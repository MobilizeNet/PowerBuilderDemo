namespace pbj_webmapdemo
{

   public partial class w_single_line_edit
   {

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_single_line_editInner.Icb_4_type cb_4 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_single_line_editInner.Icb_5_type cb_5 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_single_line_editInner.Icb_6_type cb_6 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_single_line_editInner.Icb_3_type cb_3 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_single_line_editInner.Icb_1_type cb_1 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_single_line_editInner.Isle_1_type sle_1 { get; set; }


      public w_single_line_edit(Mobilize.Web.BaseControl parent = null)
      : base(parent)
      {
         this.X = 101;
         this.Y = 100;
         this.Width = 1838;
         this.Height = 1004;
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