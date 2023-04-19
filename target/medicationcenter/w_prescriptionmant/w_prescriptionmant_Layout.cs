namespace medicationcenter
{

   public partial class w_prescriptionmant
   {

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_prescriptionmantInner.Iuo_1_type uo_1 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public bool? dirtyadd { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public bool? dirtyremove { get; set; }

      public Mobilize.Web.VoidEventHandler savedataEventHandler { get; set; }


      public w_prescriptionmant(Mobilize.Web.BaseControl parent = null)
      : base(parent)
      {
         this.Width = 3301;
         this.Height = 2104;
         this.MenuName = "m_adminmaint";
         this.ControlMenu = false;
         this.MaxBox = false;
         this.Resizable = false;
      }
   }

}