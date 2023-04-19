namespace features
{

   public partial class w_dummyfeatures
   {

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_dummyfeaturesInner.Icb_1_type cb_1 { get; set; }


      public w_dummyfeatures(Mobilize.Web.BaseControl parent = null)
      : base(parent)
      {
         this.Width = 3378;
         this.Height = 1408;
         this.TitleBar = true;
         this.Title = "Untitled";
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