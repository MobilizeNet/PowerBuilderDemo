#pragma warning disable
#line 1 "w_dw_dropdowndatawindow\\w_dw_dropdowndatawindow.cs"
#pragma warning disable
#line 1 "w_dw_dropdowndatawindow\\w_dw_dropdowndatawindow.cs"
namespace pbj_webmapdemo
{

   [Mobilize.WebMap.Common.Attributes.Observable]
   public partial class w_dw_dropdowndatawindow
      : Mobilize.Web.Window, pbj_webmapdemo.Iw_dw_dropdowndatawindow
   {

      public override void Create()
      {
         this.dw_1 = CreateInnerControl_dw_1_type();
         this.Control = Mobilize.Web.ArrayExtensions.Clone<Mobilize.Web.IControl>(new Mobilize.Web.IControl[] { this.dw_1 });
      }

      public override void Destroy()
      {
         this.dw_1 = null;
      }

      public virtual int? OpenWindow()
      {
         this.dw_1.SetTransObject((Mobilize.Web.ITransaction)(Mobilize.Web.Application.CurrentApplication.Variables.SQLCA<Mobilize.Web.ITransaction>()));
         this.dw_1.Retrieve();
         return null;
      }

      public override void DoWmInit()
      {
         base.DoWmInit();
         this.open = new Mobilize.Web.OpenWindowEventHandler(OpenWindow);
      }

      protected virtual Iw_dw_dropdowndatawindowInner.Idw_1_type CreateInnerControl_dw_1_type()
      {
         return Mobilize.Web.Application.Create<Iw_dw_dropdowndatawindowInner.Idw_1_type>(this);
      }

      public partial class dw_1_type
         : Mobilize.Web.DataManagerControl, Iw_dw_dropdowndatawindowInner.Idw_1_type
      {

         public dw_1_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_dw_dropdowndatawindow Parent => (w_dw_dropdowndatawindow)base.Parent;

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 59;
            this.Y = 96;
            this.Width = 3790;
            this.Height = 596;
            this.TabOrder = 10;
            this.Title = "none";
            this.DataObject = "dw_productsbrand";
            this.LiveScroll = true;
            this.BorderStyle = Mobilize.Web.BorderStyle.StyleLowered;
         }

      }

   }

}
#pragma warning restore
