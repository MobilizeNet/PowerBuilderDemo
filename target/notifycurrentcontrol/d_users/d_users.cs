namespace notifycurrentcontrol
{

   [Mobilize.WebMap.Common.Attributes.Observable]
   public partial class d_users
      : Mobilize.Web.DataManager, Mobilize.Web.IDataManager
   {

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText id_t { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn _id { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText name_t { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn _name { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText street_t { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn street { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText state_t { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn state { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText address_t { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn address { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText company_t { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn company { get; set; }


      public d_users()
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
         this.Detail.Height = 824;
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
         var state_db4 = new Mobilize.Web.DB.Column();
         state_db4.Type = Mobilize.Web.CaseExtensions.String("char(10)");
         state_db4.UpdateWhereClause = true;
         state_db4.Name = Mobilize.Web.CaseExtensions.String("state");
         state_db4.DbName = "state";
         var address_db5 = new Mobilize.Web.DB.Column();
         address_db5.Type = Mobilize.Web.CaseExtensions.String("char(10)");
         address_db5.UpdateWhereClause = true;
         address_db5.Name = Mobilize.Web.CaseExtensions.String("address");
         address_db5.DbName = "address";
         var company_db6 = new Mobilize.Web.DB.Column();
         company_db6.Type = Mobilize.Web.CaseExtensions.String("char(10)");
         company_db6.UpdateWhereClause = true;
         company_db6.Name = Mobilize.Web.CaseExtensions.String("company");
         company_db6.DbName = "company";
         this.id_t = new Mobilize.Web.DmText();
         this.id_t.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.id_t.Alignment = 1;
         this.id_t.Text = "Id:";
         this.id_t.Border = 0;
         this.id_t.Color = "33554432";
         this.id_t.X = 37;
         this.id_t.Y = 4;
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
         this._id = new Mobilize.Web.DmColumn();
         this._id.Band = Mobilize.Web.CaseExtensions.String("detail");
         this._id.Id = 1;
         this._id.Alignment = 0;
         this._id.TabSequence = 10;
         this._id.Border = 0;
         this._id.Color = "33554432";
         this._id.X = 347;
         this._id.Y = 4;
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
         this.name_t = new Mobilize.Web.DmText();
         this.name_t.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.name_t.Alignment = 1;
         this.name_t.Text = "Name:";
         this.name_t.Border = 0;
         this.name_t.Color = "33554432";
         this.name_t.X = 37;
         this.name_t.Y = 140;
         this.name_t.Height = 64;
         this.name_t.Width = 274;
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
         this._name = new Mobilize.Web.DmColumn();
         this._name.Band = Mobilize.Web.CaseExtensions.String("detail");
         this._name.Id = 2;
         this._name.Alignment = 0;
         this._name.TabSequence = 20;
         this._name.Border = 0;
         this._name.Color = "33554432";
         this._name.X = 347;
         this._name.Y = 140;
         this._name.Height = 76;
         this._name.Width = 274;
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
         this.street_t = new Mobilize.Web.DmText();
         this.street_t.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.street_t.Alignment = 1;
         this.street_t.Text = "Street:";
         this.street_t.Border = 0;
         this.street_t.Color = "33554432";
         this.street_t.X = 37;
         this.street_t.Y = 276;
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
         this.street = new Mobilize.Web.DmColumn();
         this.street.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.street.Id = 3;
         this.street.Alignment = 0;
         this.street.TabSequence = 30;
         this.street.Border = 0;
         this.street.Color = "33554432";
         this.street.X = 347;
         this.street.Y = 276;
         this.street.Height = 76;
         this.street.Width = 274;
         this.street.Format = "[general]";
         this.street.Name = Mobilize.Web.CaseExtensions.String("street");
         this.street.Visible = true;
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
         this.state_t = new Mobilize.Web.DmText();
         this.state_t.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.state_t.Alignment = 1;
         this.state_t.Text = "State:";
         this.state_t.Border = 0;
         this.state_t.Color = "33554432";
         this.state_t.X = 37;
         this.state_t.Y = 412;
         this.state_t.Height = 64;
         this.state_t.Width = 274;
         this.state_t.Name = Mobilize.Web.CaseExtensions.String("state_t");
         this.state_t.Visible = true;
         this.state_t.Font.FontFace = "Tahoma";
         this.state_t.Font.Height = -10;
         this.state_t.Font.Weight = 400;
         this.state_t.Font.FontFamily = "2";
         this.state_t.Font.Pitch = "2";
         this.state_t.Font.Charset = "0";
         this.state_t.Background.Mode = 1;
         this.state_t.Background.Color = "536870912";
         this.state = new Mobilize.Web.DmColumn();
         this.state.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.state.Id = 4;
         this.state.Alignment = 0;
         this.state.TabSequence = 40;
         this.state.Border = 0;
         this.state.Color = "33554432";
         this.state.X = 347;
         this.state.Y = 412;
         this.state.Height = 76;
         this.state.Width = 274;
         this.state.Format = "[general]";
         this.state.Name = Mobilize.Web.CaseExtensions.String("state");
         this.state.Visible = true;
         this.state.Edit.Limit = 0;
         this.state.Edit.Case = "any";
         this.state.Edit.FocusRectangle = false;
         this.state.Edit.AutoSelect = true;
         this.state.Edit.AutoHScroll = true;
         this.state.Font.FontFace = "Tahoma";
         this.state.Font.Height = -10;
         this.state.Font.Weight = 400;
         this.state.Font.FontFamily = "2";
         this.state.Font.Pitch = "2";
         this.state.Font.Charset = "0";
         this.state.Background.Mode = 1;
         this.state.Background.Color = "536870912";
         this.state.EditMask.MaskDataType = Mobilize.Web.MaskDataType.StringMask;
         this.address_t = new Mobilize.Web.DmText();
         this.address_t.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.address_t.Alignment = 1;
         this.address_t.Text = "Address:";
         this.address_t.Border = 0;
         this.address_t.Color = "33554432";
         this.address_t.X = 37;
         this.address_t.Y = 548;
         this.address_t.Height = 64;
         this.address_t.Width = 274;
         this.address_t.Name = Mobilize.Web.CaseExtensions.String("address_t");
         this.address_t.Visible = true;
         this.address_t.Font.FontFace = "Tahoma";
         this.address_t.Font.Height = -10;
         this.address_t.Font.Weight = 400;
         this.address_t.Font.FontFamily = "2";
         this.address_t.Font.Pitch = "2";
         this.address_t.Font.Charset = "0";
         this.address_t.Background.Mode = 1;
         this.address_t.Background.Color = "536870912";
         this.address = new Mobilize.Web.DmColumn();
         this.address.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.address.Id = 5;
         this.address.Alignment = 0;
         this.address.TabSequence = 50;
         this.address.Border = 0;
         this.address.Color = "33554432";
         this.address.X = 347;
         this.address.Y = 548;
         this.address.Height = 76;
         this.address.Width = 274;
         this.address.Format = "[general]";
         this.address.Name = Mobilize.Web.CaseExtensions.String("address");
         this.address.Visible = true;
         this.address.Edit.Limit = 0;
         this.address.Edit.Case = "any";
         this.address.Edit.FocusRectangle = false;
         this.address.Edit.AutoSelect = true;
         this.address.Edit.AutoHScroll = true;
         this.address.Font.FontFace = "Tahoma";
         this.address.Font.Height = -10;
         this.address.Font.Weight = 400;
         this.address.Font.FontFamily = "2";
         this.address.Font.Pitch = "2";
         this.address.Font.Charset = "0";
         this.address.Background.Mode = 1;
         this.address.Background.Color = "536870912";
         this.address.EditMask.MaskDataType = Mobilize.Web.MaskDataType.StringMask;
         this.company_t = new Mobilize.Web.DmText();
         this.company_t.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.company_t.Alignment = 1;
         this.company_t.Text = "Company:";
         this.company_t.Border = 0;
         this.company_t.Color = "33554432";
         this.company_t.X = 37;
         this.company_t.Y = 684;
         this.company_t.Height = 64;
         this.company_t.Width = 274;
         this.company_t.Name = Mobilize.Web.CaseExtensions.String("company_t");
         this.company_t.Visible = true;
         this.company_t.Font.FontFace = "Tahoma";
         this.company_t.Font.Height = -10;
         this.company_t.Font.Weight = 400;
         this.company_t.Font.FontFamily = "2";
         this.company_t.Font.Pitch = "2";
         this.company_t.Font.Charset = "0";
         this.company_t.Background.Mode = 1;
         this.company_t.Background.Color = "536870912";
         this.company = new Mobilize.Web.DmColumn();
         this.company.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.company.Id = 6;
         this.company.Alignment = 0;
         this.company.TabSequence = 60;
         this.company.Border = 0;
         this.company.Color = "33554432";
         this.company.X = 347;
         this.company.Y = 684;
         this.company.Height = 76;
         this.company.Width = 274;
         this.company.Format = "[general]";
         this.company.Name = Mobilize.Web.CaseExtensions.String("company");
         this.company.Visible = true;
         this.company.Edit.Limit = 0;
         this.company.Edit.Case = "any";
         this.company.Edit.FocusRectangle = false;
         this.company.Edit.AutoSelect = true;
         this.company.Edit.AutoHScroll = true;
         this.company.Font.FontFace = "Tahoma";
         this.company.Font.Height = -10;
         this.company.Font.Weight = 400;
         this.company.Font.FontFamily = "2";
         this.company.Font.Pitch = "2";
         this.company.Font.Charset = "0";
         this.company.Background.Mode = 1;
         this.company.Background.Color = "536870912";
         this.company.EditMask.MaskDataType = Mobilize.Web.MaskDataType.StringMask;
         this.AddColumns(new Mobilize.Web.DB.Column[] { id_db1, name_db2, street_db3, state_db4, address_db5, company_db6 });
         this.AddControls(new Mobilize.Web.DmControl[] { this.id_t, this._id, this.name_t, this._name, this.street_t, this.street, this.state_t, this.state, this.address_t, this.address, this.company_t, this.company });
         this.AddData(new object[] { "1", "name1", "street1", "state1", "address1", "company1", "2", "name2", "stree2", "state2", "address2", "company2" });
         this.PopulateRadioButtons();
      }
   }

}