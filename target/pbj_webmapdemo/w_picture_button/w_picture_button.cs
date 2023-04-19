namespace pbj_webmapdemo
{

   [Mobilize.WebMap.Common.Attributes.Observable]
   public partial class w_picture_button
      : Mobilize.Web.Window, pbj_webmapdemo.Iw_picture_button
   {

      public override void Create()
      {
         this.cb_1 = CreateInnerControl_cb_1_type();
         this.cb_3 = CreateInnerControl_cb_3_type();
         this.cb_6 = CreateInnerControl_cb_6_type();
         this.cb_5 = CreateInnerControl_cb_5_type();
         this.cb_4 = CreateInnerControl_cb_4_type();
         this.pb_1 = CreateInnerControl_pb_1_type();
         this.Control = Mobilize.Web.ArrayExtensions.Clone<Mobilize.Web.IControl>(new Mobilize.Web.IControl[] { this.cb_1, this.cb_3, this.cb_6, this.cb_5, this.cb_4, this.pb_1 });
      }

      public override void Destroy()
      {
         this.cb_1 = null;
         this.cb_3 = null;
         this.cb_6 = null;
         this.cb_5 = null;
         this.cb_4 = null;
         this.pb_1 = null;
      }

      protected virtual Iw_picture_buttonInner.Icb_1_type CreateInnerControl_cb_1_type()
      {
         return Mobilize.Web.Application.Create<Iw_picture_buttonInner.Icb_1_type>(this);
      }

      protected virtual Iw_picture_buttonInner.Icb_3_type CreateInnerControl_cb_3_type()
      {
         return Mobilize.Web.Application.Create<Iw_picture_buttonInner.Icb_3_type>(this);
      }

      protected virtual Iw_picture_buttonInner.Icb_6_type CreateInnerControl_cb_6_type()
      {
         return Mobilize.Web.Application.Create<Iw_picture_buttonInner.Icb_6_type>(this);
      }

      protected virtual Iw_picture_buttonInner.Icb_5_type CreateInnerControl_cb_5_type()
      {
         return Mobilize.Web.Application.Create<Iw_picture_buttonInner.Icb_5_type>(this);
      }

      protected virtual Iw_picture_buttonInner.Icb_4_type CreateInnerControl_cb_4_type()
      {
         return Mobilize.Web.Application.Create<Iw_picture_buttonInner.Icb_4_type>(this);
      }

      protected virtual Iw_picture_buttonInner.Ipb_1_type CreateInnerControl_pb_1_type()
      {
         return Mobilize.Web.Application.Create<Iw_picture_buttonInner.Ipb_1_type>(this);
      }

      public class cb_1_type
         : Mobilize.Web.CommandButton, Iw_picture_buttonInner.Icb_1_type
      {

         public cb_1_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_picture_button Parent => (w_picture_button)base.Parent;

         public virtual int? Clicked()
         { //Change Picture Button Show/Hide

            if ( Mobilize.Web.Comparison.Equals(this.Parent.pb_1.Visible, true) == true )
            {
               this.Parent.pb_1.Hide();
            }
            else
            {
               this.Parent.pb_1.Show();
            }
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 283;
            this.Y = 1368;
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

      public class cb_3_type
         : Mobilize.Web.CommandButton, Iw_picture_buttonInner.Icb_3_type
      {

         public cb_3_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_picture_button Parent => (w_picture_button)base.Parent;

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 1298;
            this.Y = 1368;
            this.Width = 402;
            this.Height = 112;
            this.TabOrder = 20;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.Text = "Click";
         }

      }

      public class cb_6_type
         : Mobilize.Web.CommandButton, Iw_picture_buttonInner.Icb_6_type
      {

         public cb_6_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_picture_button Parent => (w_picture_button)base.Parent;

         public virtual int? Clicked()
         {
            string s_picture_path = "";
            string s_picture_path_2 = "";
            s_picture_path = "https://mobilize.blob.core.windows.net/pbjava/product-images/key.jpg";
            s_picture_path_2 = "https://mobilize.blob.core.windows.net/pbjava/product-images/key2.jpg";
            if ( Mobilize.Web.Comparison.Equals(this.Parent.pb_1.PictureName, s_picture_path) == true )
            {
               this.Parent.pb_1.PictureName = s_picture_path_2;
            }
            else
            {
               this.Parent.pb_1.PictureName = s_picture_path;
            }
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 1303;
            this.Y = 1556;
            this.Width = 402;
            this.Height = 112;
            this.TabOrder = 30;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.Text = "PictureName";
            this.bnclicked = new Mobilize.Web.ClickedEventHandler(Clicked);
         }

      }

      public class cb_5_type
         : Mobilize.Web.CommandButton, Iw_picture_buttonInner.Icb_5_type
      {

         public cb_5_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_picture_button Parent => (w_picture_button)base.Parent;

         public virtual int? Clicked()
         { //GetVisible

            bool? lb_visible = false;
            lb_visible = this.Parent.pb_1.Visible;
            //Change PictureButton Visible
            if ( (lb_visible) == true )
            {
               this.Parent.pb_1.Visible = false;
            }
            else
            {
               this.Parent.pb_1.Visible = true;
            }
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 800;
            this.Y = 1552;
            this.Width = 402;
            this.Height = 112;
            this.TabOrder = 20;
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
         : Mobilize.Web.CommandButton, Iw_picture_buttonInner.Icb_4_type
      {

         public cb_4_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_picture_button Parent => (w_picture_button)base.Parent;

         public virtual int? Clicked()
         { //GetEnabled

            bool? lb_enabled = false;
            lb_enabled = this.Parent.pb_1.Enabled;
            //Change PictureButton ENABLED
            if ( (lb_enabled) == true )
            {
               this.Parent.pb_1.Enabled = false;
            }
            else
            {
               this.Parent.pb_1.Enabled = true;
            }
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 288;
            this.Y = 1556;
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

      public class pb_1_type
         : Mobilize.Web.PictureButton, Iw_picture_buttonInner.Ipb_1_type
      {

         public pb_1_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_picture_button Parent => (w_picture_button)base.Parent;

         public virtual int? Clicked()
         { //Change Click button text

            if ( Mobilize.Web.Comparison.Equals(this.Parent.cb_3.Text, "Click") == true )
            {
               this.Parent.cb_3.Text = "Clicked";
            }
            else
            {
               this.Parent.cb_3.Text = "Click";
            }
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 462;
            this.Y = 368;
            this.Width = 1001;
            this.Height = 700;
            this.TabOrder = 10;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.Text = "Picture Button";
            this.PictureName = "https://mobilize.blob.core.windows.net/pbjava/product-images/key2.jpg";
            this.HTextAlign = Mobilize.Web.Alignment.Left;
            this.bnclicked = new Mobilize.Web.ClickedEventHandler(Clicked);
         }

      }

   }

}