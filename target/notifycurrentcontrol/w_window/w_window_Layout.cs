namespace notifycurrentcontrol
{

   public partial class w_window
   {

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_windowInner.Ist_1_type st_1 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_windowInner.Idw_1_type dw_1 { get; set; }


      public w_window(Mobilize.Web.BaseControl parent = null)
      : base(parent)
      {
         this.Width = 1888;
         this.Height = 1272;
         this.TitleBar = true;
         this.Title = "Notify Current Control Change";
         this.ControlMenu = true;
         this.MinBox = true;
         this.MaxBox = true;
         this.Resizable = true;
         this.BackColor = 67108864;
         this.Icon = "AppIcon!";
         this.Center = true;
      }
   }

}