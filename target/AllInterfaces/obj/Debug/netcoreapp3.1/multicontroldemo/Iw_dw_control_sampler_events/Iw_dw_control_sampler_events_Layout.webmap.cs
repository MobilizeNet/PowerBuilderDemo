#pragma warning disable
#line 1 "multicontroldemo\\Iw_dw_control_sampler_events\\Iw_dw_control_sampler_events_Layout.cs"
#pragma warning disable
#line 1 "multicontroldemo\\Iw_dw_control_sampler_events\\Iw_dw_control_sampler_events_Layout.cs"
namespace multicontroldemo
{

   public interface Iw_dw_control_sampler_events
      : Mobilize.Web.IWindow
   {

      void Create();

      void Destroy();

      short? log(string message_txt);

      string getcurrentcolumnvalue();

      int? OpenWindow();

      void DoWmInit();

      Iw_dw_control_sampler_eventsInner.Icb_3_type cb_3 { get; set; }

      Iw_dw_control_sampler_eventsInner.Icb_2_type cb_2 { get; set; }

      Iw_dw_control_sampler_eventsInner.Icb_1_type cb_1 { get; set; }

      Iw_dw_control_sampler_eventsInner.Imle_log_type mle_log { get; set; }

      Iw_dw_control_sampler_eventsInner.Idw_1_type dw_1 { get; set; }

   }

   namespace Iw_dw_control_sampler_eventsInner
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

      public interface Imle_log_type
         : Mobilize.Web.IMultiLineEdit
      {

         void DoWmInit();

      }

      public interface Idw_1_type
         : Mobilize.Web.IDataManagerControl
      {

         short? ItemChanged(int? row, Mobilize.Web.IDmControl dwo, string data);

         short? ItemFocusChanged(int? row, Mobilize.Web.IDmControl dwo);

         short? RowFocusChanged(int? currentrow);

         short? RowFocusChanging(int? currentrow, int? newrow);

         void DoWmInit();

      }

   }
}
#pragma warning restore
