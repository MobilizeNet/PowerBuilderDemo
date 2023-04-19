namespace pbj_webmapdemo
{

   [Mobilize.WebMap.Common.Attributes.Observable]
   public partial class dw_productsbrand
      : Mobilize.Web.DataManager, Mobilize.Web.IDataManager
   {

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText id_t { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText name_t { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText brandid_t { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn _id { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn _name { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn brandid { get; set; }


      public dw_productsbrand()
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
         id_db1.Type = Mobilize.Web.CaseExtensions.String("long");
         id_db1.Update = true;
         id_db1.UpdateWhereClause = true;
         id_db1.Key = Mobilize.Web.CaseExtensions.String("yes");
         id_db1.Name = Mobilize.Web.CaseExtensions.String("id");
         id_db1.DbName = "productitems.id";
         var name_db2 = new Mobilize.Web.DB.Column();
         name_db2.Type = Mobilize.Web.CaseExtensions.String("char(16383)");
         name_db2.Update = true;
         name_db2.UpdateWhereClause = false;
         name_db2.Name = Mobilize.Web.CaseExtensions.String("name");
         name_db2.DbName = "productitems.name";
         var price_db3 = new Mobilize.Web.DB.Column();
         price_db3.Type = Mobilize.Web.CaseExtensions.String("real");
         price_db3.Update = true;
         price_db3.UpdateWhereClause = true;
         price_db3.Name = Mobilize.Web.CaseExtensions.String("price");
         price_db3.DbName = "productitems.price";
         var imagename_db4 = new Mobilize.Web.DB.Column();
         imagename_db4.Type = Mobilize.Web.CaseExtensions.String("char(16383)");
         imagename_db4.Update = true;
         imagename_db4.UpdateWhereClause = false;
         imagename_db4.Name = Mobilize.Web.CaseExtensions.String("imagename");
         imagename_db4.DbName = "productitems.imagename";
         var brandid_db5 = new Mobilize.Web.DB.Column();
         brandid_db5.Type = Mobilize.Web.CaseExtensions.String("long");
         brandid_db5.Update = true;
         brandid_db5.UpdateWhereClause = true;
         brandid_db5.Name = Mobilize.Web.CaseExtensions.String("brandid");
         brandid_db5.DbName = "productitems.brandid";
         var typeid_db6 = new Mobilize.Web.DB.Column();
         typeid_db6.Type = Mobilize.Web.CaseExtensions.String("long");
         typeid_db6.Update = true;
         typeid_db6.UpdateWhereClause = true;
         typeid_db6.Name = Mobilize.Web.CaseExtensions.String("typeid");
         typeid_db6.DbName = "productitems.typeid";
         var tagid_db7 = new Mobilize.Web.DB.Column();
         tagid_db7.Type = Mobilize.Web.CaseExtensions.String("long");
         tagid_db7.Update = true;
         tagid_db7.UpdateWhereClause = true;
         tagid_db7.Name = Mobilize.Web.CaseExtensions.String("tagid");
         tagid_db7.DbName = "productitems.tagid";
         this.RetrieveStatement = "PBSELECT( VERSION(400) TABLE(NAME=\"productitems\" ) COLUMN(NAME=\"productitems.id\") COLUMN(NAME=\"productitems.name\") COLUMN(NAME=\"productitems.price\") COLUMN(NAME=\"productitems.imagename\") COLUMN(NAME=\"productitems.brandid\") COLUMN(NAME=\"productitems.typeid\") COLUMN(NAME=\"productitems.tagid\")) ";
         this.UpdateTableName = "productitems";
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
         this.name_t.Width = 1701;
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
         this.brandid_t = new Mobilize.Web.DmText();
         this.brandid_t.Band = Mobilize.Web.CaseExtensions.String("header");
         this.brandid_t.Alignment = 2;
         this.brandid_t.Text = "Brand";
         this.brandid_t.Border = 0;
         this.brandid_t.Color = "33554432";
         this.brandid_t.X = 2075;
         this.brandid_t.Y = 8;
         this.brandid_t.Height = 64;
         this.brandid_t.Width = 1065;
         this.brandid_t.Name = Mobilize.Web.CaseExtensions.String("brandid_t");
         this.brandid_t.Visible = true;
         this.brandid_t.Font.FontFace = "Tahoma";
         this.brandid_t.Font.Height = -10;
         this.brandid_t.Font.Weight = 400;
         this.brandid_t.Font.FontFamily = "2";
         this.brandid_t.Font.Pitch = "2";
         this.brandid_t.Font.Charset = "0";
         this.brandid_t.Background.Mode = 1;
         this.brandid_t.Background.Color = "536870912";
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
         this._name.Width = 1701;
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
         this.brandid = new Mobilize.Web.DmColumn();
         this.brandid.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.brandid.Id = 5;
         this.brandid.Alignment = 1;
         this.brandid.TabSequence = 50;
         this.brandid.Border = 0;
         this.brandid.Color = "33554432";
         this.brandid.X = 2075;
         this.brandid.Y = 8;
         this.brandid.Height = 76;
         this.brandid.Width = 1065;
         this.brandid.Format = "[general]";
         this.brandid.Name = Mobilize.Web.CaseExtensions.String("brandid");
         this.brandid.Visible = true;
         this.brandid.DdDm.DataManager = Mobilize.Web.CaseExtensions.String("dw_brands");
         this.brandid.DdDm.DisplayColumn = Mobilize.Web.CaseExtensions.String("name");
         this.brandid.DdDm.DataColumn = Mobilize.Web.CaseExtensions.String("id");
         this.brandid.DdDm.PercentWidth = 0;
         this.brandid.DdDm.Lines = 0;
         this.brandid.DdDm.Limit = 0;
         this.brandid.DdDm.AllowEdit = false;
         this.brandid.DdDm.UseAsBorder = true;
         this.brandid.DdDm.Case = Mobilize.Web.CaseExtensions.String("any");
         this.brandid.DdDm.HScrollBar = true;
         this.brandid.Font.FontFace = "Tahoma";
         this.brandid.Font.Height = -10;
         this.brandid.Font.Weight = 400;
         this.brandid.Font.FontFamily = "2";
         this.brandid.Font.Pitch = "2";
         this.brandid.Font.Charset = "0";
         this.brandid.Background.Mode = 1;
         this.brandid.Background.Color = "536870912";
         this.brandid.EditMask.MaskDataType = Mobilize.Web.MaskDataType.StringMask;
         this.AddColumns(new Mobilize.Web.DB.Column[] { id_db1, name_db2, price_db3, imagename_db4, brandid_db5, typeid_db6, tagid_db7 });
         this.AddControls(new Mobilize.Web.DmControl[] { this.id_t, this.name_t, this.brandid_t, this._id, this._name, this.brandid });
         this.PopulateRadioButtons();
      }
   }

}