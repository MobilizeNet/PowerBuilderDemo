namespace medicationcenter
{

   [Mobilize.WebMap.Common.Attributes.Observable]
   public partial class d_removeprescription
      : Mobilize.Web.DataManager, Mobilize.Web.IDataManager
   {

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmLine l_1 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText t_1 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText id_t { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn iid { get; set; }


      public d_removeprescription()
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
         this.Detail.Height = 488;
         this.Detail.Color = "536870912";
         var iid_db1 = new Mobilize.Web.DB.Column();
         iid_db1.Type = Mobilize.Web.CaseExtensions.String("number");
         iid_db1.UpdateWhereClause = true;
         iid_db1.Name = Mobilize.Web.CaseExtensions.String("iid");
         iid_db1.DbName = "id";
         this.l_1 = new Mobilize.Web.DmLine();
         this.l_1.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.l_1.X1 = 119;
         this.l_1.Y1 = 184;
         this.l_1.X2 = 2272;
         this.l_1.Y2 = 184;
         this.l_1.Name = Mobilize.Web.CaseExtensions.String("l_1");
         this.l_1.Visible = true;
         this.l_1.Pen.Style = 0;
         this.l_1.Pen.Width = 5;
         this.l_1.Pen.Color = "33554432";
         this.l_1.Background.Mode = 2;
         this.l_1.Background.Color = "1073741824";
         this.t_1 = new Mobilize.Web.DmText();
         this.t_1.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.t_1.Alignment = 1;
         this.t_1.Text = "Select the prescription you want to remove.";
         this.t_1.Border = 0;
         this.t_1.Color = "33554432";
         this.t_1.X = 571;
         this.t_1.Y = 68;
         this.t_1.Height = 64;
         this.t_1.Width = 1143;
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
         this.id_t = new Mobilize.Web.DmText();
         this.id_t.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.id_t.Alignment = 1;
         this.id_t.Text = "Prescription:";
         this.id_t.Border = 0;
         this.id_t.Color = "33554432";
         this.id_t.X = 201;
         this.id_t.Y = 280;
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
         this.iid = new Mobilize.Web.DmColumn();
         this.iid.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.iid.Id = 1;
         this.iid.Alignment = 1;
         this.iid.TabSequence = 10;
         this.iid.Border = 4;
         this.iid.Color = "33554432";
         this.iid.X = 631;
         this.iid.Y = 280;
         this.iid.Height = 76;
         this.iid.Width = 1541;
         this.iid.Format = "[general]";
         this.iid.Name = Mobilize.Web.CaseExtensions.String("iid");
         this.iid.Visible = true;
         this.iid.DdDm.DataManager = Mobilize.Web.CaseExtensions.String("d_dddwprescription");
         this.iid.DdDm.DisplayColumn = Mobilize.Web.CaseExtensions.String("prescdata");
         this.iid.DdDm.DataColumn = Mobilize.Web.CaseExtensions.String("id");
         this.iid.DdDm.PercentWidth = 0;
         this.iid.DdDm.Lines = 0;
         this.iid.DdDm.Limit = 0;
         this.iid.DdDm.AllowEdit = false;
         this.iid.DdDm.UseAsBorder = false;
         this.iid.DdDm.Case = Mobilize.Web.CaseExtensions.String("any");
         this.iid.Font.FontFace = "Tahoma";
         this.iid.Font.Height = -10;
         this.iid.Font.Weight = 400;
         this.iid.Font.FontFamily = "2";
         this.iid.Font.Pitch = "2";
         this.iid.Font.Charset = "0";
         this.iid.Background.Mode = 1;
         this.iid.Background.Color = "536870912";
         this.iid.EditMask.MaskDataType = Mobilize.Web.MaskDataType.NumericMask;
         this.AddColumns(new Mobilize.Web.DB.Column[] { iid_db1 });
         this.AddControls(new Mobilize.Web.DmControl[] { this.l_1, this.t_1, this.id_t, this.iid });
         this.PopulateRadioButtons();
      }
   }

}