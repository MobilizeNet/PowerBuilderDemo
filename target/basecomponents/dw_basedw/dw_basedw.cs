namespace basecomponents
{

   [Mobilize.WebMap.Common.Attributes.Observable]
   public partial class dw_basedw
      : Mobilize.Web.DataManagerControl, basecomponents.Idw_basedw
   {

      public override void Create()
      {
      }

      public override void Destroy()
      {
      }

      public virtual void resetdata()
      {
         this.Reset();
         this.InsertRow(0);
      }

      public override void DoWmInit()
      {
         base.DoWmInit();
         this.resetdataEventHandler = this.resetdata;
      }

   }

}