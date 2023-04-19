#pragma warning disable
#line 1 "uo_okcancelretry\\uo_okcancelretry.cs"
#pragma warning disable
#line 1 "uo_okcancelretry\\uo_okcancelretry.cs"
namespace medicationcenter
{

   [Mobilize.WebMap.Common.Attributes.Observable]
   public partial class uo_okcancelretry
      : Mobilize.Web.UserObject, medicationcenter.Iuo_okcancelretry
   {

      public override void Create()
      {
         this.cb_retry = CreateInnerControl_cb_retry_type();
         this.cb_cancel = CreateInnerControl_cb_cancel_type();
         this.cb_ok = CreateInnerControl_cb_ok_type();
         this.Control = Mobilize.Web.ArrayExtensions.Clone<Mobilize.Web.IControl>(new Mobilize.Web.IControl[] { this.cb_retry, this.cb_cancel, this.cb_ok });
      }

      public override void Destroy()
      {
         this.cb_retry = null;
         this.cb_cancel = null;
         this.cb_ok = null;
      }

      public override void DoWmInit()
      {
         base.DoWmInit();
         this.okclickEventHandler = this.okclick;
         this.cancelclickEventHandler = this.cancelclick;
         this.retryclickEventHandler = this.retryclick;
      }

      public virtual void okclick()
      {
      }

      public virtual void cancelclick()
      {
      }

      public virtual void retryclick()
      {
      }

      protected virtual Iuo_okcancelretryInner.Icb_retry_type CreateInnerControl_cb_retry_type()
      {
         return Mobilize.Web.Application.Create<Iuo_okcancelretryInner.Icb_retry_type>(this);
      }

      protected virtual Iuo_okcancelretryInner.Icb_cancel_type CreateInnerControl_cb_cancel_type()
      {
         return Mobilize.Web.Application.Create<Iuo_okcancelretryInner.Icb_cancel_type>(this);
      }

      protected virtual Iuo_okcancelretryInner.Icb_ok_type CreateInnerControl_cb_ok_type()
      {
         return Mobilize.Web.Application.Create<Iuo_okcancelretryInner.Icb_ok_type>(this);
      }

      public partial class cb_retry_type
         : Mobilize.Web.CommandButton, Iuo_okcancelretryInner.Icb_retry_type
      {

         public cb_retry_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new uo_okcancelretry Parent => (uo_okcancelretry)base.Parent;

         public virtual int? Clicked()
         {
            this.Parent.TriggerEvent("retryclick");
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 526;
            this.Y = 44;
            this.Width = 402;
            this.Height = 112;
            this.TabOrder = 30;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.Text = "Retry";
            this.bnclicked = new Mobilize.Web.ClickedEventHandler(Clicked);
         }

      }

      public partial class cb_cancel_type
         : Mobilize.Web.CommandButton, Iuo_okcancelretryInner.Icb_cancel_type
      {

         public cb_cancel_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new uo_okcancelretry Parent => (uo_okcancelretry)base.Parent;

         public virtual int? Clicked()
         {
            this.Parent.TriggerEvent("cancelclick");
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 974;
            this.Y = 48;
            this.Width = 402;
            this.Height = 112;
            this.TabOrder = 20;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.Text = "Cancel";
            this.Cancel = true;
            this.bnclicked = new Mobilize.Web.ClickedEventHandler(Clicked);
         }

      }

      public partial class cb_ok_type
         : Mobilize.Web.CommandButton, Iuo_okcancelretryInner.Icb_ok_type
      {

         public cb_ok_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new uo_okcancelretry Parent => (uo_okcancelretry)base.Parent;

         public virtual int? Clicked()
         {
            this.Parent.TriggerEvent("okclick");
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 64;
            this.Y = 44;
            this.Width = 402;
            this.Height = 112;
            this.TabOrder = 10;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.Text = "Ok";
            this.Default = true;
            this.bnclicked = new Mobilize.Web.ClickedEventHandler(Clicked);
         }

      }

   }

}
#pragma warning restore
