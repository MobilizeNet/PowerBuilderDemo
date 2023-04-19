namespace pbj_webmapdemo
{

   [Mobilize.WebMap.Common.Attributes.Observable]
   public partial class w_check_box
      : Mobilize.Web.Window, pbj_webmapdemo.Iw_check_box
   {

      public override void Create()
      {
         this.cb_7 = CreateInnerControl_cb_7_type();
         this.cb_1 = CreateInnerControl_cb_1_type();
         this.cb_3 = CreateInnerControl_cb_3_type();
         this.cb_6 = CreateInnerControl_cb_6_type();
         this.cb_5 = CreateInnerControl_cb_5_type();
         this.cb_4 = CreateInnerControl_cb_4_type();
         this.cbx_2 = CreateInnerControl_cbx_2_type();
         this.cbx_1 = CreateInnerControl_cbx_1_type();
         this.Control = Mobilize.Web.ArrayExtensions.Clone<Mobilize.Web.IControl>(new Mobilize.Web.IControl[] { this.cb_7, this.cb_1, this.cb_3, this.cb_6, this.cb_5, this.cb_4, this.cbx_2, this.cbx_1 });
      }

      public override void Destroy()
      {
         this.cb_7 = null;
         this.cb_1 = null;
         this.cb_3 = null;
         this.cb_6 = null;
         this.cb_5 = null;
         this.cb_4 = null;
         this.cbx_2 = null;
         this.cbx_1 = null;
      }

      public virtual int? OpenWindow()
      { /****************************Properties*****************************/
         return null;
      //GetName
      //SetName
      }

      public override void DoWmInit()
      {
         base.DoWmInit();
         this.open = new Mobilize.Web.OpenWindowEventHandler(OpenWindow);
      }

      protected virtual Iw_check_boxInner.Icb_7_type CreateInnerControl_cb_7_type()
      {
         return Mobilize.Web.Application.Create<Iw_check_boxInner.Icb_7_type>(this);
      }

      protected virtual Iw_check_boxInner.Icb_1_type CreateInnerControl_cb_1_type()
      {
         return Mobilize.Web.Application.Create<Iw_check_boxInner.Icb_1_type>(this);
      }

      protected virtual Iw_check_boxInner.Icb_3_type CreateInnerControl_cb_3_type()
      {
         return Mobilize.Web.Application.Create<Iw_check_boxInner.Icb_3_type>(this);
      }

      protected virtual Iw_check_boxInner.Icb_6_type CreateInnerControl_cb_6_type()
      {
         return Mobilize.Web.Application.Create<Iw_check_boxInner.Icb_6_type>(this);
      }

      protected virtual Iw_check_boxInner.Icb_5_type CreateInnerControl_cb_5_type()
      {
         return Mobilize.Web.Application.Create<Iw_check_boxInner.Icb_5_type>(this);
      }

      protected virtual Iw_check_boxInner.Icb_4_type CreateInnerControl_cb_4_type()
      {
         return Mobilize.Web.Application.Create<Iw_check_boxInner.Icb_4_type>(this);
      }

      protected virtual Iw_check_boxInner.Icbx_2_type CreateInnerControl_cbx_2_type()
      {
         return Mobilize.Web.Application.Create<Iw_check_boxInner.Icbx_2_type>(this);
      }

      protected virtual Iw_check_boxInner.Icbx_1_type CreateInnerControl_cbx_1_type()
      {
         return Mobilize.Web.Application.Create<Iw_check_boxInner.Icbx_1_type>(this);
      }

      public class cb_7_type
         : Mobilize.Web.CommandButton, Iw_check_boxInner.Icb_7_type
      {

         public cb_7_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_check_box Parent => (w_check_box)base.Parent;

         public virtual int? Clicked()
         { //GetCheckBoxState

            bool? lb_checked = false;
            lb_checked = this.Parent.cbx_1.Checked;
            //ChangeCheckBoxState
            if ( (lb_checked) == true )
            {
               this.Parent.cbx_1.Checked = false;
            }
            else
            {
               this.Parent.cbx_1.Checked = true;
            }
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 681;
            this.Y = 536;
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

      public class cb_1_type
         : Mobilize.Web.CommandButton, Iw_check_boxInner.Icb_1_type
      {

         public cb_1_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_check_box Parent => (w_check_box)base.Parent;

         public virtual int? Clicked()
         { //Change CheckBox Show/Hide

            if ( Mobilize.Web.Comparison.Equals(this.Parent.cbx_1.Visible, true) == true )
            {
               this.Parent.cbx_1.Hide();
            }
            else
            {
               this.Parent.cbx_1.Show();
            }
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 165;
            this.Y = 536;
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

      public class cb_3_type
         : Mobilize.Web.CommandButton, Iw_check_boxInner.Icb_3_type
      {

         public cb_3_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_check_box Parent => (w_check_box)base.Parent;

         public virtual int? Clicked()
         { // This button changes text when the UAT control is clicked

            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 1179;
            this.Y = 536;
            this.Width = 402;
            this.Height = 112;
            this.TabOrder = 10;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.Text = "Click";
            this.bnclicked = new Mobilize.Web.ClickedEventHandler(Clicked);
         }

      }

      public class cb_6_type
         : Mobilize.Web.CommandButton, Iw_check_boxInner.Icb_6_type
      {

         public cb_6_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_check_box Parent => (w_check_box)base.Parent;

         public virtual int? Clicked()
         { //GetText

            string s_checkbox_text = "";
            s_checkbox_text = this.Parent.cbx_1.Text;
            //Change CheckBox Text
            if ( Mobilize.Web.Comparison.Equals(s_checkbox_text, "Box 1") == true )
            {
               this.Parent.cbx_1.Text = "Test 1";
            }
            else
            {
               this.Parent.cbx_1.Text = "Box 1";
            }
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 1184;
            this.Y = 724;
            this.Width = 402;
            this.Height = 112;
            this.TabOrder = 20;
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

      public class cb_5_type
         : Mobilize.Web.CommandButton, Iw_check_boxInner.Icb_5_type
      {

         public cb_5_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_check_box Parent => (w_check_box)base.Parent;

         public virtual int? Clicked()
         { //GetVisible

            bool? lb_visible = false;
            lb_visible = this.Parent.cbx_1.Visible;
            //Change CheckBox Visible
            if ( (lb_visible) == true )
            {
               this.Parent.cbx_1.Visible = false;
            }
            else
            {
               this.Parent.cbx_1.Visible = true;
            }
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 677;
            this.Y = 720;
            this.Width = 402;
            this.Height = 112;
            this.TabOrder = 10;
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

      public class cb_4_type
         : Mobilize.Web.CommandButton, Iw_check_boxInner.Icb_4_type
      {

         public cb_4_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_check_box Parent => (w_check_box)base.Parent;

         public virtual int? Clicked()
         { //GetEnabled

            bool? lb_enabled = false;
            lb_enabled = this.Parent.cbx_1.Enabled;
            //Change CheckBox ENABLED
            if ( (lb_enabled) == true )
            {
               this.Parent.cbx_1.Enabled = false;
            }
            else
            {
               this.Parent.cbx_1.Enabled = true;
            }
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 169;
            this.Y = 724;
            this.Width = 402;
            this.Height = 112;
            this.TabOrder = 10;
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

      public class cbx_2_type
         : Mobilize.Web.CheckBox, Iw_check_boxInner.Icbx_2_type
      {

         public cbx_2_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_check_box Parent => (w_check_box)base.Parent;

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 969;
            this.Y = 180;
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
            this.Text = "Box 2";
         }

      }

      public class cbx_1_type
         : Mobilize.Web.CheckBox, Iw_check_boxInner.Icbx_1_type
      {

         public cbx_1_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_check_box Parent => (w_check_box)base.Parent;

         public virtual int? Clicked()
         { //GetCheckBoxState

            bool? lb_checked = false;
            lb_checked = this.Parent.cbx_1.Checked;
            //ChangeCheckBoxState
            if ( (lb_checked) == true )
            {
               this.Parent.cb_3.Text = "Checked";
            }
            else
            {
               this.Parent.cb_3.Text = "Unchecked";
            }
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 315;
            this.Y = 188;
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
            this.Text = "Box 1";
            this.bnclicked = new Mobilize.Web.ClickedEventHandler(Clicked);
         }

      }

   }

}