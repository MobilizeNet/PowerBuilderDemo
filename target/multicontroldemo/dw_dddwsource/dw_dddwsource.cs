namespace multicontroldemo
{

   [Mobilize.WebMap.Common.Attributes.Observable]
   public partial class dw_dddwsource
      : Mobilize.Web.DataManager, Mobilize.Web.IDataManager
   {

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText type_value_t { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn type_name { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn type_desc { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn type_value { get; set; }


      public dw_dddwsource()
      : base()
      {
         this.Units = Mobilize.Web.CaseExtensions.String("0");
         this.Color = Mobilize.Web.CaseExtensions.String("1073741824");
         this.Processing = Mobilize.Web.CaseExtensions.String("1");
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
         this.Detail.Height = 80;
         this.Detail.Color = "536870912";
         var type_value_db1 = new Mobilize.Web.DB.Column();
         type_value_db1.Type = Mobilize.Web.CaseExtensions.String("char(10)");
         type_value_db1.UpdateWhereClause = true;
         type_value_db1.Name = Mobilize.Web.CaseExtensions.String("type_value");
         type_value_db1.DbName = "type_value";
         var type_name_db2 = new Mobilize.Web.DB.Column();
         type_name_db2.Type = Mobilize.Web.CaseExtensions.String("char(20)");
         type_name_db2.UpdateWhereClause = true;
         type_name_db2.Name = Mobilize.Web.CaseExtensions.String("type_name");
         type_name_db2.DbName = "type_name";
         var type_desc_db3 = new Mobilize.Web.DB.Column();
         type_desc_db3.Type = Mobilize.Web.CaseExtensions.String("char(50)");
         type_desc_db3.UpdateWhereClause = true;
         type_desc_db3.Name = Mobilize.Web.CaseExtensions.String("type_desc");
         type_desc_db3.DbName = "type_desc";
         this.type_value_t = new Mobilize.Web.DmText();
         this.type_value_t.Band = Mobilize.Web.CaseExtensions.String("header");
         this.type_value_t.Alignment = 0;
         this.type_value_t.Text = "Type Value";
         this.type_value_t.Border = 0;
         this.type_value_t.Color = "33554432";
         this.type_value_t.X = 1815;
         this.type_value_t.Y = 4;
         this.type_value_t.Height = 64;
         this.type_value_t.Width = 334;
         this.type_value_t.Name = Mobilize.Web.CaseExtensions.String("type_value_t");
         this.type_value_t.Visible = true;
         this.type_value_t.Font.FontFace = "Tahoma";
         this.type_value_t.Font.Height = -10;
         this.type_value_t.Font.Weight = 400;
         this.type_value_t.Font.FontFamily = "2";
         this.type_value_t.Font.Pitch = "2";
         this.type_value_t.Font.Charset = "0";
         this.type_value_t.Background.Mode = 1;
         this.type_value_t.Background.Color = "536870912";
         this.type_name = new Mobilize.Web.DmColumn();
         this.type_name.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.type_name.Id = 2;
         this.type_name.Alignment = 0;
         this.type_name.TabSequence = 20;
         this.type_name.Border = 0;
         this.type_name.Color = "33554432";
         this.type_name.X = 14;
         this.type_name.Y = 8;
         this.type_name.Height = 76;
         this.type_name.Width = 1061;
         this.type_name.Format = "[general]";
         this.type_name.Name = Mobilize.Web.CaseExtensions.String("type_name");
         this.type_name.Visible = true;
         this.type_name.Edit.Limit = 0;
         this.type_name.Edit.Case = "any";
         this.type_name.Edit.FocusRectangle = false;
         this.type_name.Edit.AutoSelect = true;
         this.type_name.Edit.AutoHScroll = true;
         this.type_name.Font.FontFace = "Tahoma";
         this.type_name.Font.Height = -10;
         this.type_name.Font.Weight = 400;
         this.type_name.Font.FontFamily = "2";
         this.type_name.Font.Pitch = "2";
         this.type_name.Font.Charset = "0";
         this.type_name.Background.Mode = 1;
         this.type_name.Background.Color = "536870912";
         this.type_name.EditMask.MaskDataType = Mobilize.Web.MaskDataType.StringMask;
         this.type_desc = new Mobilize.Web.DmColumn();
         this.type_desc.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.type_desc.Id = 3;
         this.type_desc.Alignment = 0;
         this.type_desc.TabSequence = 30;
         this.type_desc.Border = 0;
         this.type_desc.Color = "33554432";
         this.type_desc.X = 1088;
         this.type_desc.Y = 8;
         this.type_desc.Height = 76;
         this.type_desc.Width = 718;
         this.type_desc.Format = "[general]";
         this.type_desc.Name = Mobilize.Web.CaseExtensions.String("type_desc");
         this.type_desc.Visible = true;
         this.type_desc.Edit.Limit = 0;
         this.type_desc.Edit.Case = "any";
         this.type_desc.Edit.FocusRectangle = false;
         this.type_desc.Edit.AutoSelect = true;
         this.type_desc.Edit.AutoHScroll = true;
         this.type_desc.Font.FontFace = "Tahoma";
         this.type_desc.Font.Height = -10;
         this.type_desc.Font.Weight = 400;
         this.type_desc.Font.FontFamily = "2";
         this.type_desc.Font.Pitch = "2";
         this.type_desc.Font.Charset = "0";
         this.type_desc.Background.Mode = 1;
         this.type_desc.Background.Color = "536870912";
         this.type_desc.EditMask.MaskDataType = Mobilize.Web.MaskDataType.StringMask;
         this.type_value = new Mobilize.Web.DmColumn();
         this.type_value.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.type_value.Id = 1;
         this.type_value.Alignment = 0;
         this.type_value.TabSequence = 40;
         this.type_value.Border = 0;
         this.type_value.Color = "33554432";
         this.type_value.X = 1819;
         this.type_value.Y = 8;
         this.type_value.Height = 76;
         this.type_value.Width = 329;
         this.type_value.Format = "[general]";
         this.type_value.Name = Mobilize.Web.CaseExtensions.String("type_value");
         this.type_value.Visible = true;
         this.type_value.Edit.Limit = 0;
         this.type_value.Edit.Case = "any";
         this.type_value.Edit.FocusRectangle = false;
         this.type_value.Edit.AutoSelect = false;
         this.type_value.Font.FontFace = "Tahoma";
         this.type_value.Font.Height = -10;
         this.type_value.Font.Weight = 400;
         this.type_value.Font.FontFamily = "2";
         this.type_value.Font.Pitch = "2";
         this.type_value.Font.Charset = "0";
         this.type_value.Background.Mode = 1;
         this.type_value.Background.Color = "536870912";
         this.type_value.EditMask.MaskDataType = Mobilize.Web.MaskDataType.StringMask;
         this.AddColumns(new Mobilize.Web.DB.Column[] { type_value_db1, type_name_db2, type_desc_db3 });
         this.AddControls(new Mobilize.Web.DmControl[] { this.type_value_t, this.type_name, this.type_desc, this.type_value });
         this.AddData(new object[] { "G", "Granted", "All permissions are given", "P", "Private", "Only internal permissions", "J", "Junior", "Basic permissions ", "S", "Secure", "Safe Mode", "M", "Master", "All permissions and modify", "E", "Executive", "Just Financial", "R", "Remote", "Remote Connections", "F", "Financial", "Accounting processes ", "D", "Director", "Assigments" });
         this.PopulateRadioButtons();
      }
   }

}