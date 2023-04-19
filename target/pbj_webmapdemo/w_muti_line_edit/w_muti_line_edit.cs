namespace pbj_webmapdemo
{

   [Mobilize.WebMap.Common.Attributes.Observable]
   public partial class w_muti_line_edit
      : Mobilize.Web.Window, pbj_webmapdemo.Iw_muti_line_edit
   {

      public override void Create()
      {
         this.cb_4 = CreateInnerControl_cb_4_type();
         this.cb_5 = CreateInnerControl_cb_5_type();
         this.cb_6 = CreateInnerControl_cb_6_type();
         this.cb_3 = CreateInnerControl_cb_3_type();
         this.cb_1 = CreateInnerControl_cb_1_type();
         this.cb_7 = CreateInnerControl_cb_7_type();
         this.mle_1 = CreateInnerControl_mle_1_type();
         this.Control = Mobilize.Web.ArrayExtensions.Clone<Mobilize.Web.IControl>(new Mobilize.Web.IControl[] { this.cb_4, this.cb_5, this.cb_6, this.cb_3, this.cb_1, this.cb_7, this.mle_1 });
      }

      public override void Destroy()
      {
         this.cb_4 = null;
         this.cb_5 = null;
         this.cb_6 = null;
         this.cb_3 = null;
         this.cb_1 = null;
         this.cb_7 = null;
         this.mle_1 = null;
      }

      protected virtual Iw_muti_line_editInner.Icb_4_type CreateInnerControl_cb_4_type()
      {
         return Mobilize.Web.Application.Create<Iw_muti_line_editInner.Icb_4_type>(this);
      }

      protected virtual Iw_muti_line_editInner.Icb_5_type CreateInnerControl_cb_5_type()
      {
         return Mobilize.Web.Application.Create<Iw_muti_line_editInner.Icb_5_type>(this);
      }

      protected virtual Iw_muti_line_editInner.Icb_6_type CreateInnerControl_cb_6_type()
      {
         return Mobilize.Web.Application.Create<Iw_muti_line_editInner.Icb_6_type>(this);
      }

      protected virtual Iw_muti_line_editInner.Icb_3_type CreateInnerControl_cb_3_type()
      {
         return Mobilize.Web.Application.Create<Iw_muti_line_editInner.Icb_3_type>(this);
      }

      protected virtual Iw_muti_line_editInner.Icb_1_type CreateInnerControl_cb_1_type()
      {
         return Mobilize.Web.Application.Create<Iw_muti_line_editInner.Icb_1_type>(this);
      }

      protected virtual Iw_muti_line_editInner.Icb_7_type CreateInnerControl_cb_7_type()
      {
         return Mobilize.Web.Application.Create<Iw_muti_line_editInner.Icb_7_type>(this);
      }

      protected virtual Iw_muti_line_editInner.Imle_1_type CreateInnerControl_mle_1_type()
      {
         return Mobilize.Web.Application.Create<Iw_muti_line_editInner.Imle_1_type>(this);
      }

      public class cb_4_type
         : Mobilize.Web.CommandButton, Iw_muti_line_editInner.Icb_4_type
      {

         public cb_4_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_muti_line_edit Parent => (w_muti_line_edit)base.Parent;

         public virtual int? Clicked()
         {
            this.Parent.cb_4.Text = "Modified";
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 466;
            this.Y = 792;
            this.Width = 402;
            this.Height = 112;
            this.TabOrder = 60;
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

      public class cb_5_type
         : Mobilize.Web.CommandButton, Iw_muti_line_editInner.Icb_5_type
      {

         public cb_5_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_muti_line_edit Parent => (w_muti_line_edit)base.Parent;

         public virtual int? Clicked()
         { //GetEnabled

            bool? lb_enabled = false;
            lb_enabled = this.Parent.mle_1.Enabled;
            //Change MultiLineEdit ENABLED
            if ( (lb_enabled) == true )
            {
               this.Parent.mle_1.Enabled = false;
            }
            else
            {
               this.Parent.mle_1.Enabled = true;
            }
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 978;
            this.Y = 788;
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

      public class cb_6_type
         : Mobilize.Web.CommandButton, Iw_muti_line_editInner.Icb_6_type
      {

         public cb_6_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_muti_line_edit Parent => (w_muti_line_edit)base.Parent;

         public virtual int? Clicked()
         { //GetVisible

            bool? lb_visible = false;
            lb_visible = this.Parent.mle_1.Visible;
            //Change MultiLineEdit Visible
            if ( (lb_visible) == true )
            {
               this.Parent.mle_1.Visible = false;
            }
            else
            {
               this.Parent.mle_1.Visible = true;
            }
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 1504;
            this.Y = 796;
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

      public class cb_3_type
         : Mobilize.Web.CommandButton, Iw_muti_line_editInner.Icb_3_type
      {

         public cb_3_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_muti_line_edit Parent => (w_muti_line_edit)base.Parent;

         public virtual int? Clicked()
         {
            this.Parent.mle_1.ReplaceText("*NewText*");
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 1755;
            this.Y = 620;
            this.Width = 402;
            this.Height = 112;
            this.TabOrder = 40;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.Text = "ReplaceText";
            this.bnclicked = new Mobilize.Web.ClickedEventHandler(Clicked);
         }

      }

      public class cb_1_type
         : Mobilize.Web.CommandButton, Iw_muti_line_editInner.Icb_1_type
      {

         public cb_1_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_muti_line_edit Parent => (w_muti_line_edit)base.Parent;

         public virtual int? Clicked()
         { //Change CommandButton Show/Hide

            if ( Mobilize.Web.Comparison.Equals(this.Parent.mle_1.Visible, true) == true )
            {
               this.Parent.mle_1.Hide();
            }
            else
            {
               this.Parent.mle_1.Show();
            }
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 718;
            this.Y = 616;
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
         : Mobilize.Web.CommandButton, Iw_muti_line_editInner.Icb_7_type
      {

         public cb_7_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_muti_line_edit Parent => (w_muti_line_edit)base.Parent;

         public virtual int? Clicked()
         { //GetText

            string s_multiLineEdit = "";
            s_multiLineEdit = this.Parent.mle_1.Text;
            //Change MultiLineEdit Text
            if ( Mobilize.Web.Comparison.Equals(s_multiLineEdit, "Multi Line Edit") == true )
            {
               this.Parent.mle_1.Text = "Text Changed";
            }
            else
            {
               this.Parent.mle_1.Text = "Multi Line Edit";
            }
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 2030;
            this.Y = 788;
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

      public class mle_1_type
         : Mobilize.Web.MultiLineEdit, Iw_muti_line_editInner.Imle_1_type
      {

         public mle_1_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_muti_line_edit Parent => (w_muti_line_edit)base.Parent;

         public virtual int? modified()
         {
            this.Parent.cb_4.Text = "Modified=TRUE";
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 553;
            this.Y = 96;
            this.Width = 1851;
            this.Height = 408;
            this.TabOrder = 10;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.TextColor = 33554432;
            this.Text = "Multi Line Edit";
            this.BorderStyle = Mobilize.Web.BorderStyle.StyleLowered;
            ;
         }

      }

   }

}