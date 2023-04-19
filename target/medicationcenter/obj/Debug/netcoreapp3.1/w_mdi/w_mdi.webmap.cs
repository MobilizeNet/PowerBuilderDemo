#pragma warning disable
#line 1 "w_mdi\\w_mdi.cs"
#pragma warning disable
#line 1 "w_mdi\\w_mdi.cs"
namespace medicationcenter
{

   [Mobilize.WebMap.Common.Attributes.Observable]
   public partial class w_mdi
      : medicationcenter.w_basemdi, medicationcenter.Iw_mdi
   {

      public override void Create()
      {
         base.Create();
      }

      public override void Destroy()
      {
         base.Destroy();
         if ( Mobilize.Web.BuiltInExtensions.IsValid(this.MenuID) == true )
         {
            this.MenuID = null;
         }
      }

      public override void ev_loadcontent()
      {
         base.ev_loadcontent();
         if ( ((bool?)(Mobilize.Web.Application.CurrentApplication.Variables.isAdmin<bool?>())) == true )
         {
            ChangeMenu(Mobilize.Web.ReferenceExtensions.Ref<Mobilize.Web.IMenu>((Mobilize.Web.IMenu)Mobilize.Web.Application.CurrentApplication.Variables.m_adminmdi<medicationcenter.Im_adminmdi>(), (v) => Mobilize.Web.Application.CurrentApplication.Variables.m_adminmdi = (medicationcenter.Im_adminmdi)v, () => Mobilize.Web.Application.CurrentApplication.Variables.m_adminmdi<medicationcenter.Im_adminmdi>()));
         }
      }

      public override void DoWmInit()
      {
         base.DoWmInit();
         ;
      }

      protected override medicationcenter.Iw_basemdiInner.Imdi_1_type CreateInnerControl_mdi_1_type()
      {
         return Mobilize.Web.Application.Create<Iw_mdiInner.Imdi_1_type>(this);
      }

      public partial class mdi_1_type
         : medicationcenter.w_basemdi.mdi_1_type, Iw_mdiInner.Imdi_1_type
      {

         public mdi_1_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_mdi Parent => (w_mdi)base.Parent;

      }

   }

}
#pragma warning restore
