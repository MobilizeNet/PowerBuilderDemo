namespace basecomponents
{

   public interface Iw_basewindow
      : Mobilize.Web.IWindow
   {

      void Create();

      void Destroy();

      int? OpenWindow();

      void DoWmInit();

      void ev_loadcontent();

      Mobilize.Web.VoidEventHandler ev_loadcontentEventHandler { get; set; }

   }

}