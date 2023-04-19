namespace medicationcenter
{

   public partial class w_basemdi
   {

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_basemdiInner.Imdi_1_type mdi_1 { get; set; }


      public w_basemdi(Mobilize.Web.BaseControl parent = null)
      : base(parent)
      {
         this.Width = 4101;
         this.Height = 2948;
         this.Title = "Medication Center";
         this.MenuName = "m_basemdi";
         this.WindowType = Mobilize.Web.WindowType.Mdi;
         this.WindowState = Mobilize.Web.WindowState.Maximized;
      }
   }

}