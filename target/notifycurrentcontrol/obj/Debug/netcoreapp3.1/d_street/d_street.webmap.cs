#pragma warning disable
#line 1 "d_street\\d_street.cs"
#pragma warning disable
#line 1 "d_street\\d_street.cs"
namespace notifycurrentcontrol
{

   [Mobilize.WebMap.Common.Attributes.Observable]
   public partial class d_street
      : Mobilize.Web.DataManager, Mobilize.Web.IDataManager
   {

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.DmText id_t_k__BackingField;
#line 10


      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText id_t 
#line 10
                                      { 
#line 10
                                        get                                           
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_id_t)<=0){this.id_t_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.DmText>(this,_Mobilize_References,0);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_id_t;;} return this.id_t_k__BackingField; } 
#line 10

#line 10
                                             set                                                
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.DmText>(this,_Mobilize_References,0,this.id_t_k__BackingField,(Mobilize.Web.DmText)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_id_t;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_id_t;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.id_t_k__BackingField=(Mobilize.Web.DmText)value;} 
#line 10
                                                  }

#line 11

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.DmText street_t_k__BackingField;
#line 13


      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText street_t 
#line 13
                                          { 
#line 13
                                            get                                               
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_street_t)<=0){this.street_t_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.DmText>(this,_Mobilize_References,1);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_street_t;;} return this.street_t_k__BackingField; } 
#line 13

#line 13
                                                 set                                                    
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.DmText>(this,_Mobilize_References,1,this.street_t_k__BackingField,(Mobilize.Web.DmText)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_street_t;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_street_t;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.street_t_k__BackingField=(Mobilize.Web.DmText)value;} 
#line 13
                                                      }

#line 14

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.DmColumn _id_k__BackingField;
#line 16


      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn _id 
#line 16
                                       { 
#line 16
                                         get                                            
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded__id)<=0){this._id_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.DmColumn>(this,_Mobilize_References,2);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded__id;;} return this._id_k__BackingField; } 
#line 16

#line 16
                                              set                                                 
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.DmColumn>(this,_Mobilize_References,2,this._id_k__BackingField,(Mobilize.Web.DmColumn)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty__id;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded__id;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this._id_k__BackingField=(Mobilize.Web.DmColumn)value;} 
#line 16
                                                   }

#line 17

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private Mobilize.Web.DmColumn street_k__BackingField;
#line 19


      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn street 
#line 19
                                          { 
#line 19
                                            get                                               
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_street)<=0){this.street_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.DmColumn>(this,_Mobilize_References,3);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_street;;} return this.street_k__BackingField; } 
#line 19

#line 19
                                                 set                                                    
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.DmColumn>(this,_Mobilize_References,3,this.street_k__BackingField,(Mobilize.Web.DmColumn)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_street;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_street;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.street_k__BackingField=(Mobilize.Web.DmColumn)value;} 
#line 19
                                                      }

