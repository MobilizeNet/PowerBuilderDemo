namespace pbj_webmapdemo
{

   public interface Iw_picture_button
      : Mobilize.Web.IWindow
   {

      void Create();

      void Destroy();

      Iw_picture_buttonInner.Icb_1_type cb_1 { get; set; }

      Iw_picture_buttonInner.Icb_3_type cb_3 { get; set; }

      Iw_picture_buttonInner.Icb_6_type cb_6 { get; set; }

      Iw_picture_buttonInner.Icb_5_type cb_5 { get; set; }

      Iw_picture_buttonInner.Icb_4_type cb_4 { get; set; }

      Iw_picture_buttonInner.Ipb_1_type pb_1 { get; set; }

   }

   namespace Iw_picture_buttonInner
   {

      public interface Icb_1_type
         : Mobilize.Web.ICommandButton
      {

         int? Clicked();

         void DoWmInit();

      }

      public interface Icb_3_type
         : Mobilize.Web.ICommandButton
      {

         void DoWmInit();

      }

      public interface Icb_6_type
         : Mobilize.Web.ICommandButton
      {

         int? Clicked();

         void DoWmInit();

      }

      public interface Icb_5_type
         : Mobilize.Web.ICommandButton
      {

         int? Clicked();

         void DoWmInit();

      }

      public interface Icb_4_type
         : Mobilize.Web.ICommandButton
      {

         int? Clicked();

         void DoWmInit();

      }

      public interface Ipb_1_type
         : Mobilize.Web.IPictureButton
      {

         int? Clicked();

         void DoWmInit();

      }

   }
}