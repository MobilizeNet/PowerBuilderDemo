#pragma warning disable
#line 1 "w_dw_dropdowndatawindow\\w_dw_dropdowndatawindow_Layout.cs"
#pragma warning disable
#line 1 "w_dw_dropdowndatawindow\\w_dw_dropdowndatawindow_Layout.cs"
namespace pbj_webmapdemo
{

   public partial class w_dw_dropdowndatawindow
   {

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private pbj_webmapdemo.Iw_dw_dropdowndatawindowInner.Idw_1_type dw_1_k__BackingField;
#line 8


      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_dw_dropdowndatawindowInner.Idw_1_type dw_1 
#line 8
                                                           { 
#line 8
                                                             get                                                                
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_dw_1)<=0){this.dw_1_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetNonObservable<pbj_webmapdemo.Iw_dw_dropdowndatawindowInner.Idw_1_type>(this,_Mobilize_References,0);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_dw_1;}return this.dw_1_k__BackingField;} 
#line 8

#line 8
                                                                  set                                                                     
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetNonObservable<Iw_dw_dropdowndatawindowInner.Idw_1_type >(this,_Mobilize_References,0,this.dw_1_k__BackingField,(pbj_webmapdemo.Iw_dw_dropdowndatawindowInner.Idw_1_type)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_dw_1;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_dw_1;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.dw_1_k__BackingField=(pbj_webmapdemo.Iw_dw_dropdowndatawindowInner.Idw_1_type)value;} 
#line 8
                                                                       }

#line 9


      public w_dw_dropdowndatawindow(Mobilize.Web.BaseControl parent = null)
      : base(parent)
      {
         this.Width = 3945;
         this.Height = 1140;
         this.TitleBar = true;
         this.Title = "DropDown Data Window";
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
