namespace pbj_webmapdemo
{

   public interface Iw_muti_line_edit
      : Mobilize.Web.IWindow
   {

      void Create();

      void Destroy();

      Iw_muti_line_editInner.Icb_4_type cb_4 { get; set; }

      Iw_muti_line_editInner.Icb_5_type cb_5 { get; set; }

      Iw_muti_line_editInner.Icb_6_type cb_6 { get; set; }

      Iw_muti_line_editInner.Icb_3_type cb_3 { get; set; }

      Iw_muti_line_editInner.Icb_1_type cb_1 { get; set; }

      Iw_muti_line_editInner.Icb_7_type cb_7 { get; set; }

      Iw_muti_line_editInner.Imle_1_type mle_1 { get; set; }

   }

   namespace Iw_muti_line_editInner
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

      public interface Icb_7_type
         : Mobilize.Web.ICommandButton
      {

         int? Clicked();

         void DoWmInit();

      }

      public interface Imle_1_type
         : Mobilize.Web.IMultiLineEdit
      {

         int? modified();

         void DoWmInit();

      }

   }
}