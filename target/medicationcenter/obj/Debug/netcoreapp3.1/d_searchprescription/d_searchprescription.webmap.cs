#pragma warning disable
#line 1 "d_searchprescription\\d_searchprescription.cs"
#pragma warning disable
#line 1 "d_searchprescription\\d_searchprescription.cs"
namespace medicationcenter
{

   [Mobilize.WebMap.Common.Attributes.Observable]
   public partial class d_searchprescription
      : Mobilize.Web.DataManager, Mobilize.Web.IDataManager
   {

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.DmText patient_t_k__BackingField;
#line 10


      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText patient_t 
#line 10
                                           { 
#line 10
                                             get                                                
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_patient_t)<=0){this.patient_t_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.DmText>(this,_Mobilize_References,0);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_patient_t;;} return this.patient_t_k__BackingField; } 
#line 10

#line 10
                                                  set                                                     
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.DmText>(this,_Mobilize_References,0,this.patient_t_k__BackingField,(Mobilize.Web.DmText)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_patient_t;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_patient_t;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.patient_t_k__BackingField=(Mobilize.Web.DmText)value;} 
#line 10
                                                       }

#line 11

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.DmColumn patient_k__BackingField;
#line 13


      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn patient 
#line 13
                                           { 
#line 13
                                             get                                                
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_patient)<=0){this.patient_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.DmColumn>(this,_Mobilize_References,1);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_patient;;} return this.patient_k__BackingField; } 
#line 13

#line 13
                                                  set                                                     
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.DmColumn>(this,_Mobilize_References,1,this.patient_k__BackingField,(Mobilize.Web.DmColumn)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_patient;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_patient;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.patient_k__BackingField=(Mobilize.Web.DmColumn)value;} 
#line 13
                                                       }

#line 14

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.DmText medication_t_k__BackingField;
#line 16


      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText medication_t 
#line 16
                                              { 
#line 16
                                                get                                                   
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_medication_t)<=0){this.medication_t_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.DmText>(this,_Mobilize_References,2);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_medication_t;;} return this.medication_t_k__BackingField; } 
#line 16

#line 16
                                                     set                                                        
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.DmText>(this,_Mobilize_References,2,this.medication_t_k__BackingField,(Mobilize.Web.DmText)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_medication_t;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_medication_t;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.medication_t_k__BackingField=(Mobilize.Web.DmText)value;} 
#line 16
                                                          }

#line 17

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.DmColumn medication_k__BackingField;
#line 19


      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn medication 
#line 19
                                              { 
#line 19
                                                get                                                   
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_medication)<=0){this.medication_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.DmColumn>(this,_Mobilize_References,3);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_medication;;} return this.medication_k__BackingField; } 
#line 19

#line 19
                                                     set                                                        
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.DmColumn>(this,_Mobilize_References,3,this.medication_k__BackingField,(Mobilize.Web.DmColumn)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_medication;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_medication;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.medication_k__BackingField=(Mobilize.Web.DmColumn)value;} 
#line 19
                                                          }

#line 20

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.DmButton b_1_k__BackingField;
#line 22


      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmButton b_1 
#line 22
                                       { 
#line 22
                                         get                                            
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_b_1)<=0){this.b_1_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.DmButton>(this,_Mobilize_References,4);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_b_1;;} return this.b_1_k__BackingField; } 
#line 22

#line 22
                                              set                                                 
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.DmButton>(this,_Mobilize_References,4,this.b_1_k__BackingField,(Mobilize.Web.DmButton)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_b_1;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_b_1;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.b_1_k__BackingField=(Mobilize.Web.DmButton)value;} 
#line 22
                                                   }

#line 23

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.DmText t_search_k__BackingField;
#line 25


      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText t_search 
#line 25
                                          { 
#line 25
                                            get                                               
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_t_search)<=0){this.t_search_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.DmText>(this,_Mobilize_References,5);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_t_search;;} return this.t_search_k__BackingField; } 
#line 25

#line 25
                                                 set                                                    
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.DmText>(this,_Mobilize_References,5,this.t_search_k__BackingField,(Mobilize.Web.DmText)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_t_search;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_t_search;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.t_search_k__BackingField=(Mobilize.Web.DmText)value;} 
#line 25
                                                      }

#line 26

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.DmColumn searchby_k__BackingField;
#line 28


      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn searchby 
#line 28
                                            { 
#line 28
                                              get                                                 
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_searchby)<=0){this.searchby_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.DmColumn>(this,_Mobilize_References,6);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_searchby;;} return this.searchby_k__BackingField; } 
#line 28

#line 28
                                                   set                                                      
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.DmColumn>(this,_Mobilize_References,6,this.searchby_k__BackingField,(Mobilize.Web.DmColumn)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_searchby;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_searchby;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.searchby_k__BackingField=(Mobilize.Web.DmColumn)value;} 
#line 28
                                                        }

