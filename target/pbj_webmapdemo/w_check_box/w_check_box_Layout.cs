namespace pbj_webmapdemo
{

   public partial class w_check_box
   {

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_check_boxInner.Icb_7_type cb_7 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_check_boxInner.Icb_1_type cb_1 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_check_boxInner.Icb_3_type cb_3 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_check_boxInner.Icb_6_type cb_6 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_check_boxInner.Icb_5_type cb_5 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_check_boxInner.Icb_4_type cb_4 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_check_boxInner.Icbx_2_type cbx_2 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_check_boxInner.Icbx_1_type cbx_1 { get; set; }


      public w_check_box(Mobilize.Web.BaseControl parent = null)
      : base(parent)
      {
         this.Width = 1838;
         this.Height = 1104;
         this.TitleBar = true;
         this.Title = "Check Box";
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