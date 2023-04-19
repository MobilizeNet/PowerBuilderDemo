#pragma warning disable
#line 1 "w_allinformation\\w_allinformation.cs"
#pragma warning disable
#line 1 "w_allinformation\\w_allinformation.cs"
namespace multicontroldemo
{

   [Mobilize.WebMap.Common.Attributes.Observable]
   public partial class w_allinformation
      : Mobilize.Web.Window, multicontroldemo.Iw_allinformation
   {

      public override void Create()
      {
         this.cb_1 = CreateInnerControl_cb_1_type();
         this.sle_1 = CreateInnerControl_sle_1_type();
         this.cb_insert_details = CreateInnerControl_cb_insert_details_type();
         this.cb_get_text_details = CreateInnerControl_cb_get_text_details_type();
         this.cb_insertrow = CreateInnerControl_cb_insertrow_type();
         this.cb_gettext = CreateInnerControl_cb_gettext_type();
         this.cb_clear = CreateInnerControl_cb_clear_type();
         this.mle_log = CreateInnerControl_mle_log_type();
         this.dw_additional_info = CreateInnerControl_dw_additional_info_type();
         this.dw_main_info = CreateInnerControl_dw_main_info_type();
         this.gb_main = CreateInnerControl_gb_main_type();
         this.gb_details = CreateInnerControl_gb_details_type();
         this.Control = Mobilize.Web.ArrayExtensions.Clone<Mobilize.Web.IControl>(new Mobilize.Web.IControl[] { this.cb_1, this.sle_1, this.cb_insert_details, this.cb_get_text_details, this.cb_insertrow, this.cb_gettext, this.cb_clear, this.mle_log, this.dw_additional_info, this.dw_main_info, this.gb_main, this.gb_details });
      }

      public override void Destroy()
      {
         this.cb_1 = null;
         this.sle_1 = null;
         this.cb_insert_details = null;
         this.cb_get_text_details = null;
         this.cb_insertrow = null;
         this.cb_gettext = null;
         this.cb_clear = null;
         this.mle_log = null;
         this.dw_additional_info = null;
         this.dw_main_info = null;
         this.gb_main = null;
         this.gb_details = null;
      }

      public virtual short? logaction(string arg)
      {
         this.mle_log.Text = Mobilize.Web.PlusFunctions.Plus(Mobilize.Web.PlusFunctions.Plus(arg, "\r\n"), this.mle_log.Text);
         return 1;
      }

      public virtual short? modifydatawindow(string mask)
      { //dw_allcontrols_one.modify("dist_code.EditMask.Mask = '" + mask + "'")

         return 1;
      }

      protected virtual Iw_allinformationInner.Icb_1_type CreateInnerControl_cb_1_type()
      {
         return Mobilize.Web.Application.Create<Iw_allinformationInner.Icb_1_type>(this);
      }

      protected virtual Iw_allinformationInner.Isle_1_type CreateInnerControl_sle_1_type()
      {
         return Mobilize.Web.Application.Create<Iw_allinformationInner.Isle_1_type>(this);
      }

      protected virtual Iw_allinformationInner.Icb_insert_details_type CreateInnerControl_cb_insert_details_type()
      {
         return Mobilize.Web.Application.Create<Iw_allinformationInner.Icb_insert_details_type>(this);
      }

      protected virtual Iw_allinformationInner.Icb_get_text_details_type CreateInnerControl_cb_get_text_details_type()
      {
         return Mobilize.Web.Application.Create<Iw_allinformationInner.Icb_get_text_details_type>(this);
      }

      protected virtual Iw_allinformationInner.Icb_insertrow_type CreateInnerControl_cb_insertrow_type()
      {
         return Mobilize.Web.Application.Create<Iw_allinformationInner.Icb_insertrow_type>(this);
      }

      protected virtual Iw_allinformationInner.Icb_gettext_type CreateInnerControl_cb_gettext_type()
      {
         return Mobilize.Web.Application.Create<Iw_allinformationInner.Icb_gettext_type>(this);
      }

      protected virtual Iw_allinformationInner.Icb_clear_type CreateInnerControl_cb_clear_type()
      {
         return Mobilize.Web.Application.Create<Iw_allinformationInner.Icb_clear_type>(this);
      }

      protected virtual Iw_allinformationInner.Imle_log_type CreateInnerControl_mle_log_type()
      {
         return Mobilize.Web.Application.Create<Iw_allinformationInner.Imle_log_type>(this);
      }

      protected virtual Iw_allinformationInner.Idw_additional_info_type CreateInnerControl_dw_additional_info_type()
      {
         return Mobilize.Web.Application.Create<Iw_allinformationInner.Idw_additional_info_type>(this);
      }

      protected virtual Iw_allinformationInner.Idw_main_info_type CreateInnerControl_dw_main_info_type()
      {
         return Mobilize.Web.Application.Create<Iw_allinformationInner.Idw_main_info_type>(this);
      }

      protected virtual Iw_allinformationInner.Igb_main_type CreateInnerControl_gb_main_type()
      {
         return Mobilize.Web.Application.Create<Iw_allinformationInner.Igb_main_type>(this);
      }

      protected virtual Iw_allinformationInner.Igb_details_type CreateInnerControl_gb_details_type()
      {
         return Mobilize.Web.Application.Create<Iw_allinformationInner.Igb_details_type>(this);
      }

      public partial class cb_1_type
         : Mobilize.Web.CommandButton, Iw_allinformationInner.Icb_1_type
      {

         public cb_1_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_allinformation Parent => (w_allinformation)base.Parent;

         public virtual int? Clicked()
         {
            short? pos = 0;
            pos = 0;
            pos = Mobilize.Web.TypeConversion.Integer(this.Parent.sle_1.Text);
            this.Parent.dw_main_info.ScrollToRow(pos);
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 3200;
            this.Y = 2180;
            this.Width = 402;
            this.Height = 112;
            this.TabOrder = 70;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.Text = "SetRow";
            this.bnclicked = new Mobilize.Web.ClickedEventHandler(Clicked);
         }

      }

      public partial class sle_1_type
         : Mobilize.Web.SingleLineEdit, Iw_allinformationInner.Isle_1_type
      {

         public sle_1_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_allinformation Parent => (w_allinformation)base.Parent;

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 3675;
            this.Y = 2184;
            this.Width = 402;
            this.Height = 112;
            this.TabOrder = 60;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.TextColor = 33554432;
         }

      }

