#pragma warning disable
#line 1 "m_main_menu\\m_main_menu.cs"
#pragma warning disable
#line 1 "m_main_menu\\m_main_menu.cs"
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

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private pbj_webmapdemo.Im_main_menuInner.Im_controls_typeInner.Im_statictext_type m_statictext_k__BackingField;
#line 68


         [Mobilize.WebMap.Common.Attributes.Intercepted]
         public Im_main_menuInner.Im_controls_typeInner.Im_statictext_type m_statictext 
#line 68
                                                                                        { 
#line 68
                                                                                          get                                                                                             
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_m_statictext)<=0){this.m_statictext_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetNonObservable<pbj_webmapdemo.Im_main_menuInner.Im_controls_typeInner.Im_statictext_type>(this,_Mobilize_References,0);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_m_statictext;}return this.m_statictext_k__BackingField;} 
#line 68

#line 68
                                                                                               set                                                                                                  
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetNonObservable<Im_main_menuInner.Im_controls_typeInner.Im_statictext_type >(this,_Mobilize_References,0,this.m_statictext_k__BackingField,(pbj_webmapdemo.Im_main_menuInner.Im_controls_typeInner.Im_statictext_type)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_m_statictext;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_m_statictext;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.m_statictext_k__BackingField=(pbj_webmapdemo.Im_main_menuInner.Im_controls_typeInner.Im_statictext_type)value;} 
#line 68
                                                                                                    }

#line 69

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private pbj_webmapdemo.Im_main_menuInner.Im_controls_typeInner.Im_0_type m_0_k__BackingField;
#line 71


         [Mobilize.WebMap.Common.Attributes.Intercepted]
         public Im_main_menuInner.Im_controls_typeInner.Im_0_type m_0 
#line 71
                                                                      { 
#line 71
                                                                        get                                                                           
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_m_0)<=0){this.m_0_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetNonObservable<pbj_webmapdemo.Im_main_menuInner.Im_controls_typeInner.Im_0_type>(this,_Mobilize_References,1);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_m_0;}return this.m_0_k__BackingField;} 
#line 71

#line 71
                                                                             set                                                                                
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetNonObservable<Im_main_menuInner.Im_controls_typeInner.Im_0_type >(this,_Mobilize_References,1,this.m_0_k__BackingField,(pbj_webmapdemo.Im_main_menuInner.Im_controls_typeInner.Im_0_type)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_m_0;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_m_0;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.m_0_k__BackingField=(pbj_webmapdemo.Im_main_menuInner.Im_controls_typeInner.Im_0_type)value;} 
#line 71
                                                                                  }

#line 72

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private pbj_webmapdemo.Im_main_menuInner.Im_controls_typeInner.Im_commandbutton_type m_commandbutton_k__BackingField;
#line 74


         [Mobilize.WebMap.Common.Attributes.Intercepted]
         public Im_main_menuInner.Im_controls_typeInner.Im_commandbutton_type m_commandbutton 
#line 74
                                                                                              { 
#line 74
                                                                                                get                                                                                                   
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_m_commandbutton)<=0){this.m_commandbutton_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetNonObservable<pbj_webmapdemo.Im_main_menuInner.Im_controls_typeInner.Im_commandbutton_type>(this,_Mobilize_References,2);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_m_commandbutton;}return this.m_commandbutton_k__BackingField;} 
#line 74

#line 74
                                                                                                     set                                                                                                        
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetNonObservable<Im_main_menuInner.Im_controls_typeInner.Im_commandbutton_type >(this,_Mobilize_References,2,this.m_commandbutton_k__BackingField,(pbj_webmapdemo.Im_main_menuInner.Im_controls_typeInner.Im_commandbutton_type)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_m_commandbutton;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_m_commandbutton;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.m_commandbutton_k__BackingField=(pbj_webmapdemo.Im_main_menuInner.Im_controls_typeInner.Im_commandbutton_type)value;} 
#line 74
                                                                                                          }

#line 75

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private pbj_webmapdemo.Im_main_menuInner.Im_controls_typeInner.Im_editmask_type m_editmask_k__BackingField;
#line 77


         [Mobilize.WebMap.Common.Attributes.Intercepted]
         public Im_main_menuInner.Im_controls_typeInner.Im_editmask_type m_editmask 
