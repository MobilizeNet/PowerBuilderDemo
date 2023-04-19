#pragma warning disable
#line 1 "ou_showallprescriptions\\ou_showallprescriptions.cs"
#pragma warning disable
#line 1 "ou_showallprescriptions\\ou_showallprescriptions.cs"
namespace medicationcenter
{

   [Mobilize.WebMap.Common.Attributes.Observable]
   public partial class ou_showallprescriptions
      : Mobilize.Web.UserObject, medicationcenter.Iou_showallprescriptions
   {

      public override void Create()
      {
         this.dw_all = CreateInnerControl_dw_all_type();
         this.Control = Mobilize.Web.ArrayExtensions.Clone<Mobilize.Web.IControl>(new Mobilize.Web.IControl[] { this.dw_all });
      }

      public override void Destroy()
      {
         this.dw_all = null;
      }

      public virtual int? Constructor()
      {
         this.dw_all.TriggerEvent("updatedata");
         return null;
      }

      public override void DoWmInit()
      {
         base.DoWmInit();
         this.constructor = new Mobilize.Web.ConstructorEventHandler(Constructor);
      }

      protected virtual Iou_showallprescriptionsInner.Idw_all_type CreateInnerControl_dw_all_type()
      {
         return Mobilize.Web.Application.Create<Iou_showallprescriptionsInner.Idw_all_type>(this);
      }

      public partial class dw_all_type
         : medicationcenter.dw_showallprescriptions, Iou_showallprescriptionsInner.Idw_all_type
      {

         public dw_all_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new ou_showallprescriptions Parent => (ou_showallprescriptions)base.Parent;

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 32;
            this.Y = 32;
            this.Width = 3438;
            this.Height = 776;
            this.TabOrder = 10;
            this.DataObject = "d_showallprescrpition";
         }

      }

   }

}
#pragma warning restore
