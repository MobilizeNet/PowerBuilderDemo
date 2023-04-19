#pragma warning disable
#line 1 "d_dddwprescription\\d_dddwprescription.cs"
#pragma warning disable
#line 1 "d_dddwprescription\\d_dddwprescription.cs"
namespace medicationcenter
{

   [Mobilize.WebMap.Common.Attributes.Observable]
   public partial class d_dddwprescription
      : Mobilize.Web.DataManager, Mobilize.Web.IDataManager
   {

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.DmColumn prescdata_k__BackingField;
#line 10


      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn prescdata 
#line 10
                                             { 
#line 10
                                               get                                                  
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_prescdata)<=0){this.prescdata_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.DmColumn>(this,_Mobilize_References,0);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_prescdata;;} return this.prescdata_k__BackingField; } 
#line 10

#line 10
                                                    set                                                       
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.DmColumn>(this,_Mobilize_References,0,this.prescdata_k__BackingField,(Mobilize.Web.DmColumn)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_prescdata;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_prescdata;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.prescdata_k__BackingField=(Mobilize.Web.DmColumn)value;} 
#line 10
                                                         }

#line 11


      public d_dddwprescription()
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
         this.Detail.Height = 76;
         this.Detail.Color = "536870912";
         var prescdata_db1 = new Mobilize.Web.DB.Column();
         prescdata_db1.Type = Mobilize.Web.CaseExtensions.String("char(250)");
         prescdata_db1.UpdateWhereClause = false;
         prescdata_db1.Name = Mobilize.Web.CaseExtensions.String("prescdata");
         prescdata_db1.DbName = "dose";
         var id_db2 = new Mobilize.Web.DB.Column();
         id_db2.Type = Mobilize.Web.CaseExtensions.String("number");
         id_db2.UpdateWhereClause = false;
         id_db2.Name = Mobilize.Web.CaseExtensions.String("id");
         id_db2.DbName = "id";
         this.prescdata = new Mobilize.Web.DmColumn();
         this.prescdata.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.prescdata.Id = 1;
         this.prescdata.Alignment = 0;
         this.prescdata.TabSequence = 32766;
         this.prescdata.Border = 0;
         this.prescdata.Color = "33554432";
         this.prescdata.X = 14;
         this.prescdata.Y = 4;
         this.prescdata.Height = 64;
         this.prescdata.Width = 2085;
         this.prescdata.Name = Mobilize.Web.CaseExtensions.String("prescdata");
         this.prescdata.Visible = true;
         this.prescdata.Edit.Limit = 0;
         this.prescdata.Edit.Case = "any";
         this.prescdata.Edit.FocusRectangle = false;
         this.prescdata.Edit.AutoSelect = false;
         this.prescdata.Edit.DisplayOnly = true;
         this.prescdata.Font.FontFace = "Tahoma";
         this.prescdata.Font.Height = -10;
         this.prescdata.Font.Weight = 400;
         this.prescdata.Font.FontFamily = "2";
         this.prescdata.Font.Pitch = "2";
         this.prescdata.Font.Charset = "0";
         this.AddColumns(new Mobilize.Web.DB.Column[] { prescdata_db1, id_db2 });
         this.AddControls(new Mobilize.Web.DmControl[] { this.prescdata });
         this.PopulateRadioButtons();
      }
   }

}
#pragma warning restore