#line 77
                                                                                    { 
#line 77
                                                                                      get                                                                                         
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_m_editmask)<=0){this.m_editmask_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetNonObservable<pbj_webmapdemo.Im_main_menuInner.Im_controls_typeInner.Im_editmask_type>(this,_Mobilize_References,3);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_m_editmask;}return this.m_editmask_k__BackingField;} 
#line 77

#line 77
                                                                                           set                                                                                              
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetNonObservable<Im_main_menuInner.Im_controls_typeInner.Im_editmask_type >(this,_Mobilize_References,3,this.m_editmask_k__BackingField,(pbj_webmapdemo.Im_main_menuInner.Im_controls_typeInner.Im_editmask_type)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_m_editmask;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_m_editmask;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.m_editmask_k__BackingField=(pbj_webmapdemo.Im_main_menuInner.Im_controls_typeInner.Im_editmask_type)value;} 
#line 77
                                                                                                }

#line 78

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private pbj_webmapdemo.Im_main_menuInner.Im_controls_typeInner.Im_multilineedit_type m_multilineedit_k__BackingField;
#line 80


         [Mobilize.WebMap.Common.Attributes.Intercepted]
         public Im_main_menuInner.Im_controls_typeInner.Im_multilineedit_type m_multilineedit 
#line 80
                                                                                              { 
#line 80
                                                                                                get                                                                                                   
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_m_multilineedit)<=0){this.m_multilineedit_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetNonObservable<pbj_webmapdemo.Im_main_menuInner.Im_controls_typeInner.Im_multilineedit_type>(this,_Mobilize_References,4);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_m_multilineedit;}return this.m_multilineedit_k__BackingField;} 
#line 80

#line 80
                                                                                                     set                                                                                                        
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetNonObservable<Im_main_menuInner.Im_controls_typeInner.Im_multilineedit_type >(this,_Mobilize_References,4,this.m_multilineedit_k__BackingField,(pbj_webmapdemo.Im_main_menuInner.Im_controls_typeInner.Im_multilineedit_type)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_m_multilineedit;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_m_multilineedit;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.m_multilineedit_k__BackingField=(pbj_webmapdemo.Im_main_menuInner.Im_controls_typeInner.Im_multilineedit_type)value;} 
#line 80
                                                                                                          }

#line 81

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private pbj_webmapdemo.Im_main_menuInner.Im_controls_typeInner.Im_radiobutton_type m_radiobutton_k__BackingField;
#line 83


         [Mobilize.WebMap.Common.Attributes.Intercepted]
         public Im_main_menuInner.Im_controls_typeInner.Im_radiobutton_type m_radiobutton 
#line 83
                                                                                          { 
#line 83
                                                                                            get                                                                                               
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_m_radiobutton)<=0){this.m_radiobutton_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetNonObservable<pbj_webmapdemo.Im_main_menuInner.Im_controls_typeInner.Im_radiobutton_type>(this,_Mobilize_References,5);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_m_radiobutton;}return this.m_radiobutton_k__BackingField;} 
#line 83

#line 83
                                                                                                 set                                                                                                    
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetNonObservable<Im_main_menuInner.Im_controls_typeInner.Im_radiobutton_type >(this,_Mobilize_References,5,this.m_radiobutton_k__BackingField,(pbj_webmapdemo.Im_main_menuInner.Im_controls_typeInner.Im_radiobutton_type)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_m_radiobutton;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_m_radiobutton;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.m_radiobutton_k__BackingField=(pbj_webmapdemo.Im_main_menuInner.Im_controls_typeInner.Im_radiobutton_type)value;} 
#line 83
                                                                                                      }

#line 84

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private pbj_webmapdemo.Im_main_menuInner.Im_controls_typeInner.Im_checkbox_type m_checkbox_k__BackingField;
#line 86


         [Mobilize.WebMap.Common.Attributes.Intercepted]
         public Im_main_menuInner.Im_controls_typeInner.Im_checkbox_type m_checkbox 
