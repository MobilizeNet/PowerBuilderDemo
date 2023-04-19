namespace medicationcenter
{

   [Mobilize.WebMap.Common.Attributes.Observable]
   public partial class w_tabbase
      : basecomponents.w_basewindow, medicationcenter.Iw_tabbase
   {

      public override void Create()
      {
         short? iCurrent = 0;
         base.Create();
         this.tab_1 = CreateInnerControl_tab_1_type();
         iCurrent = (short?)this.Control.GetUpperBound();
         this.Control[iCurrent + 1] = this.tab_1;
      }

      public override void Destroy()
      {
         base.Destroy();
         this.tab_1 = null;
      }

      protected virtual Iw_tabbaseInner.Itab_1_type CreateInnerControl_tab_1_type()
      {
         return Mobilize.Web.Application.Create<Iw_tabbaseInner.Itab_1_type>(this);
      }

      public partial class tab_1_type
         : medicationcenter.tb_tabbase, Iw_tabbaseInner.Itab_1_type
      {

         public tab_1_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_tabbase Parent => (w_tabbase)base.Parent;

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 59;
            this.Y = 60;
            this.TabOrder = 20;
         }

      }

   }

}