#pragma warning disable
#line 1 "medicationcenter\\Iw_login\\Iw_login_Layout.cs"
#pragma warning disable
#line 1 "medicationcenter\\Iw_login\\Iw_login_Layout.cs"
namespace medicationcenter
{

   public interface Iw_login
      : medicationcenter.Iw_loginbase
   {

      void Create();

      void Destroy();

      void handlelogin(byte? loggedin);

      void ev_loadcontent();

      void DoWmInit();

      Iw_loginInner.Ipb_1_type pb_1 { get; set; }

   }

   namespace Iw_loginInner
   {

      public interface Ipb_1_type
         : Mobilize.Web.IPictureButton
      {

         void DoWmInit();

      }

      public interface Icbx_admin_type
         : medicationcenter.Iw_loginbaseInner.Icbx_admin_type
      {

         void DoWmInit();

      }

      public interface Ist_pass_type
         : medicationcenter.Iw_loginbaseInner.Ist_pass_type
      {

         void DoWmInit();

      }

      public interface Ist_user_type
         : medicationcenter.Iw_loginbaseInner.Ist_user_type
      {

         void DoWmInit();

      }

      public interface Isle_pass_type
         : medicationcenter.Iw_loginbaseInner.Isle_pass_type
      {

         void DoWmInit();

      }

      public interface Isle_user_type
         : medicationcenter.Iw_loginbaseInner.Isle_user_type
      {

         void DoWmInit();

      }

      public interface Iuo_okcancel_type
         : medicationcenter.Iw_loginbaseInner.Iuo_okcancel_type
      {

         void okclick();

         void DoWmInit();

      }

   }
}
#pragma warning restore
