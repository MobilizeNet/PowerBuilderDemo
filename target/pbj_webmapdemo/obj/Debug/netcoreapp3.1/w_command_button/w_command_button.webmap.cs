#pragma warning disable
#line 1 "w_command_button\\w_command_button.cs"
#pragma warning disable
#line 1 "w_command_button\\w_command_button.cs"
namespace pbj_webmapdemo
{

   [Mobilize.WebMap.Common.Attributes.Observable]
   public partial class w_command_button
      : Mobilize.Web.Window, pbj_webmapdemo.Iw_command_button
   {

      public override void Create()
      {
         this.cb_1 = CreateInnerControl_cb_1_type();
         this.cb_3 = CreateInnerControl_cb_3_type();
         this.cb_6 = CreateInnerControl_cb_6_type();
         this.cb_5 = CreateInnerControl_cb_5_type();
         this.cb_4 = CreateInnerControl_cb_4_type();
         this.cb_0 = CreateInnerControl_cb_0_type();
         this.Control = Mobilize.Web.ArrayExtensions.Clone<Mobilize.Web.IControl>(new Mobilize.Web.IControl[] { this.cb_1, this.cb_3, this.cb_6, this.cb_5, this.cb_4, this.cb_0 });
      }

      public override void Destroy()
      {
         this.cb_1 = null;
         this.cb_3 = null;
         this.cb_6 = null;
         this.cb_5 = null;
         this.cb_4 = null;
         this.cb_0 = null;
      }

      protected virtual Iw_command_buttonInner.Icb_1_type CreateInnerControl_cb_1_type()
      {
         return Mobilize.Web.Application.Create<Iw_command_buttonInner.Icb_1_type>(this);
      }

      protected virtual Iw_command_buttonInner.Icb_3_type CreateInnerControl_cb_3_type()
      {
         return Mobilize.Web.Application.Create<Iw_command_buttonInner.Icb_3_type>(this);
      }

      protected virtual Iw_command_buttonInner.Icb_6_type CreateInnerControl_cb_6_type()
      {
         return Mobilize.Web.Application.Create<Iw_command_buttonInner.Icb_6_type>(this);
      }

      protected virtual Iw_command_buttonInner.Icb_5_type CreateInnerControl_cb_5_type()
      {
         return Mobilize.Web.Application.Create<Iw_command_buttonInner.Icb_5_type>(this);
      }

      protected virtual Iw_command_buttonInner.Icb_4_type CreateInnerControl_cb_4_type()
      {
         return Mobilize.Web.Application.Create<Iw_command_buttonInner.Icb_4_type>(this);
      }

      protected virtual Iw_command_buttonInner.Icb_0_type CreateInnerControl_cb_0_type()
      {
         return Mobilize.Web.Application.Create<Iw_command_buttonInner.Icb_0_type>(this);
      }

      public partial class cb_1_type
         : Mobilize.Web.CommandButton, Iw_command_buttonInner.Icb_1_type
      {

         public cb_1_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_command_button Parent => (w_command_button)base.Parent;

         public virtual int? Clicked()
         { //Change CommandButton Show/Hide

            if ( Mobilize.Web.Comparison.Equals(this.Parent.cb_0.Visible, true) == true )
            {
               this.Parent.cb_0.Hide();
            }
            else
            {
               this.Parent.cb_0.Show();
            }
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 297;
            this.Y = 488;
            this.Width = 402;
            this.Height = 112;
            this.TabOrder = 30;
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

      public partial class cb_3_type
         : Mobilize.Web.CommandButton, Iw_command_buttonInner.Icb_3_type
      {

         public cb_3_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_command_button Parent => (w_command_button)base.Parent;

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 1312;
            this.Y = 488;
            this.Width = 402;
            this.Height = 112;
            this.TabOrder = 20;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.Text = "Click";
         }

      }

      public partial class cb_6_type
         : Mobilize.Web.CommandButton, Iw_command_buttonInner.Icb_6_type
      {

         public cb_6_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_command_button Parent => (w_command_button)base.Parent;

         public virtual int? Clicked()
         { //GetText

            string s_checkbox_text = "";
            s_checkbox_text = this.Parent.cb_0.Text;
            //Change CommandButton Text
            if ( Mobilize.Web.Comparison.Equals(s_checkbox_text, "Command Button") == true )
            {
               this.Parent.cb_0.Text = "Text Changed";
            }
            else
            {
               this.Parent.cb_0.Text = "Command Button";
            }
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 1317;
            this.Y = 676;
            this.Width = 402;
            this.Height = 112;
            this.TabOrder = 30;
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

      public partial class cb_5_type
         : Mobilize.Web.CommandButton, Iw_command_buttonInner.Icb_5_type
      {

         public cb_5_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_command_button Parent => (w_command_button)base.Parent;

         public virtual int? Clicked()
         { //GetVisible

            bool? lb_visible = false;
            lb_visible = this.Parent.cb_0.Visible;
            //Change CheckBox Visible
            if ( (lb_visible) == true )
            {
               this.Parent.cb_0.Visible = false;
            }
            else
            {
               this.Parent.cb_0.Visible = true;
            }
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 814;
            this.Y = 672;
            this.Width = 402;
            this.Height = 112;
            this.TabOrder = 20;
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

      public partial class cb_4_type
         : Mobilize.Web.CommandButton, Iw_command_buttonInner.Icb_4_type
      {

         public cb_4_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_command_button Parent => (w_command_button)base.Parent;

         public virtual int? Clicked()
         { //GetEnabled

            bool? lb_enabled = false;
            lb_enabled = this.Parent.cb_0.Enabled;
            //Change CheckBox ENABLED
            if ( (lb_enabled) == true )
            {
               this.Parent.cb_0.Enabled = false;
            }
            else
            {
               this.Parent.cb_0.Enabled = true;
            }
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 302;
            this.Y = 676;
            this.Width = 402;
            this.Height = 112;
            this.TabOrder = 20;
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

      public partial class cb_0_type
         : Mobilize.Web.CommandButton, Iw_command_buttonInner.Icb_0_type
      {

         public cb_0_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_command_button Parent => (w_command_button)base.Parent;

         public virtual int? Clicked()
         { //Change Click button text

            if ( Mobilize.Web.Comparison.Equals(this.Parent.cb_3.Text, "Click") == true )
            {
               this.Parent.cb_3.Text = "Clicked";
            }
            else
            {
               this.Parent.cb_3.Text = "Click";
            }
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 750;
            this.Y = 176;
            this.Width = 503;
            this.Height = 136;
            this.TabOrder = 10;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.Text = "Command Button";
            this.bnclicked = new Mobilize.Web.ClickedEventHandler(Clicked);
         }

      }

   }

}
#pragma warning restore
