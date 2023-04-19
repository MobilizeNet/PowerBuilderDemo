namespace medicationcenter
{

   public partial class ou_showallprescriptions
   {

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iou_showallprescriptionsInner.Idw_all_type dw_all { get; set; }


      public ou_showallprescriptions(Mobilize.Web.BaseControl parent = null)
      : base(parent)
      {
         this.Width = 3817;
         this.Height = 832;
         this.BackColor = 67108864;
         this.Text = "none";
         this.TabTextColor = 33554432;
         this.PictureMaskColor = 536870912;
      }
   }

}