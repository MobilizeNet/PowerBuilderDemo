namespace medicationcenter
{

   [Mobilize.WebMap.Common.Attributes.Observable]
   public partial class d_showallprescrpition
      : Mobilize.Web.DataManager, Mobilize.Web.IDataManager
   {

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText id_t { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText medicine_t { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText patient_t { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText dose_t { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText socialsecurity_t { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn iid { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn medicine { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn patient { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn dose { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn socialsecurity { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText t_1 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmCompute compute_1 { get; set; }


      public d_showallprescrpition()
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
         this.Footer.Height = 60;
         this.Footer.Color = "536870912";
         this.Detail.Height = 128;
         this.Detail.Color = "536870912";
         var socialsecurity_db1 = new Mobilize.Web.DB.Column();
         socialsecurity_db1.Type = Mobilize.Web.CaseExtensions.String("char(9)");
         socialsecurity_db1.UpdateWhereClause = true;
         socialsecurity_db1.Name = Mobilize.Web.CaseExtensions.String("socialsecurity");
         socialsecurity_db1.DbName = "name_1";
         var iid_db2 = new Mobilize.Web.DB.Column();
         iid_db2.Type = Mobilize.Web.CaseExtensions.String("number");
         iid_db2.UpdateWhereClause = true;
         iid_db2.Name = Mobilize.Web.CaseExtensions.String("iid");
         iid_db2.DbName = "id";
         var medicine_db3 = new Mobilize.Web.DB.Column();
         medicine_db3.Type = Mobilize.Web.CaseExtensions.String("number");
         medicine_db3.UpdateWhereClause = true;
         medicine_db3.Name = Mobilize.Web.CaseExtensions.String("medicine");
         medicine_db3.DbName = "medicine";
         var patient_db4 = new Mobilize.Web.DB.Column();
         patient_db4.Type = Mobilize.Web.CaseExtensions.String("number");
         patient_db4.UpdateWhereClause = true;
         patient_db4.Name = Mobilize.Web.CaseExtensions.String("patient");
         patient_db4.DbName = "patient";
         var dose_db5 = new Mobilize.Web.DB.Column();
         dose_db5.Type = Mobilize.Web.CaseExtensions.String("number");
         dose_db5.UpdateWhereClause = true;
         dose_db5.Name = Mobilize.Web.CaseExtensions.String("dose");
         dose_db5.DbName = "dose";
         this.id_t = new Mobilize.Web.DmText();
         this.id_t.Band = Mobilize.Web.CaseExtensions.String("header");
         this.id_t.Alignment = 2;
         this.id_t.Text = "Id";
         this.id_t.Border = 0;
         this.id_t.Color = "33554432";
         this.id_t.X = 14;
         this.id_t.Y = 8;
         this.id_t.Height = 64;
         this.id_t.Width = 219;
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
         this.medicine_t = new Mobilize.Web.DmText();
         this.medicine_t.Band = Mobilize.Web.CaseExtensions.String("header");
         this.medicine_t.Alignment = 2;
         this.medicine_t.Text = "Medicine";
         this.medicine_t.Border = 0;
         this.medicine_t.Color = "33554432";
         this.medicine_t.X = 247;
         this.medicine_t.Y = 8;
         this.medicine_t.Height = 64;
         this.medicine_t.Width = 699;
         this.medicine_t.Name = Mobilize.Web.CaseExtensions.String("medicine_t");
         this.medicine_t.Visible = true;
         this.medicine_t.Font.FontFace = "Tahoma";
         this.medicine_t.Font.Height = -10;
         this.medicine_t.Font.Weight = 400;
         this.medicine_t.Font.FontFamily = "2";
         this.medicine_t.Font.Pitch = "2";
         this.medicine_t.Font.Charset = "0";
         this.medicine_t.Background.Mode = 1;
         this.medicine_t.Background.Color = "536870912";
         this.patient_t = new Mobilize.Web.DmText();
         this.patient_t.Band = Mobilize.Web.CaseExtensions.String("header");
         this.patient_t.Alignment = 2;
         this.patient_t.Text = "Patient";
         this.patient_t.Border = 0;
         this.patient_t.Color = "33554432";
         this.patient_t.X = 960;
         this.patient_t.Y = 8;
         this.patient_t.Height = 64;
         this.patient_t.Width = 1298;
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
         this.dose_t = new Mobilize.Web.DmText();
         this.dose_t.Band = Mobilize.Web.CaseExtensions.String("header");
         this.dose_t.Alignment = 2;
         this.dose_t.Text = "Dose";
         this.dose_t.Border = 0;
         this.dose_t.Color = "33554432";
         this.dose_t.X = 2272;
         this.dose_t.Y = 8;
         this.dose_t.Height = 64;
         this.dose_t.Width = 279;
         this.dose_t.Name = Mobilize.Web.CaseExtensions.String("dose_t");
         this.dose_t.Visible = true;
         this.dose_t.Font.FontFace = "Tahoma";
         this.dose_t.Font.Height = -10;
         this.dose_t.Font.Weight = 400;
         this.dose_t.Font.FontFamily = "2";
         this.dose_t.Font.Pitch = "2";
         this.dose_t.Font.Charset = "0";
         this.dose_t.Background.Mode = 1;
         this.dose_t.Background.Color = "536870912";
         this.socialsecurity_t = new Mobilize.Web.DmText();
         this.socialsecurity_t.Band = Mobilize.Web.CaseExtensions.String("header");
         this.socialsecurity_t.Alignment = 0;
         this.socialsecurity_t.Text = "Socialsecurity";
         this.socialsecurity_t.Border = 0;
         this.socialsecurity_t.Color = "33554432";
         this.socialsecurity_t.X = 2560;
         this.socialsecurity_t.Y = 4;
         this.socialsecurity_t.Height = 64;
         this.socialsecurity_t.Width = 402;
         this.socialsecurity_t.Name = Mobilize.Web.CaseExtensions.String("socialsecurity_t");
         this.socialsecurity_t.Visible = true;
         this.socialsecurity_t.Font.FontFace = "Tahoma";
         this.socialsecurity_t.Font.Height = -10;
         this.socialsecurity_t.Font.Weight = 400;
         this.socialsecurity_t.Font.FontFamily = "2";
         this.socialsecurity_t.Font.Pitch = "2";
         this.socialsecurity_t.Font.Charset = "0";
         this.socialsecurity_t.Background.Mode = 2;
         this.socialsecurity_t.Background.Color = "1073741824";
         this.iid = new Mobilize.Web.DmColumn();
         this.iid.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.iid.Id = 2;
         this.iid.Alignment = 1;
         this.iid.TabSequence = 10;
         this.iid.Border = 0;
         this.iid.Color = "33554432";
         this.iid.X = 14;
         this.iid.Y = 8;
         this.iid.Height = 76;
         this.iid.Width = 219;
         this.iid.Format = "[general]";
         this.iid.Name = Mobilize.Web.CaseExtensions.String("iid");
         this.iid.Visible = true;
         this.iid.Edit.Limit = 0;
         this.iid.Edit.Case = "any";
         this.iid.Edit.FocusRectangle = false;
         this.iid.Edit.AutoSelect = true;
         this.iid.Edit.AutoHScroll = true;
         this.iid.Edit.DisplayOnly = true;
         this.iid.Font.FontFace = "Tahoma";
         this.iid.Font.Height = -10;
         this.iid.Font.Weight = 400;
         this.iid.Font.FontFamily = "2";
         this.iid.Font.Pitch = "2";
         this.iid.Font.Charset = "0";
         this.iid.Background.Mode = 1;
         this.iid.Background.Color = "536870912";
         this.iid.EditMask.MaskDataType = Mobilize.Web.MaskDataType.NumericMask;
         this.medicine = new Mobilize.Web.DmColumn();
         this.medicine.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.medicine.Id = 3;
         this.medicine.Alignment = 0;
         this.medicine.TabSequence = 32766;
         this.medicine.Border = 0;
         this.medicine.Color = "33554432";
         this.medicine.X = 247;
         this.medicine.Y = 8;
         this.medicine.Height = 76;
         this.medicine.Width = 699;
         this.medicine.Format = "[general]";
         this.medicine.Name = Mobilize.Web.CaseExtensions.String("medicine");
         this.medicine.Visible = true;
         this.medicine.DdLb.Limit = 0;
         this.medicine.DdLb.AllowEdit = false;
         this.medicine.DdLb.Case = Mobilize.Web.CaseExtensions.String("any");
         this.medicine.Font.FontFace = "Tahoma";
         this.medicine.Font.Height = -10;
         this.medicine.Font.Weight = 400;
         this.medicine.Font.FontFamily = "2";
         this.medicine.Font.Pitch = "2";
         this.medicine.Font.Charset = "0";
         this.medicine.Background.Mode = 1;
         this.medicine.Background.Color = "536870912";
         this.medicine.EditMask.MaskDataType = Mobilize.Web.MaskDataType.NumericMask;
         this.patient = new Mobilize.Web.DmColumn();
         this.patient.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.patient.Id = 4;
         this.patient.Alignment = 0;
         this.patient.TabSequence = 32766;
         this.patient.Border = 0;
         this.patient.Color = "33554432";
         this.patient.X = 960;
         this.patient.Y = 8;
         this.patient.Height = 76;
         this.patient.Width = 1298;
         this.patient.Format = "[general]";
         this.patient.Name = Mobilize.Web.CaseExtensions.String("patient");
         this.patient.Visible = true;
         this.patient.DdLb.Limit = 0;
         this.patient.DdLb.AllowEdit = false;
         this.patient.DdLb.Case = Mobilize.Web.CaseExtensions.String("any");
         this.patient.Font.FontFace = "Tahoma";
         this.patient.Font.Height = -10;
         this.patient.Font.Weight = 400;
         this.patient.Font.FontFamily = "2";
         this.patient.Font.Pitch = "2";
         this.patient.Font.Charset = "0";
         this.patient.Background.Mode = 1;
         this.patient.Background.Color = "536870912";
         this.patient.EditMask.MaskDataType = Mobilize.Web.MaskDataType.NumericMask;
         this.dose = new Mobilize.Web.DmColumn();
         this.dose.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.dose.Id = 5;
         this.dose.Alignment = 0;
         this.dose.TabSequence = 20;
         this.dose.Border = 0;
         this.dose.Color = "33554432";
         this.dose.X = 2272;
         this.dose.Y = 8;
         this.dose.Height = 76;
         this.dose.Width = 279;
         this.dose.Format = "#0.00 mg";
         this.dose.Name = Mobilize.Web.CaseExtensions.String("dose");
         this.dose.Visible = true;
         this.dose.Edit.Limit = 0;
         this.dose.Edit.Case = "any";
         this.dose.Edit.FocusRectangle = false;
         this.dose.Edit.AutoSelect = true;
         this.dose.Edit.AutoHScroll = true;
         this.dose.Edit.DisplayOnly = true;
         this.dose.Font.FontFace = "Tahoma";
         this.dose.Font.Height = -10;
         this.dose.Font.Weight = 400;
         this.dose.Font.FontFamily = "2";
         this.dose.Font.Pitch = "2";
         this.dose.Font.Charset = "0";
         this.dose.Background.Mode = 1;
         this.dose.Background.Color = "536870912";
         this.dose.EditMask.MaskDataType = Mobilize.Web.MaskDataType.NumericMask;
         this.socialsecurity = new Mobilize.Web.DmColumn();
         this.socialsecurity.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.socialsecurity.Id = 1;
         this.socialsecurity.Alignment = 0;
         this.socialsecurity.TabSequence = 30;
         this.socialsecurity.Border = 0;
         this.socialsecurity.Color = "33554432";
         this.socialsecurity.X = 2565;
         this.socialsecurity.Y = 32;
         this.socialsecurity.Height = 64;
         this.socialsecurity.Width = 398;
         this.socialsecurity.Format = "@@@ @@ @@@@";
         this.socialsecurity.Name = Mobilize.Web.CaseExtensions.String("socialsecurity");
         this.socialsecurity.Visible = true;
         this.socialsecurity.Edit.Limit = 0;
         this.socialsecurity.Edit.Case = "any";
         this.socialsecurity.Edit.Format = "@@@-@@-@@@@";
         this.socialsecurity.Edit.FocusRectangle = false;
         this.socialsecurity.Edit.AutoSelect = false;
         this.socialsecurity.Edit.DisplayOnly = true;
         this.socialsecurity.Font.FontFace = "Tahoma";
         this.socialsecurity.Font.Height = -10;
         this.socialsecurity.Font.Weight = 400;
         this.socialsecurity.Font.FontFamily = "2";
         this.socialsecurity.Font.Pitch = "2";
         this.socialsecurity.Font.Charset = "0";
         this.socialsecurity.Background.Mode = 2;
         this.socialsecurity.Background.Color = "1073741824";
         this.socialsecurity.EditMask.MaskDataType = Mobilize.Web.MaskDataType.StringMask;
         this.t_1 = new Mobilize.Web.DmText();
         this.t_1.Band = Mobilize.Web.CaseExtensions.String("footer");
         this.t_1.Alignment = 0;
         this.t_1.Text = "Count:";
         this.t_1.Border = 0;
         this.t_1.Color = "33554432";
         this.t_1.X = 5;
         this.t_1.Y = 0;
         this.t_1.Height = 64;
         this.t_1.Width = 229;
         this.t_1.Name = Mobilize.Web.CaseExtensions.String("t_1");
         this.t_1.Visible = true;
         this.t_1.Font.FontFace = "Tahoma";
         this.t_1.Font.Height = -10;
         this.t_1.Font.Weight = 400;
         this.t_1.Font.FontFamily = "2";
         this.t_1.Font.Pitch = "2";
         this.t_1.Font.Charset = "0";
         this.t_1.Background.Mode = 2;
         this.t_1.Background.Color = "1073741824";
         this.compute_1 = new Mobilize.Web.DmCompute();
         this.compute_1.Band = Mobilize.Web.CaseExtensions.String("footer");
         this.compute_1.Alignment = 0;
         this.compute_1.Expression = "rowcount()";
         this.compute_1.Border = 0;
         this.compute_1.Color = "33554432";
         this.compute_1.X = 242;
         this.compute_1.Y = 0;
         this.compute_1.Height = 64;
         this.compute_1.Width = 704;
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
         this.AddColumns(new Mobilize.Web.DB.Column[] { socialsecurity_db1, iid_db2, medicine_db3, patient_db4, dose_db5 });
         this.AddControls(new Mobilize.Web.DmControl[] { this.id_t, this.medicine_t, this.patient_t, this.dose_t, this.socialsecurity_t, this.iid, this.medicine, this.patient, this.dose, this.socialsecurity, this.t_1, this.compute_1 });
         this.PopulateRadioButtons();
      }
   }

}