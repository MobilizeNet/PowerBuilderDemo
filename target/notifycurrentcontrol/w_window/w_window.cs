namespace notifycurrentcontrol
{

   [Mobilize.WebMap.Common.Attributes.Observable]
   public partial class w_window
      : Mobilize.Web.Window, notifycurrentcontrol.Iw_window
   {

      public override void Create()
      {
         this.st_1 = CreateInnerControl_st_1_type();
         this.dw_1 = CreateInnerControl_dw_1_type();
         this.Control = Mobilize.Web.ArrayExtensions.Clone<Mobilize.Web.IControl>(new Mobilize.Web.IControl[] { this.st_1, this.dw_1 });
      }

      public override void Destroy()
      {
         this.st_1 = null;
         this.dw_1 = null;
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

      protected virtual Iw_windowInner.Ist_1_type CreateInnerControl_st_1_type()
      {
         return Mobilize.Web.Application.Create<Iw_windowInner.Ist_1_type>(this);
      }

      protected virtual Iw_windowInner.Idw_1_type CreateInnerControl_dw_1_type()
      {
         return Mobilize.Web.Application.Create<Iw_windowInner.Idw_1_type>(this);
      }

      public class st_1_type
         : Mobilize.Web.StaticText, Iw_windowInner.Ist_1_type
      {

         public st_1_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_window Parent => (w_window)base.Parent;

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 23;
            this.Y = 1036;
            this.Width = 1792;
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

      public class dw_1_type
         : Mobilize.Web.DataManagerControl, Iw_windowInner.Idw_1_type
      {

         public dw_1_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_window Parent => (w_window)base.Parent;

         public virtual short? ItemChanged(int? row, Mobilize.Web.IDmControl dwo, string data)
         {
            this.Parent.st_1.Text = Mobilize.Web.PlusFunctions.Plus(this.Parent.st_1.Text, "itemchanged.");
            return null;
         }

         public virtual short? ItemFocusChanged(int? row, Mobilize.Web.IDmControl dwo)
         {
            this.Parent.st_1.Text = Mobilize.Web.PlusFunctions.Plus(this.Parent.st_1.Text, "itemfocuschanged.");
            return null;
         }

         public virtual short? EditChanged(int? row, Mobilize.Web.IDmControl dwo, string data)
         {
            this.Parent.st_1.Text = ""; // st_1.Text + 'editchanged.'

            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 146;
            this.Y = 100;
            this.Width = 1509;
            this.Height = 868;
            this.TabOrder = 10;
            this.Title = "none";
            this.DataObject = "d_current_control_change";
            this.LiveScroll = true;
            this.BorderStyle = Mobilize.Web.BorderStyle.StyleLowered;
            this.dwnitemchange = new Mobilize.Web.DataManagerItemChangedEventHandler(ItemChanged);
            this.dwnitemchangefocus = new Mobilize.Web.ItemFocusChangedEventHandler(ItemFocusChanged);
            this.dwnchanging = new Mobilize.Web.EditChangedEventHandler(EditChanged);
         }

      }

   }

}