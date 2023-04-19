namespace multicontroldemo
{

   public partial class w_allinformation
   {

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_allinformationInner.Icb_1_type cb_1 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_allinformationInner.Isle_1_type sle_1 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_allinformationInner.Icb_insert_details_type cb_insert_details { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_allinformationInner.Icb_get_text_details_type cb_get_text_details { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_allinformationInner.Icb_insertrow_type cb_insertrow { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_allinformationInner.Icb_gettext_type cb_gettext { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_allinformationInner.Icb_clear_type cb_clear { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_allinformationInner.Imle_log_type mle_log { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_allinformationInner.Idw_additional_info_type dw_additional_info { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_allinformationInner.Idw_main_info_type dw_main_info { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_allinformationInner.Igb_main_type gb_main { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_allinformationInner.Igb_details_type gb_details { get; set; }


      public w_allinformation(Mobilize.Web.BaseControl parent = null)
      : base(parent)
      {
         this.Width = 4722;
         this.Height = 2464;
         this.TitleBar = true;
         this.Title = "All Information";
         this.ControlMenu = true;
         this.MinBox = true;
         this.MaxBox = true;
         this.Resizable = true;
         this.BackColor = 67108864;
         this.Icon = "Information!";
         this.Center = true;
      }
   }

}