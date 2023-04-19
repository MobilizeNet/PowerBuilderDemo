namespace reports
{

   [Mobilize.WebMap.Common.Attributes.Observable]
   public partial class dw_product
      : Mobilize.Web.DataManager, Mobilize.Web.IDataManager
   {

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn _name { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn price { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn vendor { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText t_4 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText t_3 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText t_2 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText t_1 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn _id { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmCompute compute_1 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmCompute compute_2 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn category { get; set; }


      public dw_product()
      : base()
      {
         this.Units = Mobilize.Web.CaseExtensions.String("2");
         this.Color = Mobilize.Web.CaseExtensions.String("1073741824");
         this.Processing = Mobilize.Web.CaseExtensions.String("2");
         this.PrintSpecification.PrinterName = "";
         this.PrintSpecification.DocumentName = "";
         this.PrintSpecification.Orientation = Mobilize.Web.CaseExtensions.String("0");
         this.PrintSpecification.Margin.Left = 281;
         this.PrintSpecification.Margin.Right = 280;
         this.PrintSpecification.Margin.Top = 500;
         this.PrintSpecification.Margin.Bottom = 500;
         this.PrintSpecification.Paper.Source = 0;
         this.PrintSpecification.Paper.Size = 0;
         this.PrintSpecification.CanUseDefaultPrinter = true;
         this.PrintSpecification.Prompt = false;
         this.PrintSpecification.Buttons = false;
         this.PrintSpecification.ClipText = false;
         this.PrintSpecification.OverridePrintJob = false;
         this.PrintSpecification.Collate = true;
         this.Label.Name = "Laser Address 0.50 x 1.75 5267";
         this.Label.Width = 2500;
         this.Label.Height = 1500;
         this.Label.Rows = 6;
         this.Label.Rows.Spacing = 0;
         this.Label.Columns = 3;
         this.Label.Columns.Spacing = 100;
         this.Label.TopDown = false;
         this.Label.Sheet = true;
         this.Label.Shape = Mobilize.Web.CaseExtensions.String("roundrectangle");
         this.Label.EllipseHeight = 83;
         this.Label.EllipseWidth = 83;
         this.Detail.Height = 1500;
         this.Detail.Color = "536870912";
         var id_db1 = new Mobilize.Web.DB.Column();
         id_db1.Type = Mobilize.Web.CaseExtensions.String("char(10)");
         id_db1.UpdateWhereClause = true;
         id_db1.Name = Mobilize.Web.CaseExtensions.String("id");
         id_db1.DbName = "id";
         var name_db2 = new Mobilize.Web.DB.Column();
         name_db2.Type = Mobilize.Web.CaseExtensions.String("char(10)");
         name_db2.UpdateWhereClause = true;
         name_db2.Name = Mobilize.Web.CaseExtensions.String("name");
         name_db2.DbName = "Name";
         var category_db3 = new Mobilize.Web.DB.Column();
         category_db3.Type = Mobilize.Web.CaseExtensions.String("char(10)");
         category_db3.UpdateWhereClause = true;
         category_db3.Name = Mobilize.Web.CaseExtensions.String("category");
         category_db3.DbName = "category";
         var price_db4 = new Mobilize.Web.DB.Column();
         price_db4.Type = Mobilize.Web.CaseExtensions.String("decimal(2)");
         price_db4.UpdateWhereClause = true;
         price_db4.Name = Mobilize.Web.CaseExtensions.String("price");
         price_db4.DbName = "Price";
         var vendor_db5 = new Mobilize.Web.DB.Column();
         vendor_db5.Type = Mobilize.Web.CaseExtensions.String("char(10)");
         vendor_db5.UpdateWhereClause = true;
         vendor_db5.Name = Mobilize.Web.CaseExtensions.String("vendor");
         vendor_db5.DbName = "Vendor";
         this._name = new Mobilize.Web.DmColumn();
         this._name.Band = Mobilize.Web.CaseExtensions.String("detail");
         this._name.Id = 2;
         this._name.Alignment = 0;
         this._name.TabSequence = 32766;
         this._name.Border = 0;
         this._name.Color = "33554432";
         this._name.X = 4729;
         this._name.Y = 1010;
         this._name.Height = 197;
         this._name.Width = 625;
         this._name.Format = "[general]";
         this._name.Name = Mobilize.Web.CaseExtensions.String("name");
         this._name.Visible = true;
         this._name.Edit.Limit = 0;
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
         this.price = new Mobilize.Web.DmColumn();
         this.price.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.price.Id = 4;
         this.price.Alignment = 0;
         this.price.TabSequence = 32766;
         this.price.Border = 0;
         this.price.Color = "33554432";
         this.price.X = 4697;
         this.price.Y = 708;
         this.price.Height = 197;
         this.price.Width = 500;
         this.price.Format = "[general]";
         this.price.Name = Mobilize.Web.CaseExtensions.String("price");
         this.price.Visible = true;
         this.price.Edit.Limit = 0;
         this.price.Edit.Case = "any";
         this.price.Edit.FocusRectangle = false;
         this.price.Edit.AutoSelect = true;
         this.price.Edit.AutoHScroll = true;
         this.price.Font.FontFace = "Tahoma";
         this.price.Font.Height = -10;
         this.price.Font.Weight = 400;
         this.price.Font.FontFamily = "2";
         this.price.Font.Pitch = "2";
         this.price.Font.Charset = "0";
         this.price.Background.Mode = 1;
         this.price.Background.Color = "536870912";
         this.price.EditMask.MaskDataType = Mobilize.Web.MaskDataType.DecimalMask;
         this.vendor = new Mobilize.Web.DmColumn();
         this.vendor.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.vendor.Id = 5;
         this.vendor.Alignment = 0;
         this.vendor.TabSequence = 32766;
         this.vendor.Border = 0;
         this.vendor.Color = "33554432";
         this.vendor.X = 4770;
         this.vendor.Y = 1291;
         this.vendor.Height = 187;
         this.vendor.Width = 625;
         this.vendor.Format = "[general]";
         this.vendor.Name = Mobilize.Web.CaseExtensions.String("vendor");
         this.vendor.Visible = true;
         this.vendor.Edit.Limit = 0;
         this.vendor.Edit.Case = "any";
         this.vendor.Edit.FocusRectangle = false;
         this.vendor.Edit.AutoSelect = true;
         this.vendor.Edit.AutoHScroll = true;
         this.vendor.Font.FontFace = "Tahoma";
         this.vendor.Font.Height = -10;
         this.vendor.Font.Weight = 400;
         this.vendor.Font.FontFamily = "2";
         this.vendor.Font.Pitch = "2";
         this.vendor.Font.Charset = "0";
         this.vendor.Background.Mode = 1;
         this.vendor.Background.Color = "536870912";
         this.vendor.EditMask.MaskDataType = Mobilize.Web.MaskDataType.StringMask;
         this.t_4 = new Mobilize.Web.DmText();
         this.t_4.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.t_4.Alignment = 0;
         this.t_4.Text = "Category:";
         this.t_4.Border = 0;
         this.t_4.Color = "33554432";
         this.t_4.X = 145;
         this.t_4.Y = 1166;
         this.t_4.Height = 166;
         this.t_4.Width = 739;
         this.t_4.Name = Mobilize.Web.CaseExtensions.String("t_4");
         this.t_4.Visible = true;
         this.t_4.Font.FontFace = "Tahoma";
         this.t_4.Font.Height = -10;
         this.t_4.Font.Weight = 700;
         this.t_4.Font.FontFamily = "2";
         this.t_4.Font.Pitch = "2";
         this.t_4.Font.Charset = "0";
         this.t_4.Background.Mode = 2;
         this.t_4.Background.Color = "1073741824";
         this.t_3 = new Mobilize.Web.DmText();
         this.t_3.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.t_3.Alignment = 0;
         this.t_3.Text = "Price:";
         this.t_3.Border = 0;
         this.t_3.Color = "33554432";
         this.t_3.X = 197;
         this.t_3.Y = 885;
         this.t_3.Height = 166;
         this.t_3.Width = 645;
         this.t_3.Name = Mobilize.Web.CaseExtensions.String("t_3");
         this.t_3.Visible = true;
         this.t_3.Font.FontFace = "Tahoma";
         this.t_3.Font.Height = -10;
         this.t_3.Font.Weight = 700;
         this.t_3.Font.FontFamily = "2";
         this.t_3.Font.Pitch = "2";
         this.t_3.Font.Charset = "0";
         this.t_3.Background.Mode = 2;
         this.t_3.Background.Color = "1073741824";
         this.t_2 = new Mobilize.Web.DmText();
         this.t_2.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.t_2.Alignment = 0;
         this.t_2.Text = "Name:";
         this.t_2.Border = 0;
         this.t_2.Color = "33554432";
         this.t_2.X = 187;
         this.t_2.Y = 520;
         this.t_2.Height = 166;
         this.t_2.Width = 656;
         this.t_2.Name = Mobilize.Web.CaseExtensions.String("t_2");
         this.t_2.Visible = true;
         this.t_2.Font.FontFace = "Tahoma";
         this.t_2.Font.Height = -10;
         this.t_2.Font.Weight = 700;
         this.t_2.Font.FontFamily = "2";
         this.t_2.Font.Pitch = "2";
         this.t_2.Font.Charset = "0";
         this.t_2.Background.Mode = 2;
         this.t_2.Background.Color = "1073741824";
         this.t_1 = new Mobilize.Web.DmText();
         this.t_1.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.t_1.Alignment = 0;
         this.t_1.Text = "Product Code:";
         this.t_1.Border = 0;
         this.t_1.Color = "33554432";
         this.t_1.X = 166;
         this.t_1.Y = 166;
         this.t_1.Height = 312;
         this.t_1.Width = 656;
         this.t_1.Name = Mobilize.Web.CaseExtensions.String("t_1");
         this.t_1.Visible = true;
         this.t_1.Font.FontFace = "Tahoma";
         this.t_1.Font.Height = -10;
         this.t_1.Font.Weight = 700;
         this.t_1.Font.FontFamily = "2";
         this.t_1.Font.Pitch = "2";
         this.t_1.Font.Charset = "0";
         this.t_1.Background.Mode = 2;
         this.t_1.Background.Color = "1073741824";
         this._id = new Mobilize.Web.DmColumn();
         this._id.Band = Mobilize.Web.CaseExtensions.String("detail");
         this._id.Id = 1;
         this._id.Alignment = 0;
         this._id.TabSequence = 32766;
         this._id.Border = 0;
         this._id.Color = "33554432";
         this._id.X = 958;
         this._id.Y = 145;
         this._id.Height = 197;
         this._id.Width = 1312;
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
         this._id.Font.Underline = true;
         this._id.Background.Mode = 1;
         this._id.Background.Color = "536870912";
         this._id.EditMask.MaskDataType = Mobilize.Web.MaskDataType.StringMask;
         this.compute_1 = new Mobilize.Web.DmCompute();
         this.compute_1.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.compute_1.Alignment = 0;
         this.compute_1.Expression = "\"##\" + vendor  + \"-\" +  name ";
         this.compute_1.Border = 0;
         this.compute_1.Color = "33554432";
         this.compute_1.X = 968;
         this.compute_1.Y = 520;
         this.compute_1.Height = 281;
         this.compute_1.Width = 1302;
         this.compute_1.Format = "[GENERAL]";
         this.compute_1.Name = Mobilize.Web.CaseExtensions.String("compute_1");
         this.compute_1.Visible = true;
         this.compute_1.Font.FontFace = "Tahoma";
         this.compute_1.Font.Height = -10;
         this.compute_1.Font.Weight = 400;
         this.compute_1.Font.FontFamily = "2";
         this.compute_1.Font.Pitch = "2";
         this.compute_1.Font.Charset = "0";
         this.compute_1.Background.Mode = 1;
         this.compute_1.Background.Color = "536870912";
         this.compute_2 = new Mobilize.Web.DmCompute();
         this.compute_2.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.compute_2.Alignment = 0;
         this.compute_2.Expression = "\"$\" + string(price )";
         this.compute_2.Border = 0;
         this.compute_2.Color = "33554432";
         this.compute_2.X = 968;
         this.compute_2.Y = 875;
         this.compute_2.Height = 166;
         this.compute_2.Width = 1260;
         this.compute_2.Format = "[General]";
         this.compute_2.Name = Mobilize.Web.CaseExtensions.String("compute_2");
         this.compute_2.Visible = true;
         this.compute_2.Font.FontFace = "Tahoma";
         this.compute_2.Font.Height = -10;
         this.compute_2.Font.Weight = 400;
         this.compute_2.Font.FontFamily = "2";
         this.compute_2.Font.Pitch = "2";
         this.compute_2.Font.Charset = "0";
         this.compute_2.Background.Mode = 1;
         this.compute_2.Background.Color = "536870912";
         this.category = new Mobilize.Web.DmColumn();
         this.category.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.category.Id = 3;
         this.category.Alignment = 0;
         this.category.TabSequence = 32766;
         this.category.Border = 0;
         this.category.Color = "33554432";
         this.category.X = 937;
         this.category.Y = 1166;
         this.category.Height = 197;
         this.category.Width = 1281;
         this.category.Format = "[general]";
         this.category.Name = Mobilize.Web.CaseExtensions.String("category");
         this.category.Visible = true;
         this.category.Edit.Limit = 0;
         this.category.Edit.Case = "any";
         this.category.Edit.FocusRectangle = false;
         this.category.Edit.AutoSelect = true;
         this.category.Edit.AutoHScroll = true;
         this.category.Font.FontFace = "Tahoma";
         this.category.Font.Height = -10;
         this.category.Font.Weight = 400;
         this.category.Font.FontFamily = "2";
         this.category.Font.Pitch = "2";
         this.category.Font.Charset = "0";
         this.category.Background.Mode = 1;
         this.category.Background.Color = "536870912";
         this.category.EditMask.MaskDataType = Mobilize.Web.MaskDataType.StringMask;
         this.AddColumns(new Mobilize.Web.DB.Column[] { id_db1, name_db2, category_db3, price_db4, vendor_db5 });
         this.AddControls(new Mobilize.Web.DmControl[] { this._name, this.price, this.vendor, this.t_4, this.t_3, this.t_2, this.t_1, this._id, this.compute_1, this.compute_2, this.category });
         this.PopulateRadioButtons();
      }
   }

}