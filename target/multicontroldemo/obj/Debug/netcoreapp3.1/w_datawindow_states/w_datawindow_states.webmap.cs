#pragma warning disable
#line 1 "w_datawindow_states\\w_datawindow_states.cs"
#pragma warning disable
#line 1 "w_datawindow_states\\w_datawindow_states.cs"
namespace multicontroldemo
{

   [Mobilize.WebMap.Common.Attributes.Observable]
   public partial class w_datawindow_states
      : Mobilize.Web.Window, multicontroldemo.Iw_datawindow_states
   {

      public override void Create()
      {
         this.cb_9 = CreateInnerControl_cb_9_type();
         this.cb_8 = CreateInnerControl_cb_8_type();
         this.cb_7 = CreateInnerControl_cb_7_type();
         this.cb_6 = CreateInnerControl_cb_6_type();
         this.cb_5 = CreateInnerControl_cb_5_type();
         this.cb_4 = CreateInnerControl_cb_4_type();
         this.cb_3 = CreateInnerControl_cb_3_type();
         this.mle_1 = CreateInnerControl_mle_1_type();
         this.cb_2 = CreateInnerControl_cb_2_type();
         this.cb_1 = CreateInnerControl_cb_1_type();
         this.dw_1 = CreateInnerControl_dw_1_type();
         this.Control = Mobilize.Web.ArrayExtensions.Clone<Mobilize.Web.IControl>(new Mobilize.Web.IControl[] { this.cb_9, this.cb_8, this.cb_7, this.cb_6, this.cb_5, this.cb_4, this.cb_3, this.mle_1, this.cb_2, this.cb_1, this.dw_1 });
      }

      public override void Destroy()
      {
         this.cb_9 = null;
         this.cb_8 = null;
         this.cb_7 = null;
         this.cb_6 = null;
         this.cb_5 = null;
         this.cb_4 = null;
         this.cb_3 = null;
         this.mle_1 = null;
         this.cb_2 = null;
         this.cb_1 = null;
         this.dw_1 = null;
      }

      public virtual void log(string _text)
      {
         if ( Mobilize.Web.Comparison.Equals(this.mle_1.Text, "") == true )
         {
            this.mle_1.Text = _text;
         }
         else
         {
            this.mle_1.Text = Mobilize.Web.PlusFunctions.Plus(Mobilize.Web.PlusFunctions.Plus(this.mle_1.Text, "\r\n"), _text);
         }
      }

      public virtual string textornull(string _text)
      {
         if ( Mobilize.Web.BuiltInExtensions.IsNull(_text) == true )
         {
            return "null";
         }
         return _text;
      }

      protected virtual Iw_datawindow_statesInner.Icb_9_type CreateInnerControl_cb_9_type()
      {
         return Mobilize.Web.Application.Create<Iw_datawindow_statesInner.Icb_9_type>(this);
      }

      protected virtual Iw_datawindow_statesInner.Icb_8_type CreateInnerControl_cb_8_type()
      {
         return Mobilize.Web.Application.Create<Iw_datawindow_statesInner.Icb_8_type>(this);
      }

      protected virtual Iw_datawindow_statesInner.Icb_7_type CreateInnerControl_cb_7_type()
      {
         return Mobilize.Web.Application.Create<Iw_datawindow_statesInner.Icb_7_type>(this);
      }

      protected virtual Iw_datawindow_statesInner.Icb_6_type CreateInnerControl_cb_6_type()
      {
         return Mobilize.Web.Application.Create<Iw_datawindow_statesInner.Icb_6_type>(this);
      }

      protected virtual Iw_datawindow_statesInner.Icb_5_type CreateInnerControl_cb_5_type()
      {
         return Mobilize.Web.Application.Create<Iw_datawindow_statesInner.Icb_5_type>(this);
      }

      protected virtual Iw_datawindow_statesInner.Icb_4_type CreateInnerControl_cb_4_type()
      {
         return Mobilize.Web.Application.Create<Iw_datawindow_statesInner.Icb_4_type>(this);
      }

      protected virtual Iw_datawindow_statesInner.Icb_3_type CreateInnerControl_cb_3_type()
      {
         return Mobilize.Web.Application.Create<Iw_datawindow_statesInner.Icb_3_type>(this);
      }

      protected virtual Iw_datawindow_statesInner.Imle_1_type CreateInnerControl_mle_1_type()
      {
         return Mobilize.Web.Application.Create<Iw_datawindow_statesInner.Imle_1_type>(this);
      }

      protected virtual Iw_datawindow_statesInner.Icb_2_type CreateInnerControl_cb_2_type()
      {
         return Mobilize.Web.Application.Create<Iw_datawindow_statesInner.Icb_2_type>(this);
      }

      protected virtual Iw_datawindow_statesInner.Icb_1_type CreateInnerControl_cb_1_type()
      {
         return Mobilize.Web.Application.Create<Iw_datawindow_statesInner.Icb_1_type>(this);
      }

      protected virtual Iw_datawindow_statesInner.Idw_1_type CreateInnerControl_dw_1_type()
      {
         return Mobilize.Web.Application.Create<Iw_datawindow_statesInner.Idw_1_type>(this);
      }

      public partial class cb_9_type
         : Mobilize.Web.CommandButton, Iw_datawindow_statesInner.Icb_9_type
      {

         public cb_9_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_datawindow_states Parent => (w_datawindow_states)base.Parent;

         public virtual int? Clicked()
         {
            this.Parent.dw_1.SetSort("field1 A");
            this.Parent.dw_1.Sort();
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 1646;
            this.Y = 976;
            this.Width = 402;
            this.Height = 112;
            this.TabOrder = 80;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.Text = "Sort";
            this.bnclicked = new Mobilize.Web.ClickedEventHandler(Clicked);
         }

      }

      public partial class cb_8_type
         : Mobilize.Web.CommandButton, Iw_datawindow_statesInner.Icb_8_type
      {

         public cb_8_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_datawindow_states Parent => (w_datawindow_states)base.Parent;

         public virtual int? Clicked()
         {
            this.Parent.dw_1.DataObject = "d_with_data";
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 1641;
            this.Y = 212;
            this.Width = 759;
            this.Height = 104;
            this.TabOrder = 50;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Roman;
            this.FaceName = "Times New Roman";
            this.Text = "Load DataObject (With Data)";
            this.bnclicked = new Mobilize.Web.ClickedEventHandler(Clicked);
         }

      }

      public partial class cb_7_type
         : Mobilize.Web.CommandButton, Iw_datawindow_statesInner.Icb_7_type
      {

         public cb_7_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_datawindow_states Parent => (w_datawindow_states)base.Parent;

         public virtual int? Clicked()
         {
            this.Parent.mle_1.Text = "";
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 4005;
            this.Y = 96;
            this.Width = 343;
            this.Height = 104;
            this.TabOrder = 40;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Roman;
            this.FaceName = "Times New Roman";
            this.Text = "Clear";
            this.bnclicked = new Mobilize.Web.ClickedEventHandler(Clicked);
         }

      }

      public partial class cb_6_type
         : Mobilize.Web.CommandButton, Iw_datawindow_statesInner.Icb_6_type
      {

         public cb_6_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_datawindow_states Parent => (w_datawindow_states)base.Parent;

         public virtual int? Clicked()
         {
            Parent.log(Mobilize.Web.PlusFunctions.Plus("CurrentText = ", Parent.textornull(Mobilize.Web.CaseExtensions.String(this.Parent.dw_1.GetText()))));
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 1641;
            this.Y = 856;
            this.Width = 343;
            this.Height = 104;
            this.TabOrder = 70;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Roman;
            this.FaceName = "Times New Roman";
            this.Text = "CurrentText";
            this.bnclicked = new Mobilize.Web.ClickedEventHandler(Clicked);
         }

      }

      public partial class cb_5_type
         : Mobilize.Web.CommandButton, Iw_datawindow_statesInner.Icb_5_type
      {

         public cb_5_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_datawindow_states Parent => (w_datawindow_states)base.Parent;

         public virtual int? Clicked()
         {
            Parent.log(Mobilize.Web.PlusFunctions.Plus("CurrentColumnName = ", Parent.textornull(this.Parent.dw_1.GetColumnName())));
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 1641;
            this.Y = 732;
            this.Width = 553;
            this.Height = 104;
            this.TabOrder = 60;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Roman;
            this.FaceName = "Times New Roman";
            this.Text = "CurrentColumnName";
            this.bnclicked = new Mobilize.Web.ClickedEventHandler(Clicked);
         }

      }

      public partial class cb_4_type
         : Mobilize.Web.CommandButton, Iw_datawindow_statesInner.Icb_4_type
      {

         public cb_4_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_datawindow_states Parent => (w_datawindow_states)base.Parent;

         public virtual int? Clicked()
         {
            Parent.log(Mobilize.Web.PlusFunctions.Plus("CurrentRow = ", Parent.textornull(Mobilize.Web.CaseExtensions.String(this.Parent.dw_1.GetRow()))));
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 1641;
            this.Y = 604;
            this.Width = 343;
            this.Height = 104;
            this.TabOrder = 50;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Roman;
            this.FaceName = "Times New Roman";
            this.Text = "CurrentRow";
            this.bnclicked = new Mobilize.Web.ClickedEventHandler(Clicked);
         }

      }

      public partial class cb_3_type
         : Mobilize.Web.CommandButton, Iw_datawindow_statesInner.Icb_3_type
      {

         public cb_3_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_datawindow_states Parent => (w_datawindow_states)base.Parent;

         public virtual int? Clicked()
         {
            Parent.log(Mobilize.Web.PlusFunctions.Plus("CurrentColumn = ", Parent.textornull(Mobilize.Web.CaseExtensions.String(this.Parent.dw_1.GetColumn()))));
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 1641;
            this.Y = 472;
            this.Width = 416;
            this.Height = 104;
            this.TabOrder = 40;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Roman;
            this.FaceName = "Times New Roman";
            this.Text = "CurrentColumn";
            this.bnclicked = new Mobilize.Web.ClickedEventHandler(Clicked);
         }

      }

      public partial class mle_1_type
         : Mobilize.Web.MultiLineEdit, Iw_datawindow_statesInner.Imle_1_type
      {

         public mle_1_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_datawindow_states Parent => (w_datawindow_states)base.Parent;

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 2519;
            this.Y = 92;
            this.Width = 1449;
            this.Height = 1672;
            this.TabOrder = 30;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.TextColor = 33554432;
            this.BorderStyle = Mobilize.Web.BorderStyle.StyleLowered;
         }

      }

