#pragma warning disable
#line 1 "str_patient\\str_patient.cs"
#pragma warning disable
#line 1 "str_patient\\str_patient.cs"
namespace models
{

   [Mobilize.WebMap.Common.Attributes.Observable]
   public sealed partial class str_patient
      : Mobilize.Web.BaseStructure, models.Istr_patient
   {

      public str_patient()
      {
         firstname = "";
         lastname = "";
         age = 0;
         iid = 0;
      }

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private string firstname_k__BackingField;
#line 18


      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public string firstname 
#line 18
                              { 
#line 18
                                get                                   
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.firstname_k__BackingField;} 
#line 18

#line 18
                                     set                                        
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_firstname;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.firstname_k__BackingField=(string)value;} 
#line 18
                                          }

#line 19

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private string lastname_k__BackingField;
#line 21


      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public string lastname 
#line 21
                             { 
#line 21
                               get                                  
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.lastname_k__BackingField;} 
#line 21

#line 21
                                    set                                       
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_lastname;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.lastname_k__BackingField=(string)value;} 
#line 21
                                         }

#line 22

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private short? age_k__BackingField;
#line 24


      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public short? age 
#line 24
                        { 
#line 24
                          get                             
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.age_k__BackingField;} 
#line 24

#line 24
                               set                                  
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_age;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.age_k__BackingField=(short?)value;} 
#line 24
                                    }

#line 25

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private short? iid_k__BackingField;
#line 27


      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public short? iid 
#line 27
                        { 
#line 27
                          get                             
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.iid_k__BackingField;} 
#line 27

#line 27
                               set                                  
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_iid;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.iid_k__BackingField=(short?)value;} 
#line 27
                                    }

#line 28

      public Istr_patient ByVal()
      {
         var newStructure = new str_patient();
         newStructure.firstname = this.firstname;
         newStructure.lastname = this.lastname;
         newStructure.age = this.age;
         newStructure.iid = this.iid;
         return newStructure;
      }

   }

}
#pragma warning restore
