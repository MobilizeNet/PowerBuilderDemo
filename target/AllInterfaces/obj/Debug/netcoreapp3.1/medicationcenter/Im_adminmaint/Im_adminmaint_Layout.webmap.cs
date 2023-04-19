#pragma warning disable
#line 1 "medicationcenter\\Im_adminmaint\\Im_adminmaint_Layout.cs"
#pragma warning disable
#line 1 "medicationcenter\\Im_adminmaint\\Im_adminmaint_Layout.cs"
namespace medicationcenter
{

   public interface Im_adminmaint
      : medicationcenter.Im_adminmdi
   {

      void Create();

      void Destroy();

      Im_adminmaintInner.Im_prescriptions_type m_prescriptions { get; set; }

      Im_adminmaintInner.Im_edit_type m_edit { get; set; }

      Im_adminmaintInner.Im_administration_type m_administration { get; set; }

   }

   namespace Im_adminmaintInner
   {

      public interface Im_prescriptions_type
         : medicationcenter.Im_adminmdiInner.Im_prescriptions_type
      {
      }

      namespace Im_prescriptions_typeInner
      {

         public interface Im_addprescription_type
            : medicationcenter.Im_adminmdiInner.Im_prescriptions_typeInner.Im_addprescription_type
         {

            void Create();

         }

         public interface Im_showall_type
            : medicationcenter.Im_adminmdiInner.Im_prescriptions_typeInner.Im_showall_type
         {

            void Create();

         }

         public interface Im_search_type
            : medicationcenter.Im_adminmdiInner.Im_prescriptions_typeInner.Im_search_type
         {

            void Create();

         }

         public interface Im_removeprescription_type
            : medicationcenter.Im_adminmdiInner.Im_prescriptions_typeInner.Im_removeprescription_type
         {

            void Create();

         }

         public interface Im_dwcontrolsampler_type
            : medicationcenter.Im_adminmdiInner.Im_prescriptions_typeInner.Im_dwcontrolsampler_type
         {

            void Create();

         }

      }

      public interface Im_edit_type
         : medicationcenter.Im_adminmdiInner.Im_edit_type
      {

         void Create();

      }

      namespace Im_edit_typeInner
      {

         public interface Im_save_type
            : medicationcenter.Im_adminmdiInner.Im_edit_typeInner.Im_save_type
         {

            int? Clicked();

            void Create();

            void DoWmInit();

         }

         public interface Im_close_type
            : medicationcenter.Im_adminmdiInner.Im_edit_typeInner.Im_close_type
         {

            int? Clicked();

            void Create();

            void DoWmInit();

         }

      }

      public interface Im_administration_type
         : medicationcenter.Im_adminmdiInner.Im_administration_type
      {
      }

      namespace Im_administration_typeInner
      {

         public interface Im_addpatient_type
            : medicationcenter.Im_adminmdiInner.Im_administration_typeInner.Im_addpatient_type
         {
         }

      }
   }
}
#pragma warning restore
