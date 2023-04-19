#pragma warning disable
#line 1 "m_basemdi\\m_basemdi.cs"
#pragma warning disable
#line 1 "m_basemdi\\m_basemdi.cs"
namespace medicationcenter
{

   [Mobilize.WebMap.Common.Attributes.Observable]
   public partial class m_basemdi
      : Mobilize.Web.Menu, medicationcenter.Im_basemdi
   {

      public override void Create()
      {
         Mobilize.Web.Application.CurrentApplication.Variables.m_basemdi = (Mobilize.Web.IMenu)(this);
         base.Create();
         this.TextSize = 8;
         this.Weight = 400;
         this.FaceName = "Tahoma";
         this.m_prescriptions = CreateInnerControl_m_prescriptions_type();
         this.m_edit = CreateInnerControl_m_edit_type();
         this.Item[this.Item.GetUpperBound() + 1] = this.m_prescriptions;
         this.Item[this.Item.GetUpperBound() + 1] = this.m_edit;
      }

      public override void Destroy()
      {
         base.Destroy();
         this.m_prescriptions = null;
         this.m_edit = null;
      }

      protected virtual Im_basemdiInner.Im_prescriptions_type CreateInnerControl_m_prescriptions_type()
      {
         return Mobilize.Web.Application.Create<Im_basemdiInner.Im_prescriptions_type>(this);
      }

      protected virtual Im_basemdiInner.Im_edit_type CreateInnerControl_m_edit_type()
      {
         return Mobilize.Web.Application.Create<Im_basemdiInner.Im_edit_type>(this);
      }

      public partial class m_prescriptions_type
         : Mobilize.Web.Menu, Im_basemdiInner.Im_prescriptions_type
      {

         public m_prescriptions_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new m_basemdi Parent => (m_basemdi)base.Parent;

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private medicationcenter.Im_basemdiInner.Im_prescriptions_typeInner.Im_addprescription_type m_addprescription_k__BackingField;
#line 51


         [Mobilize.WebMap.Common.Attributes.Intercepted]
         public Im_basemdiInner.Im_prescriptions_typeInner.Im_addprescription_type m_addprescription 
#line 51
                                                                                                     { 
#line 51
                                                                                                       get                                                                                                          
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_m_addprescription)<=0){this.m_addprescription_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetNonObservable<medicationcenter.Im_basemdiInner.Im_prescriptions_typeInner.Im_addprescription_type>(this,_Mobilize_References,0);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_m_addprescription;}return this.m_addprescription_k__BackingField;} 
#line 51

#line 51
                                                                                                            set                                                                                                               
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetNonObservable<Im_basemdiInner.Im_prescriptions_typeInner.Im_addprescription_type >(this,_Mobilize_References,0,this.m_addprescription_k__BackingField,(medicationcenter.Im_basemdiInner.Im_prescriptions_typeInner.Im_addprescription_type)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_m_addprescription;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_m_addprescription;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.m_addprescription_k__BackingField=(medicationcenter.Im_basemdiInner.Im_prescriptions_typeInner.Im_addprescription_type)value;} 
#line 51
                                                                                                                 }

#line 52

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private medicationcenter.Im_basemdiInner.Im_prescriptions_typeInner.Im_showall_type m_showall_k__BackingField;
#line 54


         [Mobilize.WebMap.Common.Attributes.Intercepted]
         public Im_basemdiInner.Im_prescriptions_typeInner.Im_showall_type m_showall 
#line 54
                                                                                     { 
#line 54
                                                                                       get                                                                                          
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_m_showall)<=0){this.m_showall_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetNonObservable<medicationcenter.Im_basemdiInner.Im_prescriptions_typeInner.Im_showall_type>(this,_Mobilize_References,1);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_m_showall;}return this.m_showall_k__BackingField;} 
#line 54

#line 54
                                                                                            set                                                                                               
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetNonObservable<Im_basemdiInner.Im_prescriptions_typeInner.Im_showall_type >(this,_Mobilize_References,1,this.m_showall_k__BackingField,(medicationcenter.Im_basemdiInner.Im_prescriptions_typeInner.Im_showall_type)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_m_showall;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_m_showall;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.m_showall_k__BackingField=(medicationcenter.Im_basemdiInner.Im_prescriptions_typeInner.Im_showall_type)value;} 
#line 54
                                                                                                 }

#line 55

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private medicationcenter.Im_basemdiInner.Im_prescriptions_typeInner.Im_search_type m_search_k__BackingField;
#line 57


         [Mobilize.WebMap.Common.Attributes.Intercepted]
         public Im_basemdiInner.Im_prescriptions_typeInner.Im_search_type m_search 
