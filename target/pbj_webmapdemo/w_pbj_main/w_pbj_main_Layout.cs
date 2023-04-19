namespace pbj_webmapdemo
{

   public partial class w_pbj_main
   {

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_pbj_mainInner.Imdi_1_type mdi_1 { get; set; }


      public w_pbj_main(Mobilize.Web.BaseControl parent = null)
      : base(parent)
      {
         this.Width = 4037;
         this.Height = 2180;
         this.TitleBar = true;
         this.Title = "PBJ_WebMapDemo";
         this.MenuName = "m_main_menu";
         this.ControlMenu = true;
         this.MinBox = true;
         this.MaxBox = true;
         this.Resizable = true;
         this.WindowType = Mobilize.Web.WindowType.Mdi;
         this.BackColor = 67108864;
         this.Icon = "AppIcon!";
         this.Center = true;
      }
   }

}