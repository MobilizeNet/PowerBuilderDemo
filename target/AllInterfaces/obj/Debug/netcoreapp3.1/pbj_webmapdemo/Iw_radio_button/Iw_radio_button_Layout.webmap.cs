#pragma warning disable
#line 1 "pbj_webmapdemo\\Iw_radio_button\\Iw_radio_button_Layout.cs"
#pragma warning disable
#line 1 "pbj_webmapdemo\\Iw_radio_button\\Iw_radio_button_Layout.cs"
namespace pbj_webmapdemo
{

   public interface Iw_radio_button
      : Mobilize.Web.IWindow
   {

      void Create();

      void Destroy();

      Iw_radio_buttonInner.Irb_5_type rb_5 { get; set; }

      Iw_radio_buttonInner.Irb_4_type rb_4 { get; set; }

      Iw_radio_buttonInner.Icb_4_type cb_4 { get; set; }

      Iw_radio_buttonInner.Icb_5_type cb_5 { get; set; }

      Iw_radio_buttonInner.Icb_6_type cb_6 { get; set; }

      Iw_radio_buttonInner.Icb_3_type cb_3 { get; set; }

      Iw_radio_buttonInner.Icb_1_type cb_1 { get; set; }

      Iw_radio_buttonInner.Icb_7_type cb_7 { get; set; }

      Iw_radio_buttonInner.Irb_3_type rb_3 { get; set; }

      Iw_radio_buttonInner.Irb_2_type rb_2 { get; set; }

      Iw_radio_buttonInner.Irb_1_type rb_1 { get; set; }

      Iw_radio_buttonInner.Igb_1_type gb_1 { get; set; }

   }

   namespace Iw_radio_buttonInner
   {

      public interface Irb_5_type
         : Mobilize.Web.IRadioButton
      {

         void DoWmInit();

      }

      public interface Irb_4_type
         : Mobilize.Web.IRadioButton
      {

         void DoWmInit();

      }

      public interface Icb_4_type
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

      public interface Icb_6_type
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

      public interface Icb_1_type
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

      public interface Irb_3_type
         : Mobilize.Web.IRadioButton
      {

         void DoWmInit();

      }

      public interface Irb_2_type
         : Mobilize.Web.IRadioButton
      {

         void DoWmInit();

      }

      public interface Irb_1_type
         : Mobilize.Web.IRadioButton
      {

         int? Clicked();

         void DoWmInit();

      }

      public interface Igb_1_type
         : Mobilize.Web.IGroupBox
      {

         void DoWmInit();

      }

   }
}
#pragma warning restore
