#pragma warning disable
#line 1 "dw_categories_freeform\\dw_categories_freeform.cs"
#pragma warning disable
#line 1 "dw_categories_freeform\\dw_categories_freeform.cs"
namespace pbj_webmapdemo
{

   [Mobilize.WebMap.Common.Attributes.Observable]
   public partial class dw_categories_freeform
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
private Mobilize.Web.DmText name_t_k__BackingField;
#line 13


      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText name_t 
#line 13
                                        { 
#line 13
                                          get                                             
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_name_t)<=0){this.name_t_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.DmText>(this,_Mobilize_References,1);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_name_t;;} return this.name_t_k__BackingField; } 
#line 13

#line 13
                                               set                                                  
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.DmText>(this,_Mobilize_References,1,this.name_t_k__BackingField,(Mobilize.Web.DmText)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_name_t;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_name_t;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.name_t_k__BackingField=(Mobilize.Web.DmText)value;} 
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
private Mobilize.Web.DmColumn _name_k__BackingField;
#line 19


      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn _name 
#line 19
                                         { 
#line 19
                                           get                                              
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded__name)<=0){this._name_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.Web.DmColumn>(this,_Mobilize_References,3);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded__name;;} return this._name_k__BackingField; } 
#line 19

#line 19
                                                set                                                   
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.Web.DmColumn>(this,_Mobilize_References,3,this._name_k__BackingField,(Mobilize.Web.DmColumn)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty__name;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded__name;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this._name_k__BackingField=(Mobilize.Web.DmColumn)value;} 
#line 19
                                                     }

#line 20


      public dw_categories_freeform()
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
         this.Header.Height = 80;
         this.Header.Color = "536870912";
         this.Summary.Height = 0;
         this.Summary.Color = "536870912";
         this.Footer.Height = 0;
         this.Footer.Color = "536870912";
         this.Detail.Height = 92;
         this.Detail.Color = "536870912";
         var id_db1 = new Mobilize.Web.DB.Column();
         id_db1.Type = Mobilize.Web.CaseExtensions.String("long");
         id_db1.Update = true;
         id_db1.UpdateWhereClause = true;
         id_db1.Key = Mobilize.Web.CaseExtensions.String("yes");
         id_db1.Name = Mobilize.Web.CaseExtensions.String("id");
         id_db1.DbName = "producttypes.id";
         var name_db2 = new Mobilize.Web.DB.Column();
         name_db2.Type = Mobilize.Web.CaseExtensions.String("char(16383)");
         name_db2.Update = true;
         name_db2.UpdateWhereClause = false;
         name_db2.Name = Mobilize.Web.CaseExtensions.String("name");
         name_db2.DbName = "producttypes.name";
         var code_db3 = new Mobilize.Web.DB.Column();
         code_db3.Type = Mobilize.Web.CaseExtensions.String("char(450)");
         code_db3.Update = true;
         code_db3.UpdateWhereClause = true;
         code_db3.Name = Mobilize.Web.CaseExtensions.String("code");
         code_db3.DbName = "producttypes.code";
         this.RetrieveStatement = "PBSELECT(TABLE(NAME=\"producttypes\") COLUMN(NAME=\"producttypes.id\")COLUMN(NAME=\"producttypes.name\")COLUMN(NAME=\"producttypes.code\"))";
         this.UpdateTableName = "producttypes";
         this.UpdateWhere = 1;
         this.UpdateKeyInPlace = false;
         this.id_t = new Mobilize.Web.DmText();
         this.id_t.Band = Mobilize.Web.CaseExtensions.String("header");
         this.id_t.Alignment = 2;
         this.id_t.Text = "Id";
         this.id_t.Border = 0;
         this.id_t.Color = "33554432";
         this.id_t.X = 14;
         this.id_t.Y = 8;
         this.id_t.Height = 64;
         this.id_t.Width = 329;
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
         this.name_t = new Mobilize.Web.DmText();
         this.name_t.Band = Mobilize.Web.CaseExtensions.String("header");
         this.name_t.Alignment = 2;
         this.name_t.Text = "Name";
         this.name_t.Border = 0;
         this.name_t.Color = "33554432";
         this.name_t.X = 357;
         this.name_t.Y = 8;
         this.name_t.Height = 64;
         this.name_t.Width = 2098;
         this.name_t.Name = Mobilize.Web.CaseExtensions.String("name_t");
         this.name_t.Visible = true;
         this.name_t.Font.FontFace = "Tahoma";
         this.name_t.Font.Height = -10;
         this.name_t.Font.Weight = 400;
         this.name_t.Font.FontFamily = "2";
         this.name_t.Font.Pitch = "2";
         this.name_t.Font.Charset = "0";
         this.name_t.Background.Mode = 1;
         this.name_t.Background.Color = "536870912";
         this._id = new Mobilize.Web.DmColumn();
         this._id.Band = Mobilize.Web.CaseExtensions.String("detail");
         this._id.Id = 1;
         this._id.Alignment = 1;
         this._id.TabSequence = 10;
         this._id.Border = 0;
         this._id.Color = "33554432";
         this._id.X = 14;
         this._id.Y = 8;
         this._id.Height = 76;
         this._id.Width = 329;
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
         this._name = new Mobilize.Web.DmColumn();
         this._name.Band = Mobilize.Web.CaseExtensions.String("detail");
         this._name.Id = 2;
         this._name.Alignment = 0;
         this._name.TabSequence = 20;
         this._name.Border = 0;
         this._name.Color = "33554432";
         this._name.X = 357;
         this._name.Y = 8;
         this._name.Height = 76;
         this._name.Width = 2098;
         this._name.Format = "[general]";
         this._name.Name = Mobilize.Web.CaseExtensions.String("name");
         this._name.Visible = true;
         this._name.Edit.Limit = 16383;
         this._name.Edit.Case = "any";
         this._name.Edit.FocusRectangle = false;
         this._name.Edit.AutoSelect = true;
         this._name.Edit.AutoHScroll = true;
         this._name.Font.FontFace = "Tahoma";
         this._name.Font.Height = -10;
         this._name.Font.Weight = 400;
         this._name.Font.FontFamily = "2";
         this._name.Font.Pitch = "2";
         this._name.Font.Charset = "0";
         this._name.Background.Mode = 1;
         this._name.Background.Color = "536870912";
         this._name.EditMask.MaskDataType = Mobilize.Web.MaskDataType.StringMask;
         this.AddColumns(new Mobilize.Web.DB.Column[] { id_db1, name_db2, code_db3 });
         this.AddControls(new Mobilize.Web.DmControl[] { this.id_t, this.name_t, this._id, this._name });
         this.PopulateRadioButtons();
      }
   }

}
#pragma warning restore