#line 86
                                                                                    { 
#line 86
                                                                                      get                                                                                         
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_m_checkbox)<=0){this.m_checkbox_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetNonObservable<pbj_webmapdemo.Im_main_menuInner.Im_controls_typeInner.Im_checkbox_type>(this,_Mobilize_References,6);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_m_checkbox;}return this.m_checkbox_k__BackingField;} 
#line 86

#line 86
                                                                                           set                                                                                              
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetNonObservable<Im_main_menuInner.Im_controls_typeInner.Im_checkbox_type >(this,_Mobilize_References,6,this.m_checkbox_k__BackingField,(pbj_webmapdemo.Im_main_menuInner.Im_controls_typeInner.Im_checkbox_type)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_m_checkbox;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_m_checkbox;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.m_checkbox_k__BackingField=(pbj_webmapdemo.Im_main_menuInner.Im_controls_typeInner.Im_checkbox_type)value;} 
#line 86
                                                                                                }

#line 87

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private pbj_webmapdemo.Im_main_menuInner.Im_controls_typeInner.Im_dropdownlistbox_type m_dropdownlistbox_k__BackingField;
#line 89


         [Mobilize.WebMap.Common.Attributes.Intercepted]
         public Im_main_menuInner.Im_controls_typeInner.Im_dropdownlistbox_type m_dropdownlistbox 
#line 89
                                                                                                  { 
#line 89
                                                                                                    get                                                                                                       
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_m_dropdownlistbox)<=0){this.m_dropdownlistbox_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetNonObservable<pbj_webmapdemo.Im_main_menuInner.Im_controls_typeInner.Im_dropdownlistbox_type>(this,_Mobilize_References,7);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_m_dropdownlistbox;}return this.m_dropdownlistbox_k__BackingField;} 
#line 89

#line 89
                                                                                                         set                                                                                                            
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetNonObservable<Im_main_menuInner.Im_controls_typeInner.Im_dropdownlistbox_type >(this,_Mobilize_References,7,this.m_dropdownlistbox_k__BackingField,(pbj_webmapdemo.Im_main_menuInner.Im_controls_typeInner.Im_dropdownlistbox_type)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_m_dropdownlistbox;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_m_dropdownlistbox;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.m_dropdownlistbox_k__BackingField=(pbj_webmapdemo.Im_main_menuInner.Im_controls_typeInner.Im_dropdownlistbox_type)value;} 
#line 89
                                                                                                              }

#line 90

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private pbj_webmapdemo.Im_main_menuInner.Im_controls_typeInner.Im_picture_type m_picture_k__BackingField;
#line 92


         [Mobilize.WebMap.Common.Attributes.Intercepted]
         public Im_main_menuInner.Im_controls_typeInner.Im_picture_type m_picture 
#line 92
                                                                                  { 
#line 92
                                                                                    get                                                                                       
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_m_picture)<=0){this.m_picture_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetNonObservable<pbj_webmapdemo.Im_main_menuInner.Im_controls_typeInner.Im_picture_type>(this,_Mobilize_References,8);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_m_picture;}return this.m_picture_k__BackingField;} 
#line 92

#line 92
                                                                                         set                                                                                            
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetNonObservable<Im_main_menuInner.Im_controls_typeInner.Im_picture_type >(this,_Mobilize_References,8,this.m_picture_k__BackingField,(pbj_webmapdemo.Im_main_menuInner.Im_controls_typeInner.Im_picture_type)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_m_picture;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_m_picture;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.m_picture_k__BackingField=(pbj_webmapdemo.Im_main_menuInner.Im_controls_typeInner.Im_picture_type)value;} 
#line 92
                                                                                              }

#line 93

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private pbj_webmapdemo.Im_main_menuInner.Im_controls_typeInner.Im_picturebutton_type m_picturebutton_k__BackingField;
#line 95


         [Mobilize.WebMap.Common.Attributes.Intercepted]
         public Im_main_menuInner.Im_controls_typeInner.Im_picturebutton_type m_picturebutton 
#line 95
                                                                                              { 
#line 95
                                                                                                get                                                                                                   
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_m_picturebutton)<=0){this.m_picturebutton_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetNonObservable<pbj_webmapdemo.Im_main_menuInner.Im_controls_typeInner.Im_picturebutton_type>(this,_Mobilize_References,9);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_m_picturebutton;}return this.m_picturebutton_k__BackingField;} 
#line 95

