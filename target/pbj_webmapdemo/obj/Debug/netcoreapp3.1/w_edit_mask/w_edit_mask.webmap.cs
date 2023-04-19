#pragma warning disable
#line 1 "w_edit_mask\\w_edit_mask.cs"
#pragma warning disable
#line 1 "w_edit_mask\\w_edit_mask.cs"
namespace pbj_webmapdemo
{

   [Mobilize.WebMap.Common.Attributes.Observable]
   public partial class w_edit_mask
      : Mobilize.Web.Window, pbj_webmapdemo.Iw_edit_mask
   {

      public override void Create()
      {
         this.cb_time = CreateInnerControl_cb_time_type();
         this.cb_number = CreateInnerControl_cb_number_type();
         this.cb_7 = CreateInnerControl_cb_7_type();
         this.cb_8 = CreateInnerControl_cb_8_type();
         this.cb_9 = CreateInnerControl_cb_9_type();
         this.cb_1 = CreateInnerControl_cb_1_type();
         this.cb_3 = CreateInnerControl_cb_3_type();
         this.cb_6 = CreateInnerControl_cb_6_type();
         this.cb_5 = CreateInnerControl_cb_5_type();
         this.cb_4 = CreateInnerControl_cb_4_type();
         this.em_1 = CreateInnerControl_em_1_type();
         this.Control = Mobilize.Web.ArrayExtensions.Clone<Mobilize.Web.IControl>(new Mobilize.Web.IControl[] { this.cb_time, this.cb_number, this.cb_7, this.cb_8, this.cb_9, this.cb_1, this.cb_3, this.cb_6, this.cb_5, this.cb_4, this.em_1 });
      }

      public override void Destroy()
      {
         this.cb_time = null;
         this.cb_number = null;
         this.cb_7 = null;
         this.cb_8 = null;
         this.cb_9 = null;
         this.cb_1 = null;
         this.cb_3 = null;
         this.cb_6 = null;
         this.cb_5 = null;
         this.cb_4 = null;
         this.em_1 = null;
      }

      protected virtual Iw_edit_maskInner.Icb_time_type CreateInnerControl_cb_time_type()
      {
         return Mobilize.Web.Application.Create<Iw_edit_maskInner.Icb_time_type>(this);
      }

      protected virtual Iw_edit_maskInner.Icb_number_type CreateInnerControl_cb_number_type()
      {
         return Mobilize.Web.Application.Create<Iw_edit_maskInner.Icb_number_type>(this);
      }

      protected virtual Iw_edit_maskInner.Icb_7_type CreateInnerControl_cb_7_type()
      {
         return Mobilize.Web.Application.Create<Iw_edit_maskInner.Icb_7_type>(this);
      }

      protected virtual Iw_edit_maskInner.Icb_8_type CreateInnerControl_cb_8_type()
      {
         return Mobilize.Web.Application.Create<Iw_edit_maskInner.Icb_8_type>(this);
      }

      protected virtual Iw_edit_maskInner.Icb_9_type CreateInnerControl_cb_9_type()
      {
         return Mobilize.Web.Application.Create<Iw_edit_maskInner.Icb_9_type>(this);
      }

      protected virtual Iw_edit_maskInner.Icb_1_type CreateInnerControl_cb_1_type()
      {
         return Mobilize.Web.Application.Create<Iw_edit_maskInner.Icb_1_type>(this);
      }

      protected virtual Iw_edit_maskInner.Icb_3_type CreateInnerControl_cb_3_type()
      {
         return Mobilize.Web.Application.Create<Iw_edit_maskInner.Icb_3_type>(this);
      }

      protected virtual Iw_edit_maskInner.Icb_6_type CreateInnerControl_cb_6_type()
      {
         return Mobilize.Web.Application.Create<Iw_edit_maskInner.Icb_6_type>(this);
      }

      protected virtual Iw_edit_maskInner.Icb_5_type CreateInnerControl_cb_5_type()
      {
         return Mobilize.Web.Application.Create<Iw_edit_maskInner.Icb_5_type>(this);
      }

      protected virtual Iw_edit_maskInner.Icb_4_type CreateInnerControl_cb_4_type()
      {
         return Mobilize.Web.Application.Create<Iw_edit_maskInner.Icb_4_type>(this);
      }

      protected virtual Iw_edit_maskInner.Iem_1_type CreateInnerControl_em_1_type()
      {
         return Mobilize.Web.Application.Create<Iw_edit_maskInner.Iem_1_type>(this);
      }

      public partial class cb_time_type
         : Mobilize.Web.CommandButton, Iw_edit_maskInner.Icb_time_type
      {

         public cb_time_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_edit_mask Parent => (w_edit_mask)base.Parent;

         public virtual int? Clicked()
         {
            this.Parent.em_1.SetMask(Mobilize.Web.MaskDataType.TimeMask, "HH:MM:SS");
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 1248;
            this.Y = 696;
            this.Width = 457;
            this.Height = 112;
            this.TabOrder = 30;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.Text = "Time";
            this.bnclicked = new Mobilize.Web.ClickedEventHandler(Clicked);
         }

      }

      public partial class cb_number_type
         : Mobilize.Web.CommandButton, Iw_edit_maskInner.Icb_number_type
      {

         public cb_number_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_edit_mask Parent => (w_edit_mask)base.Parent;

         public virtual int? Clicked()
         {
            this.Parent.em_1.SetMask(Mobilize.Web.MaskDataType.NumericMask, "#,###,###.##");
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 736;
            this.Y = 696;
            this.Width = 434;
            this.Height = 112;
            this.TabOrder = 50;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.Text = "Number";
            this.bnclicked = new Mobilize.Web.ClickedEventHandler(Clicked);
         }

      }

      public partial class cb_7_type
         : Mobilize.Web.CommandButton, Iw_edit_maskInner.Icb_7_type
      {

         public cb_7_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_edit_mask Parent => (w_edit_mask)base.Parent;

         public virtual int? Clicked()
         {
            string ls_mask = "";
            ls_mask = this.Parent.em_1.Mask;
            if ( Mobilize.Web.Comparison.Equals(ls_mask, "") == true )
            {
               this.Parent.em_1.Text = "Alphanumeric 123";
            }
            else if ( Mobilize.Web.Comparison.Equals(ls_mask, "(###) ####-####") == true )
            {
               this.Parent.em_1.Text = "50612345678";
            }
            else if ( Mobilize.Web.Comparison.Equals(ls_mask, "mm/dd/yyyy") == true )
            {
               this.Parent.em_1.Text = "12/31/2019";
            }
            else if ( Mobilize.Web.Comparison.Equals(ls_mask, "#,###,###.##") == true )
            {
               this.Parent.em_1.Text = "1234567.99";
            }
            else if ( Mobilize.Web.Comparison.Equals(ls_mask, "HH:MM:SS") == true )
            {
               this.Parent.em_1.Text = "11:15:23";
            }
            else
            {
               this.Parent.em_1.Text = "";
            }
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 187;
            this.Y = 692;
            this.Width = 462;
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

      public partial class cb_8_type
         : Mobilize.Web.CommandButton, Iw_edit_maskInner.Icb_8_type
      {

         public cb_8_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_edit_mask Parent => (w_edit_mask)base.Parent;

         public virtual int? Clicked()
         {
            this.Parent.em_1.SetMask(Mobilize.Web.MaskDataType.StringMask, "");
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 187;
            this.Y = 896;
            this.Width = 462;
            this.Height = 112;
            this.TabOrder = 40;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.Text = "Alphanumeric";
            this.bnclicked = new Mobilize.Web.ClickedEventHandler(Clicked);
         }

      }

      public partial class cb_9_type
         : Mobilize.Web.CommandButton, Iw_edit_maskInner.Icb_9_type
      {

         public cb_9_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_edit_mask Parent => (w_edit_mask)base.Parent;

         public virtual int? Clicked()
         {
            this.Parent.em_1.SetMask(Mobilize.Web.MaskDataType.NumericMask, "(###) ####-####");
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 736;
            this.Y = 896;
            this.Width = 434;
            this.Height = 112;
            this.TabOrder = 40;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.Text = "Telephone #";
            this.bnclicked = new Mobilize.Web.ClickedEventHandler(Clicked);
         }

      }

      public partial class cb_1_type
         : Mobilize.Web.CommandButton, Iw_edit_maskInner.Icb_1_type
      {

         public cb_1_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_edit_mask Parent => (w_edit_mask)base.Parent;

         public virtual int? Clicked()
         { //Change EditMask Show/Hide

            if ( Mobilize.Web.Comparison.Equals(this.Parent.em_1.Visible, true) == true )
            {
               this.Parent.em_1.Hide();
            }
            else
            {
               this.Parent.em_1.Show();
            }
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 50;
            this.Y = 400;
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
         : Mobilize.Web.CommandButton, Iw_edit_maskInner.Icb_3_type
      {

         public cb_3_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_edit_mask Parent => (w_edit_mask)base.Parent;

         public virtual int? Clicked()
         {
            this.Parent.em_1.SetMask(Mobilize.Web.MaskDataType.DateMask, "mm/dd/yyyy");
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 1248;
            this.Y = 896;
            this.Width = 457;
            this.Height = 112;
            this.TabOrder = 20;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.Text = "Date";
            this.bnclicked = new Mobilize.Web.ClickedEventHandler(Clicked);
         }

      }

      public partial class cb_6_type
         : Mobilize.Web.CommandButton, Iw_edit_maskInner.Icb_6_type
      {

         public cb_6_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_edit_mask Parent => (w_edit_mask)base.Parent;

         public virtual int? Clicked()
         { //GetVisible

            bool? lb_visible = false;
            lb_visible = this.Parent.em_1.Visible;
            //Change CheckBox Visible
            if ( (lb_visible) == true )
            {
               this.Parent.em_1.Visible = false;
            }
            else
            {
               this.Parent.em_1.Visible = true;
            }
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 1449;
            this.Y = 400;
            this.Width = 402;
            this.Height = 112;
            this.TabOrder = 30;
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

      public partial class cb_5_type
         : Mobilize.Web.CommandButton, Iw_edit_maskInner.Icb_5_type
      {

         public cb_5_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_edit_mask Parent => (w_edit_mask)base.Parent;

         public virtual int? Clicked()
         { //GetEnabled

            bool? lb_enabled = false;
            lb_enabled = this.Parent.em_1.Enabled;
            //Change EditMask ENABLED
            if ( (lb_enabled) == true )
            {
               this.Parent.em_1.Enabled = false;
            }
            else
            {
               this.Parent.em_1.Enabled = true;
            }
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 1015;
            this.Y = 400;
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

      public partial class cb_4_type
         : Mobilize.Web.CommandButton, Iw_edit_maskInner.Icb_4_type
      {

         public cb_4_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_edit_mask Parent => (w_edit_mask)base.Parent;

         public virtual int? Clicked()
         {
            this.Parent.cb_4.Text = "Modified";
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 503;
            this.Y = 400;
            this.Width = 485;
            this.Height = 112;
            this.TabOrder = 20;
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

      public partial class em_1_type
         : Mobilize.Web.EditMask, Iw_edit_maskInner.Iem_1_type
      {

         public em_1_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_edit_mask Parent => (w_edit_mask)base.Parent;

         public virtual int? Modified()
         {
            this.Parent.cb_4.Text = "Modified=TRUE";
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 439;
            this.Y = 128;
            this.Width = 992;
            this.Height = 112;
            this.TabOrder = 10;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.TextColor = 33554432;
            this.Text = "Edit Mask";
            this.MaskDataType = Mobilize.Web.MaskDataType.StringMask;
            this.enmodified = new Mobilize.Web.ModifiedEventHandler(Modified);
         }

      }

   }

}
#pragma warning restore
