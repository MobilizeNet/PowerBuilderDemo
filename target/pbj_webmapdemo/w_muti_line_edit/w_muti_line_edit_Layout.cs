namespace pbj_webmapdemo
{

   public partial class w_muti_line_edit
   {

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_muti_line_editInner.Icb_4_type cb_4 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_muti_line_editInner.Icb_5_type cb_5 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_muti_line_editInner.Icb_6_type cb_6 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_muti_line_editInner.Icb_3_type cb_3 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_muti_line_editInner.Icb_1_type cb_1 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_muti_line_editInner.Icb_7_type cb_7 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_muti_line_editInner.Imle_1_type mle_1 { get; set; }


      public w_muti_line_edit(Mobilize.Web.BaseControl parent = null)
      : base(parent)
      {
         this.Width = 3045;
         this.Height = 1184;
         this.TitleBar = true;
         this.Title = "MultiLine Edit";
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