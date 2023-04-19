namespace pbj_webmapdemo
{

   public partial class w_dw_dropdowndatawindow
   {

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_dw_dropdowndatawindowInner.Idw_1_type dw_1 { get; set; }


      public w_dw_dropdowndatawindow(Mobilize.Web.BaseControl parent = null)
      : base(parent)
      {
         this.Width = 3945;
         this.Height = 1140;
         this.TitleBar = true;
         this.Title = "DropDown Data Window";
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