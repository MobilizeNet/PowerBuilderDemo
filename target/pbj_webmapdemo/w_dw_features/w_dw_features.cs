namespace pbj_webmapdemo
{

   [Mobilize.WebMap.Common.Attributes.Observable]
   public partial class w_dw_features
      : Mobilize.Web.Window, pbj_webmapdemo.Iw_dw_features
   {

      public override void Create()
      {
         this.rb_freeform = CreateInnerControl_rb_freeform_type();
         this.rb_grid = CreateInnerControl_rb_grid_type();
         this.rb_4 = CreateInnerControl_rb_4_type();
         this.rb_3 = CreateInnerControl_rb_3_type();
         this.rb_2 = CreateInnerControl_rb_2_type();
         this.rb_1 = CreateInnerControl_rb_1_type();
         this.st_4 = CreateInnerControl_st_4_type();
         this.sle_1 = CreateInnerControl_sle_1_type();
         this.cb_6 = CreateInnerControl_cb_6_type();
         this.cb_5 = CreateInnerControl_cb_5_type();
         this.cb_4 = CreateInnerControl_cb_4_type();
         this.cb_3 = CreateInnerControl_cb_3_type();
         this.cb_2 = CreateInnerControl_cb_2_type();
         this.cb_1 = CreateInnerControl_cb_1_type();
         this.dw_1 = CreateInnerControl_dw_1_type();
         this.gb_1 = CreateInnerControl_gb_1_type();
         this.gb_2 = CreateInnerControl_gb_2_type();
         this.gb_3 = CreateInnerControl_gb_3_type();
         this.Control = Mobilize.Web.ArrayExtensions.Clone<Mobilize.Web.IControl>(new Mobilize.Web.IControl[] { this.rb_freeform, this.rb_grid, this.rb_4, this.rb_3, this.rb_2, this.rb_1, this.st_4, this.sle_1, this.cb_6, this.cb_5, this.cb_4, this.cb_3, this.cb_2, this.cb_1, this.dw_1, this.gb_1, this.gb_2, this.gb_3 });
      }

      public override void Destroy()
      {
         this.rb_freeform = null;
         this.rb_grid = null;
         this.rb_4 = null;
         this.rb_3 = null;
         this.rb_2 = null;
         this.rb_1 = null;
         this.st_4 = null;
         this.sle_1 = null;
         this.cb_6 = null;
         this.cb_5 = null;
         this.cb_4 = null;
         this.cb_3 = null;
         this.cb_2 = null;
         this.cb_1 = null;
         this.dw_1 = null;
         this.gb_1 = null;
         this.gb_2 = null;
         this.gb_3 = null;
      }

      public virtual int? OpenWindow()
      {
         this.dw_1.DataObject = "dw_categories_freeform";
         //dw_1.dataobject = "dw_categories"
         this.rb_freeform.Checked = true;
         this.dw_1.SetTransObject((Mobilize.Web.ITransaction)(Mobilize.Web.Application.CurrentApplication.Variables.SQLCA<Mobilize.Web.ITransaction>()));
         return null;
      }

      public override void DoWmInit()
      {
         base.DoWmInit();
         this.open = new Mobilize.Web.OpenWindowEventHandler(OpenWindow);
      }

      protected virtual Iw_dw_featuresInner.Irb_freeform_type CreateInnerControl_rb_freeform_type()
      {
         return Mobilize.Web.Application.Create<Iw_dw_featuresInner.Irb_freeform_type>(this);
      }

      protected virtual Iw_dw_featuresInner.Irb_grid_type CreateInnerControl_rb_grid_type()
      {
         return Mobilize.Web.Application.Create<Iw_dw_featuresInner.Irb_grid_type>(this);
      }

      protected virtual Iw_dw_featuresInner.Irb_4_type CreateInnerControl_rb_4_type()
      {
         return Mobilize.Web.Application.Create<Iw_dw_featuresInner.Irb_4_type>(this);
      }

      protected virtual Iw_dw_featuresInner.Irb_3_type CreateInnerControl_rb_3_type()
      {
         return Mobilize.Web.Application.Create<Iw_dw_featuresInner.Irb_3_type>(this);
      }

      protected virtual Iw_dw_featuresInner.Irb_2_type CreateInnerControl_rb_2_type()
      {
         return Mobilize.Web.Application.Create<Iw_dw_featuresInner.Irb_2_type>(this);
      }

      protected virtual Iw_dw_featuresInner.Irb_1_type CreateInnerControl_rb_1_type()
      {
         return Mobilize.Web.Application.Create<Iw_dw_featuresInner.Irb_1_type>(this);
      }

      protected virtual Iw_dw_featuresInner.Ist_4_type CreateInnerControl_st_4_type()
      {
         return Mobilize.Web.Application.Create<Iw_dw_featuresInner.Ist_4_type>(this);
      }

      protected virtual Iw_dw_featuresInner.Isle_1_type CreateInnerControl_sle_1_type()
      {
         return Mobilize.Web.Application.Create<Iw_dw_featuresInner.Isle_1_type>(this);
      }

      protected virtual Iw_dw_featuresInner.Icb_6_type CreateInnerControl_cb_6_type()
      {
         return Mobilize.Web.Application.Create<Iw_dw_featuresInner.Icb_6_type>(this);
      }

      protected virtual Iw_dw_featuresInner.Icb_5_type CreateInnerControl_cb_5_type()
      {
         return Mobilize.Web.Application.Create<Iw_dw_featuresInner.Icb_5_type>(this);
      }

      protected virtual Iw_dw_featuresInner.Icb_4_type CreateInnerControl_cb_4_type()
      {
         return Mobilize.Web.Application.Create<Iw_dw_featuresInner.Icb_4_type>(this);
      }

      protected virtual Iw_dw_featuresInner.Icb_3_type CreateInnerControl_cb_3_type()
      {
         return Mobilize.Web.Application.Create<Iw_dw_featuresInner.Icb_3_type>(this);
      }

      protected virtual Iw_dw_featuresInner.Icb_2_type CreateInnerControl_cb_2_type()
      {
         return Mobilize.Web.Application.Create<Iw_dw_featuresInner.Icb_2_type>(this);
      }

      protected virtual Iw_dw_featuresInner.Icb_1_type CreateInnerControl_cb_1_type()
      {
         return Mobilize.Web.Application.Create<Iw_dw_featuresInner.Icb_1_type>(this);
      }

      protected virtual Iw_dw_featuresInner.Idw_1_type CreateInnerControl_dw_1_type()
      {
         return Mobilize.Web.Application.Create<Iw_dw_featuresInner.Idw_1_type>(this);
      }

      protected virtual Iw_dw_featuresInner.Igb_1_type CreateInnerControl_gb_1_type()
      {
         return Mobilize.Web.Application.Create<Iw_dw_featuresInner.Igb_1_type>(this);
      }

      protected virtual Iw_dw_featuresInner.Igb_2_type CreateInnerControl_gb_2_type()
      {
         return Mobilize.Web.Application.Create<Iw_dw_featuresInner.Igb_2_type>(this);
      }

      protected virtual Iw_dw_featuresInner.Igb_3_type CreateInnerControl_gb_3_type()
      {
         return Mobilize.Web.Application.Create<Iw_dw_featuresInner.Igb_3_type>(this);
      }

      public class rb_freeform_type
         : Mobilize.Web.RadioButton, Iw_dw_featuresInner.Irb_freeform_type
      {

         public rb_freeform_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_dw_features Parent => (w_dw_features)base.Parent;

         public virtual int? Clicked()
         {
            this.Parent.dw_1.DataObject = "dw_categories_freeform";
            this.Parent.dw_1.SetTransObject((Mobilize.Web.ITransaction)(Mobilize.Web.Application.CurrentApplication.Variables.SQLCA<Mobilize.Web.ITransaction>()));
            this.Parent.dw_1.Retrieve();
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 2898;
            this.Y = 920;
            this.Width = 338;
            this.Height = 84;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.TextColor = 33554432;
            this.BackColor = 67108864;
            this.Text = "FreeForm";
            this.bnclicked = new Mobilize.Web.ClickedEventHandler(Clicked);
         }

      }

      public class rb_grid_type
         : Mobilize.Web.RadioButton, Iw_dw_featuresInner.Irb_grid_type
      {

         public rb_grid_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_dw_features Parent => (w_dw_features)base.Parent;

         public virtual int? Clicked()
         {
            this.Parent.dw_1.DataObject = "dw_categories";
            this.Parent.dw_1.SetTransObject((Mobilize.Web.ITransaction)(Mobilize.Web.Application.CurrentApplication.Variables.SQLCA<Mobilize.Web.ITransaction>()));
            this.Parent.dw_1.Retrieve();
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 2894;
            this.Y = 820;
            this.Width = 320;
            this.Height = 84;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.TextColor = 33554432;
            this.BackColor = 67108864;
            this.Text = "Grid";
            this.bnclicked = new Mobilize.Web.ClickedEventHandler(Clicked);
         }

      }

      public class rb_4_type
         : Mobilize.Web.RadioButton, Iw_dw_featuresInner.Irb_4_type
      {

         public rb_4_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_dw_features Parent => (w_dw_features)base.Parent;

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 2912;
            this.Y = 564;
            this.Width = 270;
            this.Height = 80;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.TextColor = 33554432;
            this.BackColor = 67108864;
            this.Text = "Name";
         }

      }

      public class rb_3_type
         : Mobilize.Web.RadioButton, Iw_dw_featuresInner.Irb_3_type
      {

         public rb_3_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_dw_features Parent => (w_dw_features)base.Parent;

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 2912;
            this.Y = 452;
            this.Width = 197;
            this.Height = 80;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.TextColor = 33554432;
            this.BackColor = 67108864;
            this.Text = "Id";
            this.Checked = true;
         }

      }

      public class rb_2_type
         : Mobilize.Web.RadioButton, Iw_dw_featuresInner.Irb_2_type
      {

         public rb_2_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_dw_features Parent => (w_dw_features)base.Parent;

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 2949;
            this.Y = 248;
            this.Width = 274;
            this.Height = 80;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.TextColor = 33554432;
            this.BackColor = 67108864;
            this.Text = "Desc";
         }

      }

      public class rb_1_type
         : Mobilize.Web.RadioButton, Iw_dw_featuresInner.Irb_1_type
      {

         public rb_1_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_dw_features Parent => (w_dw_features)base.Parent;

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 2949;
            this.Y = 136;
            this.Width = 274;
            this.Height = 80;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.TextColor = 33554432;
            this.BackColor = 67108864;
            this.Text = "Asc";
            this.Checked = true;
         }

      }

      public class st_4_type
         : Mobilize.Web.StaticText, Iw_dw_featuresInner.Ist_4_type
      {

         public st_4_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_dw_features Parent => (w_dw_features)base.Parent;

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 2885;
            this.Y = 1160;
            this.Width = 379;
            this.Height = 64;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.TextColor = 33554432;
            this.BackColor = 67108864;
            this.Text = "Filter Id";
            this.FocusRectangle = false;
         }

      }

      public class sle_1_type
         : Mobilize.Web.SingleLineEdit, Iw_dw_featuresInner.Isle_1_type
      {

         public sle_1_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_dw_features Parent => (w_dw_features)base.Parent;

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 2880;
            this.Y = 1252;
            this.Width = 379;
            this.Height = 112;
            this.TabOrder = 60;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.TextColor = 33554432;
            this.BorderStyle = Mobilize.Web.BorderStyle.StyleLowered;
         }

      }

      public class cb_6_type
         : Mobilize.Web.CommandButton, Iw_dw_featuresInner.Icb_6_type
      {

         public cb_6_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_dw_features Parent => (w_dw_features)base.Parent;

         public virtual int? Clicked()
         {
            string ls_sort = "", ls_column = "";
            if ( Mobilize.Web.Comparison.Equals(this.Parent.rb_1.Checked, true) == true )
            {
               ls_sort = " asc";
            }
            else
            {
               ls_sort = " desc";
            }
            if ( Mobilize.Web.Comparison.Equals(this.Parent.rb_3.Checked, true) == true )
            {
               ls_column = "id";
            }
            else
            {
               ls_column = "name";
            }
            this.Parent.dw_1.SetSort(Mobilize.Web.PlusFunctions.Plus(ls_column, ls_sort));
            this.Parent.dw_1.Sort();
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 1870;
            this.Y = 1124;
            this.Width = 402;
            this.Height = 112;
            this.TabOrder = 60;
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

      public class cb_5_type
         : Mobilize.Web.CommandButton, Iw_dw_featuresInner.Icb_5_type
      {

         public cb_5_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_dw_features Parent => (w_dw_features)base.Parent;

         public virtual int? Clicked()
         {
            if ( Mobilize.Web.Comparison.NotEquals(this.Parent.sle_1.Text, "") == true )
            {
               this.Parent.dw_1.SetFilter(Mobilize.Web.PlusFunctions.Plus("id = ", this.Parent.sle_1.Text));
            }
            else
            {
               this.Parent.dw_1.SetFilter("");
            }
            this.Parent.dw_1.Filter();
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 2327;
            this.Y = 1124;
            this.Width = 402;
            this.Height = 112;
            this.TabOrder = 50;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.Text = "Filter";
            this.bnclicked = new Mobilize.Web.ClickedEventHandler(Clicked);
         }

      }

      public class cb_4_type
         : Mobilize.Web.CommandButton, Iw_dw_featuresInner.Icb_4_type
      {

         public cb_4_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_dw_features Parent => (w_dw_features)base.Parent;

         public virtual int? Clicked()
         {
            this.Parent.dw_1.DeleteRow(this.Parent.dw_1.GetRow());
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 955;
            this.Y = 1124;
            this.Width = 402;
            this.Height = 112;
            this.TabOrder = 50;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.Text = "Delete";
            this.bnclicked = new Mobilize.Web.ClickedEventHandler(Clicked);
         }

      }

      public class cb_3_type
         : Mobilize.Web.CommandButton, Iw_dw_featuresInner.Icb_3_type
      {

         public cb_3_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_dw_features Parent => (w_dw_features)base.Parent;

         public virtual int? Clicked()
         {
            short? li_result = 0;
            li_result = this.Parent.dw_1.Update();
            if ( Mobilize.Web.Comparison.Equals(li_result, 1) == true )
            {
               Mobilize.Web.MessageBox.Show("Message", "Data updated successfully", Mobilize.Web.Icon.Information);
            }
            else
            {
               Mobilize.Web.MessageBox.Show("Error", "Error Updating information", Mobilize.Web.Icon.StopSign);
            }
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 1413;
            this.Y = 1124;
            this.Width = 402;
            this.Height = 112;
            this.TabOrder = 40;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.Text = "Update";
            this.bnclicked = new Mobilize.Web.ClickedEventHandler(Clicked);
         }

      }

      public class cb_2_type
         : Mobilize.Web.CommandButton, Iw_dw_featuresInner.Icb_2_type
      {

         public cb_2_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_dw_features Parent => (w_dw_features)base.Parent;

         public virtual int? Clicked()
         {
            this.Parent.dw_1.InsertRow(0);
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 498;
            this.Y = 1124;
            this.Width = 402;
            this.Height = 112;
            this.TabOrder = 30;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.Text = "Insert";
            this.bnclicked = new Mobilize.Web.ClickedEventHandler(Clicked);
         }

      }

      public class cb_1_type
         : Mobilize.Web.CommandButton, Iw_dw_featuresInner.Icb_1_type
      {

         public cb_1_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_dw_features Parent => (w_dw_features)base.Parent;

         public virtual int? Clicked()
         {
            this.Parent.dw_1.Retrieve();
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 41;
            this.Y = 1124;
            this.Width = 402;
            this.Height = 112;
            this.TabOrder = 20;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.Text = "Retrieve";
            this.bnclicked = new Mobilize.Web.ClickedEventHandler(Clicked);
         }

      }

      public class dw_1_type
         : Mobilize.Web.DataManagerControl, Iw_dw_featuresInner.Idw_1_type
      {

         public dw_1_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_dw_features Parent => (w_dw_features)base.Parent;

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 41;
            this.Y = 96;
            this.Width = 2784;
            this.Height = 988;
            this.TabOrder = 10;
            this.Title = "none";
            this.LiveScroll = true;
            this.BorderStyle = Mobilize.Web.BorderStyle.StyleLowered;
         }

      }

      public class gb_1_type
         : Mobilize.Web.GroupBox, Iw_dw_featuresInner.Igb_1_type
      {

         public gb_1_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_dw_features Parent => (w_dw_features)base.Parent;

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 2857;
            this.Y = 52;
            this.Width = 398;
            this.Height = 324;
            this.TabOrder = 20;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.TextColor = 33554432;
            this.BackColor = 67108864;
            this.Text = "Sort";
         }

      }

      public class gb_2_type
         : Mobilize.Web.GroupBox, Iw_dw_featuresInner.Igb_2_type
      {

         public gb_2_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_dw_features Parent => (w_dw_features)base.Parent;

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 2857;
            this.Y = 388;
            this.Width = 407;
            this.Height = 324;
            this.TabOrder = 20;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.TextColor = 33554432;
            this.BackColor = 67108864;
            this.Text = "Sort Column";
         }

      }

      public class gb_3_type
         : Mobilize.Web.GroupBox, Iw_dw_featuresInner.Igb_3_type
      {

         public gb_3_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_dw_features Parent => (w_dw_features)base.Parent;

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 2857;
            this.Y = 740;
            this.Width = 407;
            this.Height = 324;
            this.TabOrder = 30;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.TextColor = 33554432;
            this.BackColor = 67108864;
            this.Text = "DW Type";
         }

      }

   }

}