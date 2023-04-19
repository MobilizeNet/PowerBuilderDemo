namespace pbj_webmapdemo
{

   public partial class w_command_button
   {

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_command_buttonInner.Icb_1_type cb_1 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_command_buttonInner.Icb_3_type cb_3 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_command_buttonInner.Icb_6_type cb_6 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_command_buttonInner.Icb_5_type cb_5 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_command_buttonInner.Icb_4_type cb_4 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_command_buttonInner.Icb_0_type cb_0 { get; set; }


      public w_command_button(Mobilize.Web.BaseControl parent = null)
      : base(parent)
      {
         this.Width = 2011;
         this.Height = 1080;
         this.TitleBar = true;
         this.Title = "Command Button";
         this.ControlMenu = true;
         this.MinBox = true;
         this.WindowType = Mobilize.Web.WindowType.Popup;
         this.BackColor = 67108864;
         this.Icon = "AppIcon!";
         this.Center = true;
      }
   }

}