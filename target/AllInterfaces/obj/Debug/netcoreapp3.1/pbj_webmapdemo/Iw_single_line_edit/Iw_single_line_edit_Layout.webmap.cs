#pragma warning disable
#line 1 "pbj_webmapdemo\\Iw_single_line_edit\\Iw_single_line_edit_Layout.cs"
#pragma warning disable
#line 1 "pbj_webmapdemo\\Iw_single_line_edit\\Iw_single_line_edit_Layout.cs"
namespace pbj_webmapdemo
{

   public interface Iw_single_line_edit
      : Mobilize.Web.IWindow
   {

      void Create();

      void Destroy();

      Iw_single_line_editInner.Icb_4_type cb_4 { get; set; }

      Iw_single_line_editInner.Icb_5_type cb_5 { get; set; }

      Iw_single_line_editInner.Icb_6_type cb_6 { get; set; }

      Iw_single_line_editInner.Icb_3_type cb_3 { get; set; }

      Iw_single_line_editInner.Icb_1_type cb_1 { get; set; }

      Iw_single_line_editInner.Isle_1_type sle_1 { get; set; }

   }

   namespace Iw_single_line_editInner
   {

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

         int? Clicked();

         void DoWmInit();

      }

      public interface Icb_1_type
         : Mobilize.Web.ICommandButton
      {

         int? Clicked();

         void DoWmInit();

      }

      public interface Isle_1_type
         : Mobilize.Web.ISingleLineEdit
      {

         int? Modified();

         void DoWmInit();

      }

   }
}
#pragma warning restore
