#pragma warning disable
#line 1 "w_prescriptionmant\\w_prescriptionmant_Layout.cs"
#pragma warning disable
#line 1 "w_prescriptionmant\\w_prescriptionmant_Layout.cs"
namespace medicationcenter
{

   public partial class w_prescriptionmant
   {

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private medicationcenter.Iw_prescriptionmantInner.Iuo_1_type uo_1_k__BackingField;
#line 8


      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_prescriptionmantInner.Iuo_1_type uo_1 
#line 8
                                                      { 
#line 8
                                                        get                                                           
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_uo_1)<=0){this.uo_1_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetNonObservable<medicationcenter.Iw_prescriptionmantInner.Iuo_1_type>(this,_Mobilize_References,0);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_uo_1;}return this.uo_1_k__BackingField;} 
#line 8

#line 8
                                                             set                                                                
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetNonObservable<Iw_prescriptionmantInner.Iuo_1_type >(this,_Mobilize_References,0,this.uo_1_k__BackingField,(medicationcenter.Iw_prescriptionmantInner.Iuo_1_type)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_uo_1;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_uo_1;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.uo_1_k__BackingField=(medicationcenter.Iw_prescriptionmantInner.Iuo_1_type)value;} 
#line 8
                                                                  }

#line 9

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private bool? dirtyadd_k__BackingField;
#line 11


      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public bool? dirtyadd 
#line 11
                            { 
#line 11
                              get                                 
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.dirtyadd_k__BackingField;} 
#line 11

#line 11
                                   set                                      
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_dirtyadd;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.dirtyadd_k__BackingField=(bool?)value;} 
#line 11
                                        }

#line 12

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private bool? dirtyremove_k__BackingField;
#line 14


      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public bool? dirtyremove 
#line 14
                               { 
#line 14
                                 get                                    
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.dirtyremove_k__BackingField;} 
#line 14

#line 14
                                      set                                         
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_dirtyremove;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.dirtyremove_k__BackingField=(bool?)value;} 
#line 14
                                           }

#line 15

      public Mobilize.Web.VoidEventHandler savedataEventHandler { get; set; }


      public w_prescriptionmant(Mobilize.Web.BaseControl parent = null)
      : base(parent)
      {
         this.Width = 3301;
         this.Height = 2104;
         this.MenuName = "m_adminmaint";
         this.ControlMenu = false;
         this.MaxBox = false;
         this.Resizable = false;
      }
   }

}
#pragma warning restore
