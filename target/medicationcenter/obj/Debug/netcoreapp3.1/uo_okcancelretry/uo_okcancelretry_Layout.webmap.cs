#pragma warning disable
#line 1 "uo_okcancelretry\\uo_okcancelretry_Layout.cs"
#pragma warning disable
#line 1 "uo_okcancelretry\\uo_okcancelretry_Layout.cs"
namespace medicationcenter
{

   public partial class uo_okcancelretry
   {

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private medicationcenter.Iuo_okcancelretryInner.Icb_retry_type cb_retry_k__BackingField;
#line 8


      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iuo_okcancelretryInner.Icb_retry_type cb_retry 
#line 8
                                                            { 
#line 8
                                                              get                                                                 
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_cb_retry)<=0){this.cb_retry_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetNonObservable<medicationcenter.Iuo_okcancelretryInner.Icb_retry_type>(this,_Mobilize_References,0);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_cb_retry;}return this.cb_retry_k__BackingField;} 
#line 8

#line 8
                                                                   set                                                                      
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetNonObservable<Iuo_okcancelretryInner.Icb_retry_type >(this,_Mobilize_References,0,this.cb_retry_k__BackingField,(medicationcenter.Iuo_okcancelretryInner.Icb_retry_type)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_cb_retry;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_cb_retry;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.cb_retry_k__BackingField=(medicationcenter.Iuo_okcancelretryInner.Icb_retry_type)value;} 
#line 8
                                                                        }

#line 9

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private medicationcenter.Iuo_okcancelretryInner.Icb_cancel_type cb_cancel_k__BackingField;
#line 11


      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iuo_okcancelretryInner.Icb_cancel_type cb_cancel 
#line 11
                                                              { 
#line 11
                                                                get                                                                   
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_cb_cancel)<=0){this.cb_cancel_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetNonObservable<medicationcenter.Iuo_okcancelretryInner.Icb_cancel_type>(this,_Mobilize_References,1);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_cb_cancel;}return this.cb_cancel_k__BackingField;} 
#line 11

#line 11
                                                                     set                                                                        
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetNonObservable<Iuo_okcancelretryInner.Icb_cancel_type >(this,_Mobilize_References,1,this.cb_cancel_k__BackingField,(medicationcenter.Iuo_okcancelretryInner.Icb_cancel_type)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_cb_cancel;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_cb_cancel;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.cb_cancel_k__BackingField=(medicationcenter.Iuo_okcancelretryInner.Icb_cancel_type)value;} 
#line 11
                                                                          }

#line 12

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private medicationcenter.Iuo_okcancelretryInner.Icb_ok_type cb_ok_k__BackingField;
#line 14


      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iuo_okcancelretryInner.Icb_ok_type cb_ok 
#line 14
                                                      { 
#line 14
                                                        get                                                           
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_cb_ok)<=0){this.cb_ok_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetNonObservable<medicationcenter.Iuo_okcancelretryInner.Icb_ok_type>(this,_Mobilize_References,2);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_cb_ok;}return this.cb_ok_k__BackingField;} 
#line 14

#line 14
                                                             set                                                                
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetNonObservable<Iuo_okcancelretryInner.Icb_ok_type >(this,_Mobilize_References,2,this.cb_ok_k__BackingField,(medicationcenter.Iuo_okcancelretryInner.Icb_ok_type)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_cb_ok;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_cb_ok;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.cb_ok_k__BackingField=(medicationcenter.Iuo_okcancelretryInner.Icb_ok_type)value;} 
#line 14
                                                                  }

#line 15

      public Mobilize.Web.VoidEventHandler okclickEventHandler { get; set; }

      public Mobilize.Web.VoidEventHandler cancelclickEventHandler { get; set; }

      public Mobilize.Web.VoidEventHandler retryclickEventHandler { get; set; }


      public uo_okcancelretry(Mobilize.Web.BaseControl parent = null)
      : base(parent)
      {
         this.Width = 1413;
         this.Height = 184;
         this.BackColor = 67108864;
         this.Text = "none";
         this.TabTextColor = 33554432;
         this.PictureMaskColor = 536870912;
      }
   }

}
#pragma warning restore
