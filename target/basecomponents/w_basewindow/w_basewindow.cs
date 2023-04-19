namespace basecomponents
{

   [Mobilize.WebMap.Common.Attributes.Observable]
   public partial class w_basewindow
      : Mobilize.Web.Window, basecomponents.Iw_basewindow
   {

      public override void Create()
      {
      }

      public override void Destroy()
      {
      }

      public virtual int? OpenWindow()
      {
         PostEvent("ev_loadcontent");
         return null;
      }

      public override void DoWmInit()
      {
         base.DoWmInit();
         this.open = new Mobilize.Web.OpenWindowEventHandler(OpenWindow);
         this.ev_loadcontentEventHandler = this.ev_loadcontent;
      }

      public virtual void ev_loadcontent()
      {
      }

   }

}