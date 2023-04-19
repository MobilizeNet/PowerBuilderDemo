namespace pbj_webmapdemo
{

   public partial class w_picture_button
   {

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_picture_buttonInner.Icb_1_type cb_1 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_picture_buttonInner.Icb_3_type cb_3 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_picture_buttonInner.Icb_6_type cb_6 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_picture_buttonInner.Icb_5_type cb_5 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_picture_buttonInner.Icb_4_type cb_4 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_picture_buttonInner.Ipb_1_type pb_1 { get; set; }


      public w_picture_button(Mobilize.Web.BaseControl parent = null)
      : base(parent)
      {
         this.Width = 2039;
         this.Height = 2104;
         this.TitleBar = true;
         this.Title = "Picture Button";
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