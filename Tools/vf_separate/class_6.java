import javax.microedition.lcdui.Display;
import javax.microedition.midlet.MIDlet;

// $VF: renamed from: S
public final class class_6 extends MIDlet {
   // $VF: renamed from: a c
   public static class_5 field_406;
   // $VF: renamed from: a javax.microedition.lcdui.Display
   public static Display field_407;

   public final void startApp() {
      field_407.setCurrent(field_406);
      class_5.field_161 = false;
   }

   public final void pauseApp() {
      if (field_406 != null) {
         field_406.hideNotify();
      }

      this.notifyPaused();
      class_5.field_161 = true;
   }

   public final void destroyApp(boolean var1) {
      if (field_406 != null) {
         class_5.method_68();
      }

      field_406 = null;
      if (field_407 != null) {
         field_407.setCurrent(null);
      }

      field_407 = null;
      this.notifyDestroyed();
   }

   // $VF: renamed from: a () void
   public final void method_334() {
      this.destroyApp(false);
   }

   public class_6() {
      field_407 = Display.getDisplay(this);

      try {
         field_406 = new class_5(this);
         class_5.field_164.start();
      } catch (Exception var2) {
         var2.printStackTrace();
      }
   }
}
