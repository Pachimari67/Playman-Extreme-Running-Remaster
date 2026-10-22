import os, glob, re

script_dir = os.path.dirname(os.path.abspath(__file__))
vf_dir = os.path.join(script_dir, 'vf_separate')
out_dir = os.path.abspath(os.path.join(script_dir, '..', 'Game'))
os.makedirs(out_dir, exist_ok=True)

def fix_labeled_blocks(code):
    while True:
        m = re.search(r'\b(label\d+)\s*:\s*\{', code)
        if not m:
            break
        lbl = m.group(1)
        start = m.start()
        brace_open = m.end() - 1
        depth = 0
        pos = brace_open
        while pos < len(code):
            if code[pos] == '{':
                depth += 1
            elif code[pos] == '}':
                depth -= 1
                if depth == 0:
                    break
            pos += 1
        inner = code[brace_open:pos+1]
        replacement = inner + f'\n{lbl}_end: ;'
        code = code[:start] + replacement + code[pos+1:]
        code = re.sub(rf'\bbreak\s+{lbl}\s*;', f'goto {lbl}_end;', code)
    return code

def ends_with_jump(stmt_text):
    lines = [l.strip() for l in stmt_text.splitlines() if l.strip() and not l.strip().startswith('//')]
    if not lines:
        return True
    last = lines[-1]
    if re.match(r'^(break|return|continue|throw|goto)\b', last):
        return True
    return False

def find_next_switch(text, start_pos):
    m = re.search(r'\bswitch\s*\(', text[start_pos:])
    if not m:
        return None
    sw_start = start_pos + m.start()
    paren_open = start_pos + m.end() - 1
    p_depth = 0
    i = paren_open
    while i < len(text):
        if text[i] == '(':
            p_depth += 1
        elif text[i] == ')':
            p_depth -= 1
            if p_depth == 0:
                break
        i += 1
    brace_open = text.find('{', i + 1)
    if brace_open == -1:
        return None
    return (sw_start, brace_open)

def fix_switches(code):
    def process_switch_body(body):
        pos = 0
        new_body = []
        while True:
            found = find_next_switch(body, pos)
            if not found:
                new_body.append(body[pos:])
                break
            sw_start, b_open = found
            depth = 0
            i = b_open
            while i < len(body):
                if body[i] == '{': depth += 1
                elif body[i] == '}':
                    depth -= 1
                    if depth == 0: break
                i += 1
            inner_fixed = process_switch_body(body[b_open+1:i])
            new_body.append(body[pos:b_open+1] + inner_fixed + '}')
            pos = i + 1
        body = ''.join(new_body)

        labels = []
        depth = 0
        lines = body.splitlines(keepends=True)

        for idx, l in enumerate(lines):
            if depth == 0:
                m_case = re.match(r'^(\s*)(case\s+[^:]+|default)\s*:(.*)$', l)
                if m_case:
                    labels.append((idx, m_case.group(1), m_case.group(2).strip(), m_case.group(3)))
            for ch in l:
                if ch == '{': depth += 1
                elif ch == '}': depth -= 1

        if not labels:
            return body

        out_lines = list(lines)
        last_idx, last_indent, last_lbl, _ = labels[-1]
        after_last = ''.join(out_lines[last_idx+1:])
        if not ends_with_jump(after_last) or after_last.strip() == '':
            out_lines.append(f'{last_indent}   break;\n')

        for k in range(len(labels) - 2, -1, -1):
            curr_idx, curr_indent, curr_lbl, curr_rest = labels[k]
            next_idx, next_indent, next_lbl, _ = labels[k+1]
            between = curr_rest + '\n' + ''.join(out_lines[curr_idx+1:next_idx])
            if between.strip() != '' and not ends_with_jump(between):
                target = f'goto {next_lbl};' if next_lbl.startswith('case ') else 'goto default;'
                out_lines.insert(next_idx, f'{curr_indent}   {target}\n')

        return ''.join(out_lines)

    return process_switch_body(code)

