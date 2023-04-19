#pragma warning disable
#line 1 "multicontroldemo\\Iw_allinformation\\Iw_allinformation_Layout.cs"
#pragma warning disable
#line 1 "multicontroldemo\\Iw_allinformation\\Iw_allinformation_Layout.cs"
namespace multicontroldemo
{

   public interface Iw_allinformation
      : Mobilize.Web.IWindow
   {

      void Create();

      void Destroy();

      short? logaction(string arg);

      short? modifydatawindow(string mask);

      Iw_allinformationInner.Icb_1_type cb_1 { get; set; }

      Iw_allinformationInner.Isle_1_type sle_1 { get; set; }

      Iw_allinformationInner.Icb_insert_details_type cb_insert_details { get; set; }

      Iw_allinformationInner.Icb_get_text_details_type cb_get_text_details { get; set; }

      Iw_allinformationInner.Icb_insertrow_type cb_insertrow { get; set; }

      Iw_allinformationInner.Icb_gettext_type cb_gettext { get; set; }

      Iw_allinformationInner.Icb_clear_type cb_clear { get; set; }

      Iw_allinformationInner.Imle_log_type mle_log { get; set; }

      Iw_allinformationInner.Idw_additional_info_type dw_additional_info { get; set; }

      Iw_allinformationInner.Idw_main_info_type dw_main_info { get; set; }

      Iw_allinformationInner.Igb_main_type gb_main { get; set; }

      Iw_allinformationInner.Igb_details_type gb_details { get; set; }

   }

   namespace Iw_allinformationInner
   {

      public interface Icb_1_type
         : Mobilize.Web.ICommandButton
      {

         int? Clicked();

         void DoWmInit();

      }

      public interface Isle_1_type
         : Mobilize.Web.ISingleLineEdit
      {

         void DoWmInit();

      }

      public interface Icb_insert_details_type
         : Mobilize.Web.ICommandButton
      {

         int? Clicked();

         void DoWmInit();

      }

      public interface Icb_get_text_details_type
         : Mobilize.Web.ICommandButton
      {

         int? Clicked();

         void DoWmInit();

      }

      public interface Icb_insertrow_type
         : Mobilize.Web.ICommandButton
      {

         int? Clicked();

         void DoWmInit();

      }

      public interface Icb_gettext_type
         : Mobilize.Web.ICommandButton
      {

         int? Clicked();

         void DoWmInit();

      }

      public interface Icb_clear_type
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

      public interface Idw_additional_info_type
         : Mobilize.Web.IDataManagerControl
      {

         short? ItemChanged(int? row, Mobilize.Web.IDmControl dwo, string data);

         short? ItemFocusChanged(int? row, Mobilize.Web.IDmControl dwo);

         void DoWmInit();

      }

      public interface Idw_main_info_type
         : Mobilize.Web.IDataManagerControl
      {

         int? keydown(Mobilize.Web.KeyCode? key, uint? keyflags);

         short? ItemChanged(int? row, Mobilize.Web.IDmControl dwo, string data);

         short? ItemFocusChanged(int? row, Mobilize.Web.IDmControl dwo);

         int? LoseFocus();

         int? GetFocus();

         short? RowFocusChanged(int? currentrow);

         short? RowFocusChanging(int? currentrow, int? newrow);

         short? EditChanged(int? row, Mobilize.Web.IDmControl dwo, string data);

         short? ButtonClicked(int? row, int? actionreturncode, Mobilize.Web.IDmControl dwo);

         short? Clicked(short? xpos, short? ypos, int? row, Mobilize.Web.IDmControl dwo);

         short? DoubleClicked(short? xpos, short? ypos, int? row, Mobilize.Web.IDmControl dwo);

         Iw_allinformationInner.Idw_main_info_typeInner.keydownHandler keydownEventHandler { get; set; }

         void DoWmInit();

      }

      namespace Idw_main_info_typeInner
      {

         public delegate int? keydownHandler(Mobilize.Web.KeyCode? key, uint? keyflags);
      }

      public interface Igb_main_type
         : Mobilize.Web.IGroupBox
      {

         void DoWmInit();

      }

      public interface Igb_details_type
         : Mobilize.Web.IGroupBox
      {

         void DoWmInit();

      }

   }
}
#pragma warning restore
