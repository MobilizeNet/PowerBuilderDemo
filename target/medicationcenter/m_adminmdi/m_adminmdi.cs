namespace medicationcenter
{

   [Mobilize.WebMap.Common.Attributes.Observable]
   public partial class m_adminmdi
      : medicationcenter.m_basemdi, medicationcenter.Im_adminmdi
   {

      public override void Create()
      {
         Mobilize.Web.Application.CurrentApplication.Variables.m_adminmdi = (medicationcenter.m_basemdi)(this);
         base.Create();
         this.m_administration = CreateInnerControl_m_administration_type();
         this.Item[this.Item.GetUpperBound() + 1] = this.m_administration;
      }

      public override void Destroy()
      {
         base.Destroy();
         this.m_administration = null;
      }

      public new Im_adminmdiInner.Im_prescriptions_type m_prescriptions
      {
         get
         {
            return (m_adminmdi.m_prescriptions_type)base.m_prescriptions;
         }
         set
         {
            base.m_prescriptions = value;
         }
      }

      public new Im_adminmdiInner.Im_edit_type m_edit
      {
         get
         {
            return (m_adminmdi.m_edit_type)base.m_edit;
         }
         set
         {
            base.m_edit = value;
         }
      }

      protected virtual Im_adminmdiInner.Im_administration_type CreateInnerControl_m_administration_type()
      {
         return Mobilize.Web.Application.Create<Im_adminmdiInner.Im_administration_type>(this);
      }

      protected override medicationcenter.Im_basemdiInner.Im_prescriptions_type CreateInnerControl_m_prescriptions_type()
      {
         return Mobilize.Web.Application.Create<Im_adminmdiInner.Im_prescriptions_type>(this);
      }

      protected override medicationcenter.Im_basemdiInner.Im_edit_type CreateInnerControl_m_edit_type()
      {
         return Mobilize.Web.Application.Create<Im_adminmdiInner.Im_edit_type>(this);
      }

      public partial class m_administration_type
         : Mobilize.Web.Menu, Im_adminmdiInner.Im_administration_type
      {

         public m_administration_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new m_adminmdi Parent => (m_adminmdi)base.Parent;

         [Mobilize.WebMap.Common.Attributes.Intercepted]
         public Im_adminmdiInner.Im_administration_typeInner.Im_addpatient_type m_addpatient { get; set; }

         public override void Create()
         {
            base.Create();
            this.Visible = false;
            this.Text = "Administration";
            this.TextSize = 8;
            this.Weight = 400;
            this.FaceName = "Tahoma";
            this.m_addpatient = CreateInnerControl_m_addpatient_type();
            this.Item[this.Item.GetUpperBound() + 1] = this.m_addpatient;
         }

         protected virtual Im_adminmdiInner.Im_administration_typeInner.Im_addpatient_type CreateInnerControl_m_addpatient_type()
         {
            return Mobilize.Web.Application.Create<Im_adminmdiInner.Im_administration_typeInner.Im_addpatient_type>(this);
         }

         public partial class m_addpatient_type
            : Mobilize.Web.Menu, Im_adminmdiInner.Im_administration_typeInner.Im_addpatient_type
         {

            public m_addpatient_type(Mobilize.Web.BaseControl parent)
            : base(parent)
            {
            }

            private new m_adminmdi.m_administration_type Parent => (m_adminmdi.m_administration_type)base.Parent;

            public override void Create()
            {
               base.Create();
               this.Text = "Add Patient";
               this.ToolbarItemVisible = false;
               this.ToolbarItemName = "img\\adduser.png";
               this.ToolbarItemText = "Add Patient";
               this.TextSize = 8;
               this.Weight = 400;
               this.FaceName = "Tahoma";
            }

         }

      }

      public partial class m_prescriptions_type
         : medicationcenter.m_basemdi.m_prescriptions_type, Im_adminmdiInner.Im_prescriptions_type
      {

         public m_prescriptions_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new m_adminmdi Parent => (m_adminmdi)base.Parent;

         protected override medicationcenter.Im_basemdiInner.Im_prescriptions_typeInner.Im_addprescription_type CreateInnerControl_m_addprescription_type()
         {
            return Mobilize.Web.Application.Create<Im_adminmdiInner.Im_prescriptions_typeInner.Im_addprescription_type>(this);
         }

         protected override medicationcenter.Im_basemdiInner.Im_prescriptions_typeInner.Im_showall_type CreateInnerControl_m_showall_type()
         {
            return Mobilize.Web.Application.Create<Im_adminmdiInner.Im_prescriptions_typeInner.Im_showall_type>(this);
         }

         protected override medicationcenter.Im_basemdiInner.Im_prescriptions_typeInner.Im_search_type CreateInnerControl_m_search_type()
         {
            return Mobilize.Web.Application.Create<Im_adminmdiInner.Im_prescriptions_typeInner.Im_search_type>(this);
         }

         protected override medicationcenter.Im_basemdiInner.Im_prescriptions_typeInner.Im_removeprescription_type CreateInnerControl_m_removeprescription_type()
         {
            return Mobilize.Web.Application.Create<Im_adminmdiInner.Im_prescriptions_typeInner.Im_removeprescription_type>(this);
         }

         protected override medicationcenter.Im_basemdiInner.Im_prescriptions_typeInner.Im_dwcontrolsampler_type CreateInnerControl_m_dwcontrolsampler_type()
         {
            return Mobilize.Web.Application.Create<Im_adminmdiInner.Im_prescriptions_typeInner.Im_dwcontrolsampler_type>(this);
         }

         public partial class m_addprescription_type
            : medicationcenter.m_basemdi.m_prescriptions_type.m_addprescription_type, Im_adminmdiInner.Im_prescriptions_typeInner.Im_addprescription_type
         {

            public m_addprescription_type(Mobilize.Web.BaseControl parent)
            : base(parent)
            {
            }

            private new m_adminmdi.m_prescriptions_type Parent => (m_adminmdi.m_prescriptions_type)base.Parent;

            public virtual int? Clicked()
            {
               int? AncestorReturnValue = null;
               Mobilize.Web.BuiltInExtensions.OpenSheetWithParm(Mobilize.Web.ReferenceExtensions.Ref<Mobilize.Web.IWindow>((Mobilize.Web.IWindow)Mobilize.Web.Application.CurrentApplication.Variables.w_prescriptionmant<medicationcenter.Iw_prescriptionmant>(), (v) => Mobilize.Web.Application.CurrentApplication.Variables.w_prescriptionmant = (medicationcenter.Iw_prescriptionmant)v, () => Mobilize.Web.Application.CurrentApplication.Variables.w_prescriptionmant<medicationcenter.Iw_prescriptionmant>()), 1, (medicationcenter.Iw_mdi)(Mobilize.Web.Application.CurrentApplication.Variables.w_mdi<medicationcenter.Iw_mdi>()), 10, Mobilize.Web.ArrangeOpen.Layered);
               return null;
            }

            public override void Create()
            {
               base.Create();
               this.Visible = true;
               this.ToolbarItemVisible = true;
            }

            public override void DoWmInit()
            {
               base.DoWmInit();
               this.clicked = new Mobilize.Web.MenuClickedEventHandler(Clicked);
            }

         }

         public partial class m_showall_type
            : medicationcenter.m_basemdi.m_prescriptions_type.m_showall_type, Im_adminmdiInner.Im_prescriptions_typeInner.Im_showall_type
         {

            public m_showall_type(Mobilize.Web.BaseControl parent)
            : base(parent)
            {
            }

            private new m_adminmdi.m_prescriptions_type Parent => (m_adminmdi.m_prescriptions_type)base.Parent;

            public override int? Clicked()
            {
               int? AncestorReturnValue = null;
               AncestorReturnValue = base.Clicked();
               Mobilize.Web.BuiltInExtensions.OpenSheet(Mobilize.Web.ReferenceExtensions.Ref<Mobilize.Web.IWindow>((Mobilize.Web.IWindow)Mobilize.Web.Application.CurrentApplication.Variables.w_basewindow<basecomponents.Iw_basewindow>(), (v) => Mobilize.Web.Application.CurrentApplication.Variables.w_basewindow = (basecomponents.Iw_basewindow)v, () => Mobilize.Web.Application.CurrentApplication.Variables.w_basewindow<basecomponents.Iw_basewindow>()), (medicationcenter.Iw_mdi)(Mobilize.Web.Application.CurrentApplication.Variables.w_mdi<medicationcenter.Iw_mdi>()), 10, Mobilize.Web.ArrangeOpen.Layered);
               return null;
            //w_basewindow.openuserobject(ou_showallprescriptions)
            //ou_showallprescriptions.resize( w_basewindow.Workspacewidth(), w_basewindow.Workspaceheight())
            //ou_showallprescriptions.dw_all.resize( w_basewindow.Workspacewidth(), w_basewindow.Workspaceheight() - 50)
            }

            public override void Create()
            {
               base.Create();
               this.ToolbarItemText = "Show All Prescriptions";
            }

            public override void DoWmInit()
            {
               base.DoWmInit();
               this.clicked = new Mobilize.Web.MenuClickedEventHandler(Clicked);
            }

         }

         public partial class m_search_type
            : medicationcenter.m_basemdi.m_prescriptions_type.m_search_type, Im_adminmdiInner.Im_prescriptions_typeInner.Im_search_type
         {

            public m_search_type(Mobilize.Web.BaseControl parent)
            : base(parent)
            {
            }

            private new m_adminmdi.m_prescriptions_type Parent => (m_adminmdi.m_prescriptions_type)base.Parent;

            public override int? Clicked()
            {
               int? AncestorReturnValue = null;
               AncestorReturnValue = base.Clicked();
               Mobilize.Web.BuiltInExtensions.OpenSheetWithParm(Mobilize.Web.ReferenceExtensions.Ref<Mobilize.Web.IWindow>((Mobilize.Web.IWindow)Mobilize.Web.Application.CurrentApplication.Variables.w_prescriptionmant<medicationcenter.Iw_prescriptionmant>(), (v) => Mobilize.Web.Application.CurrentApplication.Variables.w_prescriptionmant = (medicationcenter.Iw_prescriptionmant)v, () => Mobilize.Web.Application.CurrentApplication.Variables.w_prescriptionmant<medicationcenter.Iw_prescriptionmant>()), 3, (medicationcenter.Iw_mdi)(Mobilize.Web.Application.CurrentApplication.Variables.w_mdi<medicationcenter.Iw_mdi>()), 10, Mobilize.Web.ArrangeOpen.Layered);
               return null;
            }

            public override void DoWmInit()
            {
               base.DoWmInit();
               this.clicked = new Mobilize.Web.MenuClickedEventHandler(Clicked);
            }

         }

         public partial class m_removeprescription_type
            : medicationcenter.m_basemdi.m_prescriptions_type.m_removeprescription_type, Im_adminmdiInner.Im_prescriptions_typeInner.Im_removeprescription_type
         {

            public m_removeprescription_type(Mobilize.Web.BaseControl parent)
            : base(parent)
            {
            }

            private new m_adminmdi.m_prescriptions_type Parent => (m_adminmdi.m_prescriptions_type)base.Parent;

            public virtual int? Clicked()
            {
               int? AncestorReturnValue = null;
               Mobilize.Web.BuiltInExtensions.OpenSheetWithParm(Mobilize.Web.ReferenceExtensions.Ref<Mobilize.Web.IWindow>((Mobilize.Web.IWindow)Mobilize.Web.Application.CurrentApplication.Variables.w_prescriptionmant<medicationcenter.Iw_prescriptionmant>(), (v) => Mobilize.Web.Application.CurrentApplication.Variables.w_prescriptionmant = (medicationcenter.Iw_prescriptionmant)v, () => Mobilize.Web.Application.CurrentApplication.Variables.w_prescriptionmant<medicationcenter.Iw_prescriptionmant>()), 2, (medicationcenter.Iw_mdi)(Mobilize.Web.Application.CurrentApplication.Variables.w_mdi<medicationcenter.Iw_mdi>()), 10, Mobilize.Web.ArrangeOpen.Layered);
               return null;
            }

            public override void Create()
            {
               base.Create();
               this.Visible = true;
               this.ToolbarItemVisible = true;
            }

            public override void DoWmInit()
            {
               base.DoWmInit();
               this.clicked = new Mobilize.Web.MenuClickedEventHandler(Clicked);
            }

         }

         public partial class m_dwcontrolsampler_type
            : medicationcenter.m_basemdi.m_prescriptions_type.m_dwcontrolsampler_type, Im_adminmdiInner.Im_prescriptions_typeInner.Im_dwcontrolsampler_type
         {

            public m_dwcontrolsampler_type(Mobilize.Web.BaseControl parent)
            : base(parent)
            {
            }

            private new m_adminmdi.m_prescriptions_type Parent => (m_adminmdi.m_prescriptions_type)base.Parent;

         }

      }

      public partial class m_edit_type
         : medicationcenter.m_basemdi.m_edit_type, Im_adminmdiInner.Im_edit_type
      {

         public m_edit_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new m_adminmdi Parent => (m_adminmdi)base.Parent;

         protected override medicationcenter.Im_basemdiInner.Im_edit_typeInner.Im_save_type CreateInnerControl_m_save_type()
         {
            return Mobilize.Web.Application.Create<Im_adminmdiInner.Im_edit_typeInner.Im_save_type>(this);
         }

         protected override medicationcenter.Im_basemdiInner.Im_edit_typeInner.Im_close_type CreateInnerControl_m_close_type()
         {
            return Mobilize.Web.Application.Create<Im_adminmdiInner.Im_edit_typeInner.Im_close_type>(this);
         }

         public partial class m_save_type
            : medicationcenter.m_basemdi.m_edit_type.m_save_type, Im_adminmdiInner.Im_edit_typeInner.Im_save_type
         {

            public m_save_type(Mobilize.Web.BaseControl parent)
            : base(parent)
            {
            }

            private new m_adminmdi.m_edit_type Parent => (m_adminmdi.m_edit_type)base.Parent;

         }

         public partial class m_close_type
            : medicationcenter.m_basemdi.m_edit_type.m_close_type, Im_adminmdiInner.Im_edit_typeInner.Im_close_type
         {

            public m_close_type(Mobilize.Web.BaseControl parent)
            : base(parent)
            {
            }

            private new m_adminmdi.m_edit_type Parent => (m_adminmdi.m_edit_type)base.Parent;

         }

      }

   }

}