#line 95
                                                                                                     set                                                                                                        
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetNonObservable<Im_main_menuInner.Im_controls_typeInner.Im_picturebutton_type >(this,_Mobilize_References,9,this.m_picturebutton_k__BackingField,(pbj_webmapdemo.Im_main_menuInner.Im_controls_typeInner.Im_picturebutton_type)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_m_picturebutton;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_m_picturebutton;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.m_picturebutton_k__BackingField=(pbj_webmapdemo.Im_main_menuInner.Im_controls_typeInner.Im_picturebutton_type)value;} 
#line 95
                                                                                                          }

#line 96

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private pbj_webmapdemo.Im_main_menuInner.Im_controls_typeInner.Im_datamangercontrols_type m_datamangercontrols_k__BackingField;
#line 98


         [Mobilize.WebMap.Common.Attributes.Intercepted]
         public Im_main_menuInner.Im_controls_typeInner.Im_datamangercontrols_type m_datamangercontrols 
#line 98
                                                                                                        { 
#line 98
                                                                                                          get                                                                                                             
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_m_datamangercontrols)<=0){this.m_datamangercontrols_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetNonObservable<pbj_webmapdemo.Im_main_menuInner.Im_controls_typeInner.Im_datamangercontrols_type>(this,_Mobilize_References,10);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_m_datamangercontrols;}return this.m_datamangercontrols_k__BackingField;} 
#line 98

#line 98
                                                                                                               set                                                                                                                  
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetNonObservable<Im_main_menuInner.Im_controls_typeInner.Im_datamangercontrols_type >(this,_Mobilize_References,10,this.m_datamangercontrols_k__BackingField,(pbj_webmapdemo.Im_main_menuInner.Im_controls_typeInner.Im_datamangercontrols_type)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_m_datamangercontrols;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_m_datamangercontrols;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.m_datamangercontrols_k__BackingField=(pbj_webmapdemo.Im_main_menuInner.Im_controls_typeInner.Im_datamangercontrols_type)value;} 
#line 98
                                                                                                                    }

#line 99

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

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private pbj_webmapdemo.Im_main_menuInner.Im_controls_typeInner.Im_datamangercontrols_typeInner.Im_dropdowndw_type m_dropdowndw_k__BackingField;
#line 548


            [Mobilize.WebMap.Common.Attributes.Intercepted]
            public Im_main_menuInner.Im_controls_typeInner.Im_datamangercontrols_typeInner.Im_dropdowndw_type m_dropdowndw 
#line 548
                                                                                                                           { 
#line 548
                                                                                                                             get                                                                                                                                
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_m_dropdowndw)<=0){this.m_dropdowndw_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetNonObservable<pbj_webmapdemo.Im_main_menuInner.Im_controls_typeInner.Im_datamangercontrols_typeInner.Im_dropdowndw_type>(this,_Mobilize_References,0);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_m_dropdowndw;}return this.m_dropdowndw_k__BackingField;} 
#line 548

#line 548
                                                                                                                                  set                                                                                                                                     
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetNonObservable<Im_main_menuInner.Im_controls_typeInner.Im_datamangercontrols_typeInner.Im_dropdowndw_type >(this,_Mobilize_References,0,this.m_dropdowndw_k__BackingField,(pbj_webmapdemo.Im_main_menuInner.Im_controls_typeInner.Im_datamangercontrols_typeInner.Im_dropdowndw_type)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_m_dropdowndw;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_m_dropdowndw;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.m_dropdowndw_k__BackingField=(pbj_webmapdemo.Im_main_menuInner.Im_controls_typeInner.Im_datamangercontrols_typeInner.Im_dropdowndw_type)value;} 
#line 548
                                                                                                                                       }

#line 549

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

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private pbj_webmapdemo.Im_main_menuInner.Im_features_typeInner.Im_datawindowcrud_type m_datawindowcrud_k__BackingField;
#line 616


         [Mobilize.WebMap.Common.Attributes.Intercepted]
         public Im_main_menuInner.Im_features_typeInner.Im_datawindowcrud_type m_datawindowcrud 
