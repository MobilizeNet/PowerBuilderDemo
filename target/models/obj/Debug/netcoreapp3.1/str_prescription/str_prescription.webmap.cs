#pragma warning disable
#line 1 "str_prescription\\str_prescription.cs"
#pragma warning disable
#line 1 "str_prescription\\str_prescription.cs"
namespace models
{

   [Mobilize.WebMap.Common.Attributes.Observable]
   public sealed partial class str_prescription
      : Mobilize.Web.BaseStructure, models.Istr_prescription
   {

      public str_prescription()
      {
         dose = null;
         iid = 0;
         medicine = 0;
         patient = 0;
         state = 0;
         socialsecurity = "";
      }

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private decimal? dose_k__BackingField;
#line 20


      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public decimal? dose 
#line 20
                           { 
#line 20
                             get                                
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.dose_k__BackingField;} 
#line 20

#line 20
                                  set                                     
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_dose;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.dose_k__BackingField=(decimal?)value;} 
#line 20
                                       }

#line 21

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private short? iid_k__BackingField;
#line 23


      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public short? iid 
#line 23
                        { 
#line 23
                          get                             
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.iid_k__BackingField;} 
#line 23

#line 23
                               set                                  
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_iid;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.iid_k__BackingField=(short?)value;} 
#line 23
                                    }

#line 24

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private short? medicine_k__BackingField;
#line 26


      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public short? medicine 
#line 26
                             { 
#line 26
                               get                                  
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.medicine_k__BackingField;} 
#line 26

#line 26
                                    set                                       
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_medicine;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.medicine_k__BackingField=(short?)value;} 
#line 26
                                         }

#line 27

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private short? patient_k__BackingField;
#line 29


      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public short? patient 
#line 29
                            { 
#line 29
                              get                                 
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.patient_k__BackingField;} 
#line 29

#line 29
                                   set                                      
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_patient;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.patient_k__BackingField=(short?)value;} 
#line 29
                                        }

#line 30

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private short? state_k__BackingField;
#line 32


      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public short? state 
#line 32
                          { 
#line 32
                            get                               
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.state_k__BackingField;} 
#line 32

#line 32
                                 set                                    
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_state;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.state_k__BackingField=(short?)value;} 
#line 32
                                      }

#line 33

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private string socialsecurity_k__BackingField;
#line 35


      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public string socialsecurity 
#line 35
                                   { 
#line 35
                                     get                                        
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.socialsecurity_k__BackingField;} 
#line 35

#line 35
                                          set                                             
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_socialsecurity;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.socialsecurity_k__BackingField=(string)value;} 
#line 35
                                               }

#line 36

      public Istr_prescription ByVal()
      {
         var newStructure = new str_prescription();
         newStructure.dose = this.dose;
         newStructure.iid = this.iid;
         newStructure.medicine = this.medicine;
         newStructure.patient = this.patient;
         newStructure.state = this.state;
         newStructure.socialsecurity = this.socialsecurity;
         return newStructure;
      }

   }

}
#pragma warning restore
