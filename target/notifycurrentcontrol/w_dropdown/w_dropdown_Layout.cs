namespace notifycurrentcontrol
{

   public partial class w_dropdown
   {

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_dropdownInner.Ist_2_type st_2 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_dropdownInner.Ist_1_type st_1 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_dropdownInner.Idw_1_type dw_1 { get; set; }


      public w_dropdown(Mobilize.Web.BaseControl parent = null)
      : base(parent)
      {
         this.Width = 869;
         this.Height = 756;
         this.TitleBar = true;
         this.Title = "DropDownDW";
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