#line 616
                                                                                                { 
#line 616
                                                                                                  get                                                                                                     
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_m_datawindowcrud)<=0){this.m_datawindowcrud_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetNonObservable<pbj_webmapdemo.Im_main_menuInner.Im_features_typeInner.Im_datawindowcrud_type>(this,_Mobilize_References,0);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_m_datawindowcrud;}return this.m_datawindowcrud_k__BackingField;} 
#line 616

#line 616
                                                                                                       set                                                                                                          
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetNonObservable<Im_main_menuInner.Im_features_typeInner.Im_datawindowcrud_type >(this,_Mobilize_References,0,this.m_datawindowcrud_k__BackingField,(pbj_webmapdemo.Im_main_menuInner.Im_features_typeInner.Im_datawindowcrud_type)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_m_datawindowcrud;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_m_datawindowcrud;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.m_datawindowcrud_k__BackingField=(pbj_webmapdemo.Im_main_menuInner.Im_features_typeInner.Im_datawindowcrud_type)value;} 
#line 616
                                                                                                            }

#line 617

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private pbj_webmapdemo.Im_main_menuInner.Im_features_typeInner.Im_datamanagereventonsinglerow_type m_datamanagereventonsinglerow_k__BackingField;
#line 619


         [Mobilize.WebMap.Common.Attributes.Intercepted]
         public Im_main_menuInner.Im_features_typeInner.Im_datamanagereventonsinglerow_type m_datamanagereventonsinglerow 
#line 619
                                                                                                                          { 
#line 619
                                                                                                                            get                                                                                                                               
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_m_datamanagereventonsinglerow)<=0){this.m_datamanagereventonsinglerow_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetNonObservable<pbj_webmapdemo.Im_main_menuInner.Im_features_typeInner.Im_datamanagereventonsinglerow_type>(this,_Mobilize_References,1);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_m_datamanagereventonsinglerow;}return this.m_datamanagereventonsinglerow_k__BackingField;} 
#line 619

#line 619
                                                                                                                                 set                                                                                                                                    
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetNonObservable<Im_main_menuInner.Im_features_typeInner.Im_datamanagereventonsinglerow_type >(this,_Mobilize_References,1,this.m_datamanagereventonsinglerow_k__BackingField,(pbj_webmapdemo.Im_main_menuInner.Im_features_typeInner.Im_datamanagereventonsinglerow_type)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_m_datamanagereventonsinglerow;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_m_datamanagereventonsinglerow;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.m_datamanagereventonsinglerow_k__BackingField=(pbj_webmapdemo.Im_main_menuInner.Im_features_typeInner.Im_datamanagereventonsinglerow_type)value;} 
#line 619
                                                                                                                                      }

#line 620

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private pbj_webmapdemo.Im_main_menuInner.Im_features_typeInner.Im_alldatamanagercontrolinteractions_type m_alldatamanagercontrolinteractions_k__BackingField;
#line 622


         [Mobilize.WebMap.Common.Attributes.Intercepted]
         public Im_main_menuInner.Im_features_typeInner.Im_alldatamanagercontrolinteractions_type m_alldatamanagercontrolinteractions 
#line 622
                                                                                                                                      { 
#line 622
                                                                                                                                        get                                                                                                                                           
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_m_alldatamanagercontrolinteractions)<=0){this.m_alldatamanagercontrolinteractions_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetNonObservable<pbj_webmapdemo.Im_main_menuInner.Im_features_typeInner.Im_alldatamanagercontrolinteractions_type>(this,_Mobilize_References,2);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_m_alldatamanagercontrolinteractions;}return this.m_alldatamanagercontrolinteractions_k__BackingField;} 
#line 622

#line 622
                                                                                                                                             set                                                                                                                                                
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetNonObservable<Im_main_menuInner.Im_features_typeInner.Im_alldatamanagercontrolinteractions_type >(this,_Mobilize_References,2,this.m_alldatamanagercontrolinteractions_k__BackingField,(pbj_webmapdemo.Im_main_menuInner.Im_features_typeInner.Im_alldatamanagercontrolinteractions_type)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_m_alldatamanagercontrolinteractions;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_m_alldatamanagercontrolinteractions;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.m_alldatamanagercontrolinteractions_k__BackingField=(pbj_webmapdemo.Im_main_menuInner.Im_features_typeInner.Im_alldatamanagercontrolinteractions_type)value;} 
#line 622
                                                                                                                                                  }