def convert_file(filepath):
    with open(filepath, 'r', encoding='utf-8') as f:
        code = f.read()

    rel = os.path.relpath(filepath, vf_dir)

    if 'class_5.java' in rel:
        # 1. Fix Vineflower [S (short[]) vs class_6 (S) array allocations & dup_x2 post-increment in method_103
        code = code.replace('(short[][])(new class_6[var0][])', 'new short[var0][]')
        code = code.replace('(short[][])(new class_6[14][])', 'new short[14][]')
        code = code.replace('(short[][])(new class_6[12][])', 'new short[12][]')
        code = code.replace(
            'var3[var19 * var7 + var20 + 1]++;\n                                 var3[var3[var19 * var7 + var20 + 1]] = (short)var25;',
            'var3[var3[var19 * var7 + var20 + 1]++] = (short)var25;'
        )

        # 2. Fix character literals used as integer masks
        code = code.replace("(char)-1", "65535")
        code = code.replace("'耀'", "32768")
        code = code.replace("0xFF000000", "-16777216")

        # 3. Fix boolean/int JVM stack arithmetic in class_5.java
        code = code.replace('18 - field_347[field_239].field_53', '18 - (field_347[field_239].field_53 ? 1 : 0)')
        code = code.replace('9 - field_347[field_239].field_53', '9 - (field_347[field_239].field_53 ? 1 : 0)')
        code = code.replace('9 - var0.field_53', '9 - (var0.field_53 ? 1 : 0)')
        code = code.replace('var3 += var0.field_53;', 'var3 += (var0.field_53 ? 1 : 0);')
        code = code.replace('(byte)field_347[field_239].field_53', '(byte)(field_347[field_239].field_53 ? 1 : 0)')
        code = code.replace('(byte)field_347[field_239].field_54', '(byte)(field_347[field_239].field_54 ? 1 : 0)')
        code = code.replace('int var10001 = 0;\n            if ((field_357[field_358[field_239] * 14 + 8] & 16) != 0) {\n               var10001 = 1;\n            }\n\n            var10000.field_57 = (boolean)var10001;',
                            'int var10001 = 0;\n            if ((field_357[field_358[field_239] * 14 + 8] & 16) != 0) {\n               var10001 = 1;\n            }\n\n            var10000.field_57 = var10001 != 0;')
        code = code.replace(
            """      int var10000 = 0;
      if ((var0 & 16) != 0) {
         var10000 = 1;
      }

      boolean var1 = (boolean)var10000;
      var10000 = (boolean)0;
      if ((var0 & 32) != 0) {
         var10000 = (boolean)1;
      }

      boolean var2 = var10000;
      var10000 = (boolean)0;
      if ((var0 & 64) != 0) {
         var10000 = (boolean)1;
      }

      boolean var3 = var10000;""",
            """      int var10000 = 0;
      boolean var1 = (var0 & 16) != 0;
      boolean var2 = (var0 & 32) != 0;
      boolean var3 = (var0 & 64) != 0;"""
        )
        code = code.replace('int var8 = var7 != 0 ? 1 : -1;', 'int var8 = var7 ? 1 : -1;')
        code = code.replace('int var9 = var7 != 0 ? 0 : 1024;', 'int var9 = var7 ? 0 : 1024;')
        code = code.replace('var0.field_88 = 9 - var7;', 'var0.field_88 = 9 - (var7 ? 1 : 0);')
        code = code.replace('int var9 = var8 != 0 ? -1 : 1;\n      int var10 = var8 != 0 ? 1024 : 0;',
                            'int var9 = var8 ? -1 : 1;\n      int var10 = var8 ? 1024 : 0;')
        code = code.replace('var0.field_88 = var8 + 6;', 'var0.field_88 = (var8 ? 1 : 0) + 6;')
        code = code.replace('int var9 = var8 != 0 ? 1 : -1;\n      int var10 = var8 != 0 ? 0 : 1024;',
                            'int var9 = var8 ? 1 : -1;\n      int var10 = var8 ? 0 : 1024;')
        code = code.replace('var0.field_88 = 14 - var8;', 'var0.field_88 = 14 - (var8 ? 1 : 0);')
        code = code.replace(
            """   private static boolean method_257(class_3 var0, int var1, int var2, int var3, int var4, int var5, int var6, int var7, int var8, boolean var9) {
      int var10 = var9 != 0 ? -1 : 1;
      if (var4 >= var8 || var3 == var5 || (var9 != 0 || var3 != 0) && (var9 == 0 || var3 != 1024)) {
         if (var4 == 0 && var4 != var6 && (var9 == 0 && var3 < var7 || var9 != 0 && var3 > 1024 - var7)) {
            var0.field_78 = var1 + (var9 != 0 ? 1024 : 0);
            var0.field_79 = var2;
            var0.field_80 = -var10;
            var0.field_81 = -1;
            var0.field_82 = 0;
            var0.field_83 = -1024;
            var0.field_88 = var9 + 11;
            return true;
         } else {
            return false;
         }
      } else {
         var0.field_78 = var1 + (var9 != 0 ? 1024 : 0);
         var0.field_79 = var2 + var4;
         var0.field_80 = -var10;
         var0.field_81 = -1;
         var0.field_82 = -var10 * 1024;
         var0.field_83 = 0;
         var0.field_88 = var9 + 11;
         return true;
      }
   }""",
            """   private static boolean method_257(class_3 var0, int var1, int var2, int var3, int var4, int var5, int var6, int var7, int var8, boolean var9) {
      int var10 = var9 ? -1 : 1;
      if (var4 >= var8 || var3 == var5 || (var9 || var3 != 0) && (!var9 || var3 != 1024)) {
         if (var4 == 0 && var4 != var6 && (!var9 && var3 < var7 || var9 && var3 > 1024 - var7)) {
            var0.field_78 = var1 + (var9 ? 1024 : 0);
            var0.field_79 = var2;
            var0.field_80 = -var10;
            var0.field_81 = -1;
            var0.field_82 = 0;
            var0.field_83 = -1024;
            var0.field_88 = (var9 ? 1 : 0) + 11;
            return true;
         } else {
            return false;
         }
      } else {
         var0.field_78 = var1 + (var9 ? 1024 : 0);
         var0.field_79 = var2 + var4;
         var0.field_80 = -var10;
         var0.field_81 = -1;
         var0.field_82 = -var10 * 1024;
         var0.field_83 = 0;
         var0.field_88 = (var9 ? 1 : 0) + 11;
         return true;
      }
   }"""
        )
        code = code.replace(
            """   private static boolean method_261(class_3 var0, int var1, int var2, int var3, int var4, int var5, int var6, int var7, int var8, int var9, boolean var10) {
      int var11 = var10 != 0 ? -1 : 1;
      if (var4 != 0 || (var10 != 0 || var3 < var9 || var3 >= var7 + var9) && (var10 == 0 || var3 <= 1024 - var7 - var9 || var3 > 1024 - var9)) {
         if ((var10 == 0 && var3 <= var9 && var5 >= var9 || var10 != 0 && var3 >= 1024 - var9 && var5 <= 1024 - var9)
            && (var3 == var5 ? var4 : (var6 - var4) / (var5 - var3) * (var10 != 0 ? 1024 - var9 - var3 : var9 - var3) + var4) < var8) {
            var0.field_78 = var1 + (var10 != 0 ? 1024 - var9 : var9);
            int var10001 = var2 + var4;
            byte var10002 = 0;
            if (var4 < 1024) {
               var10002 = 1;
            }

            var0.field_79 = var10001 + var10002;
            var0.field_80 = -var11;
            var0.field_81 = 0;
            var0.field_82 = -var11 * 1024;
            var0.field_83 = 0;
            var0.field_88 = var10 + 11;
            return true;
         } else {
            return false;
         }
      } else {
         var0.field_78 = var1 + (var10 != 0 ? 1024 - var9 : var9);
         var0.field_79 = var2 + 1;
         var0.field_80 = -var11;
         var0.field_81 = 0;
         var0.field_82 = 0;
         var0.field_83 = -1024;
         var0.field_88 = var10 + 11;
         return true;
      }
   }""",
            """   private static boolean method_261(class_3 var0, int var1, int var2, int var3, int var4, int var5, int var6, int var7, int var8, int var9, boolean var10) {
      int var11 = var10 ? -1 : 1;
      if (var4 != 0 || (var10 || var3 < var9 || var3 >= var7 + var9) && (!var10 || var3 <= 1024 - var7 - var9 || var3 > 1024 - var9)) {
         if ((!var10 && var3 <= var9 && var5 >= var9 || var10 && var3 >= 1024 - var9 && var5 <= 1024 - var9)
            && (var3 == var5 ? var4 : (var6 - var4) / (var5 - var3) * (var10 ? 1024 - var9 - var3 : var9 - var3) + var4) < var8) {
            var0.field_78 = var1 + (var10 ? 1024 - var9 : var9);
            int var10001 = var2 + var4;
            byte var10002 = 0;
            if (var4 < 1024) {
               var10002 = 1;
            }

            var0.field_79 = var10001 + var10002;
            var0.field_80 = -var11;
            var0.field_81 = 0;
            var0.field_82 = -var11 * 1024;
            var0.field_83 = 0;
            var0.field_88 = (var10 ? 1 : 0) + 11;
            return true;
         } else {
            return false;
         }
      } else {
         var0.field_78 = var1 + (var10 ? 1024 - var9 : var9);
         var0.field_79 = var2 + 1;
         var0.field_80 = -var11;
         var0.field_81 = 0;
         var0.field_82 = 0;
         var0.field_83 = -1024;
         var0.field_88 = (var10 ? 1 : 0) + 11;
         return true;
      }
   }"""
        )

        # Fix byte loop counters that can exceed 127 (method_53 and method_54!)
        code = code.replace('for (byte var5 = 0; var5 < var2; var5 += 4)', 'for (int var5 = 0; var5 < var2; var5 += 4)')
        code = code.replace('for (byte var5 = 0; var5 < var2; var5 += 2)', 'for (int var5 = 0; var5 < var2; var5 += 2)')
        code = code.replace('for (byte var12 = 0; var12 < field_197; var12 += 4)', 'for (int var12 = 0; var12 < field_197; var12 += 4)')

        # Fix synchronization primitives not needed in single-threaded Godot main loop
        code = code.replace('synchronized (field_167) {\n         field_167.notifyAll();\n      }', '')
        code = code.replace('synchronized (field_167) {\n               try {\n                  field_167.wait(10000L);\n               } catch (Exception var4) {\n                  field_166 = (int)System.currentTimeMillis();\n               }\n            }', '')

        # Make method_66() and method_41() non-blocking and prevent method_41 from corrupting deterministic field_121
        code = code.replace(
            """   private static void method_41(int var0, int var1) {
      if (field_137) {
         method_36();
         method_301();
      }
   }""",
            """   private static void method_41(int var0, int var1) {
   }"""
        )
        # In method_200(), do not play stray checkpoint sound 3 at 13000ms when transitioning to menu, and stop all sounds on intro skip
        code = code.replace(
            """      if (field_121 - field_310 >= 13000 && field_311) {
         method_20();
         method_17(3, 128, 1);
      }""",
            """      if (field_121 - field_310 >= 13000 && field_311) {
         method_20();
      }"""
        )
        code = code.replace(
            """         } else if (field_170) {
            if (field_172 && method_63(var0, 327704)) {
               field_170 = false;
               method_16(1);
               method_73();
               method_61();
            }""",
            """         } else if (field_170) {
            if (field_172 && method_63(var0, 327704)) {
               field_170 = false;
               method_20();
               method_73();
               method_61();
            }"""
        )
        code = code.replace(
            """         do {
            try {
               Thread.yield();
            } catch (Exception var0) {
            }
         } while (!field_153);""",
            ""
        )

        # Make method_97() (name input) non-blocking and driven by StepOneTick
        code = code.replace(
            """      for (field_162 = true; !field_232 && field_164 != null; field_162 = false) {
         while (field_161) {
            try {
               Thread.sleep(100L);
            } catch (Exception var5) {
            }

            if (field_164 == null) {
               break;
            }
         }

         method_36();
         method_62();
         if (field_164 == null) {
            break;
         }

         field_165.method_65();

         do {
            field_150 = false;

            try {
               Thread.yield();
            } catch (Exception var6) {
            }
         } while (field_153 && !field_150);
      }

      field_231 = null;
      field_230 = null;
      field_225 = false;
      field_159 = var4;
      return field_224;""",
            """      NameInputPrevInGame = var4;
      return field_224;"""
        )
        code = code.replace(
            """         case 8:
            String var10 = method_169();
            method_313(field_345[field_240].field_18, field_280[6 * field_239 + 5], var10, 1 - field_339);
            field_288 = 0;
            method_180();
            return;""",
            """         case 8:
            method_169();
            return;"""
        )
        code = code.replace(
            """      String var0 = method_97(field_145[28], method_120(0), 24, 8);
      method_121(0, var0);
      field_274 = false;
      field_267 = -1;
      return var0;""",
            """      String var0 = method_97(field_145[28], method_120(0), 24, 8);
      return var0;"""
        )
        code = code.replace(
            """            if (field_337 != -1) {
               field_314[field_337] = method_97("", field_314[field_337], 24, 8);
               method_121(1 + field_337, field_314[field_337]);
               field_337 = -1;
            }""",
            """            if (field_337 != -1) {
               method_97("", field_314[field_337], 24, 8);
            }"""
        )

        # Pause/Resume music position tracking in method_70 and method_133
        code = code.replace(
            """   private static void method_70() {
      method_20();""",
            """   private static void method_70() {
      OnPauseGame?.Invoke();
      method_20();"""
        )
        code = code.replace(
            """   private static void method_133(boolean var0) {""",
            """   private static void method_133(boolean var0) {
      IsResumingFromPause = !var0;"""
        )

        # Route method_32 (triangle fill) through J2MEGraphics.fillTriangle for 2x Remaster quality
        code = code.replace(
            """   private static void method_32(int var0, int var1, int var2, int var3, int var4, int var5) {
      if (var3 < var1) {""",
            """   private static void method_32(int var0, int var1, int var2, int var3, int var4, int var5) {
      field_151.fillTriangle(var0, var1, var2, var3, var4, var5);
      if (false && var3 < var1) {"""
        )
        # Expand field_135 from 602 to 640 shorts so Options items 28, 29, 30 never collide with Main Menu item 1
        code = code.replace(
            'field_135 = new short[602];',
            'field_135 = new short[640];'
        )

        # Keep original 1x logical size for HUD (FLOW bar, score, timer, mini-flags, off-screen arrow) and in-world flags, anchored to ScreenW / ScreenH
        code = code.replace(
            'int var6 = 235 - var5 + (var5 >> 2);',
            'int var6 = (ScreenW - 5) - var5 + (var5 >> 2);'
        )
        code = code.replace(
            'method_10(var4, 235 + var7, var3 + (var5 >> 3), 24, 0);',
            'method_10(var4, (ScreenW - 5) + var7, var3 + (var5 >> 3), 24, 0);'
        )
        code = code.replace(
            'method_125(196611, 194, 36, 0);',
            'method_125(196611, ScreenW - 46, 36, 0);'
        )
        code = code.replace(
            'method_125(196612, 194, 36, 0);',
            'method_125(196612, ScreenW - 46, 36, 0);'
        )
        code = code.replace(
            """      if (var3 > 235) {
         var4 = method_138(235, var1, var2, var3, var4);
         var3 = 235;
         var11 = true;
      }

      if (var4 > 315) {
         var3 = method_137(315, var1, var2, var3, var4);
         var4 = 315;
         var10 = 1;
         var11 = true;
      }""",
            """      if (var3 > ScreenW - 5) {
         var4 = method_138(ScreenW - 5, var1, var2, var3, var4);
         var3 = ScreenW - 5;
         var11 = true;
      }

      if (var4 > ScreenH - 5) {
         var3 = method_137(ScreenH - 5, var1, var2, var3, var4);
         var4 = ScreenH - 5;
         var10 = 1;
         var11 = true;
      }"""
        )

        # Score & Combo popups in method_239
        code = code.replace(
            'method_114("" + field_345[var0].field_18, 235, 5, 24);',
            'method_114("" + field_345[var0].field_18, ScreenW - 5, 5, 24);'
        )
        code = code.replace(
            'method_114("" + field_345[var0].field_27[(var1 << 1) + 1], 120, var3, 17);',
            'method_114("" + field_345[var0].field_27[(var1 << 1) + 1], ScreenW / 2, var3, 17);'
        )
        code = code.replace(
            'method_114("" + var4, 120, var5, 17);',
            'method_114("" + var4, ScreenW / 2, var5, 17);'
        )

        # Camera centering & level bounds in world units (X: ScreenW * 16, ScreenW * 32; Y: ScreenH * 16, ScreenH * 32)
        code = code.replace('3840', '(ScreenW * 16)')
        code = code.replace('7680', '(ScreenW * 32)')
        # Replace camera Y 5120 / 10240 (preserving FLOW meter max 5120 in method_223)
        code = code.replace('if (field_343 > 5120) {\n         field_343 = 5120;\n      }', 'if (field_343 > 5120) { field_343 = 5120; } // FLOW_MAX')
        code = code.replace('- 5120', '- (ScreenH * 16)')
        code = code.replace('- 10240', '- (ScreenH * 32)')
        code = code.replace('var2 = 5888 + ((var0.field_45 * 10240 / (field_377 << 10) - (ScreenH * 16)) * 256 >> 10);',
                            'var2 = (ScreenH * 16 + 768) + ((var0.field_45 * 10240 / (field_377 << 10) - 5120) * 256 >> 10);')

        # Level & character renderer (method_105)
        # Increase field_237 capacity and bypass the 240x320 spatial grid culling (field_235) which overflowed 2000 entries in k8/k12 on widescreen!
        code = code.replace(
            'field_237 = new short[2000];',
            'field_237 = new short[16384];'
        )
        code = code.replace(
            'if (var0 + 1 == field_235) {',
            'if (false && var0 + 1 == field_235) {'
        )
        code = code.replace(
            'if (var4 < 240 && var5 < 320 && var4 + var29[var9 + 2] > 0 && var5 + var29[var9 + 3] > 0) {',
            'if (var4 < ScreenW && var5 < ScreenH && var4 + var29[var9 + 2] > 0 && var5 + var29[var9 + 3] > 0) {'
        )
        code = code.replace(
            'for (int var17 = (var16 = -var5 / 160) + 3; var16 < var17; var16++) {\n               for (int var19 = (var18 = -var4 / 120) + 3; var18 < var19; var18++) {',
            'for (int var17 = (var16 = -var5 / 160) + (ScreenH / 160 + 3); var16 < var17; var16++) {\n               for (int var19 = (var18 = -var4 / 120) + (ScreenW / 120 + 3); var18 < var19; var18++) {'
        )
        code = code.replace(
            """                  if (var54 > 240) {
                     var54 = 240;
                  }

                  if (var55 > 320) {
                     var55 = 320;
                  }

                  for (int var56 = var49; var56 < var55; var56 += var52) {
                     for (int var26 = var46; var26 < var54; var26 += var53) {
                        method_10(field_234[2] >> 3, var26, var56, 0, field_234[2] & 7);
                     }
                  }

                  method_28(0, 0, 240, 320);""",
            """                  if (var54 > ScreenW) {
                     var54 = ScreenW;
                  }

                  if (var55 > ScreenH) {
                     var55 = ScreenH;
                  }

                  for (int var56 = var49; var56 < var55; var56 += var52) {
                     for (int var26 = var46; var26 < var54; var26 += var53) {
                        method_10(field_234[2] >> 3, var26, var56, 0, field_234[2] & 7);
                     }
                  }

                  method_28(0, 0, ScreenW, ScreenH);"""
        )

        # Parallax sky, clouds, buildings, and water reflections (method_9, method_115, method_304, method_130)
        code = code.replace(
            'if (var1 < 240 && var2 < 320 && var1 + var4 >= 0 && var2 + var5 >= 0) {',
            'if (var1 < ScreenW && var2 < ScreenH && var1 + var4 >= 0 && var2 + var5 >= 0) {'
        )
        code = code.replace(
            'if (var0 < 240 && var0 + var2 >= 0 && var1 < 320 && var1 + var3 >= 0 && var2 >= 0 && var3 >= 0) {',
            'if (var0 < ScreenW && var0 + var2 >= 0 && var1 < ScreenH && var1 + var3 >= 0 && var2 >= 0 && var3 >= 0) {'
        )
        code = code.replace(
            'if (var7 >> 8 >= 320) {',
            'if (var7 >> 8 >= ScreenH) {'
        )
        code = code.replace(
            """      int var1 = 260 - (field_363 / field_377 >> 4);
      if (field_394 == 3) {
         var1 -= 32;
      }

      if (field_276 == 11) {
         var1 -= field_363 / field_377 >> 2;
      }

      method_115(0, var1 - 100, 240, 100, field_276 != 11 ? field_393[field_394 * 5 + 2] : field_295, field_393[field_394 * 5 + 1], 12);
      field_151.setColor(field_393[field_394 * 5]);
      field_151.fillRect(0, var1, 240, 320 - var1);
      if (var1 - 100 > 0) {
         field_151.setColor(field_276 != 11 ? field_393[field_394 * 5 + 2] : field_295);
         field_151.fillRect(0, 0, 240, var1 - 100);
      }

      if (field_393[field_394 * 5 + 4] != -1) {
         int var0 = -(field_362 * 240 >> 17);

         for (int var2 = 0; var2 < 3; var2++) {
            int var3 = (var0 + var2 * 5423 + (field_121 >> 9)) % 480 - 240;
            method_10(field_393[field_394 * 5 + 4], var3, var1 - 100 - var2 * 28, 36, 0);
         }
      }

      for (int var6 = -(field_362 * 240 >> 16) % 200; var6 < 240; var6 += 200) {
         method_10(field_393[field_394 * 5 + 3], var6, var1, 36, 0);
      }

      if (field_276 == 11) {
         method_130();
      }

      int var7 = -(field_362 * 240 >> 15) % 200;
      var1 = 310 - (field_363 / field_377 >> 4) - (field_363 / field_377 >> 5);
      if (field_394 == 3) {
         var1 -= 32;
      }

      if (field_276 == 11) {
         var1 -= field_363 / field_377 >> 2;
      }

      while (var7 < 240) {
         method_10(field_393[field_394 * 5 + 3] + 1, var7, var1, 36, 0);
         var7 += 200;
      }

      if (field_394 == 3 && var1 < 320) {
         for (int var8 = -(field_362 * 240 >> 15) % 200; var8 < 240; var8 += 200) {
            for (int var10 = 0; var10 < 51 && var1 + var10 < 320; var10++) {""",
            """      method_28(0, 0, ScreenW, ScreenH);
      int var1 = 260 + (ScreenH - 320) - (field_363 / field_377 >> 4);
      if (field_394 == 3) {
         var1 -= 32;
      }

      if (field_276 == 11) {
         var1 -= field_363 / field_377 >> 2;
      }

      method_115(0, var1 - 100, ScreenW, 100, field_276 != 11 ? field_393[field_394 * 5 + 2] : field_295, field_393[field_394 * 5 + 1], 12);
      field_151.setColor(field_393[field_394 * 5]);
      field_151.fillRect(0, var1, ScreenW, ScreenH - var1);
      if (var1 - 100 > 0) {
         field_151.setColor(field_276 != 11 ? field_393[field_394 * 5 + 2] : field_295);
         field_151.fillRect(0, 0, ScreenW, var1 - 100);
      }

      if (field_393[field_394 * 5 + 4] != -1) {
         int var0 = -(field_362 * 240 >> 17);
         int cloudSpan = ScreenW + 240;
         for (int var2 = 0; var2 < 6; var2++) {
            int var3 = ((var0 + var2 * 5423 + (field_121 >> 9)) % cloudSpan + cloudSpan) % cloudSpan - 240;
            method_10(field_393[field_394 * 5 + 4], var3, var1 - 100 - (var2 % 3) * 28, 36, 0);
         }
      }

      for (int var6 = -(field_362 * 240 >> 16) % 200 - 200; var6 < ScreenW; var6 += 200) {
         method_10(field_393[field_394 * 5 + 3], var6, var1, 36, 0);
      }

      if (field_276 == 11) {
         method_130();
      }

      int var7 = -(field_362 * 240 >> 15) % 200 - 200;
      var1 = 310 + (ScreenH - 320) - (field_363 / field_377 >> 4) - (field_363 / field_377 >> 5);
      if (field_394 == 3) {
         var1 -= 32;
      }

      if (field_276 == 11) {
         var1 -= field_363 / field_377 >> 2;
      }

      while (var7 < ScreenW) {
         method_10(field_393[field_394 * 5 + 3] + 1, var7, var1, 36, 0);
         var7 += 200;
      }

      if (field_394 == 3 && var1 < ScreenH) {
         for (int var8 = -(field_362 * 240 >> 15) % 200 - 200; var8 < ScreenW; var8 += 200) {
            for (int var10 = 0; var10 < 51 && var1 + var10 < ScreenH; var10++) {"""
        )

        # Full-screen Remaster Menu Layout (Playman logo on far left, House logo on far right, full-width top bars & selection bars, corner softkeys)
        code = code.replace(
            'if (var5 >= 0 && var1 <= 320) {',
            'if (var5 >= 0 && var1 <= ScreenH) {'
        )
        code = code.replace(
            '319 - method_27(0) - (24 + method_27(1))',
            '(ScreenH - 1 - method_27(0) - (24 + method_27(1)))'
        )
        code = code.replace(
            """         int var2 = 320 - (319 - method_27(1024)) >> 1;
         int var3 = 320 - var2;
         var3--;
         field_151.setColor(16777215);
         if (var0) {
            method_32(121 - var2, var3 - 1, 121, var3 - var2 - 1, 121 + var2, var3 - 1);
         }

         if (var1) {
            method_32(121 - var2, var3 + 1, 121, var3 + var2 + 1, 121 + var2, var3 + 1);
         }

         field_151.setColor(0);
         if (var0) {
            method_33(121 - var2, var3 - 1, 121, var3 - var2 - 1, 121 + var2, var3 - 1);
         }

         if (var1) {
            method_33(121 - var2, var3 + 1, 121, var3 + var2 + 1, 121 + var2, var3 + 1);
         }""",
            """         int var2 = ScreenH - (ScreenH - 1 - method_27(1024)) >> 1;
         int var3 = ScreenH - var2;
         var3--;
         int cx = ScreenW / 2 + 1;
         field_151.setColor(16777215);
         if (var0) {
            method_32(cx - var2, var3 - 1, cx, var3 - var2 - 1, cx + var2, var3 - 1);
         }

         if (var1) {
            method_32(cx - var2, var3 + 1, cx, var3 + var2 + 1, cx + var2, var3 + 1);
         }

         field_151.setColor(0);
         if (var0) {
            method_33(cx - var2, var3 - 1, cx, var3 - var2 - 1, cx + var2, var3 - 1);
         }

         if (var1) {
            method_33(cx - var2, var3 + 1, cx, var3 + var2 + 1, cx + var2, var3 + 1);
         }"""
        )
        code = code.replace(
            """         int var7 = 120 - var6;
         int var8 = 120 + var6;
         int var9 = (var5 & 1) != 0 ? var5 : var5 + 1;
         boolean var10 = false;
         if (var7 - var9 < 0) {
            var7 = var9;
            var10 = true;
         }

         if (var8 + var9 >= 240) {
            var8 = 240 - var9;
            var10 = true;
         }""",
            """         int var7 = (ScreenW / 2) - var6;
         int var8 = (ScreenW / 2) + var6;
         int var9 = (var5 & 1) != 0 ? var5 : var5 + 1;
         boolean var10 = false;
         if (var7 - var9 < 0) {
            var7 = var9;
            var10 = true;
         }

         if (var8 + var9 >= ScreenW) {
            var8 = ScreenW - var9;
            var10 = true;
         }"""
        )
        code = code.replace(
            """         if (var0 != -1) {
            method_23(1024, field_145[var0], 3, 319 - method_27(1024), 20);
         }

         if (var1 != -1) {
            method_23(1024, field_145[var1], 237, 319 - method_27(1024), 24);
         }""",
            """         if (var0 != -1) {
            method_23(1024, field_145[var0], 3, ScreenH - 1 - method_27(1024), 20);
         }

         if (var1 != -1) {
            method_23(1024, field_145[var1], ScreenW - 3, ScreenH - 1 - method_27(1024), 24);
         }"""
        )
        code = code.replace(
            """   private static void method_87() {
      method_28(0, 0, 240, 320);""",
            """   private static void method_87() {
      method_28(0, 0, ScreenW, ScreenH);"""
        )
        code = code.replace(
            'method_93(1024, 7, var17, field_190 * field_205);',
            'method_93(1024, MenuOffsetX + 7, var17, field_190 * field_205);'
        )
        code = code.replace(
            'method_93(1024, 7, 24 + method_27(1), field_187);',
            'method_93(1024, MenuOffsetX + 7, 24 + method_27(1), field_187);'
        )
        code = code.replace(
            """                  int var13 = 120;
                  if (var8 == 5) {
                     var5 = var5 + " : ";
                     int var14;
                     int var15 = (var14 = method_24(1024, var5)) + method_89();
                     int var16;
                     var13 = (var16 = 120 - (var15 >> 1) + var14) - (var14 >> 1);""",
            """                  int var13 = ScreenW / 2;
                  if (var8 == 5) {
                     var5 = var5 + " : ";
                     int var14;
                     int var15 = (var14 = method_24(1024, var5)) + method_89();
                     int var16;
                     var13 = (var16 = (ScreenW / 2) - (var15 >> 1) + var14) - (var14 >> 1);"""
        )
        code = code.replace(
            """   private static int method_140(String var0) {
      int var1 = method_27(0) + 2;
      field_151.setColor(2758677);
      field_151.drawRect(-1, -1, 241, var1 + 1);
      field_151.setColor(16728334);
      field_151.fillRect(0, 0, 240, var1);
      field_151.setColor(9510656);
      method_23(0, var0, 120, 1, 17);
      return var1 + 1;
   }""",
            """   private static int method_140(String var0) {
      int var1 = method_27(0) + 2;
      field_151.setColor(2758677);
      field_151.drawRect(-1, -1, ScreenW + 1, var1 + 1);
      field_151.setColor(16728334);
      field_151.fillRect(0, 0, ScreenW, var1);
      field_151.setColor(9510656);
      method_23(0, var0, ScreenW / 2, 1, 17);
      return var1 + 1;
   }"""
        )
        code = code.replace(
            """      field_151.drawRect(-1, var0 - 1, 241, var5 + 1);
      if (!var2) {
         if (var3) {
            field_151.setColor(2758677);
         } else {
            field_151.setColor(7430492);
         }
      } else {
         field_151.setColor(16728334);
      }

      field_151.fillRect(0, var0, 240, var5);
      if (var4) {
         method_142(var0 + (var5 >> 1), 120, 120);
      }

      if (var1 != null) {
         int var6 = 0;
         if (var4) {
            var6 = (var6 = method_147() * 240 >> 8) < 240 ? var6 : 240;
            int var10000 = 0;
            if (var6 >= 0) {
               var10000 = var6;
            }

            var6 = var10000;
            var6 = 240 - var6;
         }

         field_151.setColor(16777215);
         method_23(0, var1, method_148() < 0 ? 120 - var6 : 120 + var6, var0 + 1, 17);
      }""",
            """      field_151.drawRect(-1, var0 - 1, ScreenW + 1, var5 + 1);
      if (!var2) {
         if (var3) {
            field_151.setColor(2758677);
         } else {
            field_151.setColor(7430492);
         }
      } else {
         field_151.setColor(16728334);
      }

      field_151.fillRect(0, var0, ScreenW, var5);
      if (var4) {
         method_142(var0 + (var5 >> 1), ScreenW / 2, ScreenW / 2);
      }

      if (var1 != null) {
         int var6 = 0;
         if (var4) {
            var6 = (var6 = method_147() * ScreenW >> 8) < ScreenW ? var6 : ScreenW;
            int var10000 = 0;
            if (var6 >= 0) {
               var10000 = var6;
            }

            var6 = var10000;
            var6 = ScreenW - var6;
         }

         field_151.setColor(16777215);
         method_23(0, var1, method_148() < 0 ? (ScreenW / 2) - var6 : (ScreenW / 2) + var6, var0 + 1, 17);
      }"""
        )
        code = code.replace(
            """      if (field_176[field_179] != 11) {
         if (field_171 && field_170) {
            field_151.setColor(16728334);
            field_151.fillRect(0, 0, 240, 320);
         } else {
            if (field_176[field_179] != 0 && field_176[field_179] != 2) {
               field_151.setColor(12102307);
            } else {
               field_151.setColor(16728334);
            }

            field_151.fillRect(0, 0, 240, 320);
            if (field_159 || !field_158) {
               if (field_176[field_179] == 0) {
                  method_10(154, 240, 320, 40, 0);
               } else if (field_176[field_179] < 12 && field_176[field_179] > 14) {
                  method_10(153, 240, 320, 40, 0);
               }
            }

            if (!field_171 && field_176[field_179] != 8 && field_176[field_179] != 9 && field_176[field_179] != 10 && field_176[field_179] != 3) {
               field_151.setColor(2758677);
               field_151.fillRect(0, field_189 - 1, 240, field_189 + method_27(1024) - field_189 + 2);
            }""",
            """      if (field_176[field_179] != 11) {
         if (field_171 && field_170) {
            field_151.setColor(16728334);
            field_151.fillRect(0, 0, ScreenW, ScreenH);
         } else {
            if (field_176[field_179] != 0 && field_176[field_179] != 2) {
               field_151.setColor(12102307);
            } else {
               field_151.setColor(16728334);
            }

            field_151.fillRect(0, 0, ScreenW, ScreenH);
            if (field_159 || !field_158) {
               if (field_176[field_179] == 0) {
                  method_10(154, ScreenW, ScreenH, 40, 0);
               } else if (field_176[field_179] < 12 && field_176[field_179] > 14) {
                  method_10(153, ScreenW, ScreenH, 40, 0);
               }
            }

            if (!field_171 && field_176[field_179] != 8 && field_176[field_179] != 9 && field_176[field_179] != 10 && field_176[field_179] != 3) {
               field_151.setColor(2758677);
               field_151.fillRect(0, field_189 - 1, ScreenW, field_189 + method_27(1024) - field_189 + 2);
            }"""
        )

        # Submenus: Moves (method_196/198), Character Select (method_209), Level/Mission/Multiplayer (method_210, method_216, method_219, method_220)
        # Center Character Select (method_209) and Level Select with icons (method_210) in the middle of the screen in Remaster mode!
        code = code.replace(
            'method_94(0, var3 + field_145[field_304[field_303 * 3 + 2]], 0, var2, 240, 320 - var2 - method_27(1024), 4, 4, 8, true);',
            'method_94(0, var3 + field_145[field_304[field_303 * 3 + 2]], MenuOffsetX, var2, 240, ScreenH - var2 - method_27(1024), 4, 4, 8, true);'
        )
        code = code.replace(
            """      field_151.setColor(12102307);
      field_151.fillRect(0, 0, 240, 320);
      int var0;
      var0 = (var0 = method_140(field_145[85])) + method_144(var0, field_145[31 + field_303], false, false, true);
      method_28(0, var0, 240, 320 - var0);
      method_93(field_221, field_218, field_219, field_222);
      method_28(0, 0, 240, 320);""",
            """      field_151.setColor(12102307);
      field_151.fillRect(0, 0, ScreenW, ScreenH);
      int var0;
      var0 = (var0 = method_140(field_145[85])) + method_144(var0, field_145[31 + field_303], false, false, true);
      method_28(0, var0, ScreenW, ScreenH - var0);
      method_93(field_221, field_218, field_219, field_222);
      method_28(0, 0, ScreenW, ScreenH);"""
        )
        code = code.replace(
            """      var0 += 45;
      short var3 = 161;
      short var4 = 160;
      byte var5 = 0;
      if (field_339 == 0) {
         var3 = 159;
         var5 = 51;
         method_10(67, 76, var0 + 51, 3, 0);
      }

      method_10(var3, 76, var0, 3, 0);
      if (field_339 == 1) {
         var4 = 158;
         var5 = 54;
         method_10(66, 159, var0 + 54, 3, 0);
      }

      method_10(var4, 159, var0, 3, 0);
      var0 += var5 * 5 / 4;
      if (field_324) {
         method_94(1024, field_339 == 0 ? field_145[128] : field_145[129], 0, var0, 240, 320 - (var0 + method_27(1024) + 4), 1, 1, 8, true);""",
            """      var0 += 45 + (UseRemasterMode ? 75 : 0);
      short var3 = 161;
      short var4 = 160;
      byte var5 = 0;
      if (field_339 == 0) {
         var3 = 159;
         var5 = 51;
         method_10(67, (ScreenW / 2) - 44, var0 + 51, 3, 0);
      }

      method_10(var3, (ScreenW / 2) - 44, var0, 3, 0);
      if (field_339 == 1) {
         var4 = 158;
         var5 = 54;
         method_10(66, (ScreenW / 2) + 39, var0 + 54, 3, 0);
      }

      method_10(var4, (ScreenW / 2) + 39, var0, 3, 0);
      var0 += var5 * 5 / 4;
      if (field_324) {
         method_94(1024, field_339 == 0 ? field_145[128] : field_145[129], MenuOffsetX, var0, 240, ScreenH - (var0 + method_27(1024) + 4), 1, 1, 8, true);"""
        )
        code = code.replace(
            'var4 = (320 - field_330 - (method_27(1024) + 4 + 2 + method_27(0) * 3)) / field_330;',
            'var4 = (ScreenH - field_330 - (method_27(1024) + 4 + 2 + method_27(0) * 3)) / field_330;'
        )
        code = code.replace(
            'int var8 = 120 - field_329 / 2;\n               int var9 = 2 + field_330 * var7 + method_27(0);',
            'int var8 = (ScreenW / 2) - field_329 / 2;\n               int var9 = (UseRemasterMode ? 35 : 0) + 2 + field_330 * var7 + method_27(0);'
        )
        code = code.replace(
            'if (var9 > 320 - (method_27(1024) + 4) - field_330) {',
            'if (var9 > ScreenH - (method_27(1024) + 4) - field_330) {'
        )
        code = code.replace(
            'method_208(0, var9, 240, field_330 - field_328 / 2, false, 16777215, 7430492);',
            'method_208(0, var9, ScreenW, field_330 - field_328 / 2, false, 16777215, 7430492);'
        )
        code = code.replace(
            'method_208(0, var9, 240, field_330 - field_328 / 2, false, 16777215, 2758677);',
            'method_208(0, var9, ScreenW, field_330 - field_328 / 2, false, 16777215, 2758677);'
        )
        code = code.replace(
            'method_23(1024, field_145[25], 120, var9 + field_328 / 4, 17);',
            'method_23(1024, field_145[25], ScreenW / 2, var9 + field_328 / 4, 17);'
        )
        code = code.replace(
            'method_142(var9 + field_330 / 2 - field_328 / 4, 120, 120);',
            'method_142(var9 + field_330 / 2 - field_328 / 4, ScreenW / 2, 120);'
        )
        code = code.replace(
            'method_23(1024, method_60(field_145[146], "" + field_336, 1), 120, var9 + field_328 / 4, 17);',
            'method_23(1024, method_60(field_145[146], "" + field_336, 1), ScreenW / 2, var9 + field_328 / 4, 17);'
        )
        code = code.replace(
            'int var18 = var16 + (120 - var51);\n                  int var19 = var17 - var52 + var21 + var21 / 16 + 1 + 25;',
            'int var18 = var16 + ((ScreenW / 2) - var51);\n                  int var19 = var17 - var52 + var21 + var21 / 16 + 1 + 25 + (UseRemasterMode ? 75 : 0);'
        )
        code = code.replace(
            """               int var36 = 0;
               var36 = (var36 = method_147() * 240 >> 8) < 240 ? var36 : 240;
               int var58 = 0;
               if (var36 >= 0) {
                  var58 = var36;
               }

               var36 = var58;
               var36 = 240 - var36;
               var1 += 6;
               method_207(field_321, -1, var1, method_148() < 0 ? 120 - var36 : 120 + var36);
               var1 += 62;
               var1 += var32;
            } else if (field_318 == 2) {
               var1 += 6;
               method_207(field_321, field_322, var1, 120);""",
            """               int var36 = 0;
               var36 = (var36 = method_147() * ScreenW >> 8) < ScreenW ? var36 : ScreenW;
               int var58 = 0;
               if (var36 >= 0) {
                  var58 = var36;
               }

               var36 = var58;
               var36 = ScreenW - var36;
               var1 += 6 + (UseRemasterMode ? 75 : 0);
               method_207(field_321, -1, var1, method_148() < 0 ? (ScreenW / 2) - var36 : (ScreenW / 2) + var36);
               var1 += 62;
               var1 += var32;
            } else if (field_318 == 2) {
               var1 += 6 + (UseRemasterMode ? 75 : 0);
               method_207(field_321, field_322, var1, ScreenW / 2);"""
        )
        code = code.replace(
            """               if (field_318 == 0 && field_324 && var33 >= 65536) {
                  int var46;
                  if ((var46 = 320 - (var1 + method_27(1024) + 4)) < field_108.getHeight()) {
                     var1 -= field_108.getHeight() - var46;
                     var46 = field_108.getHeight();
                  }

                  method_94(1024, var42, 0, var1, 240, var46, 0, 0, 8, true);""",
            """               if (field_318 == 0 && field_324 && var33 >= 65536) {
                  int var46;
                  if ((var46 = ScreenH - (var1 + method_27(1024) + 4)) < field_108.getHeight()) {
                     var1 -= field_108.getHeight() - var46;
                     var46 = field_108.getHeight();
                  }

                  method_94(1024, var42, MenuOffsetX, var1, 240, var46, 0, 0, 8, true);"""
        )
        code = code.replace(
            """               if (field_318 == 0) {
                  field_151.setColor(16777215);
                  method_28(0, field_215, 240, field_217);
                  method_93(field_221, field_218, field_219, field_222);
                  method_28(0, 0, 240, 320);""",
            """               if (field_318 == 0) {
                  field_151.setColor(16777215);
                  method_28(0, field_215, ScreenW, field_217);
                  method_93(field_221, field_218, field_219, field_222);
                  method_28(0, 0, ScreenW, ScreenH);"""
        )
        code = code.replace(
            """                  if ((var50 = field_215 + var1 + (320 - (field_215 + var1 + method_27(1024) + 4)) / 2) > 320 - (method_27(1024) + 4)) {
                     var50 = 320 - (method_27(1024) + 4);
                  }

                  field_151.setColor(4864053);
                  method_23(0, var42, 240 - (field_121 - field_317 >> 4) % (var47 + 240), var50, 36);""",
            """                  if ((var50 = field_215 + var1 + (ScreenH - (field_215 + var1 + method_27(1024) + 4)) / 2) > ScreenH - (method_27(1024) + 4)) {
                     var50 = ScreenH - (method_27(1024) + 4);
                  }

                  field_151.setColor(4864053);
                  method_23(0, var42, ScreenW - (field_121 - field_317 >> 4) % (var47 + ScreenW), var50, 36);"""
        )
        code = code.replace(
            'method_94(0, var1, 0, var0, 240, 320 - (var0 + method_27(1024) + 4 + method_141() * 2), 0, 0, 8, true);',
            'method_94(0, var1, MenuOffsetX, var0, 240, ScreenH - (var0 + method_27(1024) + 4 + method_141() * 2), 0, 0, 8, true);'
        )
        code = code.replace(
            """      method_28(0, method_141() * 2, 240, 320 - (method_141() * 2 + method_27(1024) + 4));

      for (int var3 = 0; var3 < field_199 / 3; var3++) {
         field_151.setColor((var3 & 1) == 0 ? 9667196 : 12102307);
         int var4 = field_195[var3 * 3 + 1] + method_141() * 2 - field_195[field_257 * 3 + 1];
         field_151.fillRect(0, var4, 240, field_195[var3 * 3 + 2]);
         if (var0 != 14 && var3 > 0 && (var3 & 1) == 0) {
            field_151.setColor(16777215);
            field_151.fillRect(0, var4, 240, 1);
         }
      }

      method_93(field_221, field_218, field_219, field_222);
      method_28(0, 0, 240, 320);""",
            """      method_28(0, method_141() * 2, ScreenW, ScreenH - (method_141() * 2 + method_27(1024) + 4));

      for (int var3 = 0; var3 < field_199 / 3; var3++) {
         field_151.setColor((var3 & 1) == 0 ? 9667196 : 12102307);
         int var4 = field_195[var3 * 3 + 1] + method_141() * 2 - field_195[field_257 * 3 + 1];
         field_151.fillRect(0, var4, ScreenW, field_195[var3 * 3 + 2]);
         if (var0 != 14 && var3 > 0 && (var3 & 1) == 0) {
            field_151.setColor(16777215);
            field_151.fillRect(0, var4, ScreenW, 1);
         }
      }

      method_93(field_221, field_218, field_219, field_222);
      method_28(0, 0, ScreenW, ScreenH);"""
        )
        code = code.replace(
            'method_94(0, var1, 0, method_141() * 2, 240, 320 - (method_141() * 2 + method_27(1024) + 4), 1, 1, 8, true);',
            'method_94(0, var1, MenuOffsetX, method_141() * 2, 240, ScreenH - (method_141() * 2 + method_27(1024) + 4), 1, 1, 8, true);'
        )

        # Prize screen (field_276 == 11) fixes:
        # 1) Esc and Select both exit Prize screen (no Pause menu in Prize screen)
        # 2) Loop Prize music (Sound 2 with var2 = 0 -> LoopCount = -1)
        # 3) Center Prize camera & fireworks and fix F2 in Prize screen
        code = code.replace(
            """      if (field_276 == 11) {
         if (method_63(var0, 262152)) {
            method_20();
            method_328();
            return;
         }

         if (field_292 >= 6) {
            boolean var1 = method_63(var0, 131072);
            boolean var2 = method_63(var0, 131074);
            if (var1) {
               method_95(4);
            }

            if (var2) {
               method_95(2);
            }
         }
      }""",
            """      if (field_276 == 11) {
         if (method_63(var0, 262152) || method_63(var0, 131094)) {
            method_20();
            method_328();
            return;
         }

         if (field_292 >= 6) {
            boolean var1 = method_63(var0, 131072);
            boolean var2 = method_63(var0, 131074);
            if (var1) {
               method_95(4);
            }

            if (var2) {
               method_95(2);
            }
         }
         return;
      }"""
        )
        code = code.replace(
            """            int var2 = 120 + field_248[var0] + 32 * field_249[var0] * (var1 * var1 / 1000) / 100000;
            int var3 = 320 - var1 * 32 / 620 + (method_106(field_249[var0]) + 7) * var1 * var1 / 4000000;""",
            """            int var2 = (ScreenW / 2) + field_248[var0] + 32 * field_249[var0] * (var1 * var1 / 1000) / 100000;
            int var3 = ScreenH - var1 * 32 / 620 + (method_106(field_249[var0]) + 7) * var1 * var1 / 4000000;"""
        )
        code = code.replace(
            """            method_281(49408, -2048);
            method_94(1024, field_145[156], 12, 52, 216, 319 - method_27(1024) - 36 - 32, 12, 16, 8, true);
            field_267 = -1;
            field_135[568] = 2;
            field_135[532] = 0;
            field_135[556] = 2;
            field_290 = false;
            method_20();
            method_17(2, 128, 1);""",
            """            method_281(53248 - (ScreenW * 16), -2048);
            FormatPrizeText();
            field_267 = -1;
            field_135[568] = 2;
            field_135[532] = 0;
            field_135[556] = 2;
            field_290 = false;
            method_20();
            method_17(2, 128, 0);"""
        )
        code = code.replace(
            'method_281(49408, method_287(-2048, -10240, var4 - 6000, 3000));',
            'method_281(53248 - (ScreenW * 16), method_287(-2048, -10240, var4 - 6000, 3000));'
        )
        code = code.replace(
            'method_281(49408, -10240);',
            'method_281(53248 - (ScreenW * 16), -10240);'
        )
        code = code.replace(
            'method_23(1024, field_145[157], 120, 34, 33);',
            'method_23(1024, field_145[157], ScreenW / 2, MenuOffsetY + 34, 33);'
        )
        code = code.replace(
            """                  if (field_106[var4] instanceof Player) {
                     if (var2 != 1) {
                        try {
                           ((Player)field_106[var4]).setLoopCount(var2 == 0 ? -1 : var2);
                        } catch (Exception var6) {
                        }
                     }""",
            """                  if (field_106[var4] instanceof Player) {
                     try {
                        ((Player)field_106[var4]).setLoopCount(var2 == 0 ? -1 : var2);
                     } catch (Exception var6) {
                     }"""
        )

        # In-game dialogs (method_167, method_172, method_302) and Intro (method_201)
        code = code.replace(
            'method_94(0, var1, 4, var6, 232, 240, 4, 4, 8, true);',
            'method_94(0, var1, MenuOffsetX + 4, MenuOffsetY + var6, 232, 240, 4, 4, 8, true);'
        )
        code = code.replace(
            'method_23(0, field_145[field_275], 120, var5 - var0 + 4, 17);',
            'method_23(0, field_145[field_275], ScreenW / 2, var5 - var0 + 4, 17);'
        )
        code = code.replace(
            """      field_151.setColor(16728334);
      field_151.fillRect(0, 0, 240, 320);
      field_112 = 0;
      field_151.setColor(16777215);
      method_23(1024, field_145[18], 120, 160, 33);
      int var2 = method_24(1024, field_145[18]);
      int var3 = 120 - var2 / 2;""",
            """      field_151.setColor(16728334);
      field_151.fillRect(0, 0, ScreenW, ScreenH);
      field_112 = 0;
      field_151.setColor(16777215);
      method_23(1024, field_145[18], ScreenW / 2, ScreenH / 2, 33);
      int var2 = method_24(1024, field_145[18]);
      int var3 = (ScreenW / 2) - var2 / 2;"""
        )
        code = code.replace(
            """         field_151.setColor(0);
         field_151.fillRect(var3 + var4 - 1, 165, 8, 8);
         field_151.setColor(16777215);
         field_151.fillRect(var3 + var4, 166, 6, 6);""",
            """         field_151.setColor(0);
         field_151.fillRect(var3 + var4 - 1, (ScreenH / 2) + 5, 8, 8);
         field_151.setColor(16777215);
         field_151.fillRect(var3 + var4, (ScreenH / 2) + 6, 6, 6);"""
        )
        code = code.replace(
            """      field_151.setColor(var1);
      field_151.fillRect(0, 0, 240, 320);
      int var2 = 320;
      if (var0 < 250) {
         var2 += 115;
      } else if (var0 < 750) {
         var2 = 320 + 115 * (250000 - (var0 - 250) * (var0 - 250)) / 250000;
      }

      method_10(154, 240, var2, 40, 0);
      if (var0 >= 1000 && var0 < 2500) {
         int var3 = 120;
         if (var0 >= 2000) {
            int var5 = var0 - 2000;
            boolean var6 = false;
            var3 = 120 + 173 * var5 / 3 * (-5 * var5 + 1000) / (500 * 500);
         }

         method_10(152, var3, 160, 3, 0);
      }

      if (var0 >= 3500 && var0 < 5000) {
         int var17 = 120;
         if (var0 >= 4500) {
            int var18 = var0 - 4500;
            var17 = 120 + 173 * var18 / 3 * (-5 * var18 + 1000) / (500 * 500);
         }

         method_10(151, var17, 160, 3, 0);
      }""",
            """      field_151.setColor(var1);
      field_151.fillRect(0, 0, ScreenW, ScreenH);
      int var2 = ScreenH;
      if (var0 < 250) {
         var2 += 115;
      } else if (var0 < 750) {
         var2 = ScreenH + 115 * (250000 - (var0 - 250) * (var0 - 250)) / 250000;
      }

      method_10(154, ScreenW, var2, 40, 0);
      if (var0 >= 1000 && var0 < 2500) {
         int var3 = ScreenW / 2;
         if (var0 >= 2000) {
            int var5 = var0 - 2000;
            boolean var6 = false;
            var3 = (ScreenW / 2) + 173 * var5 / 3 * (-5 * var5 + 1000) / (500 * 500);
         }

         method_10(152, var3, ScreenH / 2, 3, 0);
      }

      if (var0 >= 3500 && var0 < 5000) {
         int var17 = ScreenW / 2;
         if (var0 >= 4500) {
            int var18 = var0 - 4500;
            var17 = (ScreenW / 2) + 173 * var18 / 3 * (-5 * var18 + 1000) / (500 * 500);
         }

         method_10(151, var17, ScreenH / 2, 3, 0);
      }"""
        )
        code = code.replace(
            """         if (var12) {
            method_10(157, var19 + 59, var20 + 160 - 23 + 4, 33, 0);
         }

         if (var13) {
            method_10(155, var7 + 88, var8 + 160, 3, 0);
         }

         if (var14) {
            method_10(156, var9 + 147, var10 + 160 + 23 - 7, 17, 0);
         }

         if (var0 >= 7000) {
            method_10(159, 120 + var19 - 37 - 24, 248, 33, 0);
         }

         if (var0 >= 7000) {
            method_10(158, 169, 160 + var11 + 21, 33, 0);
         }""",
            """         if (var12) {
            method_10(157, MenuOffsetX + var19 + 59, var20 + (ScreenH / 2) - 23 + 4, 33, 0);
         }

         if (var13) {
            method_10(155, MenuOffsetX + var7 + 88, var8 + (ScreenH / 2), 3, 0);
         }

         if (var14) {
            method_10(156, MenuOffsetX + var9 + 147, var10 + (ScreenH / 2) + 23 - 7, 17, 0);
         }

         if (var0 >= 7000) {
            method_10(159, (ScreenW / 2) + var19 - 37 - 24, MenuOffsetY + 248, 33, 0);
         }

         if (var0 >= 7000) {
            method_10(158, MenuOffsetX + 169, (ScreenH / 2) + var11 + 21, 33, 0);
         }"""
        )

        # Tag Player with SoundId in method_14 and method_17, and add Mode (28), Screen (29), and Language (30) ONLY to Options menu (var0 == 1)
        code = code.replace(
            """            for (int var1 = 0; var1 < 200; var1++) {
               field_145[var1] = field_141.readUTF();
            }

            method_48();""",
            """            for (int var1 = 0; var1 < 200; var1++) {
               field_145[var1] = field_141.readUTF();
            }

            method_48();
            Localization.ApplyLanguage(field_145, CurrentLanguageIndex);"""
        )
        code = code.replace(
            'field_106[var7] = Manager.createPlayer(new ByteArrayInputStream(var8), method_11(var5));',
            'field_106[var7] = Manager.createPlayer(new ByteArrayInputStream(var8), method_11(var5));\n                           ((Player)field_106[var7]).SoundId = var4;'
        )
        code = code.replace(
            '((Player)field_106[var4]).setMediaTime(0L);\n                     ((Player)field_106[var4]).start();',
            '((Player)field_106[var4]).SoundId = var0;\n                     ((Player)field_106[var4]).setMediaTime(0L);\n                     ((Player)field_106[var4]).start();'
        )
        code = code.replace(
            'field_104 = Manager.createPlayer(new ByteArrayInputStream((byte[])field_106[var4]), method_11(var3));',
            'field_104 = Manager.createPlayer(new ByteArrayInputStream((byte[])field_106[var4]), method_11(var3));\n                     field_104.SoundId = var0;'
        )
        code = code.replace(
            """               field_181++;
            }
         }""",
            """               field_181++;
               if (var0 == 1 && var4 == 6) {
                  field_135[490 + 28 * 4] = 6;
                  field_135[490 + 28 * 4 + 1] = 0;
                  field_135[490 + 28 * 4 + 2] = 0;
                  field_135[490 + 28 * 4 + 3] = 0;
                  field_178[field_181++] = 28;

                  field_135[490 + 29 * 4] = 6;
                  field_135[490 + 29 * 4 + 1] = 0;
                  field_135[490 + 29 * 4 + 2] = 0;
                  field_135[490 + 29 * 4 + 3] = 0;
                  field_178[field_181++] = 29;

                  field_135[490 + 30 * 4] = 6;
                  field_135[490 + 30 * 4 + 1] = 0;
                  field_135[490 + 30 * 4 + 2] = 0;
                  field_135[490 + 30 * 4 + 3] = 0;
                  field_178[field_181++] = 30;
               }
            }
         }"""
        )
        code = code.replace(
            'String var5 = field_145[var11];',
            'String var5 = (var7 == 28 * 4) ? Localization.GetModeOptionLine(CurrentLanguageIndex, UseRemasterMode) : ((var7 == 29 * 4) ? Localization.GetScreenOptionLine(CurrentLanguageIndex, WindowModeIndex) : ((var7 == 30 * 4) ? Localization.GetLanguageOptionLine(CurrentLanguageIndex) : field_145[var11]));'
        )
        code = code.replace(
            'if (var8 == 4) {\n                        var1 = 6;',
            'if (var8 == 4 || var8 == 6) {\n                        var1 = 6;'
        )
        code = code.replace(
            'int var10002 = method_24(1024, field_145[field_135[490 + (var7 >> 2) * 4 + 3]] + (var8 == 5 ? " : " : ""));',
            'int var10002 = method_24(1024, var8 == 6 ? var5 : (field_145[field_135[490 + (var7 >> 2) * 4 + 3]] + (var8 == 5 ? " : " : "")));'
        )
        code = code.replace(
            '   private static void method_77(int var0, int var1) {',
            """   private static void method_77(int var0, int var1) {
      if (var0 == 28) {
         OnModeChanged?.Invoke();
         method_17(20, 128, 1);
         return;
      }
      if (var0 == 29) {
         WindowModeIndex = (WindowModeIndex + (var1 == 3 ? 2 : 1)) % 3;
         OnWindowModeChanged?.Invoke(WindowModeIndex);
         method_17(20, 128, 1);
         return;
      }
      if (var0 == 30) {
         int langCount = Localization.LanguageNames.Length;
         CurrentLanguageIndex = (CurrentLanguageIndex + (var1 == 3 ? langCount - 1 : 1)) % langCount;
         if (field_133 != null && field_133.Length > 2) {
            field_133[2] = (sbyte)CurrentLanguageIndex;
            method_38();
         }
         Localization.ApplyLanguage(field_145, CurrentLanguageIndex);
         OnSettingsChanged?.Invoke();
         method_17(20, 128, 1);
         return;
      }"""
        )

        # Add deterministic StepOneTick(int deltaMs), UnlockAllLevelsCheat() (F11), and ResetAllProgress() (F12) to class_5
        helper_methods = """
   public static int ScreenW => Displayable.ConfiguredWidth;
   public static int ScreenH => Displayable.ConfiguredHeight;
   public static int MenuOffsetX => (Displayable.ConfiguredWidth - 240) / 2;
   public static int MenuOffsetY => (Displayable.ConfiguredHeight - 320) / 2;
   public static bool NameInputPrevInGame = false;
   public static int DeterministicDeltaMs = 30;
   public static bool UseRemasterMode = true;
   public static bool IsResumingFromPause = false;
   public static int CurrentLanguageIndex = 0;
   public static int WindowModeIndex = 1; // Default 1 = Borderless ("не в полном экране без рамок")
   public static Action OnPauseGame;
   public static Action OnModeChanged;
   public static Action<int> OnWindowModeChanged;
   public static Action OnSettingsChanged;

   public static void FormatPrizeText() {
      int boxW = UseRemasterMode ? 520 : 216;
      int boxX = UseRemasterMode ? ((ScreenW - boxW) / 2) : (MenuOffsetX + 12);
      int boxY = MenuOffsetY + 52;
      int boxH = ScreenH - method_27(1024) - boxY - 16;
      int savedPage = field_222;
      method_94(1024, field_145[156], boxX, boxY, boxW, boxH, 12, 16, 8, true);
      field_222 = Math.Clamp(savedPage, 0, Math.Max(0, field_198 - 1));
   }

   public static Player GetActiveMusicPlayer() {
      if (field_159 && field_276 == 11 && field_106 != null && field_135 != null) {
         short idx = field_135[380 + 2];
         if (idx >= 0 && idx < field_106.Length && field_106[idx] is Player prizePlayer) {
            return prizePlayer;
         }
      }
      return field_104;
   }

   public static void RecenterLayoutForResolutionChange() {
      field_188 = (ScreenH - 1 - method_27(0) - (24 + method_27(1))) / method_27(1024);
      if (!field_159 && !field_170 && field_179 >= 0) {
         int savedSel = field_180;
         int savedScroll = field_184;
         field_324 = true;
         method_81();
         field_180 = Math.Clamp(savedSel, 0, Math.Max(0, field_181 - 1));
         field_184 = Math.Clamp(savedScroll, 0, Math.Max(0, field_181 - 1));
      } else if (field_159 && field_276 == 11) {
         FormatPrizeText();
         field_362 = Math.Clamp(53248 - ScreenW * 16, 0, Math.Max(0, (field_376 << 10) - ScreenW * 32));
         field_364 = field_362;
         return;
      } else if (field_159 && field_267 != -1 && field_191 != null) {
         int savedPage = field_222;
         int var6 = field_271 > 0 ? (4 + field_108.getHeight() + 8) : 4;
         method_94(0, field_191, MenuOffsetX + 4, MenuOffsetY + var6, 232, 240, 4, 4, 8, true);
         field_222 = Math.Clamp(savedPage, 0, Math.Max(0, field_198 - 1));
      }
      if (field_159 && field_347 != null && field_347[field_240] != null) {
         var p = field_347[field_240];
         field_362 = Math.Clamp(p.field_44 - ScreenW * 16, 0, Math.Max(0, (field_376 << 10) - ScreenW * 32));
         field_363 = Math.Min(p.field_45 - ScreenH * 16, (field_377 << 10) - ScreenH * 32);
         field_364 = field_362;
         field_365 = field_363;
      }
   }

   public void InitGame() {
      field_137 = false;
      field_153 = true;
      method_39();
      method_67();
      field_158 = false;
      field_159 = false;
      field_160 = false;
      field_162 = false;
      field_225 = false;
      field_139 = false;
      field_161 = false;
      method_73();
      method_61();
      field_165.method_65();
   }

   public void StepOneTick(int deltaMs) {
      DeterministicDeltaMs = deltaMs;
      field_168 = false;

      // Advance game timer deterministically at native 33.3 FPS (30 ms per step)
      field_120++;
      field_128 = field_121;
      field_123 = deltaMs;
      field_121 += deltaMs;
      field_127 = field_121;
      if (field_159 && !field_126) {
         field_122 += deltaMs;
      }
      if (field_121 - field_125 > 300) {
         field_124 ^= true;
         field_125 = field_121;
      }

      method_62();

      if (field_225) {
         field_162 = true;
         if (field_232) {
            if (string.IsNullOrWhiteSpace(field_224)) {
               field_224 = "Player";
            }
            field_231 = null;
            field_230 = null;
            field_225 = false;
            field_159 = NameInputPrevInGame;
            if (field_274) {
               method_121(0, field_224);
               field_274 = false;
               field_267 = -1;
               method_313(field_345[field_240].field_18, field_280[6 * field_239 + 5], field_224, 1 - field_339);
               method_38();
               method_58();
               field_288 = 0;
               method_180();
            } else if (field_337 != -1) {
               field_314[field_337] = field_224;
               method_121(1 + field_337, field_314[field_337]);
               method_38();
               method_58();
               field_337 = -1;
            }
         }
      } else if (field_159) {
         if (!method_331()) {
            method_327();
            method_35();
            field_158 = false;
            field_159 = false;
            field_162 = false;
            method_73();
            method_61();
         }
      } else if (!method_75()) {
         field_162 = false;
         field_159 = true;
         if (!field_158) {
            method_74();
            method_35();
            field_158 = true;
            method_326();
         } else if (field_212 != null) {
            method_92(field_204, field_209, field_212, field_210, field_211, false, field_213);
         }
         method_61();
      }

      field_165.method_65();
      field_162 = false;
   }

   public static void UnlockAllLevelsCheat() {
      if (field_133 == null) return;
      for (int i = 0; i < 12; i++) {
         field_133[7 + i] = 31;
      }
      field_294 = true;
      if (field_135 != null && field_135.Length > 600) {
         field_135[596] = 0;
         field_135[600] = 2;
      }
      method_38();
      method_58();
      field_324 = true;
      if (!field_159 && !field_170 && field_179 >= 0) {
         int savedSel = field_180;
         int savedScroll = field_184;
         method_81();
         field_180 = Math.Clamp(savedSel, 0, Math.Max(0, field_181 - 1));
         field_184 = Math.Clamp(savedScroll, 0, Math.Max(0, field_181 - 1));
      }
      if (field_173) {
         method_17(20, 128, 1);
      }
   }

   public static void ResetAllProgress() {
      if (field_133 == null) return;
      for (int i = 0; i < 12; i++) {
         field_133[7 + i] = 0;
      }
      field_294 = false;
      if (field_135 != null && field_135.Length > 600) {
         field_135[596] = 2;
         field_135[600] = 0;
      }
      method_38();
      if (field_173) {
         method_122();
         method_58();
         method_204(true);
         if (field_314 != null) {
            for (int i = 0; i < 8; i++) {
               field_314[i] = method_120(1 + i);
            }
         }
         field_324 = true;
         if (!field_159 && !field_170 && field_179 >= 0) {
            int savedSel = field_180;
            int savedScroll = field_184;
            method_81();
            field_180 = Math.Clamp(savedSel, 0, Math.Max(0, field_181 - 1));
            field_184 = Math.Clamp(savedScroll, 0, Math.Max(0, field_181 - 1));
         }
         method_17(1, 128, 1);
      }
   }
"""
        code = code.replace('   public class_5() {', helper_methods + '\n   public class_5() {')
        code = code.replace(
            """         field_400 = field_123 * 900 >> 10;
         if (field_400 > 150) {
            field_400 = 150;
         }""",
            """         field_400 = DeterministicDeltaMs;"""
        )

    # Strip package and import lines
    code = re.sub(r'^package\s+[\w\.]+;\s*$', '', code, flags=re.M)
    code = re.sub(r'^import\s+[\w\.\*]+;\s*$', '', code, flags=re.M)

    # Fix labeled blocks
    code = fix_labeled_blocks(code)

    # Handle class header extends / implements
    def repl_class_decl(m):
        is_abs = m.group(2) or ''
        is_fin = 'sealed ' if m.group(3) else ''
        kind = m.group(4)
        name = m.group(5)
        ext = m.group(6)
        imp = m.group(7)
        bases = []
        if ext:
            bases.append(ext.strip())
        if imp:
            bases.extend([x.strip() for x in imp.split(',')])
        base_str = (' : ' + ', '.join(bases)) if bases else ''
        return f'public {is_abs}{is_fin}{kind} {name}{base_str} {{'

    code = re.sub(
        r'^(public\s+)?(abstract\s+)?(final\s+)?(class|interface)\s+(\w+)(?:\s+extends\s+([\w\.]+))?(?:\s+implements\s+([\w\.,\s]+))?\s*\{',
        repl_class_decl,
        code,
        flags=re.M
    )

    # Handle super(...) and this(...) calls at start of constructors
    code = re.sub(
        r'((?:public|protected|private)?\s*\bclass_\d+\s*\([^)]*\))\s*\{\s*super\(([^)]*)\);',
        r'\1 : base(\2) {',
        code
    )
    code = re.sub(r'\bsuper\(\);\s*', '', code)
    code = re.sub(r'\bsuper\.', 'base.', code)

    # Method modifiers
    code = re.sub(r'\bfinal\s+', '', code)
    code = re.sub(r'\bsynchronized\s+', '', code)
    code = re.sub(r'\bthrows\s+[\w\.,\s]+(?=\{)', '', code)

    # Override methods from Canvas/GameCanvas
    code = re.sub(
        r'(public|protected)\s+void\s+(paint|keyPressed|keyReleased|hideNotify|showNotify)\s*\(',
        r'public override void \2(',
        code
    )

    # Types & keywords
    code = re.sub(r'\bboolean\b', 'bool', code)
    code = re.sub(r'\bbyte\b', 'sbyte', code)
    code = re.sub(r'\bString\b', 'string', code)
    code = re.sub(r'\bObject\b', 'object', code)
    code = re.sub(r'\bImage\b', 'J2MEImage', code)
    code = re.sub(r'\bGraphics\b', 'J2MEGraphics', code)
    code = re.sub(r'\bRandom\b', 'JavaRandom', code)
    code = re.sub(r'\bThread\b', 'JavaThread', code)
    code = re.sub(r'\binstanceof\b', 'is', code)

    # Static system calls
    code = code.replace('System.currentTimeMillis()', 'JavaLang.CurrentTimeMillis()')
    code = code.replace('System.gc()', 'JavaLang.Gc()')
    code = re.sub(r'\.length\b(?!\s*\()', '.Length', code)

    # Unsigned right shift >>>=
    code = re.sub(r'(\b[\w\[\]\.]+)\s*>>>=\s*([^;]+);', r'\1 = (int)((uint)(\1) >> (\2));', code)

    # Fix switches
    code = fix_switches(code)

    header = """using System;
using System.IO;
using PlaymanExtremeRunning.J2ME;

"""
    return header + code

files = sorted(glob.glob(os.path.join(vf_dir, '*.java')))
for f in files:
    cs_code = convert_file(f)
    base = os.path.splitext(os.path.basename(f))[0] + '.cs'
    out_path = os.path.join(out_dir, base)
    with open(out_path, 'w', encoding='utf-8') as out_f:
        out_f.write(cs_code)

print(f'Converted {len(files)} files to {out_dir}')
