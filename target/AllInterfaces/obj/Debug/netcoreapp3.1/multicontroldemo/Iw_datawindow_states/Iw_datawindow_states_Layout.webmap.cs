#pragma warning disable
#line 1 "multicontroldemo\\Iw_datawindow_states\\Iw_datawindow_states_Layout.cs"
#pragma warning disable
#line 1 "multicontroldemo\\Iw_datawindow_states\\Iw_datawindow_states_Layout.cs"
namespace multicontroldemo
{

   public interface Iw_datawindow_states
      : Mobilize.Web.IWindow
   {

      void Create();

      void Destroy();

      void log(string _text);

      string textornull(string _text);

      Iw_datawindow_statesInner.Icb_9_type cb_9 { get; set; }

      Iw_datawindow_statesInner.Icb_8_type cb_8 { get; set; }

      Iw_datawindow_statesInner.Icb_7_type cb_7 { get; set; }

      Iw_datawindow_statesInner.Icb_6_type cb_6 { get; set; }

      Iw_datawindow_statesInner.Icb_5_type cb_5 { get; set; }

      Iw_datawindow_statesInner.Icb_4_type cb_4 { get; set; }

      Iw_datawindow_statesInner.Icb_3_type cb_3 { get; set; }

      Iw_datawindow_statesInner.Imle_1_type mle_1 { get; set; }

      Iw_datawindow_statesInner.Icb_2_type cb_2 { get; set; }

      Iw_datawindow_statesInner.Icb_1_type cb_1 { get; set; }

      Iw_datawindow_statesInner.Idw_1_type dw_1 { get; set; }

   }

   namespace Iw_datawindow_statesInner
   {

      public interface Icb_9_type
         : Mobilize.Web.ICommandButton
      {

         int? Clicked();

         void DoWmInit();

      }

      public interface Icb_8_type
         : Mobilize.Web.ICommandButton
      {

         int? Clicked();

         void DoWmInit();

      }

      public interface Icb_7_type
         : Mobilize.Web.ICommandButton
      {

         int? Clicked();

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

      public interface Icb_3_type
         : Mobilize.Web.ICommandButton
      {

         int? Clicked();

         void DoWmInit();

      }

      public interface Imle_1_type
         : Mobilize.Web.IMultiLineEdit
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

      public interface Idw_1_type
         : Mobilize.Web.IDataManagerControl
      {

         void DoWmInit();

      }

   }
}
#pragma warning restore
