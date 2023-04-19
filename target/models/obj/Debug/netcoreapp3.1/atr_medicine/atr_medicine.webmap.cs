#pragma warning disable
#line 1 "atr_medicine\\atr_medicine.cs"
#pragma warning disable
#line 1 "atr_medicine\\atr_medicine.cs"
namespace models
{

   [Mobilize.WebMap.Common.Attributes.Observable]
   public sealed partial class atr_medicine
      : Mobilize.Web.BaseStructure, models.Iatr_medicine
   {

      public atr_medicine()
      {
         sname = "";
         iid = 0;
      }

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private string sname_k__BackingField;
#line 16


      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public string sname 
#line 16
                          { 
#line 16
                            get                               
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.sname_k__BackingField;} 
#line 16

#line 16
                                 set                                    
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_sname;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.sname_k__BackingField=(string)value;} 
#line 16
                                      }

#line 17

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private short? iid_k__BackingField;
#line 19


      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public short? iid 
#line 19
                        { 
#line 19
                          get                             
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.iid_k__BackingField;} 
#line 19

#line 19
                               set                                  
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_iid;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.iid_k__BackingField=(short?)value;} 
#line 19
                                    }

#line 20

      public Iatr_medicine ByVal()
      {
         var newStructure = new atr_medicine();
         newStructure.sname = this.sname;
         newStructure.iid = this.iid;
         return newStructure;
      }

   }

}
#pragma warning restore
