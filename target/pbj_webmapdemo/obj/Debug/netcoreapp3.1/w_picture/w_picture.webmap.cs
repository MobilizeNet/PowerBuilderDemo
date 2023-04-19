#pragma warning disable
#line 1 "w_picture\\w_picture.cs"
#pragma warning disable
#line 1 "w_picture\\w_picture.cs"
namespace pbj_webmapdemo
{

   [Mobilize.WebMap.Common.Attributes.Observable]
   public partial class w_picture
      : Mobilize.Web.Window, pbj_webmapdemo.Iw_picture
   {

      public override void Create()
      {
         this.cb_4 = CreateInnerControl_cb_4_type();
         this.cb_5 = CreateInnerControl_cb_5_type();
         this.cb_6 = CreateInnerControl_cb_6_type();
         this.cb_3 = CreateInnerControl_cb_3_type();
         this.cb_1 = CreateInnerControl_cb_1_type();
         this.p_1 = CreateInnerControl_p_1_type();
         this.Control = Mobilize.Web.ArrayExtensions.Clone<Mobilize.Web.IControl>(new Mobilize.Web.IControl[] { this.cb_4, this.cb_5, this.cb_6, this.cb_3, this.cb_1, this.p_1 });
      }

      public override void Destroy()
      {
         this.cb_4 = null;
         this.cb_5 = null;
         this.cb_6 = null;
         this.cb_3 = null;
         this.cb_1 = null;
         this.p_1 = null;
      }

      protected virtual Iw_pictureInner.Icb_4_type CreateInnerControl_cb_4_type()
      {
         return Mobilize.Web.Application.Create<Iw_pictureInner.Icb_4_type>(this);
      }

      protected virtual Iw_pictureInner.Icb_5_type CreateInnerControl_cb_5_type()
      {
         return Mobilize.Web.Application.Create<Iw_pictureInner.Icb_5_type>(this);
      }

      protected virtual Iw_pictureInner.Icb_6_type CreateInnerControl_cb_6_type()
      {
         return Mobilize.Web.Application.Create<Iw_pictureInner.Icb_6_type>(this);
      }

      protected virtual Iw_pictureInner.Icb_3_type CreateInnerControl_cb_3_type()
      {
         return Mobilize.Web.Application.Create<Iw_pictureInner.Icb_3_type>(this);
      }

      protected virtual Iw_pictureInner.Icb_1_type CreateInnerControl_cb_1_type()
      {
         return Mobilize.Web.Application.Create<Iw_pictureInner.Icb_1_type>(this);
      }

      protected virtual Iw_pictureInner.Ip_1_type CreateInnerControl_p_1_type()
      {
         return Mobilize.Web.Application.Create<Iw_pictureInner.Ip_1_type>(this);
      }

      public partial class cb_4_type
         : Mobilize.Web.CommandButton, Iw_pictureInner.Icb_4_type
      {

         public cb_4_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_picture Parent => (w_picture)base.Parent;

         public virtual int? Clicked()
         { //GetEnabled

            bool? lb_enabled = false;
            lb_enabled = this.Parent.p_1.Enabled;
            //Change Picture ENABLED
            if ( (lb_enabled) == true )
            {
               this.Parent.p_1.Enabled = false;
            }
            else
            {
               this.Parent.p_1.Enabled = true;
            }
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 265;
            this.Y = 1644;
            this.Width = 402;
            this.Height = 112;
            this.TabOrder = 40;
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
         : Mobilize.Web.CommandButton, Iw_pictureInner.Icb_5_type
      {

         public cb_5_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_picture Parent => (w_picture)base.Parent;

         public virtual int? Clicked()
         { //GetVisible

            bool? lb_visible = false;
            lb_visible = this.Parent.p_1.Visible;
            //Change Picture Visible
            if ( (lb_visible) == true )
            {
               this.Parent.p_1.Visible = false;
            }
            else
            {
               this.Parent.p_1.Visible = true;
            }
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 777;
            this.Y = 1640;
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

      public partial class cb_6_type
         : Mobilize.Web.CommandButton, Iw_pictureInner.Icb_6_type
      {

         public cb_6_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_picture Parent => (w_picture)base.Parent;

         public virtual int? Clicked()
         {
            string s_picture_path = "";
            string s_picture_path_2 = "";
            s_picture_path = "https://mobilize.blob.core.windows.net/pbjava/product-images/key.jpg";
            s_picture_path_2 = "https://mobilize.blob.core.windows.net/pbjava/product-images/key2.jpg";
            if ( Mobilize.Web.Comparison.Equals(this.Parent.p_1.PictureName, s_picture_path) == true )
            {
               this.Parent.p_1.PictureName = s_picture_path_2;
            }
            else
            {
               this.Parent.p_1.PictureName = s_picture_path;
            }
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 1280;
            this.Y = 1644;
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

      public partial class cb_3_type
         : Mobilize.Web.CommandButton, Iw_pictureInner.Icb_3_type
      {

         public cb_3_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_picture Parent => (w_picture)base.Parent;

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 1275;
            this.Y = 1456;
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

      public partial class cb_1_type
         : Mobilize.Web.CommandButton, Iw_pictureInner.Icb_1_type
      {

         public cb_1_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_picture Parent => (w_picture)base.Parent;

         public virtual int? Clicked()
         { //Change Picture Show/Hide

            if ( Mobilize.Web.Comparison.Equals(this.Parent.p_1.Visible, true) == true )
            {
               this.Parent.p_1.Hide();
            }
            else
            {
               this.Parent.p_1.Show();
            }
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 261;
            this.Y = 1456;
            this.Width = 402;
            this.Height = 112;
            this.TabOrder = 10;
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

      public partial class p_1_type
         : Mobilize.Web.Picture, Iw_pictureInner.Ip_1_type
      {

         public p_1_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_picture Parent => (w_picture)base.Parent;

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
            this.Y = 372;
            this.Width = 1001;
            this.Height = 700;
            this.PictureName = "https://mobilize.blob.core.windows.net/pbjava/product-images/key.jpg";
            this.FocusRectangle = false;
            this.bnclicked = new Mobilize.Web.ClickedEventHandler(Clicked);
         }

      }

   }

}
#pragma warning restore
