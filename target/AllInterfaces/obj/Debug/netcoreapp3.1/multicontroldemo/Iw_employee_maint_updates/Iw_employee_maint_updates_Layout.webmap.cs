#pragma warning disable
#line 1 "multicontroldemo\\Iw_employee_maint_updates\\Iw_employee_maint_updates_Layout.cs"
#pragma warning disable
#line 1 "multicontroldemo\\Iw_employee_maint_updates\\Iw_employee_maint_updates_Layout.cs"
namespace multicontroldemo
{

   public interface Iw_employee_maint_updates
      : Mobilize.Web.IWindow
   {

      void Create();

      void Destroy();

      int? OpenWindow();

      void DoWmInit();

      Iw_employee_maint_updatesInner.Icb_9_type cb_9 { get; set; }

      Iw_employee_maint_updatesInner.Icb_8_type cb_8 { get; set; }

      Iw_employee_maint_updatesInner.Icb_7_type cb_7 { get; set; }

      Iw_employee_maint_updatesInner.Icb_6_type cb_6 { get; set; }

      Iw_employee_maint_updatesInner.Icb_5_type cb_5 { get; set; }

      Iw_employee_maint_updatesInner.Icb_4_type cb_4 { get; set; }

      Iw_employee_maint_updatesInner.Icb_3_type cb_3 { get; set; }

      Iw_employee_maint_updatesInner.Icb_2_type cb_2 { get; set; }

      Iw_employee_maint_updatesInner.Icb_1_type cb_1 { get; set; }

      Iw_employee_maint_updatesInner.Idw_1_type dw_1 { get; set; }

   }

   namespace Iw_employee_maint_updatesInner
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

         short? ItemChanged(int? row, Mobilize.Web.IDmControl dwo, string data);

         void DoWmInit();

      }

   }
}
#pragma warning restore
