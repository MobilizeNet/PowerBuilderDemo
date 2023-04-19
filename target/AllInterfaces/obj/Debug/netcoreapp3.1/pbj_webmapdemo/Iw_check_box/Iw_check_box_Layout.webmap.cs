#pragma warning disable
#line 1 "pbj_webmapdemo\\Iw_check_box\\Iw_check_box_Layout.cs"
#pragma warning disable
#line 1 "pbj_webmapdemo\\Iw_check_box\\Iw_check_box_Layout.cs"
namespace pbj_webmapdemo
{

   public interface Iw_check_box
      : Mobilize.Web.IWindow
   {

      void Create();

      void Destroy();

      int? OpenWindow();

      void DoWmInit();

      Iw_check_boxInner.Icb_7_type cb_7 { get; set; }

      Iw_check_boxInner.Icb_1_type cb_1 { get; set; }

      Iw_check_boxInner.Icb_3_type cb_3 { get; set; }

      Iw_check_boxInner.Icb_6_type cb_6 { get; set; }

      Iw_check_boxInner.Icb_5_type cb_5 { get; set; }

      Iw_check_boxInner.Icb_4_type cb_4 { get; set; }

      Iw_check_boxInner.Icbx_2_type cbx_2 { get; set; }

      Iw_check_boxInner.Icbx_1_type cbx_1 { get; set; }

   }

   namespace Iw_check_boxInner
   {

      public interface Icb_7_type
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

      public interface Icbx_2_type
         : Mobilize.Web.ICheckBox
      {

         void DoWmInit();

      }

      public interface Icbx_1_type
         : Mobilize.Web.ICheckBox
      {

         int? Clicked();

         void DoWmInit();

      }

   }
}
#pragma warning restore
