#pragma warning disable
#line 1 "w_basemdi\\w_basemdi.cs"
#pragma warning disable
#line 1 "w_basemdi\\w_basemdi.cs"
namespace medicationcenter
{

   [Mobilize.WebMap.Common.Attributes.Observable]
   public partial class w_basemdi
      : basecomponents.w_basewindow, medicationcenter.Iw_basemdi
   {

      public override void Create()
      {
         short? iCurrent = 0;
         base.Create();
         if ( Mobilize.Web.Comparison.Equals(this.MenuName, "m_basemdi") == true )
         {
            this.MenuID = Mobilize.Web.Application.Create<medicationcenter.Im_basemdi>(this);
         }
         this.mdi_1 = CreateInnerControl_mdi_1_type();
         iCurrent = (short?)this.Control.GetUpperBound();
         this.Control[iCurrent + 1] = this.mdi_1;
      }

      public override void Destroy()
      {
         base.Destroy();
         if ( Mobilize.Web.BuiltInExtensions.IsValid(this.MenuID) == true )
         {
            this.MenuID = null;
         }
         this.mdi_1 = null;
      }

      protected virtual Iw_basemdiInner.Imdi_1_type CreateInnerControl_mdi_1_type()
      {
         return Mobilize.Web.Application.Create<Iw_basemdiInner.Imdi_1_type>(this);
      }

      public partial class mdi_1_type
         : Mobilize.Web.MDIClient, Iw_basemdiInner.Imdi_1_type
      {

         public mdi_1_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_basemdi Parent => (w_basemdi)base.Parent;

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.BackColor = 268435456;
         }

      }

   }

}
#pragma warning restore
