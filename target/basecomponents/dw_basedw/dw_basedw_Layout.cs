namespace basecomponents
{

   public partial class dw_basedw
   {

      public Mobilize.Web.VoidEventHandler resetdataEventHandler { get; set; }


      public dw_basedw(Mobilize.Web.BaseControl parent = null)
      : base(parent)
      {
         this.Width = 759;
         this.Height = 476;
         this.Title = "none";
         this.LiveScroll = true;
         this.BorderStyle = Mobilize.Web.BorderStyle.StyleLowered;
      }
   }

}