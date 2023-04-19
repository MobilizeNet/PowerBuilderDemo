#pragma warning disable
#line 1 "medicationcenter\\Im_adminmdi\\Im_adminmdi_Layout.cs"
#pragma warning disable
#line 1 "medicationcenter\\Im_adminmdi\\Im_adminmdi_Layout.cs"
namespace medicationcenter
{

   public interface Im_adminmdi
      : medicationcenter.Im_basemdi
   {

      void Create();

      void Destroy();

      Im_adminmdiInner.Im_prescriptions_type m_prescriptions { get; set; }

      Im_adminmdiInner.Im_edit_type m_edit { get; set; }

      Im_adminmdiInner.Im_administration_type m_administration { get; set; }

   }

   namespace Im_adminmdiInner
   {

      public interface Im_administration_type
         : Mobilize.Web.IMenu
      {

         Im_adminmdiInner.Im_administration_typeInner.Im_addpatient_type m_addpatient { get; set; }

         void Create();

      }

      namespace Im_administration_typeInner
      {

         public interface Im_addpatient_type
            : Mobilize.Web.IMenu
         {

            void Create();

         }

      }

      public interface Im_prescriptions_type
         : medicationcenter.Im_basemdiInner.Im_prescriptions_type
      {
      }

      namespace Im_prescriptions_typeInner
      {

         public interface Im_addprescription_type
            : medicationcenter.Im_basemdiInner.Im_prescriptions_typeInner.Im_addprescription_type
         {

            int? Clicked();

            void Create();

            void DoWmInit();

         }

         public interface Im_showall_type
            : medicationcenter.Im_basemdiInner.Im_prescriptions_typeInner.Im_showall_type
         {

            int? Clicked();

            void Create();

            void DoWmInit();

         }

         public interface Im_search_type
            : medicationcenter.Im_basemdiInner.Im_prescriptions_typeInner.Im_search_type
         {

            int? Clicked();

            void DoWmInit();

         }

         public interface Im_removeprescription_type
            : medicationcenter.Im_basemdiInner.Im_prescriptions_typeInner.Im_removeprescription_type
         {

            int? Clicked();

            void Create();

            void DoWmInit();

         }

         public interface Im_dwcontrolsampler_type
            : medicationcenter.Im_basemdiInner.Im_prescriptions_typeInner.Im_dwcontrolsampler_type
         {
         }

      }

      public interface Im_edit_type
         : medicationcenter.Im_basemdiInner.Im_edit_type
      {
      }

      namespace Im_edit_typeInner
      {

         public interface Im_save_type
            : medicationcenter.Im_basemdiInner.Im_edit_typeInner.Im_save_type
         {
         }

         public interface Im_close_type
            : medicationcenter.Im_basemdiInner.Im_edit_typeInner.Im_close_type
         {
         }

      }
   }
}
#pragma warning restore
