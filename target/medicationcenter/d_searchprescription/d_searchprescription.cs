namespace medicationcenter
{

   [Mobilize.WebMap.Common.Attributes.Observable]
   public partial class d_searchprescription
      : Mobilize.Web.DataManager, Mobilize.Web.IDataManager
   {

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText patient_t { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn patient { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText medication_t { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn medication { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmButton b_1 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText t_search { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn searchby { get; set; }


      public d_searchprescription()
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
         this.Detail.Height = 784;
         this.Detail.Color = "536870912";
         var patient_db1 = new Mobilize.Web.DB.Column();
         patient_db1.Type = Mobilize.Web.CaseExtensions.String("char(250)");
         patient_db1.UpdateWhereClause = true;
         patient_db1.Name = Mobilize.Web.CaseExtensions.String("patient");
         patient_db1.DbName = "patient";
         var searchby_db2 = new Mobilize.Web.DB.Column();
         searchby_db2.Type = Mobilize.Web.CaseExtensions.String("number");
         searchby_db2.UpdateWhereClause = true;
         searchby_db2.Name = Mobilize.Web.CaseExtensions.String("searchby");
         searchby_db2.DbName = "name_1";
         searchby_db2.Values = "Patient Name\t1/Medication Name\t2/";
         var medication_db3 = new Mobilize.Web.DB.Column();
         medication_db3.Type = Mobilize.Web.CaseExtensions.String("char(250)");
         medication_db3.UpdateWhereClause = true;
         medication_db3.Name = Mobilize.Web.CaseExtensions.String("medication");
         medication_db3.DbName = "medication";
         this.patient_t = new Mobilize.Web.DmText();
         this.patient_t.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.patient_t.Alignment = 1;
         this.patient_t.Text = "Patient:";
         this.patient_t.Border = 0;
         this.patient_t.Color = "33554432";
         this.patient_t.X = 128;
         this.patient_t.Y = 88;
         this.patient_t.Height = 64;
         this.patient_t.Width = 320;
         this.patient_t.Name = Mobilize.Web.CaseExtensions.String("patient_t");
         this.patient_t.Visible = true;
         this.patient_t.Font.FontFace = "Tahoma";
         this.patient_t.Font.Height = -10;
         this.patient_t.Font.Weight = 400;
         this.patient_t.Font.FontFamily = "2";
         this.patient_t.Font.Pitch = "2";
         this.patient_t.Font.Charset = "0";
         this.patient_t.Background.Mode = 1;
         this.patient_t.Background.Color = "536870912";
         this.patient = new Mobilize.Web.DmColumn();
         this.patient.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.patient.Id = 1;
         this.patient.Alignment = 0;
         this.patient.TabSequence = 10;
         this.patient.Border = 4;
         this.patient.Color = "33554432";
         this.patient.X = 485;
         this.patient.Y = 88;
         this.patient.Height = 76;
         this.patient.Width = 1445;
         this.patient.Format = "[general]";
         this.patient.Name = Mobilize.Web.CaseExtensions.String("patient");
         this.patient.Visible = true;
         this.patient.Edit.Limit = 0;
         this.patient.Edit.Case = "any";
         this.patient.Edit.FocusRectangle = false;
         this.patient.Edit.AutoSelect = false;
         this.patient.Font.FontFace = "Tahoma";
         this.patient.Font.Height = -10;
         this.patient.Font.Weight = 400;
         this.patient.Font.FontFamily = "2";
         this.patient.Font.Pitch = "2";
         this.patient.Font.Charset = "0";
         this.patient.Background.Mode = 1;
         this.patient.Background.Color = "536870912";
         this.patient.EditMask.MaskDataType = Mobilize.Web.MaskDataType.StringMask;
         this.medication_t = new Mobilize.Web.DmText();
         this.medication_t.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.medication_t.Alignment = 1;
         this.medication_t.Text = "Medication:";
         this.medication_t.Border = 0;
         this.medication_t.Color = "33554432";
         this.medication_t.X = 128;
         this.medication_t.Y = 224;
         this.medication_t.Height = 64;
         this.medication_t.Width = 320;
         this.medication_t.Name = Mobilize.Web.CaseExtensions.String("medication_t");
         this.medication_t.Visible = true;
         this.medication_t.Font.FontFace = "Tahoma";
         this.medication_t.Font.Height = -10;
         this.medication_t.Font.Weight = 400;
         this.medication_t.Font.FontFamily = "2";
         this.medication_t.Font.Pitch = "2";
         this.medication_t.Font.Charset = "0";
         this.medication_t.Background.Mode = 1;
         this.medication_t.Background.Color = "536870912";
         this.medication = new Mobilize.Web.DmColumn();
         this.medication.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.medication.Id = 3;
         this.medication.Alignment = 0;
         this.medication.TabSequence = 20;
         this.medication.Border = 4;
         this.medication.Color = "33554432";
         this.medication.X = 489;
         this.medication.Y = 224;
         this.medication.Height = 76;
         this.medication.Width = 1435;
         this.medication.Format = "[general]";
         this.medication.Name = Mobilize.Web.CaseExtensions.String("medication");
         this.medication.Visible = true;
         this.medication.Edit.Limit = 0;
         this.medication.Edit.Case = "any";
         this.medication.Edit.FocusRectangle = false;
         this.medication.Edit.AutoSelect = true;
         this.medication.Edit.AutoHScroll = true;
         this.medication.Font.FontFace = "Tahoma";
         this.medication.Font.Height = -10;
         this.medication.Font.Weight = 400;
         this.medication.Font.FontFamily = "2";
         this.medication.Font.Pitch = "2";
         this.medication.Font.Charset = "0";
         this.medication.Background.Mode = 1;
         this.medication.Background.Color = "536870912";
         this.medication.EditMask.MaskDataType = Mobilize.Web.MaskDataType.StringMask;
         this.b_1 = new Mobilize.Web.DmButton();
         this.b_1.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.b_1.Text = "Search";
         this.b_1.Border = 0;
         this.b_1.Color = "33554432";
         this.b_1.X = 1605;
         this.b_1.Y = 488;
         this.b_1.Height = 120;
         this.b_1.Width = 320;
         this.b_1.VTextAlign = 0;
         this.b_1.HTextAlign = 0;
         this.b_1.Name = Mobilize.Web.CaseExtensions.String("b_1");
         this.b_1.Visible = true;
         this.b_1.Font.FontFace = "Tahoma";
         this.b_1.Font.Height = -10;
         this.b_1.Font.Weight = 400;
         this.b_1.Font.FontFamily = "2";
         this.b_1.Font.Pitch = "2";
         this.b_1.Font.Charset = "0";
         this.b_1.Background.Mode = 2;
         this.b_1.Background.Color = "67108864";
         this.t_search = new Mobilize.Web.DmText();
         this.t_search.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.t_search.Alignment = 0;
         this.t_search.Text = "Search By:";
         this.t_search.Border = 0;
         this.t_search.Color = "33554432";
         this.t_search.X = 169;
         this.t_search.Y = 360;
         this.t_search.Height = 64;
         this.t_search.Width = 283;
         this.t_search.Name = Mobilize.Web.CaseExtensions.String("t_search");
         this.t_search.Visible = true;
         this.t_search.Font.FontFace = "Tahoma";
         this.t_search.Font.Height = -10;
         this.t_search.Font.Weight = 400;
         this.t_search.Font.FontFamily = "2";
         this.t_search.Font.Pitch = "2";
         this.t_search.Font.Charset = "0";
         this.t_search.Background.Mode = 2;
         this.t_search.Background.Color = "1073741824";
         this.searchby = new Mobilize.Web.DmColumn();
         this.searchby.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.searchby.Id = 2;
         this.searchby.Alignment = 0;
         this.searchby.TabSequence = 30;
         this.searchby.Border = 0;
         this.searchby.Color = "33554432";
         this.searchby.X = 133;
         this.searchby.Y = 452;
         this.searchby.Height = 160;
         this.searchby.Width = 571;
         this.searchby.Format = "[general]";
         this.searchby.Name = Mobilize.Web.CaseExtensions.String("searchby");
         this.searchby.Visible = true;
         this.searchby.RadioButtons.Columns = 1;
         this.searchby.Font.FontFace = "Tahoma";
         this.searchby.Font.Height = -10;
         this.searchby.Font.Weight = 400;
         this.searchby.Font.FontFamily = "2";
         this.searchby.Font.Pitch = "2";
         this.searchby.Font.Charset = "0";
         this.searchby.Background.Mode = 1;
         this.searchby.Background.Color = "536870912";
         this.searchby.EditMask.MaskDataType = Mobilize.Web.MaskDataType.NumericMask;
         this.AddColumns(new Mobilize.Web.DB.Column[] { patient_db1, searchby_db2, medication_db3 });
         this.AddControls(new Mobilize.Web.DmControl[] { this.patient_t, this.patient, this.medication_t, this.medication, this.b_1, this.t_search, this.searchby });
         this.PopulateRadioButtons();
      }
   }

}