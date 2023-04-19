#pragma warning disable
#line 1 "w_dummyfeatures\\w_dummyfeatures_Layout.cs"
#pragma warning disable
#line 1 "w_dummyfeatures\\w_dummyfeatures_Layout.cs"
namespace features
{

   public partial class w_dummyfeatures
   {

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private features.Iw_dummyfeaturesInner.Icb_1_type cb_1_k__BackingField;
#line 8


      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_dummyfeaturesInner.Icb_1_type cb_1 
#line 8
                                                   { 
#line 8
                                                     get                                                        
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_cb_1)<=0){this.cb_1_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetNonObservable<features.Iw_dummyfeaturesInner.Icb_1_type>(this,_Mobilize_References,0);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_cb_1;}return this.cb_1_k__BackingField;} 
#line 8

#line 8
                                                          set                                                             
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetNonObservable<Iw_dummyfeaturesInner.Icb_1_type >(this,_Mobilize_References,0,this.cb_1_k__BackingField,(features.Iw_dummyfeaturesInner.Icb_1_type)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_cb_1;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_cb_1;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.cb_1_k__BackingField=(features.Iw_dummyfeaturesInner.Icb_1_type)value;} 
#line 8
                                                               }

#line 9


      public w_dummyfeatures(Mobilize.Web.BaseControl parent = null)
      : base(parent)
      {
         this.Width = 3378;
         this.Height = 1408;
         this.TitleBar = true;
         this.Title = "Untitled";
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