      public partial class cb_insert_details_type
         : Mobilize.Web.CommandButton, Iw_allinformationInner.Icb_insert_details_type
      {

         public cb_insert_details_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_allinformation Parent => (w_allinformation)base.Parent;

         public virtual int? Clicked()
         {
            this.Parent.dw_additional_info.InsertRow(1);
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 3749;
            this.Y = 1988;
            this.Width = 343;
            this.Height = 112;
            this.TabOrder = 50;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.Text = "Insert Row";
            this.bnclicked = new Mobilize.Web.ClickedEventHandler(Clicked);
         }

      }

      public partial class cb_get_text_details_type
         : Mobilize.Web.CommandButton, Iw_allinformationInner.Icb_get_text_details_type
      {

         public cb_get_text_details_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_allinformation Parent => (w_allinformation)base.Parent;

         public virtual int? Clicked()
         {
            string str = "";
            str = this.Parent.dw_additional_info.GetItemString(1, this.Parent.dw_additional_info.GetColumnName());
            if ( Mobilize.Web.BuiltInExtensions.IsNull(str) == true )
            {
               str = "Es nulo";
            }
            Mobilize.Web.MessageBox.Show("Get text", Mobilize.Web.PlusFunctions.Plus(Mobilize.Web.CaseExtensions.String(this.Parent.dw_additional_info.GetText()) + "/", str));
            this.Parent.dw_additional_info.AcceptText();
            str = this.Parent.dw_additional_info.GetItemString(1, this.Parent.dw_additional_info.GetColumnName());
            if ( Mobilize.Web.BuiltInExtensions.IsNull(str) == true )
            {
               str = "Es nulo";
            }
            Mobilize.Web.MessageBox.Show("Get text (accepttext)", Mobilize.Web.PlusFunctions.Plus(Mobilize.Web.CaseExtensions.String(this.Parent.dw_additional_info.GetText()) + "/", str));
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 3749;
            this.Y = 1844;
            this.Width = 343;
            this.Height = 112;
            this.TabOrder = 50;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.Text = "Get Text";
            this.bnclicked = new Mobilize.Web.ClickedEventHandler(Clicked);
         }

      }

      public partial class cb_insertrow_type
         : Mobilize.Web.CommandButton, Iw_allinformationInner.Icb_insertrow_type
      {

         public cb_insertrow_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_allinformation Parent => (w_allinformation)base.Parent;

         public virtual int? Clicked()
         {
            this.Parent.dw_main_info.InsertRow(1);
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 3195;
            this.Y = 1988;
            this.Width = 343;
            this.Height = 112;
            this.TabOrder = 40;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.Text = "Insert Row";
            this.bnclicked = new Mobilize.Web.ClickedEventHandler(Clicked);
         }

      }

