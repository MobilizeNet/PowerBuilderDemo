namespace notifycurrentcontrol
{

   public interface Iw_window
      : Mobilize.Web.IWindow
   {

      void Create();

      void Destroy();

      int? OpenWindow();

      void DoWmInit();

      Iw_windowInner.Ist_1_type st_1 { get; set; }

      Iw_windowInner.Idw_1_type dw_1 { get; set; }

   }

   namespace Iw_windowInner
   {

      public interface Ist_1_type
         : Mobilize.Web.IStaticText
      {

         void DoWmInit();

      }

      public interface Idw_1_type
         : Mobilize.Web.IDataManagerControl
      {

         short? ItemChanged(int? row, Mobilize.Web.IDmControl dwo, string data);

         short? ItemFocusChanged(int? row, Mobilize.Web.IDmControl dwo);

         short? EditChanged(int? row, Mobilize.Web.IDmControl dwo, string data);

         void DoWmInit();

      }

   }
}