namespace reports
{

   public partial class w_main_report
   {

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_main_reportInner.Icb_3_type cb_3 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_main_reportInner.Icb_2_type cb_2 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_main_reportInner.Icb_1_type cb_1 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_main_reportInner.Idw_1_type dw_1 { get; set; }


      public w_main_report(Mobilize.Web.BaseControl parent = null)
      : base(parent)
      {
         this.Width = 5175;
         this.Height = 3640;
         this.TitleBar = true;
         this.Title = "Main Report";
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