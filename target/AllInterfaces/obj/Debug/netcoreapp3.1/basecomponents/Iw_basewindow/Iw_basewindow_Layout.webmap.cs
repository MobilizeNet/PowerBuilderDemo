#pragma warning disable
#line 1 "basecomponents\\Iw_basewindow\\Iw_basewindow_Layout.cs"
#pragma warning disable
#line 1 "basecomponents\\Iw_basewindow\\Iw_basewindow_Layout.cs"
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
#pragma warning restore
