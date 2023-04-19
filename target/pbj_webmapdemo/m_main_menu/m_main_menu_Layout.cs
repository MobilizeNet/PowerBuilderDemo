namespace pbj_webmapdemo
{

   public partial class m_main_menu
   {

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Im_main_menuInner.Im_controls_type m_controls { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Im_main_menuInner.Im_features_type m_features { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Im_main_menuInner.Im_medicalcenter_type m_medicalcenter { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Im_main_menuInner.Im_reports_type m_reports { get; set; }


      public m_main_menu(Mobilize.Web.BaseControl parent = null)
      : base(parent)
      {
      }
   }

}