#line 623

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private pbj_webmapdemo.Im_main_menuInner.Im_features_typeInner.Im_1_type m_1_k__BackingField;
#line 625


         [Mobilize.WebMap.Common.Attributes.Intercepted]
         public Im_main_menuInner.Im_features_typeInner.Im_1_type m_1 
#line 625
                                                                      { 
#line 625
                                                                        get                                                                           
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_m_1)<=0){this.m_1_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetNonObservable<pbj_webmapdemo.Im_main_menuInner.Im_features_typeInner.Im_1_type>(this,_Mobilize_References,3);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_m_1;}return this.m_1_k__BackingField;} 
#line 625

#line 625
                                                                             set                                                                                
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetNonObservable<Im_main_menuInner.Im_features_typeInner.Im_1_type >(this,_Mobilize_References,3,this.m_1_k__BackingField,(pbj_webmapdemo.Im_main_menuInner.Im_features_typeInner.Im_1_type)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_m_1;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_m_1;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.m_1_k__BackingField=(pbj_webmapdemo.Im_main_menuInner.Im_features_typeInner.Im_1_type)value;} 
#line 625
                                                                                  }

#line 626

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private pbj_webmapdemo.Im_main_menuInner.Im_features_typeInner.Im_2_type m_2_k__BackingField;
#line 628


         [Mobilize.WebMap.Common.Attributes.Intercepted]
         public Im_main_menuInner.Im_features_typeInner.Im_2_type m_2 
#line 628
                                                                      { 
#line 628
                                                                        get                                                                           
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_m_2)<=0){this.m_2_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetNonObservable<pbj_webmapdemo.Im_main_menuInner.Im_features_typeInner.Im_2_type>(this,_Mobilize_References,4);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_m_2;}return this.m_2_k__BackingField;} 
#line 628

#line 628
                                                                             set                                                                                
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetNonObservable<Im_main_menuInner.Im_features_typeInner.Im_2_type >(this,_Mobilize_References,4,this.m_2_k__BackingField,(pbj_webmapdemo.Im_main_menuInner.Im_features_typeInner.Im_2_type)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_m_2;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_m_2;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.m_2_k__BackingField=(pbj_webmapdemo.Im_main_menuInner.Im_features_typeInner.Im_2_type)value;} 
#line 628
                                                                                  }

#line 629

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private pbj_webmapdemo.Im_main_menuInner.Im_features_typeInner.Im_3_type m_3_k__BackingField;
#line 631


         [Mobilize.WebMap.Common.Attributes.Intercepted]
         public Im_main_menuInner.Im_features_typeInner.Im_3_type m_3 
#line 631
                                                                      { 
#line 631
                                                                        get                                                                           
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_m_3)<=0){this.m_3_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetNonObservable<pbj_webmapdemo.Im_main_menuInner.Im_features_typeInner.Im_3_type>(this,_Mobilize_References,5);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_m_3;}return this.m_3_k__BackingField;} 
#line 631

#line 631
                                                                             set                                                                                
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetNonObservable<Im_main_menuInner.Im_features_typeInner.Im_3_type >(this,_Mobilize_References,5,this.m_3_k__BackingField,(pbj_webmapdemo.Im_main_menuInner.Im_features_typeInner.Im_3_type)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_m_3;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_m_3;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.m_3_k__BackingField=(pbj_webmapdemo.Im_main_menuInner.Im_features_typeInner.Im_3_type)value;} 
#line 631
                                                                                  }

#line 632

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private pbj_webmapdemo.Im_main_menuInner.Im_features_typeInner.Im_4_type m_4_k__BackingField;
#line 634


         [Mobilize.WebMap.Common.Attributes.Intercepted]
         public Im_main_menuInner.Im_features_typeInner.Im_4_type m_4 
#line 634
                                                                      { 
#line 634
                                                                        get                                                                           
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_m_4)<=0){this.m_4_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetNonObservable<pbj_webmapdemo.Im_main_menuInner.Im_features_typeInner.Im_4_type>(this,_Mobilize_References,6);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_m_4;}return this.m_4_k__BackingField;} 
#line 634

