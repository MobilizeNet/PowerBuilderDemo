namespace pbj_webmapdemo
{

   [Mobilize.WebMap.Common.Attributes.Observable]
   public partial class m_main_menu
      : Mobilize.Web.Menu, pbj_webmapdemo.Im_main_menu
   {

      public override void Create()
      {
         Mobilize.Web.Application.CurrentApplication.Variables.m_main_menu = (Mobilize.Web.IMenu)(this);
         base.Create();
         this.Text = "m_main_menu";
         this.TextSize = 8;
         this.Weight = 400;
         this.FaceName = "Tahoma";
         this.m_controls = CreateInnerControl_m_controls_type();
         this.m_features = CreateInnerControl_m_features_type();
         this.m_medicalcenter = CreateInnerControl_m_medicalcenter_type();
         this.m_reports = CreateInnerControl_m_reports_type();
         this.Item[this.Item.GetUpperBound() + 1] = this.m_controls;
         this.Item[this.Item.GetUpperBound() + 1] = this.m_features;
         this.Item[this.Item.GetUpperBound() + 1] = this.m_medicalcenter;
         this.Item[this.Item.GetUpperBound() + 1] = this.m_reports;
      }

      public override void Destroy()
      {
         base.Destroy();
         this.m_controls = null;
         this.m_features = null;
         this.m_medicalcenter = null;
         this.m_reports = null;
      }

      protected virtual Im_main_menuInner.Im_controls_type CreateInnerControl_m_controls_type()
      {
         return Mobilize.Web.Application.Create<Im_main_menuInner.Im_controls_type>(this);
      }

      protected virtual Im_main_menuInner.Im_features_type CreateInnerControl_m_features_type()
      {
         return Mobilize.Web.Application.Create<Im_main_menuInner.Im_features_type>(this);
      }

      protected virtual Im_main_menuInner.Im_medicalcenter_type CreateInnerControl_m_medicalcenter_type()
      {
         return Mobilize.Web.Application.Create<Im_main_menuInner.Im_medicalcenter_type>(this);
      }

      protected virtual Im_main_menuInner.Im_reports_type CreateInnerControl_m_reports_type()
      {
         return Mobilize.Web.Application.Create<Im_main_menuInner.Im_reports_type>(this);
      }

      public partial class m_controls_type
         : Mobilize.Web.Menu, Im_main_menuInner.Im_controls_type
      {

         public m_controls_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new m_main_menu Parent => (m_main_menu)base.Parent;

         [Mobilize.WebMap.Common.Attributes.Intercepted]
         public Im_main_menuInner.Im_controls_typeInner.Im_statictext_type m_statictext { get; set; }

         [Mobilize.WebMap.Common.Attributes.Intercepted]
         public Im_main_menuInner.Im_controls_typeInner.Im_0_type m_0 { get; set; }

         [Mobilize.WebMap.Common.Attributes.Intercepted]
         public Im_main_menuInner.Im_controls_typeInner.Im_commandbutton_type m_commandbutton { get; set; }

         [Mobilize.WebMap.Common.Attributes.Intercepted]
         public Im_main_menuInner.Im_controls_typeInner.Im_editmask_type m_editmask { get; set; }

         [Mobilize.WebMap.Common.Attributes.Intercepted]
         public Im_main_menuInner.Im_controls_typeInner.Im_multilineedit_type m_multilineedit { get; set; }

         [Mobilize.WebMap.Common.Attributes.Intercepted]
         public Im_main_menuInner.Im_controls_typeInner.Im_radiobutton_type m_radiobutton { get; set; }

         [Mobilize.WebMap.Common.Attributes.Intercepted]
         public Im_main_menuInner.Im_controls_typeInner.Im_checkbox_type m_checkbox { get; set; }

         [Mobilize.WebMap.Common.Attributes.Intercepted]
         public Im_main_menuInner.Im_controls_typeInner.Im_dropdownlistbox_type m_dropdownlistbox { get; set; }

         [Mobilize.WebMap.Common.Attributes.Intercepted]
         public Im_main_menuInner.Im_controls_typeInner.Im_picture_type m_picture { get; set; }

         [Mobilize.WebMap.Common.Attributes.Intercepted]
         public Im_main_menuInner.Im_controls_typeInner.Im_picturebutton_type m_picturebutton { get; set; }

         [Mobilize.WebMap.Common.Attributes.Intercepted]
         public Im_main_menuInner.Im_controls_typeInner.Im_datamangercontrols_type m_datamangercontrols { get; set; }

         public override void Create()
         {
            base.Create();
            this.Text = "&Controls";
            this.TextSize = 8;
            this.Weight = 400;
            this.FaceName = "Tahoma";
            this.m_statictext = CreateInnerControl_m_statictext_type();
            this.m_0 = CreateInnerControl_m_0_type();
            this.m_commandbutton = CreateInnerControl_m_commandbutton_type();
            this.m_editmask = CreateInnerControl_m_editmask_type();
            this.m_multilineedit = CreateInnerControl_m_multilineedit_type();
            this.m_radiobutton = CreateInnerControl_m_radiobutton_type();
            this.m_checkbox = CreateInnerControl_m_checkbox_type();
            this.m_dropdownlistbox = CreateInnerControl_m_dropdownlistbox_type();
            this.m_picture = CreateInnerControl_m_picture_type();
            this.m_picturebutton = CreateInnerControl_m_picturebutton_type();
            this.m_datamangercontrols = CreateInnerControl_m_datamangercontrols_type();
            this.Item[this.Item.GetUpperBound() + 1] = this.m_statictext;
            this.Item[this.Item.GetUpperBound() + 1] = this.m_0;
            this.Item[this.Item.GetUpperBound() + 1] = this.m_commandbutton;
            this.Item[this.Item.GetUpperBound() + 1] = this.m_editmask;
            this.Item[this.Item.GetUpperBound() + 1] = this.m_multilineedit;
            this.Item[this.Item.GetUpperBound() + 1] = this.m_radiobutton;
            this.Item[this.Item.GetUpperBound() + 1] = this.m_checkbox;
            this.Item[this.Item.GetUpperBound() + 1] = this.m_dropdownlistbox;
            this.Item[this.Item.GetUpperBound() + 1] = this.m_picture;
            this.Item[this.Item.GetUpperBound() + 1] = this.m_picturebutton;
            this.Item[this.Item.GetUpperBound() + 1] = this.m_datamangercontrols;
         }

         protected virtual Im_main_menuInner.Im_controls_typeInner.Im_statictext_type CreateInnerControl_m_statictext_type()
         {
            return Mobilize.Web.Application.Create<Im_main_menuInner.Im_controls_typeInner.Im_statictext_type>(this);
         }

         protected virtual Im_main_menuInner.Im_controls_typeInner.Im_0_type CreateInnerControl_m_0_type()
         {
            return Mobilize.Web.Application.Create<Im_main_menuInner.Im_controls_typeInner.Im_0_type>(this);
         }

         protected virtual Im_main_menuInner.Im_controls_typeInner.Im_commandbutton_type CreateInnerControl_m_commandbutton_type()
         {
            return Mobilize.Web.Application.Create<Im_main_menuInner.Im_controls_typeInner.Im_commandbutton_type>(this);
         }

         protected virtual Im_main_menuInner.Im_controls_typeInner.Im_editmask_type CreateInnerControl_m_editmask_type()
         {
            return Mobilize.Web.Application.Create<Im_main_menuInner.Im_controls_typeInner.Im_editmask_type>(this);
         }

         protected virtual Im_main_menuInner.Im_controls_typeInner.Im_multilineedit_type CreateInnerControl_m_multilineedit_type()
         {
            return Mobilize.Web.Application.Create<Im_main_menuInner.Im_controls_typeInner.Im_multilineedit_type>(this);
         }

         protected virtual Im_main_menuInner.Im_controls_typeInner.Im_radiobutton_type CreateInnerControl_m_radiobutton_type()
         {
            return Mobilize.Web.Application.Create<Im_main_menuInner.Im_controls_typeInner.Im_radiobutton_type>(this);
         }

         protected virtual Im_main_menuInner.Im_controls_typeInner.Im_checkbox_type CreateInnerControl_m_checkbox_type()
         {
            return Mobilize.Web.Application.Create<Im_main_menuInner.Im_controls_typeInner.Im_checkbox_type>(this);
         }

         protected virtual Im_main_menuInner.Im_controls_typeInner.Im_dropdownlistbox_type CreateInnerControl_m_dropdownlistbox_type()
         {
            return Mobilize.Web.Application.Create<Im_main_menuInner.Im_controls_typeInner.Im_dropdownlistbox_type>(this);
         }

         protected virtual Im_main_menuInner.Im_controls_typeInner.Im_picture_type CreateInnerControl_m_picture_type()
         {
            return Mobilize.Web.Application.Create<Im_main_menuInner.Im_controls_typeInner.Im_picture_type>(this);
         }

         protected virtual Im_main_menuInner.Im_controls_typeInner.Im_picturebutton_type CreateInnerControl_m_picturebutton_type()
         {
            return Mobilize.Web.Application.Create<Im_main_menuInner.Im_controls_typeInner.Im_picturebutton_type>(this);
         }

         protected virtual Im_main_menuInner.Im_controls_typeInner.Im_datamangercontrols_type CreateInnerControl_m_datamangercontrols_type()
         {
            return Mobilize.Web.Application.Create<Im_main_menuInner.Im_controls_typeInner.Im_datamangercontrols_type>(this);
         }

         public partial class m_statictext_type
            : Mobilize.Web.Menu, Im_main_menuInner.Im_controls_typeInner.Im_statictext_type
         {

            public m_statictext_type(Mobilize.Web.BaseControl parent)
            : base(parent)
            {
            }

            private new m_main_menu.m_controls_type Parent => (m_main_menu.m_controls_type)base.Parent;

            public virtual int? Clicked()
            {
               Mobilize.Web.BuiltInExtensions.OpenSheet(Mobilize.Web.ReferenceExtensions.Ref<Mobilize.Web.IWindow>((Mobilize.Web.IWindow)Mobilize.Web.Application.CurrentApplication.Variables.w_static_text<pbj_webmapdemo.Iw_static_text>(), (v) => Mobilize.Web.Application.CurrentApplication.Variables.w_static_text = (pbj_webmapdemo.Iw_static_text)v, () => Mobilize.Web.Application.CurrentApplication.Variables.w_static_text<pbj_webmapdemo.Iw_static_text>()), (pbj_webmapdemo.Iw_pbj_main)(Mobilize.Web.Application.CurrentApplication.Variables.w_pbj_main<pbj_webmapdemo.Iw_pbj_main>()), 4, Mobilize.Web.ArrangeOpen.Original);
               return null;
            }

            public override void Create()
            {
               base.Create();
               this.Text = "&StaticText\tAlt+T";
               this.Shortcut = 596;
               this.TextSize = 8;
               this.Weight = 400;
               this.FaceName = "Tahoma";
            }

            public override void DoWmInit()
            {
               base.DoWmInit();
               this.clicked = new Mobilize.Web.MenuClickedEventHandler(Clicked);
            }

         }

         public partial class m_0_type
            : Mobilize.Web.Menu, Im_main_menuInner.Im_controls_typeInner.Im_0_type
         {

            public m_0_type(Mobilize.Web.BaseControl parent)
            : base(parent)
            {
            }

            private new m_main_menu.m_controls_type Parent => (m_main_menu.m_controls_type)base.Parent;

            public virtual int? Clicked()
            {
               Mobilize.Web.BuiltInExtensions.OpenSheet(Mobilize.Web.ReferenceExtensions.Ref<Mobilize.Web.IWindow>((Mobilize.Web.IWindow)Mobilize.Web.Application.CurrentApplication.Variables.w_single_line_edit<pbj_webmapdemo.Iw_single_line_edit>(), (v) => Mobilize.Web.Application.CurrentApplication.Variables.w_single_line_edit = (pbj_webmapdemo.Iw_single_line_edit)v, () => Mobilize.Web.Application.CurrentApplication.Variables.w_single_line_edit<pbj_webmapdemo.Iw_single_line_edit>()), (pbj_webmapdemo.Iw_pbj_main)(Mobilize.Web.Application.CurrentApplication.Variables.w_pbj_main<pbj_webmapdemo.Iw_pbj_main>()), 4, Mobilize.Web.ArrangeOpen.Original);
               return null;
            }

            public override void Create()
            {
               base.Create();
               this.Text = "&SingleLineEdit\tAlt+S";
               this.Shortcut = 595;
               this.TextSize = 8;
               this.Weight = 400;
               this.FaceName = "Tahoma";
            }

            public override void DoWmInit()
            {
               base.DoWmInit();
               this.clicked = new Mobilize.Web.MenuClickedEventHandler(Clicked);
            }

         }

         public partial class m_commandbutton_type
            : Mobilize.Web.Menu, Im_main_menuInner.Im_controls_typeInner.Im_commandbutton_type
         {

            public m_commandbutton_type(Mobilize.Web.BaseControl parent)
            : base(parent)
            {
            }

            private new m_main_menu.m_controls_type Parent => (m_main_menu.m_controls_type)base.Parent;

            public virtual int? Clicked()
            {
               Mobilize.Web.BuiltInExtensions.OpenSheet(Mobilize.Web.ReferenceExtensions.Ref<Mobilize.Web.IWindow>((Mobilize.Web.IWindow)Mobilize.Web.Application.CurrentApplication.Variables.w_command_button<pbj_webmapdemo.Iw_command_button>(), (v) => Mobilize.Web.Application.CurrentApplication.Variables.w_command_button = (pbj_webmapdemo.Iw_command_button)v, () => Mobilize.Web.Application.CurrentApplication.Variables.w_command_button<pbj_webmapdemo.Iw_command_button>()), (pbj_webmapdemo.Iw_pbj_main)(Mobilize.Web.Application.CurrentApplication.Variables.w_pbj_main<pbj_webmapdemo.Iw_pbj_main>()), 4, Mobilize.Web.ArrangeOpen.Original);
               return null;
            }

            public override void Create()
            {
               base.Create();
               this.Text = "Command&Button\tAlt+B";
               this.Shortcut = 578;
               this.TextSize = 8;
               this.Weight = 400;
               this.FaceName = "Tahoma";
            }

            public override void DoWmInit()
            {
               base.DoWmInit();
               this.clicked = new Mobilize.Web.MenuClickedEventHandler(Clicked);
            }

         }

         public partial class m_editmask_type
            : Mobilize.Web.Menu, Im_main_menuInner.Im_controls_typeInner.Im_editmask_type
         {

            public m_editmask_type(Mobilize.Web.BaseControl parent)
            : base(parent)
            {
            }

            private new m_main_menu.m_controls_type Parent => (m_main_menu.m_controls_type)base.Parent;

            public virtual int? Clicked()
            {
               Mobilize.Web.BuiltInExtensions.OpenSheet(Mobilize.Web.ReferenceExtensions.Ref<Mobilize.Web.IWindow>((Mobilize.Web.IWindow)Mobilize.Web.Application.CurrentApplication.Variables.w_edit_mask<pbj_webmapdemo.Iw_edit_mask>(), (v) => Mobilize.Web.Application.CurrentApplication.Variables.w_edit_mask = (pbj_webmapdemo.Iw_edit_mask)v, () => Mobilize.Web.Application.CurrentApplication.Variables.w_edit_mask<pbj_webmapdemo.Iw_edit_mask>()), (pbj_webmapdemo.Iw_pbj_main)(Mobilize.Web.Application.CurrentApplication.Variables.w_pbj_main<pbj_webmapdemo.Iw_pbj_main>()), 4, Mobilize.Web.ArrangeOpen.Original);
               return null;
            }

            public override void Create()
            {
               base.Create();
               this.Text = "&EditMask\tAlt+E";
               this.Shortcut = 581;
               this.TextSize = 8;
               this.Weight = 400;
               this.FaceName = "Tahoma";
            }

            public override void DoWmInit()
            {
               base.DoWmInit();
               this.clicked = new Mobilize.Web.MenuClickedEventHandler(Clicked);
            }

         }

         public partial class m_multilineedit_type
            : Mobilize.Web.Menu, Im_main_menuInner.Im_controls_typeInner.Im_multilineedit_type
         {

            public m_multilineedit_type(Mobilize.Web.BaseControl parent)
            : base(parent)
            {
            }

            private new m_main_menu.m_controls_type Parent => (m_main_menu.m_controls_type)base.Parent;

            public virtual int? Clicked()
            {
               Mobilize.Web.BuiltInExtensions.OpenSheet(Mobilize.Web.ReferenceExtensions.Ref<Mobilize.Web.IWindow>((Mobilize.Web.IWindow)Mobilize.Web.Application.CurrentApplication.Variables.w_muti_line_edit<pbj_webmapdemo.Iw_muti_line_edit>(), (v) => Mobilize.Web.Application.CurrentApplication.Variables.w_muti_line_edit = (pbj_webmapdemo.Iw_muti_line_edit)v, () => Mobilize.Web.Application.CurrentApplication.Variables.w_muti_line_edit<pbj_webmapdemo.Iw_muti_line_edit>()), (pbj_webmapdemo.Iw_pbj_main)(Mobilize.Web.Application.CurrentApplication.Variables.w_pbj_main<pbj_webmapdemo.Iw_pbj_main>()), 4, Mobilize.Web.ArrangeOpen.Original);
               return null;
            }

            public override void Create()
            {
               base.Create();
               this.Text = "&MultiLineEdit\tAlt+M";
               this.Shortcut = 589;
               this.TextSize = 8;
               this.Weight = 400;
               this.FaceName = "Tahoma";
            }

            public override void DoWmInit()
            {
               base.DoWmInit();
               this.clicked = new Mobilize.Web.MenuClickedEventHandler(Clicked);
            }

         }

         public partial class m_radiobutton_type
            : Mobilize.Web.Menu, Im_main_menuInner.Im_controls_typeInner.Im_radiobutton_type
         {

            public m_radiobutton_type(Mobilize.Web.BaseControl parent)
            : base(parent)
            {
            }

            private new m_main_menu.m_controls_type Parent => (m_main_menu.m_controls_type)base.Parent;

            public virtual int? Clicked()
            {
               Mobilize.Web.BuiltInExtensions.OpenSheet(Mobilize.Web.ReferenceExtensions.Ref<Mobilize.Web.IWindow>((Mobilize.Web.IWindow)Mobilize.Web.Application.CurrentApplication.Variables.w_radio_button<pbj_webmapdemo.Iw_radio_button>(), (v) => Mobilize.Web.Application.CurrentApplication.Variables.w_radio_button = (pbj_webmapdemo.Iw_radio_button)v, () => Mobilize.Web.Application.CurrentApplication.Variables.w_radio_button<pbj_webmapdemo.Iw_radio_button>()), (pbj_webmapdemo.Iw_pbj_main)(Mobilize.Web.Application.CurrentApplication.Variables.w_pbj_main<pbj_webmapdemo.Iw_pbj_main>()), 4, Mobilize.Web.ArrangeOpen.Original);
               return null;
            }

            public override void Create()
            {
               base.Create();
               this.Text = "&RadioButton\tAlt+R";
               this.Shortcut = 594;
               this.TextSize = 8;
               this.Weight = 400;
               this.FaceName = "Tahoma";
            }

            public override void DoWmInit()
            {
               base.DoWmInit();
               this.clicked = new Mobilize.Web.MenuClickedEventHandler(Clicked);
            }

         }

         public partial class m_checkbox_type
            : Mobilize.Web.Menu, Im_main_menuInner.Im_controls_typeInner.Im_checkbox_type
         {

            public m_checkbox_type(Mobilize.Web.BaseControl parent)
            : base(parent)
            {
            }

            private new m_main_menu.m_controls_type Parent => (m_main_menu.m_controls_type)base.Parent;

            public virtual int? Clicked()
            {
               Mobilize.Web.BuiltInExtensions.OpenSheet(Mobilize.Web.ReferenceExtensions.Ref<Mobilize.Web.IWindow>((Mobilize.Web.IWindow)Mobilize.Web.Application.CurrentApplication.Variables.w_check_box<pbj_webmapdemo.Iw_check_box>(), (v) => Mobilize.Web.Application.CurrentApplication.Variables.w_check_box = (pbj_webmapdemo.Iw_check_box)v, () => Mobilize.Web.Application.CurrentApplication.Variables.w_check_box<pbj_webmapdemo.Iw_check_box>()), (pbj_webmapdemo.Iw_pbj_main)(Mobilize.Web.Application.CurrentApplication.Variables.w_pbj_main<pbj_webmapdemo.Iw_pbj_main>()), 4, Mobilize.Web.ArrangeOpen.Original);
               return null;
            }

            public override void Create()
            {
               base.Create();
               this.Text = "C&heckBox\tAlt+H";
               this.Shortcut = 584;
               this.TextSize = 8;
               this.Weight = 400;
               this.FaceName = "Tahoma";
            }

            public override void DoWmInit()
            {
               base.DoWmInit();
               this.clicked = new Mobilize.Web.MenuClickedEventHandler(Clicked);
            }

         }

         public partial class m_dropdownlistbox_type
            : Mobilize.Web.Menu, Im_main_menuInner.Im_controls_typeInner.Im_dropdownlistbox_type
         {

            public m_dropdownlistbox_type(Mobilize.Web.BaseControl parent)
            : base(parent)
            {
            }

            private new m_main_menu.m_controls_type Parent => (m_main_menu.m_controls_type)base.Parent;

            public virtual int? Clicked()
            {
               Mobilize.Web.BuiltInExtensions.OpenSheet(Mobilize.Web.ReferenceExtensions.Ref<Mobilize.Web.IWindow>((Mobilize.Web.IWindow)Mobilize.Web.Application.CurrentApplication.Variables.w_dropdown_listbox<pbj_webmapdemo.Iw_dropdown_listbox>(), (v) => Mobilize.Web.Application.CurrentApplication.Variables.w_dropdown_listbox = (pbj_webmapdemo.Iw_dropdown_listbox)v, () => Mobilize.Web.Application.CurrentApplication.Variables.w_dropdown_listbox<pbj_webmapdemo.Iw_dropdown_listbox>()), (pbj_webmapdemo.Iw_pbj_main)(Mobilize.Web.Application.CurrentApplication.Variables.w_pbj_main<pbj_webmapdemo.Iw_pbj_main>()), 4, Mobilize.Web.ArrangeOpen.Original);
               return null;
            }

            public override void Create()
            {
               base.Create();
               this.Text = "&DropDownListBox\tAlt+D";
               this.Shortcut = 580;
               this.TextSize = 8;
               this.Weight = 400;
               this.FaceName = "Tahoma";
            }

            public override void DoWmInit()
            {
               base.DoWmInit();
               this.clicked = new Mobilize.Web.MenuClickedEventHandler(Clicked);
            }

         }

         public partial class m_picture_type
            : Mobilize.Web.Menu, Im_main_menuInner.Im_controls_typeInner.Im_picture_type
         {

            public m_picture_type(Mobilize.Web.BaseControl parent)
            : base(parent)
            {
            }

            private new m_main_menu.m_controls_type Parent => (m_main_menu.m_controls_type)base.Parent;

            public virtual int? Clicked()
            {
               Mobilize.Web.BuiltInExtensions.OpenSheet(Mobilize.Web.ReferenceExtensions.Ref<Mobilize.Web.IWindow>((Mobilize.Web.IWindow)Mobilize.Web.Application.CurrentApplication.Variables.w_picture<pbj_webmapdemo.Iw_picture>(), (v) => Mobilize.Web.Application.CurrentApplication.Variables.w_picture = (pbj_webmapdemo.Iw_picture)v, () => Mobilize.Web.Application.CurrentApplication.Variables.w_picture<pbj_webmapdemo.Iw_picture>()), (pbj_webmapdemo.Iw_pbj_main)(Mobilize.Web.Application.CurrentApplication.Variables.w_pbj_main<pbj_webmapdemo.Iw_pbj_main>()), 4, Mobilize.Web.ArrangeOpen.Original);
               return null;
            }

            public override void Create()
            {
               base.Create();
               this.Text = "&Picture\tAlt+P";
               this.Shortcut = 592;
               this.TextSize = 8;
               this.Weight = 400;
               this.FaceName = "Tahoma";
            }

            public override void DoWmInit()
            {
               base.DoWmInit();
               this.clicked = new Mobilize.Web.MenuClickedEventHandler(Clicked);
            }

         }

         public partial class m_picturebutton_type
            : Mobilize.Web.Menu, Im_main_menuInner.Im_controls_typeInner.Im_picturebutton_type
         {

            public m_picturebutton_type(Mobilize.Web.BaseControl parent)
            : base(parent)
            {
            }

            private new m_main_menu.m_controls_type Parent => (m_main_menu.m_controls_type)base.Parent;

            public virtual int? Clicked()
            {
               Mobilize.Web.BuiltInExtensions.OpenSheet(Mobilize.Web.ReferenceExtensions.Ref<Mobilize.Web.IWindow>((Mobilize.Web.IWindow)Mobilize.Web.Application.CurrentApplication.Variables.w_picture_button<pbj_webmapdemo.Iw_picture_button>(), (v) => Mobilize.Web.Application.CurrentApplication.Variables.w_picture_button = (pbj_webmapdemo.Iw_picture_button)v, () => Mobilize.Web.Application.CurrentApplication.Variables.w_picture_button<pbj_webmapdemo.Iw_picture_button>()), (pbj_webmapdemo.Iw_pbj_main)(Mobilize.Web.Application.CurrentApplication.Variables.w_pbj_main<pbj_webmapdemo.Iw_pbj_main>()), 4, Mobilize.Web.ArrangeOpen.Original);
               return null;
            }

            public override void Create()
            {
               base.Create();
               this.Text = "P&ictureButton\tAlt+I";
               this.Shortcut = 585;
               this.TextSize = 8;
               this.Weight = 400;
               this.FaceName = "Tahoma";
            }

            public override void DoWmInit()
            {
               base.DoWmInit();
               this.clicked = new Mobilize.Web.MenuClickedEventHandler(Clicked);
            }

         }

         public partial class m_datamangercontrols_type
            : Mobilize.Web.Menu, Im_main_menuInner.Im_controls_typeInner.Im_datamangercontrols_type
         {

            public m_datamangercontrols_type(Mobilize.Web.BaseControl parent)
            : base(parent)
            {
            }

            private new m_main_menu.m_controls_type Parent => (m_main_menu.m_controls_type)base.Parent;

            [Mobilize.WebMap.Common.Attributes.Intercepted]
            public Im_main_menuInner.Im_controls_typeInner.Im_datamangercontrols_typeInner.Im_dropdowndw_type m_dropdowndw { get; set; }

            public override void Create()
            {
               base.Create();
               this.Text = "&DataManger Controls";
               this.TextSize = 8;
               this.Weight = 400;
               this.FaceName = "Tahoma";
               this.m_dropdowndw = CreateInnerControl_m_dropdowndw_type();
               this.Item[this.Item.GetUpperBound() + 1] = this.m_dropdowndw;
            }

            protected virtual Im_main_menuInner.Im_controls_typeInner.Im_datamangercontrols_typeInner.Im_dropdowndw_type CreateInnerControl_m_dropdowndw_type()
            {
               return Mobilize.Web.Application.Create<Im_main_menuInner.Im_controls_typeInner.Im_datamangercontrols_typeInner.Im_dropdowndw_type>(this);
            }

            public partial class m_dropdowndw_type
               : Mobilize.Web.Menu, Im_main_menuInner.Im_controls_typeInner.Im_datamangercontrols_typeInner.Im_dropdowndw_type
            {

               public m_dropdowndw_type(Mobilize.Web.BaseControl parent)
               : base(parent)
               {
               }

               private new m_main_menu.m_controls_type.m_datamangercontrols_type Parent => (m_main_menu.m_controls_type.m_datamangercontrols_type)base.Parent;

               public virtual int? Clicked()
               {
                  Mobilize.Web.BuiltInExtensions.OpenSheet(Mobilize.Web.ReferenceExtensions.Ref<Mobilize.Web.IWindow>((Mobilize.Web.IWindow)Mobilize.Web.Application.CurrentApplication.Variables.w_dw_dropdowndatawindow<pbj_webmapdemo.Iw_dw_dropdowndatawindow>(), (v) => Mobilize.Web.Application.CurrentApplication.Variables.w_dw_dropdowndatawindow = (pbj_webmapdemo.Iw_dw_dropdowndatawindow)v, () => Mobilize.Web.Application.CurrentApplication.Variables.w_dw_dropdowndatawindow<pbj_webmapdemo.Iw_dw_dropdowndatawindow>()), (pbj_webmapdemo.Iw_pbj_main)(Mobilize.Web.Application.CurrentApplication.Variables.w_pbj_main<pbj_webmapdemo.Iw_pbj_main>()), 4, Mobilize.Web.ArrangeOpen.Original);
                  return null;
               }

               public override void Create()
               {
                  base.Create();
                  this.Text = "&DropDownDW";
                  this.TextSize = 8;
                  this.Weight = 400;
                  this.FaceName = "Tahoma";
               }

               public override void DoWmInit()
               {
                  base.DoWmInit();
                  this.clicked = new Mobilize.Web.MenuClickedEventHandler(Clicked);
               }

            }

         }

      }

      public partial class m_features_type
         : Mobilize.Web.Menu, Im_main_menuInner.Im_features_type
      {

         public m_features_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new m_main_menu Parent => (m_main_menu)base.Parent;

         [Mobilize.WebMap.Common.Attributes.Intercepted]
         public Im_main_menuInner.Im_features_typeInner.Im_datawindowcrud_type m_datawindowcrud { get; set; }

         [Mobilize.WebMap.Common.Attributes.Intercepted]
         public Im_main_menuInner.Im_features_typeInner.Im_datamanagereventonsinglerow_type m_datamanagereventonsinglerow { get; set; }

         [Mobilize.WebMap.Common.Attributes.Intercepted]
         public Im_main_menuInner.Im_features_typeInner.Im_alldatamanagercontrolinteractions_type m_alldatamanagercontrolinteractions { get; set; }

         [Mobilize.WebMap.Common.Attributes.Intercepted]
         public Im_main_menuInner.Im_features_typeInner.Im_1_type m_1 { get; set; }

         [Mobilize.WebMap.Common.Attributes.Intercepted]
         public Im_main_menuInner.Im_features_typeInner.Im_2_type m_2 { get; set; }

         [Mobilize.WebMap.Common.Attributes.Intercepted]
         public Im_main_menuInner.Im_features_typeInner.Im_3_type m_3 { get; set; }

         [Mobilize.WebMap.Common.Attributes.Intercepted]
         public Im_main_menuInner.Im_features_typeInner.Im_4_type m_4 { get; set; }

         [Mobilize.WebMap.Common.Attributes.Intercepted]
         public Im_main_menuInner.Im_features_typeInner.Im_datamanagerstate_nodata_type m_datamanagerstate_nodata { get; set; }

         [Mobilize.WebMap.Common.Attributes.Intercepted]
         public Im_main_menuInner.Im_features_typeInner.Im_datamanagerw_window_type m_datamanagerw_window { get; set; }

         [Mobilize.WebMap.Common.Attributes.Intercepted]
         public Im_main_menuInner.Im_features_typeInner.Im_datamanagerw_shared_type m_datamanagerw_shared { get; set; }

         [Mobilize.WebMap.Common.Attributes.Intercepted]
         public Im_main_menuInner.Im_features_typeInner.Im_datamanagerw_dropdown_type m_datamanagerw_dropdown { get; set; }

         [Mobilize.WebMap.Common.Attributes.Intercepted]
         public Im_main_menuInner.Im_features_typeInner.Im_datamanagerw_expression_type m_datamanagerw_expression { get; set; }

         public override void Create()
         {
            base.Create();
            this.Text = "&Features";
            this.TextSize = 8;
            this.Weight = 400;
            this.FaceName = "Tahoma";
            this.m_datawindowcrud = CreateInnerControl_m_datawindowcrud_type();
            this.m_datamanagereventonsinglerow = CreateInnerControl_m_datamanagereventonsinglerow_type();
            this.m_alldatamanagercontrolinteractions = CreateInnerControl_m_alldatamanagercontrolinteractions_type();
            this.m_1 = CreateInnerControl_m_1_type();
            this.m_2 = CreateInnerControl_m_2_type();
            this.m_3 = CreateInnerControl_m_3_type();
            this.m_4 = CreateInnerControl_m_4_type();
            this.m_datamanagerstate_nodata = CreateInnerControl_m_datamanagerstate_nodata_type();
            this.m_datamanagerw_window = CreateInnerControl_m_datamanagerw_window_type();
            this.m_datamanagerw_shared = CreateInnerControl_m_datamanagerw_shared_type();
            this.m_datamanagerw_dropdown = CreateInnerControl_m_datamanagerw_dropdown_type();
            this.m_datamanagerw_expression = CreateInnerControl_m_datamanagerw_expression_type();
            this.Item[this.Item.GetUpperBound() + 1] = this.m_datawindowcrud;
            this.Item[this.Item.GetUpperBound() + 1] = this.m_datamanagereventonsinglerow;
            this.Item[this.Item.GetUpperBound() + 1] = this.m_alldatamanagercontrolinteractions;
            this.Item[this.Item.GetUpperBound() + 1] = this.m_1;
            this.Item[this.Item.GetUpperBound() + 1] = this.m_2;
            this.Item[this.Item.GetUpperBound() + 1] = this.m_3;
            this.Item[this.Item.GetUpperBound() + 1] = this.m_4;
            this.Item[this.Item.GetUpperBound() + 1] = this.m_datamanagerstate_nodata;
            this.Item[this.Item.GetUpperBound() + 1] = this.m_datamanagerw_window;
            this.Item[this.Item.GetUpperBound() + 1] = this.m_datamanagerw_shared;
            this.Item[this.Item.GetUpperBound() + 1] = this.m_datamanagerw_dropdown;
            this.Item[this.Item.GetUpperBound() + 1] = this.m_datamanagerw_expression;
         }

         protected virtual Im_main_menuInner.Im_features_typeInner.Im_datawindowcrud_type CreateInnerControl_m_datawindowcrud_type()
         {
            return Mobilize.Web.Application.Create<Im_main_menuInner.Im_features_typeInner.Im_datawindowcrud_type>(this);
         }

         protected virtual Im_main_menuInner.Im_features_typeInner.Im_datamanagereventonsinglerow_type CreateInnerControl_m_datamanagereventonsinglerow_type()
         {
            return Mobilize.Web.Application.Create<Im_main_menuInner.Im_features_typeInner.Im_datamanagereventonsinglerow_type>(this);
         }

         protected virtual Im_main_menuInner.Im_features_typeInner.Im_alldatamanagercontrolinteractions_type CreateInnerControl_m_alldatamanagercontrolinteractions_type()
         {
            return Mobilize.Web.Application.Create<Im_main_menuInner.Im_features_typeInner.Im_alldatamanagercontrolinteractions_type>(this);
         }

         protected virtual Im_main_menuInner.Im_features_typeInner.Im_1_type CreateInnerControl_m_1_type()
         {
            return Mobilize.Web.Application.Create<Im_main_menuInner.Im_features_typeInner.Im_1_type>(this);
         }

         protected virtual Im_main_menuInner.Im_features_typeInner.Im_2_type CreateInnerControl_m_2_type()
         {
            return Mobilize.Web.Application.Create<Im_main_menuInner.Im_features_typeInner.Im_2_type>(this);
         }

         protected virtual Im_main_menuInner.Im_features_typeInner.Im_3_type CreateInnerControl_m_3_type()
         {
            return Mobilize.Web.Application.Create<Im_main_menuInner.Im_features_typeInner.Im_3_type>(this);
         }

         protected virtual Im_main_menuInner.Im_features_typeInner.Im_4_type CreateInnerControl_m_4_type()
         {
            return Mobilize.Web.Application.Create<Im_main_menuInner.Im_features_typeInner.Im_4_type>(this);
         }

         protected virtual Im_main_menuInner.Im_features_typeInner.Im_datamanagerstate_nodata_type CreateInnerControl_m_datamanagerstate_nodata_type()
         {
            return Mobilize.Web.Application.Create<Im_main_menuInner.Im_features_typeInner.Im_datamanagerstate_nodata_type>(this);
         }

         protected virtual Im_main_menuInner.Im_features_typeInner.Im_datamanagerw_window_type CreateInnerControl_m_datamanagerw_window_type()
         {
            return Mobilize.Web.Application.Create<Im_main_menuInner.Im_features_typeInner.Im_datamanagerw_window_type>(this);
         }

         protected virtual Im_main_menuInner.Im_features_typeInner.Im_datamanagerw_shared_type CreateInnerControl_m_datamanagerw_shared_type()
         {
            return Mobilize.Web.Application.Create<Im_main_menuInner.Im_features_typeInner.Im_datamanagerw_shared_type>(this);
         }

         protected virtual Im_main_menuInner.Im_features_typeInner.Im_datamanagerw_dropdown_type CreateInnerControl_m_datamanagerw_dropdown_type()
         {
            return Mobilize.Web.Application.Create<Im_main_menuInner.Im_features_typeInner.Im_datamanagerw_dropdown_type>(this);
         }

         protected virtual Im_main_menuInner.Im_features_typeInner.Im_datamanagerw_expression_type CreateInnerControl_m_datamanagerw_expression_type()
         {
            return Mobilize.Web.Application.Create<Im_main_menuInner.Im_features_typeInner.Im_datamanagerw_expression_type>(this);
         }

         public partial class m_datawindowcrud_type
            : Mobilize.Web.Menu, Im_main_menuInner.Im_features_typeInner.Im_datawindowcrud_type
         {

            public m_datawindowcrud_type(Mobilize.Web.BaseControl parent)
            : base(parent)
            {
            }

            private new m_main_menu.m_features_type Parent => (m_main_menu.m_features_type)base.Parent;

            public virtual int? Clicked()
            {
               Mobilize.Web.BuiltInExtensions.OpenSheet(Mobilize.Web.ReferenceExtensions.Ref<Mobilize.Web.IWindow>((Mobilize.Web.IWindow)Mobilize.Web.Application.CurrentApplication.Variables.w_dw_features<pbj_webmapdemo.Iw_dw_features>(), (v) => Mobilize.Web.Application.CurrentApplication.Variables.w_dw_features = (pbj_webmapdemo.Iw_dw_features)v, () => Mobilize.Web.Application.CurrentApplication.Variables.w_dw_features<pbj_webmapdemo.Iw_dw_features>()), (pbj_webmapdemo.Iw_pbj_main)(Mobilize.Web.Application.CurrentApplication.Variables.w_pbj_main<pbj_webmapdemo.Iw_pbj_main>()), 4, Mobilize.Web.ArrangeOpen.Original);
               return null;
            }

            public override void Create()
            {
               base.Create();
               this.Text = "DataWindow Crud";
               this.ToolbarItemName = "arrangeicons!";
               this.ToolbarItemText = "DataWindow Crud";
               this.TextSize = 8;
               this.Weight = 400;
               this.FaceName = "Tahoma";
            }

            public override void DoWmInit()
            {
               base.DoWmInit();
               this.clicked = new Mobilize.Web.MenuClickedEventHandler(Clicked);
            }

         }

         public partial class m_datamanagereventonsinglerow_type
            : Mobilize.Web.Menu, Im_main_menuInner.Im_features_typeInner.Im_datamanagereventonsinglerow_type
         {

            public m_datamanagereventonsinglerow_type(Mobilize.Web.BaseControl parent)
            : base(parent)
            {
            }

            private new m_main_menu.m_features_type Parent => (m_main_menu.m_features_type)base.Parent;

            public virtual int? Clicked()
            {
               Mobilize.Web.BuiltInExtensions.Open(Mobilize.Web.ReferenceExtensions.Ref<Mobilize.Web.IWindow>((Mobilize.Web.IWindow)Mobilize.Web.Application.CurrentApplication.Variables.w_dw_control_sampler_events<multicontroldemo.Iw_dw_control_sampler_events>(), (v) => Mobilize.Web.Application.CurrentApplication.Variables.w_dw_control_sampler_events = (multicontroldemo.Iw_dw_control_sampler_events)v, () => Mobilize.Web.Application.CurrentApplication.Variables.w_dw_control_sampler_events<multicontroldemo.Iw_dw_control_sampler_events>()));
               return null;
            }

            public override void Create()
            {
               base.Create();
               this.Text = "DataManager event on single row";
               this.TextSize = 8;
               this.Weight = 400;
               this.FaceName = "Tahoma";
            }

            public override void DoWmInit()
            {
               base.DoWmInit();
               this.clicked = new Mobilize.Web.MenuClickedEventHandler(Clicked);
            }

         }

         public partial class m_alldatamanagercontrolinteractions_type
            : Mobilize.Web.Menu, Im_main_menuInner.Im_features_typeInner.Im_alldatamanagercontrolinteractions_type
         {

            public m_alldatamanagercontrolinteractions_type(Mobilize.Web.BaseControl parent)
            : base(parent)
            {
            }

            private new m_main_menu.m_features_type Parent => (m_main_menu.m_features_type)base.Parent;

            public virtual int? Clicked()
            {
               Mobilize.Web.BuiltInExtensions.Open(Mobilize.Web.ReferenceExtensions.Ref<Mobilize.Web.IWindow>((Mobilize.Web.IWindow)Mobilize.Web.Application.CurrentApplication.Variables.w_allinformation<multicontroldemo.Iw_allinformation>(), (v) => Mobilize.Web.Application.CurrentApplication.Variables.w_allinformation = (multicontroldemo.Iw_allinformation)v, () => Mobilize.Web.Application.CurrentApplication.Variables.w_allinformation<multicontroldemo.Iw_allinformation>()));
               return null;
            }

            public override void Create()
            {
               base.Create();
               this.Text = "All DataManager control interactions";
               this.TextSize = 8;
               this.Weight = 400;
               this.FaceName = "Tahoma";
            }

            public override void DoWmInit()
            {
               base.DoWmInit();
               this.clicked = new Mobilize.Web.MenuClickedEventHandler(Clicked);
            }

         }

         public partial class m_1_type
            : Mobilize.Web.Menu, Im_main_menuInner.Im_features_typeInner.Im_1_type
         {

            public m_1_type(Mobilize.Web.BaseControl parent)
            : base(parent)
            {
            }

            private new m_main_menu.m_features_type Parent => (m_main_menu.m_features_type)base.Parent;

            public virtual int? Clicked()
            {
               Mobilize.Web.BuiltInExtensions.OpenSheetWithParm(Mobilize.Web.ReferenceExtensions.Ref<Mobilize.Web.IWindow>((Mobilize.Web.IWindow)Mobilize.Web.Application.CurrentApplication.Variables.w_employee_maint_updates<multicontroldemo.Iw_employee_maint_updates>(), (v) => Mobilize.Web.Application.CurrentApplication.Variables.w_employee_maint_updates = (multicontroldemo.Iw_employee_maint_updates)v, () => Mobilize.Web.Application.CurrentApplication.Variables.w_employee_maint_updates<multicontroldemo.Iw_employee_maint_updates>()), "free", (pbj_webmapdemo.Iw_pbj_main)(Mobilize.Web.Application.CurrentApplication.Variables.w_pbj_main<pbj_webmapdemo.Iw_pbj_main>()), 10, Mobilize.Web.ArrangeOpen.Layered);
               return null;
            }

            public override void Create()
            {
               base.Create();
               this.Text = "DataManager dirty handling - free";
               this.TextSize = 8;
               this.Weight = 400;
               this.FaceName = "Tahoma";
            }

            public override void DoWmInit()
            {
               base.DoWmInit();
               this.clicked = new Mobilize.Web.MenuClickedEventHandler(Clicked);
            }

         }

         public partial class m_2_type
            : Mobilize.Web.Menu, Im_main_menuInner.Im_features_typeInner.Im_2_type
         {

            public m_2_type(Mobilize.Web.BaseControl parent)
            : base(parent)
            {
            }

            private new m_main_menu.m_features_type Parent => (m_main_menu.m_features_type)base.Parent;

            public virtual int? Clicked()
            {
               Mobilize.Web.BuiltInExtensions.OpenSheetWithParm(Mobilize.Web.ReferenceExtensions.Ref<Mobilize.Web.IWindow>((Mobilize.Web.IWindow)Mobilize.Web.Application.CurrentApplication.Variables.w_employee_maint_updates<multicontroldemo.Iw_employee_maint_updates>(), (v) => Mobilize.Web.Application.CurrentApplication.Variables.w_employee_maint_updates = (multicontroldemo.Iw_employee_maint_updates)v, () => Mobilize.Web.Application.CurrentApplication.Variables.w_employee_maint_updates<multicontroldemo.Iw_employee_maint_updates>()), "grid", (pbj_webmapdemo.Iw_pbj_main)(Mobilize.Web.Application.CurrentApplication.Variables.w_pbj_main<pbj_webmapdemo.Iw_pbj_main>()), 10, Mobilize.Web.ArrangeOpen.Layered);
               return null;
            }

            public override void Create()
            {
               base.Create();
               this.Text = "DataManager dirty handling - grid";
               this.TextSize = 8;
               this.Weight = 400;
               this.FaceName = "Tahoma";
            }

            public override void DoWmInit()
            {
               base.DoWmInit();
               this.clicked = new Mobilize.Web.MenuClickedEventHandler(Clicked);
            }

         }

         public partial class m_3_type
            : Mobilize.Web.Menu, Im_main_menuInner.Im_features_typeInner.Im_3_type
         {

            public m_3_type(Mobilize.Web.BaseControl parent)
            : base(parent)
            {
            }

            private new m_main_menu.m_features_type Parent => (m_main_menu.m_features_type)base.Parent;

            public virtual int? Clicked()
            {
               Mobilize.Web.BuiltInExtensions.OpenSheetWithParm(Mobilize.Web.ReferenceExtensions.Ref<Mobilize.Web.IWindow>((Mobilize.Web.IWindow)Mobilize.Web.Application.CurrentApplication.Variables.w_employee_maint_updates<multicontroldemo.Iw_employee_maint_updates>(), (v) => Mobilize.Web.Application.CurrentApplication.Variables.w_employee_maint_updates = (multicontroldemo.Iw_employee_maint_updates)v, () => Mobilize.Web.Application.CurrentApplication.Variables.w_employee_maint_updates<multicontroldemo.Iw_employee_maint_updates>()), "dynfree", (pbj_webmapdemo.Iw_pbj_main)(Mobilize.Web.Application.CurrentApplication.Variables.w_pbj_main<pbj_webmapdemo.Iw_pbj_main>()), 10, Mobilize.Web.ArrangeOpen.Layered);
               return null;
            }

            public override void Create()
            {
               base.Create();
               this.Text = "DataManager dirty handling - free dynamic";
               this.TextSize = 8;
               this.Weight = 400;
               this.FaceName = "Tahoma";
            }

            public override void DoWmInit()
            {
               base.DoWmInit();
               this.clicked = new Mobilize.Web.MenuClickedEventHandler(Clicked);
            }

         }

         public partial class m_4_type
            : Mobilize.Web.Menu, Im_main_menuInner.Im_features_typeInner.Im_4_type
         {

            public m_4_type(Mobilize.Web.BaseControl parent)
            : base(parent)
            {
            }

            private new m_main_menu.m_features_type Parent => (m_main_menu.m_features_type)base.Parent;

            public virtual int? Clicked()
            {
               Mobilize.Web.BuiltInExtensions.OpenSheetWithParm(Mobilize.Web.ReferenceExtensions.Ref<Mobilize.Web.IWindow>((Mobilize.Web.IWindow)Mobilize.Web.Application.CurrentApplication.Variables.w_employee_maint_updates<multicontroldemo.Iw_employee_maint_updates>(), (v) => Mobilize.Web.Application.CurrentApplication.Variables.w_employee_maint_updates = (multicontroldemo.Iw_employee_maint_updates)v, () => Mobilize.Web.Application.CurrentApplication.Variables.w_employee_maint_updates<multicontroldemo.Iw_employee_maint_updates>()), "dyngrid", (pbj_webmapdemo.Iw_pbj_main)(Mobilize.Web.Application.CurrentApplication.Variables.w_pbj_main<pbj_webmapdemo.Iw_pbj_main>()), 10, Mobilize.Web.ArrangeOpen.Layered);
               return null;
            }

            public override void Create()
            {
               base.Create();
               this.Text = "DataManager dirty handling - grid dynamic";
               this.TextSize = 8;
               this.Weight = 400;
               this.FaceName = "Tahoma";
            }

            public override void DoWmInit()
            {
               base.DoWmInit();
               this.clicked = new Mobilize.Web.MenuClickedEventHandler(Clicked);
            }

         }

         public partial class m_datamanagerstate_nodata_type
            : Mobilize.Web.Menu, Im_main_menuInner.Im_features_typeInner.Im_datamanagerstate_nodata_type
         {

            public m_datamanagerstate_nodata_type(Mobilize.Web.BaseControl parent)
            : base(parent)
            {
            }

            private new m_main_menu.m_features_type Parent => (m_main_menu.m_features_type)base.Parent;

            public virtual int? Clicked()
            {
               Mobilize.Web.BuiltInExtensions.Open(Mobilize.Web.ReferenceExtensions.Ref<Mobilize.Web.IWindow>((Mobilize.Web.IWindow)Mobilize.Web.Application.CurrentApplication.Variables.w_datawindow_states<multicontroldemo.Iw_datawindow_states>(), (v) => Mobilize.Web.Application.CurrentApplication.Variables.w_datawindow_states = (multicontroldemo.Iw_datawindow_states)v, () => Mobilize.Web.Application.CurrentApplication.Variables.w_datawindow_states<multicontroldemo.Iw_datawindow_states>()));
               return null;
            }

            public override void Create()
            {
               base.Create();
               this.Text = "DataManager States";
               this.TextSize = 8;
               this.Weight = 400;
               this.FaceName = "Tahoma";
            }

            public override void DoWmInit()
            {
               base.DoWmInit();
               this.clicked = new Mobilize.Web.MenuClickedEventHandler(Clicked);
            }

         }

         public partial class m_datamanagerw_window_type
            : Mobilize.Web.Menu, Im_main_menuInner.Im_features_typeInner.Im_datamanagerw_window_type
         {

            public m_datamanagerw_window_type(Mobilize.Web.BaseControl parent)
            : base(parent)
            {
            }

            private new m_main_menu.m_features_type Parent => (m_main_menu.m_features_type)base.Parent;

            public virtual int? Clicked()
            {
               Mobilize.Web.BuiltInExtensions.Open(Mobilize.Web.ReferenceExtensions.Ref<Mobilize.Web.IWindow>((Mobilize.Web.IWindow)Mobilize.Web.Application.CurrentApplication.Variables.w_window<notifycurrentcontrol.Iw_window>(), (v) => Mobilize.Web.Application.CurrentApplication.Variables.w_window = (notifycurrentcontrol.Iw_window)v, () => Mobilize.Web.Application.CurrentApplication.Variables.w_window<notifycurrentcontrol.Iw_window>()));
               return null;
            }

            public override void Create()
            {
               base.Create();
               this.Text = "DataManager w_window";
               this.TextSize = 8;
               this.Weight = 400;
               this.FaceName = "Tahoma";
            }

            public override void DoWmInit()
            {
               base.DoWmInit();
               this.clicked = new Mobilize.Web.MenuClickedEventHandler(Clicked);
            }

         }

         public partial class m_datamanagerw_shared_type
            : Mobilize.Web.Menu, Im_main_menuInner.Im_features_typeInner.Im_datamanagerw_shared_type
         {

            public m_datamanagerw_shared_type(Mobilize.Web.BaseControl parent)
            : base(parent)
            {
            }

            private new m_main_menu.m_features_type Parent => (m_main_menu.m_features_type)base.Parent;

            public virtual int? Clicked()
            {
               Mobilize.Web.BuiltInExtensions.Open(Mobilize.Web.ReferenceExtensions.Ref<Mobilize.Web.IWindow>((Mobilize.Web.IWindow)Mobilize.Web.Application.CurrentApplication.Variables.w_shareddatawindow<notifycurrentcontrol.Iw_shareddatawindow>(), (v) => Mobilize.Web.Application.CurrentApplication.Variables.w_shareddatawindow = (notifycurrentcontrol.Iw_shareddatawindow)v, () => Mobilize.Web.Application.CurrentApplication.Variables.w_shareddatawindow<notifycurrentcontrol.Iw_shareddatawindow>()));
               return null;
            }

            public override void Create()
            {
               base.Create();
               this.Text = "DataManager w_sharedatawindow";
               this.TextSize = 8;
               this.Weight = 400;
               this.FaceName = "Tahoma";
            }

            public override void DoWmInit()
            {
               base.DoWmInit();
               this.clicked = new Mobilize.Web.MenuClickedEventHandler(Clicked);
            }

         }

         public partial class m_datamanagerw_dropdown_type
            : Mobilize.Web.Menu, Im_main_menuInner.Im_features_typeInner.Im_datamanagerw_dropdown_type
         {

            public m_datamanagerw_dropdown_type(Mobilize.Web.BaseControl parent)
            : base(parent)
            {
            }

            private new m_main_menu.m_features_type Parent => (m_main_menu.m_features_type)base.Parent;

            public virtual int? Clicked()
            {
               Mobilize.Web.BuiltInExtensions.Open(Mobilize.Web.ReferenceExtensions.Ref<Mobilize.Web.IWindow>((Mobilize.Web.IWindow)Mobilize.Web.Application.CurrentApplication.Variables.w_dropdown<notifycurrentcontrol.Iw_dropdown>(), (v) => Mobilize.Web.Application.CurrentApplication.Variables.w_dropdown = (notifycurrentcontrol.Iw_dropdown)v, () => Mobilize.Web.Application.CurrentApplication.Variables.w_dropdown<notifycurrentcontrol.Iw_dropdown>()));
               return null;
            }

            public override void Create()
            {
               base.Create();
               this.Text = "DataManager w_dropdown";
               this.TextSize = 8;
               this.Weight = 400;
               this.FaceName = "Tahoma";
            }

            public override void DoWmInit()
            {
               base.DoWmInit();
               this.clicked = new Mobilize.Web.MenuClickedEventHandler(Clicked);
            }

         }

         public partial class m_datamanagerw_expression_type
            : Mobilize.Web.Menu, Im_main_menuInner.Im_features_typeInner.Im_datamanagerw_expression_type
         {

            public m_datamanagerw_expression_type(Mobilize.Web.BaseControl parent)
            : base(parent)
            {
            }

            private new m_main_menu.m_features_type Parent => (m_main_menu.m_features_type)base.Parent;

            public virtual int? Clicked()
            {
               Mobilize.Web.BuiltInExtensions.Open(Mobilize.Web.ReferenceExtensions.Ref<Mobilize.Web.IWindow>((Mobilize.Web.IWindow)Mobilize.Web.Application.CurrentApplication.Variables.w_expressions<notifycurrentcontrol.Iw_expressions>(), (v) => Mobilize.Web.Application.CurrentApplication.Variables.w_expressions = (notifycurrentcontrol.Iw_expressions)v, () => Mobilize.Web.Application.CurrentApplication.Variables.w_expressions<notifycurrentcontrol.Iw_expressions>()));
               return null;
            }

            public override void Create()
            {
               base.Create();
               this.Text = "DataManager w_expresions";
               this.TextSize = 8;
               this.Weight = 400;
               this.FaceName = "Tahoma";
            }

            public override void DoWmInit()
            {
               base.DoWmInit();
               this.clicked = new Mobilize.Web.MenuClickedEventHandler(Clicked);
            }

         }

      }

      public partial class m_medicalcenter_type
         : Mobilize.Web.Menu, Im_main_menuInner.Im_medicalcenter_type
      {

         public m_medicalcenter_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new m_main_menu Parent => (m_main_menu)base.Parent;

         public virtual int? Clicked()
         {
            Mobilize.Web.BuiltInExtensions.Open(Mobilize.Web.ReferenceExtensions.Ref<Mobilize.Web.IWindow>((Mobilize.Web.IWindow)Mobilize.Web.Application.CurrentApplication.Variables.w_login<medicationcenter.Iw_login>(), (v) => Mobilize.Web.Application.CurrentApplication.Variables.w_login = (medicationcenter.Iw_login)v, () => Mobilize.Web.Application.CurrentApplication.Variables.w_login<medicationcenter.Iw_login>()));
            return null;
         }

         public override void Create()
         {
            base.Create();
            this.Text = "&MedicalCenter";
            this.TextSize = 8;
            this.Weight = 400;
            this.FaceName = "Tahoma";
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.clicked = new Mobilize.Web.MenuClickedEventHandler(Clicked);
         }

      }

      public partial class m_reports_type
         : Mobilize.Web.Menu, Im_main_menuInner.Im_reports_type
      {

         public m_reports_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new m_main_menu Parent => (m_main_menu)base.Parent;

         public virtual int? Clicked()
         {
            Mobilize.Web.BuiltInExtensions.Open(Mobilize.Web.ReferenceExtensions.Ref<Mobilize.Web.IWindow>((Mobilize.Web.IWindow)Mobilize.Web.Application.CurrentApplication.Variables.w_main_report<reports.Iw_main_report>(), (v) => Mobilize.Web.Application.CurrentApplication.Variables.w_main_report = (reports.Iw_main_report)v, () => Mobilize.Web.Application.CurrentApplication.Variables.w_main_report<reports.Iw_main_report>()));
            return null;
         }

         public override void Create()
         {
            base.Create();
            this.Text = "&Reports";
            this.TextSize = 8;
            this.Weight = 400;
            this.FaceName = "Tahoma";
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.clicked = new Mobilize.Web.MenuClickedEventHandler(Clicked);
         }

      }

   }

}