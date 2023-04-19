namespace reports
{

   public interface Iw_main_report
      : Mobilize.Web.IWindow
   {

      void Create();

      void Destroy();

      int? OpenWindow();

      void DoWmInit();

      Iw_main_reportInner.Icb_3_type cb_3 { get; set; }

      Iw_main_reportInner.Icb_2_type cb_2 { get; set; }

      Iw_main_reportInner.Icb_1_type cb_1 { get; set; }

      Iw_main_reportInner.Idw_1_type dw_1 { get; set; }

   }

   namespace Iw_main_reportInner
   {

      public interface Icb_3_type
         : Mobilize.Web.ICommandButton
      {

         int? Clicked();

         void DoWmInit();

      }

      public interface Icb_2_type
         : Mobilize.Web.ICommandButton
      {

         int? Clicked();

         void DoWmInit();

      }

      public interface Icb_1_type
         : Mobilize.Web.ICommandButton
      {

         int? Clicked();

         void DoWmInit();

      }

      public interface Idw_1_type
         : Mobilize.Web.IDataManagerControl
      {

         void DoWmInit();

      }

   }
}