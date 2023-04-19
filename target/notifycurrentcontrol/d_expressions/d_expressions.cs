namespace notifycurrentcontrol
{

   [Mobilize.WebMap.Common.Attributes.Observable]
   public partial class d_expressions
      : Mobilize.Web.DataManager, Mobilize.Web.IDataManager
   {

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText id_t { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText street_t { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText t_1 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn _id { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn street { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmCompute compute_1 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmCompute compute_2 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText t_2 { get; set; }


      public d_expressions()
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
         this.Header.Height = 80;
         this.Header.Color = "536870912";
         this.Summary.Height = 0;
         this.Summary.Color = "536870912";
         this.Footer.Height = 0;
         this.Footer.Color = "536870912";
         this.Detail.Height = 92;
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
         name_db2.DbName = "name";
         var street_db3 = new Mobilize.Web.DB.Column();
         street_db3.Type = Mobilize.Web.CaseExtensions.String("char(10)");
         street_db3.UpdateWhereClause = true;
         street_db3.Name = Mobilize.Web.CaseExtensions.String("street");
         street_db3.DbName = "street";
         this.id_t = new Mobilize.Web.DmText();
         this.id_t.Band = Mobilize.Web.CaseExtensions.String("header");
         this.id_t.Alignment = 2;
         this.id_t.Text = "Id";
         this.id_t.Border = 0;
         this.id_t.Color = "33554432";
         this.id_t.X = 14;
         this.id_t.Y = 8;
         this.id_t.Height = 64;
         this.id_t.Width = 274;
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
         this.street_t.Band = Mobilize.Web.CaseExtensions.String("header");
         this.street_t.Alignment = 2;
         this.street_t.Text = "Street";
         this.street_t.Border = 0;
         this.street_t.Color = "33554432";
         this.street_t.X = 306;
         this.street_t.Y = 8;
         this.street_t.Height = 64;
         this.street_t.Width = 274;
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
         this.t_1 = new Mobilize.Web.DmText();
         this.t_1.Band = Mobilize.Web.CaseExtensions.String("header");
         this.t_1.Alignment = 2;
         this.t_1.Text = "Description";
         this.t_1.Border = 0;
         this.t_1.Color = "33554432";
         this.t_1.X = 590;
         this.t_1.Y = 8;
         this.t_1.Height = 64;
         this.t_1.Width = 325;
         this.t_1.Name = Mobilize.Web.CaseExtensions.String("t_1");
         this.t_1.Visible = true;
         this.t_1.Font.FontFace = "Tahoma";
         this.t_1.Font.Height = -10;
         this.t_1.Font.Weight = 400;
         this.t_1.Font.FontFamily = "2";
         this.t_1.Font.Pitch = "2";
         this.t_1.Font.Charset = "0";
         this.t_1.Background.Mode = 1;
         this.t_1.Background.Color = "536870912";
         this._id = new Mobilize.Web.DmColumn();
         this._id.Band = Mobilize.Web.CaseExtensions.String("detail");
         this._id.Id = 1;
         this._id.Alignment = 0;
         this._id.TabSequence = 10;
         this._id.Border = 0;
         this._id.Color = "33554432";
         this._id.X = 14;
         this._id.Y = 8;
         this._id.Height = 76;
         this._id.Width = 274;
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
         this.street.Id = 3;
         this.street.Alignment = 0;
         this.street.TabSequence = 30;
         this.street.Border = 0;
         this.street.Color = "33554432";
         this.street.X = 306;
         this.street.Y = 8;
         this.street.Height = 76;
         this.street.Width = 274;
         this.street.Format = "[general]";
         this.street.Name = Mobilize.Web.CaseExtensions.String("street");
         this.street.Visible = "1\tif(street = '0', 0, 1)";
         this.street.Edit.Limit = 0;
         this.street.Edit.Case = "any";
         this.street.Edit.FocusRectangle = false;
         this.street.Edit.AutoSelect = true;
         this.street.Edit.AutoHScroll = true;
         this.street.Font.FontFace = "Tahoma";
         this.street.Font.Height = -10;
         this.street.Font.Weight = 400;
         this.street.Font.FontFamily = "2";
         this.street.Font.Pitch = "2";
         this.street.Font.Charset = "0";
         this.street.Background.Mode = 1;
         this.street.Background.Color = "536870912";
         this.street.EditMask.MaskDataType = Mobilize.Web.MaskDataType.StringMask;
         this.compute_1 = new Mobilize.Web.DmCompute();
         this.compute_1.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.compute_1.Alignment = 0;
         this.compute_1.Expression = "if(street = '0', 'n/a', if(street= '1', 'One', 'Unknown'))";
         this.compute_1.Border = 0;
         this.compute_1.Color = "33554432";
         this.compute_1.X = 590;
         this.compute_1.Y = 8;
         this.compute_1.Height = 96;
         this.compute_1.Width = 325;
         this.compute_1.Format = "[GENERAL]";
         this.compute_1.Name = Mobilize.Web.CaseExtensions.String("compute_1");
         this.compute_1.Visible = true;
         this.compute_1.Font.FontFace = "Tahoma";
         this.compute_1.Font.Height = -10;
         this.compute_1.Font.Weight = 400;
         this.compute_1.Font.FontFamily = "2";
         this.compute_1.Font.Pitch = "2";
         this.compute_1.Font.Charset = "0";
         this.compute_1.Background.Mode = 2;
         this.compute_1.Background.Color = "1073741824";
         this.compute_2 = new Mobilize.Web.DmCompute();
         this.compute_2.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.compute_2.Alignment = 0;
         this.compute_2.Expression = "if(name = \"name0\", \"Name\", \"\")";
         this.compute_2.Border = 0;
         this.compute_2.Color = "33554432";
         this.compute_2.X = 923;
         this.compute_2.Y = 8;
         this.compute_2.Height = 64;
         this.compute_2.Width = 210;
         this.compute_2.Format = "[GENERAL]";
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
         this.t_2 = new Mobilize.Web.DmText();
         this.t_2.Band = Mobilize.Web.CaseExtensions.String("header");
         this.t_2.Alignment = 2;
         this.t_2.Text = "Name";
         this.t_2.Border = 0;
         this.t_2.Color = "33554432";
         this.t_2.X = 923;
         this.t_2.Y = 8;
         this.t_2.Height = 64;
         this.t_2.Width = 210;
         this.t_2.Name = Mobilize.Web.CaseExtensions.String("t_2");
         this.t_2.Visible = true;
         this.t_2.Font.FontFace = "Tahoma";
         this.t_2.Font.Height = -10;
         this.t_2.Font.Weight = 400;
         this.t_2.Font.FontFamily = "2";
         this.t_2.Font.Pitch = "2";
         this.t_2.Font.Charset = "0";
         this.t_2.Background.Mode = 1;
         this.t_2.Background.Color = "536870912";
         this.AddColumns(new Mobilize.Web.DB.Column[] { id_db1, name_db2, street_db3 });
         this.AddControls(new Mobilize.Web.DmControl[] { this.id_t, this.street_t, this.t_1, this._id, this.street, this.compute_1, this.compute_2, this.t_2 });
         this.AddData(new object[] { "0", "name0", "0", "1", "name1", "1", "2", "street2", "2", "3", "street3", "3", "4", "name4", "street4" });
         this.PopulateRadioButtons();
      }
   }

}