      public partial class cb_2_type
         : Mobilize.Web.CommandButton, Iw_datawindow_statesInner.Icb_2_type
      {

         public cb_2_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_datawindow_states Parent => (w_datawindow_states)base.Parent;

         public virtual int? Clicked()
         {
            this.Parent.dw_1.InsertRow(0);
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 1641;
            this.Y = 332;
            this.Width = 343;
            this.Height = 104;
            this.TabOrder = 30;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Roman;
            this.FaceName = "Times New Roman";
            this.Text = "InsertRow";
            this.bnclicked = new Mobilize.Web.ClickedEventHandler(Clicked);
         }

      }

      public partial class cb_1_type
         : Mobilize.Web.CommandButton, Iw_datawindow_statesInner.Icb_1_type
      {

         public cb_1_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_datawindow_states Parent => (w_datawindow_states)base.Parent;

         public virtual int? Clicked()
         {
            this.Parent.dw_1.DataObject = "d_no_data";
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 1641;
            this.Y = 92;
            this.Width = 699;
            this.Height = 104;
            this.TabOrder = 20;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Roman;
            this.FaceName = "Times New Roman";
            this.Text = "Load DataObject (No data)";
            this.bnclicked = new Mobilize.Web.ClickedEventHandler(Clicked);
         }

      }

      public partial class dw_1_type
         : Mobilize.Web.DataManagerControl, Iw_datawindow_statesInner.Idw_1_type
      {

         public dw_1_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_datawindow_states Parent => (w_datawindow_states)base.Parent;

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 101;
            this.Y = 88;
            this.Width = 1440;
            this.Height = 1684;
            this.TabOrder = 10;
            this.Title = "none";
            this.LiveScroll = true;
            this.BorderStyle = Mobilize.Web.BorderStyle.StyleLowered;
         }

      }

   }

}
#pragma warning restore