#line 20


      public d_street()
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
         this.Detail.Height = 280;
         this.Detail.Color = "536870912";
         var id_db1 = new Mobilize.Web.DB.Column();
         id_db1.Type = Mobilize.Web.CaseExtensions.String("char(10)");
         id_db1.UpdateWhereClause = true;
         id_db1.Name = Mobilize.Web.CaseExtensions.String("id");
         id_db1.DbName = "Id";
         var street_db2 = new Mobilize.Web.DB.Column();
         street_db2.Type = Mobilize.Web.CaseExtensions.String("char(10)");
         street_db2.UpdateWhereClause = true;
         street_db2.Name = Mobilize.Web.CaseExtensions.String("street");
         street_db2.DbName = "street";
         this.id_t = new Mobilize.Web.DmText();
         this.id_t.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.id_t.Alignment = 1;
         this.id_t.Text = "Id:";
         this.id_t.Border = 0;
         this.id_t.Color = "33554432";
         this.id_t.X = 37;
         this.id_t.Y = 4;
         this.id_t.Height = 64;
         this.id_t.Width = 192;
         this.id_t.Name = Mobilize.Web.CaseExtensions.String("id_t");
         this.id_t.Visible = true;
         this.id_t.Font.FontFace = "Tahoma";
         this.id_t.Font.Height = -10;
         this.id_t.Font.Weight = 400;
         this.id_t.Font.FontFamily = "2";
         this.id_t.Font.Pitch = "2";
         this.id_t.Font.Charset = "0";
         this.id_t.Background.Mode = 1;
         this.id_t.Background.Color = "536870912";
         this.street_t = new Mobilize.Web.DmText();
         this.street_t.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.street_t.Alignment = 1;
         this.street_t.Text = "Street:";
         this.street_t.Border = 0;
         this.street_t.Color = "33554432";
         this.street_t.X = 37;
         this.street_t.Y = 140;
         this.street_t.Height = 64;
         this.street_t.Width = 192;
         this.street_t.Name = Mobilize.Web.CaseExtensions.String("street_t");
         this.street_t.Visible = true;
         this.street_t.Font.FontFace = "Tahoma";
         this.street_t.Font.Height = -10;
         this.street_t.Font.Weight = 400;
         this.street_t.Font.FontFamily = "2";
         this.street_t.Font.Pitch = "2";
         this.street_t.Font.Charset = "0";
         this.street_t.Background.Mode = 1;
         this.street_t.Background.Color = "536870912";
         this._id = new Mobilize.Web.DmColumn();
         this._id.Band = Mobilize.Web.CaseExtensions.String("detail");
         this._id.Id = 1;
         this._id.Alignment = 0;
         this._id.TabSequence = 10;
         this._id.Border = 0;
         this._id.Color = "33554432";
         this._id.X = 265;
         this._id.Y = 4;
         this._id.Height = 76;
         this._id.Width = 338;
         this._id.Format = "[general]";
         this._id.Name = Mobilize.Web.CaseExtensions.String("id");
         this._id.Visible = true;
         this._id.Edit.Limit = 0;
         this._id.Edit.Case = "any";
         this._id.Edit.FocusRectangle = false;
         this._id.Edit.AutoSelect = true;
         this._id.Edit.AutoHScroll = true;
         this._id.Font.FontFace = "Tahoma";
         this._id.Font.Height = -10;
         this._id.Font.Weight = 400;
         this._id.Font.FontFamily = "2";
         this._id.Font.Pitch = "2";
         this._id.Font.Charset = "0";
         this._id.Background.Mode = 1;
         this._id.Background.Color = "536870912";
         this._id.EditMask.MaskDataType = Mobilize.Web.MaskDataType.StringMask;
         this.street = new Mobilize.Web.DmColumn();
         this.street.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.street.Id = 2;
         this.street.Alignment = 0;
         this.street.TabSequence = 20;
         this.street.Border = 0;
         this.street.Color = "33554432";
         this.street.X = 265;
         this.street.Y = 140;
         this.street.Height = 76;
         this.street.Width = 338;
         this.street.Format = "[general]";
         this.street.Name = Mobilize.Web.CaseExtensions.String("street");
         this.street.Visible = true;
         this.street.DdDm.DataManager = Mobilize.Web.CaseExtensions.String("d_ddddw");
         this.street.DdDm.DisplayColumn = Mobilize.Web.CaseExtensions.String("name");
         this.street.DdDm.DataColumn = Mobilize.Web.CaseExtensions.String("id");
         this.street.DdDm.PercentWidth = 0;
         this.street.DdDm.Lines = 0;
         this.street.DdDm.Limit = 0;
         this.street.DdDm.AllowEdit = false;
         this.street.DdDm.UseAsBorder = true;
         this.street.DdDm.Case = Mobilize.Web.CaseExtensions.String("any");
         this.street.Font.FontFace = "Tahoma";
         this.street.Font.Height = -10;
         this.street.Font.Weight = 400;
         this.street.Font.FontFamily = "2";
         this.street.Font.Pitch = "2";
         this.street.Font.Charset = "0";
         this.street.Background.Mode = 1;
         this.street.Background.Color = "536870912";
         this.street.EditMask.MaskDataType = Mobilize.Web.MaskDataType.StringMask;
         this.AddColumns(new Mobilize.Web.DB.Column[] { id_db1, street_db2 });
         this.AddControls(new Mobilize.Web.DmControl[] { this.id_t, this.street_t, this._id, this.street });
         this.AddData(new object[] { "1", "1", "2", "2", "3", "3" });
         this.PopulateRadioButtons();
      }
   }

}
#pragma warning restore
