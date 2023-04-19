namespace medicationcenter
{

   [Mobilize.WebMap.Common.Attributes.Observable]
   public partial class m_adminmaint
      : medicationcenter.m_adminmdi, medicationcenter.Im_adminmaint
   {

      public override void Create()
      {
         Mobilize.Web.Application.CurrentApplication.Variables.m_adminmaint = (medicationcenter.m_adminmdi)(this);
         base.Create();
         this.Text = "m_adminmaint";
      }

      public override void Destroy()
      {
         base.Destroy();
      }

      public new Im_adminmaintInner.Im_prescriptions_type m_prescriptions
      {
         get
         {
            return (m_adminmaint.m_prescriptions_type)base.m_prescriptions;
         }
         set
         {
            base.m_prescriptions = value;
         }
      }

      public new Im_adminmaintInner.Im_edit_type m_edit
      {
         get
         {
            return (m_adminmaint.m_edit_type)base.m_edit;
         }
         set
         {
            base.m_edit = value;
         }
      }

      public new Im_adminmaintInner.Im_administration_type m_administration
      {
         get
         {
            return (m_adminmaint.m_administration_type)base.m_administration;
         }
         set
         {
            base.m_administration = value;
         }
      }

      protected override medicationcenter.Im_basemdiInner.Im_prescriptions_type CreateInnerControl_m_prescriptions_type()
      {
         return Mobilize.Web.Application.Create<Im_adminmaintInner.Im_prescriptions_type>(this);
      }

      protected override medicationcenter.Im_basemdiInner.Im_edit_type CreateInnerControl_m_edit_type()
      {
         return Mobilize.Web.Application.Create<Im_adminmaintInner.Im_edit_type>(this);
      }

      protected override medicationcenter.Im_adminmdiInner.Im_administration_type CreateInnerControl_m_administration_type()
      {
         return Mobilize.Web.Application.Create<Im_adminmaintInner.Im_administration_type>(this);
      }

      public partial class m_prescriptions_type
         : medicationcenter.m_adminmdi.m_prescriptions_type, Im_adminmaintInner.Im_prescriptions_type
      {

         public m_prescriptions_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new m_adminmaint Parent => (m_adminmaint)base.Parent;

         protected override medicationcenter.Im_basemdiInner.Im_prescriptions_typeInner.Im_addprescription_type CreateInnerControl_m_addprescription_type()
         {
            return Mobilize.Web.Application.Create<Im_adminmaintInner.Im_prescriptions_typeInner.Im_addprescription_type>(this);
         }

         protected override medicationcenter.Im_basemdiInner.Im_prescriptions_typeInner.Im_showall_type CreateInnerControl_m_showall_type()
         {
            return Mobilize.Web.Application.Create<Im_adminmaintInner.Im_prescriptions_typeInner.Im_showall_type>(this);
         }

         protected override medicationcenter.Im_basemdiInner.Im_prescriptions_typeInner.Im_search_type CreateInnerControl_m_search_type()
         {
            return Mobilize.Web.Application.Create<Im_adminmaintInner.Im_prescriptions_typeInner.Im_search_type>(this);
         }

         protected override medicationcenter.Im_basemdiInner.Im_prescriptions_typeInner.Im_removeprescription_type CreateInnerControl_m_removeprescription_type()
         {
            return Mobilize.Web.Application.Create<Im_adminmaintInner.Im_prescriptions_typeInner.Im_removeprescription_type>(this);
         }

         protected override medicationcenter.Im_basemdiInner.Im_prescriptions_typeInner.Im_dwcontrolsampler_type CreateInnerControl_m_dwcontrolsampler_type()
         {
            return Mobilize.Web.Application.Create<Im_adminmaintInner.Im_prescriptions_typeInner.Im_dwcontrolsampler_type>(this);
         }

         public partial class m_addprescription_type
            : medicationcenter.m_adminmdi.m_prescriptions_type.m_addprescription_type, Im_adminmaintInner.Im_prescriptions_typeInner.Im_addprescription_type
         {

            public m_addprescription_type(Mobilize.Web.BaseControl parent)
            : base(parent)
            {
            }

            private new m_adminmaint.m_prescriptions_type Parent => (m_adminmaint.m_prescriptions_type)base.Parent;

            public override void Create()
            {
               base.Create();
               this.ToolbarItemVisible = false;
            }

         }

         public partial class m_showall_type
            : medicationcenter.m_adminmdi.m_prescriptions_type.m_showall_type, Im_adminmaintInner.Im_prescriptions_typeInner.Im_showall_type
         {

            public m_showall_type(Mobilize.Web.BaseControl parent)
            : base(parent)
            {
            }

            private new m_adminmaint.m_prescriptions_type Parent => (m_adminmaint.m_prescriptions_type)base.Parent;

            public override void Create()
            {
               base.Create();
               this.ToolbarItemVisible = false;
            }

         }

         public partial class m_search_type
            : medicationcenter.m_adminmdi.m_prescriptions_type.m_search_type, Im_adminmaintInner.Im_prescriptions_typeInner.Im_search_type
         {

            public m_search_type(Mobilize.Web.BaseControl parent)
            : base(parent)
            {
            }

            private new m_adminmaint.m_prescriptions_type Parent => (m_adminmaint.m_prescriptions_type)base.Parent;

            public override void Create()
            {
               base.Create();
               this.ToolbarItemVisible = false;
            }

         }

         public partial class m_removeprescription_type
            : medicationcenter.m_adminmdi.m_prescriptions_type.m_removeprescription_type, Im_adminmaintInner.Im_prescriptions_typeInner.Im_removeprescription_type
         {

            public m_removeprescription_type(Mobilize.Web.BaseControl parent)
            : base(parent)
            {
            }

            private new m_adminmaint.m_prescriptions_type Parent => (m_adminmaint.m_prescriptions_type)base.Parent;

            public override void Create()
            {
               base.Create();
               this.ToolbarItemVisible = false;
            }

         }

         public partial class m_dwcontrolsampler_type
            : medicationcenter.m_adminmdi.m_prescriptions_type.m_dwcontrolsampler_type, Im_adminmaintInner.Im_prescriptions_typeInner.Im_dwcontrolsampler_type
         {

            public m_dwcontrolsampler_type(Mobilize.Web.BaseControl parent)
            : base(parent)
            {
            }

            private new m_adminmaint.m_prescriptions_type Parent => (m_adminmaint.m_prescriptions_type)base.Parent;

            public override void Create()
            {
               base.Create();
               this.ToolbarItemVisible = false;
            }

         }

      }

      public partial class m_edit_type
         : medicationcenter.m_adminmdi.m_edit_type, Im_adminmaintInner.Im_edit_type
      {

         public m_edit_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new m_adminmaint Parent => (m_adminmaint)base.Parent;

         public override void Create()
         {
            base.Create();
            this.Visible = true;
         }

         protected override medicationcenter.Im_basemdiInner.Im_edit_typeInner.Im_save_type CreateInnerControl_m_save_type()
         {
            return Mobilize.Web.Application.Create<Im_adminmaintInner.Im_edit_typeInner.Im_save_type>(this);
         }

         protected override medicationcenter.Im_basemdiInner.Im_edit_typeInner.Im_close_type CreateInnerControl_m_close_type()
         {
            return Mobilize.Web.Application.Create<Im_adminmaintInner.Im_edit_typeInner.Im_close_type>(this);
         }

         public partial class m_save_type
            : medicationcenter.m_adminmdi.m_edit_type.m_save_type, Im_adminmaintInner.Im_edit_typeInner.Im_save_type
         {

            public m_save_type(Mobilize.Web.BaseControl parent)
            : base(parent)
            {
            }

            private new m_adminmaint.m_edit_type Parent => (m_adminmaint.m_edit_type)base.Parent;

            public virtual int? Clicked()
            {
               int? AncestorReturnValue = null;
               this.ParentWindow.TriggerEvent("savedata");
               return null;
            }

            public override void Create()
            {
               base.Create();
               this.ToolbarItemVisible = true;
            }

            public override void DoWmInit()
            {
               base.DoWmInit();
               this.clicked = new Mobilize.Web.MenuClickedEventHandler(Clicked);
            }

         }

         public partial class m_close_type
            : medicationcenter.m_adminmdi.m_edit_type.m_close_type, Im_adminmaintInner.Im_edit_typeInner.Im_close_type
         {

            public m_close_type(Mobilize.Web.BaseControl parent)
            : base(parent)
            {
            }

            private new m_adminmaint.m_edit_type Parent => (m_adminmaint.m_edit_type)base.Parent;

            public virtual int? Clicked()
            {
               int? AncestorReturnValue = null;
               Mobilize.Web.BuiltInExtensions.Close(this.ParentWindow);
               return null;
            }

            public override void Create()
            {
               base.Create();
               this.ToolbarItemVisible = true;
            }

            public override void DoWmInit()
            {
               base.DoWmInit();
               this.clicked = new Mobilize.Web.MenuClickedEventHandler(Clicked);
            }

         }

      }

      public partial class m_administration_type
         : medicationcenter.m_adminmdi.m_administration_type, Im_adminmaintInner.Im_administration_type
      {

         public m_administration_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new m_adminmaint Parent => (m_adminmaint)base.Parent;

         protected override medicationcenter.Im_adminmdiInner.Im_administration_typeInner.Im_addpatient_type CreateInnerControl_m_addpatient_type()
         {
            return Mobilize.Web.Application.Create<Im_adminmaintInner.Im_administration_typeInner.Im_addpatient_type>(this);
         }

         public partial class m_addpatient_type
            : medicationcenter.m_adminmdi.m_administration_type.m_addpatient_type, Im_adminmaintInner.Im_administration_typeInner.Im_addpatient_type
         {

            public m_addpatient_type(Mobilize.Web.BaseControl parent)
            : base(parent)
            {
            }

            private new m_adminmaint.m_administration_type Parent => (m_adminmaint.m_administration_type)base.Parent;

         }

      }

   }

}