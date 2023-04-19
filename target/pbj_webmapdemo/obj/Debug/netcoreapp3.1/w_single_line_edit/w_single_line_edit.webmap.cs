#pragma warning disable
#line 1 "w_single_line_edit\\w_single_line_edit.cs"
#pragma warning disable
#line 1 "w_single_line_edit\\w_single_line_edit.cs"
namespace pbj_webmapdemo
{

   [Mobilize.WebMap.Common.Attributes.Observable]
   public partial class w_single_line_edit
      : Mobilize.Web.Window, pbj_webmapdemo.Iw_single_line_edit
   {

      public override void Create()
      {
         this.cb_4 = CreateInnerControl_cb_4_type();
         this.cb_5 = CreateInnerControl_cb_5_type();
         this.cb_6 = CreateInnerControl_cb_6_type();
         this.cb_3 = CreateInnerControl_cb_3_type();
         this.cb_1 = CreateInnerControl_cb_1_type();
         this.sle_1 = CreateInnerControl_sle_1_type();
         this.Control = Mobilize.Web.ArrayExtensions.Clone<Mobilize.Web.IControl>(new Mobilize.Web.IControl[] { this.cb_4, this.cb_5, this.cb_6, this.cb_3, this.cb_1, this.sle_1 });
      }

      public override void Destroy()
      {
         this.cb_4 = null;
         this.cb_5 = null;
         this.cb_6 = null;
         this.cb_3 = null;
         this.cb_1 = null;
         this.sle_1 = null;
      }

      protected virtual Iw_single_line_editInner.Icb_4_type CreateInnerControl_cb_4_type()
      {
         return Mobilize.Web.Application.Create<Iw_single_line_editInner.Icb_4_type>(this);
      }

      protected virtual Iw_single_line_editInner.Icb_5_type CreateInnerControl_cb_5_type()
      {
         return Mobilize.Web.Application.Create<Iw_single_line_editInner.Icb_5_type>(this);
      }

      protected virtual Iw_single_line_editInner.Icb_6_type CreateInnerControl_cb_6_type()
      {
         return Mobilize.Web.Application.Create<Iw_single_line_editInner.Icb_6_type>(this);
      }

      protected virtual Iw_single_line_editInner.Icb_3_type CreateInnerControl_cb_3_type()
      {
         return Mobilize.Web.Application.Create<Iw_single_line_editInner.Icb_3_type>(this);
      }

      protected virtual Iw_single_line_editInner.Icb_1_type CreateInnerControl_cb_1_type()
      {
         return Mobilize.Web.Application.Create<Iw_single_line_editInner.Icb_1_type>(this);
      }

      protected virtual Iw_single_line_editInner.Isle_1_type CreateInnerControl_sle_1_type()
      {
         return Mobilize.Web.Application.Create<Iw_single_line_editInner.Isle_1_type>(this);
      }

      public partial class cb_4_type
         : Mobilize.Web.CommandButton, Iw_single_line_editInner.Icb_4_type
      {

         public cb_4_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_single_line_edit Parent => (w_single_line_edit)base.Parent;

         public virtual int? Clicked()
         { //GetEnabled

            bool? lb_enabled = false;
            lb_enabled = this.Parent.sle_1.Enabled;
            //Change SingleLineEdit ENABLED
            if ( (lb_enabled) == true )
            {
               this.Parent.sle_1.Enabled = false;
            }
            else
            {
               this.Parent.sle_1.Enabled = true;
            }
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 123;
            this.Y = 576;
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

      public partial class cb_5_type
         : Mobilize.Web.CommandButton, Iw_single_line_editInner.Icb_5_type
      {

         public cb_5_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_single_line_edit Parent => (w_single_line_edit)base.Parent;

         public virtual int? Clicked()
         { //GetVisible

            bool? lb_visible = false;
            lb_visible = this.Parent.sle_1.Visible;
            //Change SingleLineEdit Visible
            if ( (lb_visible) == true )
            {
               this.Parent.sle_1.Visible = false;
            }
            else
            {
               this.Parent.sle_1.Visible = true;
            }
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 635;
            this.Y = 572;
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

      public partial class cb_6_type
         : Mobilize.Web.CommandButton, Iw_single_line_editInner.Icb_6_type
      {

         public cb_6_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_single_line_edit Parent => (w_single_line_edit)base.Parent;

         public virtual int? Clicked()
         { //GetText

            string s_singleLineEdit_text = "";
            s_singleLineEdit_text = this.Parent.sle_1.Text;
            //Change SingleLineEdit Text
            if ( Mobilize.Web.Comparison.Equals(s_singleLineEdit_text, "") == true )
            {
               this.Parent.sle_1.Text = "Text Changed";
            }
            else
            {
               this.Parent.sle_1.Text = "";
            }
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 1138;
            this.Y = 576;
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

      public partial class cb_3_type
         : Mobilize.Web.CommandButton, Iw_single_line_editInner.Icb_3_type
      {

         public cb_3_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_single_line_edit Parent => (w_single_line_edit)base.Parent;

         public virtual int? Clicked()
         {
            this.Parent.cb_3.Text = "Modified";
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 1134;
            this.Y = 388;
            this.Width = 402;
            this.Height = 112;
            this.TabOrder = 40;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.Text = "Modified";
            this.bnclicked = new Mobilize.Web.ClickedEventHandler(Clicked);
         }

      }

      public partial class cb_1_type
         : Mobilize.Web.CommandButton, Iw_single_line_editInner.Icb_1_type
      {

         public cb_1_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_single_line_edit Parent => (w_single_line_edit)base.Parent;

         public virtual int? Clicked()
         { //Change SingleLineEdit Show/Hide

            if ( Mobilize.Web.Comparison.Equals(this.Parent.sle_1.Visible, true) == true )
            {
               this.Parent.sle_1.Hide();
            }
            else
            {
               this.Parent.sle_1.Show();
            }
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 119;
            this.Y = 388;
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

      public partial class sle_1_type
         : Mobilize.Web.SingleLineEdit, Iw_single_line_editInner.Isle_1_type
      {

         public sle_1_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_single_line_edit Parent => (w_single_line_edit)base.Parent;

         public virtual int? Modified()
         {
            this.Parent.cb_3.Text = "Modified=True";
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 151;
            this.Y = 128;
            this.Width = 1371;
            this.Height = 120;
            this.TabOrder = 10;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.TextColor = 33554432;
            this.BorderStyle = Mobilize.Web.BorderStyle.StyleLowered;
            this.enmodified = new Mobilize.Web.ModifiedEventHandler(Modified);
         }

      }

   }

}
#pragma warning restore
