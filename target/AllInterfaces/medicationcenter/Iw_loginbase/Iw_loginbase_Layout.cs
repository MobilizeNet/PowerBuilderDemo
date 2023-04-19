namespace medicationcenter
{

   public interface Iw_loginbase
      : basecomponents.Iw_basewindow
   {

      void Create();

      void Destroy();

      Iw_loginbaseInner.Icbx_admin_type cbx_admin { get; set; }

      Iw_loginbaseInner.Ist_pass_type st_pass { get; set; }

      Iw_loginbaseInner.Ist_user_type st_user { get; set; }

      Iw_loginbaseInner.Isle_pass_type sle_pass { get; set; }

      Iw_loginbaseInner.Isle_user_type sle_user { get; set; }

      Iw_loginbaseInner.Iuo_okcancel_type uo_okcancel { get; set; }

   }

   namespace Iw_loginbaseInner
   {

      public interface Icbx_admin_type
         : Mobilize.Web.ICheckBox
      {

         void DoWmInit();

      }

      public interface Ist_pass_type
         : Mobilize.Web.IStaticText
      {

         void DoWmInit();

      }

      public interface Ist_user_type
         : Mobilize.Web.IStaticText
      {

         void DoWmInit();

      }

      public interface Isle_pass_type
         : Mobilize.Web.ISingleLineEdit
      {

         void DoWmInit();

      }

      public interface Isle_user_type
         : Mobilize.Web.ISingleLineEdit
      {

         void DoWmInit();

      }

      public interface Iuo_okcancel_type
         : medicationcenter.Iuo_okcancelretry
      {

         void cancelclick();

         void DoWmInit();

      }

   }
}