#line 57
                                                                                   { 
#line 57
                                                                                     get                                                                                        
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_m_search)<=0){this.m_search_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetNonObservable<medicationcenter.Im_basemdiInner.Im_prescriptions_typeInner.Im_search_type>(this,_Mobilize_References,2);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_m_search;}return this.m_search_k__BackingField;} 
#line 57

#line 57
                                                                                          set                                                                                             
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetNonObservable<Im_basemdiInner.Im_prescriptions_typeInner.Im_search_type >(this,_Mobilize_References,2,this.m_search_k__BackingField,(medicationcenter.Im_basemdiInner.Im_prescriptions_typeInner.Im_search_type)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_m_search;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_m_search;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.m_search_k__BackingField=(medicationcenter.Im_basemdiInner.Im_prescriptions_typeInner.Im_search_type)value;} 
#line 57
                                                                                               }

#line 58

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private medicationcenter.Im_basemdiInner.Im_prescriptions_typeInner.Im_removeprescription_type m_removeprescription_k__BackingField;
#line 60


         [Mobilize.WebMap.Common.Attributes.Intercepted]
         public Im_basemdiInner.Im_prescriptions_typeInner.Im_removeprescription_type m_removeprescription 
#line 60
                                                                                                           { 
#line 60
                                                                                                             get                                                                                                                
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_m_removeprescription)<=0){this.m_removeprescription_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetNonObservable<medicationcenter.Im_basemdiInner.Im_prescriptions_typeInner.Im_removeprescription_type>(this,_Mobilize_References,3);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_m_removeprescription;}return this.m_removeprescription_k__BackingField;} 
#line 60

#line 60
                                                                                                                  set                                                                                                                     
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetNonObservable<Im_basemdiInner.Im_prescriptions_typeInner.Im_removeprescription_type >(this,_Mobilize_References,3,this.m_removeprescription_k__BackingField,(medicationcenter.Im_basemdiInner.Im_prescriptions_typeInner.Im_removeprescription_type)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_m_removeprescription;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_m_removeprescription;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.m_removeprescription_k__BackingField=(medicationcenter.Im_basemdiInner.Im_prescriptions_typeInner.Im_removeprescription_type)value;} 
#line 60
                                                                                                                       }

#line 61

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private medicationcenter.Im_basemdiInner.Im_prescriptions_typeInner.Im_dwcontrolsampler_type m_dwcontrolsampler_k__BackingField;
#line 63


         [Mobilize.WebMap.Common.Attributes.Intercepted]
         public Im_basemdiInner.Im_prescriptions_typeInner.Im_dwcontrolsampler_type m_dwcontrolsampler 
#line 63
                                                                                                       { 
#line 63
                                                                                                         get                                                                                                            
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_m_dwcontrolsampler)<=0){this.m_dwcontrolsampler_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetNonObservable<medicationcenter.Im_basemdiInner.Im_prescriptions_typeInner.Im_dwcontrolsampler_type>(this,_Mobilize_References,4);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_m_dwcontrolsampler;}return this.m_dwcontrolsampler_k__BackingField;} 
#line 63

#line 63
                                                                                                              set                                                                                                                 
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetNonObservable<Im_basemdiInner.Im_prescriptions_typeInner.Im_dwcontrolsampler_type >(this,_Mobilize_References,4,this.m_dwcontrolsampler_k__BackingField,(medicationcenter.Im_basemdiInner.Im_prescriptions_typeInner.Im_dwcontrolsampler_type)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_m_dwcontrolsampler;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_m_dwcontrolsampler;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.m_dwcontrolsampler_k__BackingField=(medicationcenter.Im_basemdiInner.Im_prescriptions_typeInner.Im_dwcontrolsampler_type)value;} 
#line 63
                                                                                                                   }

