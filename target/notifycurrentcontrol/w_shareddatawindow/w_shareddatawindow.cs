namespace notifycurrentcontrol
{

   [Mobilize.WebMap.Common.Attributes.Observable]
   public partial class w_shareddatawindow
      : Mobilize.Web.Window, notifycurrentcontrol.Iw_shareddatawindow
   {

      public override void Create()
      {
         this.st_3 = CreateInnerControl_st_3_type();
         this.st_2 = CreateInnerControl_st_2_type();
         this.st_1 = CreateInnerControl_st_1_type();
         this.cb_2 = CreateInnerControl_cb_2_type();
         this.cb_1 = CreateInnerControl_cb_1_type();
         this.dw_3 = CreateInnerControl_dw_3_type();
         this.dw_2 = CreateInnerControl_dw_2_type();
         this.dw_1 = CreateInnerControl_dw_1_type();
         this.Control = Mobilize.Web.ArrayExtensions.Clone<Mobilize.Web.IControl>(new Mobilize.Web.IControl[] { this.st_3, this.st_2, this.st_1, this.cb_2, this.cb_1, this.dw_3, this.dw_2, this.dw_1 });
      }

      public override void Destroy()
      {
         this.st_3 = null;
         this.st_2 = null;
         this.st_1 = null;
         this.cb_2 = null;
         this.cb_1 = null;
         this.dw_3 = null;
         this.dw_2 = null;
         this.dw_1 = null;
      }

      public virtual void getvalues(short? row, string column)
      {
         this.st_1.Text = this.dw_1.GetItemString(row, column);
         this.st_2.Text = this.dw_2.GetItemString(row, column);
         this.st_3.Text = this.dw_3.GetItemString(row, column);
      }

      public virtual int? OpenWindow()
      {
         this.dw_1.SetTransObject((Mobilize.Web.ITransaction)(Mobilize.Web.Application.CurrentApplication.Variables.SQLCA<Mobilize.Web.ITransaction>()));
         this.dw_1.ShareData(this.dw_2);
         this.dw_1.ShareData(this.dw_3);
         this.dw_1.Retrieve();
         return null;
      }

      public override void DoWmInit()
      {
         base.DoWmInit();
         this.open = new Mobilize.Web.OpenWindowEventHandler(OpenWindow);
      }

      protected virtual Iw_shareddatawindowInner.Ist_3_type CreateInnerControl_st_3_type()
      {
         return Mobilize.Web.Application.Create<Iw_shareddatawindowInner.Ist_3_type>(this);
      }

      protected virtual Iw_shareddatawindowInner.Ist_2_type CreateInnerControl_st_2_type()
      {
         return Mobilize.Web.Application.Create<Iw_shareddatawindowInner.Ist_2_type>(this);
      }

      protected virtual Iw_shareddatawindowInner.Ist_1_type CreateInnerControl_st_1_type()
      {
         return Mobilize.Web.Application.Create<Iw_shareddatawindowInner.Ist_1_type>(this);
      }

      protected virtual Iw_shareddatawindowInner.Icb_2_type CreateInnerControl_cb_2_type()
      {
         return Mobilize.Web.Application.Create<Iw_shareddatawindowInner.Icb_2_type>(this);
      }

      protected virtual Iw_shareddatawindowInner.Icb_1_type CreateInnerControl_cb_1_type()
      {
         return Mobilize.Web.Application.Create<Iw_shareddatawindowInner.Icb_1_type>(this);
      }

      protected virtual Iw_shareddatawindowInner.Idw_3_type CreateInnerControl_dw_3_type()
      {
         return Mobilize.Web.Application.Create<Iw_shareddatawindowInner.Idw_3_type>(this);
      }

      protected virtual Iw_shareddatawindowInner.Idw_2_type CreateInnerControl_dw_2_type()
      {
         return Mobilize.Web.Application.Create<Iw_shareddatawindowInner.Idw_2_type>(this);
      }

      protected virtual Iw_shareddatawindowInner.Idw_1_type CreateInnerControl_dw_1_type()
      {
         return Mobilize.Web.Application.Create<Iw_shareddatawindowInner.Idw_1_type>(this);
      }

      public class st_3_type
         : Mobilize.Web.StaticText, Iw_shareddatawindowInner.Ist_3_type
      {

         public st_3_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_shareddatawindow Parent => (w_shareddatawindow)base.Parent;

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 1669;
            this.Y = 952;
            this.Width = 786;
            this.Height = 64;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.TextColor = 33554432;
            this.BackColor = 67108864;
            this.FocusRectangle = false;
         }

      }

      public class st_2_type
         : Mobilize.Web.StaticText, Iw_shareddatawindowInner.Ist_2_type
      {

         public st_2_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_shareddatawindow Parent => (w_shareddatawindow)base.Parent;

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 873;
            this.Y = 952;
            this.Width = 786;
            this.Height = 64;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.TextColor = 33554432;
            this.BackColor = 67108864;
            this.FocusRectangle = false;
         }

      }

      public class st_1_type
         : Mobilize.Web.StaticText, Iw_shareddatawindowInner.Ist_1_type
      {

         public st_1_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_shareddatawindow Parent => (w_shareddatawindow)base.Parent;

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 32;
            this.Y = 952;
            this.Width = 786;
            this.Height = 64;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.TextColor = 33554432;
            this.BackColor = 67108864;
            this.FocusRectangle = false;
         }

      }

      public class cb_2_type
         : Mobilize.Web.CommandButton, Iw_shareddatawindowInner.Icb_2_type
      {

         public cb_2_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_shareddatawindow Parent => (w_shareddatawindow)base.Parent;

         public virtual int? Clicked()
         {
            this.Parent.dw_1.DeleteRow(this.Parent.dw_1.GetRow());
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 485;
            this.Y = 1076;
            this.Width = 402;
            this.Height = 112;
            this.TabOrder = 30;
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

      public class cb_1_type
         : Mobilize.Web.CommandButton, Iw_shareddatawindowInner.Icb_1_type
      {

         public cb_1_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_shareddatawindow Parent => (w_shareddatawindow)base.Parent;

         public virtual int? Clicked()
         {
            this.Parent.dw_1.InsertRow(1);
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 73;
            this.Y = 1076;
            this.Width = 402;
            this.Height = 112;
            this.TabOrder = 30;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.Text = "Add";
            this.bnclicked = new Mobilize.Web.ClickedEventHandler(Clicked);
         }

      }

      public class dw_3_type
         : Mobilize.Web.DataManagerControl, Iw_shareddatawindowInner.Idw_3_type
      {

         public dw_3_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_shareddatawindow Parent => (w_shareddatawindow)base.Parent;

         public virtual short? ItemChanged(int? row, Mobilize.Web.IDmControl dwo, string data)
         {
            this.Parent.PostMethod("getvalues", new object[] { (short?)row, dwo.Name });
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 1664;
            this.Y = 56;
            this.Width = 795;
            this.Height = 896;
            this.TabOrder = 20;
            this.Title = "none";
            this.DataObject = "d_users";
            this.VScrollBar = true;
            this.LiveScroll = true;
            this.BorderStyle = Mobilize.Web.BorderStyle.StyleLowered;
            this.dwnitemchange = new Mobilize.Web.DataManagerItemChangedEventHandler(ItemChanged);
         }

      }

      public class dw_2_type
         : Mobilize.Web.DataManagerControl, Iw_shareddatawindowInner.Idw_2_type
      {

         public dw_2_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_shareddatawindow Parent => (w_shareddatawindow)base.Parent;

         public virtual short? ItemChanged(int? row, Mobilize.Web.IDmControl dwo, string data)
         {
            this.Parent.PostMethod("getvalues", new object[] { (short?)row, dwo.Name });
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 855;
            this.Y = 56;
            this.Width = 795;
            this.Height = 896;
            this.TabOrder = 10;
            this.Title = "none";
            this.DataObject = "d_users";
            this.VScrollBar = true;
            this.LiveScroll = true;
            this.BorderStyle = Mobilize.Web.BorderStyle.StyleLowered;
            this.dwnitemchange = new Mobilize.Web.DataManagerItemChangedEventHandler(ItemChanged);
         }

      }

      public class dw_1_type
         : Mobilize.Web.DataManagerControl, Iw_shareddatawindowInner.Idw_1_type
      {

         public dw_1_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_shareddatawindow Parent => (w_shareddatawindow)base.Parent;

         public virtual short? ItemChanged(int? row, Mobilize.Web.IDmControl dwo, string data)
         {
            this.Parent.PostMethod("getvalues", new object[] { (short?)row, dwo.Name });
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 37;
            this.Y = 56;
            this.Width = 795;
            this.Height = 896;
            this.TabOrder = 10;
            this.Title = "none";
            this.DataObject = "d_users";
            this.VScrollBar = true;
            this.LiveScroll = true;
            this.BorderStyle = Mobilize.Web.BorderStyle.StyleLowered;
            this.dwnitemchange = new Mobilize.Web.DataManagerItemChangedEventHandler(ItemChanged);
         }

      }

   }

}