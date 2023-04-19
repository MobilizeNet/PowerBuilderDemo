namespace multicontroldemo
{

   [Mobilize.WebMap.Common.Attributes.Observable]
   public partial class d_no_data
      : Mobilize.Web.DataManager, Mobilize.Web.IDataManager
   {

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText field1_t { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn field1 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText field2_t { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn field2 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText field3_t { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn field3 { get; set; }


      public d_no_data()
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
         this.Detail.Height = 416;
         this.Detail.Color = "536870912";
         var field1_db1 = new Mobilize.Web.DB.Column();
         field1_db1.Type = Mobilize.Web.CaseExtensions.String("char(10)");
         field1_db1.UpdateWhereClause = true;
         field1_db1.Name = Mobilize.Web.CaseExtensions.String("field1");
         field1_db1.DbName = "field1";
         var field2_db2 = new Mobilize.Web.DB.Column();
         field2_db2.Type = Mobilize.Web.CaseExtensions.String("char(10)");
         field2_db2.UpdateWhereClause = true;
         field2_db2.Name = Mobilize.Web.CaseExtensions.String("field2");
         field2_db2.DbName = "field2";
         var field3_db3 = new Mobilize.Web.DB.Column();
         field3_db3.Type = Mobilize.Web.CaseExtensions.String("char(10)");
         field3_db3.UpdateWhereClause = true;
         field3_db3.Name = Mobilize.Web.CaseExtensions.String("field3");
         field3_db3.DbName = "field3";
         this.field1_t = new Mobilize.Web.DmText();
         this.field1_t.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.field1_t.Alignment = 1;
         this.field1_t.Text = "Field1:";
         this.field1_t.Border = 0;
         this.field1_t.Color = "33554432";
         this.field1_t.X = 37;
         this.field1_t.Y = 4;
         this.field1_t.Height = 64;
         this.field1_t.Width = 183;
         this.field1_t.Name = Mobilize.Web.CaseExtensions.String("field1_t");
         this.field1_t.Visible = true;
         this.field1_t.Font.FontFace = "Tahoma";
         this.field1_t.Font.Height = -10;
         this.field1_t.Font.Weight = 400;
         this.field1_t.Font.FontFamily = "2";
         this.field1_t.Font.Pitch = "2";
         this.field1_t.Font.Charset = "0";
         this.field1_t.Background.Mode = 1;
         this.field1_t.Background.Color = "536870912";
         this.field1 = new Mobilize.Web.DmColumn();
         this.field1.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.field1.Id = 1;
         this.field1.Alignment = 0;
         this.field1.TabSequence = 10;
         this.field1.Border = 0;
         this.field1.Color = "33554432";
         this.field1.X = 256;
         this.field1.Y = 4;
         this.field1.Height = 76;
         this.field1.Width = 274;
         this.field1.Format = "[general]";
         this.field1.Name = Mobilize.Web.CaseExtensions.String("field1");
         this.field1.Visible = true;
         this.field1.Edit.Limit = 0;
         this.field1.Edit.Case = "any";
         this.field1.Edit.FocusRectangle = false;
         this.field1.Edit.AutoSelect = true;
         this.field1.Edit.NilIsNull = true;
         this.field1.Edit.AutoHScroll = true;
         this.field1.Font.FontFace = "Tahoma";
         this.field1.Font.Height = -10;
         this.field1.Font.Weight = 400;
         this.field1.Font.FontFamily = "2";
         this.field1.Font.Pitch = "2";
         this.field1.Font.Charset = "0";
         this.field1.Background.Mode = 1;
         this.field1.Background.Color = "536870912";
         this.field1.EditMask.MaskDataType = Mobilize.Web.MaskDataType.StringMask;
         this.field2_t = new Mobilize.Web.DmText();
         this.field2_t.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.field2_t.Alignment = 1;
         this.field2_t.Text = "Field2:";
         this.field2_t.Border = 0;
         this.field2_t.Color = "33554432";
         this.field2_t.X = 37;
         this.field2_t.Y = 140;
         this.field2_t.Height = 64;
         this.field2_t.Width = 183;
         this.field2_t.Name = Mobilize.Web.CaseExtensions.String("field2_t");
         this.field2_t.Visible = true;
         this.field2_t.Font.FontFace = "Tahoma";
         this.field2_t.Font.Height = -10;
         this.field2_t.Font.Weight = 400;
         this.field2_t.Font.FontFamily = "2";
         this.field2_t.Font.Pitch = "2";
         this.field2_t.Font.Charset = "0";
         this.field2_t.Background.Mode = 1;
         this.field2_t.Background.Color = "536870912";
         this.field2 = new Mobilize.Web.DmColumn();
         this.field2.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.field2.Id = 2;
         this.field2.Alignment = 0;
         this.field2.TabSequence = 20;
         this.field2.Border = 0;
         this.field2.Color = "33554432";
         this.field2.X = 256;
         this.field2.Y = 140;
         this.field2.Height = 76;
         this.field2.Width = 274;
         this.field2.Format = "[general]";
         this.field2.Name = Mobilize.Web.CaseExtensions.String("field2");
         this.field2.Visible = true;
         this.field2.Edit.Limit = 0;
         this.field2.Edit.Case = "any";
         this.field2.Edit.FocusRectangle = false;
         this.field2.Edit.AutoSelect = true;
         this.field2.Edit.AutoHScroll = true;
         this.field2.Font.FontFace = "Tahoma";
         this.field2.Font.Height = -10;
         this.field2.Font.Weight = 400;
         this.field2.Font.FontFamily = "2";
         this.field2.Font.Pitch = "2";
         this.field2.Font.Charset = "0";
         this.field2.Background.Mode = 1;
         this.field2.Background.Color = "536870912";
         this.field2.EditMask.MaskDataType = Mobilize.Web.MaskDataType.StringMask;
         this.field3_t = new Mobilize.Web.DmText();
         this.field3_t.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.field3_t.Alignment = 1;
         this.field3_t.Text = "Field3:";
         this.field3_t.Border = 0;
         this.field3_t.Color = "33554432";
         this.field3_t.X = 37;
         this.field3_t.Y = 276;
         this.field3_t.Height = 64;
         this.field3_t.Width = 183;
         this.field3_t.Name = Mobilize.Web.CaseExtensions.String("field3_t");
         this.field3_t.Visible = true;
         this.field3_t.Font.FontFace = "Tahoma";
         this.field3_t.Font.Height = -10;
         this.field3_t.Font.Weight = 400;
         this.field3_t.Font.FontFamily = "2";
         this.field3_t.Font.Pitch = "2";
         this.field3_t.Font.Charset = "0";
         this.field3_t.Background.Mode = 1;
         this.field3_t.Background.Color = "536870912";
         this.field3 = new Mobilize.Web.DmColumn();
         this.field3.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.field3.Id = 3;
         this.field3.Alignment = 0;
         this.field3.TabSequence = 30;
         this.field3.Border = 0;
         this.field3.Color = "33554432";
         this.field3.X = 256;
         this.field3.Y = 276;
         this.field3.Height = 76;
         this.field3.Width = 274;
         this.field3.Format = "[general]";
         this.field3.Name = Mobilize.Web.CaseExtensions.String("field3");
         this.field3.Visible = true;
         this.field3.Edit.Limit = 0;
         this.field3.Edit.Case = "any";
         this.field3.Edit.FocusRectangle = false;
         this.field3.Edit.AutoSelect = true;
         this.field3.Edit.AutoHScroll = true;
         this.field3.Font.FontFace = "Tahoma";
         this.field3.Font.Height = -10;
         this.field3.Font.Weight = 400;
         this.field3.Font.FontFamily = "2";
         this.field3.Font.Pitch = "2";
         this.field3.Font.Charset = "0";
         this.field3.Background.Mode = 1;
         this.field3.Background.Color = "536870912";
         this.field3.EditMask.MaskDataType = Mobilize.Web.MaskDataType.StringMask;
         this.AddColumns(new Mobilize.Web.DB.Column[] { field1_db1, field2_db2, field3_db3 });
         this.AddControls(new Mobilize.Web.DmControl[] { this.field1_t, this.field1, this.field2_t, this.field2, this.field3_t, this.field3 });
         this.PopulateRadioButtons();
      }
   }

}