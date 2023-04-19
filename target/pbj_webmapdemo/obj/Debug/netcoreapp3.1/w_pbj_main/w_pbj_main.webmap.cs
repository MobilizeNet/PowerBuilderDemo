#pragma warning disable
#line 1 "w_pbj_main\\w_pbj_main.cs"
#pragma warning disable
#line 1 "w_pbj_main\\w_pbj_main.cs"
namespace pbj_webmapdemo
{

   [Mobilize.WebMap.Common.Attributes.Observable]
   public partial class w_pbj_main
      : Mobilize.Web.Window, pbj_webmapdemo.Iw_pbj_main
   {

      public override void Create()
      {
         if ( Mobilize.Web.Comparison.Equals(this.MenuName, "m_main_menu") == true )
         {
            this.MenuID = Mobilize.Web.Application.Create<pbj_webmapdemo.Im_main_menu>(this);
         }
         this.mdi_1 = CreateInnerControl_mdi_1_type();
         this.Control = Mobilize.Web.ArrayExtensions.Clone<Mobilize.Web.IControl>(new Mobilize.Web.IControl[] { this.mdi_1 });
      }

      public override void Destroy()
      {
         if ( Mobilize.Web.BuiltInExtensions.IsValid(this.MenuID) == true )
         {
            this.MenuID = null;
         }
         this.mdi_1 = null;
      }

      protected virtual Iw_pbj_mainInner.Imdi_1_type CreateInnerControl_mdi_1_type()
      {
         return Mobilize.Web.Application.Create<Iw_pbj_mainInner.Imdi_1_type>(this);
      }

      public partial class mdi_1_type
         : Mobilize.Web.MDIClient, Iw_pbj_mainInner.Imdi_1_type
      {

         public mdi_1_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_pbj_main Parent => (w_pbj_main)base.Parent;

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.BackColor = 268435456;
         }

      }

   }

}
#pragma warning restore
