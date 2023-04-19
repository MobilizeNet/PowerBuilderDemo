#pragma warning disable
#line 1 "w_basewindow\\w_basewindow_Layout.cs"
#pragma warning disable
#line 1 "w_basewindow\\w_basewindow_Layout.cs"
namespace basecomponents
{

   public partial class w_basewindow
   {

      public Mobilize.Web.VoidEventHandler ev_loadcontentEventHandler { get; set; }


      public w_basewindow(Mobilize.Web.BaseControl parent = null)
      : base(parent)
      {
         this.Width = 2423;
         this.Height = 1296;
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
#pragma warning restore