      public partial class cb_gettext_type
         : Mobilize.Web.CommandButton, Iw_allinformationInner.Icb_gettext_type
      {

         public cb_gettext_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_allinformation Parent => (w_allinformation)base.Parent;

         public virtual int? Clicked()
         {
            string str = "";
            str = this.Parent.dw_main_info.GetItemString(1, this.Parent.dw_main_info.GetColumnName());
            if ( Mobilize.Web.BuiltInExtensions.IsNull(str) == true )
            {
               str = "Es nulo";
            }
            Mobilize.Web.MessageBox.Show("Get text", Mobilize.Web.PlusFunctions.Plus(Mobilize.Web.CaseExtensions.String(this.Parent.dw_main_info.GetText()) + "/", str));
            this.Parent.dw_main_info.AcceptText();
            str = this.Parent.dw_main_info.GetItemString(1, this.Parent.dw_main_info.GetColumnName());
            if ( Mobilize.Web.BuiltInExtensions.IsNull(str) == true )
            {
               str = "Es nulo";
            }
            Mobilize.Web.MessageBox.Show("Get text (accepttext)", Mobilize.Web.PlusFunctions.Plus(Mobilize.Web.CaseExtensions.String(this.Parent.dw_main_info.GetText()) + "/", str));
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 3195;
            this.Y = 1840;
            this.Width = 343;
            this.Height = 112;
            this.TabOrder = 40;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.Text = "Get Text";
            this.bnclicked = new Mobilize.Web.ClickedEventHandler(Clicked);
         }

      }

      public partial class cb_clear_type
         : Mobilize.Web.CommandButton, Iw_allinformationInner.Icb_clear_type
      {

         public cb_clear_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_allinformation Parent => (w_allinformation)base.Parent;

         public virtual int? Clicked()
         {
            this.Parent.mle_log.Text = "";
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 4215;
            this.Y = 1768;
            this.Width = 402;
            this.Height = 112;
            this.TabOrder = 30;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.Text = "Clear Log";
            this.bnclicked = new Mobilize.Web.ClickedEventHandler(Clicked);
         }

      }

