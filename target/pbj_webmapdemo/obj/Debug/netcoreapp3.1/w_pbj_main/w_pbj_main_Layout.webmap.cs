#pragma warning disable
#line 1 "w_pbj_main\\w_pbj_main_Layout.cs"
#pragma warning disable
#line 1 "w_pbj_main\\w_pbj_main_Layout.cs"
namespace pbj_webmapdemo
{

   public partial class w_pbj_main
   {

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private pbj_webmapdemo.Iw_pbj_mainInner.Imdi_1_type mdi_1_k__BackingField;
#line 8


      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_pbj_mainInner.Imdi_1_type mdi_1 
#line 8
                                                { 
#line 8
                                                  get                                                     
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_mdi_1)<=0){this.mdi_1_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetNonObservable<pbj_webmapdemo.Iw_pbj_mainInner.Imdi_1_type>(this,_Mobilize_References,0);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_mdi_1;}return this.mdi_1_k__BackingField;} 
#line 8

#line 8
                                                       set                                                          
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetNonObservable<Iw_pbj_mainInner.Imdi_1_type >(this,_Mobilize_References,0,this.mdi_1_k__BackingField,(pbj_webmapdemo.Iw_pbj_mainInner.Imdi_1_type)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_mdi_1;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_mdi_1;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.mdi_1_k__BackingField=(pbj_webmapdemo.Iw_pbj_mainInner.Imdi_1_type)value;} 
#line 8
                                                            }

#line 9


      public w_pbj_main(Mobilize.Web.BaseControl parent = null)
      : base(parent)
      {
         this.Width = 4037;
         this.Height = 2180;
         this.TitleBar = true;
         this.Title = "PBJ_WebMapDemo";
         this.MenuName = "m_main_menu";
         this.ControlMenu = true;
         this.MinBox = true;
         this.MaxBox = true;
         this.Resizable = true;
         this.WindowType = Mobilize.Web.WindowType.Mdi;
         this.BackColor = 67108864;
         this.Icon = "AppIcon!";
         this.Center = true;
      }
   }

}
#pragma warning restore
