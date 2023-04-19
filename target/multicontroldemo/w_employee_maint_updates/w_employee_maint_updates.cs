namespace multicontroldemo
{

   [Mobilize.WebMap.Common.Attributes.Observable]
   public partial class w_employee_maint_updates
      : Mobilize.Web.Window, multicontroldemo.Iw_employee_maint_updates
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
         this.cb_2 = CreateInnerControl_cb_2_type();
         this.cb_1 = CreateInnerControl_cb_1_type();
         this.dw_1 = CreateInnerControl_dw_1_type();
         this.Control = Mobilize.Web.ArrayExtensions.Clone<Mobilize.Web.IControl>(new Mobilize.Web.IControl[] { this.cb_9, this.cb_8, this.cb_7, this.cb_6, this.cb_5, this.cb_4, this.cb_3, this.cb_2, this.cb_1, this.dw_1 });
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
         this.cb_2 = null;
         this.cb_1 = null;
         this.dw_1 = null;
      }

      public virtual int? OpenWindow()
      {
         Mobilize.Web.IDataStore ds = Mobilize.Web.Application.Default<Mobilize.Web.IDataStore>();
         if ( Mobilize.Web.Comparison.Equals(((Mobilize.Web.IMessage)(Mobilize.Web.Application.CurrentApplication.Variables.Message<Mobilize.Web.IMessage>())).StringParm, "free") == true )
         {
            this.dw_1.DataObject = "d_employee_info_update";
         }
         else if ( Mobilize.Web.Comparison.Equals(((Mobilize.Web.IMessage)(Mobilize.Web.Application.CurrentApplication.Variables.Message<Mobilize.Web.IMessage>())).StringParm, "grid") == true )
         {
            this.dw_1.DataObject = "d_employee_info_update_grid";
         }
         else if ( Mobilize.Web.Comparison.Equals(((Mobilize.Web.IMessage)(Mobilize.Web.Application.CurrentApplication.Variables.Message<Mobilize.Web.IMessage>())).StringParm, "dyngrid") == true )
         {
            ds = Mobilize.Web.Application.Create<Mobilize.Web.IDataStore>(this);
            ds.DataObject = "d_employee_info_update_grid";
            this.dw_1.Create(ds.Describe("datawindow.syntax"));
         }
         else if ( Mobilize.Web.Comparison.Equals(((Mobilize.Web.IMessage)(Mobilize.Web.Application.CurrentApplication.Variables.Message<Mobilize.Web.IMessage>())).StringParm, "dynfree") == true )
         {
            ds = Mobilize.Web.Application.Create<Mobilize.Web.IDataStore>(this);
            ds.DataObject = "d_employee_info_update";
            this.dw_1.Create(ds.Describe("datawindow.syntax"));
         }
         this.dw_1.InsertRow(0);
         return null;
      }

      public override void DoWmInit()
      {
         base.DoWmInit();
         this.open = new Mobilize.Web.OpenWindowEventHandler(OpenWindow);
      }

      protected virtual Iw_employee_maint_updatesInner.Icb_9_type CreateInnerControl_cb_9_type()
      {
         return Mobilize.Web.Application.Create<Iw_employee_maint_updatesInner.Icb_9_type>(this);
      }

      protected virtual Iw_employee_maint_updatesInner.Icb_8_type CreateInnerControl_cb_8_type()
      {
         return Mobilize.Web.Application.Create<Iw_employee_maint_updatesInner.Icb_8_type>(this);
      }

      protected virtual Iw_employee_maint_updatesInner.Icb_7_type CreateInnerControl_cb_7_type()
      {
         return Mobilize.Web.Application.Create<Iw_employee_maint_updatesInner.Icb_7_type>(this);
      }

      protected virtual Iw_employee_maint_updatesInner.Icb_6_type CreateInnerControl_cb_6_type()
      {
         return Mobilize.Web.Application.Create<Iw_employee_maint_updatesInner.Icb_6_type>(this);
      }

      protected virtual Iw_employee_maint_updatesInner.Icb_5_type CreateInnerControl_cb_5_type()
      {
         return Mobilize.Web.Application.Create<Iw_employee_maint_updatesInner.Icb_5_type>(this);
      }

      protected virtual Iw_employee_maint_updatesInner.Icb_4_type CreateInnerControl_cb_4_type()
      {
         return Mobilize.Web.Application.Create<Iw_employee_maint_updatesInner.Icb_4_type>(this);
      }

      protected virtual Iw_employee_maint_updatesInner.Icb_3_type CreateInnerControl_cb_3_type()
      {
         return Mobilize.Web.Application.Create<Iw_employee_maint_updatesInner.Icb_3_type>(this);
      }

      protected virtual Iw_employee_maint_updatesInner.Icb_2_type CreateInnerControl_cb_2_type()
      {
         return Mobilize.Web.Application.Create<Iw_employee_maint_updatesInner.Icb_2_type>(this);
      }

      protected virtual Iw_employee_maint_updatesInner.Icb_1_type CreateInnerControl_cb_1_type()
      {
         return Mobilize.Web.Application.Create<Iw_employee_maint_updatesInner.Icb_1_type>(this);
      }

      protected virtual Iw_employee_maint_updatesInner.Idw_1_type CreateInnerControl_dw_1_type()
      {
         return Mobilize.Web.Application.Create<Iw_employee_maint_updatesInner.Idw_1_type>(this);
      }

      public class cb_9_type
         : Mobilize.Web.CommandButton, Iw_employee_maint_updatesInner.Icb_9_type
      {

         public cb_9_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_employee_maint_updates Parent => (w_employee_maint_updates)base.Parent;

         public virtual int? Clicked()
         {
            this.Parent.dw_1.ScrollToRow(1);
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 3003;
            this.Y = 1380;
            this.Width = 402;
            this.Height = 112;
            this.TabOrder = 100;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.Text = "Scroll to 1";
            this.bnclicked = new Mobilize.Web.ClickedEventHandler(Clicked);
         }

      }

      public class cb_8_type
         : Mobilize.Web.CommandButton, Iw_employee_maint_updatesInner.Icb_8_type
      {

         public cb_8_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_employee_maint_updates Parent => (w_employee_maint_updates)base.Parent;

         public virtual int? Clicked()
         {
            this.Parent.dw_1.ScrollToRow(3);
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 2990;
            this.Y = 1196;
            this.Width = 402;
            this.Height = 112;
            this.TabOrder = 90;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.Text = "Scroll to 3";
            this.bnclicked = new Mobilize.Web.ClickedEventHandler(Clicked);
         }

      }

      public class cb_7_type
         : Mobilize.Web.CommandButton, Iw_employee_maint_updatesInner.Icb_7_type
      {

         public cb_7_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_employee_maint_updates Parent => (w_employee_maint_updates)base.Parent;

         public virtual int? Clicked()
         {
            this.Parent.dw_1.DeleteRow(1);
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 2985;
            this.Y = 1028;
            this.Width = 402;
            this.Height = 112;
            this.TabOrder = 80;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.Text = "Delete at 1";
            this.bnclicked = new Mobilize.Web.ClickedEventHandler(Clicked);
         }

      }

      public class cb_6_type
         : Mobilize.Web.CommandButton, Iw_employee_maint_updatesInner.Icb_6_type
      {

         public cb_6_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_employee_maint_updates Parent => (w_employee_maint_updates)base.Parent;

         public virtual int? Clicked()
         {
            short? i = 0;
            for ( i = 1; i <= this.Parent.dw_1.RowCount(); ++i )
            {
               this.Parent.dw_1.SetItem(i, "tdescription", "");
            }
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 2994;
            this.Y = 852;
            this.Width = 521;
            this.Height = 112;
            this.TabOrder = 70;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.Text = "Clear descriptions";
            this.bnclicked = new Mobilize.Web.ClickedEventHandler(Clicked);
         }

      }

      public class cb_5_type
         : Mobilize.Web.CommandButton, Iw_employee_maint_updatesInner.Icb_5_type
      {

         public cb_5_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_employee_maint_updates Parent => (w_employee_maint_updates)base.Parent;

         public virtual int? Clicked()
         {
            short? current_row = 0;
            short? newcategory = 0;
            current_row = (short?)this.Parent.dw_1.GetRow();
            newcategory = 1;
            switch ( this.Parent.dw_1.GetItemNumber(current_row, "tdepartment") )
            {
               case 1:
                  newcategory = 2;
                  break;
               case 2:
                  newcategory = 3;
                  break;
               case 3:
                  newcategory = 1;
                  break;
            }
            this.Parent.dw_1.SetItem(current_row, "tdepartment", newcategory);
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 2981;
            this.Y = 692;
            this.Width = 562;
            this.Height = 112;
            this.TabOrder = 60;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.Text = "Update Department";
            this.bnclicked = new Mobilize.Web.ClickedEventHandler(Clicked);
         }

      }

      public class cb_4_type
         : Mobilize.Web.CommandButton, Iw_employee_maint_updatesInner.Icb_4_type
      {

         public cb_4_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_employee_maint_updates Parent => (w_employee_maint_updates)base.Parent;

         public virtual int? Clicked()
         {
            short? i = 0;
            System.DateTime? dt = new System.DateTime(1900, 1, 1, 0, 0, 0);
            i = 0;
            dt = Mobilize.Web.TypeConversion.DateTime("2001/01/01 08:01:02");
            for ( i = i; i <= this.Parent.dw_1.RowCount(); ++i )
            {
               this.Parent.dw_1.SetItem(i, "tlastlogin", dt);
            }
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 2981;
            this.Y = 528;
            this.Width = 512;
            this.Height = 112;
            this.TabOrder = 50;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.Text = "Update login time";
            this.bnclicked = new Mobilize.Web.ClickedEventHandler(Clicked);
         }

      }

      public class cb_3_type
         : Mobilize.Web.CommandButton, Iw_employee_maint_updatesInner.Icb_3_type
      {

         public cb_3_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_employee_maint_updates Parent => (w_employee_maint_updates)base.Parent;

         public virtual int? Clicked()
         {
            short? current_row = 0;
            short? newcategory = 0;
            current_row = (short?)this.Parent.dw_1.GetRow();
            newcategory = 10;
            switch ( this.Parent.dw_1.GetItemNumber(current_row, "tcategory") )
            {
               case 10:
                  newcategory = 20;
                  break;
               case 20:
                  newcategory = 30;
                  break;
               case 30:
                  newcategory = 10;
                  break;
            }
            this.Parent.dw_1.SetItem(current_row, "tcategory", newcategory);
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 2981;
            this.Y = 364;
            this.Width = 494;
            this.Height = 112;
            this.TabOrder = 40;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.Text = "Change category";
            this.bnclicked = new Mobilize.Web.ClickedEventHandler(Clicked);
         }

      }

      public class cb_2_type
         : Mobilize.Web.CommandButton, Iw_employee_maint_updatesInner.Icb_2_type
      {

         public cb_2_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_employee_maint_updates Parent => (w_employee_maint_updates)base.Parent;

         public virtual int? Clicked()
         {
            short? i = 0;
            for ( i = 1; i <= this.Parent.dw_1.RowCount(); ++i )
            {
               this.Parent.dw_1.SetItem(i, "tsalary", this.Parent.dw_1.GetItemNumber(i, "tsalary") * 2);
            }
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 2981;
            this.Y = 216;
            this.Width = 498;
            this.Height = 112;
            this.TabOrder = 30;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.Text = "Increase salaries";
            this.bnclicked = new Mobilize.Web.ClickedEventHandler(Clicked);
         }

      }

      public class cb_1_type
         : Mobilize.Web.CommandButton, Iw_employee_maint_updatesInner.Icb_1_type
      {

         public cb_1_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_employee_maint_updates Parent => (w_employee_maint_updates)base.Parent;

         public virtual int? Clicked()
         {
            this.Parent.dw_1.InsertRow(1);
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 2981;
            this.Y = 84;
            this.Width = 402;
            this.Height = 112;
            this.TabOrder = 20;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.Text = "Insert at 1";
            this.bnclicked = new Mobilize.Web.ClickedEventHandler(Clicked);
         }

      }

      public class dw_1_type
         : Mobilize.Web.DataManagerControl, Iw_employee_maint_updatesInner.Idw_1_type
      {

         public dw_1_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_employee_maint_updates Parent => (w_employee_maint_updates)base.Parent;

         public virtual short? ItemChanged(int? row, Mobilize.Web.IDmControl dwo, string data)
         {
            string colname = "";
            colname = this.Parent.dw_1.GetColumnName();
            if ( (Mobilize.Web.Comparison.Equals(colname, "tsalary") & Mobilize.Web.TypeConversion.Double(data) < (double?)this.Parent.dw_1.GetItemNumber(row, "tsalary")) == true )
            {
               this.Parent.dw_1.SetItem(row, "tdescription", "Too bad!");
            }
            if ( (Mobilize.Web.Comparison.Equals(colname, "tage") & (Mobilize.Web.TypeConversion.Double(data) > 100 | Mobilize.Web.TypeConversion.Double(data) < 18)) == true )
            {
               this.Parent.dw_1.SetItem(row, "tdescription", "Imposible!");
               this.Parent.dw_1.SetItem(row, "tage", 60);
               return 2;
            }
            if ( (Mobilize.Web.Comparison.Equals(colname, "tdepartment") & this.Parent.dw_1.RowCount() >= row + 1) == true )
            {
               if ( Mobilize.Web.Comparison.Equals(Mobilize.Web.TypeConversion.Double(data), (double?)this.Parent.dw_1.GetItemNumber(row + 1, "tdepartment")) == true )
               {
                  this.Parent.dw_1.SetItem(row, "tdescription", "Same Department as the following");
               }
            }
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 64;
            this.Y = 40;
            this.Width = 2830;
            this.Height = 1752;
            this.TabOrder = 10;
            this.Title = "none";
            this.HScrollBar = true;
            this.VScrollBar = true;
            this.LiveScroll = true;
            this.BorderStyle = Mobilize.Web.BorderStyle.StyleLowered;
            this.dwnitemchange = new Mobilize.Web.DataManagerItemChangedEventHandler(ItemChanged);
         }

      }

   }

}