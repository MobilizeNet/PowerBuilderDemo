namespace medicationcenter
{

   [Mobilize.WebMap.Common.Attributes.Observable]
   public partial class w_login
      : medicationcenter.w_loginbase, medicationcenter.Iw_login
   {

      public override void Create()
      {
         short? iCurrent = 0;
         base.Create();
         this.pb_1 = CreateInnerControl_pb_1_type();
         iCurrent = (short?)this.Control.GetUpperBound();
         this.Control[iCurrent + 1] = this.pb_1;
      }

      public override void Destroy()
      {
         base.Destroy();
         this.pb_1 = null;
      }

      public virtual void handlelogin(byte? loggedin)
      {
         if ( Mobilize.Web.Comparison.Equals(loggedin, 1) == true )
         {
            // Open as Admin
            Mobilize.Web.Application.CurrentApplication.Variables.isAdmin = true;
         }
         else if ( Mobilize.Web.Comparison.Equals(loggedin, 2) == true )
         {
            // Open as normal user
            Mobilize.Web.Application.CurrentApplication.Variables.isAdmin = false;
         }
         else
         {
            Mobilize.Web.MessageBox.Show("Wrong user or password", "Your credentials are not valid, please try again...");
            return ;
         }
         Mobilize.Web.BuiltInExtensions.Open(Mobilize.Web.ReferenceExtensions.Ref<Mobilize.Web.IWindow>((Mobilize.Web.IWindow)Mobilize.Web.Application.CurrentApplication.Variables.w_mdi<medicationcenter.Iw_mdi>(), (v) => Mobilize.Web.Application.CurrentApplication.Variables.w_mdi = (medicationcenter.Iw_mdi)v, () => Mobilize.Web.Application.CurrentApplication.Variables.w_mdi<medicationcenter.Iw_mdi>()));
         Mobilize.Web.BuiltInExtensions.Close(this);
      }

      public override void ev_loadcontent()
      {
         base.ev_loadcontent();
         this.uo_okcancel.cb_retry.Enabled = false;
      }

      public override void DoWmInit()
      {
         base.DoWmInit();
         ;
      }

      protected virtual Iw_loginInner.Ipb_1_type CreateInnerControl_pb_1_type()
      {
         return Mobilize.Web.Application.Create<Iw_loginInner.Ipb_1_type>(this);
      }

      protected override medicationcenter.Iw_loginbaseInner.Icbx_admin_type CreateInnerControl_cbx_admin_type()
      {
         return Mobilize.Web.Application.Create<Iw_loginInner.Icbx_admin_type>(this);
      }

      protected override medicationcenter.Iw_loginbaseInner.Ist_pass_type CreateInnerControl_st_pass_type()
      {
         return Mobilize.Web.Application.Create<Iw_loginInner.Ist_pass_type>(this);
      }

      protected override medicationcenter.Iw_loginbaseInner.Ist_user_type CreateInnerControl_st_user_type()
      {
         return Mobilize.Web.Application.Create<Iw_loginInner.Ist_user_type>(this);
      }

      protected override medicationcenter.Iw_loginbaseInner.Isle_pass_type CreateInnerControl_sle_pass_type()
      {
         return Mobilize.Web.Application.Create<Iw_loginInner.Isle_pass_type>(this);
      }

      protected override medicationcenter.Iw_loginbaseInner.Isle_user_type CreateInnerControl_sle_user_type()
      {
         return Mobilize.Web.Application.Create<Iw_loginInner.Isle_user_type>(this);
      }

      protected override medicationcenter.Iw_loginbaseInner.Iuo_okcancel_type CreateInnerControl_uo_okcancel_type()
      {
         return Mobilize.Web.Application.Create<Iw_loginInner.Iuo_okcancel_type>(this);
      }

      public class pb_1_type
         : Mobilize.Web.PictureButton, Iw_loginInner.Ipb_1_type
      {

         public pb_1_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_login Parent => (w_login)base.Parent;

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 50;
            this.Y = 44;
            this.Width = 645;
            this.Height = 408;
            this.TabOrder = 20;
            this.BringToTop = true;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.PictureName = "medicalcenter\\img\\20901530_10155716394219390_8190256644347102319_o.jpg";
            this.HTextAlign = Mobilize.Web.Alignment.Left;
         }

      }

      public class cbx_admin_type
         : medicationcenter.w_loginbase.cbx_admin_type, Iw_loginInner.Icbx_admin_type
      {

         public cbx_admin_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_login Parent => (w_login)base.Parent;

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.Visible = false;
         }

      }

      public class st_pass_type
         : medicationcenter.w_loginbase.st_pass_type, Iw_loginInner.Ist_pass_type
      {

         public st_pass_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_login Parent => (w_login)base.Parent;

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 795;
            this.Y = 276;
            this.Height = 72;
         }

      }

      public class st_user_type
         : medicationcenter.w_loginbase.st_user_type, Iw_loginInner.Ist_user_type
      {

         public st_user_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_login Parent => (w_login)base.Parent;

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 800;
            this.Y = 152;
            this.Width = 197;
         }

      }

      public class sle_pass_type
         : medicationcenter.w_loginbase.sle_pass_type, Iw_loginInner.Isle_pass_type
      {

         public sle_pass_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_login Parent => (w_login)base.Parent;

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 1189;
            this.Y = 272;
            this.Width = 640;
         }

      }

      public class sle_user_type
         : medicationcenter.w_loginbase.sle_user_type, Iw_loginInner.Isle_user_type
      {

         public sle_user_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_login Parent => (w_login)base.Parent;

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 1198;
            this.Y = 124;
            this.Width = 635;
         }

      }

      public partial class uo_okcancel_type
         : medicationcenter.w_loginbase.uo_okcancel_type, Iw_loginInner.Iuo_okcancel_type
      {

         public uo_okcancel_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_login Parent => (w_login)base.Parent;

         public override void okclick()
         {
            Mobilize.Web.ISingleLineEdit s1 = Mobilize.Web.Application.Default<Mobilize.Web.ISingleLineEdit>(), s2 = Mobilize.Web.Application.Default<Mobilize.Web.ISingleLineEdit>();
            base.okclick();
            s1 = this.Parent.sle_user;
            s2 = this.Parent.sle_pass;
            Parent.handlelogin((byte?)medicationcenter.medicationcenterGlobalFunctions.verifyuser(s1.Text, s2.Text));
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 247;
            this.Y = 508;
            this.okclickEventHandler = this.okclick;
         }

      }

   }

}