#line 64

         public override void Create()
         {
            base.Create();
            this.Text = "Prescriptions";
            this.TextSize = 8;
            this.Weight = 400;
            this.FaceName = "Tahoma";
            this.m_addprescription = CreateInnerControl_m_addprescription_type();
            this.m_showall = CreateInnerControl_m_showall_type();
            this.m_search = CreateInnerControl_m_search_type();
            this.m_removeprescription = CreateInnerControl_m_removeprescription_type();
            this.m_dwcontrolsampler = CreateInnerControl_m_dwcontrolsampler_type();
            this.Item[this.Item.GetUpperBound() + 1] = this.m_addprescription;
            this.Item[this.Item.GetUpperBound() + 1] = this.m_showall;
            this.Item[this.Item.GetUpperBound() + 1] = this.m_search;
            this.Item[this.Item.GetUpperBound() + 1] = this.m_removeprescription;
            this.Item[this.Item.GetUpperBound() + 1] = this.m_dwcontrolsampler;
         }

         protected virtual Im_basemdiInner.Im_prescriptions_typeInner.Im_addprescription_type CreateInnerControl_m_addprescription_type()
         {
            return Mobilize.Web.Application.Create<Im_basemdiInner.Im_prescriptions_typeInner.Im_addprescription_type>(this);
         }

         protected virtual Im_basemdiInner.Im_prescriptions_typeInner.Im_showall_type CreateInnerControl_m_showall_type()
         {
            return Mobilize.Web.Application.Create<Im_basemdiInner.Im_prescriptions_typeInner.Im_showall_type>(this);
         }

         protected virtual Im_basemdiInner.Im_prescriptions_typeInner.Im_search_type CreateInnerControl_m_search_type()
         {
            return Mobilize.Web.Application.Create<Im_basemdiInner.Im_prescriptions_typeInner.Im_search_type>(this);
         }

         protected virtual Im_basemdiInner.Im_prescriptions_typeInner.Im_removeprescription_type CreateInnerControl_m_removeprescription_type()
         {
            return Mobilize.Web.Application.Create<Im_basemdiInner.Im_prescriptions_typeInner.Im_removeprescription_type>(this);
         }

         protected virtual Im_basemdiInner.Im_prescriptions_typeInner.Im_dwcontrolsampler_type CreateInnerControl_m_dwcontrolsampler_type()
         {
            return Mobilize.Web.Application.Create<Im_basemdiInner.Im_prescriptions_typeInner.Im_dwcontrolsampler_type>(this);
         }

         public partial class m_addprescription_type
            : Mobilize.Web.Menu, Im_basemdiInner.Im_prescriptions_typeInner.Im_addprescription_type
         {

            public m_addprescription_type(Mobilize.Web.BaseControl parent)
            : base(parent)
            {
            }

            private new m_basemdi.m_prescriptions_type Parent => (m_basemdi.m_prescriptions_type)base.Parent;

            public override void Create()
            {
               base.Create();
               this.Visible = false;
               this.Text = "Add Prescription";
               this.ToolbarItemVisible = false;
               this.ToolbarItemName = "medicalcenter\\img\\addprescription.jpg";
               this.ToolbarItemText = "Add, Add Prescription";
               this.TextSize = 8;
               this.Weight = 400;
               this.FaceName = "Tahoma";
            }

         }

         public partial class m_showall_type
            : Mobilize.Web.Menu, Im_basemdiInner.Im_prescriptions_typeInner.Im_showall_type
         {

            public m_showall_type(Mobilize.Web.BaseControl parent)
            : base(parent)
            {
            }

            private new m_basemdi.m_prescriptions_type Parent => (m_basemdi.m_prescriptions_type)base.Parent;

            public virtual int? Clicked()
            {
               Mobilize.Web.BuiltInExtensions.OpenSheet(Mobilize.Web.ReferenceExtensions.Ref<Mobilize.Web.IWindow>((Mobilize.Web.IWindow)Mobilize.Web.Application.CurrentApplication.Variables.w_basewindow<basecomponents.Iw_basewindow>(), (v) => Mobilize.Web.Application.CurrentApplication.Variables.w_basewindow = (basecomponents.Iw_basewindow)v, () => Mobilize.Web.Application.CurrentApplication.Variables.w_basewindow<basecomponents.Iw_basewindow>()), (medicationcenter.Iw_mdi)(Mobilize.Web.Application.CurrentApplication.Variables.w_mdi<medicationcenter.Iw_mdi>()), 10, Mobilize.Web.ArrangeOpen.Layered);
               return null;
            //w_basewindow.openuserobject(ou_showallprescriptions)
            //ou_showallprescriptions.resize( w_basewindow.Workspacewidth(), w_basewindow.Workspaceheight())
            //ou_showallprescriptions.dw_all.resize( w_basewindow.Workspacewidth(), w_basewindow.Workspaceheight() - 50)
            }

            public override void Create()
            {
               base.Create();
               this.Text = "Show All";
               this.ToolbarItemName = "medicalcenter\\img\\showall.jpg";
               this.ToolbarItemText = "Show All, Prescriptions";
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

         public partial class m_search_type
            : Mobilize.Web.Menu, Im_basemdiInner.Im_prescriptions_typeInner.Im_search_type
         {

            public m_search_type(Mobilize.Web.BaseControl parent)
            : base(parent)
            {
            }

            private new m_basemdi.m_prescriptions_type Parent => (m_basemdi.m_prescriptions_type)base.Parent;

            public virtual int? Clicked()
            {
               ((Mobilize.Web.IMessage)(Mobilize.Web.Application.CurrentApplication.Variables.Message<Mobilize.Web.IMessage>())).DoubleParm = 3;
               Mobilize.Web.BuiltInExtensions.OpenSheet(Mobilize.Web.ReferenceExtensions.Ref<Mobilize.Web.IWindow>((Mobilize.Web.IWindow)Mobilize.Web.Application.CurrentApplication.Variables.w_prescriptionmant<medicationcenter.Iw_prescriptionmant>(), (v) => Mobilize.Web.Application.CurrentApplication.Variables.w_prescriptionmant = (medicationcenter.Iw_prescriptionmant)v, () => Mobilize.Web.Application.CurrentApplication.Variables.w_prescriptionmant<medicationcenter.Iw_prescriptionmant>()), (medicationcenter.Iw_mdi)(Mobilize.Web.Application.CurrentApplication.Variables.w_mdi<medicationcenter.Iw_mdi>()), 10, Mobilize.Web.ArrangeOpen.Layered);
               return null;
            }

            public override void Create()
            {
               base.Create();
               this.Text = "Search";
               this.ToolbarItemName = "medicalcenter\\img\\search.jpg";
               this.ToolbarItemText = "Search";
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

         public partial class m_removeprescription_type
            : Mobilize.Web.Menu, Im_basemdiInner.Im_prescriptions_typeInner.Im_removeprescription_type
         {

            public m_removeprescription_type(Mobilize.Web.BaseControl parent)
            : base(parent)
            {
            }

            private new m_basemdi.m_prescriptions_type Parent => (m_basemdi.m_prescriptions_type)base.Parent;

            public override void Create()
            {
               base.Create();
               this.Visible = false;
               this.Text = "Remove Prescription";
               this.ToolbarItemVisible = false;
               this.ToolbarItemName = "medicalcenter\\img\\remove.jpg";
               this.ToolbarItemText = "Remove";
               this.TextSize = 8;
               this.Weight = 400;
               this.FaceName = "Tahoma";
            }

         }

         public partial class m_dwcontrolsampler_type
            : Mobilize.Web.Menu, Im_basemdiInner.Im_prescriptions_typeInner.Im_dwcontrolsampler_type
         {

            public m_dwcontrolsampler_type(Mobilize.Web.BaseControl parent)
            : base(parent)
            {
            }

            private new m_basemdi.m_prescriptions_type Parent => (m_basemdi.m_prescriptions_type)base.Parent;

            public virtual int? Clicked()
            {
               Mobilize.Web.BuiltInExtensions.OpenSheet(Mobilize.Web.ReferenceExtensions.Ref<Mobilize.Web.IWindow>((Mobilize.Web.IWindow)Mobilize.Web.Application.CurrentApplication.Variables.w_dw_control_sampler_events<multicontroldemo.Iw_dw_control_sampler_events>(), (v) => Mobilize.Web.Application.CurrentApplication.Variables.w_dw_control_sampler_events = (multicontroldemo.Iw_dw_control_sampler_events)v, () => Mobilize.Web.Application.CurrentApplication.Variables.w_dw_control_sampler_events<multicontroldemo.Iw_dw_control_sampler_events>()), (medicationcenter.Iw_mdi)(Mobilize.Web.Application.CurrentApplication.Variables.w_mdi<medicationcenter.Iw_mdi>()), 10, Mobilize.Web.ArrangeOpen.Layered);
               return null;
            }

            public override void Create()
            {
               base.Create();
               this.Text = "DW Control Sampler";
               this.ToolbarItemName = "medicalcenter\\img\\showall.jpg";
               this.ToolbarItemText = "DW Control Sampler";
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

      public partial class m_edit_type
         : Mobilize.Web.Menu, Im_basemdiInner.Im_edit_type
      {

         public m_edit_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new m_basemdi Parent => (m_basemdi)base.Parent;

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private medicationcenter.Im_basemdiInner.Im_edit_typeInner.Im_save_type m_save_k__BackingField;
#line 287


         [Mobilize.WebMap.Common.Attributes.Intercepted]
         public Im_basemdiInner.Im_edit_typeInner.Im_save_type m_save 
#line 287
                                                                      { 
#line 287
                                                                        get                                                                           
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_m_save)<=0){this.m_save_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetNonObservable<medicationcenter.Im_basemdiInner.Im_edit_typeInner.Im_save_type>(this,_Mobilize_References,0);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_m_save;}return this.m_save_k__BackingField;} 
#line 287

#line 287
                                                                             set                                                                                
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetNonObservable<Im_basemdiInner.Im_edit_typeInner.Im_save_type >(this,_Mobilize_References,0,this.m_save_k__BackingField,(medicationcenter.Im_basemdiInner.Im_edit_typeInner.Im_save_type)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_m_save;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_m_save;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.m_save_k__BackingField=(medicationcenter.Im_basemdiInner.Im_edit_typeInner.Im_save_type)value;} 
#line 287
                                                                                  }

#line 288

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private medicationcenter.Im_basemdiInner.Im_edit_typeInner.Im_close_type m_close_k__BackingField;
#line 290


         [Mobilize.WebMap.Common.Attributes.Intercepted]
         public Im_basemdiInner.Im_edit_typeInner.Im_close_type m_close 
#line 290
                                                                        { 
#line 290
                                                                          get                                                                             
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_m_close)<=0){this.m_close_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetNonObservable<medicationcenter.Im_basemdiInner.Im_edit_typeInner.Im_close_type>(this,_Mobilize_References,1);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_m_close;}return this.m_close_k__BackingField;} 
#line 290

#line 290
                                                                               set                                                                                  
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetNonObservable<Im_basemdiInner.Im_edit_typeInner.Im_close_type >(this,_Mobilize_References,1,this.m_close_k__BackingField,(medicationcenter.Im_basemdiInner.Im_edit_typeInner.Im_close_type)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_m_close;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_m_close;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.m_close_k__BackingField=(medicationcenter.Im_basemdiInner.Im_edit_typeInner.Im_close_type)value;} 
#line 290
                                                                                    }

#line 291

         public override void Create()
         {
            base.Create();
            this.Visible = false;
            this.Text = "Edit";
            this.TextSize = 8;
            this.Weight = 400;
            this.FaceName = "Tahoma";
            this.m_save = CreateInnerControl_m_save_type();
            this.m_close = CreateInnerControl_m_close_type();
            this.Item[this.Item.GetUpperBound() + 1] = this.m_save;
            this.Item[this.Item.GetUpperBound() + 1] = this.m_close;
         }

         protected virtual Im_basemdiInner.Im_edit_typeInner.Im_save_type CreateInnerControl_m_save_type()
         {
            return Mobilize.Web.Application.Create<Im_basemdiInner.Im_edit_typeInner.Im_save_type>(this);
         }

         protected virtual Im_basemdiInner.Im_edit_typeInner.Im_close_type CreateInnerControl_m_close_type()
         {
            return Mobilize.Web.Application.Create<Im_basemdiInner.Im_edit_typeInner.Im_close_type>(this);
         }

         public partial class m_save_type
            : Mobilize.Web.Menu, Im_basemdiInner.Im_edit_typeInner.Im_save_type
         {

            public m_save_type(Mobilize.Web.BaseControl parent)
            : base(parent)
            {
            }

            private new m_basemdi.m_edit_type Parent => (m_basemdi.m_edit_type)base.Parent;

            public override void Create()
            {
               base.Create();
               this.Text = "Save";
               this.ToolbarItemVisible = false;
               this.ToolbarItemName = "medicalcenter\\img\\save.jpg";
               this.ToolbarItemText = "Save";
               this.TextSize = 8;
               this.Weight = 400;
               this.FaceName = "Tahoma";
            }

         }

         public partial class m_close_type
            : Mobilize.Web.Menu, Im_basemdiInner.Im_edit_typeInner.Im_close_type
         {

            public m_close_type(Mobilize.Web.BaseControl parent)
            : base(parent)
            {
            }

            private new m_basemdi.m_edit_type Parent => (m_basemdi.m_edit_type)base.Parent;

            public override void Create()
            {
               base.Create();
               this.Text = "Close";
               this.ToolbarItemVisible = false;
               this.ToolbarItemName = "medicalcenter\\img\\cancel.jpg";
               this.ToolbarItemText = "Close";
               this.TextSize = 8;
               this.Weight = 400;
               this.FaceName = "Tahoma";
            }

         }

      }

   }

}
#pragma warning restore