#line 634
                                                                             set                                                                                
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetNonObservable<Im_main_menuInner.Im_features_typeInner.Im_4_type >(this,_Mobilize_References,6,this.m_4_k__BackingField,(pbj_webmapdemo.Im_main_menuInner.Im_features_typeInner.Im_4_type)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_m_4;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_m_4;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.m_4_k__BackingField=(pbj_webmapdemo.Im_main_menuInner.Im_features_typeInner.Im_4_type)value;} 
#line 634
                                                                                  }

#line 635

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private pbj_webmapdemo.Im_main_menuInner.Im_features_typeInner.Im_datamanagerstate_nodata_type m_datamanagerstate_nodata_k__BackingField;
#line 637


         [Mobilize.WebMap.Common.Attributes.Intercepted]
         public Im_main_menuInner.Im_features_typeInner.Im_datamanagerstate_nodata_type m_datamanagerstate_nodata 
#line 637
                                                                                                                  { 
#line 637
                                                                                                                    get                                                                                                                       
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_m_datamanagerstate_nodata)<=0){this.m_datamanagerstate_nodata_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetNonObservable<pbj_webmapdemo.Im_main_menuInner.Im_features_typeInner.Im_datamanagerstate_nodata_type>(this,_Mobilize_References,7);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_m_datamanagerstate_nodata;}return this.m_datamanagerstate_nodata_k__BackingField;} 
#line 637

#line 637
                                                                                                                         set                                                                                                                            
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetNonObservable<Im_main_menuInner.Im_features_typeInner.Im_datamanagerstate_nodata_type >(this,_Mobilize_References,7,this.m_datamanagerstate_nodata_k__BackingField,(pbj_webmapdemo.Im_main_menuInner.Im_features_typeInner.Im_datamanagerstate_nodata_type)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_m_datamanagerstate_nodata;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_m_datamanagerstate_nodata;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.m_datamanagerstate_nodata_k__BackingField=(pbj_webmapdemo.Im_main_menuInner.Im_features_typeInner.Im_datamanagerstate_nodata_type)value;} 
#line 637
                                                                                                                              }

#line 638

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private pbj_webmapdemo.Im_main_menuInner.Im_features_typeInner.Im_datamanagerw_window_type m_datamanagerw_window_k__BackingField;
#line 640


         [Mobilize.WebMap.Common.Attributes.Intercepted]
         public Im_main_menuInner.Im_features_typeInner.Im_datamanagerw_window_type m_datamanagerw_window 
#line 640
                                                                                                          { 
#line 640
                                                                                                            get                                                                                                               
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_m_datamanagerw_window)<=0){this.m_datamanagerw_window_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetNonObservable<pbj_webmapdemo.Im_main_menuInner.Im_features_typeInner.Im_datamanagerw_window_type>(this,_Mobilize_References,8);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_m_datamanagerw_window;}return this.m_datamanagerw_window_k__BackingField;} 
#line 640

#line 640
                                                                                                                 set                                                                                                                    
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetNonObservable<Im_main_menuInner.Im_features_typeInner.Im_datamanagerw_window_type >(this,_Mobilize_References,8,this.m_datamanagerw_window_k__BackingField,(pbj_webmapdemo.Im_main_menuInner.Im_features_typeInner.Im_datamanagerw_window_type)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_m_datamanagerw_window;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_m_datamanagerw_window;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.m_datamanagerw_window_k__BackingField=(pbj_webmapdemo.Im_main_menuInner.Im_features_typeInner.Im_datamanagerw_window_type)value;} 
#line 640
                                                                                                                      }

#line 641

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private pbj_webmapdemo.Im_main_menuInner.Im_features_typeInner.Im_datamanagerw_shared_type m_datamanagerw_shared_k__BackingField;
#line 643


         [Mobilize.WebMap.Common.Attributes.Intercepted]
         public Im_main_menuInner.Im_features_typeInner.Im_datamanagerw_shared_type m_datamanagerw_shared 
