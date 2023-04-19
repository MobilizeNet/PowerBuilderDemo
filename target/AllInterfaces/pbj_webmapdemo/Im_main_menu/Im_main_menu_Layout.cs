namespace pbj_webmapdemo
{

   public interface Im_main_menu
      : Mobilize.Web.IMenu
   {

      void Create();

      void Destroy();

      Im_main_menuInner.Im_controls_type m_controls { get; set; }

      Im_main_menuInner.Im_features_type m_features { get; set; }

      Im_main_menuInner.Im_medicalcenter_type m_medicalcenter { get; set; }

      Im_main_menuInner.Im_reports_type m_reports { get; set; }

   }

   namespace Im_main_menuInner
   {

      public interface Im_controls_type
         : Mobilize.Web.IMenu
      {

         Im_main_menuInner.Im_controls_typeInner.Im_statictext_type m_statictext { get; set; }

         Im_main_menuInner.Im_controls_typeInner.Im_0_type m_0 { get; set; }

         Im_main_menuInner.Im_controls_typeInner.Im_commandbutton_type m_commandbutton { get; set; }

         Im_main_menuInner.Im_controls_typeInner.Im_editmask_type m_editmask { get; set; }

         Im_main_menuInner.Im_controls_typeInner.Im_multilineedit_type m_multilineedit { get; set; }

         Im_main_menuInner.Im_controls_typeInner.Im_radiobutton_type m_radiobutton { get; set; }

         Im_main_menuInner.Im_controls_typeInner.Im_checkbox_type m_checkbox { get; set; }

         Im_main_menuInner.Im_controls_typeInner.Im_dropdownlistbox_type m_dropdownlistbox { get; set; }

         Im_main_menuInner.Im_controls_typeInner.Im_picture_type m_picture { get; set; }

         Im_main_menuInner.Im_controls_typeInner.Im_picturebutton_type m_picturebutton { get; set; }

         Im_main_menuInner.Im_controls_typeInner.Im_datamangercontrols_type m_datamangercontrols { get; set; }

         void Create();

      }

      namespace Im_controls_typeInner
      {

         public interface Im_statictext_type
            : Mobilize.Web.IMenu
         {

            int? Clicked();

            void Create();

            void DoWmInit();

         }

         public interface Im_0_type
            : Mobilize.Web.IMenu
         {

            int? Clicked();

            void Create();

            void DoWmInit();

         }

         public interface Im_commandbutton_type
            : Mobilize.Web.IMenu
         {

            int? Clicked();

            void Create();

            void DoWmInit();

         }

         public interface Im_editmask_type
            : Mobilize.Web.IMenu
         {

            int? Clicked();

            void Create();

            void DoWmInit();

         }

         public interface Im_multilineedit_type
            : Mobilize.Web.IMenu
         {

            int? Clicked();

            void Create();

            void DoWmInit();

         }

         public interface Im_radiobutton_type
            : Mobilize.Web.IMenu
         {

            int? Clicked();

            void Create();

            void DoWmInit();

         }

         public interface Im_checkbox_type
            : Mobilize.Web.IMenu
         {

            int? Clicked();

            void Create();

            void DoWmInit();

         }

         public interface Im_dropdownlistbox_type
            : Mobilize.Web.IMenu
         {

            int? Clicked();

            void Create();

            void DoWmInit();

         }

         public interface Im_picture_type
            : Mobilize.Web.IMenu
         {

            int? Clicked();

            void Create();

            void DoWmInit();

         }

         public interface Im_picturebutton_type
            : Mobilize.Web.IMenu
         {

            int? Clicked();

            void Create();

            void DoWmInit();

         }

         public interface Im_datamangercontrols_type
            : Mobilize.Web.IMenu
         {

            Im_main_menuInner.Im_controls_typeInner.Im_datamangercontrols_typeInner.Im_dropdowndw_type m_dropdowndw { get; set; }

            void Create();

         }

         namespace Im_datamangercontrols_typeInner
         {

            public interface Im_dropdowndw_type
               : Mobilize.Web.IMenu
            {

               int? Clicked();

               void Create();

               void DoWmInit();

            }

         }
      }

      public interface Im_features_type
         : Mobilize.Web.IMenu
      {

         Im_main_menuInner.Im_features_typeInner.Im_datawindowcrud_type m_datawindowcrud { get; set; }

         Im_main_menuInner.Im_features_typeInner.Im_datamanagereventonsinglerow_type m_datamanagereventonsinglerow { get; set; }

         Im_main_menuInner.Im_features_typeInner.Im_alldatamanagercontrolinteractions_type m_alldatamanagercontrolinteractions { get; set; }

         Im_main_menuInner.Im_features_typeInner.Im_1_type m_1 { get; set; }

         Im_main_menuInner.Im_features_typeInner.Im_2_type m_2 { get; set; }

         Im_main_menuInner.Im_features_typeInner.Im_3_type m_3 { get; set; }

         Im_main_menuInner.Im_features_typeInner.Im_4_type m_4 { get; set; }

         Im_main_menuInner.Im_features_typeInner.Im_datamanagerstate_nodata_type m_datamanagerstate_nodata { get; set; }

         Im_main_menuInner.Im_features_typeInner.Im_datamanagerw_window_type m_datamanagerw_window { get; set; }

         Im_main_menuInner.Im_features_typeInner.Im_datamanagerw_shared_type m_datamanagerw_shared { get; set; }

         Im_main_menuInner.Im_features_typeInner.Im_datamanagerw_dropdown_type m_datamanagerw_dropdown { get; set; }

         Im_main_menuInner.Im_features_typeInner.Im_datamanagerw_expression_type m_datamanagerw_expression { get; set; }

         void Create();

      }

      namespace Im_features_typeInner
      {

         public interface Im_datawindowcrud_type
            : Mobilize.Web.IMenu
         {

            int? Clicked();

            void Create();

            void DoWmInit();

         }

         public interface Im_datamanagereventonsinglerow_type
            : Mobilize.Web.IMenu
         {

            int? Clicked();

            void Create();

            void DoWmInit();

         }

         public interface Im_alldatamanagercontrolinteractions_type
            : Mobilize.Web.IMenu
         {

            int? Clicked();

            void Create();

            void DoWmInit();

         }

         public interface Im_1_type
            : Mobilize.Web.IMenu
         {

            int? Clicked();

            void Create();

            void DoWmInit();

         }

         public interface Im_2_type
            : Mobilize.Web.IMenu
         {

            int? Clicked();

            void Create();

            void DoWmInit();

         }

         public interface Im_3_type
            : Mobilize.Web.IMenu
         {

            int? Clicked();

            void Create();

            void DoWmInit();

         }

         public interface Im_4_type
            : Mobilize.Web.IMenu
         {

            int? Clicked();

            void Create();

            void DoWmInit();

         }

         public interface Im_datamanagerstate_nodata_type
            : Mobilize.Web.IMenu
         {

            int? Clicked();

            void Create();

            void DoWmInit();

         }

         public interface Im_datamanagerw_window_type
            : Mobilize.Web.IMenu
         {

            int? Clicked();

            void Create();

            void DoWmInit();

         }

         public interface Im_datamanagerw_shared_type
            : Mobilize.Web.IMenu
         {

            int? Clicked();

            void Create();

            void DoWmInit();

         }

         public interface Im_datamanagerw_dropdown_type
            : Mobilize.Web.IMenu
         {

            int? Clicked();

            void Create();

            void DoWmInit();

         }

         public interface Im_datamanagerw_expression_type
            : Mobilize.Web.IMenu
         {

            int? Clicked();

            void Create();

            void DoWmInit();

         }

      }

      public interface Im_medicalcenter_type
         : Mobilize.Web.IMenu
      {

         int? Clicked();

         void Create();

         void DoWmInit();

      }

      public interface Im_reports_type
         : Mobilize.Web.IMenu
      {

         int? Clicked();

         void Create();

         void DoWmInit();

      }

   }
}