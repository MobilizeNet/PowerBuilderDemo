#pragma warning disable
#line 1 "pbj_webmapdemo\\Iw_edit_mask\\Iw_edit_mask_Layout.cs"
#pragma warning disable
#line 1 "pbj_webmapdemo\\Iw_edit_mask\\Iw_edit_mask_Layout.cs"
namespace pbj_webmapdemo
{

   public interface Iw_edit_mask
      : Mobilize.Web.IWindow
   {

      void Create();

      void Destroy();

      Iw_edit_maskInner.Icb_time_type cb_time { get; set; }

      Iw_edit_maskInner.Icb_number_type cb_number { get; set; }

      Iw_edit_maskInner.Icb_7_type cb_7 { get; set; }

      Iw_edit_maskInner.Icb_8_type cb_8 { get; set; }

      Iw_edit_maskInner.Icb_9_type cb_9 { get; set; }

      Iw_edit_maskInner.Icb_1_type cb_1 { get; set; }

      Iw_edit_maskInner.Icb_3_type cb_3 { get; set; }

      Iw_edit_maskInner.Icb_6_type cb_6 { get; set; }

      Iw_edit_maskInner.Icb_5_type cb_5 { get; set; }

      Iw_edit_maskInner.Icb_4_type cb_4 { get; set; }

      Iw_edit_maskInner.Iem_1_type em_1 { get; set; }

   }

   namespace Iw_edit_maskInner
   {

      public interface Icb_time_type
         : Mobilize.Web.ICommandButton
      {

         int? Clicked();

         void DoWmInit();

      }

      public interface Icb_number_type
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

      public interface Icb_8_type
         : Mobilize.Web.ICommandButton
      {

         int? Clicked();

         void DoWmInit();

      }

      public interface Icb_9_type
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

      public interface Icb_3_type
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

      public interface Iem_1_type
         : Mobilize.Web.IEditMask
      {

         int? Modified();

         void DoWmInit();

      }

   }
}
#pragma warning restore
