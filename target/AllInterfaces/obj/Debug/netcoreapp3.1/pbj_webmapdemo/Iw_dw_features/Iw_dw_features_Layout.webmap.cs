#pragma warning disable
#line 1 "pbj_webmapdemo\\Iw_dw_features\\Iw_dw_features_Layout.cs"
#pragma warning disable
#line 1 "pbj_webmapdemo\\Iw_dw_features\\Iw_dw_features_Layout.cs"
namespace pbj_webmapdemo
{

   public interface Iw_dw_features
      : Mobilize.Web.IWindow
   {

      void Create();

      void Destroy();

      int? OpenWindow();

      void DoWmInit();

      Iw_dw_featuresInner.Irb_freeform_type rb_freeform { get; set; }

      Iw_dw_featuresInner.Irb_grid_type rb_grid { get; set; }

      Iw_dw_featuresInner.Irb_4_type rb_4 { get; set; }

      Iw_dw_featuresInner.Irb_3_type rb_3 { get; set; }

      Iw_dw_featuresInner.Irb_2_type rb_2 { get; set; }

      Iw_dw_featuresInner.Irb_1_type rb_1 { get; set; }

      Iw_dw_featuresInner.Ist_4_type st_4 { get; set; }

      Iw_dw_featuresInner.Isle_1_type sle_1 { get; set; }

      Iw_dw_featuresInner.Icb_6_type cb_6 { get; set; }

      Iw_dw_featuresInner.Icb_5_type cb_5 { get; set; }

      Iw_dw_featuresInner.Icb_4_type cb_4 { get; set; }

      Iw_dw_featuresInner.Icb_3_type cb_3 { get; set; }

      Iw_dw_featuresInner.Icb_2_type cb_2 { get; set; }

      Iw_dw_featuresInner.Icb_1_type cb_1 { get; set; }

      Iw_dw_featuresInner.Idw_1_type dw_1 { get; set; }

      Iw_dw_featuresInner.Igb_1_type gb_1 { get; set; }

      Iw_dw_featuresInner.Igb_2_type gb_2 { get; set; }

      Iw_dw_featuresInner.Igb_3_type gb_3 { get; set; }

   }

   namespace Iw_dw_featuresInner
   {

      public interface Irb_freeform_type
         : Mobilize.Web.IRadioButton
      {

         int? Clicked();

         void DoWmInit();

      }

      public interface Irb_grid_type
         : Mobilize.Web.IRadioButton
      {

         int? Clicked();

         void DoWmInit();

      }

      public interface Irb_4_type
         : Mobilize.Web.IRadioButton
      {

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

         void DoWmInit();

      }

      public interface Ist_4_type
         : Mobilize.Web.IStaticText
      {

         void DoWmInit();

      }

      public interface Isle_1_type
         : Mobilize.Web.ISingleLineEdit
      {

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

      public interface Igb_1_type
         : Mobilize.Web.IGroupBox
      {

         void DoWmInit();

      }

      public interface Igb_2_type
         : Mobilize.Web.IGroupBox
      {

         void DoWmInit();

      }

      public interface Igb_3_type
         : Mobilize.Web.IGroupBox
      {

         void DoWmInit();

      }

   }
}
#pragma warning restore