#line 643
                                                                                                          { 
#line 643
                                                                                                            get                                                                                                               
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_m_datamanagerw_shared)<=0){this.m_datamanagerw_shared_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetNonObservable<pbj_webmapdemo.Im_main_menuInner.Im_features_typeInner.Im_datamanagerw_shared_type>(this,_Mobilize_References,9);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_m_datamanagerw_shared;}return this.m_datamanagerw_shared_k__BackingField;} 
#line 643

#line 643
                                                                                                                 set                                                                                                                    
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetNonObservable<Im_main_menuInner.Im_features_typeInner.Im_datamanagerw_shared_type >(this,_Mobilize_References,9,this.m_datamanagerw_shared_k__BackingField,(pbj_webmapdemo.Im_main_menuInner.Im_features_typeInner.Im_datamanagerw_shared_type)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_m_datamanagerw_shared;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_m_datamanagerw_shared;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.m_datamanagerw_shared_k__BackingField=(pbj_webmapdemo.Im_main_menuInner.Im_features_typeInner.Im_datamanagerw_shared_type)value;} 
#line 643
                                                                                                                      }

#line 644

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private pbj_webmapdemo.Im_main_menuInner.Im_features_typeInner.Im_datamanagerw_dropdown_type m_datamanagerw_dropdown_k__BackingField;
#line 646


         [Mobilize.WebMap.Common.Attributes.Intercepted]
         public Im_main_menuInner.Im_features_typeInner.Im_datamanagerw_dropdown_type m_datamanagerw_dropdown 
#line 646
                                                                                                              { 
#line 646
                                                                                                                get                                                                                                                   
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_m_datamanagerw_dropdown)<=0){this.m_datamanagerw_dropdown_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetNonObservable<pbj_webmapdemo.Im_main_menuInner.Im_features_typeInner.Im_datamanagerw_dropdown_type>(this,_Mobilize_References,10);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_m_datamanagerw_dropdown;}return this.m_datamanagerw_dropdown_k__BackingField;} 
#line 646

#line 646
                                                                                                                     set                                                                                                                        
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetNonObservable<Im_main_menuInner.Im_features_typeInner.Im_datamanagerw_dropdown_type >(this,_Mobilize_References,10,this.m_datamanagerw_dropdown_k__BackingField,(pbj_webmapdemo.Im_main_menuInner.Im_features_typeInner.Im_datamanagerw_dropdown_type)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_m_datamanagerw_dropdown;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_m_datamanagerw_dropdown;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.m_datamanagerw_dropdown_k__BackingField=(pbj_webmapdemo.Im_main_menuInner.Im_features_typeInner.Im_datamanagerw_dropdown_type)value;} 
#line 646
                                                                                                                          }

#line 647

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private pbj_webmapdemo.Im_main_menuInner.Im_features_typeInner.Im_datamanagerw_expression_type m_datamanagerw_expression_k__BackingField;
#line 649


         [Mobilize.WebMap.Common.Attributes.Intercepted]
         public Im_main_menuInner.Im_features_typeInner.Im_datamanagerw_expression_type m_datamanagerw_expression 
#line 649
                                                                                                                  { 
#line 649
                                                                                                                    get                                                                                                                       
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_m_datamanagerw_expression)<=0){this.m_datamanagerw_expression_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetNonObservable<pbj_webmapdemo.Im_main_menuInner.Im_features_typeInner.Im_datamanagerw_expression_type>(this,_Mobilize_References,11);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_m_datamanagerw_expression;}return this.m_datamanagerw_expression_k__BackingField;} 
#line 649

#line 649
                                                                                                                         set                                                                                                                            
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetNonObservable<Im_main_menuInner.Im_features_typeInner.Im_datamanagerw_expression_type >(this,_Mobilize_References,11,this.m_datamanagerw_expression_k__BackingField,(pbj_webmapdemo.Im_main_menuInner.Im_features_typeInner.Im_datamanagerw_expression_type)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_m_datamanagerw_expression;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_m_datamanagerw_expression;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.m_datamanagerw_expression_k__BackingField=(pbj_webmapdemo.Im_main_menuInner.Im_features_typeInner.Im_datamanagerw_expression_type)value;} 
#line 649
                                                                                                                              }

#line 650

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
#pragma warning restore
