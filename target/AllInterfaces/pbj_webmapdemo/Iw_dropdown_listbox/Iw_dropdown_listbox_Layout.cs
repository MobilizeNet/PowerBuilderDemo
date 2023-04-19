namespace pbj_webmapdemo
{

   public interface Iw_dropdown_listbox
      : Mobilize.Web.IWindow
   {

      void Create();

      void Destroy();

      Iw_dropdown_listboxInner.Icb_3_type cb_3 { get; set; }

      Iw_dropdown_listboxInner.Icb_10_type cb_10 { get; set; }

      Iw_dropdown_listboxInner.Icb_9_type cb_9 { get; set; }

      Iw_dropdown_listboxInner.Icb_8_type cb_8 { get; set; }

      Iw_dropdown_listboxInner.Icb_7_type cb_7 { get; set; }

      Iw_dropdown_listboxInner.Icb_2_type cb_2 { get; set; }

      Iw_dropdown_listboxInner.Icb_4_type cb_4 { get; set; }

      Iw_dropdown_listboxInner.Icb_5_type cb_5 { get; set; }

      Iw_dropdown_listboxInner.Icb_6_type cb_6 { get; set; }

      Iw_dropdown_listboxInner.Icb_1_type cb_1 { get; set; }

      Iw_dropdown_listboxInner.Iddlb_1_type ddlb_1 { get; set; }

   }

   namespace Iw_dropdown_listboxInner
   {

      public interface Icb_3_type
         : Mobilize.Web.ICommandButton
      {

         int? Clicked();

         void DoWmInit();

      }

      public interface Icb_10_type
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

      public interface Icb_2_type
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

      public interface Icb_1_type
         : Mobilize.Web.ICommandButton
      {

         int? Clicked();

         void DoWmInit();

      }

      public interface Iddlb_1_type
         : Mobilize.Web.IDropDownListBox
      {

         void DoWmInit();

      }

   }
}