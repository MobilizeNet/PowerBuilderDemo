#pragma warning disable
#line 1 "d_employee_dept_info_update_dddw\\d_employee_dept_info_update_dddw.cs"
#pragma warning disable
#line 1 "d_employee_dept_info_update_dddw\\d_employee_dept_info_update_dddw.cs"
namespace multicontroldemo
{

   [Mobilize.WebMap.Common.Attributes.Observable]
   public partial class d_employee_dept_info_update_dddw
      : Mobilize.Web.DataManager, Mobilize.Web.IDataManager
   {

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.DmColumn tdname_k__BackingField;
#line 10


      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn tdname 
#line 10
                                          { 
#line 10
                                            get                                               
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_tdname)<=0){this.tdname_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.DmColumn>(this,_Mobilize_References,0);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_tdname;;} return this.tdname_k__BackingField; } 
#line 10

#line 10
                                                 set                                                    
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.DmColumn>(this,_Mobilize_References,0,this.tdname_k__BackingField,(Mobilize.Web.DmColumn)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_tdname;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_tdname;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.tdname_k__BackingField=(Mobilize.Web.DmColumn)value;} 
#line 10
                                                      }

#line 11


      public d_employee_dept_info_update_dddw()
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
         this.Detail.Height = 92;
         this.Detail.Color = "536870912";
         var tdip_db1 = new Mobilize.Web.DB.Column();
         tdip_db1.Type = Mobilize.Web.CaseExtensions.String("number");
         tdip_db1.UpdateWhereClause = true;
         tdip_db1.Name = Mobilize.Web.CaseExtensions.String("tdip");
         tdip_db1.DbName = "tdip";
         var tdname_db2 = new Mobilize.Web.DB.Column();
         tdname_db2.Type = Mobilize.Web.CaseExtensions.String("char(20)");
         tdname_db2.UpdateWhereClause = true;
         tdname_db2.Name = Mobilize.Web.CaseExtensions.String("tdname");
         tdname_db2.DbName = "tdname";
         this.tdname = new Mobilize.Web.DmColumn();
         this.tdname.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.tdname.Id = 2;
         this.tdname.Alignment = 0;
         this.tdname.TabSequence = 20;
         this.tdname.Border = 0;
         this.tdname.Color = "33554432";
         this.tdname.X = 9;
         this.tdname.Y = 4;
         this.tdname.Height = 76;
         this.tdname.Width = 549;
         this.tdname.Format = "[general]";
         this.tdname.Name = Mobilize.Web.CaseExtensions.String("tdname");
         this.tdname.Visible = true;
         this.tdname.Edit.Limit = 0;
         this.tdname.Edit.Case = "any";
         this.tdname.Edit.FocusRectangle = false;
         this.tdname.Edit.AutoSelect = true;
         this.tdname.Edit.AutoHScroll = true;
         this.tdname.Font.FontFace = "Tahoma";
         this.tdname.Font.Height = -10;
         this.tdname.Font.Weight = 400;
         this.tdname.Font.FontFamily = "2";
         this.tdname.Font.Pitch = "2";
         this.tdname.Font.Charset = "0";
         this.tdname.Background.Mode = 1;
         this.tdname.Background.Color = "536870912";
         this.tdname.EditMask.MaskDataType = Mobilize.Web.MaskDataType.StringMask;
         this.AddColumns(new Mobilize.Web.DB.Column[] { tdip_db1, tdname_db2 });
         this.AddControls(new Mobilize.Web.DmControl[] { this.tdname });
         this.AddData(new object[] { 1, "IT", 2, "HR", 3, "ACC" });
         this.PopulateRadioButtons();
      }
   }

}
#pragma warning restore
