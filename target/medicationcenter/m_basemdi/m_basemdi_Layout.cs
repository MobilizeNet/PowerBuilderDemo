namespace medicationcenter
{

   public partial class m_basemdi
   {

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Im_basemdiInner.Im_prescriptions_type m_prescriptions { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Im_basemdiInner.Im_edit_type m_edit { get; set; }


      public m_basemdi(Mobilize.Web.BaseControl parent = null)
      : base(parent)
      {
      }
   }

}