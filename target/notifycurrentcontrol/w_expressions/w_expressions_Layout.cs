namespace notifycurrentcontrol
{

   public partial class w_expressions
   {

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_expressionsInner.Ist_3_type st_3 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_expressionsInner.Ist_2_type st_2 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_expressionsInner.Ist_1_type st_1 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_expressionsInner.Idw_1_type dw_1 { get; set; }


      public w_expressions(Mobilize.Web.BaseControl parent = null)
      : base(parent)
      {
         this.Width = 2464;
         this.Height = 728;
         this.TitleBar = true;
         this.Title = "Expressions";
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