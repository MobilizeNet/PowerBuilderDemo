namespace medicationcenter
{

   public partial class tb_tabbase
   {

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Itb_tabbaseInner.Itabpage_add_type tabpage_add { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Itb_tabbaseInner.Itabpage_remove_type tabpage_remove { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Itb_tabbaseInner.Itabpage_search_type tabpage_search { get; set; }

      public Mobilize.Web.VoidEventHandler adddirtyEventHandler { get; set; }

      public Mobilize.Web.VoidEventHandler removedirtyEventHandler { get; set; }

      public Mobilize.Web.VoidEventHandler dosearchEventHandler { get; set; }


      public tb_tabbase(Mobilize.Web.BaseControl parent = null)
      : base(parent)
      {
         this.Width = 2587;
         this.Height = 1008;
         this.TextSize = -10;
         this.Weight = 400;
         this.FontCharset = Mobilize.Web.FontCharset.Ansi;
         this.FontPitch = Mobilize.Web.FontPitch.Variable;
         this.FontFamily = Mobilize.Web.FontFamily.Swiss;
         this.FaceName = "Tahoma";
         this.BackColor = 67108864;
         this.RaggedRight = true;
         this.FocusOnButtonDown = true;
         this.SelectedTab = 1;
      }
   }

}