      public partial class mle_log_type
         : Mobilize.Web.MultiLineEdit, Iw_allinformationInner.Imle_log_type
      {

         public mle_log_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_allinformation Parent => (w_allinformation)base.Parent;

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 3163;
            this.Y = 48;
            this.Width = 1454;
            this.Height = 1676;
            this.TabOrder = 20;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.TextColor = 33554432;
         }

      }

      public partial class dw_additional_info_type
         : Mobilize.Web.DataManagerControl, Iw_allinformationInner.Idw_additional_info_type
      {

         public dw_additional_info_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_allinformation Parent => (w_allinformation)base.Parent;

         public virtual short? ItemChanged(int? row, Mobilize.Web.IDmControl dwo, string data)
         {
            string str = "";
            str = data;
            if ( (Mobilize.Web.Comparison.Equals(GetRow(), 1) & Mobilize.Web.Comparison.Equals(GetColumn(), 2)) == true )
            {
               if ( Mobilize.Web.Comparison.Equals(data, "") == true )
               {
                  str = "string empty";
               }
               if ( Mobilize.Web.BuiltInExtensions.IsNull(data) == true )
               {
                  str = "null";
               }
               Parent.logaction("itemchanged r: " + Mobilize.Web.CaseExtensions.String(row) + " gr: " + Mobilize.Web.CaseExtensions.String(GetRow()) + " c: " + Mobilize.Web.CaseExtensions.String(GetColumn()) + " cn: " + GetColumnName() + " d: " + str);
            }
            return null;
         }

         public virtual short? ItemFocusChanged(int? row, Mobilize.Web.IDmControl dwo)
         {
            if ( (Mobilize.Web.Comparison.Equals(GetRow(), 1) & Mobilize.Web.Comparison.Equals(GetColumn(), 2)) == true )
            {
            }
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 46;
            this.Y = 1196;
            this.Width = 3040;
            this.Height = 1128;
            this.TabOrder = 20;
            this.Title = "none";
            this.DataObject = "dw_allcontrols_two";
            this.LiveScroll = true;
            this.dwnitemchange = new Mobilize.Web.DataManagerItemChangedEventHandler(ItemChanged);
            this.dwnitemchangefocus = new Mobilize.Web.ItemFocusChangedEventHandler(ItemFocusChanged);
         }

      }

      public partial class dw_main_info_type
         : Mobilize.Web.DataManagerControl, Iw_allinformationInner.Idw_main_info_type
      {

         public dw_main_info_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_allinformation Parent => (w_allinformation)base.Parent;

         public virtual int? keydown(Mobilize.Web.KeyCode? key, uint? keyflags)
         {
            Parent.logaction("dwnkey r: " + Mobilize.Web.CaseExtensions.String(key) + " gr: " + Mobilize.Web.CaseExtensions.String(GetRow()) + " c: " + Mobilize.Web.CaseExtensions.String(GetColumn()) + " cn: " + GetColumnName());
            return null;
         }

         public virtual short? ItemChanged(int? row, Mobilize.Web.IDmControl dwo, string data)
         {
            string str = "";
            str = data;
            if ( Mobilize.Web.Comparison.Equals(data, "") == true )
            {
               str = "string empty";
            }
            if ( Mobilize.Web.BuiltInExtensions.IsNull(data) == true )
            {
               str = "null";
            }
            Parent.logaction("itemchanged r: " + Mobilize.Web.CaseExtensions.String(row) + " gr: " + Mobilize.Web.CaseExtensions.String(GetRow()) + " c: " + Mobilize.Web.CaseExtensions.String(GetColumn()) + " cn: " + GetColumnName() + " d: " + str);
            return null;
         }

         public virtual short? ItemFocusChanged(int? row, Mobilize.Web.IDmControl dwo)
         {
            string ls_mask = "";
            string ls_value = "";
            string val = "";
            Parent.logaction("itemfocuschanged r: " + Mobilize.Web.CaseExtensions.String(row) + " gr: " + Mobilize.Web.CaseExtensions.String(GetRow()) + " c: " + Mobilize.Web.CaseExtensions.String(GetColumn()) + " cn: " + GetColumnName());
            //val = this.getitemstring(row, dw_main_info.getcolumnname())
            val = this.Describe(Mobilize.Web.PlusFunctions.Plus(Mobilize.Web.PlusFunctions.Plus("evaluate('", this.Parent.dw_main_info.GetColumnName()), "',row)"));
            if ( Mobilize.Web.Comparison.Equals(dwo.Name, "gender") == true )
            {
               switch ( val )
               {
                  case "Male":
                     ls_mask = "ML!!!!";
                     ls_value = "ML    ";
                     break;
                  case "Female":
                     ls_mask = "FE!!!!";
                     ls_value = "FE    ";
                     break;
                  case "NR":
                     ls_mask = "NR!!!!";
                     ls_value = "NR    ";
                     break;
                  case "Trans":
                     ls_mask = "TR!!!!";
                     ls_value = "TR    ";
                     break;
               }
               this.Parent.dw_main_info.Modify(Mobilize.Web.PlusFunctions.Plus(Mobilize.Web.PlusFunctions.Plus("dist_code.EditMask.Mask = '", ls_mask), "'"));
               this.Parent.dw_main_info.SetItem(row, "dist_code", ls_value);
            }
            return null;
         }

         public virtual int? LoseFocus()
         {
            Parent.logaction("losefocus");
            return null;
         }

         public virtual int? GetFocus()
         {
            Parent.logaction("getfocus");
            return null;
         }

         public virtual short? RowFocusChanged(int? currentrow)
         {
            Parent.logaction(Mobilize.Web.PlusFunctions.Plus(Mobilize.Web.PlusFunctions.Plus(Mobilize.Web.PlusFunctions.Plus(Mobilize.Web.PlusFunctions.Plus(Mobilize.Web.PlusFunctions.Plus("rowfocuschanged r: ", Mobilize.Web.CaseExtensions.String(GetRow())), " c: "), Mobilize.Web.CaseExtensions.String(GetColumn())), " cn: "), GetColumnName()));
            return null;
         }

         public virtual short? RowFocusChanging(int? currentrow, int? newrow)
         {
            Parent.logaction("rowfocuschanging r: " + Mobilize.Web.CaseExtensions.String(currentrow) + " nr: " + Mobilize.Web.CaseExtensions.String(newrow) + " gr: " + Mobilize.Web.CaseExtensions.String(GetRow()) + " c: " + Mobilize.Web.CaseExtensions.String(GetColumn()) + " cn: " + GetColumnName());
            return null;
         }

         public virtual short? EditChanged(int? row, Mobilize.Web.IDmControl dwo, string data)
         {
            Parent.logaction("editchanged r: " + Mobilize.Web.CaseExtensions.String(row) + " gr: " + Mobilize.Web.CaseExtensions.String(GetRow()) + " d: " + data + " GetText " + this.GetText() + " ItemString " + this.GetItemString(row, GetColumn()));
            return null;
         }

         public virtual short? ButtonClicked(int? row, int? actionreturncode, Mobilize.Web.IDmControl dwo)
         {
            Parent.logaction(Mobilize.Web.PlusFunctions.Plus(Mobilize.Web.PlusFunctions.Plus(Mobilize.Web.PlusFunctions.Plus(Mobilize.Web.PlusFunctions.Plus(Mobilize.Web.PlusFunctions.Plus("buttonclicked r: ", Mobilize.Web.CaseExtensions.String(row)), " gr: "), Mobilize.Web.CaseExtensions.String(GetRow())), " c: "), Mobilize.Web.CaseExtensions.String(GetColumn())));
            return null;
         }

         public virtual short? Clicked(short? xpos, short? ypos, int? row, Mobilize.Web.IDmControl dwo)
         {
            Parent.logaction(Mobilize.Web.PlusFunctions.Plus(Mobilize.Web.PlusFunctions.Plus(Mobilize.Web.PlusFunctions.Plus(Mobilize.Web.PlusFunctions.Plus(Mobilize.Web.PlusFunctions.Plus("clicked r: ", Mobilize.Web.CaseExtensions.String(row)), " gr: "), Mobilize.Web.CaseExtensions.String(GetRow())), " c: "), Mobilize.Web.CaseExtensions.String(GetClickedColumn())));
            return null;
         }

         public virtual short? DoubleClicked(short? xpos, short? ypos, int? row, Mobilize.Web.IDmControl dwo)
         {
            Parent.logaction(Mobilize.Web.PlusFunctions.Plus(Mobilize.Web.PlusFunctions.Plus(Mobilize.Web.PlusFunctions.Plus(Mobilize.Web.PlusFunctions.Plus(Mobilize.Web.PlusFunctions.Plus("doubleclicked ", Mobilize.Web.CaseExtensions.String(GetRow())), " "), Mobilize.Web.CaseExtensions.String(row)), " "), Mobilize.Web.CaseExtensions.String(GetClickedColumn())));
            return null;
         }

         public Iw_allinformationInner.Idw_main_info_typeInner.keydownHandler keydownEventHandler { get; set; }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 46;
            this.Y = 48;
            this.Width = 3040;
            this.Height = 1120;
            this.TabOrder = 10;
            this.Title = "none";
            this.DataObject = "dw_allcontrols_one";
            this.VScrollBar = true;
            this.LiveScroll = true;
            ;
            this.dwnitemchange = new Mobilize.Web.DataManagerItemChangedEventHandler(ItemChanged);
            this.dwnitemchangefocus = new Mobilize.Web.ItemFocusChangedEventHandler(ItemFocusChanged);
            this.dwnkillfocus = new Mobilize.Web.LoseFocusEventHandler(LoseFocus);
            this.dwnsetfocus = new Mobilize.Web.GetFocusEventHandler(GetFocus);
            this.dwnrowchange = new Mobilize.Web.RowFocusChangedEventHandler(RowFocusChanged);
            this.dwnrowchanging = new Mobilize.Web.RowFocusChangingEventHandler(RowFocusChanging);
            this.dwnchanging = new Mobilize.Web.EditChangedEventHandler(EditChanged);
            this.dwnbuttonclicked = new Mobilize.Web.ButtonClickedEventHandler(ButtonClicked);
            this.dwnlbuttonclk = new Mobilize.Web.DataManagerClickedEventHandler(Clicked);
            this.dwnlbuttondblclk = new Mobilize.Web.DataManagerDoubleClickedEventHandler(DoubleClicked);
         }

      }

      public partial class gb_main_type
         : Mobilize.Web.GroupBox, Iw_allinformationInner.Igb_main_type
      {

         public gb_main_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_allinformation Parent => (w_allinformation)base.Parent;

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 3150;
            this.Y = 1744;
            this.Width = 480;
            this.Height = 400;
            this.TabOrder = 30;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.TextColor = 33554432;
            this.BackColor = 67108864;
            this.Text = "Main Info";
            this.BorderStyle = Mobilize.Web.BorderStyle.StyleBox;
         }

      }

      public partial class gb_details_type
         : Mobilize.Web.GroupBox, Iw_allinformationInner.Igb_details_type
      {

         public gb_details_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_allinformation Parent => (w_allinformation)base.Parent;

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 3703;
            this.Y = 1744;
            this.Width = 480;
            this.Height = 400;
            this.TabOrder = 40;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.TextColor = 33554432;
            this.BackColor = 67108864;
            this.Text = "Details";
            this.BorderStyle = Mobilize.Web.BorderStyle.StyleBox;
         }

      }

   }

}
#pragma warning restore
