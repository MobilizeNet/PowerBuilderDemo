namespace pbj_webmapdemo
{

   [Mobilize.WebMap.Common.Attributes.Observable]
   public partial class w_dropdown_listbox
      : Mobilize.Web.Window, pbj_webmapdemo.Iw_dropdown_listbox
   {

      public override void Create()
      {
         this.cb_3 = CreateInnerControl_cb_3_type();
         this.cb_10 = CreateInnerControl_cb_10_type();
         this.cb_9 = CreateInnerControl_cb_9_type();
         this.cb_8 = CreateInnerControl_cb_8_type();
         this.cb_7 = CreateInnerControl_cb_7_type();
         this.cb_2 = CreateInnerControl_cb_2_type();
         this.cb_4 = CreateInnerControl_cb_4_type();
         this.cb_5 = CreateInnerControl_cb_5_type();
         this.cb_6 = CreateInnerControl_cb_6_type();
         this.cb_1 = CreateInnerControl_cb_1_type();
         this.ddlb_1 = CreateInnerControl_ddlb_1_type();
         this.Control = Mobilize.Web.ArrayExtensions.Clone<Mobilize.Web.IControl>(new Mobilize.Web.IControl[] { this.cb_3, this.cb_10, this.cb_9, this.cb_8, this.cb_7, this.cb_2, this.cb_4, this.cb_5, this.cb_6, this.cb_1, this.ddlb_1 });
      }

      public override void Destroy()
      {
         this.cb_3 = null;
         this.cb_10 = null;
         this.cb_9 = null;
         this.cb_8 = null;
         this.cb_7 = null;
         this.cb_2 = null;
         this.cb_4 = null;
         this.cb_5 = null;
         this.cb_6 = null;
         this.cb_1 = null;
         this.ddlb_1 = null;
      }

      protected virtual Iw_dropdown_listboxInner.Icb_3_type CreateInnerControl_cb_3_type()
      {
         return Mobilize.Web.Application.Create<Iw_dropdown_listboxInner.Icb_3_type>(this);
      }

      protected virtual Iw_dropdown_listboxInner.Icb_10_type CreateInnerControl_cb_10_type()
      {
         return Mobilize.Web.Application.Create<Iw_dropdown_listboxInner.Icb_10_type>(this);
      }

      protected virtual Iw_dropdown_listboxInner.Icb_9_type CreateInnerControl_cb_9_type()
      {
         return Mobilize.Web.Application.Create<Iw_dropdown_listboxInner.Icb_9_type>(this);
      }

      protected virtual Iw_dropdown_listboxInner.Icb_8_type CreateInnerControl_cb_8_type()
      {
         return Mobilize.Web.Application.Create<Iw_dropdown_listboxInner.Icb_8_type>(this);
      }

      protected virtual Iw_dropdown_listboxInner.Icb_7_type CreateInnerControl_cb_7_type()
      {
         return Mobilize.Web.Application.Create<Iw_dropdown_listboxInner.Icb_7_type>(this);
      }

      protected virtual Iw_dropdown_listboxInner.Icb_2_type CreateInnerControl_cb_2_type()
      {
         return Mobilize.Web.Application.Create<Iw_dropdown_listboxInner.Icb_2_type>(this);
      }

      protected virtual Iw_dropdown_listboxInner.Icb_4_type CreateInnerControl_cb_4_type()
      {
         return Mobilize.Web.Application.Create<Iw_dropdown_listboxInner.Icb_4_type>(this);
      }

      protected virtual Iw_dropdown_listboxInner.Icb_5_type CreateInnerControl_cb_5_type()
      {
         return Mobilize.Web.Application.Create<Iw_dropdown_listboxInner.Icb_5_type>(this);
      }

      protected virtual Iw_dropdown_listboxInner.Icb_6_type CreateInnerControl_cb_6_type()
      {
         return Mobilize.Web.Application.Create<Iw_dropdown_listboxInner.Icb_6_type>(this);
      }

      protected virtual Iw_dropdown_listboxInner.Icb_1_type CreateInnerControl_cb_1_type()
      {
         return Mobilize.Web.Application.Create<Iw_dropdown_listboxInner.Icb_1_type>(this);
      }

      protected virtual Iw_dropdown_listboxInner.Iddlb_1_type CreateInnerControl_ddlb_1_type()
      {
         return Mobilize.Web.Application.Create<Iw_dropdown_listboxInner.Iddlb_1_type>(this);
      }

      public class cb_3_type
         : Mobilize.Web.CommandButton, Iw_dropdown_listboxInner.Icb_3_type
      {

         public cb_3_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_dropdown_listbox Parent => (w_dropdown_listbox)base.Parent;

         public virtual int? Clicked()
         {
            bool? b_ShowList_value = false;
            b_ShowList_value = this.Parent.ddlb_1.ShowList;
            if ( Mobilize.Web.Comparison.Equals(b_ShowList_value, true) == true )
            {
               this.Parent.ddlb_1.ShowList = false;
            }
            else
            {
               this.Parent.ddlb_1.ShowList = true;
            }
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 270;
            this.Y = 404;
            this.Width = 402;
            this.Height = 112;
            this.TabOrder = 20;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.Text = "ShowList";
            this.bnclicked = new Mobilize.Web.ClickedEventHandler(Clicked);
         }

      }

      public class cb_10_type
         : Mobilize.Web.CommandButton, Iw_dropdown_listboxInner.Icb_10_type
      {

         public cb_10_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_dropdown_listbox Parent => (w_dropdown_listbox)base.Parent;

         public virtual int? Clicked()
         {
            short? i_total_items = 0;
            i_total_items = this.Parent.ddlb_1.TotalItems();
            if ( Mobilize.Web.Comparison.Equals(this.Parent.cb_10.Text, "TotalItems") == true )
            {
               this.Parent.cb_10.Text = Mobilize.Web.CaseExtensions.String(i_total_items);
            }
            else
            {
               this.Parent.cb_10.Text = "TotalItems";
            }
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 1312;
            this.Y = 804;
            this.Width = 402;
            this.Height = 112;
            this.TabOrder = 30;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.Text = "TotalItems";
            this.bnclicked = new Mobilize.Web.ClickedEventHandler(Clicked);
         }

      }

      public class cb_9_type
         : Mobilize.Web.CommandButton, Iw_dropdown_listboxInner.Icb_9_type
      {

         public cb_9_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_dropdown_listbox Parent => (w_dropdown_listbox)base.Parent;

         public virtual int? Clicked()
         {
            string s_item = "";
            s_item = "Inserted Item";
            this.Parent.ddlb_1.InsertItem(s_item, 3);
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 1312;
            this.Y = 604;
            this.Width = 402;
            this.Height = 112;
            this.TabOrder = 40;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.Text = "InsertItem";
            this.bnclicked = new Mobilize.Web.ClickedEventHandler(Clicked);
         }

      }

      public class cb_8_type
         : Mobilize.Web.CommandButton, Iw_dropdown_listboxInner.Icb_8_type
      {

         public cb_8_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_dropdown_listbox Parent => (w_dropdown_listbox)base.Parent;

         public virtual int? Clicked()
         {
            this.Parent.ddlb_1.DeleteItem(1);
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 795;
            this.Y = 804;
            this.Width = 402;
            this.Height = 112;
            this.TabOrder = 30;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.Text = "DeleteItem";
            this.bnclicked = new Mobilize.Web.ClickedEventHandler(Clicked);
         }

      }

      public class cb_7_type
         : Mobilize.Web.CommandButton, Iw_dropdown_listboxInner.Icb_7_type
      {

         public cb_7_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_dropdown_listbox Parent => (w_dropdown_listbox)base.Parent;

         public virtual int? Clicked()
         {
            string s_item = "";
            s_item = "Added Item";
            this.Parent.ddlb_1.AddItem(s_item);
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 795;
            this.Y = 604;
            this.Width = 402;
            this.Height = 112;
            this.TabOrder = 30;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.Text = "AddItem";
            this.bnclicked = new Mobilize.Web.ClickedEventHandler(Clicked);
         }

      }

      public class cb_2_type
         : Mobilize.Web.CommandButton, Iw_dropdown_listboxInner.Icb_2_type
      {

         public cb_2_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_dropdown_listbox Parent => (w_dropdown_listbox)base.Parent;

         public virtual int? Clicked()
         {
            bool? b_AllowEdit_value = false;
            b_AllowEdit_value = this.Parent.ddlb_1.AllowEdit;
            if ( Mobilize.Web.Comparison.Equals(b_AllowEdit_value, true) == true )
            {
               this.Parent.ddlb_1.AllowEdit = false;
            }
            else
            {
               this.Parent.ddlb_1.AllowEdit = true;
            }
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 270;
            this.Y = 604;
            this.Width = 402;
            this.Height = 112;
            this.TabOrder = 20;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.Text = "AllowEdit";
            this.bnclicked = new Mobilize.Web.ClickedEventHandler(Clicked);
         }

      }

      public class cb_4_type
         : Mobilize.Web.CommandButton, Iw_dropdown_listboxInner.Icb_4_type
      {

         public cb_4_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_dropdown_listbox Parent => (w_dropdown_listbox)base.Parent;

         public virtual int? Clicked()
         { //GetEnabled

            bool? lb_enabled = false;
            lb_enabled = this.Parent.ddlb_1.Enabled;
            //Change CheckBox ENABLED
            if ( (lb_enabled) == true )
            {
               this.Parent.ddlb_1.Enabled = false;
            }
            else
            {
               this.Parent.ddlb_1.Enabled = true;
            }
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 270;
            this.Y = 992;
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

      public class cb_5_type
         : Mobilize.Web.CommandButton, Iw_dropdown_listboxInner.Icb_5_type
      {

         public cb_5_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_dropdown_listbox Parent => (w_dropdown_listbox)base.Parent;

         public virtual int? Clicked()
         { //GetVisible

            bool? lb_visible = false;
            lb_visible = this.Parent.ddlb_1.Visible;
            //Change CheckBox Visible
            if ( (lb_visible) == true )
            {
               this.Parent.ddlb_1.Visible = false;
            }
            else
            {
               this.Parent.ddlb_1.Visible = true;
            }
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 795;
            this.Y = 992;
            this.Width = 402;
            this.Height = 112;
            this.TabOrder = 40;
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
         : Mobilize.Web.CommandButton, Iw_dropdown_listboxInner.Icb_6_type
      {

         public cb_6_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_dropdown_listbox Parent => (w_dropdown_listbox)base.Parent;

         public virtual int? Clicked()
         { //GetText

            string s_dropdown_listbox_text = "";
            s_dropdown_listbox_text = this.Parent.ddlb_1.Text;
            //Change DropDown ListBox Text
            if ( Mobilize.Web.Comparison.NotEquals(s_dropdown_listbox_text, "Text Changed") == true )
            {
               this.Parent.ddlb_1.Text = "Text Changed";
            }
            else
            {
               this.Parent.ddlb_1.Text = "";
            }
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 1312;
            this.Y = 992;
            this.Width = 402;
            this.Height = 112;
            this.TabOrder = 40;
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

      public class cb_1_type
         : Mobilize.Web.CommandButton, Iw_dropdown_listboxInner.Icb_1_type
      {

         public cb_1_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_dropdown_listbox Parent => (w_dropdown_listbox)base.Parent;

         public virtual int? Clicked()
         { //Change DropDownListButton Show/Hide

            if ( Mobilize.Web.Comparison.Equals(this.Parent.ddlb_1.Visible, true) == true )
            {
               this.Parent.ddlb_1.Hide();
            }
            else
            {
               this.Parent.ddlb_1.Show();
            }
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 270;
            this.Y = 804;
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

      public class ddlb_1_type
         : Mobilize.Web.DropDownListBox, Iw_dropdown_listboxInner.Iddlb_1_type
      {

         public ddlb_1_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_dropdown_listbox Parent => (w_dropdown_listbox)base.Parent;

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 407;
            this.Y = 124;
            this.Width = 1134;
            this.Height = 420;
            this.TabOrder = 10;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.TextColor = 33554432;
            this.Item = new Mobilize.Web.DynamicArray<string>(new string[] { "Item 1", "Item 2", "Item 3" });
            this.BorderStyle = Mobilize.Web.BorderStyle.StyleLowered;
         }

      }

   }

}