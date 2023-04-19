namespace basecomponents
{

   [Mobilize.WebMap.Common.Attributes.Observable]
   public partial class dw_showallbase
      : basecomponents.dw_basedw, basecomponents.Idw_showallbase
   {

      public override void Create()
      {
         base.Create();
      }

      public override void Destroy()
      {
         base.Destroy();
      }

      public override void DoWmInit()
      {
         base.DoWmInit();
         this.updatedataEventHandler = this.updatedata;
      }

      public virtual void updatedata()
      {
      }

   }

}