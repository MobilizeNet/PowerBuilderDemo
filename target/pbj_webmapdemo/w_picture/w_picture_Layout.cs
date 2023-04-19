namespace pbj_webmapdemo
{

   public partial class w_picture
   {

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_pictureInner.Icb_4_type cb_4 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_pictureInner.Icb_5_type cb_5 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_pictureInner.Icb_6_type cb_6 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_pictureInner.Icb_3_type cb_3 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_pictureInner.Icb_1_type cb_1 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_pictureInner.Ip_1_type p_1 { get; set; }


      public w_picture(Mobilize.Web.BaseControl parent = null)
      : base(parent)
      {
         this.Width = 2039;
         this.Height = 2104;
         this.TitleBar = true;
         this.Title = "Picture";
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