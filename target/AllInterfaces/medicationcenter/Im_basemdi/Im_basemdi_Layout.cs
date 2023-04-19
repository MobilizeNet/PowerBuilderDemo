namespace medicationcenter
{

   public interface Im_basemdi
      : Mobilize.Web.IMenu
   {

      void Create();

      void Destroy();

      Im_basemdiInner.Im_prescriptions_type m_prescriptions { get; set; }

      Im_basemdiInner.Im_edit_type m_edit { get; set; }

   }

   namespace Im_basemdiInner
   {

      public interface Im_prescriptions_type
         : Mobilize.Web.IMenu
      {

         Im_basemdiInner.Im_prescriptions_typeInner.Im_addprescription_type m_addprescription { get; set; }

         Im_basemdiInner.Im_prescriptions_typeInner.Im_showall_type m_showall { get; set; }

         Im_basemdiInner.Im_prescriptions_typeInner.Im_search_type m_search { get; set; }

         Im_basemdiInner.Im_prescriptions_typeInner.Im_removeprescription_type m_removeprescription { get; set; }

         Im_basemdiInner.Im_prescriptions_typeInner.Im_dwcontrolsampler_type m_dwcontrolsampler { get; set; }

         void Create();

      }

      namespace Im_prescriptions_typeInner
      {

         public interface Im_addprescription_type
            : Mobilize.Web.IMenu
         {

            void Create();

         }

         public interface Im_showall_type
            : Mobilize.Web.IMenu
         {

            int? Clicked();

            void Create();

            void DoWmInit();

         }

         public interface Im_search_type
            : Mobilize.Web.IMenu
         {

            int? Clicked();

            void Create();

            void DoWmInit();

         }

         public interface Im_removeprescription_type
            : Mobilize.Web.IMenu
         {

            void Create();

         }

         public interface Im_dwcontrolsampler_type
            : Mobilize.Web.IMenu
         {

            int? Clicked();

            void Create();

            void DoWmInit();

         }

      }

      public interface Im_edit_type
         : Mobilize.Web.IMenu
      {

         Im_basemdiInner.Im_edit_typeInner.Im_save_type m_save { get; set; }

         Im_basemdiInner.Im_edit_typeInner.Im_close_type m_close { get; set; }

         void Create();

      }

      namespace Im_edit_typeInner
      {

         public interface Im_save_type
            : Mobilize.Web.IMenu
         {

            void Create();

         }

         public interface Im_close_type
            : Mobilize.Web.IMenu
         {

            void Create();

         }

      }
   }
}