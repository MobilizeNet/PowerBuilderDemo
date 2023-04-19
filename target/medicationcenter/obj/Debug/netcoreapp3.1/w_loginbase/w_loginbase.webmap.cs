#pragma warning disable
#line 1 "w_loginbase\\w_loginbase.cs"
#pragma warning disable
#line 1 "w_loginbase\\w_loginbase.cs"
namespace medicationcenter
{

   [Mobilize.WebMap.Common.Attributes.Observable]
   public partial class w_loginbase
      : basecomponents.w_basewindow, medicationcenter.Iw_loginbase
   {

      public override void Create()
      {
         short? iCurrent = 0;
         base.Create();
         this.cbx_admin = CreateInnerControl_cbx_admin_type();
         this.st_pass = CreateInnerControl_st_pass_type();
         this.st_user = CreateInnerControl_st_user_type();
         this.sle_pass = CreateInnerControl_sle_pass_type();
         this.sle_user = CreateInnerControl_sle_user_type();
         this.uo_okcancel = CreateInnerControl_uo_okcancel_type();
         iCurrent = (short?)this.Control.GetUpperBound();
         this.Control[iCurrent + 1] = this.cbx_admin;
         this.Control[iCurrent + 2] = this.st_pass;
         this.Control[iCurrent + 3] = this.st_user;
         this.Control[iCurrent + 4] = this.sle_pass;
         this.Control[iCurrent + 5] = this.sle_user;
         this.Control[iCurrent + 6] = this.uo_okcancel;
      }

      public override void Destroy()
      {
         base.Destroy();
         this.cbx_admin = null;
         this.st_pass = null;
         this.st_user = null;
         this.sle_pass = null;
         this.sle_user = null;
         this.uo_okcancel = null;
      }

      protected virtual Iw_loginbaseInner.Icbx_admin_type CreateInnerControl_cbx_admin_type()
      {
         return Mobilize.Web.Application.Create<Iw_loginbaseInner.Icbx_admin_type>(this);
      }

      protected virtual Iw_loginbaseInner.Ist_pass_type CreateInnerControl_st_pass_type()
      {
         return Mobilize.Web.Application.Create<Iw_loginbaseInner.Ist_pass_type>(this);
      }

      protected virtual Iw_loginbaseInner.Ist_user_type CreateInnerControl_st_user_type()
      {
         return Mobilize.Web.Application.Create<Iw_loginbaseInner.Ist_user_type>(this);
      }

      protected virtual Iw_loginbaseInner.Isle_pass_type CreateInnerControl_sle_pass_type()
      {
         return Mobilize.Web.Application.Create<Iw_loginbaseInner.Isle_pass_type>(this);
      }

      protected virtual Iw_loginbaseInner.Isle_user_type CreateInnerControl_sle_user_type()
      {
         return Mobilize.Web.Application.Create<Iw_loginbaseInner.Isle_user_type>(this);
      }

      protected virtual Iw_loginbaseInner.Iuo_okcancel_type CreateInnerControl_uo_okcancel_type()
      {
         return Mobilize.Web.Application.Create<Iw_loginbaseInner.Iuo_okcancel_type>(this);
      }

      public partial class cbx_admin_type
         : Mobilize.Web.CheckBox, Iw_loginbaseInner.Icbx_admin_type
      {

         public cbx_admin_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_loginbase Parent => (w_loginbase)base.Parent;

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 823;
            this.Y = 476;
            this.Width = 672;
            this.Height = 80;
            this.TabOrder = 30;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.TextColor = 33554432;
            this.BackColor = 67108864;
            this.Text = "Login as administrator";
         }

      }

      public partial class st_pass_type
         : Mobilize.Web.StaticText, Iw_loginbaseInner.Ist_pass_type
      {

         public st_pass_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_loginbase Parent => (w_loginbase)base.Parent;

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 119;
            this.Y = 268;
            this.Width = 402;
            this.Height = 64;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.TextColor = 33554432;
            this.BackColor = 67108864;
            this.Text = "Password:";
            this.FocusRectangle = false;
         }

      }

      public partial class st_user_type
         : Mobilize.Web.StaticText, Iw_loginbaseInner.Ist_user_type
      {

         public st_user_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_loginbase Parent => (w_loginbase)base.Parent;

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 114;
            this.Y = 108;
            this.Width = 402;
            this.Height = 64;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.TextColor = 33554432;
            this.BackColor = 67108864;
            this.Text = "User:";
            this.FocusRectangle = false;
         }

      }

      public partial class sle_pass_type
         : Mobilize.Web.SingleLineEdit, Iw_loginbaseInner.Isle_pass_type
      {

         public sle_pass_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_loginbase Parent => (w_loginbase)base.Parent;

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 622;
            this.Y = 264;
            this.Width = 901;
            this.Height = 84;
            this.TabOrder = 20;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.TextColor = 33554432;
            this.Password = true;
            this.BorderStyle = Mobilize.Web.BorderStyle.StyleLowered;
         }

      }

      public partial class sle_user_type
         : Mobilize.Web.SingleLineEdit, Iw_loginbaseInner.Isle_user_type
      {

         public sle_user_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_loginbase Parent => (w_loginbase)base.Parent;

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 617;
            this.Y = 120;
            this.Width = 901;
            this.Height = 84;
            this.TabOrder = 10;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.TextColor = 33554432;
            this.BorderStyle = Mobilize.Web.BorderStyle.StyleLowered;
         }

      }

      public partial class uo_okcancel_type
         : medicationcenter.uo_okcancelretry, Iw_loginbaseInner.Iuo_okcancel_type
      {

         public uo_okcancel_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_loginbase Parent => (w_loginbase)base.Parent;

         public override void cancelclick()
         {
            short? result = 0;
            base.cancelclick();
            result = Mobilize.Web.MessageBox.Show("Close Verification", "Do you want to close the application?", Mobilize.Web.Icon.Question, Mobilize.Web.CommandButtons.YesNo);
            if ( Mobilize.Web.Comparison.Equals(result, 1) == true )
            {
               Mobilize.Web.BuiltInExtensions.Close(this.Parent);
            }
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 101;
            this.Y = 620;
            this.TabOrder = 40;
            ;
         }

      }

   }

}
#pragma warning restore
