#pragma warning disable
#line 1 "w_basemdi\\w_basemdi_Layout.cs"
#pragma warning disable
#line 1 "w_basemdi\\w_basemdi_Layout.cs"
namespace medicationcenter
{

   public partial class w_basemdi
   {

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private medicationcenter.Iw_basemdiInner.Imdi_1_type mdi_1_k__BackingField;
#line 8


      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_basemdiInner.Imdi_1_type mdi_1 
#line 8
                                               { 
#line 8
                                                 get                                                    
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_mdi_1)<=0){this.mdi_1_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetNonObservable<medicationcenter.Iw_basemdiInner.Imdi_1_type>(this,_Mobilize_References,0);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_mdi_1;}return this.mdi_1_k__BackingField;} 
#line 8

#line 8
                                                      set                                                         
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetNonObservable<Iw_basemdiInner.Imdi_1_type >(this,_Mobilize_References,0,this.mdi_1_k__BackingField,(medicationcenter.Iw_basemdiInner.Imdi_1_type)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_mdi_1;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_mdi_1;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.mdi_1_k__BackingField=(medicationcenter.Iw_basemdiInner.Imdi_1_type)value;} 
#line 8
                                                           }

#line 9


      public w_basemdi(Mobilize.Web.BaseControl parent = null)
      : base(parent)
      {
         this.Width = 4101;
         this.Height = 2948;
         this.Title = "Medication Center";
         this.MenuName = "m_basemdi";
         this.WindowType = Mobilize.Web.WindowType.Mdi;
         this.WindowState = Mobilize.Web.WindowState.Maximized;
      }
   }

}
#pragma warning restore
