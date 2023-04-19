#pragma warning disable
#line 1 "w_window\\w_window_Layout.cs"
#pragma warning disable
#line 1 "w_window\\w_window_Layout.cs"
namespace notifycurrentcontrol
{

   public partial class w_window
   {

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private notifycurrentcontrol.Iw_windowInner.Ist_1_type st_1_k__BackingField;
#line 8


      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_windowInner.Ist_1_type st_1 
#line 8
                                            { 
#line 8
                                              get                                                 
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_st_1)<=0){this.st_1_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetNonObservable<notifycurrentcontrol.Iw_windowInner.Ist_1_type>(this,_Mobilize_References,0);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_st_1;}return this.st_1_k__BackingField;} 
#line 8

#line 8
                                                   set                                                      
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetNonObservable<Iw_windowInner.Ist_1_type >(this,_Mobilize_References,0,this.st_1_k__BackingField,(notifycurrentcontrol.Iw_windowInner.Ist_1_type)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_st_1;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_st_1;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.st_1_k__BackingField=(notifycurrentcontrol.Iw_windowInner.Ist_1_type)value;} 
#line 8
                                                        }

#line 9

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private notifycurrentcontrol.Iw_windowInner.Idw_1_type dw_1_k__BackingField;
#line 11


      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_windowInner.Idw_1_type dw_1 
#line 11
                                            { 
#line 11
                                              get                                                 
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_dw_1)<=0){this.dw_1_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetNonObservable<notifycurrentcontrol.Iw_windowInner.Idw_1_type>(this,_Mobilize_References,1);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_dw_1;}return this.dw_1_k__BackingField;} 
#line 11

#line 11
                                                   set                                                      
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetNonObservable<Iw_windowInner.Idw_1_type >(this,_Mobilize_References,1,this.dw_1_k__BackingField,(notifycurrentcontrol.Iw_windowInner.Idw_1_type)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_dw_1;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_dw_1;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.dw_1_k__BackingField=(notifycurrentcontrol.Iw_windowInner.Idw_1_type)value;} 
#line 11
                                                        }

#line 12


      public w_window(Mobilize.Web.BaseControl parent = null)
      : base(parent)
      {
         this.Width = 1888;
         this.Height = 1272;
         this.TitleBar = true;
         this.Title = "Notify Current Control Change";
         this.ControlMenu = true;
         this.MinBox = true;
         this.MaxBox = true;
         this.Resizable = true;
         this.BackColor = 67108864;
         this.Icon = "AppIcon!";
         this.Center = true;
      }
   }

}
#pragma warning restore
