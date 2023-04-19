namespace multicontroldemo
{

   [Mobilize.WebMap.Common.Attributes.Observable]
   public partial class w_dw_control_sampler_events
      : Mobilize.Web.Window, multicontroldemo.Iw_dw_control_sampler_events
   {

      public override void Create()
      {
         this.cb_3 = CreateInnerControl_cb_3_type();
         this.cb_2 = CreateInnerControl_cb_2_type();
         this.cb_1 = CreateInnerControl_cb_1_type();
         this.mle_log = CreateInnerControl_mle_log_type();
         this.dw_1 = CreateInnerControl_dw_1_type();
         this.Control = Mobilize.Web.ArrayExtensions.Clone<Mobilize.Web.IControl>(new Mobilize.Web.IControl[] { this.cb_3, this.cb_2, this.cb_1, this.mle_log, this.dw_1 });
      }

      public override void Destroy()
      {
         this.cb_3 = null;
         this.cb_2 = null;
         this.cb_1 = null;
         this.mle_log = null;
         this.dw_1 = null;
      }

      public virtual short? log(string message_txt)
      {
         if ( Mobilize.Web.BuiltInExtensions.IsNull(message_txt) == true )
         {
            message_txt = "<NULL>";
         }
         this.mle_log.Text = Mobilize.Web.PlusFunctions.Plus(Mobilize.Web.PlusFunctions.Plus(message_txt, "\r\n"), this.mle_log.Text);
         return 1;
      }

      public virtual string getcurrentcolumnvalue()
      {
         string old_data = "";
         old_data = "";
         if ( (this.dw_1.GetRow() > 0 & this.dw_1.GetColumn() > 0) == true )
         {
            old_data = this.dw_1.Describe(Mobilize.Web.PlusFunctions.Plus(Mobilize.Web.PlusFunctions.Plus(Mobilize.Web.PlusFunctions.Plus(Mobilize.Web.PlusFunctions.Plus("evaluate('#", Mobilize.Web.CaseExtensions.String(this.dw_1.GetColumn())), "',"), Mobilize.Web.CaseExtensions.String(this.dw_1.GetRow())), ")"));
            if ( (Mobilize.Web.BuiltInExtensions.IsNull(old_data) | Mobilize.Web.Comparison.Equals(old_data, "!")) == true )
            {
               old_data = "";
            }
         }
         return old_data;
      }

      public virtual int? OpenWindow()
      {
         this.dw_1.InsertRow(0);
         return null;
      }

      public override void DoWmInit()
      {
         base.DoWmInit();
         this.open = new Mobilize.Web.OpenWindowEventHandler(OpenWindow);
      }

      protected virtual Iw_dw_control_sampler_eventsInner.Icb_3_type CreateInnerControl_cb_3_type()
      {
         return Mobilize.Web.Application.Create<Iw_dw_control_sampler_eventsInner.Icb_3_type>(this);
      }

      protected virtual Iw_dw_control_sampler_eventsInner.Icb_2_type CreateInnerControl_cb_2_type()
      {
         return Mobilize.Web.Application.Create<Iw_dw_control_sampler_eventsInner.Icb_2_type>(this);
      }

      protected virtual Iw_dw_control_sampler_eventsInner.Icb_1_type CreateInnerControl_cb_1_type()
      {
         return Mobilize.Web.Application.Create<Iw_dw_control_sampler_eventsInner.Icb_1_type>(this);
      }

      protected virtual Iw_dw_control_sampler_eventsInner.Imle_log_type CreateInnerControl_mle_log_type()
      {
         return Mobilize.Web.Application.Create<Iw_dw_control_sampler_eventsInner.Imle_log_type>(this);
      }

      protected virtual Iw_dw_control_sampler_eventsInner.Idw_1_type CreateInnerControl_dw_1_type()
      {
         return Mobilize.Web.Application.Create<Iw_dw_control_sampler_eventsInner.Idw_1_type>(this);
      }

      public class cb_3_type
         : Mobilize.Web.CommandButton, Iw_dw_control_sampler_eventsInner.Icb_3_type
      {

         public cb_3_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_dw_control_sampler_events Parent => (w_dw_control_sampler_events)base.Parent;

         public virtual int? Clicked()
         {
            Parent.log(Mobilize.Web.PlusFunctions.Plus(Mobilize.Web.PlusFunctions.Plus("Curr col val: '", this.Parent.getcurrentcolumnvalue()), "'"));
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 1056;
            this.Y = 1412;
            this.Width = 713;
            this.Height = 112;
            this.TabOrder = 50;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.Text = "Get current row col value";
            this.bnclicked = new Mobilize.Web.ClickedEventHandler(Clicked);
         }

      }

      public class cb_2_type
         : Mobilize.Web.CommandButton, Iw_dw_control_sampler_eventsInner.Icb_2_type
      {

         public cb_2_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_dw_control_sampler_events Parent => (w_dw_control_sampler_events)base.Parent;

         public virtual int? Clicked()
         {
            Parent.log("GetText() = " + Mobilize.Web.CaseExtensions.String(this.Parent.dw_1.GetText()));
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 553;
            this.Y = 1408;
            this.Width = 402;
            this.Height = 112;
            this.TabOrder = 40;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.Text = "GetText";
            this.bnclicked = new Mobilize.Web.ClickedEventHandler(Clicked);
         }

      }

      public class cb_1_type
         : Mobilize.Web.CommandButton, Iw_dw_control_sampler_eventsInner.Icb_1_type
      {

         public cb_1_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_dw_control_sampler_events Parent => (w_dw_control_sampler_events)base.Parent;

         public virtual int? Clicked()
         {
            this.Parent.dw_1.AcceptText();
            Parent.log("Accept text");
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 59;
            this.Y = 1400;
            this.Width = 402;
            this.Height = 112;
            this.TabOrder = 30;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.Text = "AcceptText";
            this.bnclicked = new Mobilize.Web.ClickedEventHandler(Clicked);
         }

      }

      public class mle_log_type
         : Mobilize.Web.MultiLineEdit, Iw_dw_control_sampler_eventsInner.Imle_log_type
      {

         public mle_log_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_dw_control_sampler_events Parent => (w_dw_control_sampler_events)base.Parent;

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 2363;
            this.Y = 64;
            this.Width = 1289;
            this.Height = 1296;
            this.TabOrder = 20;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.TextColor = 33554432;
            this.Text = "start";
            this.VScrollBar = true;
            this.BorderStyle = Mobilize.Web.BorderStyle.StyleLowered;
         }

      }

      public class dw_1_type
         : Mobilize.Web.DataManagerControl, Iw_dw_control_sampler_eventsInner.Idw_1_type
      {

         public dw_1_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_dw_control_sampler_events Parent => (w_dw_control_sampler_events)base.Parent;

         public virtual short? ItemChanged(int? row, Mobilize.Web.IDmControl dwo, string data)
         {
            string old_data = "";
            old_data = Parent.getcurrentcolumnvalue();
            Parent.log(Mobilize.Web.PlusFunctions.Plus(Mobilize.Web.PlusFunctions.Plus(Mobilize.Web.PlusFunctions.Plus(Mobilize.Web.PlusFunctions.Plus(Mobilize.Web.PlusFunctions.Plus(Mobilize.Web.PlusFunctions.Plus("ItemChanged: row=", Mobilize.Web.CaseExtensions.String(row)), " - "), Mobilize.Web.CaseExtensions.String(data)), " - '"), old_data), "'"));
            return null;
         }

         public virtual short? ItemFocusChanged(int? row, Mobilize.Web.IDmControl dwo)
         {
            string old_data = "";
            old_data = Parent.getcurrentcolumnvalue();
            Parent.log(Mobilize.Web.PlusFunctions.Plus(Mobilize.Web.PlusFunctions.Plus(Mobilize.Web.PlusFunctions.Plus(Mobilize.Web.PlusFunctions.Plus("ItemFocusChanged: row=", Mobilize.Web.CaseExtensions.String(row)), " cur val: '"), old_data), "'"));
            return null;
         }

         public virtual short? RowFocusChanged(int? currentrow)
         {
            string old_data = "";
            old_data = Parent.getcurrentcolumnvalue();
            Parent.log(Mobilize.Web.PlusFunctions.Plus(Mobilize.Web.PlusFunctions.Plus(Mobilize.Web.PlusFunctions.Plus(Mobilize.Web.PlusFunctions.Plus("RowFocusChanged: row=", Mobilize.Web.CaseExtensions.String(currentrow)), " cur val: '"), old_data), "'"));
            return null;
         }

         public virtual short? RowFocusChanging(int? currentrow, int? newrow)
         {
            string old_data = "";
            old_data = Parent.getcurrentcolumnvalue();
            Parent.log(Mobilize.Web.PlusFunctions.Plus(Mobilize.Web.PlusFunctions.Plus(Mobilize.Web.PlusFunctions.Plus(Mobilize.Web.PlusFunctions.Plus(Mobilize.Web.PlusFunctions.Plus(Mobilize.Web.PlusFunctions.Plus("RowFocusChanging: row=", Mobilize.Web.CaseExtensions.String(currentrow)), " newrow:"), Mobilize.Web.CaseExtensions.String(newrow)), " cur val: '"), old_data), "'"));
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 55;
            this.Y = 56;
            this.Width = 2258;
            this.Height = 1296;
            this.TabOrder = 10;
            this.Title = "none";
            this.DataObject = "d_dw_control_sampler";
            this.HScrollBar = true;
            this.VScrollBar = true;
            this.LiveScroll = true;
            this.BorderStyle = Mobilize.Web.BorderStyle.StyleLowered;
            this.dwnitemchange = new Mobilize.Web.DataManagerItemChangedEventHandler(ItemChanged);
            this.dwnitemchangefocus = new Mobilize.Web.ItemFocusChangedEventHandler(ItemFocusChanged);
            this.dwnrowchange = new Mobilize.Web.RowFocusChangedEventHandler(RowFocusChanged);
            this.dwnrowchanging = new Mobilize.Web.RowFocusChangingEventHandler(RowFocusChanging);
         }

      }

   }

}