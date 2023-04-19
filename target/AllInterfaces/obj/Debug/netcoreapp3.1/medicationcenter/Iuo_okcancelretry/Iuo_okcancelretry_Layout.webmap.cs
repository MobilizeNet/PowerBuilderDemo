#pragma warning disable
#line 1 "medicationcenter\\Iuo_okcancelretry\\Iuo_okcancelretry_Layout.cs"
#pragma warning disable
#line 1 "medicationcenter\\Iuo_okcancelretry\\Iuo_okcancelretry_Layout.cs"
namespace medicationcenter
{

   public interface Iuo_okcancelretry
      : Mobilize.Web.IUserObject
   {

      void Create();

      void Destroy();

      void DoWmInit();

      void okclick();

      void cancelclick();

      void retryclick();

      Iuo_okcancelretryInner.Icb_retry_type cb_retry { get; set; }

      Iuo_okcancelretryInner.Icb_cancel_type cb_cancel { get; set; }

      Iuo_okcancelretryInner.Icb_ok_type cb_ok { get; set; }

      Mobilize.Web.VoidEventHandler okclickEventHandler { get; set; }

      Mobilize.Web.VoidEventHandler cancelclickEventHandler { get; set; }

      Mobilize.Web.VoidEventHandler retryclickEventHandler { get; set; }

   }

   namespace Iuo_okcancelretryInner
   {

      public interface Icb_retry_type
         : Mobilize.Web.ICommandButton
      {

         int? Clicked();

         void DoWmInit();

      }

      public interface Icb_cancel_type
         : Mobilize.Web.ICommandButton
      {

         int? Clicked();

         void DoWmInit();

      }

      public interface Icb_ok_type
         : Mobilize.Web.ICommandButton
      {

         int? Clicked();

         void DoWmInit();

      }

   }
}
#pragma warning restore
