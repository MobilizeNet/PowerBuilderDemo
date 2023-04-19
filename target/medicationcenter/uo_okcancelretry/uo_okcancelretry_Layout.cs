namespace medicationcenter
{

   public partial class uo_okcancelretry
   {

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iuo_okcancelretryInner.Icb_retry_type cb_retry { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iuo_okcancelretryInner.Icb_cancel_type cb_cancel { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iuo_okcancelretryInner.Icb_ok_type cb_ok { get; set; }

      public Mobilize.Web.VoidEventHandler okclickEventHandler { get; set; }

      public Mobilize.Web.VoidEventHandler cancelclickEventHandler { get; set; }

      public Mobilize.Web.VoidEventHandler retryclickEventHandler { get; set; }


      public uo_okcancelretry(Mobilize.Web.BaseControl parent = null)
      : base(parent)
      {
         this.Width = 1413;
         this.Height = 184;
         this.BackColor = 67108864;
         this.Text = "none";
         this.TabTextColor = 33554432;
         this.PictureMaskColor = 536870912;
      }
   }

}