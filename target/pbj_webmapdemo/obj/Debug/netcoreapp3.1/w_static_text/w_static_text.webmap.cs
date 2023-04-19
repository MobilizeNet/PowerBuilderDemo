#pragma warning disable
#line 1 "w_static_text\\w_static_text.cs"
#pragma warning disable
#line 1 "w_static_text\\w_static_text.cs"
namespace pbj_webmapdemo
{

   [Mobilize.WebMap.Common.Attributes.Observable]
   public partial class w_static_text
      : Mobilize.Web.Window, pbj_webmapdemo.Iw_static_text
   {

      public override void Create()
      {
         this.st_1 = CreateInnerControl_st_1_type();
         this.cb_enable = CreateInnerControl_cb_enable_type();
         this.cb_visible = CreateInnerControl_cb_visible_type();
         this.cb_text = CreateInnerControl_cb_text_type();
         this.cb_showhide = CreateInnerControl_cb_showhide_type();
         this.Control = Mobilize.Web.ArrayExtensions.Clone<Mobilize.Web.IControl>(new Mobilize.Web.IControl[] { this.st_1, this.cb_enable, this.cb_visible, this.cb_text, this.cb_showhide });
      }

      public override void Destroy()
      {
         this.st_1 = null;
         this.cb_enable = null;
         this.cb_visible = null;
         this.cb_text = null;
         this.cb_showhide = null;
      }

      protected virtual Iw_static_textInner.Ist_1_type CreateInnerControl_st_1_type()
      {
         return Mobilize.Web.Application.Create<Iw_static_textInner.Ist_1_type>(this);
      }

      protected virtual Iw_static_textInner.Icb_enable_type CreateInnerControl_cb_enable_type()
      {
         return Mobilize.Web.Application.Create<Iw_static_textInner.Icb_enable_type>(this);
      }

      protected virtual Iw_static_textInner.Icb_visible_type CreateInnerControl_cb_visible_type()
      {
         return Mobilize.Web.Application.Create<Iw_static_textInner.Icb_visible_type>(this);
      }

      protected virtual Iw_static_textInner.Icb_text_type CreateInnerControl_cb_text_type()
      {
         return Mobilize.Web.Application.Create<Iw_static_textInner.Icb_text_type>(this);
      }

      protected virtual Iw_static_textInner.Icb_showhide_type CreateInnerControl_cb_showhide_type()
      {
         return Mobilize.Web.Application.Create<Iw_static_textInner.Icb_showhide_type>(this);
      }

      public partial class st_1_type
         : Mobilize.Web.StaticText, Iw_static_textInner.Ist_1_type
      {

         public st_1_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_static_text Parent => (w_static_text)base.Parent;

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 224;
            this.Y = 116;
            this.Width = 1042;
            this.Height = 120;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.TextColor = 33554432;
            this.BackColor = 67108864;
            this.Text = "Static Text";
            this.FocusRectangle = false;
         }

      }

      public partial class cb_enable_type
         : Mobilize.Web.CommandButton, Iw_static_textInner.Icb_enable_type
      {

         public cb_enable_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_static_text Parent => (w_static_text)base.Parent;

         public virtual int? Clicked()
         { //GetEnabled

            bool? lb_enabled = false;
            lb_enabled = this.Parent.st_1.Enabled;
            //Change SingleLineEdit ENABLED
            if ( (lb_enabled) == true )
            {
               this.Parent.st_1.Enabled = false;
            }
            else
            {
               this.Parent.st_1.Enabled = true;
            }
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 229;
            this.Y = 604;
            this.Width = 402;
            this.Height = 112;
            this.TabOrder = 50;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.Text = "Enable";
            this.bnclicked = new Mobilize.Web.ClickedEventHandler(Clicked);
         }

      }

      public partial class cb_visible_type
         : Mobilize.Web.CommandButton, Iw_static_textInner.Icb_visible_type
      {

         public cb_visible_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_static_text Parent => (w_static_text)base.Parent;

         public virtual int? Clicked()
         { //GetVisible

            bool? lb_visible = false;
            lb_visible = this.Parent.st_1.Visible;
            //Change SingleLineEdit Visible
            if ( (lb_visible) == true )
            {
               this.Parent.st_1.Visible = false;
            }
            else
            {
               this.Parent.st_1.Visible = true;
            }
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 891;
            this.Y = 604;
            this.Width = 402;
            this.Height = 112;
            this.TabOrder = 50;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.Text = "Visible";
            this.bnclicked = new Mobilize.Web.ClickedEventHandler(Clicked);
         }

      }

      public partial class cb_text_type
         : Mobilize.Web.CommandButton, Iw_static_textInner.Icb_text_type
      {

         public cb_text_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_static_text Parent => (w_static_text)base.Parent;

         public virtual int? Clicked()
         { //GetText

            string s_staticTex_text = "";
            s_staticTex_text = this.Parent.st_1.Text;
            //Change SingleLineEdit Text
            if ( Mobilize.Web.Comparison.Equals(s_staticTex_text, "Static Text") == true )
            {
               this.Parent.st_1.Text = "Text Changed";
            }
            else
            {
               this.Parent.st_1.Text = "Static Text";
            }
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 891;
            this.Y = 400;
            this.Width = 402;
            this.Height = 112;
            this.TabOrder = 50;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.Text = "Text";
            this.bnclicked = new Mobilize.Web.ClickedEventHandler(Clicked);
         }

      }

      public partial class cb_showhide_type
         : Mobilize.Web.CommandButton, Iw_static_textInner.Icb_showhide_type
      {

         public cb_showhide_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_static_text Parent => (w_static_text)base.Parent;

         public virtual int? Clicked()
         { //Change SingleLineEdit Show/Hide

            if ( Mobilize.Web.Comparison.Equals(this.Parent.st_1.Visible, true) == true )
            {
               this.Parent.st_1.Hide();
            }
            else
            {
               this.Parent.st_1.Show();
            }
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 229;
            this.Y = 400;
            this.Width = 402;
            this.Height = 112;
            this.TabOrder = 20;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.Text = "Show/Hide";
            this.bnclicked = new Mobilize.Web.ClickedEventHandler(Clicked);
         }

      }

   }

}
#pragma warning restore
