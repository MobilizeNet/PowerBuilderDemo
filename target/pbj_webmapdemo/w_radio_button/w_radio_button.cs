namespace pbj_webmapdemo
{

   [Mobilize.WebMap.Common.Attributes.Observable]
   public partial class w_radio_button
      : Mobilize.Web.Window, pbj_webmapdemo.Iw_radio_button
   {

      public override void Create()
      {
         this.rb_5 = CreateInnerControl_rb_5_type();
         this.rb_4 = CreateInnerControl_rb_4_type();
         this.cb_4 = CreateInnerControl_cb_4_type();
         this.cb_5 = CreateInnerControl_cb_5_type();
         this.cb_6 = CreateInnerControl_cb_6_type();
         this.cb_3 = CreateInnerControl_cb_3_type();
         this.cb_1 = CreateInnerControl_cb_1_type();
         this.cb_7 = CreateInnerControl_cb_7_type();
         this.rb_3 = CreateInnerControl_rb_3_type();
         this.rb_2 = CreateInnerControl_rb_2_type();
         this.rb_1 = CreateInnerControl_rb_1_type();
         this.gb_1 = CreateInnerControl_gb_1_type();
         this.Control = Mobilize.Web.ArrayExtensions.Clone<Mobilize.Web.IControl>(new Mobilize.Web.IControl[] { this.rb_5, this.rb_4, this.cb_4, this.cb_5, this.cb_6, this.cb_3, this.cb_1, this.cb_7, this.rb_3, this.rb_2, this.rb_1, this.gb_1 });
      }

      public override void Destroy()
      {
         this.rb_5 = null;
         this.rb_4 = null;
         this.cb_4 = null;
         this.cb_5 = null;
         this.cb_6 = null;
         this.cb_3 = null;
         this.cb_1 = null;
         this.cb_7 = null;
         this.rb_3 = null;
         this.rb_2 = null;
         this.rb_1 = null;
         this.gb_1 = null;
      }

      protected virtual Iw_radio_buttonInner.Irb_5_type CreateInnerControl_rb_5_type()
      {
         return Mobilize.Web.Application.Create<Iw_radio_buttonInner.Irb_5_type>(this);
      }

      protected virtual Iw_radio_buttonInner.Irb_4_type CreateInnerControl_rb_4_type()
      {
         return Mobilize.Web.Application.Create<Iw_radio_buttonInner.Irb_4_type>(this);
      }

      protected virtual Iw_radio_buttonInner.Icb_4_type CreateInnerControl_cb_4_type()
      {
         return Mobilize.Web.Application.Create<Iw_radio_buttonInner.Icb_4_type>(this);
      }

      protected virtual Iw_radio_buttonInner.Icb_5_type CreateInnerControl_cb_5_type()
      {
         return Mobilize.Web.Application.Create<Iw_radio_buttonInner.Icb_5_type>(this);
      }

      protected virtual Iw_radio_buttonInner.Icb_6_type CreateInnerControl_cb_6_type()
      {
         return Mobilize.Web.Application.Create<Iw_radio_buttonInner.Icb_6_type>(this);
      }

      protected virtual Iw_radio_buttonInner.Icb_3_type CreateInnerControl_cb_3_type()
      {
         return Mobilize.Web.Application.Create<Iw_radio_buttonInner.Icb_3_type>(this);
      }

      protected virtual Iw_radio_buttonInner.Icb_1_type CreateInnerControl_cb_1_type()
      {
         return Mobilize.Web.Application.Create<Iw_radio_buttonInner.Icb_1_type>(this);
      }

      protected virtual Iw_radio_buttonInner.Icb_7_type CreateInnerControl_cb_7_type()
      {
         return Mobilize.Web.Application.Create<Iw_radio_buttonInner.Icb_7_type>(this);
      }

      protected virtual Iw_radio_buttonInner.Irb_3_type CreateInnerControl_rb_3_type()
      {
         return Mobilize.Web.Application.Create<Iw_radio_buttonInner.Irb_3_type>(this);
      }

      protected virtual Iw_radio_buttonInner.Irb_2_type CreateInnerControl_rb_2_type()
      {
         return Mobilize.Web.Application.Create<Iw_radio_buttonInner.Irb_2_type>(this);
      }

      protected virtual Iw_radio_buttonInner.Irb_1_type CreateInnerControl_rb_1_type()
      {
         return Mobilize.Web.Application.Create<Iw_radio_buttonInner.Irb_1_type>(this);
      }

      protected virtual Iw_radio_buttonInner.Igb_1_type CreateInnerControl_gb_1_type()
      {
         return Mobilize.Web.Application.Create<Iw_radio_buttonInner.Igb_1_type>(this);
      }

      public class rb_5_type
         : Mobilize.Web.RadioButton, Iw_radio_buttonInner.Irb_5_type
      {

         public rb_5_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_radio_button Parent => (w_radio_button)base.Parent;

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 965;
            this.Y = 136;
            this.Width = 402;
            this.Height = 80;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.TextColor = 33554432;
            this.BackColor = 67108864;
            this.Text = "RB2";
         }

      }

      public class rb_4_type
         : Mobilize.Web.RadioButton, Iw_radio_buttonInner.Irb_4_type
      {

         public rb_4_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_radio_button Parent => (w_radio_button)base.Parent;

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 315;
            this.Y = 136;
            this.Width = 402;
            this.Height = 80;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.TextColor = 33554432;
            this.BackColor = 67108864;
            this.Text = "RB1";
         }

      }

      public class cb_4_type
         : Mobilize.Web.CommandButton, Iw_radio_buttonInner.Icb_4_type
      {

         public cb_4_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_radio_button Parent => (w_radio_button)base.Parent;

         public virtual int? Clicked()
         { //GetEnabled

            bool? lb_enabled = false;
            lb_enabled = this.Parent.rb_1.Enabled;
            //Change RadioButton ENABLED
            if ( (lb_enabled) == true )
            {
               this.Parent.rb_1.Enabled = false;
            }
            else
            {
               this.Parent.rb_1.Enabled = true;
            }
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 183;
            this.Y = 720;
            this.Width = 402;
            this.Height = 112;
            this.TabOrder = 70;
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

      public class cb_5_type
         : Mobilize.Web.CommandButton, Iw_radio_buttonInner.Icb_5_type
      {

         public cb_5_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_radio_button Parent => (w_radio_button)base.Parent;

         public virtual int? Clicked()
         { //GetVisible

            bool? lb_visible = false;
            lb_visible = this.Parent.rb_1.Visible;
            //Change RadioButton Visible
            if ( (lb_visible) == true )
            {
               this.Parent.rb_1.Visible = false;
            }
            else
            {
               this.Parent.rb_1.Visible = true;
            }
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 695;
            this.Y = 716;
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

      public class cb_6_type
         : Mobilize.Web.CommandButton, Iw_radio_buttonInner.Icb_6_type
      {

         public cb_6_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_radio_button Parent => (w_radio_button)base.Parent;

         public virtual int? Clicked()
         { //GetText

            string s_radiobutton_text = "";
            s_radiobutton_text = this.Parent.rb_1.Text;
            //Change CheckBox Text
            if ( Mobilize.Web.Comparison.Equals(s_radiobutton_text, "Radio 1") == true )
            {
               this.Parent.rb_1.Text = "Test 1";
            }
            else
            {
               this.Parent.rb_1.Text = "Radio 1";
            }
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 1198;
            this.Y = 720;
            this.Width = 402;
            this.Height = 112;
            this.TabOrder = 60;
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

      public class cb_3_type
         : Mobilize.Web.CommandButton, Iw_radio_buttonInner.Icb_3_type
      {

         public cb_3_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_radio_button Parent => (w_radio_button)base.Parent;

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 1193;
            this.Y = 532;
            this.Width = 402;
            this.Height = 112;
            this.TabOrder = 40;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.Text = "Click";
         }

      }

      public class cb_1_type
         : Mobilize.Web.CommandButton, Iw_radio_buttonInner.Icb_1_type
      {

         public cb_1_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_radio_button Parent => (w_radio_button)base.Parent;

         public virtual int? Clicked()
         { //Change RadioButton Show/Hide

            if ( Mobilize.Web.Comparison.Equals(this.Parent.rb_1.Visible, true) == true )
            {
               this.Parent.rb_1.Hide();
            }
            else
            {
               this.Parent.rb_1.Show();
            }
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 178;
            this.Y = 532;
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

      public class cb_7_type
         : Mobilize.Web.CommandButton, Iw_radio_buttonInner.Icb_7_type
      {

         public cb_7_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_radio_button Parent => (w_radio_button)base.Parent;

         public virtual int? Clicked()
         { //GetRadioButtonState

            bool? lb_checked = false;
            lb_checked = this.Parent.rb_1.Checked;
            //ChangeCheckBoxState
            if ( (lb_checked) == true )
            {
               this.Parent.rb_1.Checked = false;
            }
            else
            {
               this.Parent.rb_1.Checked = true;
            }
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 695;
            this.Y = 532;
            this.Width = 402;
            this.Height = 112;
            this.TabOrder = 10;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.Text = "Checked";
            this.bnclicked = new Mobilize.Web.ClickedEventHandler(Clicked);
         }

      }

      public class rb_3_type
         : Mobilize.Web.RadioButton, Iw_radio_buttonInner.Irb_3_type
      {

         public rb_3_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_radio_button Parent => (w_radio_button)base.Parent;

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 1175;
            this.Y = 348;
            this.Width = 402;
            this.Height = 80;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.TextColor = 33554432;
            this.BackColor = 67108864;
            this.Text = "Radio 3";
         }

      }

      public class rb_2_type
         : Mobilize.Web.RadioButton, Iw_radio_buttonInner.Irb_2_type
      {

         public rb_2_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_radio_button Parent => (w_radio_button)base.Parent;

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 681;
            this.Y = 348;
            this.Width = 402;
            this.Height = 80;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.TextColor = 33554432;
            this.BackColor = 67108864;
            this.Text = "Radio 2";
         }

      }

      public class rb_1_type
         : Mobilize.Web.RadioButton, Iw_radio_buttonInner.Irb_1_type
      {

         public rb_1_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_radio_button Parent => (w_radio_button)base.Parent;

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
            this.X = 137;
            this.Y = 348;
            this.Width = 402;
            this.Height = 80;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.TextColor = 33554432;
            this.BackColor = 67108864;
            this.Text = "Radio 1";
            this.bnclicked = new Mobilize.Web.ClickedEventHandler(Clicked);
         }

      }

      public class gb_1_type
         : Mobilize.Web.GroupBox, Iw_radio_buttonInner.Igb_1_type
      {

         public gb_1_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_radio_button Parent => (w_radio_button)base.Parent;

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 133;
            this.Y = 40;
            this.Width = 1463;
            this.Height = 236;
            this.TabOrder = 20;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.TextColor = 33554432;
            this.BackColor = 67108864;
            this.Text = "RadioButton";
         }

      }

   }

}