namespace pbj_webmapdemo
{

   public partial class w_static_text
   {

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_static_textInner.Ist_1_type st_1 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_static_textInner.Icb_enable_type cb_enable { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_static_textInner.Icb_visible_type cb_visible { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_static_textInner.Icb_text_type cb_text { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_static_textInner.Icb_showhide_type cb_showhide { get; set; }


      public w_static_text(Mobilize.Web.BaseControl parent = null)
      : base(parent)
      {
         this.X = 101;
         this.Y = 100;
         this.Width = 1582;
         this.Height = 996;
         this.TitleBar = true;
         this.Title = "SingleLine Edit";
         this.ControlMenu = true;
         this.MinBox = true;
         this.MaxBox = true;
         this.Resizable = true;
         this.BackColor = 67108864;
         this.Icon = "Window!";
         this.Center = true;
      }
   }

}