#line 29


      public d_searchprescription()
      : base()
      {
         this.Units = Mobilize.Web.CaseExtensions.String("0");
         this.Color = Mobilize.Web.CaseExtensions.String("1073741824");
         this.Processing = Mobilize.Web.CaseExtensions.String("0");
         this.PrintSpecification.PrinterName = "";
         this.PrintSpecification.DocumentName = "";
         this.PrintSpecification.Orientation = Mobilize.Web.CaseExtensions.String("0");
         this.PrintSpecification.Margin.Left = 110;
         this.PrintSpecification.Margin.Right = 110;
         this.PrintSpecification.Margin.Top = 96;
         this.PrintSpecification.Margin.Bottom = 96;
         this.PrintSpecification.Paper.Source = 0;
         this.PrintSpecification.Paper.Size = 0;
         this.PrintSpecification.CanUseDefaultPrinter = true;
         this.PrintSpecification.Prompt = false;
         this.PrintSpecification.Buttons = false;
         this.PrintSpecification.ClipText = false;
         this.PrintSpecification.OverridePrintJob = false;
         this.PrintSpecification.Collate = true;
         this.Header.Height = 0;
         this.Header.Color = "536870912";
         this.Summary.Height = 0;
         this.Summary.Color = "536870912";
         this.Footer.Height = 0;
         this.Footer.Color = "536870912";
         this.Detail.Height = 784;
         this.Detail.Color = "536870912";
         var patient_db1 = new Mobilize.Web.DB.Column();
         patient_db1.Type = Mobilize.Web.CaseExtensions.String("char(250)");
         patient_db1.UpdateWhereClause = true;
         patient_db1.Name = Mobilize.Web.CaseExtensions.String("patient");
         patient_db1.DbName = "patient";
         var searchby_db2 = new Mobilize.Web.DB.Column();
         searchby_db2.Type = Mobilize.Web.CaseExtensions.String("number");
         searchby_db2.UpdateWhereClause = true;
         searchby_db2.Name = Mobilize.Web.CaseExtensions.String("searchby");
         searchby_db2.DbName = "name_1";
         searchby_db2.Values = "Patient Name\t1/Medication Name\t2/";
         var medication_db3 = new Mobilize.Web.DB.Column();
         medication_db3.Type = Mobilize.Web.CaseExtensions.String("char(250)");
         medication_db3.UpdateWhereClause = true;
         medication_db3.Name = Mobilize.Web.CaseExtensions.String("medication");
         medication_db3.DbName = "medication";
         this.patient_t = new Mobilize.Web.DmText();
         this.patient_t.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.patient_t.Alignment = 1;
         this.patient_t.Text = "Patient:";
         this.patient_t.Border = 0;
         this.patient_t.Color = "33554432";
         this.patient_t.X = 128;
         this.patient_t.Y = 88;
         this.patient_t.Height = 64;
         this.patient_t.Width = 320;
         this.patient_t.Name = Mobilize.Web.CaseExtensions.String("patient_t");
         this.patient_t.Visible = true;
         this.patient_t.Font.FontFace = "Tahoma";
         this.patient_t.Font.Height = -10;
         this.patient_t.Font.Weight = 400;
         this.patient_t.Font.FontFamily = "2";
         this.patient_t.Font.Pitch = "2";
         this.patient_t.Font.Charset = "0";
         this.patient_t.Background.Mode = 1;
         this.patient_t.Background.Color = "536870912";
         this.patient = new Mobilize.Web.DmColumn();
         this.patient.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.patient.Id = 1;
         this.patient.Alignment = 0;
         this.patient.TabSequence = 10;
         this.patient.Border = 4;
         this.patient.Color = "33554432";
         this.patient.X = 485;
         this.patient.Y = 88;
         this.patient.Height = 76;
         this.patient.Width = 1445;
         this.patient.Format = "[general]";
         this.patient.Name = Mobilize.Web.CaseExtensions.String("patient");
         this.patient.Visible = true;
         this.patient.Edit.Limit = 0;
         this.patient.Edit.Case = "any";
         this.patient.Edit.FocusRectangle = false;
         this.patient.Edit.AutoSelect = false;
         this.patient.Font.FontFace = "Tahoma";
         this.patient.Font.Height = -10;
         this.patient.Font.Weight = 400;
         this.patient.Font.FontFamily = "2";
         this.patient.Font.Pitch = "2";
         this.patient.Font.Charset = "0";
         this.patient.Background.Mode = 1;
         this.patient.Background.Color = "536870912";
         this.patient.EditMask.MaskDataType = Mobilize.Web.MaskDataType.StringMask;
         this.medication_t = new Mobilize.Web.DmText();
         this.medication_t.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.medication_t.Alignment = 1;
         this.medication_t.Text = "Medication:";
         this.medication_t.Border = 0;
         this.medication_t.Color = "33554432";
         this.medication_t.X = 128;
         this.medication_t.Y = 224;
         this.medication_t.Height = 64;
         this.medication_t.Width = 320;
         this.medication_t.Name = Mobilize.Web.CaseExtensions.String("medication_t");
         this.medication_t.Visible = true;
         this.medication_t.Font.FontFace = "Tahoma";
         this.medication_t.Font.Height = -10;
         this.medication_t.Font.Weight = 400;
         this.medication_t.Font.FontFamily = "2";
         this.medication_t.Font.Pitch = "2";
         this.medication_t.Font.Charset = "0";
         this.medication_t.Background.Mode = 1;
         this.medication_t.Background.Color = "536870912";
         this.medication = new Mobilize.Web.DmColumn();
         this.medication.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.medication.Id = 3;
         this.medication.Alignment = 0;
         this.medication.TabSequence = 20;
         this.medication.Border = 4;
         this.medication.Color = "33554432";
         this.medication.X = 489;
         this.medication.Y = 224;
         this.medication.Height = 76;
         this.medication.Width = 1435;
         this.medication.Format = "[general]";
         this.medication.Name = Mobilize.Web.CaseExtensions.String("medication");
         this.medication.Visible = true;
         this.medication.Edit.Limit = 0;
         this.medication.Edit.Case = "any";
         this.medication.Edit.FocusRectangle = false;
         this.medication.Edit.AutoSelect = true;
         this.medication.Edit.AutoHScroll = true;
         this.medication.Font.FontFace = "Tahoma";
         this.medication.Font.Height = -10;
         this.medication.Font.Weight = 400;
         this.medication.Font.FontFamily = "2";
         this.medication.Font.Pitch = "2";
         this.medication.Font.Charset = "0";
         this.medication.Background.Mode = 1;
         this.medication.Background.Color = "536870912";
         this.medication.EditMask.MaskDataType = Mobilize.Web.MaskDataType.StringMask;
         this.b_1 = new Mobilize.Web.DmButton();
         this.b_1.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.b_1.Text = "Search";
         this.b_1.Border = 0;
         this.b_1.Color = "33554432";
         this.b_1.X = 1605;
         this.b_1.Y = 488;
         this.b_1.Height = 120;
         this.b_1.Width = 320;
         this.b_1.VTextAlign = 0;
         this.b_1.HTextAlign = 0;
         this.b_1.Name = Mobilize.Web.CaseExtensions.String("b_1");
         this.b_1.Visible = true;
         this.b_1.Font.FontFace = "Tahoma";
         this.b_1.Font.Height = -10;
         this.b_1.Font.Weight = 400;
         this.b_1.Font.FontFamily = "2";
         this.b_1.Font.Pitch = "2";
         this.b_1.Font.Charset = "0";
         this.b_1.Background.Mode = 2;
         this.b_1.Background.Color = "67108864";
         this.t_search = new Mobilize.Web.DmText();
         this.t_search.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.t_search.Alignment = 0;
         this.t_search.Text = "Search By:";
         this.t_search.Border = 0;
         this.t_search.Color = "33554432";
         this.t_search.X = 169;
         this.t_search.Y = 360;
         this.t_search.Height = 64;
         this.t_search.Width = 283;
         this.t_search.Name = Mobilize.Web.CaseExtensions.String("t_search");
         this.t_search.Visible = true;
         this.t_search.Font.FontFace = "Tahoma";
         this.t_search.Font.Height = -10;
         this.t_search.Font.Weight = 400;
         this.t_search.Font.FontFamily = "2";
         this.t_search.Font.Pitch = "2";
         this.t_search.Font.Charset = "0";
         this.t_search.Background.Mode = 2;
         this.t_search.Background.Color = "1073741824";
         this.searchby = new Mobilize.Web.DmColumn();
         this.searchby.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.searchby.Id = 2;
         this.searchby.Alignment = 0;
         this.searchby.TabSequence = 30;
         this.searchby.Border = 0;
         this.searchby.Color = "33554432";
         this.searchby.X = 133;
         this.searchby.Y = 452;
         this.searchby.Height = 160;
         this.searchby.Width = 571;
         this.searchby.Format = "[general]";
         this.searchby.Name = Mobilize.Web.CaseExtensions.String("searchby");
         this.searchby.Visible = true;
         this.searchby.RadioButtons.Columns = 1;
         this.searchby.Font.FontFace = "Tahoma";
         this.searchby.Font.Height = -10;
         this.searchby.Font.Weight = 400;
         this.searchby.Font.FontFamily = "2";
         this.searchby.Font.Pitch = "2";
         this.searchby.Font.Charset = "0";
         this.searchby.Background.Mode = 1;
         this.searchby.Background.Color = "536870912";
         this.searchby.EditMask.MaskDataType = Mobilize.Web.MaskDataType.NumericMask;
         this.AddColumns(new Mobilize.Web.DB.Column[] { patient_db1, searchby_db2, medication_db3 });
         this.AddControls(new Mobilize.Web.DmControl[] { this.patient_t, this.patient, this.medication_t, this.medication, this.b_1, this.t_search, this.searchby });
         this.PopulateRadioButtons();
      }
   }

}
#pragma warning restore
