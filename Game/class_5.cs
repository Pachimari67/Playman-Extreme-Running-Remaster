using System;
using System.IO;
using PlaymanExtremeRunning.J2ME;


















// $VF: renamed from: c
public sealed class class_5 : GameCanvas, Runnable {
   // $VF: renamed from: a short[][]
   public static short[][] field_92;
   // $VF: renamed from: a bool
   public static bool field_93 = false;
   // $VF: renamed from: a sbyte[]
   public static sbyte[] field_94 = new sbyte[64290];
   // $VF: renamed from: a int[]
   public static int[] field_95;
   // $VF: renamed from: a javax.microedition.lcdui.J2MEImage[]
   public static J2MEImage[] field_96 = new J2MEImage[1080];
   // $VF: renamed from: b int[]
   public static int[] field_97 = new int[1080];
   // $VF: renamed from: a int
   public static int field_98;
   // $VF: renamed from: b int
   public static int field_99;
   // $VF: renamed from: c int[]
   public static int[] field_100;
   // $VF: renamed from: c int
   public static int field_101 = 0;
   // $VF: renamed from: d int
   public static int field_102 = 0;
   // $VF: renamed from: b sbyte[]
   public static sbyte[] field_103;
   // $VF: renamed from: a javax.microedition.media.Player
   public static Player field_104;
   // $VF: renamed from: e int
   public static int field_105 = 100;
   // $VF: renamed from: a java.lang.object[]
   public static object[] field_106;
   // $VF: renamed from: b bool
   public static bool field_107 = false;
   // $VF: renamed from: a javax.microedition.lcdui.Font
   public static Font field_108 = Font.getFont(64, 1, 8);
   // $VF: renamed from: b javax.microedition.lcdui.Font
   public static Font field_109 = Font.getFont(64, 1, 0);
   // $VF: renamed from: c javax.microedition.lcdui.Font
   public static Font field_110 = Font.getFont(64, 1, 16);
   // $VF: renamed from: d javax.microedition.lcdui.Font
   public static Font field_111 = Font.getFont(0, 0, 8);
   // $VF: renamed from: f int
   public static int field_112;
   // $VF: renamed from: g int
   public static int field_113 = -1;
   // $VF: renamed from: h int
   public static int field_114 = -1;
   // $VF: renamed from: a javax.microedition.lcdui.J2MEGraphics
   public static J2MEGraphics field_115 = null;
   // $VF: renamed from: i int
   public static int field_116 = 0;
   // $VF: renamed from: j int
   public static int field_117 = 0;
   // $VF: renamed from: k int
   public static int field_118 = 240;
   // $VF: renamed from: l int
   public static int field_119 = 320;
   // $VF: renamed from: m int
   public static int field_120;
   // $VF: renamed from: n int
   public static int field_121;
   // $VF: renamed from: o int
   public static int field_122;
   // $VF: renamed from: p int
   public static int field_123;
   // $VF: renamed from: c bool
   public static bool field_124;
   // $VF: renamed from: q int
   public static int field_125;
   // $VF: renamed from: d bool
   public static bool field_126;
   // $VF: renamed from: r int
   public static int field_127;
   // $VF: renamed from: s int
   public static int field_128;
   // $VF: renamed from: t int
   public static int field_129;
   // $VF: renamed from: u int
   public static int field_130;
   // $VF: renamed from: v int
   public static int field_131;
   // $VF: renamed from: d int[]
   public static int[] field_132 = new int[4];
   // $VF: renamed from: c sbyte[]
   public static sbyte[] field_133;
   // $VF: renamed from: d sbyte[]
   public static sbyte[] field_134;
   // $VF: renamed from: a short[]
   public static short[] field_135;
   // $VF: renamed from: e int[]
   public static int[] field_136;
   // $VF: renamed from: e bool
   public static bool field_137;
   // $VF: renamed from: a sbyte
   public static sbyte field_138;
   // $VF: renamed from: f bool
   public static bool field_139;
   // $VF: renamed from: w int
   public static int field_140;
   // $VF: renamed from: a java.io.DataInputStream
   public static DataInputStream field_141;
   // $VF: renamed from: e sbyte[]
   public static sbyte[] field_142;
   // $VF: renamed from: x int
   public static int field_143 = -1;
   // $VF: renamed from: a java.util.Hashtable
   public static Hashtable field_144 = null;
   // $VF: renamed from: a java.lang.string[]
   public static string[] field_145 = new string[200];
   // $VF: renamed from: f int[]
   public static int[] field_146 = new int[20];
   // $VF: renamed from: a bool[]
   public static bool[] field_147 = new bool[110];
   // $VF: renamed from: b bool[]
   public static bool[] field_148 = new bool[20];
   // $VF: renamed from: y int
   public static int field_149 = 0;
   // $VF: renamed from: g bool
   public static bool field_150;
   // $VF: renamed from: b javax.microedition.lcdui.J2MEGraphics
   public static J2MEGraphics field_151;
   // $VF: renamed from: h bool
   public static bool field_152 = false;
   // $VF: renamed from: i bool
   public static bool field_153;
   // $VF: renamed from: a java.io.ByteArrayOutputStream
   public static ByteArrayOutputStream field_154;
   // $VF: renamed from: a java.io.DataOutputStream
   public static DataOutputStream field_155;
   // $VF: renamed from: a java.io.ByteArrayInputStream
   public static ByteArrayInputStream field_156;
   // $VF: renamed from: b java.io.DataInputStream
   public static DataInputStream field_157;
   // $VF: renamed from: j bool
   public static bool field_158;
   // $VF: renamed from: k bool
   public static bool field_159;
   // $VF: renamed from: l bool
   public static bool field_160;
   // $VF: renamed from: m bool
   public static bool field_161;
   // $VF: renamed from: n bool
   public static bool field_162;
   // $VF: renamed from: a S
   public static class_6 field_163;
   // $VF: renamed from: a java.lang.JavaThread
   public static JavaThread field_164;
   // $VF: renamed from: a c
   public static class_5 field_165;
   // $VF: renamed from: z int
   public static int field_166;
   // $VF: renamed from: a java.lang.object
   public static object field_167 = new object();
   // $VF: renamed from: o bool
   public static bool field_168;
   // $VF: renamed from: p bool
   public static bool field_169;
   // $VF: renamed from: q bool
   public static bool field_170;
   // $VF: renamed from: r bool
   public static bool field_171;
   // $VF: renamed from: s bool
   public static bool field_172;
   // $VF: renamed from: t bool
   public static bool field_173;
   // $VF: renamed from: A int
   public static int field_174;
   // $VF: renamed from: a java.lang.string
   public static string field_175;
   // $VF: renamed from: g int[]
   public static int[] field_176 = new int[5];
   // $VF: renamed from: h int[]
   public static int[] field_177 = new int[5];
   // $VF: renamed from: i int[]
   public static int[] field_178 = new int[20];
   // $VF: renamed from: B int
   public static int field_179;
   // $VF: renamed from: C int
   public static int field_180;
   // $VF: renamed from: D int
   public static int field_181;
   // $VF: renamed from: E int
   public static int field_182;
   // $VF: renamed from: F int
   public static int field_183;
   // $VF: renamed from: G int
   public static int field_184;
   // $VF: renamed from: H int
   public static int field_185;
   // $VF: renamed from: I int
   public static int field_186;
   // $VF: renamed from: J int
   public static int field_187;
   // $VF: renamed from: K int
   public static int field_188;
   // $VF: renamed from: L int
   public static int field_189;
   // $VF: renamed from: M int
   public static int field_190;
   // $VF: renamed from: b java.lang.string
   public static string field_191;
   // $VF: renamed from: b short[]
   public static short[] field_192 = new short[720];
   // $VF: renamed from: c short[]
   public static short[] field_193 = new short[120];
   // $VF: renamed from: d short[]
   public static short[] field_194 = new short[80];
   // $VF: renamed from: e short[]
   public static short[] field_195 = new short[120];
   // $VF: renamed from: N int
   public static int field_196;
   // $VF: renamed from: O int
   public static int field_197;
   // $VF: renamed from: P int
   public static int field_198;
   // $VF: renamed from: Q int
   public static int field_199;
   // $VF: renamed from: R int
   public static int field_200;
   // $VF: renamed from: S int
   public static int field_201;
   // $VF: renamed from: T int
   public static int field_202;
   // $VF: renamed from: U int
   public static int field_203;
   // $VF: renamed from: V int
   public static int field_204;
   // $VF: renamed from: W int
   public static int field_205;
   // $VF: renamed from: X int
   public static int field_206;
   // $VF: renamed from: Y int
   public static int field_207;
   // $VF: renamed from: Z int
   public static int field_208;
   // $VF: renamed from: aa int
   public static int field_209;
   // $VF: renamed from: ab int
   public static int field_210;
   // $VF: renamed from: ac int
   public static int field_211;
   // $VF: renamed from: c java.lang.string
   public static string field_212;
   // $VF: renamed from: u bool
   public static bool field_213;
   // $VF: renamed from: ad int
   public static int field_214;
   // $VF: renamed from: ae int
   public static int field_215;
   // $VF: renamed from: af int
   public static int field_216;
   // $VF: renamed from: ag int
   public static int field_217;
   // $VF: renamed from: ah int
   public static int field_218;
   // $VF: renamed from: ai int
   public static int field_219;
   // $VF: renamed from: aj int
   public static int field_220;
   // $VF: renamed from: ak int
   public static int field_221;
   // $VF: renamed from: al int
   public static int field_222;
   // $VF: renamed from: v bool
   public static bool field_223;
   // $VF: renamed from: d java.lang.string
   public static string field_224;
   // $VF: renamed from: w bool
   public static bool field_225;
   // $VF: renamed from: am int
   public static int field_226;
   // $VF: renamed from: an int
   public static int field_227;
   // $VF: renamed from: ao int
   public static int field_228;
   // $VF: renamed from: ap int
   public static int field_229;
   // $VF: renamed from: f sbyte[]
   public static sbyte[] field_230;
   // $VF: renamed from: g sbyte[]
   public static sbyte[] field_231;
   // $VF: renamed from: x bool
   public static bool field_232;
   // $VF: renamed from: b short[][]
   public static short[][] field_233;
   // $VF: renamed from: j int[]
   public static int[] field_234 = new int[12];
   // $VF: renamed from: aq int
   public static int field_235;
   // $VF: renamed from: f short[]
   public static short[] field_236;
   // $VF: renamed from: g short[]
   public static short[] field_237;
   // $VF: renamed from: a java.util.JavaRandom
   public static JavaRandom field_238;
   // $VF: renamed from: ar int
   public static int field_239;
   // $VF: renamed from: as int
   public static int field_240;
   // $VF: renamed from: b java.lang.string[]
   public static string[] field_241;
   // $VF: renamed from: k int[]
   public static int[] field_242;
   // $VF: renamed from: l int[]
   public static int[] field_243;
   // $VF: renamed from: m int[]
   public static int[] field_244;
   // $VF: renamed from: n int[]
   public static int[] field_245;
   // $VF: renamed from: o int[]
   public static int[] field_246;
   // $VF: renamed from: at int
   public static int field_247;
   // $VF: renamed from: p int[]
   public static int[] field_248;
   // $VF: renamed from: q int[]
   public static int[] field_249;
   // $VF: renamed from: r int[]
   public static int[] field_250;
   // $VF: renamed from: s int[]
   public static int[] field_251;
   // $VF: renamed from: au int
   public static int field_252;
   // $VF: renamed from: av int
   public static int field_253;
   // $VF: renamed from: aw int
   public static int field_254;
   // $VF: renamed from: y bool
   public static bool field_255;
   // $VF: renamed from: z bool
   public static bool field_256;
   // $VF: renamed from: ax int
   public static int field_257;
   // $VF: renamed from: h sbyte[]
   public static sbyte[] field_258;
   // $VF: renamed from: ay int
   public static int field_259;
   // $VF: renamed from: t int[]
   public static int[] field_260;
   // $VF: renamed from: i sbyte[]
   public static sbyte[] field_261;
   // $VF: renamed from: b sbyte
   public static sbyte field_262;
   // $VF: renamed from: az int
   public static int field_263;
   // $VF: renamed from: u int[]
   public static int[] field_264;
   // $VF: renamed from: j sbyte[]
   public static sbyte[] field_265;
   // $VF: renamed from: aA int
   public static int field_266;
   // $VF: renamed from: aB int
   public static int field_267;
   // $VF: renamed from: aC int
   public static int field_268;
   // $VF: renamed from: A bool
   public static bool field_269;
   // $VF: renamed from: B bool
   public static bool field_270;
   // $VF: renamed from: aD int
   public static int field_271;
   // $VF: renamed from: aE int
   public static int field_272;
   // $VF: renamed from: C bool
   public static bool field_273;
   // $VF: renamed from: D bool
   public static bool field_274;
   // $VF: renamed from: aF int
   public static int field_275;
   // $VF: renamed from: aG int
   public static int field_276;
   // $VF: renamed from: E bool
   public static bool field_277;
   // $VF: renamed from: aH int
   public static int field_278;
   // $VF: renamed from: aI int
   public static int field_279;
   // $VF: renamed from: v int[]
   public static int[] field_280;
   // $VF: renamed from: w int[]
   public static int[] field_281;
   // $VF: renamed from: x int[]
   public static int[] field_282;
   // $VF: renamed from: aJ int
   public static int field_283;
   // $VF: renamed from: aK int
   public static int field_284;
   // $VF: renamed from: aL int
   public static int field_285;
   // $VF: renamed from: aM int
   public static int field_286;
   // $VF: renamed from: F bool
   public static bool field_287;
   // $VF: renamed from: aN int
   public static int field_288;
   // $VF: renamed from: G bool
   public static bool field_289;
   // $VF: renamed from: H bool
   public static bool field_290;
   // $VF: renamed from: aO int
   public static int field_291;
   // $VF: renamed from: aP int
   public static int field_292;
   // $VF: renamed from: I bool
   public static bool field_293;
   // $VF: renamed from: J bool
   public static bool field_294;
   // $VF: renamed from: aQ int
   public static int field_295;
   // $VF: renamed from: aR int
   public static int field_296;
   // $VF: renamed from: aS int
   public static int field_297;
   // $VF: renamed from: aT int
   public static int field_298;
   // $VF: renamed from: y int[]
   public static int[] field_299;
   // $VF: renamed from: h short[]
   public static short[] field_300;
   // $VF: renamed from: a f[]
   public static class_0[] field_301;
   // $VF: renamed from: K bool
   public static bool field_302;
   // $VF: renamed from: aU int
   public static int field_303;
   // $VF: renamed from: i short[]
   public static short[] field_304;
   // $VF: renamed from: j short[]
   public static short[] field_305;
   // $VF: renamed from: aV int
   public static int field_306;
   // $VF: renamed from: aW int
   public static int field_307;
   // $VF: renamed from: aX int
   public static int field_308;
   // $VF: renamed from: aY int
   public static int field_309;
   // $VF: renamed from: aZ int
   public static int field_310;
   // $VF: renamed from: L bool
   public static bool field_311;
   // $VF: renamed from: M bool
   public static bool field_312;
   // $VF: renamed from: z int[]
   public static int[] field_313;
   // $VF: renamed from: c java.lang.string[]
   public static string[] field_314;
   // $VF: renamed from: N bool
   public static bool field_315;
   // $VF: renamed from: ba int
   public static int field_316;
   // $VF: renamed from: bb int
   public static int field_317;
   // $VF: renamed from: bc int
   public static int field_318;
   // $VF: renamed from: bd int
   public static int field_319;
   // $VF: renamed from: be int
   public static int field_320;
   // $VF: renamed from: bf int
   public static int field_321;
   // $VF: renamed from: bg int
   public static int field_322;
   // $VF: renamed from: bh int
   public static int field_323;
   // $VF: renamed from: O bool
   public static bool field_324;
   // $VF: renamed from: e java.lang.string
   public static string field_325;
   // $VF: renamed from: f java.lang.string
   public static string field_326;
   // $VF: renamed from: bi int
   public static int field_327;
   // $VF: renamed from: bj int
   public static int field_328;
   // $VF: renamed from: bk int
   public static int field_329;
   // $VF: renamed from: bl int
   public static int field_330;
   // $VF: renamed from: bm int
   public static int field_331;
   // $VF: renamed from: P bool
   public static bool field_332;
   // $VF: renamed from: bn int
   public static int field_333;
   // $VF: renamed from: bo int
   public static int field_334;
   // $VF: renamed from: bp int
   public static int field_335;
   // $VF: renamed from: bq int
   public static int field_336;
   // $VF: renamed from: br int
   public static int field_337;
   // $VF: renamed from: A int[]
   public static int[] field_338;
   // $VF: renamed from: bs int
   public static int field_339;
   // $VF: renamed from: Q bool
   public static bool field_340;
   // $VF: renamed from: R bool
   public static bool field_341;
   // $VF: renamed from: B int[]
   public static int[] field_342;
   // $VF: renamed from: bt int
   public static int field_343;
   // $VF: renamed from: bu int
   public static int field_344;
   // $VF: renamed from: a e[]
   public static class_1[] field_345;
   // $VF: renamed from: a b
   public static class_3 field_346;
   // $VF: renamed from: a d[]
   public static class_2[] field_347;
   // $VF: renamed from: a b[]
   public static class_3[] field_348;
   // $VF: renamed from: C int[]
   public static int[] field_349;
   // $VF: renamed from: D int[]
   public static int[] field_350;
   // $VF: renamed from: E int[]
   public static int[] field_351;
   // $VF: renamed from: F int[]
   public static int[] field_352;
   // $VF: renamed from: G int[]
   public static int[] field_353;
   // $VF: renamed from: H int[]
   public static int[] field_354;
   // $VF: renamed from: I int[]
   public static int[] field_355;
   // $VF: renamed from: J int[]
   public static int[] field_356;
   // $VF: renamed from: K int[]
   public static int[] field_357;
   // $VF: renamed from: L int[]
   public static int[] field_358;
   // $VF: renamed from: M int[]
   public static int[] field_359;
   // $VF: renamed from: bv int
   public static int field_360;
   // $VF: renamed from: bw int
   public static int field_361;
   // $VF: renamed from: bx int
   public static int field_362;
   // $VF: renamed from: by int
   public static int field_363;
   // $VF: renamed from: bz int
   public static int field_364;
   // $VF: renamed from: bA int
   public static int field_365;
   // $VF: renamed from: bB int
   public static int field_366;
   // $VF: renamed from: bC int
   public static int field_367;
   // $VF: renamed from: S bool
   public static bool field_368;
   // $VF: renamed from: bD int
   public static int field_369;
   // $VF: renamed from: bE int
   public static int field_370;
   // $VF: renamed from: bF int
   public static int field_371;
   // $VF: renamed from: bG int
   public static int field_372;
   // $VF: renamed from: bH int
   public static int field_373;
   // $VF: renamed from: bI int
   public static int field_374;
   // $VF: renamed from: k short[]
   public static short[] field_375;
   // $VF: renamed from: bJ int
   public static int field_376;
   // $VF: renamed from: bK int
   public static int field_377;
   // $VF: renamed from: bL int
   public static int field_378;
   // $VF: renamed from: bM int
   public static int field_379;
   // $VF: renamed from: bN int
   public static int field_380;
   // $VF: renamed from: bO int
   public static int field_381;
   // $VF: renamed from: bP int
   public static int field_382;
   // $VF: renamed from: bQ int
   public static int field_383;
   // $VF: renamed from: N int[]
   public static int[] field_384;
   // $VF: renamed from: bR int
   public static int field_385;
   // $VF: renamed from: l short[]
   public static short[] field_386;
   // $VF: renamed from: bS int
   public static int field_387;
   // $VF: renamed from: bT int
   public static int field_388;
   // $VF: renamed from: bU int
   public static int field_389;
   // $VF: renamed from: bV int
   public static int field_390;
   // $VF: renamed from: bW int
   public static int field_391;
   // $VF: renamed from: bX int
   public static int field_392;
   // $VF: renamed from: O int[]
   public static int[] field_393;
   // $VF: renamed from: bY int
   public static int field_394;
   // $VF: renamed from: a a[]
   public static class_4[] field_395;
   // $VF: renamed from: c short[][]
   public static short[][] field_396;
   // $VF: renamed from: d short[][]
   public static short[][] field_397;
   // $VF: renamed from: bZ int
   public static int field_398;
   // $VF: renamed from: ca int
   public static int field_399;
   // $VF: renamed from: cb int
   public static int field_400;
   // $VF: renamed from: cc int
   public static int field_401;
   // $VF: renamed from: cd int
   public static int field_402;
   // $VF: renamed from: ce int
   public static int field_403;
   // $VF: renamed from: m short[]
   public static short[] field_404;
   // $VF: renamed from: T bool
   public static bool field_405;

   // $VF: renamed from: b () void
   private static void method_0() {
      if (!field_93) {
         try {
            method_49("p", 0L);
            short var0;
            if ((var0 = field_141.readByte()) < 0) {
               var0 += 256;
            }

            field_92 = new short[var0][];

            for (int var1 = 0; var1 < var0; var1++) {
               short var2;
               if ((var2 = field_141.readByte()) < 0) {
                  var2 += 256;
               }

               field_92[var1] = new short[var2];

               for (int var3 = 1; var3 < var2; var3++) {
                  field_92[var1][var3] = field_141.readShort();
               }
            }

            field_93 = true;
         } catch (Exception var4) {
         }
      }
   }

   // $VF: renamed from: a (bool, bool) void
   private static void method_1(bool var0, bool var1) {
      sbyte var2 = 1;
      int var3 = 0;
      int var4 = 0;
      int var5 = 0;
      if (var0) {
         var2 = -1;
         var4 = 0 + (field_98 - 1);
         if (!var1) {
            var3 = field_98 * 2;
         }
      }

      if (var1) {
         var4 += field_98 * (field_99 - 1);
         if (!var0) {
            var3 = -field_98 * 2;
         }
      }

      for (int var6 = 0; var6 < field_99; var6++) {
         for (int var7 = 0; var7 < field_98; var7++) {
            field_100[var4] = field_95[var5];
            var4 += var2;
            var5++;
         }

         var4 += var3;
      }
   }

   // $VF: renamed from: b (bool, bool) void
   private static void method_2(bool var0, bool var1) {
      int var2 = field_99;
      int var3 = -field_98 * field_99 + 1;
      int var4 = 0;
      int var5 = 0;
      if (var0 && var1) {
         var2 = -field_99;
         var3 = field_99 * field_98 - 1;
         var4 = 0 + (field_98 * field_99 - 1);
      } else if (var0) {
         var3 = -field_99 * field_98 - 1;
         var4 = 0 + (field_99 - 1);
      } else if (var1) {
         var3 = field_99 * field_98 + 1;
         var2 = -field_99;
         var4 = 0 + field_99 * (field_98 - 1);
      }

      for (int var6 = 0; var6 < field_99; var6++) {
         for (int var7 = 0; var7 < field_98; var7++) {
            field_100[var4] = field_95[var5];
            var4 += var2;
            var5++;
         }

         var4 += var3;
      }
   }

   // $VF: renamed from: a (int) bool
   private static bool method_3(int var0) {
      bool var1 = false;
      switch (var0) {
         case 1:
            method_2(true, false);
            var1 = true;
            break;
         case 2:
            method_1(true, true);
            break;
         case 3:
            method_2(false, true);
            var1 = true;
            break;
         case 4:
            method_1(true, false);
            break;
         case 5:
            method_1(false, true);
            break;
         case 6:
            method_2(false, false);
            var1 = true;
            break;
         case 7:
            method_2(true, true);
            var1 = true;
                  break;
}

      return var1;
   }

   // $VF: renamed from: a (int, int) int
   private static int method_4(int var0, int var1) {
      int var2 = field_135[50 + var0];
      int var3;
      if (var1 != 0) {
         while ((var3 = field_97[var2]) != 15) {
            var2++;
            if (var3 == var1) {
               return var2;
            }
         }
      }

      return var2;
   }

   // $VF: renamed from: a (int) int
   private static int method_5(int var0) {
      var0 = method_4(var0, 0);
      return field_96[var0] == null ? 0 : field_96[var0].getHeight();
   }

   // $VF: renamed from: b (int) int
   private static int method_6(int var0) {
      var0 = method_4(var0, 0);
      return field_96[var0] == null ? 0 : field_96[var0].getWidth();
   }

   // $VF: renamed from: a (int) void
   private static void method_7(int var0) {
      int var1 = field_135[40 + var0];
      method_0();
      if (field_96[var1] == null) {
         try {
            method_49("g" + var0, 0L);

            while (var1 < field_135[40 + var0 + 1]) {
               method_41(2, var1);
               var1 = method_8(var1);
            }

            method_48();
         } catch (Exception var2) {
         }
      }
   }

   // $VF: renamed from: c (int) int
   private static int method_8(int var0) {
      try {
         int var1 = field_141.readUnsignedShort();
         int var2 = field_141.readUnsignedShort();
         int var3;
         int var4 = ((var3 = field_141.readUnsignedByte()) == 255 ? var1 * 4 : var1) * var2 + 5;
         method_50(0, var4 - 5, field_94);
         bool var5 = false;
         field_95 = new int[var1 * var2];
         field_98 = var1;
         field_99 = var2;
         field_100 = field_95;

         for (int var6 = 0; var6 < var1 * var2; var6++) {
            int var7 = field_94[var6] & 255;
            short var8 = field_92[var3][var7];
            int var9 = 0;
            if (var7 != 0) {
               var9 = var8 << 3 & 248 | var8 << 5 & 64512 | var8 << 8 & 16252928 | -16777216;
            } else {
               var5 = true;
            }

            field_95[var6] = var9;
         }

         field_96[var0] = J2MEImage.createRGBImage(field_95, var1, var2, var5);
         int var13;
         if ((var13 = field_141.readByte() & 15) > 0) {
            for (int var14 = 0; var14 < var13; var14++) {
               field_100 = new int[var1 * var2];
               sbyte var10;
               if (!method_3(var10 = field_141.readByte())) {
                  field_96[var0 + 1] = J2MEImage.createRGBImage(field_100, var1, var2, var5);
               } else {
                  field_96[var0 + 1] = J2MEImage.createRGBImage(field_100, var2, var1, var5);
               }

               field_97[var0] = var10;
               var0++;
               field_100 = null;
            }

            field_97[var0] = 15;
         }
      } catch (Exception var12) {
      }

      field_95 = null;
      return var0 + 1;
   }

   // $VF: renamed from: a (int, int, int, int, int, int, int, int) void
   private static void method_9(int var0, int var1, int var2, int var3, int var4, int var5, int var6, int var7) {
      var1 -= method_21(var3, var4);
      var2 -= method_22(var3, var5);
      if (var1 < ScreenW && var2 < ScreenH && var1 + var4 >= 0 && var2 + var5 >= 0) {
         method_30(var1, var2, var4, var5);
         method_10(var0, var1 - var6, var2 - var7, 0, 0);
         method_29();
      }
   }

   // $VF: renamed from: a (int, int, int, int, int) void
   private static void method_10(int var0, int var1, int var2, int var3, int var4) {
      int var5 = method_6(var0);
      int var6 = method_5(var0);
      if (var4 == 1 || var4 == 3 || var4 == 6 || var4 == 7) {
         int var7 = var5;
         var5 = var6;
         var6 = var7;
      }

      var1 -= method_21(var3, var5);
      var2 -= method_22(var3, var6);
      var0 = method_4(var0, var4);
      field_151.drawImage(field_96[var0], var1, var2, 0);
   }

   // $VF: renamed from: a (int) java.lang.string
   private static string method_11(int var0) {
      switch (var0) {
         case 1:
            return "audio/midi";
         case 2:
         case 5:
         case 6:
         case 7:
         case 8:
         case 10:
         case 11:
         case 12:
         case 13:
         case 14:
         default:
            return null;
         case 3:
            return "audio/x-wav";
         case 4:
            return "audio/amr";
         case 9:
            return "audio/mpeg";
         case 15:
            return "audio/aac";
         case 16:
            return "audio/mp4";
      }
   }

   // $VF: renamed from: b (int) void
   private static void method_12(int var0) {
      int var1;
      if ((var1 = (var0 * 100 >> 6) * 128 >> 8) > 100) {
         var1 = 100;
      } else if (var1 < 0) {
         var1 = 0;
      }

      field_105 = var1;

      for (int var2 = 0; var2 < 20; var2++) {
         if (field_106[var2] is Player) {
            try {
               ((VolumeControl)((Player)field_106[var2]).getControl("VolumeControl")).setLevel(field_105);
            } catch (Exception var3) {
            }
         }
      }

      if (field_104 is Player) {
         try {
            ((VolumeControl)field_104.getControl("VolumeControl")).setLevel(field_105);
            return;
         } catch (Exception var4) {
         }
      }
   }

   // $VF: renamed from: c () void
   private static void method_13() {
      field_103 = new sbyte[8];
      field_106 = new object[20];

      for (int var0 = 0; var0 < 8; var0++) {
         field_103[var0] = 0;
      }

      field_107 = true;
   }

   // $VF: renamed from: d () void
   private static void method_14() {
      for (int var0 = 0; var0 < 8; var0++) {
         if (field_103[var0] == 1) {
            short var1 = field_135[372 + var0];
            short var2 = field_135[364 + var0];
            int var3 = field_136[4 + var1];
            method_49("s", (long)var3);
            JavaLang.Gc();

            for (int var4 = var1; var4 < var1 + var2; var4++) {
               method_41(3, var4);
               sbyte var5 = field_134[var4];
               int var6 = field_136[46 + var4];
               short var7 = field_135[380 + var4];
               if (var5 != 1 && var5 != 4 && var5 != 3 && var5 != 9 && var5 != 16 && var5 != 15 || field_106[var7] == null) {
                  try {
                     sbyte[] var8 = new sbyte[var6];
                     method_50(0, var6, var8);

                     try {
                        if (var5 == 0) {
                           field_106[var7] = null;
                        } else if (var5 != 3) {
                           field_106[var7] = var8;
                        } else {
                           field_106[var7] = Manager.createPlayer(new ByteArrayInputStream(var8), method_11(var5));
                           ((Player)field_106[var7]).SoundId = var4;
                           ((Player)field_106[var7]).prefetch();

                           try {
                              ((VolumeControl)((Player)field_106[var7]).getControl("VolumeControl")).setLevel(field_105);
                           } catch (Exception var9) {
                           }
                        }
                     } catch (Exception var10) {
                     }
                  } catch (Exception var11) {
                  }
               }
            }

            field_103[var0] = 2;
         }
      }
   }

   // $VF: renamed from: c (int) void
   private static void method_15(int var0) {
      if (!field_107) {
         method_13();
      }

      if (field_103[var0] <= 0) {
         field_103[var0] = 1;
         if (field_133[0] != 0) {
            method_14();
         }
      }
   }

   // $VF: renamed from: d (int) void
   private static void method_16(int var0) {
      if (field_107) {
         method_19(var0);
      }
   }

   // $VF: renamed from: a (int, int, int) void
   private static void method_17(int var0, int var1, int var2) {
      sbyte var3 = field_134[var0];
      if (field_133[0] != 0 && var3 != 0) {
         if (var3 == 3 || var1 >= field_102 || field_121 >= field_101) {
            if (var3 != 3) {
               field_101 = var2 == 0 ? Integer.MAX_VALUE : field_121 + field_136[25 + var0] * var2;
               field_102 = var1;
            }

            short var4 = field_135[380 + var0];
            if (var3 == 1 || var3 == 4 || var3 == 3 || var3 == 9 || var3 == 16 || var3 == 15) {
               try {
                  if (field_106[var4] is Player) {
                     try {
                        ((Player)field_106[var4]).setLoopCount(var2 == 0 ? -1 : var2);
                     } catch (Exception var6) {
                     }

                     ((Player)field_106[var4]).SoundId = var0;
                     ((Player)field_106[var4]).setMediaTime(0L);
                     ((Player)field_106[var4]).start();
                  } else {
                     if (field_104 != null) {
                        field_104.close();
                     }

                     field_104 = Manager.createPlayer(new ByteArrayInputStream((sbyte[])field_106[var4]), method_11(var3));
                     field_104.SoundId = var0;
                     field_104.realize();

                     try {
                        ((VolumeControl)field_104.getControl("VolumeControl")).setLevel(field_105);
                     } catch (Exception var5) {
                     }

                     field_104.prefetch();
                     if (var2 != 1) {
                        field_104.setLoopCount(var2 == 0 ? -1 : var2);
                     }

                     field_104.setMediaTime(0L);
                     field_104.start();
                  }

                  return;
               } catch (Exception var7) {
               }
            }
         }
      }
   }

   // $VF: renamed from: e (int) void
   private static void method_18(int var0) {
      short var1 = field_135[380 + var0];
      sbyte var2 = field_134[var0];
      if (field_133[0] != 0) {
         if (var2 == 1 || var2 == 4 || var2 == 3 || var2 == 9 || var2 == 16 || var2 == 15) {
            if (var2 != 3) {
               field_101 = -2147483647;
            }

            try {
               if (field_106[var1] is Player) {
                  ((Player)field_106[var1]).stop();
               } else if (field_104 != null) {
                  field_104.close();
               }

               return;
            } catch (Exception var3) {
            }
         }
      }
   }

   // $VF: renamed from: f (int) void
   private static void method_19(int var0) {
      if (field_103[var0] == 2) {
         short var1 = field_135[372 + var0];
         short var2 = field_135[364 + var0];

         for (int var3 = var1; var3 < var1 + var2; var3++) {
            method_18(var3);
         }
      }
   }

   // $VF: renamed from: e () void
   private static void method_20() {
      if (field_107) {
         for (int var0 = 0; var0 < 8; var0++) {
            method_19(var0);
         }
      }
   }

   // $VF: renamed from: b (int, int) int
   private static int method_21(int var0, int var1) {
      if ((var0 & 1) != 0) {
         return var1 >> 1;
      } else {
         return (var0 & 8) != 0 ? var1 : 0;
      }
   }

   // $VF: renamed from: c (int, int) int
   private static int method_22(int var0, int var1) {
      if ((var0 & 2) != 0) {
         return var1 >> 1;
      } else {
         return (var0 & 32) != 0 ? var1 : 0;
      }
   }

   // $VF: renamed from: a (int, java.lang.string, int, int, int) void
   private static void method_23(int var0, string var1, int var2, int var3, int var4) {
      method_26(field_151, var0 & 127);
      int var5 = field_151.getColor();
      field_151.setColor(field_112);
      if ((var0 & 1024) != 0) {
         field_151.drawString(var1, var2 - 1, var3, var4);
         field_151.drawString(var1, var2, var3 - 1, var4);
         field_151.drawString(var1, var2 + 1, var3, var4);
         field_151.drawString(var1, var2, var3 + 1, var4);
      }

      field_151.setColor(var5);
      field_151.drawString(var1, var2, var3, var4);
   }

   // $VF: renamed from: a (int, java.lang.string) int
   private static int method_24(int var0, string var1) {
      return method_25(var0).stringWidth(var1);
   }

   // $VF: renamed from: a (int) javax.microedition.lcdui.Font
   private static Font method_25(int var0) {
      switch (var0 = var0 & 127) {
         case 0:
            return field_108;
         case 1:
            return field_109;
         case 2:
            return field_110;
         case 16:
            return field_111;
         default:
            return null;
      }
   }

   // $VF: renamed from: a (javax.microedition.lcdui.J2MEGraphics, int) void
   private static void method_26(J2MEGraphics var0, int var1) {
      var1 &= 127;
      if (field_115 != var0 || field_114 != field_120 || field_113 != var1) {
         field_115 = var0;
         field_114 = field_120;
         field_113 = var1;
         Font var2 = method_25(var1);
         var0.setFont(var2);
      }
   }

   // $VF: renamed from: d (int) int
   private static int method_27(int var0) {
      switch (var0 = var0 & 127) {
         case 0:
            return field_108.getHeight();
         case 1:
            return field_109.getHeight();
         case 2:
            return field_110.getHeight();
         case 16:
            return field_111.getHeight();
         default:
            return -1;
      }
   }

   // $VF: renamed from: a (int, int, int, int) void
   private static void method_28(int var0, int var1, int var2, int var3) {
      field_116 = var0;
      field_117 = var1;
      field_118 = var2;
      field_119 = var3;
      method_29();
   }

   // $VF: renamed from: f () void
   private static void method_29() {
      field_151.setClip(field_116, field_117, field_118, field_119);
   }

   // $VF: renamed from: b (int, int, int, int) void
   private static void method_30(int var0, int var1, int var2, int var3) {
      int var4 = var0 + var2;
      int var5 = var1 + var3;
      if (var0 < field_116) {
         var0 = field_116;
      }

      if (var1 < field_117) {
         var1 = field_117;
      }

      if (var4 > field_118 + field_116) {
         var4 = field_118 + field_116;
      }

      if (var5 > field_119 + field_117) {
         var5 = field_119 + field_117;
      }

      field_151.setClip(var0, var1, var4 - var0, var5 - var1);
   }

   // $VF: renamed from: b (int, int, int) void
   private static void method_31(int var0, int var1, int var2) {
      if (var2 < var0) {
         int var3 = var0;
         var0 = var2;
         var2 = var3;
      }

      field_151.fillRect(var0, var1, var2 - var0, 1);
   }

   // $VF: renamed from: a (int, int, int, int, int, int) void
   private static void method_32(int var0, int var1, int var2, int var3, int var4, int var5) {
      field_151.fillTriangle(var0, var1, var2, var3, var4, var5);
      if (false && var3 < var1) {
         int var6 = var3;
         var3 = var1;
         var1 = var6;
         var6 = var2;
         var2 = var0;
         var0 = var6;
      }

      if (var5 < var3) {
         int var19 = var5;
         var5 = var3;
         var3 = var19;
         var19 = var4;
         var4 = var2;
         var2 = var19;
      }

      if (var3 < var1) {
         int var21 = var3;
         var3 = var1;
         var1 = var21;
         var21 = var2;
         var2 = var0;
         var0 = var21;
      }

      if (var5 >= 0 && var1 <= ScreenH) {
         int var7 = var3 - var1;
         int var8 = var5 - var1;
         int var9 = var5 - var3;
         int var10 = 0;
         int var11 = 0;
         int var12 = 0;
         if (var7 != 0) {
            var10 = (var2 - var0 << 8) / var7;
         }

         if (var8 != 0) {
            var11 = (var4 - var0 << 8) / var8;
         }

         if (var9 != 0) {
            var12 = (var4 - var2 << 8) / var9;
         }

         int var13 = 0;
         int var14 = 0;

         for (int var15 = var1; var15 < var3; var15++) {
            int var16 = var0 + (var13 >> 8);
            int var17 = var0 + (var14 >> 8);
            method_31(var16, var15, var17);
            var13 += var10;
            var14 += var11;
         }

         var13 = 0;

         for (int var24 = var3; var24 < var5; var24++) {
            int var25 = var2 + (var13 >> 8);
            int var26 = var0 + (var14 >> 8);
            method_31(var25, var24, var26);
            var13 += var12;
            var14 += var11;
         }
      }
   }

   // $VF: renamed from: b (int, int, int, int, int, int) void
   private static void method_33(int var0, int var1, int var2, int var3, int var4, int var5) {
      field_151.drawLine(var0, var1, var2, var3);
      field_151.drawLine(var2, var3, var4, var5);
      field_151.drawLine(var4, var5, var0, var1);
   }

   // $VF: renamed from: g () void
   private static void method_34() {
      field_131 = (int)JavaLang.CurrentTimeMillis();
      field_121 = 0;
      field_127 = 0;
      field_128 = 0;
      method_35();
   }

   // $VF: renamed from: h () void
   private static void method_35() {
      field_120 = 0;
      field_129 = 0;
      field_123 = 0;
      field_122 = 0;
      field_126 = false;
      field_121 = (int)JavaLang.CurrentTimeMillis() - field_131;

      for (int var0 = 0; var0 < 4; var0++) {
         field_132[var0] = 0;
      }

      field_124 = true;
      field_125 = 0;
   }

   // $VF: renamed from: i () void
   private static void method_36() {
      field_120++;
      field_128 = field_121;
      field_127 = (int)JavaLang.CurrentTimeMillis() - field_131;
      int var0 = field_127 - field_128;

      for (int var1 = 0; var1 < 3; var1++) {
         field_132[var1] = field_132[var1 + 1];
      }

      field_132[3] = field_127;
      if (field_129 < 4) {
         field_129++;
      }

      if (field_129 > 1) {
         field_130 = (field_127 - field_132[4 - field_129]) / (field_129 - 1);
      } else {
         field_130 = 0;
      }

      field_123 = field_121;
      field_121 = field_121 + field_130;
      field_121 = field_121 + (field_127 - field_121 >> 2);
      field_123 = field_121 - field_123;
      if (var0 < -1000 || var0 > 1000) {
         field_123 = 10;
      }

      if (field_123 < 0) {
         field_123 = 0;
      }

      if (field_159 && !field_126) {
         field_122 = field_122 + field_123;
      }

      if (field_121 - field_125 > 300) {
         field_124 ^= true;
         field_125 = field_121;
      }
   }

   // $VF: renamed from: j () void
   private static void method_37() {
      field_133 = method_55("ropt");
      if (field_133 == null || field_133.Length != 19) {
         field_133 = new sbyte[19];

         for (int var0 = 0; var0 < 19; var0++) {
            field_133[var0] = 0;
         }

         field_133[0] = 1;
         field_133[1] = 0;
      }

      field_133[0] = 0;
      field_138 = field_133[1];
      field_133[1] = 0;
   }

   // $VF: renamed from: k () void
   private static void method_38() {
      method_56("ropt", field_133);
   }

   // $VF: renamed from: l () void
   private static void method_39() {
      try {
         method_49("i", 0L);
         field_134 = new sbyte[21];
         method_50(0, 21, field_134);
         field_135 = new short[640];

         for (int var0 = 0; var0 < 602; var0++) {
            field_135[var0] = field_141.readShort();
         }

         field_136 = new int[187];

         for (int var2 = 0; var2 < 187; var2++) {
            field_136[var2] = field_141.readInt();
         }

         method_48();
      } catch (IOException var1) {
      }
   }

   // $VF: renamed from: m () void
   private static void method_40() {
      if (!field_160) {
         if (field_225) {
            method_297();
         } else if (!field_159) {
            method_87();
         } else {
            method_332();
         }
      } else {
         if (field_139) {
            string var0 = field_145[18];

            for (int var1 = 0; var1 < 1 + field_140 % 3; var1++) {
               var0 = var0 + '.';
            }

            field_140++;
            int var4;
            var4 = (var4 = method_24(0, field_145[18] + "...")) + (var4 >> 2);
            int var2 = field_108.getHeight();
            int var3 = 160 - (var2 >> 1) - var2;
            field_151.setColor(0);
            field_151.fillRect(120 - (var4 >> 1) - 1, var3 + 2, var4, var2 << 1);
            field_151.setColor(7829367);
            field_151.fillRect(120 - (var4 >> 1), var3, var4, var2 << 1);
            field_151.setColor(16777215);
            field_151.drawRect(120 - (var4 >> 1), var3, var4, var2 << 1);
            field_151.setColor(16777215);
            method_23(0, var0, 120 - (method_24(0, field_145[18] + "...") >> 1), 160, 36);
            field_139 = false;
         } else {
            method_302();
         }
      }
   }

   // $VF: renamed from: a (int, int) void
   private static void method_41(int var0, int var1) {
   }

   // $VF: renamed from: n () void
   private static void method_42() {
      field_139 = true;
      method_66();
   }

   public override void hideNotify() {
      if (field_170 && !field_171) {
         field_165.keyPressed(field_135[18] - 50);
      }

      method_20();
      if (field_159) {
         method_70();
      }

      field_161 = true;
   }

   public override void showNotify() {
      method_61();
      field_162 = true;
      if (field_170 && !field_171) {
         field_165.keyPressed(field_135[18] - 50);
      }

      field_161 = false;
   }

   // $VF: renamed from: a (javax.microedition.rms.RecordStore) java.util.Hashtable
   private static Hashtable method_43(RecordStore var0) {
      Hashtable var4 = new Hashtable();

      try {
         sbyte[] var12;
         if ((var12 = var0.getRecord(1)) != null) {
            DataInputStream var2 = new DataInputStream(new ByteArrayInputStream(var12));

            int var6;
            while ((var6 = var2.readInt()) != Integer.MAX_VALUE) {
               string var7 = var2.readUTF();
               var4.put(var7, new Integer(var6));
            }
         }
      } catch (InvalidRecordIDException var10) {
         try {
            ByteArrayOutputStream var1 = new ByteArrayOutputStream();
            DataOutputStream var3;
            (var3 = new DataOutputStream(var1)).writeInt(Integer.MAX_VALUE);
            var3.writeUTF("foo");
            sbyte[] var5 = var1.toByteArray();
            var0.addRecord(var5, 0, var5.Length);
         } catch (Exception var9) {
         }
      } catch (Exception var11) {
      }

      return var4;
   }

   // $VF: renamed from: a (javax.microedition.rms.RecordStore, java.util.Hashtable) void
   private static void method_44(RecordStore var0, Hashtable var1) {
      try {
         ByteArrayOutputStream var3 = new ByteArrayOutputStream();
         DataOutputStream var4 = new DataOutputStream(var3);
         Enumeration var2 = var1.keys();

         while (var2.hasMoreElements()) {
            string var6 = (string)var2.nextElement();
            int var7 = (Integer)var1.get(var6);
            var4.writeInt(var7);
            var4.writeUTF(var6);
         }

         sbyte[] var5 = var3.toByteArray();
         if (var0.getNumRecords() == 0) {
            var0.addRecord(var5, 0, var5.Length);
         } else {
            var0.setRecord(1, var5, 0, var5.Length);
         }
      } catch (Exception var8) {
      }
   }

   // $VF: renamed from: a (java.lang.string) sbyte[]
   private static sbyte[] method_45(string var0) {
      RecordStore var1 = null;
      sbyte[] var3 = null;

      try {
         Integer var4;
         if ((var4 = (Integer)method_43(var1 = RecordStore.openRecordStore("mrg_rms", true)).get(var0)) != null) {
            var3 = var1.getRecord(var4);
         }

         if (var1 != null) {
            var1.closeRecordStore();
         }
      } catch (Exception var5) {
      }

      return var3;
   }

   // $VF: renamed from: a (java.lang.string, sbyte[]) bool
   private static bool method_46(string var0, sbyte[] var1) {
      RecordStore var2 = null;

      try {
         Hashtable var3;
         Integer var4;
         if ((var4 = (Integer)(var3 = method_43(var2 = RecordStore.openRecordStore("mrg_rms", true))).get(var0)) == null) {
            var4 = new Integer(var2.addRecord(var1, 0, var1.Length));
            var3.put(var0, var4);
         } else {
            var2.setRecord(var4, var1, 0, var1.Length);
         }

         method_44(var2, var3);
         if (var2 != null) {
            var2.closeRecordStore();
         }

         return true;
      } catch (Exception var6) {
         var6.getMessage();
         return false;
      }
   }

   // $VF: renamed from: o () void
   private static void method_47() {
      string[] var0 = RecordStore.listRecordStores();

      for (int var1 = 0; var1 < var0.Length; var1++) {
         try {
            RecordStore.deleteRecordStore(var0[var1]);
         } catch (Exception var2) {
         }
      }

      method_69();
   }

   // $VF: renamed from: p () void
   private static void method_48() {
      if (field_141 != null) {
         try {
            field_141.close();
         } catch (Exception var0) {
         }

         field_141 = null;
      }
   }

   // $VF: renamed from: a (java.lang.string, long) void
   private static void method_49(string var0, long var1) {
      try {
         method_41(4, (int)var1);
         method_48();
         DataInputStream var3 = new DataInputStream(field_165.getClass().getResourceAsStream("/" + var0));

         while (var1 > 0L) {
            var1 -= var3.skip(var1);
         }

         field_141 = var3;
      } catch (Exception var4) {
      }
   }

   // $VF: renamed from: a (int, int, sbyte[]) void
   private static void method_50(int var0, int var1, sbyte[] var2) {
      while (var1 > 0) {
         int var3 = field_141.read(var2, var0, var1);
         var0 += var3;
         var1 -= var3;
      }
   }

   // $VF: renamed from: b (int, int) void
   private static void method_51(int var0, int var1) {
      short var2 = field_135[401 + var0];
      if (field_143 != var0) {
         field_142 = null;
         field_142 = new sbyte[var2];
         method_49("b" + var0, 0L);

         try {
            field_141.readFully(field_142);
         } catch (Exception var3) {
         }

         method_48();
         field_143 = var0;
      }

      field_141 = new DataInputStream(new ByteArrayInputStream(field_142, var1, var2 - var1));
   }

   // $VF: renamed from: a (int, int, int, sbyte[]) sbyte[]
   private static sbyte[] method_52(int var0, int var1, int var2, sbyte[] var3) {
      if (var3 == null || var3.Length < var2) {
         var3 = new sbyte[var2];
      }

      try {
         method_51(var0, var1);
         method_50(0, var2, var3);
         method_48();
      } catch (IOException var4) {
      }

      return var3;
   }

   // $VF: renamed from: a (int, int, int, int[]) int[]
   private static int[] method_53(int var0, int var1, int var2, int[] var3) {
      if (var3 == null || var3.Length < var2 >> 2) {
         var3 = new int[var2 >> 2];
      }

      sbyte[] var4 = method_52(var0, var1, var2, null);

      for (int var5 = 0; var5 < var2; var5 += 4) {
         var3[var5 >> 2] = ((var4[var5] & 255) << 24) + ((var4[var5 + 1] & 255) << 16) + ((var4[var5 + 2] & 255) << 8) + (var4[var5 + 3] & 255);
      }

      return var3;
   }

   // $VF: renamed from: a (int, int, int, short[]) short[]
   private static short[] method_54(int var0, int var1, int var2, short[] var3) {
      if (var3 == null || var3.Length < var2 >> 1) {
         var3 = new short[var2 >> 1];
      }

      sbyte[] var4 = method_52(var0, var1, var2, null);

      for (int var5 = 0; var5 < var2; var5 += 2) {
         var3[var5 >> 1] = (short)(((var4[var5] & 255) << 8) + (var4[var5 + 1] & 255));
      }

      return var3;
   }

   // $VF: renamed from: b (java.lang.string) sbyte[]
   private static sbyte[] method_55(string var0) {
      if (field_144 == null) {
         try {
            sbyte[] var1 = method_45("mrg_rms");
            field_144 = new Hashtable();
            DataInputStream var2 = new DataInputStream(new ByteArrayInputStream(var1));

            int var3;
            while ((var3 = var2.readInt()) != Integer.MAX_VALUE) {
               sbyte[] var4 = new sbyte[var3];
               var2.read(var4, 0, var4.Length);
               string var5 = var2.readUTF();
               field_144.put(var5, var4);
            }
         } catch (Exception var6) {
         }
      }

      return (sbyte[])field_144.get(var0);
   }

   // $VF: renamed from: b (java.lang.string, sbyte[]) bool
   private static bool method_56(string var0, sbyte[] var1) {
      field_144.put(var0, var1);
      return true;
   }

   // $VF: renamed from: a (java.lang.string) void
   private static void method_57(string var0) {
      field_144.remove(var0);
   }

   // $VF: renamed from: q () void
   private static void method_58() {
      try {
         ByteArrayOutputStream var0 = new ByteArrayOutputStream();
         DataOutputStream var1 = new DataOutputStream(var0);
         Enumeration var2 = field_144.keys();

         while (var2.hasMoreElements()) {
            string var3 = (string)var2.nextElement();
            sbyte[] var4 = (sbyte[])field_144.get(var3);
            var1.writeInt(var4.Length);
            var1.write(var4, 0, var4.Length);
            var1.writeUTF(var3);
         }

         var1.writeInt(0);
         method_46("mrg_rms", var0.toByteArray());
      } catch (Exception var5) {
      }
   }

   // $VF: renamed from: g (int) void
   private static void method_59(int var0) {
      if (field_145[field_135[35 + var0]] == null) {
         try {
            method_49("l", (long)field_136[0]);

            for (int var1 = 0; var1 < 200; var1++) {
               field_145[var1] = field_141.readUTF();
            }

            method_48();
            Localization.ApplyLanguage(field_145, CurrentLanguageIndex);
         } catch (Exception var2) {
         }
      }
   }

   // $VF: renamed from: a (java.lang.string, java.lang.string, int) java.lang.string
   private static string method_60(string var0, string var1, int var2) {
      int var3;
      return (var3 = var0.indexOf("%" + var2)) == -1 ? var0 : var0.substring(0, var3) + var1 + var0.substring(var3 + 2, var0.length());
   }

   // $VF: renamed from: r () void
   private static void method_61() {
      field_149 = 0;

      for (int var0 = 0; var0 < 110; var0++) {
         field_147[var0] = false;
      }
   }

   public override void keyPressed(int var1) {
      field_166 = (int)JavaLang.CurrentTimeMillis();
      

      bool var10000 = false;
      if (var1 + 50 >= 110) {
         var10000 = true;
      }

      bool var10001 = false;
      if (var1 < -50) {
         var10001 = true;
      }

      if (!(var10000 | var10001)) {
         field_150 = true;
         if (field_149 >= 19) {
            method_61();
         }

         var1 += 50;
         field_146[field_149] = var1;
         field_148[field_149] = true;
         field_149++;
      }
   }

   public override void keyReleased(int var1) {
      bool var10000 = false;
      if (var1 + 50 >= 110) {
         var10000 = true;
      }

      bool var10001 = false;
      if (var1 < -50) {
         var10001 = true;
      }

      if (!(var10000 | var10001)) {
         field_150 = true;
         if (field_149 >= 19) {
            method_61();
         }

         var1 += 50;
         field_146[field_149] = var1;
         field_148[field_149] = false;
         field_149++;
      }
   }

   // $VF: renamed from: s () void
   private static void method_62() {
      for (int var0 = 0; var0 < field_149; var0++) {
         int var1 = field_146[var0];
         if (field_148[var0]) {
            field_147[var1] = true;
            if (field_225) {
               method_98(var1);
            } else if (!field_159) {
               method_79(var1);
            } else {
               method_330(var1);
            }
         } else if (field_147[var1]) {
            field_147[var1] = false;
         }
      }

      field_149 = 0;
   }

   // $VF: renamed from: a (int, int) bool
   private static bool method_63(int var0, int var1) {
      if (var1 < 65536) {
         bool var10000 = false;
         if (var0 == var1) {
            var10000 = true;
         }

         return var10000;
      } else {
         for (int var2 = 0; var2 < var1 >> 16; var2++) {
            if (field_135[(var1 & 65535) + var2] == var0) {
               return true;
            }
         }

         return false;
      }
   }

   // $VF: renamed from: e (int) int
   private static int method_64(int var0) {
      int var1;
      return (var1 = var0 - 98) >= 0 && var1 <= 9 ? var1 : -1;
   }

   // $VF: renamed from: t () void
   private void method_65() {
      field_153 = false;
      field_152 = true;
      this.repaint();
      this.serviceRepaints();
   }

   public override void paint(J2MEGraphics var1) {
      field_113 = -1;
      if (field_152) {
         field_152 = false;
         field_151 = var1;
         method_40();
         field_153 = true;
      }
   }

   // $VF: renamed from: u () void
   private static void method_66() {
      if (field_153) {
         field_162 = false;
         field_160 = true;
         field_165.method_65();



         field_160 = false;
      }
   }

   // $VF: renamed from: v () void
   private static void method_67() {
      if (!field_137) {
         method_34();
         method_37();
         method_15(0);
         method_71();
         method_325();
         method_59(0);
         field_137 = true;
         method_7(0);
      }
   }

   // $VF: renamed from: run () void
   public void run() {
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

      while (field_164 != null) {
         field_168 = false;

         while (field_161) {
            try {
               JavaThread.sleep(100L);
            } catch (Exception var3) {
            }

            if (field_164 == null) {
               return;
            }
         }

         method_36();
         method_62();
         if (field_164 == null) {
            return;
         }

         if (field_225) {
            field_162 = true;
         } else if (field_159) {
            if (!method_331()) {
               if (field_164 == null) {
                  return;
               }

               method_327();
               method_35();
               field_158 = false;
               field_159 = false;
               field_162 = false;
               method_73();
               method_61();
            }
         } else if (!method_75()) {
            if (field_164 == null) {
               return;
            }

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

         if (field_164 == null) {
            return;
         }

         if (field_162) {
            field_165.method_65();

            do {
               field_150 = false;

               try {
                  JavaThread.yield();
               } catch (Exception var7) {
               }
            } while (!field_153 || field_150);

            field_162 = false;
         } else {
            if (field_164 == null) {
               return;
            }

            try {
               JavaThread.yield();
            } catch (Exception var6) {
            }
         }

         bool var10000 = (field_159 ^ true) & field_168;
         bool var10001 = false;
         if (field_166 + 10000 < (int)JavaLang.CurrentTimeMillis()) {
            var10001 = true;
         }

         if (var10000 & var10001) {
            
         }
      }
   }

   // $VF: renamed from: a () void
   public static void method_68() {
      field_164 = null;
      method_20();
      method_38();
      method_58();
   }

   // $VF: renamed from: w () void
   private static void method_69() {
      field_163.method_334();
   }

   // $VF: renamed from: x () void
   private static void method_70() {
      OnPauseGame?.Invoke();
      method_20();
      field_159 = false;
      method_73();
   }

   // $VF: renamed from: y () void
   private static void method_71() {
      field_170 = true;
      field_185 = -1;
      field_172 = false;
      field_173 = false;
      field_183 = -1;
      field_186 = -1;
      field_189 = -1;
      field_171 = false;
   }

   // $VF: renamed from: h (int) void
   private static void method_72(int var0) {
      field_185 = var0;
   }

   // $VF: renamed from: z () void
   private static void method_73() {
      if (field_170) {
         method_7(1);
         method_59(1);
         method_15(1);
         field_133[0] = 0;
         method_76(7);
      } else {
         field_188 = ((ScreenH - 1 - method_27(0) - (24 + method_27(1)))) / method_27(1024);
         field_169 = false;
         method_80();
         if (field_158) {
            if (field_186 != -1) {
               method_82(field_186);
               field_186 = -1;
            } else {
               method_82(2);
            }

            method_20();
         } else {
            method_7(2);
            method_59(2);
            if (!field_173) {
               method_221();
               field_173 = true;
            }

            method_82(0);
            if (field_185 != -1) {
               method_82(field_185);
               field_185 = -1;
            }
         }
      }
   }

   // $VF: renamed from: A () void
   private static void method_74() {
      field_175 = null;
   }

   // $VF: renamed from: a () bool
   private static bool method_75() {
      if (field_170) {
         if (!field_171) {
            if (!field_172) {
               method_199();
               field_172 = true;
            }

            method_200();
         }

         field_162 = true;
         return true;
      } else if (field_169) {
         return false;
      } else {
         while (field_184 > field_180) {
            field_184--;
         }

         while (field_184 + field_188 <= field_180) {
            field_184++;
         }

         if (field_182 == 0) {
            int var0 = method_27(1024);
            field_189 = 24 + method_27(1) + (field_180 - field_184) * var0;
            int var1;
            if ((var1 = field_181 * var0) < (ScreenH - 1 - method_27(0) - (24 + method_27(1)))) {
               field_189 = field_189 + ((ScreenH - 1 - method_27(0) - (24 + method_27(1))) - var1 >> 1);
            }
         } else {
            field_189 = -1;
         }

         if (field_171) {
            field_189 = -1;
         }

         field_162 = true;
         return true;
      }
   }

   // $VF: renamed from: b (int) bool
   private static bool method_76(int var0) {
      short var1 = field_135[490 + var0 * 4 + 1];
      if (!field_171 && var1 == 1) {
         field_171 = true;
         field_174 = var0;
         field_175 = method_60(field_145[3], field_145[field_135[490 + var0 * 4 + 3]], 1);
         method_91(1024, field_175, 226, (ScreenH - 1 - method_27(0) - (24 + method_27(1))), false);
         field_190 = 0;
         return false;
      } else {
         return true;
      }
   }

   // $VF: renamed from: c (int, int) void
   private static void method_77(int var0, int var1) {
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
      }
      short var2 = field_135[490 + var0 * 4];
      short var3 = field_135[490 + var0 * 4 + 1];
      if (var2 == 1 && var1 == 1) {
         method_82(var3);
      }

      if (var2 == 4 && var1 == 1) {
         field_133[var3] = (sbyte)(1 - field_133[var3]);
         method_38();
         if (var3 == 0) {
            method_20();
            method_17(20, 128, 1);
         }
      }

      if (var2 == 5) {
         if (var1 == 1) {
            method_88(var3, 100);
         }

         if (var1 == 2) {
            method_88(var3, 1);
         }

         if (var1 == 3) {
            method_88(var3, -1);
         }

         if (var3 == 0 && field_133[var3] == 0) {
            method_20();
         }

         method_38();
      }

      if (var2 == 2 && var1 == 1 && method_76(var0)) {
         method_78(var0);
      }

      if (var2 == 3 && var1 == 1 && method_76(var0)) {
         method_203(var0);
      }
   }

   // $VF: renamed from: i (int) void
   private static void method_78(int var0) {
      if (var0 == 9) {
         field_169 = true;
      }

      if (var0 == 5) {
         method_69();
      }

      if (var0 == 11) {
         method_83();
      }

      if (var0 == 12) {
         method_77(field_174, 1);
         field_171 = false;
      }

      if (var0 == 13) {
         field_171 = false;
      }

      if (var0 == 8) {
         method_47();
      }

      if (var0 == 7) {
         field_133[1] = field_138;
         if (field_133[1] == 0) {
            field_133[1] = 32;
         }

         field_133[0] = 1;
         method_12(field_133[1]);
         method_14();
      }
   }

   // $VF: renamed from: j (int) void
   private static void method_79(int var0) {
      if (!field_169) {
         if (field_171) {
            if (method_63(var0, 262162)) {
               method_17(0, 128, 1);
               method_77(12, 1);
            }

            if (method_63(var0, 43)) {
               method_17(0, 128, 1);
               method_77(13, 1);
            }

            if (method_63(var0, 131086) && --field_190 < 0) {
               field_190 = 0;
            }

            if (method_63(var0, 131088) && ++field_190 >= field_207 - 1) {
               field_190 = field_207 - 1;
            }
         } else if (field_170) {
            if (field_172 && method_63(var0, 327704)) {
               field_170 = false;
               method_20();
               method_73();
               method_61();
            }
         } else {
            switch (field_182) {
               case 0:
                  sbyte var1 = 0;
                  if (method_63(var0, 131086)) {
                     var1 = -1;
                  }

                  if (method_63(var0, 131088)) {
                     var1 = 1;
                  }

                  while (var1 != 0) {
                     field_124 = true;
                     field_125 = field_121;
                     field_180 += var1;
                     if (field_180 < 0) {
                        field_180 = field_181 - 1;
                     }

                     if (field_180 >= field_181) {
                        field_180 = 0;
                     }

                     short var4;
                     if ((var4 = field_135[490 + field_178[field_180] * 4 + 2]) == 0) {
                        var1 = 0;
                     }
                  }

                  int var2 = field_178[field_180];
                  if (method_63(var0, 262162) || method_63(var0, 131101) || method_63(var0, 131103)) {
                     sbyte var3 = 1;
                     if (method_63(var0, 262162)) {
                        method_17(0, 128, 1);
                     } else if (method_63(var0, 131101)) {
                        var3 = 2;
                     } else if (method_63(var0, 131103)) {
                        var3 = 3;
                     }

                     method_77(var2, var3);
                  }
                  break;
               case 1:
                  if (method_63(var0, 131088)) {
                     field_187 = field_187 + field_205;
                  }

                  if (method_63(var0, 131086)) {
                     field_187 = field_187 - field_205;
                  }

                  if (field_187 > field_208) {
                     field_187 = field_208;
                  }

                  if (field_187 < 0) {
                     field_187 = 0;
                  }
                  break;
               case 2:
                  method_213(var0, field_176[field_179]);
                  if (method_63(var0, 131086) || method_63(var0, 131088)) {
                     field_124 = true;
                     field_125 = field_121;
                  }

                  return;
            }

            if (method_63(var0, 43)) {
               method_17(1, 128, 1);
               if (field_179 == 0) {
                  if (field_158) {
                     method_77(9, 1);
                  } else {
                     method_77(5, 1);
                  }

                  return;
               }

               method_77(11, 1);
            }
         }
      }
   }

   // $VF: renamed from: B () void
   private static void method_80() {
      field_179 = -1;
   }

   // $VF: renamed from: C () void
   private static void method_81() {
      int var0 = field_176[field_179];
      short var1 = field_135[474 + var0];
      field_182 = field_135[404 + var1];
      field_183 = field_135[404 + var1 + 1];
      field_181 = 0;
      field_184 = 0;
      if (field_182 == 0) {
         int var2 = -1;

         for (int var3 = 3; var3 < field_135[404 + var1 + 2] + 3; var3++) {
            short var4;
            if ((var4 = field_135[404 + var1 + var3]) != -1 && field_135[490 + var4 * 4 + 2] != 2) {
               field_178[field_181] = var4;
               if (var2 == -1 && field_135[490 + var4 * 4 + 2] == 0) {
                  var2 = field_181;
               }

               field_181++;
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
         }

         if (field_135[490 + field_178[field_180] * 4 + 2] != 0 && var2 > -1) {
            field_180 = var2;
         }
      } else if (field_182 == 1) {
         string var5 = "";
         short var6 = field_135[404 + var1 + 2];
         short var7 = field_135[404 + var1 + 3];
         if (var6 == 1) {
            var5 = field_145[var7];
            if (var0 == 3) {
               var5 = var5 + "\n\n" + field_145[137];
            }
         }

         method_91(1024, var5, 226, (ScreenH - 1 - method_27(0) - (24 + method_27(1))), false);
         field_187 = 0;
         field_181++;
      } else if (field_182 == 2) {
         method_205(var0);
      }

      method_202(var0);
   }

   // $VF: renamed from: k (int) void
   private static void method_82(int var0) {
      if (field_179 >= 0) {
         field_177[field_179] = field_180;
      }

      field_179++;
      field_176[field_179] = var0;
      field_180 = 0;
      method_81();
   }

   // $VF: renamed from: D () void
   private static void method_83() {
      field_179--;
      field_180 = field_177[field_179];
      method_81();
   }

   // $VF: renamed from: c (bool, bool) void
   private static void method_84(bool var0, bool var1) {
      if (!field_139) {
         int var2 = ScreenH - (ScreenH - 1 - method_27(1024)) >> 1;
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
         }
      }
   }

   // $VF: renamed from: a (bool, bool, int, int) void
   private static void method_85(bool var0, bool var1, int var2, int var3) {
      if (!field_139) {
         int var4 = var3 + (method_27(1024) >> 1);
         int var5 = method_27(1024) >> 1;
         int var6 = var2 >> 1;
         int var7 = (ScreenW / 2) - var6;
         int var8 = (ScreenW / 2) + var6;
         int var9 = (var5 & 1) != 0 ? var5 : var5 + 1;
         bool var10 = false;
         if (var7 - var9 < 0) {
            var7 = var9;
            var10 = true;
         }

         if (var8 + var9 >= ScreenW) {
            var8 = ScreenW - var9;
            var10 = true;
         }

         if (!var10 || field_124) {
            field_151.setColor(16777215);
            if (var0) {
               method_32(var7 - 1, var4 - var5, var7 - var9, var4, var7 - 1, var4 + var5);
            }

            if (var1) {
               method_32(var8 + 1, var4 - var5, var8 + var9, var4, var8 + 1, var4 + var5);
            }
         }
      }
   }

   // $VF: renamed from: d (int, int) void
   private static void method_86(int var0, int var1) {
      if (!field_139) {
         field_112 = 0;
         field_151.setColor(16777215);
         if (var0 != -1) {
            method_23(1024, field_145[var0], 3, ScreenH - 1 - method_27(1024), 20);
         }

         if (var1 != -1) {
            method_23(1024, field_145[var1], ScreenW - 3, ScreenH - 1 - method_27(1024), 24);
         }
      }
   }

   // $VF: renamed from: E () void
   private static void method_87() {
      method_28(0, 0, ScreenW, ScreenH);
      if (field_171) {
         method_217();
         int var18 = field_206 * method_27(1024);
         int var17 = 24 + method_27(1);
         if (var18 < (ScreenH - 1 - method_27(0) - (24 + method_27(1)))) {
            var17 = 24 + method_27(1) + ((ScreenH - 1 - method_27(0) - (24 + method_27(1))) >> 1) - (var18 >> 1);
         }

         field_151.setColor(16777215);
         method_93(1024, MenuOffsetX + 7, var17, field_190 * field_205);
         bool var23 = false;
         if (field_190 > 0) {
            var23 = true;
         }

         bool var10001 = false;
         if (field_190 < field_207 - 1) {
            var10001 = true;
         }

         method_84(var23, var10001);
         method_86(1, 2);
      } else if (field_170) {
         method_201();
         method_86(134, -1);
      } else {
         field_168 = true;
         method_217();
         int var0 = 24 + method_27(1);
         int var1 = -1;
         sbyte var2 = 0;
         bool var3 = false;
         bool var4 = false;
         if (field_179 > 0) {
            var2 = 5;
         } else if (field_158) {
            var2 = 8;
         } else {
            var2 = 7;
         }

         switch (field_182) {
            case 0:
               int var6;
               if ((var6 = field_181 * method_27(1024)) < (ScreenH - 1 - method_27(0) - (24 + method_27(1)))) {
                  var0 = 24 + method_27(1) + ((ScreenH - 1 - method_27(0) - (24 + method_27(1))) >> 1) - (var6 >> 1);
               }

               for (int var21 = field_184; var21 < field_181 && var21 - field_184 < field_188; var21++) {
                  int var7 = field_178[var21] * 4;
                  short var8 = field_135[490 + var7];
                  short var9 = field_135[490 + var7 + 1];
                  short var10 = field_135[490 + var7 + 2];
                  short var11 = field_135[490 + var7 + 3];
                  string var5 = (var7 == 28 * 4) ? Localization.GetModeOptionLine(CurrentLanguageIndex, UseRemasterMode) : ((var7 == 29 * 4) ? Localization.GetScreenOptionLine(CurrentLanguageIndex, WindowModeIndex) : ((var7 == 30 * 4) ? Localization.GetLanguageOptionLine(CurrentLanguageIndex) : field_145[var11]));
                  int var12 = 16777215;
                  if (var8 == 4) {
                     var5 = var5 + " : ";
                     if (field_133[var9] == 1) {
                        var5 = var5 + field_145[9];
                     } else {
                        var5 = var5 + field_145[10];
                     }
                  }

                  int var13 = ScreenW / 2;
                  if (var8 == 5) {
                     var5 = var5 + " : ";
                     int var14;
                     int var15 = (var14 = method_24(1024, var5)) + method_89();
                     int var16;
                     var13 = (var16 = (ScreenW / 2) - (var15 >> 1) + var14) - (var14 >> 1);
                     if (var9 == 0) {
                        method_90(var16, var0, method_89(), method_27(1024), field_133[1]);
                     } else {
                        method_90(var16, var0, method_89(), method_27(1024), field_133[var9]);
                     }
                  }

                  if (var10 == 1) {
                     var12 = 9510656;
                  } else if (var21 == field_180) {
                     var12 = 16728334;
                     if (var8 == 4 || var8 == 6) {
                        var1 = 6;
                     } else if (var8 == 5) {
                        if (var9 == 0) {
                           sbyte var10000 = 0;
                           if (field_133[1] != 0) {
                              var10000 = 1;
                           }

                           var1 = var10000 + 9;
                        } else {
                           sbyte var22 = 0;
                           if (field_133[var9] != 0) {
                              var22 = 1;
                           }

                           var1 = var22 + 9;
                        }
                     } else {
                        var1 = 4;
                     }
                  }

                  field_112 = 0;
                  field_151.setColor(var12);
                  method_23(1024, var5, var13, var0, 17);
                  if ((var8 == 5 || var8 == 6) && var21 == field_180) {
                     int var10002 = method_24(1024, var8 == 6 ? var5 : (field_145[field_135[490 + (var7 >> 2) * 4 + 3]] + (var8 == 5 ? " : " : "")));
                     int var10003 = 1;
                     if (var8 == 5) {
                        var10003 = method_89();
                     }

                     method_85(true, true, var10002 + var10003 + 2 + 3, var0);
                  }

                  var0 += method_27(1024);
               }

               if (field_184 > 0) {
                  var3 = true;
               }

               if (field_184 < field_181 - field_188) {
                  var4 = true;
               }

               method_84(var3, var4);
               method_86(var1, var2);
               return;
            case 1:
               field_151.setColor(16777215);
               method_93(1024, MenuOffsetX + 7, 24 + method_27(1), field_187);
               if (field_187 > 0) {
                  var3 = true;
               }

               if (field_187 < field_208) {
                  var4 = true;
               }

               method_84(var3, var4);
               method_86(-1, var2);
               return;
            case 2:
               method_210(field_176[field_179]);
                        break;
}
      }
   }

   // $VF: renamed from: e (int, int) void
   private static void method_88(int var0, int var1) {
      if (var0 == 0) {
         if (var1 == 100) {
            if (field_133[1] > 0) {
               field_133[1] = 0;
            } else {
               field_133[1] = 64;
            }
         } else if (var1 > 0) {
            if ((field_133[1] = (sbyte)(field_133[1] + 8)) > 64) {
               field_133[1] = 0;
            }
         } else if ((field_133[1] = (sbyte)(field_133[1] - 8)) < 0) {
            field_133[1] = 64;
         }

         if (field_133[1] == 0) {
            field_133[0] = 0;
         } else {
            field_133[0] = 1;
            method_14();
         }

         method_12(field_133[1]);
         method_17(20, 128, 1);
      }
   }

   // $VF: renamed from: a () int
   private static int method_89() {
      return 60;
   }

   // $VF: renamed from: b (int, int, int, int, int) void
   private static void method_90(int var0, int var1, int var2, int var3, int var4) {
      int var5 = (var2 << 8) / 8;

      for (int var6 = 0; var6 < 8; var6++) {
         if (var4 * 8 >> 6 > var6) {
            field_151.setColor(-1);
         } else {
            field_151.setColor(-12303292);
         }

         field_151.fillRect(var0 + var6 * (var5 >> 8), var1 + 1, (var5 >> 8) - 1, var3 - 2);
      }
   }

   // $VF: renamed from: a (int, java.lang.string, int, int, bool) void
   private static void method_91(int var0, string var1, int var2, int var3, bool var4) {
      method_92(-1, var0, var1, var2 - 2, var3, var4, true);
      field_205 = var3 / method_27(var0);
      if (field_205 < 1) {
         field_205 = 1;
      }

      field_206 = field_200;
      field_207 = 1;

      for (int var5 = 1; var5 < field_200; var5++) {
         if (field_193[var5] - field_193[field_222] >= field_201) {
            field_222 = var5 - 1;
            field_207++;
         }
      }

      field_208 = field_198 - 1;
   }

   // $VF: renamed from: a (int, int, java.lang.string, int, int, bool, bool) void
   private static void method_92(int var0, int var1, string var2, int var3, int var4, bool var5, bool var6) {
      field_222 = 0;
      field_200 = 0;
      int var7 = (int)JavaLang.CurrentTimeMillis();
      field_223 = false;
      if (var5) {
         field_204 = var0;
         field_209 = var1;
         field_210 = var3;
         field_211 = var4;
         field_212 = var2;
         field_213 = var6;
      }

      field_203 = var0;
      field_191 = null;
      field_191 = var2;
      field_201 = var4;
      field_196 = 0;
      field_198 = 0;
      field_220 = 0;
      int var9 = 0;
      int var54 = 0;
      int var11 = 0;
      int var12 = 0;
      int var13 = method_27(var1);
      int var14 = method_24(var1, " ");
      int var15 = 0;
      int var16 = var6 ? 2 : 0;
      field_193[0] = 0;
      int var17 = 1;
      int var20 = 0;
      int var21 = var3;
      int var22 = 0;
      int var23 = 0;
      int var24 = 0;
      int var25 = 0;
      int var26 = var3;
      int var27 = -1;
      int var28 = 0;
      int var29 = 0;
      int var30 = 0;
      int var31 = 0;
      bool var32 = false;
      int var33 = 0;
      int var34 = 0;
      int var35 = 0;
      int var36 = var16;
      int var37 = var2.length();
      field_199 = 0;
      bool var38 = false;
      short var39 = 0;
      short var40 = 0;

      while (var54 < var37) {
         if ((!field_158 || !field_159 && field_158) && (int)(JavaLang.CurrentTimeMillis() - (long)var7) > 250) {
            method_42();
            var7 = (int)JavaLang.CurrentTimeMillis();
         }

         int var41 = var2.charAt(var54);
         var54++;
         bool var18 = false;
         bool var19 = false;
         switch (var41) {
            case 10:
               if (var12 < var27 - var15) {
                  var12 = var27 - var15;
               }

               var27 = -1;
               var18 = true;
               var19 = true;
               break;
            case 11:
            case 12:
            case 13:
            case 14:
            case 15:
            case 16:
            case 17:
            case 18:
            case 23:
            case 26:
            case 29:
            case 30:
            case 31:
            default:
               int var64 = --var54;
               int var67 = -1;
               int var68 = var21 - var20;
               bool var69 = false;
               int var46 = var26 - var25;

               for (; var54 <= var37; var54++) {
                  if ((var41 = var54 == var37 ? -1 : var2.charAt(var54)) == 32 || var41 == 10 || var41 == 9 || var41 >= 19 && var41 <= 28 || var41 == -1) {
                     int var47;
                     if ((var47 = method_24(var1, var2.substring(var64, var54))) > var68) {
                        if (var67 >= 0) {
                           var54 = var67;
                           if (var41 == 32 && var47 - var30 < var46) {
                              var69 = true;
                           }
                        } else if (var68 < var46 && var47 < var46) {
                           var54 = var64;
                           var18 = true;
                        } else {
                           var54 = var64 + 1;

                           int var48;
                           for (var48 = var47 = method_24(var1, var2.substring(var64, var54));
                              var47 < var68;
                              var47 = method_24(var1, var2.substring(var64, var54))
                           ) {
                              var54++;
                              var48 = var47;
                           }

                           var30 = var48;
                           if (var64 == --var54) {
                              if (var47 < var46) {
                                 var18 = true;
                              } else {
                                 var30 = method_24(var1, var2.substring(var64, ++var54));
                              }
                           }
                        }
                        break;
                     }

                     var67 = var54;
                     var30 = var47;
                     if (var41 != 32) {
                        while (var2.charAt(var54 - 1) == ' ') {
                           var54--;
                        }

                        int var10000 = 0;
                        if (var54 > var64) {
                           var10000 = method_24(var1, var2.substring(var64, var54));
                        }

                        var30 = var10000;
                        break;
                     }
                  }
               }

               if (!var18) {
                  var11 = var20;
                  var35 = var20 += var30;
                  field_192[var9++] = (short)var64;
                  field_192[var9++] = (short)(var54 - var64);
                  field_192[var9++] = (short)var11;
                  field_192[var9++] = (short)var12;
                  field_192[var9++] = (short)var30;
                  field_192[var9++] = (short)var13;
                  if (var69) {
                     var18 = true;
                  }

                  if (var15 < var13) {
                     var15 = var13;
                  }
               }
               break;
            case 19:
            case 25:
            case 27:
            case 28:
               int var42 = var54 - 1;

               int var43;
               for (var43 = 0; var2.charAt(var54) != ':'; var54++) {
                  int var66;
                  var43 = (var66 = var43 * 10) + (var2.charAt(var54) - '0');
               }

               var54++;
               if (var41 != 25 && var41 != 28) {
                  if (var41 == 27) {
                     field_192[var9++] = (short)(-(var43 + 1 + 16383));
                  } else {
                     field_192[var9++] = (short)(-(var43 + 1));
                     var14 = method_24(var1 = method_306(var43), " ");
                     var13 = method_27(var1);
                     if (var20 == var34) {
                        var15 = var13;
                     }
                  }
               } else {
                  int var44;
                  var24 = (var44 = method_307(var43)) >> 16 & 65535;
                  var23 = var44 & 65535;
                  if (var41 == 25) {
                     var11 = var20;
                     if ((var20 += var24) > var21 && var3 >= var24) {
                        var54 = var42;
                        var18 = true;
                     } else {
                        field_194[var22++] = (short)var43;
                        field_194[var22++] = (short)var11;
                        field_194[var22++] = (short)var12;
                        field_194[var22++] = (short)var23;
                        if (var15 < var23) {
                           var15 = var23;
                        }

                        var35 = var20;
                        if (var54 == var37) {
                           var18 = true;
                        }
                     }
                  } else {
                     if (var20 != 0) {
                        var18 = true;
                        var19 = true;
                        var54 = var42;
                        break;
                     }

                     switch (var16) {
                        case 0:
                           var11 = 0;
                           var25 = var24;
                           var20 = var24;
                           break;
                        case 1:
                           var21 = var26 = var11 = var3 - var24;
                           break;
                        case 2:
                           var11 = (var3 - var24) / 2;
                           var15 = var23;
                           var18 = true;
                           var19 = true;

                           for (int var45 = var13; var45 < var23; var45 += var13) {
                              field_193[var17] = (short)(var12 + var45);
                              var17++;
                           }
                                                break;
}

                     var34 = var20;
                     var27 = var12 + var23 + 2;
                     field_194[var22++] = (short)var43;
                     field_194[var22++] = (short)var11;
                     field_194[var22++] = (short)var12;
                     field_194[var22++] = (short)var23;
                     var28 = var22;
                     var29 = var22;
                  }
               }
               break;
            case 20:
            case 21:
            case 22:
               var32 = true;
               var36 = var41 - 20;
               if (var6 && var16 == 1 && var36 == 0 && var20 > var34) {
                  var18 = true;
               }

               if (var16 == 2 && var36 != 2 && var20 > var34) {
                  var18 = true;
               }
               break;
            case 24:
               if (var38) {
                  field_195[field_199++] = (short)var39;
                  field_195[field_199++] = (short)var40;
                  field_195[field_199++] = (short)(var12 - var40 + var15 + 2);
                  var38 = false;
               } else {
                  var39 = (short)(var17 - 1);
                  var40 = (short)var12;
                  var38 = true;
               }
               break;
            case 32:
               if (var20 > var34) {
                  var20 += var14;
               }

               while (var54 < var37 && var2.charAt(var54) == ' ') {
                  var54++;
               }
                        break;
}

         if (var54 == var37) {
            var18 = true;
         }

         if (var32 || var18) {
            if (field_220 < var20) {
               field_220 = var20;
            }

            if (var16 != 0) {
               int var65 = var21 - var35;
               if (var16 == 2) {
                  var65 = (var65 + 1) / 2;
               }

               while (var33 < var9) {
                  if (field_192[var33] >= 0) {
                     field_192[var33 + 2] = (short)(field_192[var33 + 2] + var65);
                     var33 += 6;
                  } else {
                     var33++;
                  }
               }

               while (var29 < var22) {
                  field_194[var29 + 1] = (short)(field_194[var29 + 1] + var65);
                  var29 += 4;
               }

               if (var16 == 1) {
                  field_220 = var21;
                  var20 = var34;
                  var21 = var34 + var65;
               } else if (var36 == 1) {
                  var20 = var35;
               } else {
                  var20 = var34;
                  var21 -= var35;
               }
            } else {
               var33 = var9;
               var29 = var22;
            }

            var34 = var20;
            var32 = false;
            var16 = var36;
         }

         if (var18) {
            while (var31 < var9) {
               if (field_192[var31] >= 0) {
                  field_192[var31 + 3] = (short)(field_192[var31 + 3] + (var15 - field_192[var31 + 5]) / 2);
                  var31 += 6;
               } else {
                  var31++;
               }
            }

            while (var28 < var22) {
               field_194[var28 + 2] = (short)(field_194[var28 + 2] + (var15 - field_194[var28 + 3]) / 2);
               var28 += 4;
            }

            var12 += var15;
            if (var19) {
               var12 += 0;
            }

            var15 = var13;
            if (var12 > var27) {
               var20 = 0;
               var21 = var3;
               var25 = 0;
               var26 = var3;
            } else {
               var20 = var25;
               var21 = var26;
            }

            var34 = var20;
            var35 = var20;
            field_193[var17] = (short)var12;
            var17++;
         }
      }

      while (var12 <= var27) {
         var12 += var13;
         field_193[var17] = (short)var12;
         var17++;
      }

      field_202 = var12;
      field_196 = var9;
      field_197 = var22;
      field_200 = var17;

      while (var17 > 1) {
         if (field_193[field_200 - 1] - field_193[--var17 - 1] > var4) {
            var17++;
            break;
         }
      }

      field_198 = var17;
      field_223 = true;
      field_139 = false;
   }

   // $VF: renamed from: c (int, int, int, int) void
   private static void method_93(int var0, int var1, int var2, int var3) {
      if (field_223) {
         int var4 = field_151.getColor();
         int var5 = var0;
         int var6 = 0;
         int var7 = 0;
         short var8 = field_193[var3];

         while (var6 < field_196) {
            if (field_192[var6] < 0) {
               if ((var7 = -field_192[var6] - 1) < 16383) {
                  var0 = var7 == 0 ? var5 : method_306(var7);
               } else {
                  var7 -= 16383;
                  field_151.setColor(var7 == 0 ? var4 : method_305(var7));
               }

               var6++;
            } else {
               int var9;
               if ((var9 = field_192[var6 + 3] - var8) >= 0 && var9 <= field_201 - field_192[var6 + 5]) {
                  var9 += var2;
                  int var10 = var1 + field_192[var6 + 2];
                  short var11 = field_192[var6];
                  method_23(var0, field_191.substring(var11, var11 + field_192[var6 + 1]), var10, var9, 20);
               } else if (var9 >= 0) {
                  break;
               }

               var6 += 6;
            }
         }

         for (int var12 = 0; var12 < field_197; var12 += 4) {
            int var16;
            if ((var16 = field_194[var12 + 2] - var8) >= -field_194[var12 + 3] && var16 < field_201) {
               int var17 = var1 + field_194[var12 + 1];
               method_308(field_194[var12], var17, var16 + var2);
            } else if (var16 >= 0) {
               break;
            }
         }

         field_151.setColor(var4);
      }
   }

   // $VF: renamed from: a (int, java.lang.string, int, int, int, int, int, int, int, bool) void
   private static void method_94(int var0, string var1, int var2, int var3, int var4, int var5, int var6, int var7, int var8, bool var9) {
      method_91(var0, var1, var4 - (var6 << 1), var5 - (var7 << 1), var9);
      field_214 = var2 + var6;
      field_215 = var3 + var7;
      field_216 = var4 - (var6 << 1);
      field_217 = var5 - (var7 << 1);
      field_218 = field_214;
      field_219 = field_215;
      int var10 = field_202;
      if (field_202 < field_217) {
         field_219 = field_219 + (field_217 >> 1) - (var10 >> 1);
      }

      if (var8 != 0) {
         if (field_207 == 1) {
            int var11 = var5 - (var7 << 1) - var10;
            if ((var8 & 4) != 0 && (var8 & 8) != 0) {
               field_215 += var11 >> 1;
               field_217 -= var11;
            } else if ((var8 & 4) != 0) {
               field_219 = field_215 + field_217 - var10;
               field_215 = field_219;
               field_217 = var10;
            } else if ((var8 & 8) != 0) {
               field_219 = field_215;
               field_217 = var10;
            }
         }

         int var12 = var4 - (var6 << 1) - field_220;
         if ((var8 & 1) != 0 && (var8 & 2) != 0) {
            field_214 += var12 >> 1;
            field_216 -= var12;
         } else if ((var8 & 1) != 0) {
            field_214 += var12 >> 1;
            field_216 -= var12 >> 1;
         } else if ((var8 & 2) != 0) {
            field_216 -= var12 >> 1;
         }
      }

      field_214 -= var6;
      field_215 -= var7;
      field_216 += var6 << 1;
      field_217 += var7 << 1;
      field_221 = var0;
      field_222 = 0;
   }

   // $VF: renamed from: c (int) bool
   private static bool method_95(int var0) {
      if (var0 == 2 && ++field_222 > field_208) {
         field_222 = field_208;
         return false;
      } else if (var0 == 4 && --field_222 < 0) {
         field_222 = 0;
         return false;
      } else {
         return true;
      }
   }

   // $VF: renamed from: d (int) bool
   private static bool method_96(int var0) {
      if (var0 == 1) {
         for (int var1 = field_222 + 1; var1 < field_200; var1++) {
            if (field_193[var1] - field_193[field_222] >= field_201) {
               field_222 = var1 - 1;
               return true;
            }
         }
      }

      if (var0 == 3) {
         for (int var2 = field_222; var2 >= 0; var2--) {
            if (field_193[field_222 + 1] - field_193[var2] >= field_201) {
               field_222 = var2;
               return true;
            }
         }
      }

      return false;
   }

   // $VF: renamed from: a (java.lang.string, java.lang.string, int, int) java.lang.string
   private static string method_97(string var0, string var1, int var2, int var3) {
      field_231 = method_52(0, 0, 51, null);
      field_230 = method_52(0, 51, 11, null);
      field_226 = var3;
      if (var1 == null) {
         field_224 = "";
      } else {
         field_224 = var1;
      }

      field_229 = 0;
      field_225 = true;
      field_232 = false;
      field_227 = -1;
      field_228 = field_121;
      bool var4 = field_159;
      field_159 = false;
      method_61();

      NameInputPrevInGame = var4;
      return field_224;
   }

   // $VF: renamed from: l (int) void
   private static void method_98(int var0) {
      if (method_63(var0, 46)) {
         field_227 = -1;
      } else {
         int var1;
         if ((var1 = method_64(var0)) == -1) {
            if (method_63(var0, 262162)) {
               field_232 = true;
            } else {
               if (method_63(var0, 131105)) {
                  if (field_224.length() > 0) {
                     field_224 = field_224.substring(0, field_224.length() - 1);
                     field_229 = 0;
                     field_124 = true;
                  }

                  field_228 = field_121;
                  field_227 = -1;
               }
            }
         } else {
            if (field_227 == var1 && field_121 - field_228 < 1000) {
               if (++field_229 == field_230[var1 + 1] - field_230[var1]) {
                  field_229 = 0;
               }

               if (field_224.length() > 0) {
                  field_224 = field_224.substring(0, field_224.length() - 1);
               }

               field_224 = field_224 + (char)field_231[field_230[var1] + field_229];
            } else if (field_227 != var1 || field_121 - field_228 >= 1000) {
               field_229 = 0;
               if (field_224.length() == field_226) {
                  field_224 = field_224.substring(0, field_224.length() - 1);
               }

               field_224 = field_224 + (char)field_231[field_230[var1] + field_229];
            }

            field_228 = field_121;
            field_227 = var1;
         }
      }
   }

   // $VF: renamed from: f (int, int) void
   private static void method_99(int var0, int var1) {
      try {
         if (field_233 == null) {
            field_233 = new short[14][];
         }

         if (field_233[var0] == null) {
            field_233[var0] = new short[1 + var1];
            method_49("k" + var0, 0L);

            for (int var2 = 0; var2 < var1; var2++) {
               field_233[var0][var2] = field_141.readShort();
            }

            method_48();
         }
      } catch (Exception var3) {
      }
   }

   // $VF: renamed from: a (int) short
   private static short method_100(int var0) {
      int var1 = var0 >>> 11;
      int var2 = var0 & 2047;
      return field_233[var1][3 + field_233[var1][1 + var2]];
   }

   // $VF: renamed from: b (int) short
   private static short method_101(int var0) {
      int var1 = var0 >>> 11;
      int var2 = var0 & 2047;
      return field_233[var1][4 + field_233[var1][1 + var2]];
   }

   // $VF: renamed from: a (int, int, int, int) int
   private static int method_102(int var0, int var1, int var2, int var3) {
      short[] var4;
      short var5 = (var4 = field_233[var0 >>> 11])[var4[1 + (var0 & 2047)]];
      var2++;
      short var10000 = 0;
      if (var5 > 1) {
         var10000 = var4[var2++];
      }

      short var7 = var10000;

      for (int var8 = 0; var8 < var3; var7 >>= 1) {
         short var10 = 1;
         if ((var7 & 1) != 0) {
            var10 = var5;
         }

         var2 += var10;
         var8++;
      }

      return var0 >>> 11 << 24 | var2 + var1;
   }

   // $VF: renamed from: m (int) void
   private static void method_103(int var0) {
      short[] var1 = field_233[var0 >>> 11];
      short[] var3 = null;
      field_237 = new short[16384];

      for (int var4 = 0; var4 < 2; var4++) {
         int var5 = var1[1 + (var0 & 2047)];
         short var6 = var1[var5++];
         var5 += 2;
         int var7 = (var1[var5++] + 120 - 1) / 120;
         int var8 = (var1[var5++] + 160 - 1) / 160;
         if (var4 == 0) {
            var3 = new short[var7 * var8];
         } else {
            int var9 = var7 * var8 + 1;

            for (int var10 = 0; var10 < var7 * var8; var10++) {
               short var11 = var3[var10];
               var3[var10] = (short)var9;
               var9 += var11;
            }

            short[] var26;
            (var26 = new short[var9])[0] = var3[0];

            for (int var28 = 0; var28 < var7 * var8; var28++) {
               var26[var28 + 1] = var3[var28];
            }

            var3 = var26;
         }

         int var2;
         int var25;
         while ((var2 = var1[var25 = var5++] & 16383) != 0) {
            for (int var27 = 0; var27 < var6; var27++) {
               var5 = var25 + 1;
               short var10000 = 0;
               if (var6 > 1) {
                  var10000 = var1[var5++];
               }

               short var29 = var10000;
               int var12 = var2 & 0xFF;

               for (int var13 = 0; var13 < var12; var29 >>= 1) {
                  if ((var29 & 1) == 0) {
                     field_234[var13] = var1[var5];
                     var5++;
                  } else {
                     field_234[var13] = var1[var5 + var27];
                     var5 += var6;
                  }

                  var13++;
               }

               int var15 = field_234[0];
               int var16 = field_234[1];
               int var14;
               int var30;
               switch (var2 >> 8) {
                  case 0:
                  case 3:
                     var30 = field_234[3];
                     var14 = field_234[4];
                     break;
                  case 1:
                     if (field_234[2] == -1) {
                        continue;
                     }

                     var30 = method_6(field_234[2] >> 3);
                     var14 = method_5(field_234[2] >> 3);
                     if ((1 << (field_234[2] & 7) & 202) != 0) {
                        int var17 = var30;
                        var30 = var14;
                        var14 = var17;
                     }

                     var15 -= var30 >> 1;
                     var16 -= var14 >> 1;
                     break;
                  case 2:
                     var30 = method_100(field_234[2]);
                     var14 = method_101(field_234[2]);
                     break;
                  default:
                     var15 = 0;
                     var16 = 0;
                     var30 = var7 * 120;
                     var14 = var8 * 160;
                                    break;
}

               int var33 = var15 + var30;
               int var18 = var16 + var14;
               if (var15 >= 0 && var16 >= 0 && var33 <= var1[var1[1 + (var0 & 2047)] + 3] && var18 <= var1[var1[1 + (var0 & 2047)] + 4]) {
                  var15 /= 120;
                  var16 /= 160;
                  var33 = (var33 + 120 - 1) / 120;
                  var18 = (var18 + 160 - 1) / 160;

                  for (int var19 = var16; var19 < var18; var19++) {
                     if ((var19 - var16) % 3 == 0 || var19 == var18 - 1) {
                        for (int var20 = var15; var20 < var33; var20++) {
                           if ((var20 - var15) % 3 == 0 || var20 == var33 - 1) {
                              if (var4 == 0) {
                                 var3[var19 * var7 + var20]++;
                              } else {
                                 var3[var3[var19 * var7 + var20 + 1]++] = (short)var25;
                              }
                           }
                        }
                     }
                  }
               }
            }
         }
      }

      field_235 = var0 + 1;
      field_236 = var3;
   }

   // $VF: renamed from: c (int, int, int, int, int, int) void
   private static void method_104(int var0, int var1, int var2, int var3, int var4, int var5) {
      method_105(var0, 0, var1, 65536, var2, var3, var4, var5);
   }

   // $VF: renamed from: b (int, int, int, int, int, int, int, int) void
   private static void method_105(int var0, int var1, int var2, int var3, int var4, int var5, int var6, int var7) {
      if (var3 > 32767) {
         int var8 = var1;
         var1 = var2;
         var2 = var8;
         var3 = 65536 - var3;
      }

      short[] var29 = field_233[var0 >>> 11];
      int var9 = var0 & 2047;
      var9 = var29[1 + var9];
      short var10 = var29[var9++];
      if (var6 != 1024) {
         var4 -= method_21(var6, method_100(var0));
         var5 -= method_22(var6, method_101(var0));
      } else {
         var4 -= var7 != 4 ? var29[var9] : var29[var9 + 2] - var29[var9];
         var5 -= var29[var9 + 1];
      }

      if (var4 < ScreenW && var5 < ScreenH && var4 + var29[var9 + 2] > 0 && var5 + var29[var9 + 3] > 0) {
         short[] var12 = null;
         int var13 = 0;
         if (false && var0 + 1 == field_235) {
            var12 = field_236;
            int var14 = (var29[var9 + 2] + 120 - 1) / 120;
            int var15 = (var29[var9 + 3] + 160 - 1) / 160;

            int var16;
            int var18;
            for (int var17 = (var16 = -var5 / 160) + (ScreenH / 160 + 3); var16 < var17; var16++) {
               for (int var19 = (var18 = -var4 / 120) + (ScreenW / 120 + 3); var18 < var19; var18++) {
                  if (var18 >= 0 && var16 >= 0 && var18 < var14 && var16 < var15) {
                     int var20 = var16 * var14 + var18;

                     for (int var21 = var12[var20]; var21 < var12[var20 + 1]; var21++) {
                        int var22 = var13++;
                        short var25 = var12[var21];

                        int var23;
                        short var24;
                        while (var22 > 0 && (var24 = field_237[var23 = var22 - 1 >> 1]) > var25) {
                           field_237[var22] = var24;
                           var22 = var23;
                        }

                        field_237[var22] = var25;
                     }
                  }
               }
            }

            field_237[var13] = 32767;
         }

         var9 += 4;

         while (true) {
            int var33;
            int var46;
            int var49;
            while (true) {
               if (var12 != null) {
                  if ((var9 = field_237[0]) == 32767) {
                     return;
                  }

                  do {
                     int var34 = 0;

                     int var36;
                     while ((var36 = var34 * 2 + 1) < var13) {
                        short var38;
                        short var41;
                        if ((var38 = field_237[var36]) > (var41 = field_237[var36 + 1])) {
                           var36++;
                           var38 = var41;
                        }

                        field_237[var34] = var38;
                        var34 = var36;
                     }

                     field_237[var34] = 32767;
                  } while (field_237[0] == var9);
               }

               short var11;
               if ((var11 = var29[var9++]) == 0) {
                  return;
               }

               short var57 = 0;
               if (var10 > 1) {
                  var57 = var29[var9++];
               }

               short var35 = var57;
               int var37 = var11 & 255;
               int var39 = var35;

               for (int var42 = 0; var42 < var37; var39 >>= 1) {
                  if ((var39 & 1) == 0) {
                     field_234[var42] = field_234[var42 + 6] = var29[var9++];
                  } else {
                     field_234[var42] = var29[var9 + var1];
                     field_234[var42 + 6] = var29[var9 + var2];
                     var9 += var10;
                  }

                  var42++;
               }

               var39 = field_234[2];
               int var43 = field_234[8];
               field_151.setColor(
                  ((var39 & 63488) * (65536 - var3) + (var43 & 63488) * var3 >>> 13) * 33 & 0xFF0000
                     | ((var39 & 2016) * (65536 - var3) + (var43 & 2016) * var3 >>> 17) * 65 & 0xFF00
                     | ((var39 & 31) * (65536 - var3) + (var43 & 31) * var3) * 33 >>> 18 & 0xFF
               );
               if ((var11 & 16384) != 16384) {
                  bool var58 = false;
                  if ((var11 & 32768) == 32768) {
                     var58 = true;
                  }

                  bool var44 = var58;
                  var33 = var11 & 16383;

                  for (int var45 = 0; var45 < 6; var45++) {
                     var49 = field_234[var45 + 6] - field_234[var45];
                     field_234[var45 + 6] = field_234[var45];
                     field_234[var45] = field_234[var45] + (var49 * var3 + 32768 >> 16);
                  }

                  if (var44) {
                     if (field_240 != field_239 && field_277) {
                        if (field_234[8] >> 3 >= 13 && field_234[8] >> 3 <= 16) {
                           field_234[8] = -1;
                        } else {
                           field_234[8] = 640;
                        }
                     } else {
                        method_194(var33, field_234);
                     }
                  }

                  var46 = field_234[0];
                  var49 = field_234[1];
                  if (var7 != 4) {
                     break;
                  }

                  switch (var33 >> 8) {
                     case 0:
                        var46 = -var46 - field_234[3];
                        break;
                     case 1:
                        if (field_234[8] == -1) {
                           continue;
                        }

                        int var51 = method_6(field_234[8] >> 3);
                        if ((1 << (field_234[8] & 7) & 202) != 0) {
                           var51 = method_5(field_234[8] >> 3);
                        }

                        var46 = -var46 - (var51 & 1);
                        field_234[8] = field_234[8] ^ ((field_234[8] - 1 & 2) == 0 ? 7 : 4);
                        break;
                     case 2:
                        var46 = -var46 - method_100(field_234[2]);
                                          break;
}

                  var46 += method_100(var0);
                  break;
               }
            }

            var46 += var4;
            var49 += var5;
            switch (var33 >> 8) {
               case 0:
                  field_151.fillRect(var46, var49, field_234[3], field_234[4]);
                  break;
               case 1:
                  if (field_234[8] != -1) {
                     method_10(field_234[8] >> 3, var46, var49, 3, field_234[8] & 7);
                  }
                  break;
               case 2:
                  method_104(field_234[2], 0, var46, var49, 20, 0);
                  break;
               case 3:
                  int var52 = method_5(field_234[2] >> 3);
                  int var53 = method_6(field_234[2] >> 3);
                  method_28(var46, var49, field_234[3], field_234[4]);
                  int var54 = var46 + field_234[3];
                  int var55 = var49 + field_234[4];
                  if (var46 < 0) {
                     var46 -= var46 / var53 * var53;
                  }

                  if (var49 < 0) {
                     var49 -= var49 / var52 * var52;
                  }

                  if (var54 > ScreenW) {
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

                  method_28(0, 0, ScreenW, ScreenH);
                              break;
}
         }
      }
   }

   // $VF: renamed from: f (int) int
   private static int method_106(int var0) {
      return var0 < 0 ? -var0 : var0;
   }

   // $VF: renamed from: b () int
   private static int method_107() {
      if (field_238 == null) {
         field_238 = new JavaRandom();
      }

      return method_106(field_238.nextInt());
   }

   // $VF: renamed from: a (int, bool) short[]
   private static short[] method_108(int var0, bool var1) {
      short[] var2 = new short[512];
      var0 = 30 - var0;
      int var3 = var1 ? 128 : 0;
      long var4 = 1073741824L;
      long var6 = 1073660973L;
      var2[var3] = (short)((int)(var4 >> var0));
      var2[var3 + 1] = (short)((int)(var6 >> var0));

      for (int var8 = 2; var8 < 128; var8++) {
         long var9 = (var6 * 2147321946L >> 30) - var4;
         var2[var3 + var8 & 511] = (short)((int)(var9 >> var0));
         var4 = var6;
         var6 = var9;
      }

      for (int var12 = 127; var12 >= 0; var12--) {
         var2[var3 + 256 - var12 & 511] = (short)(-var2[var3 + var12 & 511]);
      }

      for (int var13 = 255; var13 > 0; var13--) {
         var2[var3 + 256 + var13 & 511] = (short)(-var2[var3 + var13 & 511]);
      }

      return var2;
   }

   // $VF: renamed from: g (int) int
   private static int method_109(int var0) {
      int var1;
      return (var1 = var0 << 13 ^ var0) * (var1 * var1 * 15731 + 789221) + 1376312589 & 2147483647;
   }

   // $VF: renamed from: h (int) int
   private static int method_110(int var0) {
      int var1;
      int var2;
      return ((var2 = ((var1 = var0 - (var0 >> 1 & 1431655765)) & 858993459) + (var1 >> 2 & 858993459)) + (var2 >> 4) & 252645135) * 16843009 >> 24;
   }

   // $VF: renamed from: i (int) int
   private static int method_111(int var0) {
      int var1 = var0;

      while (true) {
         if (var1 == 0) {
            var1 = 1;
         }

         int var2 = var1 + (var0 << 8) / var1 >> 1;
         if (var1 - var2 < 256 && var2 - var1 < 256) {
            return var2;
         }

         var1 = var2;
      }
   }

   // $VF: renamed from: a (int, int, int) int
   private static int method_112(int var0, int var1, int var2) {
      return ((var0 & 16711935) * (256 - var2) + (var1 & 16711935) * var2 & -16711936 | (var0 & 0xFF00) * (256 - var2) + (var1 & 0xFF00) * var2 & 0xFF0000)
         >> 8;
   }

   // $VF: renamed from: a (java.lang.string) int
   private static int method_113(string var0) {
      int var2 = 0;

      for (int var1 = 0; var1 < var0.length(); var1++) {
         char var3 = var0.charAt(var1);
         bool var10000 = false;
         if (var3 == ' ') {
            var10000 = true;
         }

         bool var4 = var10000;
         if (var3 >= '0' && var3 <= '9') {
            var2 += method_6(194 + (var3 - '0'));
         } else if (var3 == '.') {
            var2 += 12;
         } else if (var3 == ':') {
            var2 += 12;
         } else if (var3 == '-') {
            var2 += 16;
         } else if (var3 == '/') {
            var2 += 18;
         } else if (var3 == '*') {
            var2 += 18;
         } else if (var4) {
            var2 += 4;
         }

         if (!var4 && var1 < var0.length() - 1) {
            var2 -= 2;
         }
      }

      return var2;
   }

   // $VF: renamed from: a (java.lang.string, int, int, int) void
   private static void method_114(string var0, int var1, int var2, int var3) {
      var2 += 20;
      int var6 = method_113(var0);
      if ((var3 & 8) != 0) {
         var1 -= var6;
      } else if ((var3 & 1) != 0) {
         var1 -= var6 >> 1;
      }

      if ((var3 & 32) != 0) {
         var2 -= 20;
      } else if ((var3 & 2) != 0) {
         var2 -= 10;
      }

      for (int var4 = 0; var4 < var0.length(); var4++) {
         int var5 = -1;
         char var7;
         if ((var7 = var0.charAt(var4)) >= '0' && var7 <= '9') {
            var6 = method_6(var5 = 194 + (var7 - '0'));
         } else if (var7 == ' ') {
            var1 += 4;
         } else if (var7 == '.') {
            var5 = 211;
            var6 = 12;
         } else if (var7 == ':') {
            var5 = 204;
            var6 = 12;
         } else if (var7 == '*') {
            var5 = 210;
            var6 = 18;
         } else if (var7 == '-') {
            var5 = 205;
            var6 = 16;
         } else if (var7 == '/') {
            var5 = 209;
            var6 = 18;
         }

         if (var5 != -1) {
            method_10(var5, var1, var2, 36, 0);
            var1 += var6 + -2;
         }
      }
   }

   // $VF: renamed from: a (int, int, int, int, int, int, int) void
   private static void method_115(int var0, int var1, int var2, int var3, int var4, int var5, int var6) {
      if (var0 < ScreenW && var0 + var2 >= 0 && var1 < ScreenH && var1 + var3 >= 0 && var2 >= 0 && var3 >= 0) {
         int var8;
         int var15 = ((var8 = (var3 << 8) / var6) >> 8) + 1;
         int var9 = var4 >> 16 & 0xFF;
         int var10 = var4 >> 8 & 0xFF;
         int var11 = var4 & 0xFF;
         int var12 = ((var5 >> 16 & 0xFF) - var9 << 8) / var6;
         int var13 = ((var5 >> 8 & 0xFF) - var10 << 8) / var6;
         int var14 = ((var5 & 0xFF) - var11 << 8) / var6;
         var9 <<= 8;
         var10 <<= 8;
         var11 <<= 8;

         for (int var7 = var1 << 8; var7 < var1 + var3 << 8; var7 += var8) {
            if (var7 >> 8 >= ScreenH) {
               return;
            }

            field_151.setColor(var9 << 8 & 0xFF0000 | var10 & 0xFF00 | var11 >> 8 & 0xFF);
            field_151.fillRect(var0, var7 >> 8, var2, var15);
            var9 += var12;
            var10 += var13;
            var11 += var14;
         }
      }
   }

   // $VF: renamed from: e (int) bool
   private static bool method_116(int var0) {
      switch (var0) {
         case 0:
            return true;
         case 1:
            return method_249(field_347[field_239]);
         case 2:
            bool var61 = false;
            if (field_348[3 * field_239 + 2].field_76 && method_249(field_347[field_239])) {
               var61 = true;
            }

            return var61;
         case 3:
            bool var60 = false;
            if (field_348[3 * field_239].field_76 && (field_348[3 * field_239].field_85 == 1 || field_348[3 * field_239].field_85 == 21)) {
               var60 = true;
            }

            return var60;
         case 4:
            return field_348[3 * field_239].field_76;
         case 5:
            return field_348[3 * field_239 + 2].field_76 ^ true;
         case 6:
            bool var59 = false;
            if ((field_360 & 32) != 0) {
               var59 = true;
            }

            return var59;
         case 7:
            bool var58 = false;
            if ((field_360 & 16) != 0) {
               var58 = true;
            }

            return var58;
         case 8:
            bool var57 = false;
            if ((field_360 & 1) != 0) {
               var57 = true;
            }

            return var57;
         case 9:
            bool var56 = false;
            if ((field_360 & 2) != 0) {
               var56 = true;
            }

            return var56;
         case 10:
            return method_266(32);
         case 11:
            return method_266(16);
         case 12:
            return method_266(1);
         case 13:
            return method_266(2);
         case 14:
            bool var55 = false;
            if (method_272(method_264(0), 1) && method_272(method_264(32), 3)) {
               var55 = true;
            }

            return var55;
         case 15:
            return method_272(method_264(0), field_347[field_239].field_53 ? 128 : 64);
         case 16:
            return method_272(method_264(0), field_347[field_239].field_53 ? 128 : 64) ^ true;
         case 17:
            return method_272(method_264(0), field_347[field_239].field_53 ? 64 : 128);
         case 18:
            return method_272(method_264(0), field_347[field_239].field_53 ? 64 : 128) ^ true;
         case 19:
            return method_272(method_264(0), 252);
         case 20:
            bool var54 = false;
            if (field_348[3 * field_239 + 2].field_76 && !method_273(field_348[3 * field_239 + 2].field_88, 1)
               || field_348[3 * field_239].field_76 && !method_273(field_348[3 * field_239].field_88, 1)) {
               var54 = true;
            }

            return var54;
         case 21:
            bool var53 = false;
            if (field_348[3 * field_239 + 2].field_76 && !method_273(field_348[3 * field_239 + 2].field_88, 98305)
               || field_348[3 * field_239].field_76 && !method_273(field_348[3 * field_239].field_88, 98305)) {
               var53 = true;
            }

            return var53;
         case 22:
            bool var52 = false;
            if ((method_264(32) == 5 || method_264(32) == 6 || method_264(32) == 23 || method_264(32) == 13 || method_264(32) == 14)
               && (
                  (field_347[field_239].field_37 + field_347[field_239].field_41) % 1024 < 2
                     || (field_347[field_239].field_37 + field_347[field_239].field_41) % 1024 > 1022
               )) {
               var52 = true;
            }

            return var52;
         case 23:
            return method_272(method_264(160), field_347[field_239].field_53 ? 2304 : 4608) ^ true;
         case 24:
            bool var51 = false;
            if (method_264(160) == 17 || method_264(160) == 18 || !method_272(method_264(160), field_347[field_239].field_53 ? 2304 : 4608)) {
               var51 = true;
            }

            return var51;
         case 25:
            bool var50 = false;
            if (field_348[3 * field_239].field_76
               && (
                  !field_347[field_239].field_53
                        && field_348[3 * field_239].field_88 == 12
                        && (field_348[3 * field_239].field_85 == 6 || field_348[3 * field_239].field_85 == 23)
                     || field_347[field_239].field_53
                        && field_348[3 * field_239].field_88 == 11
                        && (field_348[3 * field_239].field_85 == 5 || field_348[3 * field_239].field_85 == 23)
               )) {
               var50 = true;
            }

            return var50;
         case 26:
            bool var49 = false;
            if (field_348[3 * field_239].field_76
               && (
                  !field_347[field_239].field_53 && field_348[3 * field_239].field_88 == 12 && field_348[3 * field_239].field_85 == 14
                     || field_347[field_239].field_53 && field_348[3 * field_239].field_88 == 11 && field_348[3 * field_239].field_85 == 13
               )) {
               var49 = true;
            }

            return var49;
         case 27:
            bool var48 = false;
            if (field_348[3 * field_239].field_76
               && (
                  !field_347[field_239].field_53 && field_348[3 * field_239].field_88 == 12 && field_348[3 * field_239].field_85 == 13
                     || field_347[field_239].field_53 && field_348[3 * field_239].field_88 == 11 && field_348[3 * field_239].field_85 == 14
               )) {
               var48 = true;
            }

            return var48;
         case 28:
            bool var47 = false;
            if (field_348[3 * field_239].field_76
               && (
                  !field_347[field_239].field_53
                        && field_348[3 * field_239].field_88 == 12
                        && (field_348[3 * field_239].field_85 == 6 || field_348[3 * field_239].field_85 == 23)
                     || field_347[field_239].field_53
                        && field_348[3 * field_239].field_88 == 11
                        && (field_348[3 * field_239].field_85 == 5 || field_348[3 * field_239].field_85 == 23)
               )) {
               var47 = true;
            }

            return var47 ^ true;
         case 29:
            bool var46 = false;
            if (field_348[3 * field_239 + 2].field_76
               && (
                  field_347[field_239].field_53
                     ? field_348[3 * field_239 + 2].field_85 == 17 && (method_264(32) == 17 || method_264(32) == 5)
                     : field_348[3 * field_239 + 2].field_85 == 18 && (method_264(32) == 18 || method_264(32) == 6)
               )) {
               var46 = true;
            }

            return var46;
         case 30:
            bool var45 = false;
            if (method_264(33) == 18 - (field_347[field_239].field_53 ? 1 : 0)) {
               var45 = true;
            }

            return var45;
         case 31:
            bool var44 = false;
            if (field_348[3 * field_239].field_76
               && (
                  field_347[field_239].field_53 && field_348[3 * field_239].field_85 == 17
                     || !field_347[field_239].field_53 && field_348[3 * field_239].field_85 == 18
               )) {
               var44 = true;
            }

            return var44;
         case 32:
            bool var43 = false;
            if (field_348[3 * field_239 + field_347[field_239].field_30].field_76
               && method_273(field_348[3 * field_239 + field_347[field_239].field_30].field_88, field_347[field_239].field_53 ? 2304 : 4608)) {
               var43 = true;
            }

            return var43;
         case 33:
            bool var42 = false;
            if (field_348[3 * field_239 + field_347[field_239].field_30].field_76
               && method_273(field_348[3 * field_239 + field_347[field_239].field_30].field_88, 6912)) {
               var42 = true;
            }

            return var42;
         case 34:
            bool var41 = false;
            if (field_348[3 * field_239 + field_347[field_239].field_30].field_88 == 1 && (method_264(0) == 15 || method_264(0) == 16)) {
               var41 = true;
            }

            return var41;
         case 35:
            bool var40 = false;
            if (!field_347[field_239].field_53 && method_264(0) == 5 || field_347[field_239].field_53 && method_264(0) == 6) {
               var40 = true;
            }

            return var40;
         case 36:
            return field_348[3 * field_239 + 2].field_76;
         case 37:
            bool var39 = false;
            if (field_348[3 * field_239].field_76
               && (
                  field_348[3 * field_239].field_88 == 1
                     || field_348[3 * field_239].field_88 == 2
                     || field_348[3 * field_239].field_88 == 3
                     || field_348[3 * field_239].field_88 == 4
                     || field_348[3 * field_239].field_88 == 5
                     || field_348[3 * field_239].field_88 == 6
                     || field_348[3 * field_239].field_88 == 7
               )) {
               var39 = true;
            }

            return var39;
         case 38:
            bool var38 = false;
            if (!field_348[3 * field_239 + field_347[field_239].field_30].field_77 && method_249(field_347[field_239])) {
               var38 = true;
            }

            return var38;
         case 39:
            if (field_347[field_239].field_53) {
               bool var37 = false;
               if ((field_347[field_239].field_40 & 1023) > 174 && (field_347[field_239].field_40 & 1023) < 1023) {
                  var37 = true;
               }

               return var37;
            }

            bool var36 = false;
            if ((field_347[field_239].field_40 & 1023) < 850 && (field_347[field_239].field_40 & 1023) > 0) {
               var36 = true;
            }

            return var36;
         case 40:
            bool var35 = false;
            if (method_264(16) != 17 && method_264(16) != 18) {
               var35 = true;
            }

            return var35;
         case 41:
            bool var34 = false;
            if (method_264(16) == 17 || method_264(16) == 18) {
               var34 = true;
            }

            return var34;
         case 42:
            bool var33 = false;
            if (method_264(32) == 17 || method_264(32) == 18) {
               var33 = true;
            }

            return var33;
         case 43:
            bool var32 = false;
            if (method_264(0) != 17 && method_264(0) != 5 && method_264(0) != 18 && method_264(0) != 6) {
               var32 = true;
            }

            return var32;
         case 44:
            bool var31 = false;
            if (method_264(0) != 5 && method_264(0) != 6 && method_264(0) != 17 && method_264(0) != 18 && (method_264(9) == 5 || method_264(9) == 6)) {
               var31 = true;
            }

            return var31;
         case 45:
            return method_265(field_347[field_239], 2000, 400);
         case 46:
            return field_348[3 * field_239 + field_347[field_239].field_30].field_76;
         case 47:
            bool var30 = false;
            if (field_348[3 * field_239 + 2].field_76 && field_348[3 * field_239 + 2].field_85 == 20) {
               var30 = true;
            }

            return var30;
         case 48:
            bool var29 = false;
            if (method_264(0) == 20) {
               var29 = true;
            }

            return var29;
         case 49:
            bool var28 = false;
            if (!field_348[3 * field_239 + field_347[field_239].field_30].field_77 && method_249(field_347[field_239]) && method_264(0) != 20) {
               var28 = true;
            }

            return var28;
         case 50:
            bool var27 = false;
            if (field_348[3 * field_239].field_76 && field_348[3 * field_239].field_85 == 19) {
               var27 = true;
            }

            return var27;
         case 51:
            bool var26 = false;
            if (method_264(32) != 19) {
               var26 = true;
            }

            return var26;
         case 52:
            bool var25 = false;
            if (method_106(field_347[field_239].field_50) > 2560) {
               var25 = true;
            }

            return var25;
         case 53:
            bool var24 = false;
            if (field_359[field_239] < 300) {
               var24 = true;
            }

            return var24;
         case 54:
            bool var23 = false;
            if (field_359[field_239] > 325 && field_358[field_239] == 56) {
               var23 = true;
            }

            return var23;
         case 55:
            bool var22 = false;
            if (method_264(290) == 1) {
               var22 = true;
            }

            return var22;
         case 56:
            bool var21 = false;
            if (method_106(field_347[field_239].field_51) > 6750) {
               var21 = true;
            }

            return var21;
         case 57:
            bool var20 = false;
            if (method_106(field_347[field_239].field_51) > 10200) {
               var20 = true;
            }

            return var20;
         case 58:
            bool var19 = false;
            if (method_106(field_347[field_239].field_51) > 9500) {
               var19 = true;
            }

            return var19;
         case 59:
            bool var18 = false;
            if (method_106(field_347[field_239].field_51) > 15000) {
               var18 = true;
            }

            return var18;
         case 60:
            bool var17 = false;
            if (method_106(field_347[field_239].field_51) > 6400) {
               var17 = true;
            }

            return var17;
         case 61:
            bool var16 = false;
            if (method_264(0) != 22 && method_264(1) != 22) {
               var16 = true;
            }

            return var16;
         case 62:
            bool var15 = false;
            if (method_264(1) == 22
               || method_264(0) == 22
                  && (field_347[field_239].field_53 ? (field_347[field_239].field_40 & 1023) <= 512 : (field_347[field_239].field_40 & 1023) > 512)) {
               var15 = true;
            }

            return var15;
         case 63:
            bool var14 = false;
            if (field_348[3 * field_239].field_76 && (field_348[3 * field_239].field_88 == 15 || field_348[3 * field_239].field_88 == 16)) {
               var14 = true;
            }

            return var14;
         case 64:
            bool var13 = false;
            if (field_348[3 * field_239 + field_347[field_239].field_30].field_85 == 13
               || field_348[3 * field_239 + field_347[field_239].field_30].field_85 == 14) {
               var13 = true;
            }

            return var13;
         case 65:
            bool var12 = false;
            if (method_272(method_264(1), 2) || method_272(method_264(5), 2)) {
               var12 = true;
            }

            return var12 ^ true;
         case 66:
            bool var11 = false;
            if (field_348[3 * field_239 + 2].field_76
               && (field_348[3 * field_239 + 2].field_88 == 9 - (field_347[field_239].field_53 ? 1 : 0) || field_348[3 * field_239 + 2].field_88 == 21)
               && method_272(method_264(128), 98305)
               && method_272(method_264(129), 98305)) {
               var11 = true;
            }

            return var11;
         case 67:
            bool var10 = false;
            if (method_264(0) == 13 || method_264(0) == 14 || method_264(0) == 25 || method_264(0) == 26) {
               var10 = true;
            }

            return var10;
         case 68:
            bool var9 = false;
            if (method_265(field_347[field_239], field_347[field_239].field_47 * 400 / 1024, 400)
                  && method_273(field_346.field_88, 6912)
                  && method_272(method_264(192), field_347[field_239].field_53 ? 2304 : 4608)
               || field_348[3 * field_239 + field_347[field_239].field_30].field_76
                  && method_273(field_348[3 * field_239 + field_347[field_239].field_30].field_88, field_347[field_239].field_53 ? 2304 : 4608)
                  && (
                     method_272(method_264(128), field_347[field_239].field_53 ? 2304 : 4608)
                        || method_272(method_264(129), field_347[field_239].field_53 ? 2304 : 4608)
                  )) {
               var9 = true;
            }

            return var9;
         case 69:
            bool var8 = false;
            if (field_348[3 * field_239 + field_347[field_239].field_30].field_76
               && (
                  field_348[3 * field_239 + field_347[field_239].field_30].field_88 == 8
                     || field_348[3 * field_239 + field_347[field_239].field_30].field_88 == 9
               )
               && !method_272(method_264(129), field_347[field_239].field_53 ? 2304 : 4608)
               && !method_272(method_264(128), field_347[field_239].field_53 ? 2304 : 4608)) {
               var8 = true;
            }

            return var8;
         case 70:
            bool var7 = false;
            if (field_347[field_239].field_47 > 1250) {
               var7 = true;
            }

            return var7;
         case 71:
            bool var6 = false;
            if (method_106(field_347[field_239].field_46) > 1750) {
               var6 = true;
            }

            return var6;
         case 72:
            bool var5 = false;
            if (method_272(method_264(528), field_347[field_239].field_53 ? 2304 : 4608) && !method_272(method_264(528), 6144)) {
               var5 = true;
            }

            return var5;
         case 73:
            return method_272(method_264(544), field_347[field_239].field_53 ? 2304 : 4608);
         case 74:
            bool var4 = false;
            if (method_272(method_264(129), field_347[field_239].field_53 ? 2304 : 4608)
               || method_272(method_264(2049), field_347[field_239].field_53 ? 2304 : 4608)) {
               var4 = true;
            }

            return var4;
         case 75:
            bool var3 = false;
            if (method_272(method_264(1), 1) && method_272(method_264(129), 1)) {
               var3 = true;
            }

            return var3;
         case 76:
            return method_272(method_264(288), 1);
         case 77:
            bool var2 = false;
            if (field_347[field_239].field_40 + field_347[field_239].field_36 + field_347[field_239].field_46 >> 10
               != field_347[field_239].field_40 + field_347[field_239].field_36 >> 10) {
               var2 = true;
            }

            return var2;
         case 78:
            return false;
         case 79:
            bool var1 = false;
            if (field_347[field_239].field_47 > 0) {
               var1 = true;
            }

            return var1;
         case 80:
            bool var10000 = false;
            if (field_347[field_239].field_46 != 0) {
               var10000 = true;
            }

            return var10000;
         default:
            return false;
      }
   }

   // $VF: renamed from: F () void
   private static void method_117() {
      field_241 = null;
   }

   // $VF: renamed from: G () void
   private static void method_118() {
      if (field_241 == null) {
         field_241 = new string[9];
         sbyte[] var0;
         if ((var0 = method_55("str")) == null) {
            field_241[0] = field_145[29];

            for (int var3 = 0; var3 < 8; var3++) {
               field_241[1 + var3] = method_60(field_145[30], "" + (var3 + 1), 1);
            }
         } else {
            try {
               field_156 = new ByteArrayInputStream(var0);
               field_157 = new DataInputStream(field_156);

               for (int var1 = 0; var1 < 9; var1++) {
                  field_241[var1] = field_157.readUTF();
               }

               field_156 = null;
               field_157 = null;
            } catch (Exception var2) {
            }
         }
      }
   }

   // $VF: renamed from: H () void
   private static void method_119() {
      field_241 = null;
   }

   // $VF: renamed from: b (int) java.lang.string
   private static string method_120(int var0) {
      return field_241[var0];
   }

   // $VF: renamed from: a (int, java.lang.string) void
   private static void method_121(int var0, string var1) {
      field_241[var0] = var1;

      try {
         field_154 = new ByteArrayOutputStream();
         field_155 = new DataOutputStream(field_154);

         for (int var2 = 0; var2 < 9; var2++) {
            field_155.writeUTF(field_241[var2]);
         }

         sbyte[] var4 = field_154.toByteArray();
         field_154 = null;
         field_155 = null;
         method_56("str", var4);
      } catch (Exception var3) {
      }
   }

   // $VF: renamed from: I () void
   private static void method_122() {
      method_119();
      method_117();
      method_57("str");
      method_118();

      for (int var0 = 0; var0 < 12; var0++) {
         field_133[7 + var0] = 0;
      }

      method_310();
      field_135[596] = 2;
      field_135[600] = 0;
      method_38();
   }

   // $VF: renamed from: J () void
   private static void method_123() {
      if (field_242 == null) {
         field_247 = 0;
         field_242 = new int[40];
         field_243 = new int[40];
         field_244 = new int[40];
         field_245 = new int[40];
         field_246 = new int[40];
         method_124();
      }
   }

   // $VF: renamed from: K () void
   private static void method_124() {
      for (int var0 = 0; var0 < 40; var0++) {
         field_242[var0] = 0;
      }
   }

   // $VF: renamed from: d (int, int, int, int) void
   private static void method_125(int var0, int var1, int var2, int var3) {
      int var4 = field_247++;
      field_242[var4] = var0;
      if (field_247 >= 40) {
         field_247 = 0;
      }

      field_243[var4] = var1;
      field_244[var4] = var2;
      field_246[var4] = var3;
      switch (var0 & 0xFF) {
         case 1:
            field_245[var4] = 400;
            return;
         case 2:
            field_245[var4] = 0;
            return;
         case 3:
            field_245[var4] = 1800;
            return;
         case 4:
            field_245[var4] = 1400;
            return;
         case 5:
            field_245[var4] = 1800;
                  break;
}
   }

   // $VF: renamed from: n (int) void
   private static void method_126(int var0) {
      for (int var1 = 0; var1 < 40; var1++) {
         if (field_242[var1] == 2) {
            field_245[var1] = field_245[var1] + var0;
            if (field_246[var1] == 0 && field_276 != 11) {
               if (method_269(field_347[field_240].field_40 - field_243[var1], field_347[field_240].field_41 - field_244[var1]) < 2000) {
                  field_246[var1] = 1;
                  field_245[var1] = 0;
               }
            } else if (field_246[var1] == 1) {
               field_243[var1] = field_243[var1] + ((var1 & 1) * 2 - 1) * (var0 * 300 >> 8);
               field_244[var1] = field_244[var1] - ((var0 * 300 >> 8) + (field_404[field_245[var1] >> 3 & 511] * var0 / 30 * 300 >> 14));
            }

            if (field_243[var1] < 0 || field_243[var1] > field_376 << 10) {
               field_242[var1] = 0;
            }

            if (field_276 != 11 && (field_244[var1] < 0 || field_244[var1] > field_377 << 10)) {
               field_242[var1] = 0;
            }
         } else if (field_242[var1] != 0) {
            field_245[var1] = field_245[var1] - var0;
            if (field_245[var1] < 0) {
               field_242[var1] = 0;
            }
         }
      }
   }

   // $VF: renamed from: o (int) void
   private static void method_127(int var0) {
      for (int var1 = 0; var1 < 40; var1++) {
         int var2;
         if (((var2 = field_242[var1]) & 131072) == var0) {
            int var3 = field_243[var1];
            int var4 = field_244[var1];
            int var5 = field_245[var1];
            if ((var2 & 65536) == 0) {
               var3 = (var3 - field_362) * 32 >> 10;
               var4 = (var4 - field_363) * 32 >> 10;
            }

            switch (var2 & 0xFF) {
               case 1:
                  var5 = 400 - var5;

                  for (int var24 = 0; var24 < 4; var24++) {
                     int var29 = method_153(0, var5, var5, 48);
                     int var34 = method_109(var24 * 533 + var1 * 2342 + 5332) % 48 - 24;
                     int var36 = -(method_109(var24 * 745 + var1 * 2341 + 3453) % 48);
                     int var39 = var3 + method_153(0, var34, var5, 400);
                     int var42 = var4 + method_153(0, var36 * 200 + var29, var5, 400 + method_109(var24 * 232 + 422) % 200 - 100) / 200;
                     int var45 = var5 * 2 / 400;
                     method_10(178 - var45, var39, var42, 3, 0);
                  }
                  break;
               case 2:
                  if (field_246[var1] == 0) {
                     method_10(296, var3, var4, 33, 0);
                  } else {
                     int var23 = field_399 >> 7 & 1;
                     int var28 = (var1 & 1) == 1 ? 0 : 4;
                     method_10(297 + var23, var3, var4, 33, var28);
                  }
                  break;
               case 3:
                  var5 = 1800 - var5;

                  for (int var22 = 0; var22 < 15; var22++) {
                     int var26 = (method_109(var22 * 2342 + 241) & 8191) - 4095;
                     int var32 = (method_109(var22 * 6543 + 645) & 8191) - 4095;
                     int var35 = (method_109(var22 * 7653 + 4654) & 8191) - 4095;
                     int var38 = (method_109(var22 * 2343 + 8753) & 8191) - 4095;
                     var26 += var35 * field_404[(var5 >> 4) + 127 & 511] >> 12;
                     var32 += var38 * field_404[(var5 >> 4) + 127 & 511] >> 12;
                     int var41 = var3 + ((var26 * var5 >> 15) * 42 >> 8);
                     int var44 = var4 + ((var32 * var5 + (-614 * var5 * var5 >> 8) >> 15) * 42 >> 8);
                     int var48;
                     if ((var48 = (var5 - (method_109(var22) & 1023)) * 5 / 1800) > 2) {
                        var48 = 4 - var48;
                     }

                     if (var48 < 0) {
                        var48 = 0;
                     }

                     method_10(179 + var48, var41, var44, 3, 0);
                  }
                  break;
               case 4:
                  var5 = 1400 - var5;

                  for (int var21 = 0; var21 < 15 - var5 * 15 / 1400; var21++) {
                     int var31 = method_109(var21 * 523 + 234) % 62 - 31;
                     int var37 = (method_109(var21 * 7653 + 4654) & 2047) - 1023;
                     int var40 = (method_109(var21 * 2343 + 8753) & 2047) - 1023;
                     int var43 = var37 * field_404[(var5 >> 4) + 127 & 511] >> 11;
                     int var47 = var40 * field_404[(var5 >> 4) + 127 & 511] >> 11;
                     int var15 = var3 + (var43 * var5 >> 15) + var31;
                     int var16 = var4 + (var47 * var5 + (300 * var5 * var5 >> 8) >> 15);
                     field_151.setColor(0);
                     field_151.fillRect(var15, var16, 2, 2);
                  }
                  break;
               case 5:
                  var5 = 3400 - var5;

                  for (int var7 = 0; var7 < 25; var7++) {
                     if (var5 <= 2550 + (method_109(var7 * 3787 + 671) >> 1) % 850) {
                        int var8 = (method_109(var7 * 2342 + 241) & 8191) - 4095;
                        int var9 = -4000 + (method_109(var7 * 6543 + 645) & 8191) - 4095;
                        int var10 = (method_109(var7 * 7653 + 4654) & 8191) - 4095;
                        int var11 = (method_109(var7 * 2343 + 8753) & 8191) - 4095;
                        var8 += var10 * field_404[(var5 >> 4) + 127 & 511] >> 12;
                        var9 += var11 * field_404[(var5 >> 4) + 127 & 511] >> 12;
                        int var12 = var3 + ((var8 * var5 >> 15) * 42 >> 8);
                        int var13 = var4 + ((var9 * var5 + (293 * var5 >> 8) * var5 >> 15) * 42 >> 8);
                        int var14;
                        if ((var14 = (var5 - (method_109(var7) & 1023)) * 5 / 3400) > 2) {
                           var14 = 4 - var14;
                        }

                        if (var14 < 0) {
                           var14 = 0;
                        }

                        var14 = 2 - var14;
                        method_10(179 + var14, var12, var13, 3, 0);
                     }
                  }
                              break;
}
         }
      }
   }

   // $VF: renamed from: L () void
   private static void method_128() {
      if (field_248 == null) {
         field_248 = new int[8];
         field_249 = new int[8];
         field_250 = new int[8];
         field_251 = new int[8];
      }

      for (int var0 = 0; var0 < 8; var0++) {
         field_250[var0] = -1;
      }
   }

   // $VF: renamed from: M () void
   private static void method_129() {
      for (int var0 = 0; var0 < 8; var0++) {
         if (field_250[var0] == -1) {
            field_248[var0] = method_107() % 64 - 32;
            field_249[var0] = method_107() % 19 - 9;
            field_250[var0] = field_122;
            field_251[var0] = field_122 + 3500 + method_107() % 1000;
            return;
         }
      }
   }

   // $VF: renamed from: N () void
   private static void method_130() {
      for (int var0 = 0; var0 < 8; var0++) {
         if (field_250[var0] != -1) {
            int var1;
            var1 = (var1 = field_122 - field_250[var0]) * (16 + (method_109(field_251[var0]) >> 1 & 7)) >> 4;
            var1 = 4000 - (4000 - var1) * (4000 - var1) / 4000;
            int var2 = (ScreenW / 2) + field_248[var0] + 32 * field_249[var0] * (var1 * var1 / 1000) / 100000;
            int var3 = ScreenH - var1 * 32 / 620 + (method_106(field_249[var0]) + 7) * var1 * var1 / 4000000;
            if (field_122 >= field_251[var0]) {
               method_125(65541, var2, var3, 0);
               field_250[var0] = -1;
               field_297 = field_122;
               switch (method_107() % 3) {
                  case 0:
                     field_296 = 10027134;
                     break;
                  case 1:
                     field_296 = 37544;
                     break;
                  case 2:
                     field_296 = 1216769;
                                    break;
}
            } else {
               method_10(179, var2, var3, 3, 0);
            }
         }
      }
   }

   // $VF: renamed from: O () void
   private static void method_131() {
      field_252 = -1;
   }

   // $VF: renamed from: P () void
   private static void method_132() {
      if (field_278 != 4 && field_278 != 5) {
         field_252 = 4 + field_323;
      } else {
         field_252 = 3;
      }

      method_15(field_252);
   }

   // $VF: renamed from: a (bool) void
   private static void method_133(bool var0) {
      IsResumingFromPause = !var0;
      if (field_278 != 4 && field_278 != 5) {
         int var1 = 3 + field_323;
         if (var0) {
            field_133[var1] = (sbyte)((field_133[var1] + 1) % 3);
         }

         int var2 = 8 + field_323 * 3 + (field_133[var1] + 2) % 3;
         method_20();
         method_17(var2, 200, 0);
      } else {
         method_20();
         method_17(7, 200, 0);
      }
   }

   // $VF: renamed from: Q () void
   private static void method_134() {
      method_16(field_252);
      field_252 = -1;
   }

   // $VF: renamed from: a (int, bool) java.lang.string
   private static string method_135(int var0, bool var1) {
      int var2;
      int var3;
      int var4 = (var3 = (var2 = method_106(var0)) / 1000) / 60;
      string var5;
      if ((var5 = "" + var2 / 10 % 100).length() == 1) {
         var5 = "0" + var5;
      }

      string var6;
      if ((var6 = "" + var3 % 60).length() == 1) {
         var6 = "0" + var6;
      }

      string var7 = "" + var4;
      return (var1 ? (var0 < 0 ? "-" : "+") : "") + var7 + ':' + var6 + '.' + var5;
   }

   // $VF: renamed from: a () java.lang.string
   private static string method_136() {
      string var0 = "";
      switch (field_284) {
         case 0:
            var0 = method_60(field_145[190], method_135(field_285, false), 1);
            break;
         case 1:
            var0 = method_60(field_145[191], "" + field_285, 1);
            break;
         case 2:
            var0 = method_60(field_145[189], method_135(field_285, false), 1);
                  break;
}

      return var0;
   }

   // $VF: renamed from: a (int, int, int, int, int) int
   private static int method_137(int var0, int var1, int var2, int var3, int var4) {
      return (var2 >= var0 || var4 >= var0) && (var2 < var0 || var4 < var0) ? var1 + (var0 - var2) * (var3 - var1) / (var4 - var2) : 0;
   }

   // $VF: renamed from: b (int, int, int, int, int) int
   private static int method_138(int var0, int var1, int var2, int var3, int var4) {
      return (var1 >= var0 || var3 >= var0) && (var1 < var0 || var3 < var0) ? var2 + (var0 - var1) * (var4 - var2) / (var3 - var1) : 0;
   }

   // $VF: renamed from: d (int, int) int
   private static int method_139(int var0, int var1) {
      if (var1 == 0) {
         return 0;
      } else {
         return var0 == 0 ? 10 : 7 - var0;
      }
   }

   // $VF: renamed from: b (java.lang.string) int
   private static int method_140(string var0) {
      int var1 = method_27(0) + 2;
      field_151.setColor(2758677);
      field_151.drawRect(-1, -1, ScreenW + 1, var1 + 1);
      field_151.setColor(16728334);
      field_151.fillRect(0, 0, ScreenW, var1);
      field_151.setColor(9510656);
      method_23(0, var0, ScreenW / 2, 1, 17);
      return var1 + 1;
   }

   // $VF: renamed from: c () int
   private static int method_141() {
      return method_27(0) + 2 + 1;
   }

   // $VF: renamed from: c (int, int, int) void
   private static void method_142(int var0, int var1, int var2) {
      var2 += 0;
      if (field_124) {
         if (field_255) {
            method_10(162, var1 - var2 + 6, var0, 6, 4);
         }

         if (field_256) {
            method_10(162, var1 + var2 - 6, var0, 10, 0);
         }
      }
   }

   // $VF: renamed from: d (bool, bool) void
   private static void method_143(bool var0, bool var1) {
      field_255 = var0;
      field_256 = var1;
   }

   // $VF: renamed from: a (int, java.lang.string, bool, bool, bool) int
   private static int method_144(int var0, string var1, bool var2, bool var3, bool var4) {
      int var5;
      if ((var5 = method_27(0) + 2) < 16) {
         var5 = 16;
      }

      if (!var2) {
         field_151.setColor(16777215);
      } else {
         field_151.setColor(2758677);
      }

      field_151.drawRect(-1, var0 - 1, ScreenW + 1, var5 + 1);
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
      }

      return var5 + 1;
   }

   // $VF: renamed from: p (int) void
   private static void method_145(int var0) {
      field_253 = var0;
   }

   // $VF: renamed from: q (int) void
   private static void method_146(int var0) {
      field_254 = var0;
   }

   // $VF: renamed from: d () int
   private static int method_147() {
      int var10000 = 0;
      if (field_121 - field_253 >= 0) {
         var10000 = field_121 - field_253;
      }

      return var10000;
   }

   // $VF: renamed from: e () int
   private static int method_148() {
      return field_254;
   }

   // $VF: renamed from: f () int
   private static int method_149() {
      int var0;
      if ((var0 = method_27(0) + 2) < 16) {
         var0 = 16;
      }

      return var0 + 1;
   }

   // $VF: renamed from: a (int, int, bool) int
   private static int method_150(int var0, int var1, bool var2) {
      if (var0 == 0) {
         if (var1 < 2) {
            return var2 ? 142 : 141;
         } else {
            return var2 ? 146 + (var1 - 2) * 2 : 145 + (var1 - 2) * 2;
         }
      } else if (field_342[var0 * 28 + 2] == 4) {
         return var2 ? 144 + var1 * 2 : 143 + var1 * 2;
      } else {
         return var2 ? 146 + var1 * 2 : 145 + var1 * 2;
      }
   }

   // $VF: renamed from: b (int, int, int) int
   private static int method_151(int var0, int var1, int var2) {
      if (var0 < var1) {
         return var1;
      } else {
         return var0 > var2 ? var2 : var0;
      }
   }

   // $VF: renamed from: e (int, int) int
   private static int method_152(int var0, int var1) {
      return var1 < var0 ? var1 : var0;
   }

   // $VF: renamed from: b (int, int, int, int) int
   private static int method_153(int var0, int var1, int var2, int var3) {
      return ((var3 - var2) * var0 + var2 * var1) / var3;
   }

   // $VF: renamed from: R () void
   private static void method_154() {
      field_258 = new sbyte[2048];
      field_259 = 0;

      for (int var0 = 0; var0 < 2048; var0++) {
         field_258[var0] = -1;
      }

      field_260 = new int[20];
      field_261 = null;
      field_262 = 0;
      field_263 = 0;
      field_264 = new int[20];
      field_265 = new sbyte[10];
   }

   // $VF: renamed from: S () void
   private static void method_155() {
      field_259 = 0;

      for (int var0 = 0; var0 < 2048; var0++) {
         field_258[var0] = -1;
      }

      field_262 = 0;
      field_263 = 0;
   }

   // $VF: renamed from: r (int) void
   private static void method_156(int var0) {
      if (field_259 + var0 > field_258.Length) {
         sbyte[] var1 = new sbyte[field_258.Length];

         for (int var2 = 0; var2 < field_258.Length; var2++) {
            var1[var2] = field_258[var2];
         }

         field_258 = null;
         field_258 = new sbyte[var1.Length + 2048];

         for (int var3 = 0; var3 < field_258.Length; var3++) {
            if (var3 < var1.Length) {
               field_258[var3] = var1[var3];
            } else {
               field_258[var3] = -1;
            }
         }
      }
   }

   // $VF: renamed from: s (int) void
   private static void method_157(int var0) {
      field_258[field_259++] = (sbyte)(var0 >> 24 & 0xFF);
      field_258[field_259++] = (sbyte)(var0 >> 16 & 0xFF);
      field_258[field_259++] = (sbyte)(var0 >> 8 & 0xFF);
      field_258[field_259++] = (sbyte)(var0 & 0xFF);
   }

   // $VF: renamed from: g () int
   private static int method_158() {
      int var0 = (field_258[field_259] & 255) << 24
         | (field_258[field_259 + 1] & 255) << 16
         | (field_258[field_259 + 2] & 255) << 8
         | field_258[field_259 + 3] & 255;
      field_259 += 4;
      return var0;
   }

   // $VF: renamed from: T () void
   private static void method_159() {
      for (int var0 = 0; var0 < field_258.Length; var0++) {
         field_258[var0] = -1;
      }

      field_259 = 0;
      method_157(field_398);
      method_157(field_347[field_239].field_29);
      method_157(field_358[field_239]);
      method_157(field_359[field_239]);
      method_157(field_347[field_239].field_40);
      method_157(field_347[field_239].field_41);
      method_157(field_347[field_239].field_46);
      method_157(field_347[field_239].field_47);
      method_157(field_347[field_239].field_48);
      method_157(field_347[field_239].field_49);
      method_157(field_347[field_239].field_50);
      method_157(field_347[field_239].field_51);
      method_157(field_347[field_239].field_75);
      method_157(field_347[field_239].field_58);
      method_157(field_347[field_239].field_59);
      method_157(field_347[field_239].field_60);
      method_157(field_347[field_239].field_61);
      method_157(field_347[field_239].field_62);
      method_157(field_347[field_239].field_63);
      method_157(field_347[field_239].field_64);
      method_157(field_347[field_239].field_65);
      method_157(field_347[field_239].field_66);
      method_157(field_347[field_239].field_67);
      method_157(field_347[field_239].field_68);
      method_157(field_347[field_239].field_69);
      method_157(field_347[field_239].field_70);
      method_157(field_347[field_239].field_71);
      method_157(field_347[field_239].field_72);
      field_258[field_259++] = (sbyte)(field_347[field_239].field_53 ? 1 : 0);
      field_258[field_259++] = (sbyte)(field_347[field_239].field_54 ? 1 : 0);
      method_157(0);
      field_262 = 0;
      field_263 = 0;
   }

   // $VF: renamed from: U () void
   private static void method_160() {
      field_259 = 0;
      field_398 = method_158();
      field_347[field_239].field_29 = method_158();
      field_358[field_239] = method_158();
      field_359[field_239] = method_158();
      field_347[field_239].field_40 = method_158();
      field_347[field_239].field_41 = method_158();
      field_347[field_239].field_44 = field_347[field_239].field_40;
      field_347[field_239].field_45 = field_347[field_239].field_41;
      field_347[field_239].field_46 = method_158();
      field_347[field_239].field_47 = method_158();
      field_347[field_239].field_48 = method_158();
      field_347[field_239].field_49 = method_158();
      field_347[field_239].field_50 = method_158();
      field_347[field_239].field_51 = method_158();
      field_347[field_239].field_75 = method_158();
      field_347[field_239].field_58 = method_158();
      field_347[field_239].field_59 = method_158();
      field_347[field_239].field_60 = method_158();
      field_347[field_239].field_61 = method_158();
      field_347[field_239].field_62 = method_158();
      field_347[field_239].field_63 = method_158();
      field_347[field_239].field_64 = method_158();
      field_347[field_239].field_65 = method_158();
      field_347[field_239].field_66 = method_158();
      field_347[field_239].field_67 = method_158();
      field_347[field_239].field_68 = method_158();
      field_347[field_239].field_69 = method_158();
      field_347[field_239].field_70 = method_158();
      field_347[field_239].field_71 = method_158();
      field_347[field_239].field_72 = method_158();
      class_2 var10000 = field_347[field_239];
      bool var10001 = false;
      if (field_258[field_259++] == 1) {
         var10001 = true;
      }

      var10000.field_53 = var10001;
      var10000 = field_347[field_239];
      var10001 = false;
      if (field_258[field_259++] == 1) {
         var10001 = true;
      }

      var10000.field_54 = var10001;
      method_158();
      field_264[field_239 * 2] = 0;
      field_264[field_239 * 2 + 1] = 0;
      field_265[field_239] = 0;
      field_262 = 0;
      field_263 = 0;
   }

   // $VF: renamed from: V () void
   private static void method_161() {
      for (int var0 = 0; var0 < field_240; var0++) {
         field_239 = var0;

         for (int var1 = 0; var1 < field_260[var0 * 2]; var1++) {
            field_258[var1] = field_261[method_165(var0) + var1];
         }

         method_160();
         field_260[var0 * 2 + 1] = method_165(var0) + field_259;
      }
   }

   // $VF: renamed from: W () void
   private static void method_162() {
      int var0;
      if ((var0 = field_342[field_401 * 28 + 6]) != -1) {
         field_258 = null;
         field_258 = method_52(field_136[67 + var0 * 3], field_136[67 + var0 * 3 + 1], field_136[67 + var0 * 3 + 2], null);
         field_266 = field_342[field_401 * 28 + 7];
         field_285 = (field_258[114] & 255) << 24 | (field_258[115] & 255) << 16 | (field_258[116] & 255) << 8 | field_258[117] & 255;
         field_285 = field_285 + field_266;
         field_259 = field_258.Length;
         method_166(0);
         field_240++;
         method_161();
         method_185(0);
      }
   }

   // $VF: renamed from: a (sbyte) void
   private static void method_163(sbyte var0) {
      if (var0 != field_262) {
         method_156(5);
         method_157(field_263);
         field_258[field_259++] = field_262;
         field_263 = 1;
         field_262 = var0;
      } else {
         field_263++;
      }
   }

   // $VF: renamed from: a (int) sbyte
   private static sbyte method_164(int var0) {
      int var1 = var0 * 2 + 1;
      if (field_264[var0 * 2] == field_264[var0 * 2 + 1]) {
         if (field_260[var1] >= field_260[var1 - 1] + method_165(var0)) {
            field_265[var0] = -1;
         } else {
            field_265[var0] = field_261[field_260[var1] + 4];
            int var2 = (field_261[field_260[var1]] & 255) << 24
               | (field_261[field_260[var1] + 1] & 255) << 16
               | (field_261[field_260[var1] + 2] & 255) << 8
               | field_261[field_260[var1] + 3] & 255 & 0xFF;
            field_260[var1] = field_260[var1] + 5;
            field_264[var0 * 2 + 1] = field_264[var0 * 2 + 1] + var2;
            if (var2 == 0) {
               field_265[var0] = -1;
            }
         }
      }

      field_264[var0 * 2]++;
      return field_265[var0];
   }

   // $VF: renamed from: j (int) int
   private static int method_165(int var0) {
      int var1 = 0;

      for (int var2 = 0; var2 < var0; var2++) {
         var1 += field_260[var2 * 2];
      }

      return var1;
   }

   // $VF: renamed from: t (int) void
   private static void method_166(int var0) {
      method_156(5);
      method_157(field_263);
      field_258[field_259++] = field_262;
      method_163((sbyte)-1);
      int var1 = field_259;
      field_259 = 114;
      method_157(field_399);
      if (field_261 == null) {
         field_261 = new sbyte[var1];
      } else {
         sbyte[] var2 = new sbyte[field_261.Length];

         for (int var3 = 0; var3 < var2.Length; var3++) {
            var2[var3] = field_261[var3];
         }

         field_261 = null;
         field_261 = new sbyte[var2.Length + var1];

         for (int var5 = 0; var5 < var2.Length; var5++) {
            field_261[var5] = var2[var5];
         }
      }

      int var4 = 0;

      for (int var6 = field_261.Length - var1; var6 < field_261.Length; var6++) {
         field_261[var6] = field_258[var4++];
      }

      field_260[var0 * 2] = var1;
      field_260[var0 * 2 + 1] = method_165(var0);
   }

   // $VF: renamed from: a (int, java.lang.string, int, bool, bool) void
   private static void method_167(int var0, string var1, int var2, bool var3, bool var4) {
      int var6 = 4;
      if (var0 != -1) {
         field_275 = var0;
         var6 = 4 + field_108.getHeight() + 8;
      }

      method_94(0, var1, MenuOffsetX + 4, MenuOffsetY + var6, 232, 240, 4, 4, 8, true);
      field_267 = field_122 + var2;
      field_270 = var4;
      field_269 = var3;
      field_272 = 0;
      field_271 = 0;
      field_273 = false;
      field_274 = false;
      method_170();
      field_268 = 0;
   }

   // $VF: renamed from: a (int, java.lang.string, int, bool, bool, bool) void
   private static void method_168(int var0, string var1, int var2, bool var3, bool var4, bool var5) {
      method_167(var0, var1, var2, var3, var4);
      field_273 = true;
   }

   // $VF: renamed from: b () java.lang.string
   private static string method_169() {
      method_167(193 + field_288 - 1, field_145[192], 0, false, false);
      field_271 = 2;
      field_274 = true;
      string var0 = method_97(field_145[28], method_120(0), 24, 8);
      return var0;
   }

   // $VF: renamed from: X () void
   private static void method_170() {
      if (field_269 && field_382 != -1) {
         method_282(field_382 - 512, field_383 - (ScreenH * 32) + 1536);
         if (field_347[field_240].field_40 < field_382 >> 1) {
            field_347[field_240].field_53 = true;
         } else {
            field_347[field_240].field_53 = false;
         }

         method_185(field_240);
      }
   }

   // $VF: renamed from: f (int) bool
   private static bool method_171(int var0) {
      if (field_273 && method_63(var0, 43)) {
         method_333();
         return true;
      } else {
         if (method_63(var0, 262152)) {
            if (field_222 >= field_198 - 1) {
               field_267 = -1;
               return true;
            }

            method_96(1);
            field_272++;
         } else if (method_63(var0, 131074) && field_222 < field_198 - 1) {
            method_96(1);
            field_272++;
         } else if (method_63(var0, 131072) && field_222 > 0) {
            method_96(3);
            field_272--;
         } else {
            method_329(var0);
         }

         return false;
      }
   }

   // $VF: renamed from: Y () void
   private static void method_172() {
      int var0 = field_108.getHeight() + 8;
      int var1 = field_214;
      int var2 = field_215;
      int var3 = field_216;
      int var4 = field_217;
      if (field_271 == 0) {
         var0 = 0;
      }

      field_151.setColor(14472400);
      field_151.fillRect(var1, var2 - var0, var3, var4 + var0);
      field_151.setColor(0);
      field_151.drawRect(var1, var2 - var0, var3, var4 + var0);
      if (field_271 > 0 && field_272 == 0) {
         int var5 = field_215 + 1;
         if (field_271 == 1) {
            field_151.setColor(9510656);
         } else {
            field_151.setColor(16728334);
         }

         field_151.fillRect(var1 + 1, var5 - var0, var3 - 1, var0);
         field_151.setColor(9510656);
         field_151.fillRect(var1 + 1, var5 + var0 - var0, var3 - 1, 1);
         field_151.setColor(16777215);
         method_23(0, field_145[field_275], ScreenW / 2, var5 - var0 + 4, 17);
         field_151.setColor(9510656);
      }

      if (field_269) {
         method_10(183, var1 + (var3 >> 3), var2 + var4, 20, 0);
      }

      method_93(field_221, field_218, field_219, field_222);
      bool var10000 = false;
      if (field_222 > 0) {
         var10000 = true;
      }

      bool var10001 = false;
      if (field_222 < field_198 - 1) {
         var10001 = true;
      }

      method_84(var10000, var10001);
      sbyte var7 = 24;
      sbyte var6 = -1;
      if (field_274) {
         var6 = 26;
      }

      if (field_222 < field_198 - 1) {
         var7 = 23;
      }

      if (field_273) {
         var6 = 22;
      }

      method_86(var7, var6);
      field_268 = field_268 + field_123;
   }

   // $VF: renamed from: b () bool
   private static bool method_173() {
      switch (field_284) {
         case 0:
         case 2:
            if (field_285 < field_280[6 * field_239 + 5]) {
               return false;
            }
            break;
         case 1:
            if (field_285 > field_345[field_240].field_18) {
               return false;
            }
                  break;
}

      return true;
   }

   // $VF: renamed from: g (int, int) void
   private static void method_174(int var0, int var1) {
      if (field_280 == null) {
         field_280 = new int[48];
      }

      if (field_281 == null) {
         field_281 = new int[8];
      }

      if (field_282 == null) {
         field_282 = new int[8];
      }

      for (int var2 = 0; var2 < 48; var2++) {
         field_280[var2] = 0;
      }

      bool var10000 = false;
      if (var1 > 1) {
         var10000 = true;
      }

      field_277 = var10000;
      field_239 = 0;
      field_240 = 0;
      field_278 = var0;
      field_283 = 0;
      field_286 = 5;
      field_403 = var1;
      field_287 = false;
      field_276 = -1;
      method_179(0);
   }

   // $VF: renamed from: h () int
   private static int method_175() {
      if (field_276 < 5) {
         switch (field_278) {
            case 4:
               return 2;
            case 5:
               return 2;
         }
      } else if (field_278 == 5) {
         return 2;
      }

      return 1;
   }

   // $VF: renamed from: g (int) bool
   private static bool method_176(int var0) {
      switch (field_276) {
         case 1:
            if (method_63(var0, 262152)) {
               if (field_298 < method_175()) {
                  field_298++;
                  method_177();
               } else {
                  method_180();
               }
            }
            break;
         case 2:
         case 3:
         case 4:
         default:
            if (method_63(var0, 262152)) {
               method_180();
               return false;
            }
            break;
         case 5:
            if (field_267 == -1 || field_122 < field_267) {
               if (method_63(var0, 131072)) {
                  field_360 |= 1;
               }

               if (method_63(var0, 131074)) {
                  field_360 |= 2;
               }

               if (method_63(var0, 131078)) {
                  field_360 = field_360 | 4 + (field_347[field_240].field_53 ? 16 : 32);
               }

               if (method_63(var0, 131076)) {
                  field_360 = field_360 | 8 + (field_347[field_240].field_53 ? 32 : 16);
               }
            }
                  break;
}

      return true;
   }

   // $VF: renamed from: Z () void
   private static void method_177() {
      switch (field_276) {
         case 1:
            int var2 = field_278 == 4 ? 165 : 169;
            string var1 = field_145[var2 + field_298];
            method_167(-1, var1, field_298 == 1 ? 2000 : 0, true, true);
            if (field_298 == 1) {
               method_283(0);
            }

            return;
         case 6:
            int var0 = field_278 == 4 ? 168 : 172 + field_298;
            method_318(field_401, field_402);
            method_167(-1, field_145[var0], 0, true, true);
            goto case 2;
         case 2:
         case 3:
         case 4:
         case 5:
                  break;
}
   }

   // $VF: renamed from: aa () void
   private static void method_178() {
      for (int var0 = 0; var0 <= field_240; var0++) {
         field_239 = var0;
         method_242();
         if (var0 == field_240) {
            method_230();
         }

         method_225();
      }

      method_161();
      field_373 = -1;
      field_372 = -1;
      field_239 = field_240;
      method_159();
   }

   // $VF: renamed from: u (int) void
   private static void method_179(int var0) {
      field_276 = var0;
      field_298 = 0;
      switch (var0) {
         case 0:
            method_180();
            return;
         case 1:
            method_177();
            return;
         case 2:
            string var15 = "";
            if (field_278 == 0) {
               var15 = field_145[178];
            } else if (field_278 == 1) {
               var15 = field_145[179];
            } else if (field_278 == 2) {
               var15 = method_60(field_145[180], "" + field_285, 1);
            } else if (field_278 == 3) {
               if (field_401 == 2) {
                  var15 = field_145[181];
               }

               if (field_401 == 3) {
                  var15 = field_145[182];
               }

               if (field_401 == 5) {
                  var15 = field_145[183];
               }

               if (field_401 == 6) {
                  var15 = field_145[184];
               }

               if (field_401 == 8) {
                  var15 = field_145[185];
               }

               if (field_401 == 10) {
                  var15 = field_145[186];
               }

               if (field_401 == 11) {
                  var15 = field_145[187];
               }
            }

            bool var10003 = false;
            if (field_278 == 0) {
               var10003 = true;
            }

            method_167(-1, var15, 0, var10003, true);
            if (field_278 == 0) {
               method_185(1);
            }

            method_185(field_240);
            return;
         case 3:
            method_178();
            string var13 = method_60(field_145[160], field_314[field_240], 1);
            if (field_278 == 0) {
               var13 = method_60(var13, method_60(field_145[190], method_135(field_342[field_401 * 28 + 5], false), 1), 2);
            } else {
               var13 = method_60(var13, "", 2);
            }

            field_389 = 0;
            field_390 = 1;
            method_167(-1, var13, 0, false, true);
            method_185(field_240);
            return;
         case 4:
            method_284();
            return;
         case 5:
            method_178();
            method_133(true);
            method_190();
            field_398 = 0;
            field_399 = 0;
            field_283 = 0;
            if (field_278 == 3) {
               switch (field_401) {
                  case 2:
                  case 3:
                  case 5:
                  case 6:
                     field_286 = 1;
                     break;
                  case 4:
                  default:
                     field_286 = 0;
                                    break;
}
            } else {
               field_286 = 5;
            }

            return;
         case 6:
            method_318(field_401, field_402);
            if (field_278 == 4) {
               method_167(-1, field_145[168], 0, true, true);
            } else if (field_278 == 5) {
               method_167(-1, field_145[172 + field_298], 0, true, true);
            }

            return;
         case 7:
            string var11 = field_145[188];
            short var16 = -1;
            field_279 = -1;
            if (!field_287) {
               field_288 = method_312(field_345[field_240].field_18, field_280[6 * field_239 + 5]);
            }

            bool var3 = false;
            sbyte var4 = 1;
            if (field_278 == 3) {
               switch (field_401) {
                  case 2:
                  case 3:
                  case 5:
                  case 6:
                     if (field_285 - field_399 <= 0 && field_285 > 0) {
                        var16 = 177;
                     } else if (field_401 == 3 && (field_361 & 2) == 0) {
                        var11 = field_145[196];
                        var4 = 0;
                     } else if (field_401 != 5 || (field_361 & 4) != 0 && (field_361 & 8) != 0 && (field_361 & 16) != 0) {
                        if (field_401 != 6 || (field_361 & 32) != 0 && (field_361 & 64) != 0) {
                           method_318(field_401, field_402);
                           var16 = 175;
                           var3 = true;
                           var4 = 2;
                        } else {
                           var11 = field_145[198];
                           var4 = 0;
                        }
                     } else {
                        var11 = field_145[197];
                        var4 = 0;
                     }
                     goto case 4;
                  case 4:
                  case 7:
                  case 9:
                  default:
                     break;
                  case 8:
                  case 10:
                  case 11:
                     short var5 = 2000;
                     if (field_401 == 10) {
                        var5 = 3200;
                     }

                     if (field_401 == 11) {
                        var5 = 5000;
                     }

                     if (field_345[field_240].field_18 < var5) {
                        var11 = field_145[199];
                        var4 = 0;
                     } else {
                        method_318(field_401, field_402);
                        var11 = method_60(var11, field_145[175], 1);
                        var4 = 0;
                        var3 = true;
                     }
                                    break;
}
            } else if (field_287) {
               var16 = 177;
            } else if (field_288 > 0 && method_173()) {
               method_318(field_401, field_402);
               var16 = 176;
               var4 = 2;
               var3 = true;
            } else if (method_173()) {
               method_318(field_401, field_402);
               var16 = 175;
               var4 = 2;
               var3 = true;
            } else {
               var16 = 174;
            }

            field_289 = var3;
            if (!var3) {
               field_288 = 0;
            }

            if (!field_294) {
               bool var17 = true;

               for (int var6 = 0; var6 < 12; var6++) {
                  if (!method_320(var6)) {
                     var17 = false;
                     break;
                  }
               }

               if (var17) {
                  field_294 = true;
                  field_135[596] = 0;
                  field_135[600] = 2;
                  field_290 = true;
               }
            }

            var11 = method_60(
               method_60(method_60(var11, method_136(), 1), method_135(field_280[6 * field_239 + 5], false), 2), "" + field_345[field_240].field_18, 3
            );
            if (field_288 == 0) {
               method_168(var16, var11, 0, false, false, false);
            } else {
               method_167(var16, var11, 0, false, false);
            }

            field_271 = var4;
            return;
         case 8:
            method_169();
            return;
         case 9:
            string var9 = method_60(field_145[159], field_145[92 + field_279], 1);
            bool var2 = false;
            field_279 = -1;
            method_168(158, var9, 0, false, false, false);
            field_271 = 2;
            return;
         case 10:
            string var1 = field_145[161];
            if (field_280[6 * field_240 + 5] == 0) {
               var1 = field_145[162];
            } else {
               var1 = method_60(method_60(var1, "" + field_345[field_240].field_18, 2), method_135(field_280[6 * field_240 + 5], false), 3);
            }

            var1 = method_60(var1, field_314[field_240], 1);
            method_167(-1, var1, 0, false, false);
            return;
         case 11:
            field_291 = field_122;
            field_292 = 0;
            field_297 = -10000;
            field_378 = 53;
            field_379 = 4;
            field_382 = 52224;
            field_383 = 4096;
            method_242();
            method_185(field_240);
            method_281(53248 - (ScreenW * 16), -2048);
            FormatPrizeText();
            field_267 = -1;
            field_135[568] = 2;
            field_135[532] = 0;
            field_135[556] = 2;
            field_290 = false;
            method_20();
            method_17(2, 128, 0);
            return;
         case 12:
            return;
         case 13:
            method_328();
                  break;
}
   }

   // $VF: renamed from: ab () void
   private static void method_180() {
      switch (field_276) {
         case 0:
            if (field_293) {
               method_179(11);
            } else if (field_278 == 4 || field_278 == 5) {
               method_179(1);
            } else if (field_277) {
               method_179(3);
            } else {
               method_179(2);
            }

            return;
         case 1:
         case 2:
         case 3:
            if (field_278 == 0) {
               method_179(4);
            } else {
               method_179(5);
            }

            return;
         case 4:
            method_179(5);
            return;
         case 5:
            if (field_278 == 4 || field_278 == 5) {
               method_179(6);
            } else if (field_277) {
               method_179(10);
            } else {
               method_179(7);
            }

            return;
         case 6:
            method_179(13);
            return;
         case 7:
            if (field_288 > 0) {
               method_179(8);
            } else if (field_279 != -1) {
               method_179(9);
            } else if (field_290) {
               method_179(11);
            } else {
               method_179(13);
            }

            return;
         case 8:
            if (field_279 != -1) {
               method_179(9);
            } else if (field_290) {
               method_179(11);
            } else {
               method_179(13);
            }

            return;
         case 9:
            method_179(13);
            return;
         case 10:
            method_166(field_240);
            field_240++;
            if (field_240 == field_403) {
               method_72(12);
               method_179(13);
            } else {
               field_373 = -1;
               field_372 = -1;
               method_280(field_347[field_240]);
               method_179(3);
            }

            return;
         case 12:
            method_179(0);
            goto case 11;
         case 11:
         case 13:
                  break;
}
   }

   // $VF: renamed from: ac () void
   private static void method_181() {
      for (int var0 = 0; var0 < 8; var0++) {
         field_281[var0] = field_282[var0] = var0;
      }

      for (int var3 = field_403 - 1; var3 > 0; var3--) {
         for (int var1 = 0; var1 < var3; var1++) {
            if (field_280[6 * field_281[var1] + 5] > field_280[6 * field_281[var1 + 1] + 5] && field_280[6 * field_281[var1 + 1] + 5] > 0
               || field_280[6 * field_281[var1] + 5] == 0) {
               int var2 = field_281[var1];
               field_281[var1] = field_281[var1 + 1];
               field_281[var1 + 1] = var2;
            }

            if (field_345[field_282[var1]].field_18 < field_345[field_282[var1 + 1]].field_18 && field_280[6 * field_282[var1 + 1] + 5] > 0
               || field_280[6 * field_282[var1] + 5] == 0) {
               int var4 = field_282[var1];
               field_282[var1] = field_282[var1 + 1];
               field_282[var1 + 1] = var4;
            }
         }
      }
   }

   // $VF: renamed from: a () int[]
   private static int[] method_182() {
      if (field_299 == null) {
         field_299 = new int[8];
      }

      int[] var0 = field_299;
      int var1 = 0;

      while (var1 < field_403) {
         var0[var1] = var1++;
      }

      for (int var4 = field_403 - 1; var4 > 0; var4--) {
         for (int var2 = 0; var2 < var4; var2++) {
            if (method_139(method_183(var0[var2], true), field_280[6 * var0[var2] + 5])
                  + method_139(method_183(var0[var2], false), field_280[6 * var0[var2] + 5])
               < method_139(method_183(var0[var2 + 1], true), field_280[6 * var0[var2 + 1] + 5])
                  + method_139(method_183(var0[var2 + 1], false), field_280[6 * var0[var2 + 1] + 5])) {
               int var3 = var0[var2];
               var0[var2] = var0[var2 + 1];
               var0[var2 + 1] = var3;
            }
         }
      }

      return var0;
   }

   // $VF: renamed from: a (int, bool) int
   private static int method_183(int var0, bool var1) {
      for (int var2 = 0; var2 < field_403; var2++) {
         int var3 = field_281[var2];
         if (!var1) {
            var3 = field_282[var2];
         }

         if (var0 == var3) {
            return var2;
         }
      }

      return -1;
   }

   // $VF: renamed from: ad () void
   private static void method_184() {
      if (field_300 == null) {
         field_300 = method_54(1, 9464, 1210, null);
         field_301 = new class_0[10];

         for (int var0 = 0; var0 < 10; var0++) {
            field_301[var0] = new class_0();
            field_301[var0].field_0 = 1;
            field_301[var0].field_1 = 0;
            field_301[var0].field_2 = 0;
            field_301[var0].field_13 = 0;
            field_301[var0].field_4 = 1;
            field_301[var0].field_5 = -1;
            field_301[var0].field_6 = 0;
            field_301[var0].field_7 = false;
            field_301[var0].field_8 = 0;
            field_301[var0].field_9 = 0;
            field_301[var0].field_11 = false;
            field_301[var0].field_12 = false;
            field_301[var0].field_10 = 0;
            field_301[var0].field_15 = 0;
            field_301[var0].field_16 = 0;
         }
      }
   }

   // $VF: renamed from: v (int) void
   private static void method_185(int var0) {
      int var1 = field_239;
      field_239 = var0;
      method_186(228, 0, 3);
      field_301[field_239].field_5 = -1;
      field_301[field_239].field_12 = field_301[field_239].field_11 = false;
      field_239 = var1;
   }

   // $VF: renamed from: d (int, int, int) void
   private static void method_186(int var0, int var1, int var2) {
      field_301[field_239].field_3 = var2;
      field_301[field_239].field_14 = var1;
      field_301[field_239].field_0 = field_300[var0];
      field_301[field_239].field_2 = var0 + 1;
      if (field_301[field_239].field_3 != 0 && field_301[field_239].field_3 != 5 && field_301[field_239].field_3 != 6) {
         field_301[field_239].field_1 = 0;
         field_301[field_239].field_13 = 0;
         field_301[field_239].field_7 = field_347[field_239].field_53 ^ true;
      }

      if (field_301[field_239].field_3 == 1 || field_301[field_239].field_3 == 2 || field_301[field_239].field_3 == 9) {
         if (field_301[field_239].field_3 != 9 && field_301[field_239].field_3 != 10) {
            field_301[field_239].field_10 = 0;
         }

         if (field_301[field_239].field_12 == field_347[field_239].field_54) {
            class_0 var10000 = field_301[field_239];
            int var10002 = 0;
            if (field_301[field_239].field_12) {
               var10002 = field_347[field_239].field_42;
            }

            var10000.field_8 = field_347[field_239].field_44 + var10002;
            var10000 = field_301[field_239];
            var10002 = 0;
            if (field_301[field_239].field_12) {
               var10002 = field_347[field_239].field_43;
            }

            var10000.field_9 = field_347[field_239].field_45 + var10002;
         }
      }

      if (field_301[field_239].field_3 == 2 || field_301[field_239].field_3 == 10) {
         field_301[field_239].field_1 = (field_301[field_239].field_0 << 10) - 1;
      }

      class_0 var4 = field_301[field_239];
      bool var10001 = false;
      if ((field_357[field_358[field_239] * 14 + 8] & 1) != 0) {
         var10001 = true;
      }

      var4.field_12 = var10001;
      if ((field_357[field_358[field_239] * 14 + 8] & 8192) != 0) {
         field_301[field_239].field_5 = -1;
      }

      if ((field_357[field_358[field_239] * 14 + 8] & 16384) != 0 && field_301[field_239].field_12 != field_301[field_239].field_11) {
         field_301[field_239].field_5 = -1;
      }
   }

   // $VF: renamed from: a (int, int, bool) void
   private static void method_187(int var0, int var1, bool var2) {
      if (var2 || field_399 > field_301[field_239].field_16) {
         field_301[field_239].field_15 = var0;
         field_301[field_239].field_16 = field_399 + var1;
      }
   }

   // $VF: renamed from: ae () void
   private static void method_188() {
      if ((method_107() & 63) == 0) {
         method_187(76, 250, false);
      }

      if ((method_107() & 63) == 0) {
         method_187(77, 250, false);
      }

      int var0 = method_106(field_347[field_239].field_50 - field_347[field_239].field_46);
      int var1 = method_106(field_347[field_239].field_51 - field_347[field_239].field_47);
      if (var0 > 5000 || var1 > 5000) {
         method_187(78, 400, true);
      }
   }

   // $VF: renamed from: af () void
   private static void method_189() {
      short var0 = field_300[field_301[field_239].field_5 % field_301[field_239].field_4 + field_301[field_239].field_6];
      int var1 = method_102(0, var0, 18090, 2);
      int var2;
      if ((var2 = field_233[var1 >> 24][var1 & 16777215] >> 3) >= 76 && var2 <= 79) {
         field_233[var1 >> 24][var1 & 16777215] = 200;
      }
   }

   // $VF: renamed from: ag () void
   private static void method_190() {
      for (int var0 = 0; var0 < 10; var0++) {
         field_301[var0].field_16 = 0;
      }
   }

   // $VF: renamed from: w (int) void
   private static void method_191(int var0) {
      int var1 = field_301[field_239].field_1;
      if (field_301[field_239].field_3 != 0
         && field_301[field_239].field_3 != 1
         && field_301[field_239].field_3 != 9
         && field_301[field_239].field_3 != 2
         && field_301[field_239].field_3 != 10) {
         if (field_301[field_239].field_3 == 6) {
            field_301[field_239].field_13 -= var0;
         } else if (field_301[field_239].field_3 == 8 && field_347 != null) {
            field_301[field_239].field_13 = field_301[field_239].field_13 + var0 * (method_106(field_347[field_239].field_46 * 500 >> 10) + 1700) / 3400;
         } else {
            field_301[field_239].field_13 += var0;
         }
      }

      if (field_301[field_239].field_3 == 4 || field_301[field_239].field_3 == 7) {
         field_301[field_239].field_1 = field_301[field_239].field_13 * field_301[field_239].field_0 / field_301[field_239].field_14 >> 10;
         if (field_301[field_239].field_3 == 7) {
            field_301[field_239].field_1 = field_301[field_239].field_0 - field_301[field_239].field_1 - 1;
         }

         field_301[field_239].field_10 = field_301[field_239].field_13 * field_301[field_239].field_0 / field_301[field_239].field_14 >> 2 & 0xFF;
      } else if (field_301[field_239].field_3 == 3
         || field_301[field_239].field_3 == 5
         || field_301[field_239].field_3 == 6
         || field_301[field_239].field_3 == 8) {
         sbyte var2 = 13;
         if (field_301[field_239].field_2 == 229) {
            var2 = 4;
         } else if ((field_357[field_358[field_239] * 14 + 8] & 512) != 0) {
            var2 = 15;
         } else if ((field_357[field_358[field_239] * 14 + 8] & 1024) != 0) {
            var2 = 10;
         }

         field_301[field_239].field_1 = field_301[field_239].field_13 * var2 / 1000 >> 10;
         field_301[field_239].field_10 = field_301[field_239].field_13 * var2 / 1000 >> 2 & 0xFF;
         if (field_301[field_239].field_3 == 6) {
            field_301[field_239].field_10 = 255 - field_301[field_239].field_10;
         }
      } else if (field_301[field_239].field_3 == 1
         || field_301[field_239].field_3 == 2
         || field_301[field_239].field_3 == 9
         || field_301[field_239].field_3 == 0
         || field_301[field_239].field_3 == 10) {
         field_301[field_239].field_10 += var0 >> 10;
         if (field_301[field_239].field_10 > 255) {
            field_301[field_239].field_5 = -1;
         }
      }

      if (field_301[field_239].field_3 == 4 && field_301[field_239].field_1 >= field_301[field_239].field_0) {
         field_301[field_239].field_1 = field_301[field_239].field_0 - 1;
         field_301[field_239].field_5 = field_301[field_239].field_1;
      } else if (field_301[field_239].field_3 != 3 && field_301[field_239].field_3 != 8) {
         if (field_301[field_239].field_3 == 5 || field_301[field_239].field_3 == 6) {
            while (field_301[field_239].field_1 < 0) {
               field_301[field_239].field_1 = field_301[field_239].field_1 + field_301[field_239].field_0;
            }

            if (field_301[field_239].field_0 > 0) {
               field_301[field_239].field_1 = field_301[field_239].field_1 % field_301[field_239].field_0;
            }
         } else if (field_301[field_239].field_3 == 7 && field_301[field_239].field_1 < 0) {
            field_301[field_239].field_1 = 0;
            field_301[field_239].field_5 = 0;
         }
      } else if (field_301[field_239].field_0 > 0) {
         field_301[field_239].field_1 = field_301[field_239].field_1 % field_301[field_239].field_0;
      }

      method_188();
      if (field_301[field_239].field_1 != var1) {
         method_189();
         field_301[field_239].field_5 = var1;
         field_301[field_239].field_6 = field_301[field_239].field_2;
         field_301[field_239].field_4 = field_301[field_239].field_0;
         if (field_301[field_239].field_3 == 4 || field_301[field_239].field_3 == 7 || field_301[field_239].field_3 == 3 || field_301[field_239].field_3 == 8) {
            class_0 var10000 = field_301[field_239];
            int var10002 = 0;
            if (field_301[field_239].field_12) {
               var10002 = field_347[field_239].field_42;
            }

            var10000.field_8 = field_347[field_239].field_44 + var10002;
            var10000 = field_301[field_239];
            var10002 = 0;
            if (field_301[field_239].field_12) {
               var10002 = field_347[field_239].field_43;
            }

            var10000.field_9 = field_347[field_239].field_45 + var10002;
         }

         field_301[field_239].field_11 = field_301[field_239].field_12;
         field_301[field_239].field_12 = field_347[field_239].field_54;
      }

      if (field_347[field_239].field_53 == field_301[field_239].field_7) {
         if (field_301[field_239].field_6 == 459) {
            field_301[field_239].field_6 = 470;
         } else if (field_301[field_239].field_6 == 472) {
            field_301[field_239].field_6 = 482;
         } else if (field_301[field_239].field_6 == 287) {
            field_301[field_239].field_6 = 296;
         } else if (field_301[field_239].field_6 == 539) {
            field_301[field_239].field_6 = 550;
         } else if (field_301[field_239].field_6 == 144) {
            field_301[field_239].field_6 = 158;
         } else if (field_301[field_239].field_6 == 331) {
            field_301[field_239].field_6 = 331;
         } else if (field_301[field_239].field_6 == 103) {
            field_301[field_239].field_6 = 482;
         }

         if (field_301[field_239].field_6 != 310) {
            field_301[field_239].field_5 = 0;
            field_301[field_239].field_4 = 1;
            field_301[field_239].field_7 = field_347[field_239].field_53 ^ true;
         }
      }

      if (field_301[field_239].field_13 < 0) {
         field_301[field_239].field_13 = 0;
      }
   }

   // $VF: renamed from: ah () void
   private static void method_192() {
      int var0 = field_347[field_239].field_44;
      int var1 = field_347[field_239].field_45;
      if (field_347[field_239].field_54) {
         var0 += field_347[field_239].field_42;
         var1 += field_347[field_239].field_43;
      }

      bool var2 = field_347[field_239].field_53;
      if ((field_357[field_358[field_239] * 14 + 8] & 4096) != 0 && field_347[field_239].field_53 != field_301[field_239].field_7) {
         var2 ^= true;
      }

      bool var10000 = false;
      if (field_301[field_239].field_5 != -1 && (field_357[field_358[field_239] * 14 + 8] & 32) == 0) {
         var10000 = true;
      }

      bool var3 = var10000;
      short var4 = field_300[field_301[field_239].field_5 % field_301[field_239].field_4 + field_301[field_239].field_6];
      short var5 = field_300[field_301[field_239].field_1 % field_301[field_239].field_0 + field_301[field_239].field_2];
      if (var3 && field_301[field_239].field_12 != field_301[field_239].field_11) {
         var0 = var0 * field_301[field_239].field_10 + field_301[field_239].field_8 * (256 - field_301[field_239].field_10) >> 8;
         var1 = var1 * field_301[field_239].field_10 + field_301[field_239].field_9 * (256 - field_301[field_239].field_10) >> 8;
      }

      method_105(
         0, var4, var5, var3 ? field_301[field_239].field_10 << 8 : 65535, (var0 - field_362) * 32 >> 10, (var1 - field_363) * 32 >> 10, 1024, var2 ? 0 : 4
      );
   }

   // $VF: renamed from: ai () void
   private static void method_193() {
      if (field_382 != -1 && (field_278 != 0 || field_276 == 11)) {
         short var1 = field_300[483];
         int var4 = field_121 % 5000 << 10;
         if (field_267 == -1 || field_122 < field_267) {
            var4 = 0;
         }

         int var5 = var4 * var1 / 5000 >> 10;
         int var6 = var4 * var1 / 5000 >> 2 & 0xFF;
         short var7 = field_300[var5 % var1 + 484];
         short var8 = field_300[(var5 + 1) % var1 + 484];
         int var9 = field_382 + 512;
         int var10 = field_383 + 1024;
         field_302 = true;
         method_105(0, var7, var8, var6 << 8, (var9 - field_362) * 32 >> 10, (var10 - field_363) * 32 >> 10, 1024, 0);
         field_302 = false;
      }
   }

   // $VF: renamed from: a (int, int[]) void
   private static void method_194(int var0, int[] var1) {
      if (var0 >> 8 == 1) {
         int var4;
         int var2 = (var4 = var1[8]) >> 3;
         int var3 = var4 & 7;
         if (field_338[field_240] == 0 && var2 == 25 && field_301[field_239].field_16 > field_399 && (var3 == 0 || var3 == 4)) {
            var1[8] = field_301[field_239].field_15 << 3 | var3;
         }

         var4 = 1 - field_339;
         if (field_276 == 11) {
            if (field_302) {
               var4 = 0;
            } else {
               var4 = 1;
            }
         } else if (field_277) {
            var4 = field_338[field_240];
         } else if (field_239 != field_240 || field_302) {
            var4 = field_342[field_401 * 28 + 12];
         }

         if (var4 > 0) {
            var4--;
            if (var2 >= 25 && var2 <= 29) {
               var1[8] = 82 + var4 * 5 + (var2 - 25) << 3 | var3;
            }

            if (var4 == 0 || var4 == 1 || var4 == 3 || var4 == 6 || var4 == 8) {
               if (var2 >= 34 && var2 <= 38) {
                  var1[8] = 127 + (var2 - 34) << 3 | var3;
               }

               if (var2 >= 57 && var2 <= 61) {
                  var1[8] = 132 + (var2 - 57) << 3 | var3;
               }
            }

            if (var2 >= 13 && var2 <= 16) {
               var1[8] = -1;
            }
         }
      }
   }

   // $VF: renamed from: aj () void
   private static void method_195() {
      if (field_304 == null) {
         field_304 = method_54(0, 62, 120, null);
         field_305 = method_54(0, 182, 3704, null);
      }

      field_303 = 0;
      method_196();
   }

   // $VF: renamed from: ak () void
   private static void method_196() {
      field_307 = 715517;
      field_306 = 715517;
      field_309 = 0;
      field_308 = 0;

      for (int var0 = 1; var0 <= field_304[field_303 * 3 + 1]; var0++) {
         short var1 = field_300[field_304[field_303 * 3] + var0];
         if (field_305[var1 * 4] < field_306) {
            field_306 = field_305[var1 * 4];
         }

         if (field_305[var1 * 4 + 1] < field_307) {
            field_307 = field_305[var1 * 4 + 1];
         }

         if (field_305[var1 * 4 + 2] > field_308) {
            field_308 = field_305[var1 * 4 + 2];
         }

         if (field_305[var1 * 4 + 3] > field_309) {
            field_309 = field_305[var1 * 4 + 3];
         }
      }

      int var2 = method_141() + method_149();
      string var3 = "\u001b24:\u0015" + (field_303 + 1) + "/20\n";
      method_94(0, var3 + field_145[field_304[field_303 * 3 + 2]], MenuOffsetX, var2, 240, ScreenH - var2 - method_27(1024), 4, 4, 8, true);
      method_143(true, true);
   }

   // $VF: renamed from: x (int) void
   private static void method_197(int var0) {
      if (method_63(var0, 43)) {
         method_17(1, 128, 1);
         method_83();
      } else {
         if (method_63(var0, 131078)) {
            if (++field_303 >= 20) {
               field_303 = 0;
            }

            method_196();
         }

         if (method_63(var0, 131076)) {
            if (--field_303 < 0) {
               field_303 = 19;
            }

            method_196();
         }

         if (method_63(var0, 131072)) {
            method_95(4);
         }

         if (method_63(var0, 131074)) {
            method_95(2);
         }
      }
   }

   // $VF: renamed from: al () void
   private static void method_198() {
      field_151.setColor(12102307);
      field_151.fillRect(0, 0, ScreenW, ScreenH);
      int var0;
      var0 = (var0 = method_140(field_145[85])) + method_144(var0, field_145[31 + field_303], false, false, true);
      method_28(0, var0, ScreenW, ScreenH - var0);
      method_93(field_221, field_218, field_219, field_222);
      method_28(0, 0, ScreenW, ScreenH);
      bool var10000 = false;
      if (field_222 > 0) {
         var10000 = true;
      }

      bool var10001 = false;
      if (field_222 < field_198 - 1) {
         var10001 = true;
      }

      method_84(var10000, var10001);
      method_86(-1, 5);
   }

   // $VF: renamed from: am () void
   private static void method_199() {
      method_7(2);
      field_310 = -1;
      method_17(2, 128, 1);
      method_15(1);
      field_311 = false;
   }

   // $VF: renamed from: an () void
   private static void method_200() {
      if (field_121 - field_310 >= 13000 && field_311) {
         method_20();
      }

      if (field_310 != -1 && field_121 - field_310 > 7000 && !field_311) {
         method_20();
         method_17(4, 128, 1);
         field_311 = true;
      }
   }

   // $VF: renamed from: ao () void
   private static void method_201() {
      if (field_310 < 0) {
         field_310 = field_121;
      }

      int var0 = field_121 - field_310;
      int var1 = 16728334;
      if (var0 >= 13000) {
         field_165.keyPressed(field_135[18] - 50);
      }

      if (var0 >= 7000 && var0 < 7512) {
         var1 = method_112(16777215, var1, (var0 - 7000) / 2);
      }

      field_151.setColor(var1);
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
            bool var6 = false;
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
      }

      if (var0 >= 2500 && var0 < 12512) {
         int var19 = 0;
         int var20 = 0;
         int var7 = 0;
         int var8 = 0;
         int var9 = 0;
         int var10 = 0;
         int var11 = 0;
         bool var12 = true;
         bool var13 = true;
         bool var14 = true;
         if (var0 <= 7000) {
            int var15 = (7000 - var0) / 300;
            var19 = method_109((field_121 >> 6) + 53) % (30 * (var15 + 1)) - 30 * (var15 + 1) / 2;
            var20 = method_109((field_121 >> 6) + 121) % (20 * (var15 + 1)) - 20 * (var15 + 1) / 2;
            var7 = method_109((field_121 >> 6) + 43) % (60 * (var15 + 1)) - 60 * (var15 + 1) / 2;
            var8 = method_109((field_121 >> 6) + 194) % (20 * (var15 + 1)) - 20 * (var15 + 1) / 2;
            var9 = method_109((field_121 >> 6) + 75) % (60 * (var15 + 1)) - 60 * (var15 + 1) / 2;
            var10 = method_109((field_121 >> 6) + 23) % (20 * (var15 + 1)) - 20 * (var15 + 1) / 2;
            bool var10000 = false;
            if (method_109((field_121 >> 7) + 73) / 2 % (var15 + 5) == 0) {
               var10000 = true;
            }

            var12 = var10000;
            var10000 = false;
            if (method_109((field_121 >> 7) + 33) / 2 % (var15 + 5) == 0) {
               var10000 = true;
            }

            var13 = var10000;
            var10000 = false;
            if (method_109((field_121 >> 7) + 23) / 2 % (var15 + 5) == 0) {
               var10000 = true;
            }

            var14 = var10000;
         }

         if (var0 >= 12000) {
            int var16;
            var16 = (var16 = var0 - 12000) * var16 / 512;
            var19 -= var16 * 240 / 512;
            var7 += var16 * 240 / 512;
            var10 -= var16 * 320 / 512;
            var11 = 0 + var16 * 320 / 512;
         }

         if (var12) {
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
         }
      }
   }

   // $VF: renamed from: y (int) void
   private static void method_202(int var0) {
      method_145(0);
      if (var0 == 0) {
         field_293 = false;
      }

      if (field_341 && (field_159 || !field_158)) {
         method_17(7, 0, 0);
      }

      if (var0 == 11) {
         field_239 = 0;
         field_240 = 0;
         field_399 = 0;
         field_302 = false;
         field_277 = false;
      }

      if (var0 == 0 && field_332) {
         field_332 = false;
         if (field_277) {
            method_82(6);
         } else {
            method_82(5);
            field_324 = true;
            if (field_340) {
               int var1 = field_323 * 3 + field_319;
               int var2 = field_342[var1 * 28 + 2];
               if (field_322 < var2 - 1 && !method_319(var1, field_322 + 1)) {
                  field_322++;
                  field_327 = field_121 + 2000;
                  field_340 = false;
                  field_326 = field_145[116 + (field_342[field_321 * 28 + 3] >> (field_322 << 2) & 15)];
                  bool var10000 = false;
                  if (field_322 > 0) {
                     var10000 = true;
                  }

                  bool var10001 = false;
                  if (field_322 < field_342[field_321 * 28 + 2] - 1) {
                     var10001 = true;
                  }

                  method_143(var10000, var10001);
               }

               if (method_320(var1)) {
                  while (method_320(var1) && var1 < 11) {
                     var1++;
                  }

                  field_323 = var1 / 3;
                  field_319 = var1 % 3;
                  field_322 = 0;
                  field_320 = field_321;
                  field_321 = var1;
                  field_325 = field_321 + 1 + ". " + field_145[92 + field_321];
                  field_326 = field_145[116 + (field_342[field_321 * 28 + 3] >> (field_322 << 2) & 15)];
                  method_211(0, false, true);
                  method_214(1);
                  field_312 = true;
                  field_341 = false;
                  return;
               }
            }

            field_312 = true;
         }
      }

      if (var0 == 0 || var0 == 5 || var0 == 6) {
         field_341 = false;
      }
   }

   // $VF: renamed from: z (int) void
   private static void method_203(int var0) {
      if (var0 == 1) {
         field_169 = true;
      }

      if (var0 == 10 || field_336 == 0 && var0 == 16) {
         if (field_276 == 11) {
            method_20();
         }

         field_169 = true;
         method_328();
      }

      if (var0 == 16 && field_336 > 0) {
         field_345[field_239].field_18 = 0;
         field_280[6 * field_240 + 5] = 0;
         method_179(10);
         field_169 = true;
      }

      if (var0 == 26) {
         field_293 = true;
         field_401 = 11;
         field_278 = 3;
         field_169 = true;
      }

      if (var0 == 19) {
         method_333();
         field_169 = true;
      }

      if (var0 == 24) {
         method_42();
         method_310();
      }

      if (var0 == 8) {
         method_42();
         method_122();
      }

      if (var0 == 9) {
         method_133(false);
         field_169 = true;
      }
   }

   // $VF: renamed from: b (bool) void
   private static void method_204(bool var0) {
      if (var0) {
         field_339 = 0;
         field_312 = false;
      }

      field_318 = 0;
      field_323 = 0;
      field_319 = 0;
      field_320 = 0;
      field_321 = 0;
      field_322 = 0;
      field_325 = field_321 + 1 + ". " + field_145[92 + field_321];
      field_326 = "";
      field_324 = true;
      field_316 = 0;
      field_317 = 0;
      method_143(false, true);
      field_315 = false;
   }

   // $VF: renamed from: A (int) void
   private static void method_205(int var0) {
      if (var0 == 11) {
         method_195();
      }

      if (var0 == 6) {
         field_335 = 0;
         if (field_336 == 0) {
            field_336 = 2;
         }

         field_337 = -1;
         field_315 = false;
         field_328 = 4;
         int var1 = method_24(0, "WWWWWWWW");
         int var2 = method_24(0, "wwwwwwww");
         field_329 = var1 > var2 ? var1 : var2;
         field_330 = method_27(0) + field_328;
         field_331 = 57;
         field_329 = field_329 + field_331;
         field_324 = true;
      } else if (var0 == 5) {
         field_336 = 0;
         field_324 = true;
         if (!field_312) {
            method_204(false);
         }
      }

      if (var0 >= 12 && var0 <= 14) {
         method_220(var0);
      }
   }

   // $VF: renamed from: i () int
   private static int method_206() {
      int var10000 = 0;
      if (field_336 > 1 && (field_321 == 0 || field_321 > 7 && field_342[field_321 * 28 + 2] == 4)) {
         var10000 = 0;
         if (field_336 > 1) {
            sbyte var0 = 0;
            if (field_321 == 0) {
               var0 = 1;
            }

            var10000 = var0 + 1;
         }
      }

      return var10000;
   }

   // $VF: renamed from: e (int, int, int, int) void
   private static void method_207(int var0, int var1, int var2, int var3) {
      int var5 = method_206();
      int var6 = field_342[var0 * 28 + 2] - var5;
      int var7 = 30 * var6;
      int var9 = var2;

      for (int var10 = 0; var10 < var6; var10++) {
         bool var11 = method_319(var0, var10 + var5);
         if (var10 + var5 == var1 - 1 && field_327 - field_121 > 0 && field_124) {
            var11 = false;
         }

         int var8 = method_150(var0, var10 + var5, var11);
         if (var10 + var5 == var1) {
            var9 -= (field_404[field_121 / 3 * 2 & 511] * 32 >> 10) / 7;
         } else {
            var9 = var2;
         }

         method_10(var8, var3 - var7 / 2 + var10 * 30 + 15, var9, 17, 0);
      }
   }

   // $VF: renamed from: a (int, int, int, int, bool, int, int) void
   private static void method_208(int var0, int var1, int var2, int var3, bool var4, int var5, int var6) {
      if (var4) {
         field_151.setColor(var5);
         field_151.fillRect(var0 - 1, var1 - 1, var2 + 2, var3 + 2);
         field_151.setColor(var6);
         field_151.fillRect(var0, var1, var2, var3);
      } else {
         field_151.setColor(var5);
         field_151.fillRect(var0 - 1, var1 - 1, var2 + 2, var3 + 2);
         field_151.setColor(var6);
         field_151.fillRect(var0, var1, var2, var3);
      }
   }

   // $VF: renamed from: ap () void
   private static void method_209() {
      int var0 = 0;
      method_143(true, true);
      var0 = (var0 = method_140(field_145[130])) + method_144(var0, field_339 == 0 ? field_145[126] : field_145[127], false, true, true);
      var0 += 45 + (UseRemasterMode ? 75 : 0);
      short var3 = 161;
      short var4 = 160;
      sbyte var5 = 0;
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
         method_94(1024, field_339 == 0 ? field_145[128] : field_145[129], MenuOffsetX, var0, 240, ScreenH - (var0 + method_27(1024) + 4), 1, 1, 8, true);
         field_324 = false;
      } else {
         field_151.setColor(16777215);
         field_112 = 0;
         method_93(field_221, field_218, field_219, field_222);
      }

      bool var10000 = false;
      if (field_222 > 0) {
         var10000 = true;
      }

      bool var10001 = false;
      if (field_222 < field_198 - 1) {
         var10001 = true;
      }

      method_84(var10000, var10001);
   }

   // $VF: renamed from: B (int) void
   private static void method_210(int var0) {
      int var1 = 0;
      field_168 = false;
      short var2 = 4;
      sbyte var3 = 5;
      if (var0 == 5 && !field_312) {
         method_209();
         method_86(4, 5);
      } else if (var0 == 11) {
         method_198();
      } else {
         if (var0 >= 12 && var0 <= 14) {
            method_219(var0);
         }

         if (var0 == 6 && !field_315) {
            method_140(field_145[21]);
            field_151.setColor(9510656);
            int var4 = 0;
            bool var5 = false;
            bool var6 = false;
            var4 = (ScreenH - field_330 - (method_27(1024) + 4 + 2 + method_27(0) * 3)) / field_330;

            for (int var7 = 0; var7 < 10; var7++) {
               int var8 = (ScreenW / 2) - field_329 / 2;
               int var9 = (UseRemasterMode ? 35 : 0) + 2 + field_330 * var7 + method_27(0);
               if (field_336 > var4 && var7 > 1 && field_335 - 2 >= var4) {
                  var9 -= field_330 * (field_335 - 1 - var4);
               }

               if (field_336 > var4 && field_335 <= field_336) {
                  var6 = true;
               }

               if (field_335 > var4 + 1) {
                  var5 = true;
               }

               bool var10 = true;
               if (var9 + field_328 / 4 < 2 + method_27(0) * 3) {
                  var10 = false;
               }

               if (var9 > ScreenH - (method_27(1024) + 4) - field_330) {
                  var10 = false;
               }

               if (field_335 == 1) {
                  var2 = -1;
               } else if (field_335 > 0) {
                  var2 = 6;
               }

               if (var7 == field_335) {
                  field_333 = var8;
                  field_334 = var9;
               }

               if (var7 == field_335 && field_337 == -1) {
                  if (var7 > 0) {
                     method_208(0, var9, ScreenW, field_330 - field_328 / 2, false, 16777215, 7430492);
                  } else {
                     method_208(0, var9, ScreenW, field_330 - field_328 / 2, false, 16777215, 2758677);
                  }
               }

               if (var7 - 1 > field_336) {
                  field_151.setColor(7430492);
               } else {
                  field_151.setColor(16777215);
                  field_112 = 0;
               }

               if (var7 == 0) {
                  method_23(1024, field_145[25], ScreenW / 2, var9 + field_328 / 4, 17);
               } else if (var7 == 1) {
                  if (field_335 == 1) {
                     bool var10000 = false;
                     if (field_336 > 2) {
                        var10000 = true;
                     }

                     bool var10001 = false;
                     if (field_336 < 8) {
                        var10001 = true;
                     }

                     method_143(var10000, var10001);
                     method_142(var9 + field_330 / 2 - field_328 / 4, ScreenW / 2, 120);
                  }

                  method_23(1024, method_60(field_145[146], "" + field_336, 1), ScreenW / 2, var9 + field_328 / 4, 17);
               } else if (var10) {
                  if (var10) {
                     if (var7 - 1 > field_336) {
                        method_23(0, field_314[var7 - 2], var8, var9 + field_328 / 4, 20);
                     } else {
                        method_23(1024, field_314[var7 - 2], var8, var9 + field_328 / 4, 20);
                     }
                  }

                  int var11 = field_338[var7 - 2];
                  int var12 = var8 + field_329 - field_331 / 2;
                  int var13 = var9 + 2;
                  bool var14 = false;
                  bool var15 = false;
                  if (var7 - 2 < field_336) {
                     method_10(method_218(var11), var12, var13, 17, 0);
                  }

                  if (var7 == field_335 && field_337 == -1) {
                     bool var56 = false;
                     if (var11 > 0) {
                        var56 = true;
                     }

                     bool var60 = false;
                     if (var11 < 9) {
                        var60 = true;
                     }

                     method_143(var56, var60);
                     method_142(var9 + field_330 / 2 - field_328 / 4, var12, 39);
                  }
               }
            }

            if (field_337 != -1) {
               var2 = 24;
               var3 = 26;
            }

            method_86(var2, var3);
            method_84(var5, var6);
         }

         if (var0 == 5 || var0 == 6 && field_315) {
            var2 = 4;
            sbyte var31 = 0;
            int var32 = 0;
            if (field_318 == 0) {
               var31 = 90;
            } else if (field_318 == 1) {
               var31 = 90;
            } else if (field_318 == 2) {
               var31 = 91;
               var2 = 144;
            }

            int var33 = (field_121 - field_316) * 256;
            if (field_318 != 2) {
               if (field_318 == 1) {
                  method_211(1, true, false);
               }

               int var43 = field_313[field_321 * 2];
               int var48 = field_313[field_321 * 2 + 1];
               int var34 = field_313[field_320 * 2];
               int var41 = field_313[field_320 * 2 + 1];
               if (var33 > 65536) {
                  var33 = 65536;
               }

               if (var33 < 0) {
                  var33 = 0;
               }

               var43 = var43 * var33 + var34 * (65536 - var33) >> 16;
               var48 = var48 * var33 + var41 * (65536 - var33) >> 16;
               int var51 = var43;
               int var52 = var48;
               int var53 = 0;

               for (int var54 = 0; var54 < 12; var54++) {
                  int var16 = field_313[var54 * 2];
                  int var17 = field_313[var54 * 2 + 1];
                  int var20 = 164 + var54;
                  if (!method_323(var54)) {
                     var20 = 163;
                  }

                  int var21 = method_6(var20);
                  int var22 = method_5(var20);
                  if (var54 == field_321) {
                     var32 = var22;
                  }

                  int var18 = var16 + ((ScreenW / 2) - var51);
                  int var19 = var17 - var52 + var21 + var21 / 16 + 1 + 25 + (UseRemasterMode ? 75 : 0);
                  var18 -= var21 / 2;
                  field_151.setColor(10066329);
                  field_151.fillRect(var18 - var21 / 16 - 1, var19 - var22 / 16 - 1, var21 + var21 / 8 + 3, var22 + var22 / 3 + 3);
                  field_151.setColor(16777215);
                  field_151.fillRect(var18 - var21 / 16, var19 - var22 / 16, var21 + var21 / 8, var22 + var22 / 3);
                  field_151.setColor(10066329);
                  field_151.fillRect(var18 - 1, var19 - 1, var21 + 2, var22 + 2);
                  method_10(var20, var18, var19, 20, 0);
                  if (field_342[var54 * 28 + 2] > 3) {
                     method_10(66 + var53 + 2, var18, var19 + var22 * 3 / 2, 20, 0);
                     var53++;
                  }
               }
            }

            var1 = 0 + method_140(field_145[var31]);
            if (field_318 == 0) {
               var1 += method_144(var1, field_325, false, true, true);
            } else {
               var1 += method_144(var1, field_325, true, false, false);
            }

            if (field_318 == 2) {
               field_151.setColor(16777215);
               var1 += method_144(var1, field_326, false, true, true);
               if (method_323(field_321)) {
                  object var35 = null;
               } else {
                  method_60(field_145[132], "" + (field_342[field_321 * 28 + 8] - method_321()), 1);
               }

               field_151.setColor(16777215);
               method_93(field_221, field_218, field_219, field_222);
               field_151.setColor(9510656);
               bool var57 = false;
               if (field_222 > 0) {
                  var57 = true;
               }

               bool var61 = false;
               if (field_222 < field_198 - 1) {
                  var61 = true;
               }

               method_84(var57, var61);
            }

            if (field_318 == 0) {
               int var36 = 0;
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
               method_207(field_321, field_322, var1, ScreenW / 2);
               var1 += 62;
               var1 -= method_27(0) + 2;
            }

            if (field_318 == 0 && var33 >= 65536 || field_318 == 2) {
               field_151.setColor(16777215);
               string var42;
               if (method_323(field_321)) {
                  var42 = field_145[104 + field_321];
               } else {
                  var42 = method_60(field_145[132], "" + (field_342[field_321 * 28 + 8] - method_321()), 1);
               }

               if (field_318 == 0 && field_324 && var33 >= 65536) {
                  int var46;
                  if ((var46 = ScreenH - (var1 + method_27(1024) + 4)) < field_108.getHeight()) {
                     var1 -= field_108.getHeight() - var46;
                     var46 = field_108.getHeight();
                  }

                  method_94(1024, var42, MenuOffsetX, var1, 240, var46, 0, 0, 8, true);
                  field_324 = false;
               } else {
                  if (field_324) {
                     method_216(var1);
                  }

                  if (field_318 == 2) {
                     int var45 = field_342[field_321 * 28 + 2];
                     if (field_321 == 0) {
                        if (field_322 < 2) {
                           var42 = "";
                        } else {
                           if (field_322 == 2) {
                              var42 = field_145[87];
                           }

                           if (field_322 == 3) {
                              var42 = field_145[88];
                           }

                           if (field_322 == 4) {
                              var42 = field_145[89];
                           }
                        }
                     } else if (var45 == 4) {
                        if (field_322 == 0) {
                           var42 = field_145[86];
                        }

                        if (field_322 == 1) {
                           var42 = field_145[87];
                        }

                        if (field_322 == 2) {
                           var42 = field_145[88];
                        }

                        if (field_322 == 3) {
                           var42 = field_145[89];
                        }
                     } else {
                        if (field_322 == 0) {
                           var42 = field_145[87];
                        }

                        if (field_322 == 1) {
                           var42 = field_145[88];
                        }

                        if (field_322 == 2) {
                           var42 = field_145[89];
                        }
                     }
                  }
               }

               if (field_318 == 0) {
                  field_151.setColor(16777215);
                  method_28(0, field_215, ScreenW, field_217);
                  method_93(field_221, field_218, field_219, field_222);
                  method_28(0, 0, ScreenW, ScreenH);
                  field_151.setColor(9510656);
                  bool var59 = false;
                  if (field_222 > 0) {
                     var59 = true;
                  }

                  bool var62 = false;
                  if (field_222 < field_198 - 1) {
                     var62 = true;
                  }

                  method_84(var59, var62);
               } else {
                  int var47 = method_24(1024, var42);
                  int var50;
                  if ((var50 = field_215 + var1 + (ScreenH - (field_215 + var1 + method_27(1024) + 4)) / 2) > ScreenH - (method_27(1024) + 4)) {
                     var50 = ScreenH - (method_27(1024) + 4);
                  }

                  field_151.setColor(4864053);
                  method_23(0, var42, ScreenW - (field_121 - field_317 >> 4) % (var47 + ScreenW), var50, 36);
               }
            }

            method_86(var2, 5);
         }
      }
   }

   // $VF: renamed from: a (int, bool, bool) void
   private static void method_211(int var0, bool var1, bool var2) {
      field_317 = field_121;
      if (!var1) {
         if (var2) {
            if (var0 == 2) {
               field_318 = 0;
               field_322 = 0;
               bool var5 = false;
               if (field_321 > 0) {
                  var5 = true;
               }

               bool var10001 = false;
               if (field_321 < 11) {
                  var10001 = true;
               }

               method_143(var5, var10001);
               field_324 = true;
               return;
            }

            if (var0 != 1 && var0 == 0) {
               field_312 = false;
               field_318 = 0;
               if (field_315) {
                  field_315 = false;
                  return;
               }

               field_324 = true;
            }
         }
      } else {
         if (var0 == 0) {
            if (method_323(field_321)) {
               field_318 = 1;
               field_316 = field_121;
               field_322 = method_206();
               field_324 = true;
            }
         } else if (var0 == 1) {
            field_318 = 2;
            field_322 = 0;
            if (field_336 > 1 && (field_321 == 0 || field_321 > 7 && field_342[field_321 * 28 + 2] == 4)) {
               int var10000 = 0;
               if (field_336 > 1) {
                  sbyte var4 = 0;
                  if (field_321 == 0) {
                     var4 = 1;
                  }

                  var10000 = var4 + 1;
               }

               field_322 = var10000;
            }

            method_143(false, true);
            field_324 = true;
         } else if (var0 == 2) {
            field_401 = field_321;
            field_402 = field_322;
            field_278 = field_342[field_321 * 28 + 3] >> (field_322 << 2) & 15;
            field_285 = -1;
            field_284 = -1;
            int var3;
            if ((var3 = field_342[field_321 * 28 + 13 + field_322 * 3]) == -2) {
               field_284 = 2;
            } else if ((var3 & -2147483648) != 0) {
               field_284 = 0;
               field_285 = var3 & 2147483647;
            } else {
               field_284 = 1;
               field_285 = var3;
            }

            field_403 = field_336;
            field_169 = true;
            return;
         }
      }
   }

   // $VF: renamed from: C (int) void
   private static void method_212(int var0) {
      bool var1 = method_63(var0, 262162);
      bool var2 = method_63(var0, 43);
      bool var3 = method_63(var0, 131072);
      bool var4 = method_63(var0, 131074);
      bool var5 = method_63(var0, 131076);
      bool var6 = method_63(var0, 131078);
      if (var3) {
         method_95(4);
      }

      if (var4) {
         method_95(2);
      }

      if (var5 || var6) {
         field_339++;
         field_324 = true;
      }

      field_339 %= 2;
      if (var1) {
         method_17(0, 128, 1);
         field_312 = true;
         field_324 = true;
         field_317 = field_121;
      }

      if (var2) {
         method_17(1, 128, 1);
         method_83();
      }
   }

   // $VF: renamed from: h (int, int) void
   private static void method_213(int var0, int var1) {
      bool var2 = method_63(var0, 262162);
      bool var3 = method_63(var0, 43);
      bool var4 = method_63(var0, 131072);
      bool var5 = method_63(var0, 131074);
      bool var6 = method_63(var0, 131076);
      bool var7 = method_63(var0, 131078);
      if (var1 == 11) {
         method_197(var0);
      } else if (var1 == 5 && !field_312) {
         method_212(var0);
      } else if (var1 == 14 && var2) {
         method_83();
         method_83();
         method_83();
         field_315 = true;
         field_324 = true;
         method_204(false);
         method_17(0, 128, 1);
      } else if (var1 == 12) {
         if (var7) {
            method_82(13);
         } else if (var4 && method_95(4)) {
            field_257--;
         } else if (var5 && method_95(2)) {
            field_257++;
         }
      } else if (var1 == 13) {
         if (var7) {
            method_82(14);
         } else if (var6) {
            method_83();
         } else if (var4 && method_95(4)) {
            field_257--;
         } else if (var5 && method_95(2)) {
            field_257++;
         }
      } else if (var1 == 14) {
         if (var6) {
            method_83();
         } else if (var4 && method_95(4)) {
            field_257--;
         } else if (var5 && method_95(2)) {
            field_257++;
         }
      } else if (var1 == 6 && !field_315) {
         if (var4 && field_335 >= 0) {
            if (field_335 == 0) {
               field_335 = field_336 + 1;
            } else {
               field_335--;
            }
         }

         if (var5 && field_335 <= field_336 + 1) {
            if (field_335 >= field_336 + 1) {
               field_335 = 0;
            } else {
               field_335++;
            }
         }

         if (var6 && field_335 == 1 && field_336 > 2) {
            field_336--;
         }

         if (var7 && field_335 == 1 && field_336 < 8) {
            field_336++;
         }

         if (var6 && field_335 > 1 && field_338[field_335 - 2] > 0) {
            field_338[field_335 - 2]--;
         }

         if (var7 && field_335 > 1 && field_338[field_335 - 2] < 9) {
            field_338[field_335 - 2]++;
         }

         if (field_335 > field_336) {
            field_335 = field_336 + 1;
         }

         if (var2 && field_337 == -1 && field_335 > 1) {
            field_337 = field_335 - 2;
            method_17(0, 128, 1);
            if (field_337 != -1) {
               method_97("", field_314[field_337], 24, 8);
            }
         }

         if (var2 && field_335 == 0) {
            method_17(0, 128, 1);
            method_204(false);
            field_315 = true;
            field_317 = field_121;
         }

         if (var3) {
            method_17(1, 128, 1);
            method_83();
         }
      } else {
         if (var1 == 5 || field_315) {
            method_215(var0);
         }
      }
   }

   // $VF: renamed from: D (int) void
   private static void method_214(int var0) {
      field_316 = field_121;
      field_324 = true;
      method_145(field_121);
      method_146(var0);
      field_317 = field_121;
   }

   // $VF: renamed from: E (int) void
   private static void method_215(int var0) {
      bool var1 = method_63(var0, 262162);
      bool var2 = method_63(var0, 43);
      bool var3 = method_63(var0, 131072);
      bool var4 = method_63(var0, 131074);
      bool var5 = method_63(var0, 131076);
      bool var6 = method_63(var0, 131078);
      if (field_318 == 0) {
         if (var6 && field_319 < 2) {
            field_319++;
            method_214(1);
         } else if (var6 && field_323 < 3) {
            field_323++;
            field_319 = 0;
            method_214(1);
         }

         if (var5 && field_319 > 0) {
            field_319--;
            method_214(-1);
         } else if (var5 && field_323 > 0) {
            field_323--;
            field_319 = 2;
            method_214(-1);
         }
      }

      field_320 = field_321;
      field_321 = field_323 * 3 + field_319;
      bool var10000 = false;
      if (field_321 > 0) {
         var10000 = true;
      }

      bool var10001 = false;
      if (field_321 < 11) {
         var10001 = true;
      }

      method_143(var10000, var10001);
      field_401 = field_321;
      if (field_318 == 2) {
         if (var6 && field_322 < field_342[field_321 * 28 + 2] - 1) {
            field_322++;
            method_145(field_121);
            method_146(1);
            field_317 = field_121;
            field_324 = true;
         }

         int var7 = method_206();
         if (var5 && field_322 > var7) {
            field_322--;
            method_145(field_121);
            method_146(-1);
            field_317 = field_121;
            field_324 = true;
         }

         var10000 = false;
         if (field_322 > var7) {
            var10000 = true;
         }

         var10001 = false;
         if (field_322 < field_342[field_321 * 28 + 2] - 1) {
            var10001 = true;
         }

         method_143(var10000, var10001);
         field_402 = field_322;
      }

      if (var3 && field_222 > 0) {
         method_95(4);
      }

      if (var4 && field_222 < field_198 - 1) {
         method_95(2);
      }

      if (var1 || var2) {
         if (var1) {
            method_17(0, 128, 1);
         }

         if (var2) {
            method_17(1, 128, 1);
         }

         method_211(field_318, var1, var2);
      }

      field_325 = field_321 + 1 + ". " + field_145[92 + field_321];
      field_326 = field_145[116 + (field_342[field_321 * 28 + 3] >> (field_322 << 2) & 15)];
   }

   // $VF: renamed from: F (int) void
   private static void method_216(int var0) {
      if (field_324) {
         string var1 = field_145[124];
         if (field_321 == 0 && field_322 == 0) {
            var1 = field_145[122];
         } else if (field_321 == 0 && field_322 == 1) {
            var1 = field_145[123];
         } else {
            var1 = method_60(var1, method_314(field_321, field_322), 1);
         }

         method_94(0, var1, MenuOffsetX, var0, 240, ScreenH - (var0 + method_27(1024) + 4 + method_141() * 2), 0, 0, 8, true);
         field_324 = false;
      }
   }

   // $VF: renamed from: aq () void
   private static void method_217() {
      if (field_176[field_179] != 11) {
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
            }

            if (field_176[field_179] == 0) {
               method_10(155, 0, 0, 20, 1);
               method_10(156, 0, 128, 20, 1);
               method_10(157, 46, 0, 20, 0);
            }

            if (field_176[field_179] != 0) {
               method_140(field_145[field_183]);
            }
         }
      }
   }

   // $VF: renamed from: k (int) int
   private static int method_218(int var0) {
      switch (var0) {
         case 0:
            return 81;
         case 1:
            return 82;
         case 2:
            return 87;
         case 3:
            return 92;
         case 4:
            return 97;
         case 5:
            return 102;
         case 6:
            return 107;
         case 7:
            return 112;
         case 8:
            return 117;
         case 9:
            return 122;
         default:
            return 0;
      }
   }

   // $VF: renamed from: G (int) void
   private static void method_219(int var0) {
      string var1 = field_145[148 + (var0 - 12)];
      int var2 = method_140(field_145[147]);
      bool var10000 = false;
      if (var0 > 12) {
         var10000 = true;
      }

      field_255 = var10000;
      var10000 = false;
      if (var0 < 14) {
         var10000 = true;
      }

      field_256 = var10000;
      method_144(var2, var1, false, true, true);
      method_28(0, method_141() * 2, ScreenW, ScreenH - (method_141() * 2 + method_27(1024) + 4));

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
      method_28(0, 0, ScreenW, ScreenH);
      var10000 = false;
      if (field_222 > 0) {
         var10000 = true;
      }

      bool var10001 = false;
      if (field_222 < field_198 - 1) {
         var10001 = true;
      }

      method_84(var10000, var10001);
      method_86(var0 == 14 ? 24 : -1, -1);
   }

   // $VF: renamed from: H (int) void
   private static void method_220(int var0) {
      string var1 = "";
      if (var0 < 14) {
         for (int var2 = 0; var2 < field_403; var2++) {
            int var3 = field_281[var2];
            if (var0 == 13) {
               var3 = field_282[var2];
            }

            string var4;
            var4 = method_60(
               method_60(method_60(var4 = field_145[151], "" + (var2 + 1), 1), field_314[var3], 2), "" + method_139(var2, field_280[6 * var3 + 5]), 3
            );
            if (field_280[6 * var3 + 5] == 0) {
               var4 = method_60(var4, field_145[153], 4);
            } else if (var0 == 12) {
               var4 = method_60(var4, method_135(field_280[6 * var3 + 5], false), 4);
            } else {
               var4 = method_60(var4, "" + field_345[var3].field_18, 4);
            }

            var4 = method_60(var4, "" + (2 + field_338[var3]), 5);
            var1 = var1 + var4;
         }
      } else {
         int[] var10 = method_182();
         int var11 = 0;
         int var15 = 1;
         int var5 = 1000;

         for (int var6 = 0; var6 < field_403; var6++) {
            int var7;
            int var8;
            if ((
                  var8 = method_139(method_183(var7 = var10[var6], true), field_280[6 * var7 + 5])
                     + method_139(method_183(var7, false), field_280[6 * var7 + 5])
               )
               < var5) {
               var11 += var15;
               var15 = 1;
            } else {
               var15++;
            }

            string var9;
            var9 = method_60(
               method_60(method_60(method_60(var9 = field_145[152], "" + var11, 1), field_314[var7], 2), "" + var8, 3), "" + (2 + field_338[var7]), 4
            );
            var1 = var1 + var9;
            var5 = var8;
         }
      }

      field_257 = 0;
      method_94(0, var1, MenuOffsetX, method_141() * 2, 240, ScreenH - (method_141() * 2 + method_27(1024) + 4), 1, 1, 8, true);
   }

   // $VF: renamed from: ar () void
   private static void method_221() {
      method_99(0, 26437);
      method_118();
      method_184();
      method_15(3);
      field_342 = method_53(2, 16906, 1344, null);
      method_309();
      method_20();
      method_17(7, 0, 0);
      field_336 = 0;
      field_341 = false;
      field_293 = false;
      field_290 = false;
      field_294 = true;

      for (int var0 = 0; var0 < 12; var0++) {
         if (!method_320(var0)) {
            field_294 = false;
            break;
         }
      }

      field_135[596] = (short)(field_294 ? 0 : 2);
      field_135[600] = (short)(field_294 ? 2 : 0);
      field_338 = new int[8];
      int var1 = 0;

      while (var1 < 8) {
         field_338[var1] = var1++;
      }

      field_314 = new string[8];

      for (int var2 = 0; var2 < 8; var2++) {
         field_314[var2] = method_120(1 + var2);
      }

      field_313 = new int[24];

      for (int var3 = 0; var3 < 12; var3++) {
         field_313[var3 * 2] = var3 * 128;
         field_313[var3 * 2 + 1] = var3 / 3 % 2 * 64 + (method_109(var3 * 431) >> 1) % 21;
      }

      field_327 = 0;
      method_204(true);
   }

   // $VF: renamed from: as () void
   private static void method_222() {
      field_344 = 0;
   }

   // $VF: renamed from: I (int) void
   private static void method_223(int var0) {
      if (field_343 + var0 >> 10 > field_343 >> 10) {
         method_17(5, 128, 1);
         method_125(196611, ScreenW - 46, 36, 0);
         field_344 = 400;
      }

      field_343 += var0;
      if (field_343 > 5120) { field_343 = 5120; } // FLOW_MAX

      method_235();
   }

   // $VF: renamed from: at () void
   private static void method_224() {
      if (field_343 >> 10 > field_343 - 2048 >> 10) {
         method_17(6, 128, 1);
         method_125(196612, ScreenW - 46, 36, 0);
         field_344 = -400;
      }

      field_343 -= 2048;
      if (field_343 < 0) {
         field_343 = 0;
      }

      method_235();
   }

   // $VF: renamed from: au () void
   private static void method_225() {
      field_343 = 0;
   }

   // $VF: renamed from: av () void
   private static void method_226() {
      int[] var0 = new int[]{16776960, 15975436, 16751617, 16730112, 16451330};
      int var1 = field_343 >> 10;
      int var2 = field_343 & 1023;
      if (var1 > 5) {
         var2 = 1023;
         var1 = 5;
      }

      int var3 = 25;
      int var4;
      int var5 = method_6(var4 = 185 + var1);
      int var6 = (ScreenW - 5) - var5 + (var5 >> 2);
      int var7 = 0;
      if (field_344 < 0) {
         var3 = 25 + method_109(field_121 >> 6) % 11;
      } else {
         var7 = field_404[field_344 * 256 / 400 & 511] * (5 + var5 + (var5 >> 2)) >> 10;
         var6 += var7;
      }

      if (var1 > 4) {
         var2 = 1023;
         field_151.setColor(method_112(var0[0], var0[4], method_106(field_404[field_121 >> 2 & 511]) >> 2));
      } else {
         field_151.setColor(var0[var1]);
      }

      int var8 = var2 * 38 / 1024;
      field_151.fillRect(var6 - 42 + 2, var3 + 3, var8, 18);
      field_151.setColor(12369084);
      field_151.fillRect(var6 - 42 + 2 + var8, var3 + 3, 38 - var8, 18);
      method_10(184, var6, var3, 24, 0);
      method_10(var4, (ScreenW - 5) + var7, var3 + (var5 >> 3), 24, 0);
      if (field_344 < 0) {
         field_344 = field_344 + field_123;
         if (field_344 > 0) {
            field_344 = 0;
         }
      } else {
         field_344 = field_344 - field_123;
         if (field_344 < 0) {
            field_344 = 0;
         }
      }
   }

   // $VF: renamed from: aw () void
   private static void method_227() {
      if (field_345 == null) {
         field_345 = new class_1[8];

         for (int var0 = 0; var0 < 8; var0++) {
            field_345[var0] = new class_1();
            field_345[var0].field_17 = new int[8];
            if (field_345[var0].field_27 == null) {
               field_345[var0].field_27 = new int[16];

               for (int var1 = 0; var1 < 16; var1++) {
                  field_345[var0].field_27[var1] = 0;
               }
            }

            field_345[var0].field_28 = 0;
         }
      }

      method_228();
   }

   // $VF: renamed from: ax () void
   private static void method_228() {
      for (int var0 = 0; var0 < 8; var0++) {
         for (int var1 = 0; var1 < field_345[var0].field_17.Length; var1++) {
            field_345[var0].field_17[var1] = 0;
         }

         field_345[var0].field_18 = 0;
         field_345[var0].field_19 = 1;
         field_345[var0].field_20 = 0;
         field_345[var0].field_21 = 0;
         field_345[var0].field_23 = -1;
         field_345[var0].field_25 = 1;
         field_345[var0].field_24 = 0;
         field_345[var0].field_26 = 0;
         if (field_345[var0].field_27 != null) {
            for (int var2 = 0; var2 < 16; var2++) {
               field_345[var0].field_27[var2] = 0;
            }
         }
      }
   }

   // $VF: renamed from: J (int) void
   private static void method_229(int var0) {
      if (var0 != 0) {
         int var1 = field_345[field_240].field_28 % 8 << 1;
         field_345[field_240].field_27[var1] = field_399 + 3000;
         field_345[field_240].field_27[var1 + 1] = var0;
         field_345[field_240].field_28++;
      }
   }

   // $VF: renamed from: ay () void
   private static void method_230() {
      field_345[field_240].field_18 = 0;
      field_345[field_240].field_19 = 1;
      field_345[field_240].field_20 = 0;
      field_345[field_240].field_21 = 0;
      field_345[field_240].field_23 = -1;
      field_345[field_240].field_25 = 1;
      field_345[field_240].field_26 = 0;
   }

   // $VF: renamed from: az () void
   private static void method_231() {
      field_345[field_240].field_25 = 1;
   }

   // $VF: renamed from: a (int, bool) void
   private static void method_232(int var0, bool var1) {
      if (field_345[field_240].field_21 != 0) {
         method_229(field_345[field_240].field_17[field_345[field_240].field_20]);
      } else if (field_345[field_240].field_20 > 0) {
         method_229(field_345[field_240].field_17[field_345[field_240].field_20 - 1]);
      }

      if (field_345[field_240].field_21 != 0) {
         method_234();
      }

      field_345[field_240].field_23 = field_399;
      field_345[field_240].field_17[field_345[field_240].field_20++] = var0 * field_345[field_240].field_25;
      if (field_345[field_240].field_20 == 8) {
         field_345[field_240].field_20 = 1;
         field_345[field_240].field_17[0] = field_345[field_240].field_17[7];

         for (int var2 = 1; var2 < 8; var2++) {
            field_345[field_240].field_17[var2] = 0;
         }
      }

      if (var1) {
         field_345[field_240].field_25++;
      }

      field_345[field_240].field_26 += var0;
   }

   // $VF: renamed from: i (int, int) void
   private static void method_233(int var0, int var1) {
      if (field_345[field_240].field_20 > 0 && field_345[field_240].field_21 == 0 && var0 > 0) {
         method_229(field_345[field_240].field_17[field_345[field_240].field_20 - 1]);
      }

      field_345[field_240].field_21 = var0;
      field_345[field_240].field_22 = var1;
   }

   // $VF: renamed from: aA () void
   private static void method_234() {
      field_345[field_240].field_23 = field_399;
      field_345[field_240].field_20++;
      field_345[field_240].field_21 = 0;
      if (field_345[field_240].field_20 == 8) {
         field_345[field_240].field_20 = 1;
         field_345[field_240].field_17[0] = field_345[field_240].field_17[7];

         for (int var0 = 1; var0 < 8; var0++) {
            field_345[field_240].field_17[var0] = 0;
         }
      }
   }

   // $VF: renamed from: aB () void
   private static void method_235() {
      field_345[field_240].field_19 = (field_343 >> 10) + 1;
      if (field_345[field_240].field_19 > 2) {
         field_345[field_240].field_19 = field_345[field_240].field_19 - 1 << 1;
      }
   }

   // $VF: renamed from: aC () void
   private static void method_236() {
      method_234();
      field_345[field_240].field_24 = 0;

      for (int var0 = 0; var0 < field_345[field_240].field_20; var0++) {
         field_345[field_240].field_17[var0] = 0;
      }

      field_345[field_240].field_18 = field_345[field_240].field_18 + field_345[field_240].field_24;
      field_345[field_240].field_20 = 0;
      field_345[field_240].field_21 = 0;
      field_345[field_240].field_23 = -1;
      field_345[field_240].field_26 = 0;
      method_231();
   }

   // $VF: renamed from: aD () void
   private static void method_237() {
      field_345[field_240].field_24 = 0;

      for (int var0 = 0; var0 < field_345[field_240].field_20; var0++) {
         field_345[field_240].field_24 = field_345[field_240].field_24 - field_345[field_240].field_17[var0] * field_345[field_240].field_19;
         field_345[field_240].field_17[var0] = 0;
      }

      field_345[field_240].field_20 = 0;
      field_345[field_240].field_21 = 0;
      field_345[field_240].field_23 = -1;
      field_345[field_240].field_26 = 0;
      method_231();
      method_224();
   }

   // $VF: renamed from: aE () void
   private static void method_238() {
      if (field_345[field_240].field_21 > 0) {
         if (field_358[field_239] != field_345[field_240].field_22) {
            method_234();
         } else if (field_357[field_358[field_239] * 14 + 12] != 5 || field_347[field_239].field_47 < 0) {
            field_345[field_240].field_17[field_345[field_240].field_20] = field_345[field_240].field_17[field_345[field_240].field_20]
               + field_345[field_240].field_21;
            field_345[field_240].field_18 = field_345[field_240].field_18 + field_345[field_240].field_21 * field_345[field_240].field_19;
            if (field_345[field_240].field_23 == -1) {
               field_345[field_240].field_23 = field_399;
            }
         }
      } else if (field_345[field_240].field_26 > 0) {
         method_223(field_345[field_240].field_26 * 2048 >> 10);
         field_345[field_240].field_18 = field_345[field_240].field_18 + field_345[field_240].field_26 * field_345[field_240].field_19;
         field_345[field_240].field_26 = 0;
      }

      if (field_345[field_240].field_23 != -1 && field_399 - field_345[field_240].field_23 >= 2000 && field_345[field_240].field_21 == 0) {
         method_236();
      }
   }

   // $VF: renamed from: K (int) void
   private static void method_239(int var0) {
      method_114("" + field_345[var0].field_18, ScreenW - 5, 5, 24);

      for (int var1 = 0; var1 < 8; var1++) {
         int var2;
         int var3;
         if ((var2 = field_345[var0].field_27[var1 << 1] - field_399) > 0 && (var3 = 80 - ((3000 - var2) * 320 * 3 >> 13)) > 25) {
            method_114("" + field_345[var0].field_27[(var1 << 1) + 1], ScreenW / 2, var3, 17);
         }
      }

      if (field_345[var0].field_23 != -1 && (field_345[var0].field_20 > 0 || field_345[var0].field_21 > 0)) {
         int var4 = field_345[var0].field_17[field_345[var0].field_20];
         if (field_345[var0].field_21 == 0) {
            var4 = field_345[var0].field_17[field_345[var0].field_20 - 1];
         }

         int var5;
         if ((var5 = 100 - ((field_399 - field_345[var0].field_23) * 320 >> 10)) < 80) {
            var5 = 80;
         }

         method_114("" + var4, ScreenW / 2, var5, 17);
      }
   }

   // $VF: renamed from: aF () void
   private static void method_240() {
      if (field_354 == null) {
         field_354 = method_53(1, 10674, 48, null);
         field_349 = method_53(1, 10722, 256, null);
         field_350 = method_53(1, 10978, 968, null);
         field_355 = method_53(1, 11946, 72, null);
         field_351 = method_53(1, 12018, 72, null);
         field_352 = method_53(1, 12090, 16, null);
         field_353 = method_53(1, 12106, 32, null);
         field_356 = method_53(1, 12138, 108, null);
      }

      if (field_347 == null) {
         field_347 = new class_2[10];
         field_348 = new class_3[30];
      }

      for (int var0 = 0; var0 < 10; var0++) {
         if (field_347[var0] == null) {
            field_347[var0] = new class_2();
            field_348[var0 * 3] = new class_3();
            field_348[var0 * 3 + 1] = new class_3();
            field_348[var0 * 3 + 2] = new class_3();
         }

         field_239 = var0;
         method_242();
      }

      if (field_346 == null) {
         field_346 = new class_3();
      }
   }

   // $VF: renamed from: aG () void
   private static void method_241() {
      for (int var0 = 0; var0 < 10; var0++) {
         field_239 = var0;
         method_242();
      }
   }

   // $VF: renamed from: aH () void
   private static void method_242() {
      field_347[field_239].field_30 = 0;
      field_348[3 * field_239 + 2].field_76 = false;
      field_348[3 * field_239 + 2].field_77 = false;
      field_348[3 * field_239 + 2].field_88 = 0;
      field_348[3 * field_239 + 1].field_76 = false;
      field_348[3 * field_239 + 1].field_77 = false;
      field_348[3 * field_239 + 1].field_88 = 0;
      field_348[3 * field_239].field_76 = false;
      field_348[3 * field_239].field_77 = true;
      field_348[3 * field_239].field_88 = 0;
      field_347[field_239].field_29 = 0;
      field_347[field_239].field_31 = 0;
      field_347[field_239].field_32 = 8800;
      field_347[field_239].field_33 = false;
      field_347[field_239].field_34 = 0;
      field_347[field_239].field_35 = 0;
      field_347[field_239].field_36 = 0;
      field_347[field_239].field_37 = -1536;
      field_347[field_239].field_40 = field_378 * 1024;
      field_347[field_239].field_41 = field_379 * 1024 + 1024;
      field_347[field_239].field_44 = field_347[field_239].field_40;
      field_347[field_239].field_45 = field_347[field_239].field_41;
      field_347[field_239].field_42 = field_347[field_239].field_36;
      field_347[field_239].field_43 = field_347[field_239].field_37;
      field_347[field_239].field_38 = 0;
      field_347[field_239].field_39 = 0;
      field_347[field_239].field_46 = 0;
      field_347[field_239].field_47 = 0;
      field_347[field_239].field_48 = 0;
      field_347[field_239].field_49 = 0;
      field_347[field_239].field_50 = 0;
      field_347[field_239].field_51 = 0;
      if (field_347[field_239].field_40 >= field_376 << 9 && (field_401 != 2 || field_278 != 3)) {
         field_347[field_239].field_53 = false;
      } else {
         field_347[field_239].field_53 = true;
      }

      field_347[field_239].field_54 = false;
      field_347[field_239].field_55 = 0;
      field_347[field_239].field_58 = 0;
      field_347[field_239].field_60 = 0;
      field_347[field_239].field_61 = 0;
      field_347[field_239].field_62 = 0;
      field_347[field_239].field_63 = 0;
      field_347[field_239].field_64 = 0;
      field_347[field_239].field_65 = 0;
      field_347[field_239].field_66 = 0;
      field_347[field_239].field_67 = 0;
      field_347[field_239].field_68 = 0;
      field_347[field_239].field_69 = 0;
      field_347[field_239].field_70 = 0;
      field_347[field_239].field_71 = 0;
      field_347[field_239].field_72 = 0;
      field_347[field_239].field_73 = 65536;
      field_347[field_239].field_74 = 65536;
      field_347[field_239].field_57 = false;
      field_347[field_239].field_75 = 0;
      field_347[field_239].field_59 = 0;
      field_347[field_239].field_56 = 0;
      field_347[field_239].field_52 = 0;
   }

   // $VF: renamed from: l (int) int
   private static int method_243(int var0) {
      int var10 = 0;
      bool var11 = false;
      bool var13 = false;
      field_347[field_239].field_75 = field_347[field_239].field_75 | field_360;
      field_347[field_239].field_50 = field_347[field_239].field_46;
      field_347[field_239].field_51 = field_347[field_239].field_47;
      field_347[field_239].field_29 += var0;
      if (field_347[field_239].field_29 >= 30) {
         var10 = 30;
         field_347[field_239].field_29 -= 30;
         var13 = true;
      } else {
         var10 = 0 + field_347[field_239].field_29;
         var13 = false;
      }

      method_250(field_347[field_239], var10);
      bool var15 = false;
      int var16 = field_347[field_239].field_40;
      int var17 = field_347[field_239].field_41;
      if (field_348[3 * field_239].field_76 || field_348[3 * field_239 + 1].field_76 || field_348[3 * field_239 + 2].field_76) {
         bool var29 = true;
         if (!field_348[3 * field_239].field_76
            || field_348[3 * field_239 + 2].field_76
               && field_348[3 * field_239].field_84 >= field_348[3 * field_239 + 2].field_84
               && (field_347[field_239].field_54 || field_348[3 * field_239].field_84 != field_348[3 * field_239 + 2].field_84)) {
            if (field_348[3 * field_239 + 2].field_76
               && (
                  method_249(field_347[field_239])
                        && (!field_348[3 * field_239 + 1].field_76 || field_348[3 * field_239 + 2].field_84 < field_348[3 * field_239 + 1].field_84)
                     || !method_249(field_347[field_239])
               )) {
               if (field_348[3 * field_239 + 2].field_88 != 0) {
                  field_347[field_239].field_30 = 2;
                  field_347[field_239].field_40 = field_348[3 * field_239 + field_347[field_239].field_30].field_78
                     + field_348[3 * field_239 + field_347[field_239].field_30].field_80;
                  field_347[field_239].field_41 = field_348[3 * field_239 + field_347[field_239].field_30].field_79
                     + field_348[3 * field_239 + field_347[field_239].field_30].field_81;
                  field_348[3 * field_239].field_88 = 0;
               } else {
                  var15 = true;
                  var29 = false;
               }
            } else {
               field_347[field_239].field_30 = 1;
               field_347[field_239].field_40 = field_348[3 * field_239 + field_347[field_239].field_30].field_78
                  + field_348[3 * field_239 + field_347[field_239].field_30].field_80
                  - field_347[field_239].field_36 / 2;
               field_347[field_239].field_41 = field_348[3 * field_239 + field_347[field_239].field_30].field_79
                  + field_348[3 * field_239 + field_347[field_239].field_30].field_81
                  - field_347[field_239].field_37 / 2;
               field_348[3 * field_239 + 2].field_88 = 0;
               field_348[3 * field_239].field_88 = 0;
            }
         } else if (field_348[3 * field_239].field_88 != 0) {
            if (field_348[3 * field_239].field_88 != 15 && field_348[3 * field_239].field_88 != 16) {
               field_347[field_239].field_30 = 0;
               field_347[field_239].field_40 = field_348[3 * field_239 + field_347[field_239].field_30].field_78
                  + field_348[3 * field_239 + field_347[field_239].field_30].field_80
                  - field_347[field_239].field_36;
               field_347[field_239].field_41 = field_348[3 * field_239 + field_347[field_239].field_30].field_79
                  + field_348[3 * field_239 + field_347[field_239].field_30].field_81
                  - field_347[field_239].field_37;
               field_348[3 * field_239 + 2].field_88 = 0;
            } else {
               field_347[field_239].field_40 = field_348[3 * field_239].field_78 + field_348[3 * field_239].field_80 - field_347[field_239].field_36;
               field_347[field_239].field_41 = field_348[3 * field_239].field_79 + field_348[3 * field_239].field_81 - field_347[field_239].field_37;
               var29 = false;
            }
         } else {
            var15 = true;
            var29 = false;
         }

         if (var29) {
            if (field_348[3 * field_239 + field_347[field_239].field_30].field_88 != 17
               && field_348[3 * field_239 + field_347[field_239].field_30].field_88 != 14
               && field_348[3 * field_239 + field_347[field_239].field_30].field_88 != 9
               && field_348[3 * field_239 + field_347[field_239].field_30].field_88 != 8
               && field_348[3 * field_239 + field_347[field_239].field_30].field_88 != 12
               && field_348[3 * field_239 + field_347[field_239].field_30].field_88 != 11) {
               field_347[field_239].field_46 = (field_347[field_239].field_49 * -field_348[3 * field_239 + field_347[field_239].field_30].field_83 + 0) / 1024;
               field_347[field_239].field_47 = (0 + field_347[field_239].field_49 * field_348[3 * field_239 + field_347[field_239].field_30].field_82) / 1024;
            } else {
               bool var31 = false;
               int var33 = (
                     field_347[field_239].field_46 * -field_348[3 * field_239 + field_347[field_239].field_30].field_83
                        + field_347[field_239].field_47 * field_348[3 * field_239 + field_347[field_239].field_30].field_82
                  )
                  / 1024;
               field_347[field_239].field_46 = -var33 * field_348[3 * field_239 + field_347[field_239].field_30].field_83 / 1024;
               field_347[field_239].field_47 = var33 * field_348[3 * field_239 + field_347[field_239].field_30].field_82 / 1024;
               field_347[field_239].field_49 = -field_347[field_239].field_49;
            }
         }

         var13 = true;
      } else if (var13 && !field_347[field_239].field_33 && method_249(field_347[field_239])) {
         int var18 = field_355[field_347[field_239].field_54 ? field_348[3 * field_239].field_88 : field_348[3 * field_239 + 2].field_88];
         int var19 = field_347[field_239].field_54
            ? field_348[3 * field_239].field_78 + field_348[3 * field_239].field_80 - field_347[field_239].field_36 - field_347[field_239].field_34
            : field_348[3 * field_239 + 2].field_78 + field_348[3 * field_239 + 2].field_80;
         int var20 = field_347[field_239].field_54
            ? field_348[3 * field_239].field_79 + field_348[3 * field_239].field_81 - field_347[field_239].field_37 - field_347[field_239].field_35
            : field_348[3 * field_239 + 2].field_79 + field_348[3 * field_239 + 2].field_81;
         if (!field_347[field_239].field_54
            || field_348[3 * field_239 + field_347[field_239].field_30].field_88 != 11
               && field_348[3 * field_239 + field_347[field_239].field_30].field_88 != 12
               && field_348[3 * field_239].field_88 != 8
               && field_348[3 * field_239].field_88 != 9) {
            field_347[field_239].field_40 = field_347[field_239].field_40 + field_347[field_239].field_38 + field_347[field_239].field_46 * var10 / 1024;
            field_347[field_239].field_41 = var18 * (field_347[field_239].field_40 - var19) / 1024 + var20;
         } else {
            field_347[field_239].field_41 = field_347[field_239].field_41 + field_347[field_239].field_39 + field_347[field_239].field_47 * var10 / 1024;
            field_347[field_239].field_40 = var19;
         }

         field_347[field_239].field_36 = field_347[field_239].field_36 + field_347[field_239].field_34;
         field_347[field_239].field_37 = field_347[field_239].field_37 + field_347[field_239].field_35;
         field_347[field_239].field_30 = field_347[field_239].field_54 ? 0 : 2;
      } else if (var13) {
         var15 = true;
      }

      if (var15) {
         field_347[field_239].field_40 = field_347[field_239].field_40 + field_347[field_239].field_38 + field_347[field_239].field_46 * var10 / 1024;
         field_347[field_239].field_41 = field_347[field_239].field_41 + field_347[field_239].field_39 + field_347[field_239].field_47 * var10 / 1024;
         field_347[field_239].field_36 = field_347[field_239].field_36 + field_347[field_239].field_34;
         field_347[field_239].field_37 = field_347[field_239].field_37 + field_347[field_239].field_35;
      }

      if (var13) {
         if (field_347[field_239].field_33) {
            field_347[field_239].field_36 = field_347[field_239].field_36 - (field_347[field_239].field_40 - var16);
            field_347[field_239].field_37 = field_347[field_239].field_37 - (field_347[field_239].field_41 - var17);
         }

         field_347[field_239].field_38 = 0;
         field_347[field_239].field_39 = 0;
         field_347[field_239].field_34 = 0;
         field_347[field_239].field_35 = 0;
      }

      if (method_249(field_347[field_239])) {
         field_347[field_239].field_74 = 65536;
      }

      int var30 = field_357[field_358[field_239] * 14 + 8];
      int var32 = field_359[field_239] > 0 && field_359[field_239] < var0 ? field_359[field_239] : var0;

      do {
         if (method_279(var32)) {
            var30 = field_357[field_358[field_239] * 14 + 8];
            if (field_347[field_239].field_57 && (var30 & 2048) == 0) {
               field_347[field_239].field_53 ^= true;
            }

            class_2 var10000 = field_347[field_239];
            int var10001 = 0;
            if ((field_357[field_358[field_239] * 14 + 8] & 16) != 0) {
               var10001 = 1;
            }

            var10000.field_57 = var10001 != 0;
            var10000 = field_347[field_239];
            var10001 = 0;
            if ((field_357[field_358[field_239] * 14 + 8] & 64) != 0) {
               var10001 = field_347[field_239].field_75;
            }

            var10000.field_75 = var10001;
            method_244(field_347[field_239], field_357[field_358[field_239] * 14 + 9]);
            method_246(
               field_347[field_239],
               field_357[field_358[field_239] * 14 + 2],
               field_357[field_358[field_239] * 14 + 3],
               field_357[field_358[field_239] * 14 + 4],
               field_357[field_358[field_239] * 14 + 5],
               method_277(field_358[field_239])
            );
            var10000 = field_347[field_239];
            bool var45 = false;
            if ((field_357[field_358[field_239] * 14 + 8] & 1) != 0) {
               var45 = true;
            }

            var10000.field_54 = var45;
            var13 = true;
         }

         field_347[field_239].field_73 += 20 * var0;
         if (field_347[field_239].field_73 > 65536) {
            field_347[field_239].field_73 = 65536;
         }

         field_347[field_239].field_74 += 11 * var0;
         if (field_347[field_239].field_74 > 65536) {
            field_347[field_239].field_74 = 65536;
         }

         if (field_359[field_239] == 0 || var13) {
            method_245(field_347[field_239], field_347[field_239].field_55, 30);
            method_247(field_347[field_239], field_347[field_239].field_58, 30, 30);
            method_248(field_347[field_239], 30);
            if ((var30 & 2) != 0 || (var30 & 4) != 1 && !method_249(field_347[field_239])) {
               field_348[3 * field_239].field_88 = 0;
               field_348[3 * field_239 + 2].field_88 = 0;
               var11 = true;
            }

            int var46 = 0;
            if (var11) {
               var46 = field_347[field_239].field_31 * 30 / 1024;
            }

            int var34 = field_347[field_239].field_71 + var46;
            var46 = 0;
            if (var11) {
               var46 = field_347[field_239].field_32 * 30 / 1024;
            }

            int var21 = field_347[field_239].field_72 + var46;
            if (method_249(field_347[field_239])) {
               int var22 = method_269(field_347[field_239].field_46, field_347[field_239].field_47);
               var46 = field_351[field_348[3 * field_239 + field_347[field_239].field_30].field_88];
               sbyte var10003 = 0;
               if (field_347[field_239].field_47 > 0) {
                  var10003 = 1;
               }

               int var23 = field_353[var46 + (1 - var10003)];
               int var24 = 3400 * var23 / 1024;
               if ((field_347[field_239].field_46 * field_347[field_239].field_71 + field_347[field_239].field_47 * field_347[field_239].field_72) / 1024 > 0) {
                  if (var22 > var24) {
                     int var25 = field_352[field_351[field_348[3 * field_239 + field_347[field_239].field_30].field_88] >> 1];
                     var34 -= var25 * field_347[field_239].field_46 / var22;
                     var21 -= var25 * field_347[field_239].field_47 / var22;
                  } else {
                     int var39 = var24 / 12;
                     int var26 = method_152(var22 / var39, 11);
                     var34 = var34 * field_354[var26] / 1024;
                     var21 = var21 * field_354[var26] / 1024;
                  }
               }
            }

            field_347[field_239].field_46 += var34;
            field_347[field_239].field_47 += var21;
            if (method_249(field_347[field_239])) {
               int var35 = field_348[3 * field_239 + field_347[field_239].field_30].field_83 == -1024
                  ? 3400
                  : (method_106(field_348[3 * field_239 + field_347[field_239].field_30].field_82) == 1024 ? 5250 : 4000);
               int var37;
               if ((var37 = field_347[field_239].field_46 * field_347[field_239].field_46 + field_347[field_239].field_47 * field_347[field_239].field_47)
                  > var35 * var35) {
                  int var38 = method_270(var37);
                  field_347[field_239].field_46 = field_347[field_239].field_46 * var35 / var38;
                  field_347[field_239].field_47 = field_347[field_239].field_47 * var35 / var38;
               }
            } else if (field_347[field_239].field_47 > 17300) {
               field_347[field_239].field_47 = 17300;
            }

            field_347[field_239].field_49 = field_347[field_239].field_46;
            if (!field_347[field_239].field_57) {
               class_2 var42 = field_347[field_239];
               bool var49;
               if (field_347[field_239].field_33) {
                  var49 = field_347[field_239].field_53;
               } else {
                  var49 = true;
                  if (field_347[field_239].field_46 <= 0) {
                     var49 = false;
                     if (field_347[field_239].field_46 >= 0) {
                        var49 = field_347[field_239].field_53;
                     }
                  }
               }

               var42.field_53 = var49;
            }

            if ((var30 & 2048) != 0 && !field_347[field_239].field_57) {
               field_347[field_239].field_53 ^= true;
            }
         }

         if (var13) {
            field_347[field_239].field_42 = field_347[field_239].field_36;
            field_347[field_239].field_43 = field_347[field_239].field_37;
            field_347[field_239].field_44 = field_347[field_239].field_40;
            field_347[field_239].field_45 = field_347[field_239].field_41;
         } else {
            field_347[field_239].field_42 = field_347[field_239].field_36 + field_347[field_239].field_34 * var10 / 30;
            field_347[field_239].field_43 = field_347[field_239].field_37 + field_347[field_239].field_35 * var10 / 30;
            field_347[field_239].field_44 = field_347[field_239].field_40
               + field_347[field_239].field_38 * var10 / 30
               + field_347[field_239].field_46 * var10 / 1024;
            field_347[field_239].field_45 = field_347[field_239].field_41
               + field_347[field_239].field_39 * var10 / 30
               + field_347[field_239].field_47 * var10 / 1024;
         }

         int var36 = field_386[field_347[field_239].field_44 >> 10] << 10;
         if (field_347[field_239].field_45 + field_347[field_239].field_43 > var36 + 2048) {
            field_347[field_239].field_41 = var36 - 2048;
            field_347[field_239].field_45 = var36 - 2048;
            method_278(11);
         }
      } while (method_277(field_358[field_239]) == 0 && field_357[field_358[field_239] * 14 + 1] != -1);

      int var43 = 1;
      if (var0 != 0) {
         var43 = var0;
      }

      return var43;
   }

   // $VF: renamed from: a (d, int) void
   private static void method_244(class_2 var0, int var1) {
      var0.field_55 = var1;
      var0.field_56 = 0;
      var0.field_38 = 0;
      var0.field_39 = 0;
      var0.field_34 = 0;
      var0.field_35 = 0;
      bool var2 = field_348[3 * field_239 + field_347[field_239].field_30].field_77;
      int var3 = 0;
      int var4 = 0;
      int var10001 = 0;
      if (var2) {
         var10001 = var0.field_36;
      }

      int var5 = var0.field_40 + var10001;
      var10001 = 0;
      if (var2) {
         var10001 = var0.field_37;
      }

      int var6 = var0.field_41 + var10001;
      if ((var2 ? field_348[3 * field_239].field_88 : field_348[3 * field_239 + 2].field_88) != 0) {
         var5 -= var2 ? field_348[3 * field_239].field_80 : field_348[3 * field_239 + 2].field_80;
         var6 -= var2 ? field_348[3 * field_239].field_81 : field_348[3 * field_239 + 2].field_81;
      }

      if (var1 == 25) {
         var5 += var0.field_36;
         var6 += var0.field_37;
      }

      var3 = method_263(var5, 10, var0.field_53 ^ true);
      var4 = var6 >> 10;
      if (var1 == 2) {
         var3 += var0.field_53 ? 1 : -1;
         var4++;
      } else if (var1 == 23) {
         var3 += var0.field_53 ? 1 : -1;
      } else if (var1 == 27) {
         var3 += (var0.field_53 ? 1 : 0);
      } else if (var1 == 25) {
         var4++;
      }

      var5 = var3 << 10;
      var6 = var4 << 10;
      switch (var1) {
         case 0:
         case 4:
         case 25:
            var0.field_33 = true;
            if (var1 == 0) {
               var0.field_36 = var0.field_53 ? var5 - 1 - var0.field_40 : var5 + 1024 + 1 - var0.field_40;
               var0.field_37 = var6 + 1 - var0.field_41;
            } else {
               var0.field_36 = 0;
               var0.field_37 = -1536;
               var0.field_40 = var0.field_53 ? var5 - 1 : var5 + 1024 + 1;
               var0.field_41 = var6 + 1536 + 1;
            }

            method_267(var0.field_53, var5, var6);
            return;
         case 1:
            var0.field_41 += 3;
            field_348[3 * field_239 + 2].field_88 = 0;
            field_348[3 * field_239].field_88 = 0;
            return;
         case 2:
         case 5:
            var0.field_33 = true;
            var0.field_36 = 0;
            var0.field_37 = -1536;
            var0.field_40 = var0.field_53 ? var5 - 1 : var5 + 1024 + 1;
            var0.field_41 = var6 + 1536 + 1;
            method_267(var0.field_53, var5, var6);
            return;
         case 3:
            var0.field_33 = true;
            return;
         case 6:
            var0.field_40 = var0.field_40 + var0.field_36;
            var0.field_41 = var0.field_41 + var0.field_37;
            var0.field_36 = 0;
            var0.field_37 = -10;
            return;
         case 7:
            var0.field_36 = 0;
            var0.field_37 = -10;
            return;
         case 8:
            var0.field_56 = var0.field_41;
            var0.field_33 = true;
            return;
         case 9:
            var0.field_33 = true;
            var0.field_36 = 0;
            var0.field_37 = -1536;
            var0.field_40 = var0.field_53 ? var5 + 768 - 1 : var5 + 256 + 1;
            var0.field_41 = var6 + 1536 + 1;
            return;
         case 10:
         case 16:
         case 17:
            return;
         case 11:
            var0.field_40 = var0.field_40 + var0.field_36;
            var0.field_41 = var0.field_41 + var0.field_37 + 1536;
            var0.field_36 = 0;
            var0.field_37 = -1536;
            return;
         case 12:
         case 28:
         default:
            var0.field_36 = 0;
            var0.field_37 = -1536;
            var0.field_33 = false;
            return;
         case 13:
            var0.field_41 -= 384;
            var0.field_37 += 384;
            return;
         case 14:
            var0.field_38 = var0.field_53 ? 192 : -192;
            var0.field_39 = 96;
            var0.field_36 = var0.field_36 - (var0.field_53 ? 192 : -192);
            var0.field_37 -= 96;
            return;
         case 15:
            method_267(var0.field_53, var5, var6);
            return;
         case 18:
            var0.field_33 = true;
            var0.field_36 = 0;
            var0.field_37 = -1536;
            var0.field_40 = var0.field_53 ? var5 - 1 : var5 + 1024 + 1;
            var0.field_41 = var6 + 1536;
            method_267(var0.field_53, var5, var6);
            return;
         case 19:
            var0.field_41 -= 64;
            return;
         case 20:
            var0.field_33 = true;
            var0.field_36 = 0;
            int var13;
            if ((var13 = var0.field_40 & 1023) > 32 && var13 < 992) {
               int var8 = 768;
               if (var13 >= 512) {
                  var8 = 256;
               }

               if (var13 < 512 && !var0.field_53) {
                  var8 = -(1024 - var8);
               }

               method_267(var0.field_53, var5 - var8, var6);
            } else {
               method_267(var0.field_53, var5, var6);
            }

            return;
         case 21:
         case 22:
            var0.field_33 = true;
            var0.field_36 = 0;
            if (var1 == 21) {
               var0.field_41 += 512;
            } else if (var1 == 22) {
               var0.field_41 = var6 + 1536;
            }

            int var7 = var0.field_53 ? 1 : -1;
            field_348[3 * field_239].field_78 = var0.field_40;
            field_348[3 * field_239].field_79 = var0.field_37;
            field_348[3 * field_239].field_80 = 0;
            field_348[3 * field_239].field_82 = 1024 * var7;
            field_348[3 * field_239].field_83 = 0;
            field_348[3 * field_239].field_88 = 9 - (var0.field_53 ? 1 : 0);
            return;
         case 23:
            var0.field_33 = true;
            var0.field_36 = 0;
            var0.field_40 = var0.field_53 ? var5 - 1 : var5 + 1024 + 1;
            method_267(var0.field_53, var5, var6);
            return;
         case 24:
            var0.field_37 = -1536;
            var0.field_41 = var6 + 1536;
            if (method_106(var0.field_40 - var5) >= 1024 || method_106(var0.field_40 - var5) == 0) {
               var0.field_40 = var0.field_40 + (var0.field_53 ? 1 : -1);
            }

            method_268(false, var5, var6);
            return;
         case 27:
            var0.field_40 = var5;
            goto case 26;
         case 26:
            var0.field_33 = false;
            var0.field_41 = var6;
            method_254(field_348[3 * field_239 + 2], var5, var6, 0, 0, 1024, 0, true);
            field_348[3 * field_239].field_88 = 0;
            return;
         case 29:
            var0.field_37 = -1536;
            var0.field_41 += 1536;
            var0.field_40 = var0.field_40 + (var0.field_53 ? 1024 : -1024);
            var0.field_33 = false;
            field_348[3 * field_239 + 2].field_88 = 0;
            field_348[3 * field_239].field_88 = 0;
            return;
         case 30:
            var0.field_40 = var5 + (var0.field_53 ? 1 : 1023);
            var0.field_33 = false;
            var0.field_41 = var6 - 2;
            method_254(field_348[3 * field_239 + 2], var0.field_40, var6 - 2, 0, 0, 1024, 0, true);
            field_348[3 * field_239].field_88 = 0;
                  break;
}
   }

   // $VF: renamed from: a (d, int, int) void
   private static void method_245(class_2 var0, int var1, int var2) {
      bool var10000 = false;
      if (var0.field_63 <= var0.field_64 / 2 && var0.field_63 + var2 > var0.field_64 / 2) {
         var10000 = true;
      }

      bool var3 = var10000;
      switch (var1) {
         case 8:
            if (var0.field_63 == var0.field_64) {
               var0.field_41 = var0.field_56 - 1536 - 1;
            }

            return;
         case 12:
            if (var3) {
               var0.field_39 = -160;
               var0.field_37 += 160;
            }
            goto case 9;
         case 9:
         case 10:
         case 11:
         case 13:
         case 14:
         case 15:
         default:
            return;
         case 16:
         case 17:
            if (var0.field_63 < var0.field_64) {
               int var4 = var1 == 16 ? 128 * var0.field_63 / var0.field_64 : 128 + 128 * var0.field_63 / var0.field_64;
               var0.field_34 = -var0.field_36 + (var0.field_53 ? 1 : -1) * (1536 * field_404[var4 & 511] >> 10);
               var0.field_35 = -var0.field_37 - (1536 * field_404[var4 + 128 & 511] >> 10);
            }
                  break;
}
   }

   // $VF: renamed from: a (d, int, int, int, int, int) void
   private static void method_246(class_2 var0, int var1, int var2, int var3, int var4, int var5) {
      var0.field_58 = var1;
      var0.field_60 = var2;
      var0.field_61 = var3;
      var0.field_62 = var4;
      var0.field_64 = var5;
      var0.field_63 = 0;
      var0.field_65 = 0;
      switch (var1) {
         case 1:
            var0.field_65 = var0.field_53 ? 100 : -100;
            var0.field_66 = (var0.field_65 - var0.field_46) * 1024 / var0.field_64;
            var0.field_67 = var0.field_46;
            return;
         case 4:
         case 12:
            int var10001 = 0;
            if (var0.field_61 > 0) {
               var10001 = -var0.field_61;
            }

            var0.field_61 = var10001;
            return;
         case 5:
            var0.field_66 = 1536;
            return;
         case 13:
            var0.field_66 = var0.field_46;
            var0.field_67 = var0.field_47;
            goto case 2;
         case 2:
         case 3:
         case 6:
         case 7:
         case 8:
         case 9:
         case 10:
         case 11:
         case 14:
         case 15:
         case 16:
         case 17:
         case 18:
         default:
            return;
         case 19:
            var0.field_64 = 1000;
                  break;
}
   }

   // $VF: renamed from: a (d, int, int, int) void
   private static void method_247(class_2 var0, int var1, int var2, int var3) {
      bool var4 = false;
      var0.field_71 = var0.field_69 = 0;
      var0.field_72 = var0.field_70 = 0;
      bool var5 = false;
      switch (var1) {
         case 4:
         case 9:
         case 10:
         case 20:
         case 21:
            bool var25 = false;
            if (var0.field_63 == 0) {
               var25 = true;
            }

            var5 = var25;
            goto case 5;
         case 5:
         case 6:
         case 7:
         case 8:
         case 14:
         case 15:
         case 16:
         case 17:
         case 18:
         case 19:
         default:
            break;
         case 11:
         case 12:
         case 13:
            bool var10000 = false;
            if (var0.field_63 <= var0.field_62 && var0.field_63 + var3 > var0.field_62) {
               var10000 = true;
            }

            var5 = var10000;
                  break;
}

      switch (var1) {
         case 0:
         case 15:
            if (var0.field_63 == 0) {
               int var14;
               if (var1 == 15) {
                  var14 = 1505536;
               } else {
                  var14 = var0.field_46 * var0.field_46 + var0.field_47 * var0.field_47;
               }

               int var18 = var0.field_60;
               int var20 = var0.field_61;
               int var22;
               if ((var22 = method_270(var14) * var20 >> 10) < var18) {
                  var22 = var18;
               }

               if (var1 == 15) {
                  var22 = var22 * var0.field_74 >> 16;
               } else {
                  var22 = var22 * var0.field_73 >> 16;
               }

               if (var1 == 15) {
                  var0.field_74 -= 9050;
               }

               if (var1 == 0 && var0.field_73 < 35000) {
                  var0.field_73 = 35000;
               }

               if (var0.field_62 == 1) {
                  var0.field_69 = (265 * var22 >> 10) * (var0.field_53 ? 1 : -1);
                  var0.field_70 = -(989 * var22 >> 10);
               } else {
                  var0.field_69 = (658 * var22 >> 10) * (var0.field_53 ? 1 : -1);
                  var0.field_70 = -(784 * var22 >> 10);
               }

               if (var1 == 15 && var0.field_47 > 0) {
                  var0.field_70 = var0.field_70 + (var0.field_47 * 500 >> 10);
                  var0.field_70 -= 100;
               }

               var0.field_46 = 0;
               var0.field_47 = 0;
            }
            break;
         case 1:
            if (var0.field_63 < var0.field_64) {
               int var13 = var0.field_67 + var0.field_66 * var0.field_63;
               int var17 = var0.field_67 + var0.field_66 * method_152(var0.field_63 + var2, var0.field_64);
               var0.field_69 = (var17 - var13) / 1024;
            } else {
               var0.field_71 = -var0.field_46;
               var0.field_72 = -var0.field_47;
               var4 = true;
            }
            break;
         case 2:
            if (var0.field_63 == 0) {
               var0.field_46 = var0.field_47 = 0;
               var0.field_69 = var0.field_53 ? var0.field_60 : -var0.field_60;
            }
            break;
         case 3:
            if (var0.field_63 == 0) {
               var0.field_69 = var0.field_36 * 1024 / var0.field_64;
               var0.field_70 = (var0.field_37 + 1536) * 1024 / var0.field_64;
            } else if (var0.field_63 == var0.field_64) {
               var0.field_69 = -var0.field_46;
               var0.field_70 = -var0.field_47;
               var0.field_40 = var0.field_40 + var0.field_36;
               var0.field_41 = var0.field_41 + 1536 + var0.field_37;
               var0.field_36 = 0;
               var0.field_37 = -1536;
            }
            break;
         case 5:
            if (var0.field_63 == 0) {
               var0.field_69 = (var0.field_53 ? 1 : -1) * var0.field_60 * 1024 / var0.field_64;
               var0.field_70 = -var0.field_66 * 1024 / var0.field_64;
            } else if (var0.field_63 == var0.field_64) {
               var0.field_69 = -var0.field_46;
               var0.field_70 = -var0.field_47;
            }
            break;
         case 6:
            if (var0.field_63 == 0) {
               var0.field_69 = -var0.field_46;
               var0.field_70 = -var0.field_47;
            }
            break;
         case 7:
            var0.field_69 = -var0.field_46 + var0.field_46 * var0.field_60 / 1024;
            break;
         case 8:
            var0.field_69 = (method_106(var0.field_46) - var0.field_60) * (var0.field_53 ? -1 : 1);
            break;
         case 9:
         case 20:
            if (var5) {
               if (var1 == 9) {
                  var0.field_47 = 0;
               }

               var0.field_69 = var0.field_53 ? var0.field_60 : -var0.field_60;
               var0.field_70 = var0.field_61;
            }
            break;
         case 10:
         case 11:
            if (var5) {
               var0.field_69 = (var0.field_53 ? var0.field_60 : -var0.field_60) - var0.field_46;
               var0.field_70 = var0.field_61 - var0.field_47;
            }
            break;
         case 12:
            if (var0.field_63 < var0.field_62) {
               var0.field_70 = -field_347[field_239].field_32 * var2 / 1024;
            }
            goto case 4;
         case 4:
            if (var5) {
               int var12 = var0.field_47;
               int var16 = var0.field_47 * var0.field_47 / 1024 + 17600 * var0.field_61;
               var0.field_69 = var0.field_53 ? var0.field_60 : -var0.field_60;
               var0.field_70 = -var12 - method_270(var12 * var12 - var16);
            }
            break;
         case 13:
            if (var0.field_63 < var0.field_62 && !var5) {
               var0.field_69 = -var0.field_46;
               var0.field_70 = -var0.field_47 - field_347[field_239].field_32 * var2 / 1024;
            } else if (var5) {
               var0.field_69 = var0.field_53 ? var0.field_60 : -var0.field_60;
               var0.field_70 = var0.field_61;
            }
            break;
         case 14:
            if (var0.field_63 == 0) {
               var0.field_69 = (method_106(var0.field_46) - (method_106(var0.field_46) + var0.field_60 >> 1)) * (var0.field_53 ? -1 : 1);
               var0.field_70 = method_106(var0.field_47) - (method_106(var0.field_47) + var0.field_61 >> 1);
            }
            break;
         case 16:
            if (var0.field_63 == 0) {
               int var11 = var0.field_53 ? 1 : -1;
               var0.field_69 = var11 * 256;
               var0.field_70 = 0;
            }
            break;
         case 17:
            if (var0.field_63 == 0) {
               var0.field_69 = -var0.field_46;
            }

            if (var0.field_47 > var0.field_61) {
               var0.field_70 = var0.field_61 - var0.field_47;
               if (var0.field_70 < -var0.field_60) {
                  var0.field_70 = -var0.field_60;
               }
            }
            break;
         case 18:
            if (var0.field_63 == 0) {
               var0.field_69 = -var0.field_46;
            }
            break;
         case 19:
            if (var0.field_63 > 100) {
               int var10 = var0.field_63 / 100;
               var0.field_69 = var10 * (var0.field_53 ? var0.field_60 : -var0.field_60);
               var0.field_63 -= 100 * var10;
            }
            break;
         case 21:
            if (var5) {
               var0.field_69 = var0.field_53 ? var0.field_60 : -var0.field_60;
               var0.field_70 = var0.field_61;
               int var6 = -field_348[3 * field_239 + field_347[field_239].field_30].field_83 * var0.field_69 / 1024;
               int var7 = field_348[3 * field_239 + field_347[field_239].field_30].field_82 * var0.field_69 / 1024;
               int var8 = field_348[3 * field_239 + field_347[field_239].field_30].field_82 * var0.field_70 / 1024;
               int var9 = field_348[3 * field_239 + field_347[field_239].field_30].field_83 * var0.field_70 / 1024;
               var0.field_71 = var6 + var8 - var0.field_46;
               var0.field_72 = var7 + var9 - var0.field_47;
               var4 = true;
            }
                  break;
}

      if (!var4) {
         if (field_348[3 * field_239 + field_347[field_239].field_30].field_88 != 0 && var1 >= 19) {
            int var15 = -field_348[3 * field_239 + field_347[field_239].field_30].field_83 * var0.field_69 / 1024;
            int var19 = field_348[3 * field_239 + field_347[field_239].field_30].field_82 * var0.field_69 / 1024;
            int var21 = field_348[3 * field_239 + field_347[field_239].field_30].field_82 * var0.field_70 / 1024;
            int var24 = field_348[3 * field_239 + field_347[field_239].field_30].field_83 * var0.field_70 / 1024;
            var0.field_71 = var15 + var21;
            var0.field_72 = var19 + var24;
            return;
         }

         if (var1 < 19) {
            var0.field_71 = var0.field_69;
            var0.field_72 = var0.field_70;
         }
      }
   }

   // $VF: renamed from: b (d, int) void
   private static void method_248(class_2 var0, int var1) {
      var0.field_63 = var0.field_63 + var1 > var0.field_64 ? var0.field_64 : var0.field_63 + var1;
   }

   // $VF: renamed from: a (d) bool
   private static bool method_249(class_2 var0) {
      if (!var0.field_54) {
         bool var1 = false;
         if (field_348[3 * field_239 + 2].field_88 != 0
            && field_348[3 * field_239 + 2].field_88 != 17
            && field_348[3 * field_239 + 2].field_88 != 9
            && field_348[3 * field_239 + 2].field_88 != 8) {
            var1 = true;
         }

         return var1;
      } else {
         bool var10000 = false;
         if (field_348[3 * field_239].field_88 == 12
            || field_348[3 * field_239].field_88 == 11
            || field_348[3 * field_239].field_88 == 9
            || field_348[3 * field_239].field_88 == 8
            || field_348[3 * field_239].field_88 == 17) {
            var10000 = true;
         }

         return var10000;
      }
   }

   // $VF: renamed from: c (d, int) void
   private static void method_250(class_2 var0, int var1) {
      int var2 = var0.field_40 + var0.field_38 + var0.field_46 * var1 / 1024;
      int var3 = var0.field_41 + var0.field_39 + var0.field_47 * var1 / 1024;
      if ((field_357[field_358[field_239] * 14 + 8] & 8) == 0) {
         int var4 = var0.field_36 + var0.field_34;
         int var5 = var0.field_37 + var0.field_35;
         int var6 = var4 / 2;
         int var7 = var5 / 2;
         bool var8 = true;
         if ((field_357[field_358[field_239] * 14 + 8] & 128) == 0) {
            field_348[3 * field_239 + 2].field_76 = method_251(
               field_348[3 * field_239 + 2], var0.field_40, var0.field_41, var2, var3, var0.field_54 ^ true, true, false, var0.field_53
            );
            field_348[3 * field_239 + 1].field_76 = method_251(
               field_348[3 * field_239 + 1],
               var0.field_40 + var0.field_36 / 2,
               var0.field_41 + var0.field_37 / 2,
               var2 + var6,
               var3 + var7,
               false,
               false,
               true,
               var0.field_53
            );
            class_3 var10000 = field_348[3 * field_239];
            bool var10001 = false;
            if (!var0.field_33
               && method_251(
                  field_348[3 * field_239],
                  var0.field_40 + var0.field_36,
                  var0.field_41 + var0.field_37,
                  var2 + var4,
                  var3 + var5,
                  var0.field_54,
                  false,
                  false,
                  var0.field_53
               )) {
               var10001 = true;
            }

            var10000.field_76 = var10001;
         } else if (var0.field_54) {
            field_348[3 * field_239 + 2].field_76 = false;
            field_348[3 * field_239 + 1].field_76 = false;
            class_3 var15 = field_348[3 * field_239];
            bool var16 = false;
            if (!var0.field_33
               && method_251(
                  field_348[3 * field_239],
                  var0.field_40 + var0.field_36,
                  var0.field_41 + var0.field_37,
                  var2 + var4,
                  var3 + var5,
                  true,
                  false,
                  false,
                  var0.field_53
               )) {
               var16 = true;
            }

            var15.field_76 = var16;
         } else {
            field_348[3 * field_239 + 2].field_76 = method_251(
               field_348[3 * field_239 + 2], var0.field_40, var0.field_41, var2, var3, true, true, false, var0.field_53
            );
            field_348[3 * field_239 + 1].field_76 = false;
            field_348[3 * field_239].field_76 = false;
            var8 = false;
         }

         if ((field_357[field_358[field_239] * 14 + 8] & 256) != 0 && !field_348[3 * field_239].field_76 && !var0.field_33 && var8) {
            field_348[3 * field_239].field_76 = method_251(
               field_348[3 * field_239],
               var0.field_40 + var0.field_36,
               var0.field_41 + var0.field_37,
               var2 + var4 + (var0.field_53 ? 32 : -32),
               var3 + var5,
               var0.field_54,
               false,
               false,
               var0.field_53
            );
            if (field_348[3 * field_239].field_76 && field_348[3 * field_239].field_88 != 11 && field_348[3 * field_239].field_88 != 12
               || field_348[3 * field_239].field_85 == 1) {
               field_348[3 * field_239].field_76 = false;
            }
         }
      } else {
         field_348[3 * field_239 + 2].field_76 = false;
         field_348[3 * field_239 + 1].field_76 = false;
         field_348[3 * field_239].field_76 = false;
      }

      if (field_348[3 * field_239 + 2].field_76) {
         int var9 = var0.field_40 - field_348[3 * field_239 + 2].field_78;
         int var12 = var0.field_41 - field_348[3 * field_239 + 2].field_79;
         field_348[3 * field_239 + 2].field_84 = var9 * var9 + var12 * var12;
      }

      if (field_348[3 * field_239 + 1].field_76) {
         int var10 = var0.field_40 + var0.field_36 / 2 - field_348[3 * field_239 + 1].field_78;
         int var13 = var0.field_41 + var0.field_37 / 2 - field_348[3 * field_239 + 1].field_79;
         field_348[3 * field_239 + 1].field_84 = var10 * var10 + var13 * var13;
      }

      if (field_348[3 * field_239].field_76) {
         int var11 = var0.field_40 + var0.field_36 - field_348[3 * field_239].field_78;
         int var14 = var0.field_41 + var0.field_37 - field_348[3 * field_239].field_79;
         field_348[3 * field_239].field_84 = var11 * var11 + var14 * var14;
      }
   }

   // $VF: renamed from: a (b, int, int, int, int, bool, bool, bool, bool) bool
   private static bool method_251(class_3 var0, int var1, int var2, int var3, int var4, bool var5, bool var6, bool var7, bool var8) {
      int var11 = var1;
      int var12 = var2;
      int var13 = var1;
      int var14 = var2;
      int var15 = var1;
      int var16 = var2;
      int var17 = var3 - var1;
      int var18 = var4 - var2;
      int var19 = var17 >= 0 ? 1024 : -1024;
      int var20 = var18 >= 0 ? 1024 : -1024;
      int var21 = 0;
      bool var10002 = false;
      if (var17 > 0) {
         var10002 = true;
      }

      int var22 = method_263(var1, 10, var10002);
      int var24 = 0;
      int var25 = 0;
      if (var18 != 0) {
         var10002 = false;
         if (var18 > 0) {
            var10002 = true;
         }

         var14 = method_262(var2, 10, var10002);
         var13 = (var3 - var1) * (var14 - var2) / (var4 - var2) + var1;
      }

      if (var17 != 0) {
         var10002 = false;
         if (var17 > 0) {
            var10002 = true;
         }

         var15 = method_262(var1, 10, var10002);
         var16 = (var4 - var2) * (var15 - var1) / (var3 - var1) + var2;
      }

      while (var11 != var3 || var12 != var4) {
         bool var29 = false;
         bool var30 = false;
         int var9 = var11;
         int var10 = var12;
         if (var17 == 0 || var18 != 0 && method_106(var1 - var13) <= method_106(var1 - var15) && method_106(var2 - var14) <= method_106(var2 - var16)) {
            var11 = var13;
            var12 = var14;
            var29 = true;
         }

         if (var18 == 0 || var17 != 0 && method_106(var1 - var13) >= method_106(var1 - var15) && method_106(var2 - var14) >= method_106(var2 - var16)) {
            var11 = var15;
            var12 = var16;
            var30 = true;
         }

         var14 = var29 ? var14 + var20 : var14;
         var13 = var29 ? (var3 - var1) * (var14 - var2) / (var4 - var2) + var1 : var13;
         var15 = var30 ? var15 + var19 : var15;
         var16 = var30 ? (var4 - var2) * (var15 - var1) / (var3 - var1) + var2 : var16;
         if (method_106(var11 - var1) > method_106(var3 - var1) || method_106(var12 - var2) > method_106(var4 - var2)) {
            var11 = var3;
            var12 = var4;
         }

         var21 = var29 && var30 ? var10 : var12;
         bool var31 = false;
         bool var32 = false;
         var10002 = false;
         if (var17 > 0) {
            var10002 = true;
         }

         var24 = method_263(var11, 10, var10002);
         var10002 = false;
         if (var18 > 0) {
            var10002 = true;
         }

         var25 = method_263(var12, 10, var10002);
         int var27 = var24 << 10;
         if (var5 && (var6 && (var24 != var22 || var0.field_85 == 13 || var0.field_85 == 14) || !var6) && var0.field_88 != 0) {
            var32 = method_252(var0, var11 - var27, var24, var25, var17, var6, var8);
         }

         if (!var32 || var0.field_88 == 0) {
            while (true) {
               var10002 = false;
               if (var17 > 0) {
                  var10002 = true;
               }

               var24 = method_263(var11, 10, var10002);
               var10002 = false;
               if (var18 > 0) {
                  var10002 = true;
               }

               var25 = method_263(var21, 10, var10002);
               var27 = var24 << 10;
               int var28 = var25 << 10;
               int var26 = method_293(var24, var25);
               if (method_253(var0, var27, var28, var9 - var27, var10 - var28, var11 - var27, var21 - var28, var26, var5, var6, var7)) {
                  var0.field_85 = var26;
                  var0.field_86 = var24;
                  var0.field_87 = var25;
                  var31 = true;
               }

               if (var31 || var21 == var12) {
                  break;
               }

               var21 = var12;
            }
         }

         if (var31 || var32) {
            return true;
         }

         var22 = var24;
      }

      return false;
   }

   // $VF: renamed from: a (b, int, int, int, int, bool, bool) bool
   private static bool method_252(class_3 var0, int var1, int var2, int var3, int var4, bool var5, bool var6) {
      if (var5) {
         int var19 = 0;
         int var21 = 0;
         int var10000 = 0;
         if (var0.field_88 != 0
            && var0.field_88 != 17
            && var0.field_88 != 11
            && var0.field_88 != 12
            && var0.field_88 != 13
            && var0.field_88 != 14
            && var0.field_88 != 15
            && var0.field_88 != 16) {
            var10000 = 22 * var0.field_88;
         }

         int var9 = var10000;
         int var10 = method_293(var2, var3);
         int var11 = method_293(var2, var3 + 1);
         var10000 = 0;
         if (var10 >= 0) {
            var10000 = var10;
         }

         var10 = var10000;
         var10000 = 0;
         if (var11 >= 0) {
            var10000 = var11;
         }

         var11 = var10000;
         int var12 = field_350[var9 + field_349[var10]];
         int var13 = field_350[var9 + field_349[var11]];
         var10000 = 0;
         if ((var12 & (var4 > 0 ? 1 : 4)) != 0) {
            var10000 = field_350[var9 + field_349[var10] + 1];
         }

         int var14 = var10000;
         var10000 = 0;
         if ((var13 & (var4 > 0 ? 2 : 8)) != 0) {
            var10000 = field_350[var9 + field_349[var11] + 1];
         }

         int var15 = var10000;
         if ((var4 <= 0 || var14 != 8) && (var4 >= 0 || var14 != 9) && var15 != 0) {
            var21 = var15;
            var19 = var11;
            var3++;
         } else {
            var21 = var14;
            var19 = var10;
         }

         if ((var19 == 14 || var19 == 26) && var1 > 768 || (var19 == 13 || var19 == 26) && var1 < 256) {
            var0.field_78 = (var2 << 10) + var1;
            var0.field_79 = (var3 << 10) + 1024;
            var0.field_80 = 0;
            var0.field_81 = -1;
            var0.field_82 = 0;
            var0.field_83 = -1024;
            var0.field_88 = 1;
            var0.field_85 = var19;
            var0.field_86 = var2;
            var0.field_87 = var3;
            return true;
         }

         if (var0.field_88 != var21 || var12 != 0 && var13 != 0) {
            int var16 = var2 << 10;
            int var17 = var3 << 10;
            int var18 = var4 > 0 ? 4 : -4;
            switch (var21) {
               case 0:
                  var0.field_88 = 0;
                  break;
               case 1:
                  method_254(var0, var16, var17, var1, 0, 1024, 0, true);
                  goto case 2;
               case 2:
               case 3:
               case 4:
               case 5:
               case 8:
               case 9:
               default:
                  break;
               case 6:
                  method_256(var0, var16, var17, var1 + var18, 0, var1 + var18, 1024, 1024, false);
                  break;
               case 7:
                  method_256(var0, var16, var17, var1 + var18, 0, var1 + var18, 1024, 1024, true);
                  break;
               case 10:
                  method_254(var0, var16, var17, var1, 0, 1024, 512, true);
                              break;
}

            if (var21 != 8 && var21 != 9) {
               var0.field_85 = var19;
               var0.field_86 = var2;
               var0.field_87 = var3;
               return true;
            }
         }
      } else {
         int var7 = 0;
         int var8 = 0;
         if (var0.field_88 == 8 || var0.field_88 == 9) {
            var7 = method_293(var2 + (var6 ? 1 : -1), var3);
            var8 = method_293(var2 + (var6 ? 1 : -1), var3 + 1);
         } else if (var0.field_88 == 17) {
            var7 = method_293(var2, var3);
         }

         if (((var7 != 5 || var8 != 17) && var7 != 17 || var0.field_88 != 8)
            && ((var7 != 6 || var8 != 18) && var7 != 18 || var0.field_88 != 9)
            && (var7 != 19 || var0.field_88 != 17)) {
            var0.field_88 = 0;
            return true;
         }
      }

      return false;
   }

   // $VF: renamed from: a (b, int, int, int, int, int, int, int, bool, bool, bool) bool
   private static bool method_253(
      class_3 var0, int var1, int var2, int var3, int var4, int var5, int var6, int var7, bool var8, bool var9, bool var10
   ) {
      switch (var7) {
         case 1:
            if (method_254(var0, var1, var2, var3, var4, var6, 0, true)
               || method_254(var0, var1, var2, var3, var4, var6, 1024, false)
               || method_255(var0, var1, var2, var3, var4, var5, 0, true)
               || method_255(var0, var1, var2, var3, var4, var5, 1024, false)) {
               return true;
            }
            break;
         case 2:
            if ((var8 || var10) && method_255(var0, var1, var2, var3, var4, var5, 0, true)) {
               return true;
            }
            break;
         case 3:
            if ((var8 || var9) && method_254(var0, var1, var2, var3, var4, var6, 0, true)) {
               return true;
            }
            break;
         case 4:
            if ((var8 || var10) && method_255(var0, var1, var2, var3, var4, var5, 1024, false)) {
               return true;
            }
            break;
         case 5:
            if (var8 && method_254(var0, var1, var2, var3, var4, var6, 0, true)
               || !var9 && !var10 && method_257(var0, var1, var2, var3, var4, var5, var6, 512, 511, false)
               || var8 && method_255(var0, var1, var2, var3, var4, var5, 0, true)) {
               return true;
            }
            break;
         case 6:
            if (var8 && method_254(var0, var1, var2, var3, var4, var6, 0, true)
               || !var9 && !var10 && method_257(var0, var1, var2, var3, var4, var5, var6, 512, 511, true)
               || var8 && method_255(var0, var1, var2, var3, var4, var5, 1024, false)) {
               return true;
            }
            break;
         case 7:
            if (var8 && method_256(var0, var1, var2, var3, var4, var5, var6, 1024, false)) {
               return true;
            }
            break;
         case 8:
            if (var8 && method_256(var0, var1, var2, var3, var4, var5, var6, 1024, true)) {
               return true;
            }
            goto case 9;
         case 9:
         case 10:
         case 11:
         case 12:
         case 15:
         case 16:
         default:
            break;
         case 13:
            if (!var9
               && !var10
               && (
                  method_257(var0, var1, var2, var3, var4, var5, var6, 256, 511, false)
                     || method_261(var0, var1, var2, var3, var4, var5, var6, 256, 511, 768, true)
               )) {
               return true;
            }

            if (method_255(var0, var1, var2, var3, var4, var5, 0, true)
               || method_255(var0, var1, var2, var3, var4, var5, 256, false)
               || method_259(var0, var1, var2, var3, var4, var6, 256, 0, true)
               || method_259(var0, var1, var2, var3, var4, var6, 256, 0, false)) {
               return true;
            }
            break;
         case 14:
            if (!var9
               && !var10
               && (
                  method_257(var0, var1, var2, var3, var4, var5, var6, 256, 511, true)
                     || method_261(var0, var1, var2, var3, var4, var5, var6, 256, 511, 768, false)
               )) {
               return true;
            }

            if (method_255(var0, var1, var2, var3, var4, var5, 1024, false)
               || method_255(var0, var1, var2, var3, var4, var5, 768, true)
               || method_259(var0, var1, var2, var3, var4, var6, 256, 768, true)
               || method_259(var0, var1, var2, var3, var4, var6, 256, 768, false)) {
               return true;
            }
            break;
         case 17:
            if (var8 && method_255(var0, var1, var2, var3, var4, var5, 0, true)) {
               return true;
            }
            break;
         case 18:
            if (var8 && method_255(var0, var1, var2, var3, var4, var5, 1024, false)) {
               return true;
            }
            break;
         case 19:
            if (!var9 && !var10 && method_254(var0, var1, var2, var3, var4, var6, 0, false)
               || !var9 && !var10 && method_254(var0, var1, var2, var3, var4, var6, 0, true)
               || var8 && method_254(var0, var1, var2, var3, var4, var6, 0, true)) {
               return true;
            }
            break;
         case 20:
            if (var8 && var9 && method_254(var0, var1, var2, var3, var4, var6, 0, true)) {
               return true;
            }
            break;
         case 21:
            if (method_254(var0, var1, var2, var3, var4, var6, 256, false)
               || method_254(var0, var1, var2, var3, var4, var6, 0, true)
               || method_260(var0, var1, var2, var3, var4, var5, 256, true)
               || method_260(var0, var1, var2, var3, var4, var5, 256, false)) {
               return true;
            }
            break;
         case 22:
            if (!var9 && !var10 && method_258(var0, var1, var2, var3, var4, var5, var6)) {
               return true;
            }
                  break;
}

      return false;
   }

   // $VF: renamed from: a (b, int, int, int, int, int, int, bool) bool
   private static bool method_254(class_3 var0, int var1, int var2, int var3, int var4, int var5, int var6, bool var7) {
      int var8 = var7 ? 1 : -1;
      if (var4 == var5 && var5 == var6 && var6 == 0 && var7) {
         return false;
      } else if (var4 != var5 && var8 * var4 <= var8 * var6 && var8 * var5 >= var8 * var6) {
         var0.field_78 = var1 + var3;
         var0.field_79 = var2 + var6;
         var0.field_80 = 0;
         var0.field_81 = -var8;
         var0.field_82 = 0;
         var0.field_83 = -var8 * 1024;
         var0.field_88 = var7 ? (var6 == 0 ? 1 : 10) : 17;
         return true;
      } else {
         return false;
      }
   }

   // $VF: renamed from: b (b, int, int, int, int, int, int, bool) bool
   private static bool method_255(class_3 var0, int var1, int var2, int var3, int var4, int var5, int var6, bool var7) {
      int var8 = var7 ? 1 : -1;
      if (var3 != var5 && var8 * var3 <= var8 * var6 && var8 * var5 >= var8 * var6) {
         var0.field_78 = var1 + var6;
         var0.field_79 = var2 + var4;
         var0.field_80 = -var8;
         var0.field_81 = 0;
         var0.field_82 = -var8 * 1024;
         var0.field_83 = 0;
         var0.field_88 = 9 - (var7 ? 1 : 0);
         return true;
      } else {
         return false;
      }
   }

   // $VF: renamed from: a (b, int, int, int, int, int, int, int, bool) bool
   private static bool method_256(class_3 var0, int var1, int var2, int var3, int var4, int var5, int var6, int var7, bool var8) {
      int var9 = var8 ? -1 : 1;
      int var10 = var8 ? 1024 : 0;
      if (var4 > var7 || var9 * var3 > var9 * var10 + (var7 - var4) || var6 < var7 && var9 * var5 < var9 * var10 + (var7 - var6)) {
         return false;
      } else {
         var0.field_78 = var1 + (var5 + var3) / 2;
         var0.field_79 = var2 - (var5 + var3) / 2 * var9 - (var10 - var7);
         var0.field_80 = 0;
         var0.field_81 = -2;
         var0.field_82 = -102400 * var9 / 141;
         var0.field_83 = -726;
         var0.field_88 = (var8 ? 1 : 0) + 6;
         return true;
      }
   }

   // $VF: renamed from: a (b, int, int, int, int, int, int, int, int, bool) bool
   private static bool method_257(class_3 var0, int var1, int var2, int var3, int var4, int var5, int var6, int var7, int var8, bool var9) {
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
   }

   // $VF: renamed from: a (b, int, int, int, int, int, int) bool
   private static bool method_258(class_3 var0, int var1, int var2, int var3, int var4, int var5, int var6) {
      if (var3 <= 512 && var5 >= 512) {
         var0.field_78 = var1 + 512;
         var0.field_79 = var2 + (var4 + var6) / 2;
         var0.field_80 = 1;
         var0.field_81 = 0;
         var0.field_82 = -1024;
         var0.field_83 = 0;
         var0.field_88 = 15;
         return true;
      } else if (var3 >= 512 && var5 <= 512) {
         var0.field_78 = var1 + 512;
         var0.field_79 = var2 + (var4 + var6) / 2;
         var0.field_80 = -1;
         var0.field_81 = 0;
         var0.field_82 = 1024;
         var0.field_83 = 0;
         var0.field_88 = 16;
         return true;
      } else {
         return false;
      }
   }

   // $VF: renamed from: b (b, int, int, int, int, int, int, int, bool) bool
   private static bool method_259(class_3 var0, int var1, int var2, int var3, int var4, int var5, int var6, int var7, bool var8) {
      int var9 = var8 ? 1 : -1;
      int var10 = var8 ? 0 : 1024;
      if (var4 != var5 && var9 * var4 <= var9 * var10 && var9 * var5 >= var9 * var10 && var3 >= var7 && var3 <= var6 + var7) {
         var0.field_78 = var1 + var3;
         var0.field_79 = var2 + var10;
         var0.field_80 = 0;
         var0.field_81 = -var9;
         var0.field_82 = 0;
         var0.field_83 = -var9 * 1024;
         var0.field_88 = 14 - (var8 ? 1 : 0);
         return true;
      } else {
         return false;
      }
   }

   // $VF: renamed from: c (b, int, int, int, int, int, int, bool) bool
   private static bool method_260(class_3 var0, int var1, int var2, int var3, int var4, int var5, int var6, bool var7) {
      int var8 = var7 ? 1 : -1;
      int var9 = var7 ? 0 : 1024;
      if (var4 <= var6 && var3 != var5 && var8 * var3 <= var8 * var9 && var8 * var5 >= var8 * var9) {
         var0.field_78 = var1 + var9;
         var0.field_79 = var2 + var4;
         var0.field_80 = -var8;
         var0.field_81 = 0;
         var0.field_82 = -var8 * 1024;
         var0.field_83 = 0;
         var0.field_88 = 9 - (var7 ? 1 : 0);
         return true;
      } else {
         return false;
      }
   }

   // $VF: renamed from: a (b, int, int, int, int, int, int, int, int, int, bool) bool
   private static bool method_261(class_3 var0, int var1, int var2, int var3, int var4, int var5, int var6, int var7, int var8, int var9, bool var10) {
      int var11 = var10 ? -1 : 1;
      if (var4 != 0 || (var10 || var3 < var9 || var3 >= var7 + var9) && (!var10 || var3 <= 1024 - var7 - var9 || var3 > 1024 - var9)) {
         if ((!var10 && var3 <= var9 && var5 >= var9 || var10 && var3 >= 1024 - var9 && var5 <= 1024 - var9)
            && (var3 == var5 ? var4 : (var6 - var4) / (var5 - var3) * (var10 ? 1024 - var9 - var3 : var9 - var3) + var4) < var8) {
            var0.field_78 = var1 + (var10 ? 1024 - var9 : var9);
            int var10001 = var2 + var4;
            sbyte var10002 = 0;
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
   }

   // $VF: renamed from: b (int, int, bool) int
   private static int method_262(int var0, int var1, bool var2) {
      return var2 ? (var0 - 1 >> var1) + 1 << var1 : var0 >> var1 << var1;
   }

   // $VF: renamed from: c (int, int, bool) int
   private static int method_263(int var0, int var1, bool var2) {
      return var2 ? var0 - 1 >> var1 : var0 >> var1;
   }

   // $VF: renamed from: m (int) int
   private static int method_264(int var0) {
      int var10000 = 0;
      bool var1 = (var0 & 16) != 0;
      bool var2 = (var0 & 32) != 0;
      bool var3 = (var0 & 64) != 0;
      int var10001 = 0;
      if (field_347[field_239].field_54 && !var1 || var2) {
         var10001 = field_347[field_239].field_36;
      }

      int var4 = field_347[field_239].field_40 + var10001;
      var10001 = 0;
      if (field_347[field_239].field_54 && !var1 || var2) {
         var10001 = field_347[field_239].field_37;
      }

      int var5 = field_347[field_239].field_41 + var10001;
      if ((var0 & 512) != 0) {
         var4 += 5 * (field_347[field_239].field_53 ? 1 : -1);
      }

      if ((var0 & 1024) != 0) {
         var4 += 512 * (field_347[field_239].field_53 ? 1 : -1);
      }

      int var6 = 0;
      int var7 = 0;
      var10000 = 1;
      if ((var0 & 1) == 0) {
         sbyte var16 = 0;
         if ((var0 & 2) == 0) {
            var16 = 1;
         }

         var10000 = var16 + -1;
      }

      int var8 = var10000;
      var10000 = 1;
      if ((var0 & 4) == 0) {
         sbyte var18 = 0;
         if ((var0 & 8) == 0) {
            var18 = 1;
         }

         var10000 = var18 + -1;
      }

      int var9 = var10000;
      var9 = field_347[field_239].field_47 > 0 ? var9 : -var9;
      if ((var0 & 128) != 0) {
         var9 = -1;
      } else if ((var0 & 256) != 0) {
         var9 = 1;
      } else if ((var0 & 2048) != 0) {
         var9 -= 2;
      }

      if (var3) {
         return method_294(field_346.field_86 + var8, field_346.field_87 + var9);
      } else {
         if ((field_347[field_239].field_54 ? field_348[3 * field_239].field_88 : field_348[3 * field_239 + 2].field_88) != 0) {
            var4 -= field_347[field_239].field_54 ? field_348[3 * field_239].field_80 : field_348[3 * field_239 + 2].field_80;
            var5 -= field_347[field_239].field_54 ? field_348[3 * field_239].field_81 : field_348[3 * field_239 + 2].field_81;
         }

         var6 = method_263(var4, 10, field_347[field_239].field_53 ^ true) + (field_347[field_239].field_53 ? var8 : -var8);
         bool var10002 = false;
         if (field_347[field_239].field_47 > 0) {
            var10002 = true;
         }

         var7 = method_263(var5, 10, var10002) + var9;
         return var6 >= 0 && var6 <= field_376 && var7 >= 0 && var7 <= field_377 ? method_293(var6, var7) : -1;
      }
   }

   // $VF: renamed from: a (d, int, int) bool
   private static bool method_265(class_2 var0, int var1, int var2) {
      field_346.field_88 = 0;
      int var3 = var0.field_40;
      int var4 = var0.field_41;
      int var5 = var3 + var0.field_46 * var2 / 1024;
      int var6 = var4 + var1;
      if (var0.field_54) {
         var3 += var0.field_36;
         var4 += var0.field_37;
         var5 += var0.field_36;
         var6 += var0.field_37;
      }

      return method_251(field_346, var3, var4, var5, var6, true, var0.field_54, false, var0.field_53);
   }

   // $VF: renamed from: h (int) bool
   private static bool method_266(int var0) {
      bool var10000 = false;
      if ((field_347[field_239].field_75 & var0) != 0) {
         var10000 = true;
      }

      bool var1 = var10000;
      var10000 = false;
      if (field_360 == 0) {
         var10000 = var1;
      }

      return var10000;
   }

   // $VF: renamed from: a (bool, int, int) void
   private static void method_267(bool var0, int var1, int var2) {
      if (var0) {
         method_255(field_348[3 * field_239], var1, var2, 0, 0, 1024, 0, true);
      } else {
         method_255(field_348[3 * field_239], var1, var2, 1024, 0, 0, 1024, false);
      }

      field_348[3 * field_239 + 2].field_88 = 0;
   }

   // $VF: renamed from: b (bool, int, int) void
   private static void method_268(bool var0, int var1, int var2) {
      if (var0) {
         method_254(field_348[3 * field_239], var1, var2, 0, 0, 1024, 0, true);
      } else {
         method_254(field_348[3 * field_239], var1, var2, 0, 1024, 0, 0, false);
      }

      field_348[3 * field_239 + 2].field_88 = 0;
   }

   // $VF: renamed from: f (int, int) int
   private static int method_269(int var0, int var1) {
      if (var0 < 0) {
         var0 = -var0;
      }

      if (var1 < 0) {
         var1 = -var1;
      }

      int var2;
      int var3;
      if (var0 < var1) {
         var2 = var0;
         var3 = var1;
      } else {
         var2 = var1;
         var3 = var0;
      }

      int var4 = var2 * 441 + var3 * 1007;
      if (var3 < var2 << 4) {
         var4 -= var3 * 40;
      }

      return var4 >> 10;
   }

   // $VF: renamed from: n (int) int
   private static int method_270(int var0) {
      int var3 = 0;

      for (int var2 = 268435456; var2 != 0; var2 >>= 2) {
         int var1 = var3 + var2;
         var3 >>= 1;
         if (var1 <= var0) {
            var0 -= var1;
            var3 += var2;
         }
      }

      return var3;
   }

   // $VF: renamed from: b (int, int) bool
   private static bool method_271(int var0, int var1) {
      switch (var1) {
         case 2:
         case 5:
         case 17:
            bool var3 = false;
            if (var0 > 0) {
               var3 = true;
            }

            return var3;
         case 3:
         case 7:
         case 8:
         case 9:
         case 10:
         case 11:
         case 12:
         case 15:
         case 16:
         default:
            return false;
         case 4:
         case 6:
         case 18:
            bool var2 = false;
            if (var0 < 0) {
               var2 = true;
            }

            return var2;
         case 13:
         case 14:
            bool var10000 = false;
            if (var0 != 0) {
               var10000 = true;
            }

            return var10000;
      }
   }

   // $VF: renamed from: c (int, int) bool
   private static bool method_272(int var0, int var1) {
      int var2 = 0;
      if (var0 >= 0 && var0 < field_356.Length) {
         var2 = field_356[var0];
      } else {
         var2 = 1;
      }

      bool var10000 = false;
      if ((var2 & var1) != 0) {
         var10000 = true;
      }

      return var10000;
   }

   // $VF: renamed from: d (int, int) bool
   private static bool method_273(int var0, int var1) {
      bool var10000 = false;
      if ((1 << var0 & var1) != 0) {
         var10000 = true;
      }

      return var10000;
   }

   // $VF: renamed from: aI () void
   private static void method_274() {
      if (field_358 != null) {
         method_275();
      } else {
         field_358 = new int[10];
         field_359 = new int[10];
         method_275();
      }
   }

   // $VF: renamed from: aJ () void
   private static void method_275() {
      for (int var0 = 0; var0 < 10; var0++) {
         field_358[var0] = 0;
         field_359[var0] = 0;
      }

      field_360 = 0;
      field_361 = 0;
   }

   // $VF: renamed from: aK () void
   private static void method_276() {
      field_357 = method_53(1, 0, 9464, null);
   }

   // $VF: renamed from: o (int) int
   private static int method_277(int var0) {
      int var1;
      return (var1 = field_357[var0 * 14]) >= 0 ? var1 : 100 + (field_347[field_239].field_52 >> 3);
   }

   // $VF: renamed from: L (int) void
   private static void method_278(int var0) {
      if (field_240 == field_239) {
         switch (field_357[field_358[field_239] * 14 + 12]) {
            case 1:
            case 3:
               int var10000 = field_357[field_358[field_239] * 14 + 13];
               bool var10001 = false;
               if (field_357[field_358[field_239] * 14 + 12] == 3) {
                  var10001 = true;
               }

               method_232(var10000, var10001);
               goto case 2;
            case 2:
                        break;
}
      }

      switch (var0) {
         case 20:
            field_361 |= 1;
            break;
         case 24:
         case 25:
         case 29:
         case 41:
         case 54:
         case 76:
         case 82:
         case 89:
            method_125(1, field_347[field_239].field_40, field_347[field_239].field_41, 0);
            break;
         case 48:
            field_361 |= 2;
            break;
         case 62:
            field_361 |= 8;
            break;
         case 67:
            field_361 |= 4;
            break;
         case 69:
            field_361 |= 16;
            break;
         case 123:
            field_361 |= 32;
            break;
         case 125:
            field_361 |= 64;
                  break;
}

      field_358[field_239] = var0;
      field_359[field_239] = method_277(var0);
      if ((field_357[field_358[field_239] * 14 + 8] & 32768) != 0) {
         field_347[field_239].field_52 = field_347[field_239].field_51;
      }

      if (field_357[field_358[field_239] * 14 + 6] != -1) {
         method_186(field_357[field_358[field_239] * 14 + 6], field_359[field_239], field_357[field_358[field_239] * 14 + 7]);
      }

      if (field_239 == field_240 && field_357[field_358[field_239] * 14 + 12] != -1) {
         switch (field_357[field_358[field_239] * 14 + 12]) {
            case 0:
               method_237();
               return;
            case 1:
            case 3:
            default:
               break;
            case 2:
            case 5:
               method_233(field_357[field_358[field_239] * 14 + 13], field_358[field_239]);
               method_231();
               return;
            case 4:
               method_231();
                        break;
}
      }
   }

   // $VF: renamed from: i (int) bool
   private static bool method_279(int var0) {
      int var1 = field_358[field_239];
      int var2 = 0;

      while (var1 != -1) {
         var2 = field_357[var1 * 14 + 10];
         int var3;
         if ((var3 = field_357[var1 * 14 + 11]) != -1) {
            int var4 = field_357[var3];

            for (int var5 = 0; var5 < var4; var5++) {
               int var6;
               if (method_116((var6 = field_357[var3 + var5 * 2 + 1]) & 0xFF)
                  && (
                     (var6 = var6 >> 8) == 0
                        || method_116(var6 & 0xFF)
                           && ((var6 = var6 >> 8) == 0 || method_116(var6 & 0xFF) && ((var6 = var6 >> 8) == 0 || method_116(var6 & 0xFF)))
                  )) {
                  method_278(field_357[var3 + var5 * 2 + 2]);
                  return true;
               }
            }
         }

         var1 = var2;
      }

      if (field_359[field_239] != -1) {
         field_359[field_239] = field_359[field_239] - var0 >= 0 ? field_359[field_239] - var0 : -2;
         if (field_359[field_239] == -2 && field_357[field_358[field_239] * 14 + 1] != -1) {
            method_278(field_357[field_358[field_239] * 14 + 1]);
            return true;
         }
      }

      return false;
   }

   // $VF: renamed from: a (d) void
   private static void method_280(class_2 var0) {
      field_368 = false;
      int var2 = 0;
      int var3 = var0.field_46 * (ScreenW * 16) / 4143;
      int var4 = var0.field_47 * 5120 / 4143;
      var2 = (ScreenH * 16 + 768) + ((var0.field_45 * 10240 / (field_377 << 10) - 5120) * 256 >> 10);
      var3 = method_151(var3, -(ScreenW * 16), (ScreenW * 16));
      var4 = method_151(var4, -var2, var2);
      int var5 = var0.field_46 > 0 ? 1 : -1;

      for (int var6 = 0; var6 < 4; var6++) {
         if (method_271(var0.field_46, method_293((var0.field_44 >> 10) + var6 * var5, var0.field_45 >> 10))
            && method_271(var0.field_46, method_293((var0.field_44 >> 10) + var6 * var5, (var0.field_45 >> 10) - 1))) {
            var3 = 0;
         }
      }

      method_282(var0.field_44 - (ScreenW * 16) + var3, var0.field_45 - var2 + var4);
   }

   // $VF: renamed from: j (int, int) void
   private static void method_281(int var0, int var1) {
      field_368 = false;
      field_364 = var0;
      field_362 = var0;
      field_365 = var1;
      field_363 = var1;
      field_367 = 0;
      field_366 = 0;
      field_362 = method_151(field_362, 0, (field_376 << 10) - (ScreenW * 32));
      field_363 = field_363 > (field_377 << 10) - (ScreenH * 32) ? (field_377 << 10) - (ScreenH * 32) : field_363;
   }

   // $VF: renamed from: k (int, int) void
   private static void method_282(int var0, int var1) {
      field_368 = false;
      field_364 = method_151(var0, 0, (field_376 << 10) - (ScreenW * 32));
      field_365 = var1 > (field_377 << 10) - (ScreenH * 32) ? (field_377 << 10) - (ScreenH * 32) : var1;
   }

   // $VF: renamed from: M (int) void
   private static void method_283(int var0) {
      field_368 = false;
      field_364 = method_151((field_384[var0 * 2] << 10) - (ScreenW * 16), 0, (field_376 << 10) - (ScreenW * 32));
      field_365 = (field_384[var0 * 2 + 1] << 10) - (ScreenH * 16) > (field_377 << 10) - (ScreenH * 32) ? (field_377 << 10) - (ScreenH * 32) : (field_384[var0 * 2 + 1] << 10) - (ScreenH * 16);
   }

   // $VF: renamed from: aL () void
   private static void method_284() {
      field_368 = true;
      field_369 = 1;
      method_285(field_369);
   }

   // $VF: renamed from: N (int) void
   private static void method_285(int var0) {
      field_369 = var0;
      field_370 = 0;
      int var1;
      int var2;
      if (var0 == 0) {
         var1 = (field_378 << 10) - (ScreenW * 16);
         var2 = (field_379 << 10) - (ScreenH * 16);
      } else if (var0 == field_385 + 1) {
         var1 = (field_380 << 10) - (ScreenW * 16);
         var2 = (field_381 << 10) - (ScreenH * 16);
      } else {
         var1 = (field_384[field_369 - 1 << 1] << 10) + 512 - (ScreenW * 16);
         var2 = (field_384[(field_369 - 1 << 1) + 1] << 10) + 512 - (ScreenH * 16);
      }

      field_364 = field_362;
      field_365 = field_363;
      int var3 = (var1 >> 8) - (field_362 >> 8);
      int var4 = (var2 >> 8) - (field_363 >> 8);
      field_371 = method_111(var3 * var3 + var4 * var4) + 1 << 5;
      field_371 = field_371 + 20000 >> 1;
   }

   // $VF: renamed from: c (int, int, int, int) int
   private static int method_286(int var0, int var1, int var2, int var3) {
      int var4;
      if ((var4 = (var2 - var0 << 14) / (var1 - var0)) < 0) {
         var4 = 0;
      }

      if (var4 > 32768) {
         var4 = 32768;
      }

      return (((24576 - var4) * var4 >> 13) * var4 >> 14) * var3 >> 14;
   }

   // $VF: renamed from: d (int, int, int, int) int
   private static int method_287(int var0, int var1, int var2, int var3) {
      return method_153(var0, var1, method_286(0, var3, var2, var3), var3);
   }

   // $VF: renamed from: b (int, bool) void
   private static void method_288(int var0, bool var1) {
      if (field_368) {
         field_370 += var0 >> 6;
         if (field_370 > field_371) {
            method_285((field_369 + 1) % (field_385 + 2));
         }

         int var10;
         int var11;
         if (field_369 == 0) {
            var10 = (field_378 << 10) - (ScreenW * 16);
            var11 = (field_379 << 10) - (ScreenH * 16);
         } else if (field_369 == field_385 + 1) {
            var10 = (field_380 << 10) - (ScreenW * 16);
            var11 = (field_381 << 10) - (ScreenH * 16);
         } else {
            var10 = (field_384[field_369 - 1 << 1] << 10) + 512 - (ScreenW * 16);
            var11 = (field_384[(field_369 - 1 << 1) + 1] << 10) + 512 - (ScreenH * 16);
         }

         field_362 = method_287(field_364, var10, field_370 >> 4, field_371 >> 4);
         field_363 = method_287(field_365, var11, field_370 >> 4, field_371 >> 4);
         field_362 = method_151(field_362, 0, (field_376 << 10) - (ScreenW * 32));
         field_363 = field_363 > (field_377 << 10) - (ScreenH * 32) ? (field_377 << 10) - (ScreenH * 32) : field_363;
      } else {
         int var2 = field_364 - field_362;
         int var3 = field_365 - field_363;
         int var4 = (var2 >> 3) * var0 >> 15;
         int var5 = (var3 >> 3) * var0 >> 15;
         int var6 = var2 < 0 ? -1 : 1;
         int var7 = var3 < 0 ? -1 : 1;
         field_366 = method_151(field_366 + (var2 * 200 >> 16), -var4 * var6, var4 * var6);
         field_367 = method_151(field_367 + (var3 * 240 >> 16), -var5 * var7 >> 1, var5 * var7 >> 1);
         field_362 = field_362 + field_366;
         field_363 = field_363 + field_367;
         if (var1) {
            field_362 = method_151(field_362, field_347[field_240].field_40 - (ScreenW * 16) - 1920, field_347[field_240].field_40 - (ScreenW * 16) + 1920);
            field_363 = method_151(field_363, field_347[field_240].field_41 - (ScreenH * 16) - 512 - 2560, field_347[field_240].field_41 - (ScreenH * 16) - 512 + 2560);
         }

         field_362 = method_151(field_362, 0, (field_376 << 10) - (ScreenW * 32));
         field_363 = field_363 > (field_377 << 10) - (ScreenH * 32) ? (field_377 << 10) - (ScreenH * 32) : field_363;
      }
   }

   // $VF: renamed from: c () bool
   private static bool method_289() {
      int var0 = field_347[field_240].field_40 + (field_347[field_240].field_36 >> 1) >> 10;
      int var1 = field_347[field_240].field_41 + (field_347[field_240].field_37 >> 1) >> 10;
      int var2 = field_347[field_240].field_40 >> 10;
      int var3 = field_347[field_240].field_41 >> 10;
      int var4 = method_293(var0, var1) - 49;
      int var5 = method_293(var2, var3) - 49;
      int var6 = var4;
      if (var5 >= 0) {
         var6 = var5;
      }

      switch (field_278) {
         case 0:
            if (var0 == field_380 && (var1 == field_381 || var1 == field_381 - 1) && (field_372 & 16) == 0) {
               field_280[6 * field_240 + 5] = field_399;
               method_181();
               method_180();
               return true;
            }

            if (var6 >= 0 && (field_372 & 1 << var6) != 0 && (var6 == 0 || (field_372 & 1 << var6 - 1) == 0)) {
               field_372 ^= 1 << var6;
               field_374 = 128000 | 1 << var6;
               method_17(3, 128, 1);
               if (field_278 == 0) {
                  field_280[6 * field_240 + field_283] = field_399;
                  field_283++;
               }
            }

            if (field_277 && field_399 >= field_342[field_401 * 28 + 5]) {
               field_280[6 * field_240 + 5] = 0;
               method_181();
               method_180();
               return true;
            }
            break;
         case 1:
            if (var6 >= 0 && (field_372 & 1 << var6) != 0) {
               field_372 ^= 1 << var6;
               field_374 = 128000 | 1 << var6;
               method_17(3, 128, 1);
               field_286--;
               if (field_286 == 0) {
                  field_280[6 * field_240 + 5] = field_399;
                  method_181();
                  method_180();
                  return true;
               }
            }

            if (field_277 && field_399 >= field_285) {
               field_280[6 * field_240 + 5] = 0;
               method_181();
               method_180();
               return true;
            }
            break;
         case 2:
            if (var0 == field_380 && (var1 == field_381 || var1 == field_381 - 1)) {
               field_280[6 * field_240 + 5] = field_399;
               method_181();
               method_180();
               return true;
            }

            if (field_342[field_401 * 28 + 4] - field_399 < 0) {
               field_287 = true;
               int var10001 = 6 * field_240 + 5;
               int var10002 = 0;
               if (!field_277) {
                  var10002 = field_342[field_401 * 28 + 4];
               }

               field_280[var10001] = var10002;
               method_181();
               method_180();
               return true;
            }
            break;
         case 3:
            if (var6 >= 0 && (field_372 & 1 << var6) != 0) {
               if (field_401 == 2 || field_401 == 3 || field_401 == 6) {
                  field_389 = 2;
                  field_390 = 3;
               }

               field_372 ^= 1 << var6;
               field_374 = 128000 | 1 << var6;
               method_17(3, 128, 1);
               field_286--;
            }

            if (field_285 > 0 && field_285 - field_399 <= 0 || var0 == field_380 && (var1 == field_381 || var1 == field_381 - 1) && field_286 == 0) {
               field_280[6 * field_240 + 5] = field_399;
               method_181();
               method_180();
               return true;
            }
            break;
         case 4:
         case 5:
            if (var6 >= 0 && (field_372 & 1 << var6) != 0) {
               field_389 = 2;
               field_390 = 3;
               field_372 ^= 1 << var6;
               field_374 = 128000 | 1 << var6;
               method_17(3, 128, 1);
            }

            if (field_358[field_239] == 40 && (field_373 & 2) != 0) {
               field_373 ^= 2;
               method_167(-1, field_145[163], 1000, false, false);
            } else if ((field_358[field_239] == 86 || field_358[field_239] == 82) && (field_373 & 4) != 0) {
               field_373 ^= 4;
               method_167(-1, field_145[164], 1000, false, false);
            }

            if (var0 == field_380 && (var1 == field_381 || var1 == field_381 - 1) && (field_372 & 1) == 0) {
               field_347[field_239].field_37 = field_347[field_239].field_43 = -1536;
               field_347[field_239].field_41 = field_347[field_239].field_45 = (field_381 + 1 << 10) - 1;
               field_347[field_239].field_54 = false;
               method_180();
               return true;
            }
                  break;
}

      return false;
   }

   // $VF: renamed from: l (int, int) void
   private static void method_290(int var0, int var1) {
      short[] var3;
      field_376 = (var3 = field_396[var0])[0];
      field_377 = var3[1];
      field_384 = new int[32];
      field_375 = field_397[var0];
      int var2 = 2;
      int var4 = 0;

      do {
         int var5 = var3[var2++] + 1;
         short var6 = var3[var2++];

         while (--var5 >= 0) {
            field_375[var4++] = var6;
         }
      } while (var4 < field_376 * field_377);

      var4 = var2;

      while (var1 > 0) {
         if (var3[var4++] == -1) {
            var1--;
         }
      }

      field_378 = var3[var4++];
      field_379 = var3[var4++];
      field_380 = -1;
      field_381 = -1;
      if (var3[var4] != -2) {
         field_380 = var3[var4++];
         field_381 = var3[var4++];
      } else {
         var4++;
      }

      field_382 = -1;
      field_383 = -1;
      if (var3[var4] != -2) {
         field_382 = var3[var4++] << 10;
         field_383 = var3[var4++] << 10;
      } else {
         var4++;
      }

      int var18 = 0;

      while (var3[var4] != -1) {
         short var20 = var3[var4++];
         short var7 = var3[var4++];
         field_384[var18++] = var20;
         field_384[var18++] = var7;
         field_375[var7 * field_376 + var20] = (short)(48 + (var18 >> 1));
         field_375[(var7 - 1) * field_376 + var20] = (short)(48 + (var18 >> 1));
      }

      field_385 = var18 >> 1;
      field_374 = 0;
      field_386 = new short[field_376];

      for (int var22 = field_377 - 1; var22 >= 0; var22--) {
         int var21 = 0;

         while (var21 < field_376) {
            short var8;
            switch (var8 = field_375[var22 * field_376 + var21]) {
               case 1:
               case 3:
               case 5:
               case 6:
               case 7:
               case 8:
                  if (var22 > field_386[var21]) {
                     field_386[var21] = (short)var22;
                  }
                  goto case 2;
               case 2:
               case 4:
               default:
                  var21++;
                              break;
}
         }
      }
   }

   // $VF: renamed from: aM () void
   private static void method_291() {
      field_376 = -1;
      field_377 = -1;
   }

   // $VF: renamed from: aN () void
   private static void method_292() {
      for (int var1 = 0; var1 < field_377; var1++) {
         for (int var0 = 0; var0 < field_376; var0++) {
            if (field_375[var1 * field_376 + var0] == 63) {
               method_125(2, (var0 << 10) + 512, (var1 << 10) + 1024, 0);
               field_375[var1 * field_376 + var0] = 0;
            }
         }
      }
   }

   // $VF: renamed from: g (int, int) int
   private static int method_293(int var0, int var1) {
      return var0 >= 0 && var1 >= 0 && var0 < field_376 && var1 < field_377 ? field_375[var1 * field_376 + var0] : -1;
   }

   // $VF: renamed from: h (int, int) int
   private static int method_294(int var0, int var1) {
      if (var0 >= 0 && var1 >= 0 && var0 < field_376 && var1 < field_377) {
         short var2 = field_375[var1 * field_376 + var0];
         short var10000 = 0;
         if (var2 <= 26) {
            var10000 = var2;
         }

         return var10000;
      } else {
         return -1;
      }
   }

   // $VF: renamed from: O (int) void
   private static void method_295(int var0) {
      int var1 = (field_347[field_239].field_44 - field_362) * 32 >> 10;
      int var2 = (field_347[field_239].field_45 - field_363) * 32 >> 10;
      int var3;
      int var4;
      if (var0 < field_385) {
         var3 = ((field_384[var0 * 2] << 10) - field_362) * 32 >> 10;
         var4 = ((field_384[var0 * 2 + 1] << 10) - field_363) * 32 >> 10;
      } else {
         var3 = ((field_380 << 10) - field_362) * 32 >> 10;
         var4 = ((field_381 << 10) - field_363) * 32 >> 10;
      }

      sbyte var10 = 0;
      bool var11 = false;
      if (var3 > ScreenW - 5) {
         var4 = method_138(ScreenW - 5, var1, var2, var3, var4);
         var3 = ScreenW - 5;
         var11 = true;
      }

      if (var4 > ScreenH - 5) {
         var3 = method_137(ScreenH - 5, var1, var2, var3, var4);
         var4 = ScreenH - 5;
         var10 = 1;
         var11 = true;
      }

      if (var3 < 5) {
         var4 = method_138(5, var1, var2, var3, var4);
         var3 = 5;
         var10 = 4;
         var11 = true;
      }

      if (var4 < 5) {
         var3 = method_137(5, var1, var2, var3, var4);
         var4 = 5;
         var10 = 3;
         var11 = true;
      }

      if (var11) {
         method_10(182, var3, var4, 3, var10);
      }
   }

   // $VF: renamed from: aO () void
   private static void method_296() {
      for (int var0 = 0; var0 < field_385; var0++) {
         int var1 = ((field_384[var0 << 1] << 10) - field_362) * 32 >> 10;
         int var2 = ((field_384[(var0 << 1) + 1] << 10) - field_363) * 32 >> 10;
         int var3 = 0;
         if (field_374 >> 8 > 0 && (field_374 & 1 << var0) != 0) {
            var3 = field_404[(field_374 >> 8) * 128 / 500 + 128 & 511] * 96 >> 10;
         }

         int var4 = (field_121 >> 7) * (field_374 >> 8 > 0 ? 4 : 1) % 3;
         if (field_278 == 0 && ((field_372 & 1 << var0) != 0 || (field_374 & 1 << var0) != 0)) {
            int var5;
            {
               var5 = 140;
               if (var0 != 0) {
                  bool var10000 = false;
                  if ((field_372 & 1 << var0 - 1) != 0) {
                     var10000 = true;
                  }

                  bool var10001 = false;
                  if ((field_372 & 1 << var0) != 0) {
                     var10001 = true;
                  }

                  if (var10000 == var10001 && (field_374 & 1 << var0) == 0) {
                     goto label56_end;
                  }
               }

               var5 = 137 + var4;
            }
label56_end: ;

            method_10(var5, var1 + 16, var2 + 16 - var3, 3, 0);
         } else if ((field_372 & 1 << var0) != 0 || (field_374 & 1 << var0) != 0) {
            method_10(137 + var4, var1 + 16, var2 + 16 - var3, 3, 0);
         }
      }

      field_374 = (field_374 >> 8) - field_400 << 8 | field_374 & 0xFF;
      if (field_374 >> 8 <= 0) {
         field_374 = 0;
      }

      if (field_380 != -1) {
         int var6 = ((field_380 << 10) - field_362) * 32 >> 10;
         int var7 = ((field_381 << 10) - field_363) * 32 >> 10;
         method_10(191, var6 + 16, var7 + 16, 3, 0);
      }
   }

   // $VF: renamed from: aP () void
   private static void method_297() {
      if (field_274) {
         method_332();
         string var5 = field_224;
         if (field_124) {
            var5 = var5 + '_';
         }

         int var1 = field_214 + 1 + 4;
         int var2 = field_215 + field_217 - method_27(0) - (method_27(0) >> 1) - 4;
         int var3 = field_216 - 1 - 8;
         int var4 = method_27(0) + 4;
         field_151.setColor(16777215);
         field_151.fillRect(var1 - 1, var2 - 1, var3 + 2, var4 + 2);
         field_151.setColor(2758677);
         field_151.fillRect(var1, var2, var3, var4);
         field_151.setColor(16777215);
         method_23(0, var5, var1 + 2, var2 + 2, 20);
      } else {
         method_217();
         method_210(6);
         method_208(field_333, field_334, field_329 - field_331, field_330 - field_328 / 2, true, 16777215, 2758677);
         field_151.setColor(16777215);
         string var0 = field_224;
         if (field_124) {
            var0 = var0 + '_';
         }

         method_23(0, var0, field_333, field_334 + 1, 20);
      }
   }

   // $VF: renamed from: P (int) void
   private static void method_298(int var0) {
      method_99(1, 1500);
      field_389 = 0;
      field_390 = 1;
      field_387 = field_342[var0 * 28 + 9];
      method_99(field_387, field_342[var0 * 28 + 10]);
      field_388 = field_342[var0 * 28 + 11];
      method_103(field_388);
   }

   // $VF: renamed from: aQ () void
   private static void method_299() {
      if (field_278 != 4 && field_278 != 5 && (field_278 != 3 || field_401 != 2 && field_401 != 3 && field_401 != 5 && field_401 != 6)) {
         sbyte var1 = 0;
         if (field_401 == 0 || field_401 == 2 || field_401 == 3 || field_401 == 6) {
            var1 = 4;
         } else if (field_401 == 5) {
            var1 = 2;
         }

         method_104(field_388, var1, -(field_362 * 32 >> 10), -(field_363 * 32 >> 10), 1024, 0);
      } else {
         int var0 = method_106(field_404[field_121 >> 2 & 511] << 6);
         method_105(field_388, field_389, field_390, var0, -(field_362 * 32 >> 10), -(field_363 * 32 >> 10), 1024, 0);
      }
   }

   // $VF: renamed from: aR () void
   private static void method_300() {
      switch (field_278) {
         case 0:
            int var4 = field_342[field_401 * 28 + 5] - field_399;
            if (!field_277 || var4 > 10000 || var4 % 1000 < 750) {
               method_114(method_135(field_399, false), 5, 5, 20);
            }

            method_295(field_283);
            break;
         case 1:
            int var3;
            if ((var3 = field_285 - field_399) < 0) {
               var3 = 0;
            }

            if (var3 > 10000 || var3 % 1000 < 750) {
               method_114(method_135(var3, false), 5, 5, 20);
            }
            break;
         case 2:
            int var2;
            if ((var2 = field_342[field_401 * 28 + 4] - field_399) < 0) {
               var2 = 0;
            }

            if (var2 > 10000 || var2 % 1000 < 750) {
               method_114(method_135(var2, false), 5, 5, 20);
            }

            method_295(field_283);
            break;
         case 3:
            if (field_285 > 0) {
               int var0;
               if ((var0 = field_285 - field_399) < 0) {
                  var0 = 0;
               }

               if (var0 > 10000 || var0 % 1000 < 750) {
                  method_114(method_135(var0, false), 5, 5, 20);
               }
            } else {
               method_114(method_135(field_285, false), 5, 10, 20);
            }
                  break;
}

      for (int var1 = 0; var1 < field_385; var1++) {
         sbyte var10002 = 0;
         if ((field_372 & 1 << var1) != 0) {
            var10002 = 1;
         }

         method_10(192 + (1 - var10002), 5 + var1 * 11, 30, 20, 0);
      }

      method_239(field_240);
      method_226();
   }

   // $VF: renamed from: aS () void
   private static void method_301() {
      if (field_391 > field_121) {
         field_391 = field_121 - 1000;
      }

      if (field_121 - field_391 > 100) {
         method_66();
         field_391 = field_121;
         field_392++;
      }
   }

   // $VF: renamed from: aT () void
   private static void method_302() {
      field_151.setColor(16728334);
      field_151.fillRect(0, 0, ScreenW, ScreenH);
      field_112 = 0;
      field_151.setColor(16777215);
      method_23(1024, field_145[18], ScreenW / 2, ScreenH / 2, 33);
      int var2 = method_24(1024, field_145[18]);
      int var3 = (ScreenW / 2) - var2 / 2;
      int var4;
      if ((var4 = field_392 % (var2 / 4 + 1) * 8) > var2) {
         var4 = var2 * 2 - var4;
      }

      field_151.setColor(0);
      field_151.fillRect(var3 + var4 - 1, 165, 8, 8);
      field_151.setColor(16777215);
      field_151.fillRect(var3 + var4, 166, 6, 6);
   }

   // $VF: renamed from: aU () void
   private static void method_303() {
      field_394 = field_401 / 3;
      field_393 = method_53(1, 12246, 80, null);
      method_7(4 + field_394);
   }

   // $VF: renamed from: aV () void
   private static void method_304() {
      method_28(0, 0, ScreenW, ScreenH);
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
            for (int var10 = 0; var10 < 51 && var1 + var10 < ScreenH; var10++) {
               int var11 = (51 - var10 << 16) / (var10 + 1);
               int var4;
               if ((var4 = 51 - var10 + (field_404[var10 + var11 + (field_121 >> 2) & 511] >> 8)) < 0) {
                  var4 = 0;
               } else if (var4 > 50) {
                  var4 = 50;
               }

               int var5 = field_404[var10 + (var11 >> 4) + (field_121 >> 2) & 511] / (51 - var10 + 1) >> 8;
               method_9(222, var8 + var5, var1 + var10, 20, 200, 1, 0, var4);
            }
         }
      }
   }

   // $VF: renamed from: p (int) int
   private static int method_305(int var0) {
      switch (var0) {
         case 2:
            return 4864053;
         case 3:
         case 7:
         case 8:
            return 16777215;
         case 4:
         case 20:
            return 16777215;
         case 5:
            return 0;
         case 6:
            return 9510656;
         case 9:
         case 10:
         case 11:
         case 12:
         case 13:
         case 14:
         case 15:
         case 16:
         case 17:
         case 18:
         case 19:
         case 25:
         case 26:
         case 27:
         case 28:
         case 29:
         default:
            return 4864053;
         case 21:
            return 16728334;
         case 22:
            return 9510656;
         case 23:
            return 9510656;
         case 24:
            return 7430492;
         case 30:
            return 16728334;
      }
   }

   // $VF: renamed from: q (int) int
   private static int method_306(int var0) {
      switch (var0) {
         case 1:
            return 1024;
         case 2:
            return 0;
         default:
            return 0;
      }
   }

   // $VF: renamed from: r (int) int
   private static int method_307(int var0) {
      if (var0 == 13) {
         return 2162713;
      } else if (var0 == 14) {
         return method_6(0) << 16 | method_5(0);
      } else if (var0 == 15) {
         return method_6(0) << 16 | method_5(0);
      } else if (var0 == 16) {
         return method_6(137) + -24 << 16 | method_5(137) + -24;
      } else if (var0 == 1) {
         return field_308 - field_306 << 16 | field_309 - field_307;
      } else {
         return var0 >= 2 && var0 < 12 ? 1376277 : 0;
      }
   }

   // $VF: renamed from: e (int, int, int) void
   private static void method_308(int var0, int var1, int var2) {
      if (var0 == 13) {
         if (field_289) {
            bool var10002 = true;
            if (field_268 < 2000) {
               var10002 = false;
               if ((field_121 >> 8 & 1) == 0) {
                  var10002 = true;
               }
            }

            method_10(method_150(field_321, field_322, var10002), var1 + 2, var2 + 2, 20, 0);
         }
      } else {
         if (var0 == 16) {
            if (method_319(field_321, field_322)) {
               method_10(137 + (field_121 >> 7) % 3, var1 + 2, var2 + 2, 20, 0);
            } else {
               method_10(140, var1 + 2, var2 + 2, 20, 0);
            }
         }

         if (var0 == 1) {
            int var3 = field_304[field_303 * 3] + 1;
            short var4 = field_304[field_303 * 3 + 1];
            int var5 = field_121 >> 7;
            int var6 = 0;
            if (field_303 == 17) {
               var6 = 0 + (field_404[field_121 << 1 & 511] * 48 >> 15);
            }

            method_105(
               0,
               field_300[var3 + var5 % var4],
               field_300[var3 + (var5 + 1) % var4],
               field_121 << 16 >> 7 & 65535,
               var1 - field_306 + (method_100(0) >> 1),
               var2 - field_307 + (method_101(0) >> 1) + var6,
               3,
               0
            );
         } else {
            if (var0 >= 2 && var0 < 12) {
               method_10(method_218(var0 - 2), var1, var2, 20, 0);
            }
         }
      }
   }

   // $VF: renamed from: aW () void
   private static void method_309() {
      field_395 = new class_4[120];

      for (int var0 = 0; var0 < 120; var0++) {
         field_395[var0] = new class_4();
      }

      sbyte[] var3;
      if ((var3 = method_55("accession")) == null) {
         method_310();
      } else {
         try {
            field_156 = new ByteArrayInputStream(var3);
            field_157 = new DataInputStream(field_156);

            for (int var1 = 0; var1 < 120; var1++) {
               field_395[var1] = new class_4();
               field_395[var1].field_89 = field_157.readUTF();
               field_395[var1].field_91 = field_157.readInt();
               field_395[var1].field_90 = field_157.readInt();
            }

            field_156 = null;
            field_157 = null;
         } catch (Exception var2) {
         }
      }
   }

   // $VF: renamed from: aX () void
   private static void method_310() {
      for (int var0 = 0; var0 < 120; var0++) {
         field_395[var0].field_89 = method_316(var0);
         field_395[var0].field_91 = method_315(var0);
         field_395[var0].field_90 = method_317(var0);
      }
   }

   // $VF: renamed from: aY () void
   private static void method_311() {
      try {
         field_154 = new ByteArrayOutputStream();
         field_155 = new DataOutputStream(field_154);

         for (int var0 = 0; var0 < 120; var0++) {
            field_155.writeUTF(field_395[var0].field_89);
            field_155.writeInt(field_395[var0].field_91);
            field_155.writeInt(field_395[var0].field_90);
         }

         sbyte[] var2 = field_154.toByteArray();
         field_154 = null;
         field_155 = null;
         method_56("accession", var2);
      } catch (Exception var1) {
      }
   }

   // $VF: renamed from: i (int, int) int
   private static int method_312(int var0, int var1) {
      int var2 = (field_401 * 5 + field_402) * 2;
      sbyte var10000 = 0;
      if (field_395[var2].field_90 < var0) {
         var10000 = 1;
      }

      sbyte var3 = var10000;
      bool var5 = false;
      if (field_395[var2 + 1].field_90 < -var1) {
         var5 = true;
      }

      bool var4 = var5;
      return var3 + (var4 ? 2 : 0);
   }

   // $VF: renamed from: a (int, int, java.lang.string, int) void
   private static void method_313(int var0, int var1, string var2, int var3) {
      int var4 = (field_401 * 5 + field_402) * 2;
      if (field_395[var4].field_90 < var0) {
         field_395[var4].field_89 = var2;
         field_395[var4].field_90 = var0;
         field_395[var4].field_91 = var3;
      }

      if (field_395[++var4].field_90 < -var1) {
         field_395[var4].field_89 = var2;
         field_395[var4].field_90 = -var1;
         field_395[var4].field_91 = var3;
      }

      method_311();
   }

   // $VF: renamed from: a (int, int) java.lang.string
   private static string method_314(int var0, int var1) {
      int var2 = var0 * 5 + var1;
      string var3 = field_145[131];
      var2 *= 2;
      string var4 = field_395[var2].field_89;
      int var5 = field_395[var2].field_90;
      int var6 = field_395[var2].field_91;
      string var7 = field_395[++var2].field_89;
      int var8 = -field_395[var2].field_90;
      int var9 = field_395[var2].field_91;
      var3 = method_60(method_60(var3, "" + var5, 1), var4, 2);
      if (var8 != 0) {
         var3 = method_60(method_60(method_60(method_60(var3, method_135(var8, false), 3), var7, 4), field_145[125], 5), "\u0019" + (2 + var9) + ':', 7);
         if (var9 < 2) {
            var3 = method_60(var3, "30:", 9);
         } else {
            var3 = method_60(var3, "3:", 9);
         }
      } else {
         var3 = method_60(method_60(method_60(method_60(method_60(var3, "", 3), "", 4), "", 5), "", 7), "", 9);
      }

      if (var6 < 2) {
         var3 = method_60(var3, "30:", 8);
      } else {
         var3 = method_60(var3, "3:", 8);
      }

      return method_60(var3, "\u0019" + (2 + var6) + ':', 6);
   }

   // $VF: renamed from: s (int) int
   private static int method_315(int var0) {
      return field_342[var0 / 2 / 5 * 28 + 12];
   }

   // $VF: renamed from: c (int) java.lang.string
   private static string method_316(int var0) {
      if ((var0 = var0 / 5) <= 3) {
         return field_145[71];
      } else if (var0 <= 5) {
         return field_145[72];
      } else if (var0 <= 9) {
         return field_145[73];
      } else if (var0 <= 11) {
         return field_145[74];
      } else if (var0 <= 15) {
         return field_145[75];
      } else if (var0 <= 17) {
         return field_145[76];
      } else {
         return var0 <= 21 ? field_145[77] : field_145[78];
      }
   }

   // $VF: renamed from: t (int) int
   private static int method_317(int var0) {
      bool var10000 = false;
      if ((var0 & 1) == 0) {
         var10000 = true;
      }

      bool var1 = var10000;
      var0 /= 2;
      return var1 ? field_342[var0 / 5 * 28 + 13 + var0 % 5 * 3 + 2] : -field_342[var0 / 5 * 28 + 13 + var0 % 5 * 3 + 1];
   }

   // $VF: renamed from: m (int, int) void
   private static void method_318(int var0, int var1) {
      sbyte var2;
      sbyte var3 = (sbyte)((var2 = field_133[7 + var0]) | 1 << var1);
      field_133[7 + var0] = var3;
      method_38();
      int var4 = method_110(var2);
      int var5 = method_110(var3);
      field_340 = false;
      if (var4 != var5) {
         field_340 = true;
         field_279 = method_322(method_321());
      }
   }

   // $VF: renamed from: e (int, int) bool
   private static bool method_319(int var0, int var1) {
      bool var10000 = false;
      if ((field_133[7 + var0] & 1 << var1) != 0) {
         var10000 = true;
      }

      return var10000;
   }

   // $VF: renamed from: j (int) bool
   private static bool method_320(int var0) {
      for (int var1 = 0; var1 < field_342[var0 * 28 + 2]; var1++) {
         if (!method_319(var0, var1)) {
            return false;
         }
      }

      return true;
   }

   // $VF: renamed from: j () int
   private static int method_321() {
      int var0 = 0;

      for (int var1 = 0; var1 < 12; var1++) {
         var0 += method_110(field_133[7 + var1]);
      }

      return var0;
   }

   // $VF: renamed from: u (int) int
   private static int method_322(int var0) {
      for (int var1 = 0; var1 < 12; var1++) {
         if (field_342[var1 * 28 + 8] == var0) {
            return var1;
         }
      }

      return -1;
   }

   // $VF: renamed from: k (int) bool
   private static bool method_323(int var0) {
      return method_321() >= field_342[var0 * 28 + 8];
   }

   // $VF: renamed from: aZ () void
   private static void method_324() {
      field_396 = new short[12][];
      field_397 = new short[12][];

      for (int var0 = 0; var0 < 12; var0++) {
         field_396[var0] = method_54(
            field_136[67 + field_342[var0 * 28 + 1] * 3],
            field_136[67 + field_342[var0 * 28 + 1] * 3 + 1],
            field_136[67 + field_342[var0 * 28 + 1] * 3 + 2],
            null
         );
         field_397[var0] = new short[field_396[var0][0] * field_396[var0][1]];
      }
   }

   // $VF: renamed from: ba () void
   private static void method_325() {
      field_240 = 0;
      field_339 = 0;
      field_302 = false;
      field_404 = method_108(10, true);
      field_267 = -1;
      field_281 = null;
      field_282 = null;
      field_280 = null;
      field_345 = null;
      method_117();
      method_131();
      method_123();
   }

   // $VF: renamed from: bb () void
   private static void method_326() {
      method_59(3);
      method_7(3);
      method_15(2);
      method_16(3);
      method_132();
      method_99(1, 1500);
      method_7(8);
      method_324();
      method_290(field_401, field_278);
      method_303();
      method_298(field_401);
      method_274();
      method_276();
      method_240();
      method_227();
      method_222();
      field_373 = -1;
      field_372 = -1;
      method_225();
      method_281(field_347[field_240].field_40 - (ScreenW * 16), field_347[field_240].field_41 - (ScreenH * 16));
      if (field_336 > 1) {
         field_135[532] = 0;
      } else {
         field_135[532] = 2;
      }

      if (field_293) {
         field_135[568] = 2;
         field_135[532] = 0;
         field_135[556] = 2;
      } else {
         field_135[568] = 0;
         field_135[556] = 0;
      }

      method_154();
      field_398 = 0;
      field_399 = 0;
      method_124();
      method_292();
      method_128();
      field_405 = false;
      field_341 = true;
      method_174(field_278, field_403);
      if (field_278 == 0 && field_403 <= 1) {
         method_162();
      }
   }

   // $VF: renamed from: bc () void
   private static void method_327() {
      method_16(2);
      method_134();
      method_15(3);
      method_291();
      method_190();
      field_233[1] = null;
   }

   // $VF: renamed from: bd () void
   private static void method_328() {
      field_405 = true;
      field_332 = field_293 ^ true;
   }

   // $VF: renamed from: Q (int) void
   private static void method_329(int var0) {
      if (method_63(var0, 131094)) {
         method_70();
      }
   }

   // $VF: renamed from: R (int) void
   private static void method_330(int var0) {
      if (field_276 == 11) {
         if (method_63(var0, 262152) || method_63(var0, 131094)) {
            method_20();
            method_328();
            return;
         }

         if (field_292 >= 6) {
            bool var1 = method_63(var0, 131072);
            bool var2 = method_63(var0, 131074);
            if (var1) {
               method_95(4);
            }

            if (var2) {
               method_95(2);
            }
         }
         return;
      }

      bool var10000 = false;
      if (field_267 != -1 && field_122 >= field_267) {
         var10000 = true;
      }

      bool var3 = var10000;
      if (field_267 == -1 || field_122 < field_267 || method_171(var0)) {
         if (method_176(var0) && !var3) {
            method_329(var0);
         }
      }
   }

   // $VF: renamed from: d () bool
   private static bool method_331() {
      if (field_405) {
         return false;
      } else {
         field_400 = DeterministicDeltaMs;

         if (field_276 == 5) {
            if (field_267 != -1 && field_122 >= field_267) {
               method_288(field_400 << 10, false);
               if (field_270) {
                  method_191(field_400 << 10);
               }
            } else {
               field_398 = field_398 + field_400;
            }

            int var0 = field_398;
            int var1 = field_360;

            for (int var2 = 0; var2 <= field_240; var2++) {
               field_398 = var0;
               field_360 = var1;

               for (field_239 = var2; field_398 >= 30 && (var2 >= field_240 || field_278 != 0 || field_403 > 1 || field_399 >= field_266); field_398 -= 30) {
                  if (var2 != field_240) {
                     field_360 = method_164(var2);
                     if (field_360 == -1 && field_358[field_239] != 5) {
                        method_278(5);
                        method_246(
                           field_347[field_239],
                           field_357[field_358[field_239] * 14 + 2],
                           field_357[field_358[field_239] * 14 + 3],
                           field_357[field_358[field_239] * 14 + 4],
                           field_357[field_358[field_239] * 14 + 5],
                           method_277(field_358[field_239])
                        );
                     }
                  } else {
                     method_163((sbyte)field_360);
                     field_399 += 30;
                  }

                  method_243(30);
                  if (var2 == field_240 && method_289()) {
                     field_398 = 0;
                     break;
                  }

                  method_191(30720);
                  if (var2 == field_240) {
                     method_238();
                  }

                  method_126(30);
                  field_360 = 0;
                  if (var2 == field_240 && field_276 <= 5) {
                     method_280(field_347[field_240]);
                     method_288(30720, true);
                  }
               }
            }
         } else if (field_276 == 11) {
            field_399 = field_399 + field_400;
            int var4 = field_122 - field_291;
            int var6 = field_393[field_394 * 5 + 2];
            if (field_122 - field_297 < 512) {
               field_295 = method_112(field_296, var6, field_122 - field_297 >> 1);
            } else {
               field_295 = var6;
            }

            {
               switch (field_292) {
                  case 0:
                     if (var4 < 2000) {
                        goto label167_end;
                     }

                     field_292 = 1;
                     goto case 1;
                  case 1:
                     if (var4 < 4000) {
                        goto label167_end;
                     }

                     field_292 = 2;
                     goto case 2;
                  case 2:
                     if (var4 < 6000) {
                        for (int var9 = 0; var9 < 40; var9++) {
                           if (field_242[var9] == 2 && field_246[var9] == 0 && var4 - 4000 > (method_109(var9 * var9 * 8837 + 927) & 1023)) {
                              field_246[var9] = 1;
                              field_245[var9] = 0;
                           }
                        }

                        method_126(field_400);
                        goto label167_end;
                     }

                     field_292 = 3;

                     for (int var7 = 0; var7 < 4; var7++) {
                        method_129();
                     }
                     goto case 3;
                  case 3:
                     if (var4 < 9000) {
                        method_126(field_400);
                        method_281(53248 - (ScreenW * 16), method_287(-2048, -10240, var4 - 6000, 3000));
                        goto label167_end;
                     }

                     field_292 = 4;
                     method_281(53248 - (ScreenW * 16), -10240);
                                    break;
}

               var4 -= 9000;
               if (var4 / 5000 > field_292 - 4) {
                  field_292++;
                  int var8 = 4 + method_107() % 4;

                  for (int var3 = 0; var3 < var8; var3++) {
                     method_129();
                  }
               }

               method_126(field_400);
            }
label167_end: ;

            method_191(field_400 << 10);
         } else if (field_276 < 5 || field_276 > 5) {
            method_288(field_400 << 10, false);
            if (field_270) {
               method_191(field_400 << 10);
            }
         }

         field_162 = true;
         return true;
      }
   }

   // $VF: renamed from: be () void
   private static void method_332() {
      method_304();
      method_299();
      method_296();
      method_127(0);
      method_193();

      for (int var0 = 0; var0 <= field_240; var0++) {
         field_239 = var0;
         method_192();
      }

      if (field_267 != -1 && field_122 >= field_267) {
         method_172();
      } else if (field_276 != 11) {
         method_300();
         method_127(131072);
      } else {
         field_151.setColor(16777215);
         field_112 = 0;
         if (field_292 >= 5) {
            method_23(1024, field_145[157], ScreenW / 2, MenuOffsetY + 34, 33);
         }

         if (field_292 >= 6) {
            method_93(field_221, field_218, field_219, field_222);
            bool var10000 = false;
            if (field_222 > 0) {
               var10000 = true;
            }

            bool var10001 = false;
            if (field_222 < field_198 - 1) {
               var10001 = true;
            }

            method_84(var10000, var10001);
         }

         method_86(24, -1);
      }
   }

   // $VF: renamed from: bf () void
   private static void method_333() {
      field_398 = 0;
      field_399 = 0;
      method_241();
      method_190();
      method_228();
      method_275();
      field_373 = -1;
      field_372 = -1;
      method_281(field_347[field_240].field_40 - (ScreenW * 16), field_347[field_240].field_41 - (ScreenH * 16));
      method_124();
      method_174(field_278, field_403);
      field_389 = 0;
      field_390 = 1;
      method_155();
      if (field_278 == 0 && field_403 <= 1) {
         method_162();
      }
   }


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

   public class_5() : base(false) {
   }

   public class_5(class_6 var1) : base(false) {
      field_163 = var1;
      field_165 = this;
      this.setFullScreenMode(true);
      field_164 = new JavaThread(this);
   }
}
