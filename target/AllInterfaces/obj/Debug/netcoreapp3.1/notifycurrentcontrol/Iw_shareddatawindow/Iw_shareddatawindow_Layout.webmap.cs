#pragma warning disable
#line 1 "notifycurrentcontrol\\Iw_shareddatawindow\\Iw_shareddatawindow_Layout.cs"
#pragma warning disable
#line 1 "notifycurrentcontrol\\Iw_shareddatawindow\\Iw_shareddatawindow_Layout.cs"
namespace notifycurrentcontrol
{

   public interface Iw_shareddatawindow
      : Mobilize.Web.IWindow
   {

      void Create();

      void Destroy();

      void getvalues(short? row, string column);

      int? OpenWindow();

      void DoWmInit();

      Iw_shareddatawindowInner.Ist_3_type st_3 { get; set; }

      Iw_shareddatawindowInner.Ist_2_type st_2 { get; set; }

      Iw_shareddatawindowInner.Ist_1_type st_1 { get; set; }

      Iw_shareddatawindowInner.Icb_2_type cb_2 { get; set; }

      Iw_shareddatawindowInner.Icb_1_type cb_1 { get; set; }

      Iw_shareddatawindowInner.Idw_3_type dw_3 { get; set; }

      Iw_shareddatawindowInner.Idw_2_type dw_2 { get; set; }

      Iw_shareddatawindowInner.Idw_1_type dw_1 { get; set; }

   }

   namespace Iw_shareddatawindowInner
   {

      public interface Ist_3_type
         : Mobilize.Web.IStaticText
      {

         void DoWmInit();

      }

      public interface Ist_2_type
         : Mobilize.Web.IStaticText
      {

         void DoWmInit();

      }

      public interface Ist_1_type
         : Mobilize.Web.IStaticText
      {

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

      public interface Idw_3_type
         : Mobilize.Web.IDataManagerControl
      {

         short? ItemChanged(int? row, Mobilize.Web.IDmControl dwo, string data);

         void DoWmInit();

      }

      public interface Idw_2_type
         : Mobilize.Web.IDataManagerControl
      {

         short? ItemChanged(int? row, Mobilize.Web.IDmControl dwo, string data);

         void DoWmInit();

      }

      public interface Idw_1_type
         : Mobilize.Web.IDataManagerControl
      {

         short? ItemChanged(int? row, Mobilize.Web.IDmControl dwo, string data);

         void DoWmInit();

      }

   }
}
#pragma warning restore
