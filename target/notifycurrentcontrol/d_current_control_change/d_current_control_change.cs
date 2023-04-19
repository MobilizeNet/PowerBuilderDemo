namespace notifycurrentcontrol
{

   [Mobilize.WebMap.Common.Attributes.Observable]
   public partial class d_current_control_change
      : Mobilize.Web.DataManager, Mobilize.Web.IDataManager
   {

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText name_t { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn _name { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn address { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText address_t { get; set; }


      public d_current_control_change()
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
         this.Detail.Height = 252;
         this.Detail.Color = "536870912";
         var name_db1 = new Mobilize.Web.DB.Column();
         name_db1.Type = Mobilize.Web.CaseExtensions.String("char(10)");
         name_db1.UpdateWhereClause = true;
         name_db1.Name = Mobilize.Web.CaseExtensions.String("name");
         name_db1.DbName = "name";
         var address_db2 = new Mobilize.Web.DB.Column();
         address_db2.Type = Mobilize.Web.CaseExtensions.String("char(10)");
         address_db2.UpdateWhereClause = true;
         address_db2.Name = Mobilize.Web.CaseExtensions.String("address");
         address_db2.DbName = "address";
         this.name_t = new Mobilize.Web.DmText();
         this.name_t.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.name_t.Alignment = 1;
         this.name_t.Text = "Name:";
         this.name_t.Border = 0;
         this.name_t.Color = "33554432";
         this.name_t.X = 37;
         this.name_t.Y = 32;
         this.name_t.Height = 64;
         this.name_t.Width = 247;
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
         this._name.Id = 1;
         this._name.Alignment = 0;
         this._name.TabSequence = 20;
         this._name.Border = 0;
         this._name.Color = "33554432";
         this._name.X = 320;
         this._name.Y = 32;
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
         this.address = new Mobilize.Web.DmColumn();
         this.address.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.address.Id = 2;
         this.address.Alignment = 0;
         this.address.TabSequence = 30;
         this.address.Border = 0;
         this.address.Color = "33554432";
         this.address.X = 325;
         this.address.Y = 160;
         this.address.Height = 68;
         this.address.Width = 320;
         this.address.Format = "[general]";
         this.address.Name = Mobilize.Web.CaseExtensions.String("address");
         this.address.Visible = true;
         this.address.Edit.Limit = 0;
         this.address.Edit.Case = "any";
         this.address.Edit.FocusRectangle = false;
         this.address.Edit.AutoSelect = false;
         this.address.Font.FontFace = "Tahoma";
         this.address.Font.Height = -10;
         this.address.Font.Weight = 400;
         this.address.Font.FontFamily = "2";
         this.address.Font.Pitch = "2";
         this.address.Font.Charset = "0";
         this.address.Background.Mode = 2;
         this.address.Background.Color = "1073741824";
         this.address.EditMask.MaskDataType = Mobilize.Web.MaskDataType.StringMask;
         this.address_t = new Mobilize.Web.DmText();
         this.address_t.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.address_t.Alignment = 1;
         this.address_t.Text = "Address:";
         this.address_t.Border = 0;
         this.address_t.Color = "33554432";
         this.address_t.X = 18;
         this.address_t.Y = 160;
         this.address_t.Height = 64;
         this.address_t.Width = 265;
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
         this.AddColumns(new Mobilize.Web.DB.Column[] { name_db1, address_db2 });
         this.AddControls(new Mobilize.Web.DmControl[] { this.name_t, this._name, this.address, this.address_t });
         this.PopulateRadioButtons();
      }
   }

}