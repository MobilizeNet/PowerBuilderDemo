#pragma warning disable
#line 1 "pbj_webmapdemo\\Iw_dw_dropdowndatawindow\\Iw_dw_dropdowndatawindow_Layout.cs"
#pragma warning disable
#line 1 "pbj_webmapdemo\\Iw_dw_dropdowndatawindow\\Iw_dw_dropdowndatawindow_Layout.cs"
namespace pbj_webmapdemo
{

   public interface Iw_dw_dropdowndatawindow
      : Mobilize.Web.IWindow
   {

      void Create();

      void Destroy();

      int? OpenWindow();

      void DoWmInit();

      Iw_dw_dropdowndatawindowInner.Idw_1_type dw_1 { get; set; }

   }

   namespace Iw_dw_dropdowndatawindowInner
   {

      public interface Idw_1_type
         : Mobilize.Web.IDataManagerControl
      {

         void DoWmInit();

      }

   }
}
#pragma warning restore
