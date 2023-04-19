namespace medicationcenter
{

   [Mobilize.WebMap.Common.Attributes.Observable]
   public partial class d_addprescription
      : Mobilize.Web.DataManager, Mobilize.Web.IDataManager
   {

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText t_1 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText t_2 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn patient { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText t_4 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn iid { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText t_3 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn dose { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText t_5 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn medicine { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn socialsecurity { get; set; }


      public d_addprescription()
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
         this.Detail.Height = 736;
         this.Detail.Color = "536870912";
         var medicine_db1 = new Mobilize.Web.DB.Column();
         medicine_db1.Type = Mobilize.Web.CaseExtensions.String("number");
         medicine_db1.UpdateWhereClause = true;
         medicine_db1.Name = Mobilize.Web.CaseExtensions.String("medicine");
         medicine_db1.DbName = "name_2";
         var socialsecurity_db2 = new Mobilize.Web.DB.Column();
         socialsecurity_db2.Type = Mobilize.Web.CaseExtensions.String("char(9)");
         socialsecurity_db2.UpdateWhereClause = false;
         socialsecurity_db2.Name = Mobilize.Web.CaseExtensions.String("socialsecurity");
         socialsecurity_db2.DbName = "name_1";
         var dose_db3 = new Mobilize.Web.DB.Column();
         dose_db3.Type = Mobilize.Web.CaseExtensions.String("number");
         dose_db3.UpdateWhereClause = false;
         dose_db3.Name = Mobilize.Web.CaseExtensions.String("dose");
         dose_db3.DbName = "dose";
         var iid_db4 = new Mobilize.Web.DB.Column();
         iid_db4.Type = Mobilize.Web.CaseExtensions.String("number");
         iid_db4.UpdateWhereClause = false;
         iid_db4.Name = Mobilize.Web.CaseExtensions.String("iid");
         iid_db4.DbName = "id";
         var patient_db5 = new Mobilize.Web.DB.Column();
         patient_db5.Type = Mobilize.Web.CaseExtensions.String("number");
         patient_db5.UpdateWhereClause = false;
         patient_db5.Name = Mobilize.Web.CaseExtensions.String("patient");
         patient_db5.DbName = "patient";
         this.t_1 = new Mobilize.Web.DmText();
         this.t_1.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.t_1.Alignment = 1;
         this.t_1.Text = "Patient Name";
         this.t_1.Border = 0;
         this.t_1.Color = "33554432";
         this.t_1.X = 247;
         this.t_1.Y = 244;
         this.t_1.Height = 64;
         this.t_1.Width = 347;
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
         this.t_2 = new Mobilize.Web.DmText();
         this.t_2.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.t_2.Alignment = 1;
         this.t_2.Text = "Medicine Name";
         this.t_2.Border = 0;
         this.t_2.Color = "33554432";
         this.t_2.X = 242;
         this.t_2.Y = 352;
         this.t_2.Height = 64;
         this.t_2.Width = 398;
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
         this.patient = new Mobilize.Web.DmColumn();
         this.patient.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.patient.Id = 5;
         this.patient.Alignment = 0;
         this.patient.TabSequence = 10;
         this.patient.Border = 2;
         this.patient.Color = "33554432";
         this.patient.X = 827;
         this.patient.Y = 244;
         this.patient.Height = 64;
         this.patient.Width = 599;
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
         this.t_4 = new Mobilize.Web.DmText();
         this.t_4.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.t_4.Alignment = 1;
         this.t_4.Text = "Prescription No.:";
         this.t_4.Border = 0;
         this.t_4.Color = "33554432";
         this.t_4.X = 1509;
         this.t_4.Y = 68;
         this.t_4.Height = 64;
         this.t_4.Width = 434;
         this.t_4.Name = Mobilize.Web.CaseExtensions.String("t_4");
         this.t_4.Visible = false;
         this.t_4.Font.FontFace = "Tahoma";
         this.t_4.Font.Height = -10;
         this.t_4.Font.Weight = 400;
         this.t_4.Font.FontFamily = "2";
         this.t_4.Font.Pitch = "2";
         this.t_4.Font.Charset = "0";
         this.t_4.Background.Mode = 1;
         this.t_4.Background.Color = "536870912";
         this.iid = new Mobilize.Web.DmColumn();
         this.iid.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.iid.Id = 4;
         this.iid.Alignment = 0;
         this.iid.TabSequence = 32766;
         this.iid.Border = 0;
         this.iid.Color = "33554432";
         this.iid.X = 1975;
         this.iid.Y = 72;
         this.iid.Height = 64;
         this.iid.Width = 215;
         this.iid.Format = "[general]";
         this.iid.Name = Mobilize.Web.CaseExtensions.String("iid");
         this.iid.Visible = false;
         this.iid.Edit.Limit = 0;
         this.iid.Edit.Case = "any";
         this.iid.Edit.FocusRectangle = false;
         this.iid.Edit.AutoSelect = false;
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
         this.t_3 = new Mobilize.Web.DmText();
         this.t_3.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.t_3.Alignment = 1;
         this.t_3.Text = "Dose (gr)";
         this.t_3.Border = 0;
         this.t_3.Color = "33554432";
         this.t_3.X = 247;
         this.t_3.Y = 592;
         this.t_3.Height = 64;
         this.t_3.Width = 247;
         this.t_3.Name = Mobilize.Web.CaseExtensions.String("t_3");
         this.t_3.Visible = true;
         this.t_3.Font.FontFace = "Tahoma";
         this.t_3.Font.Height = -10;
         this.t_3.Font.Weight = 400;
         this.t_3.Font.FontFamily = "2";
         this.t_3.Font.Pitch = "2";
         this.t_3.Font.Charset = "0";
         this.t_3.Background.Mode = 1;
         this.t_3.Background.Color = "536870912";
         this.dose = new Mobilize.Web.DmColumn();
         this.dose.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.dose.Id = 3;
         this.dose.Alignment = 0;
         this.dose.TabSequence = 30;
         this.dose.Border = 2;
         this.dose.Color = "33554432";
         this.dose.X = 823;
         this.dose.Y = 584;
         this.dose.Height = 64;
         this.dose.Width = 297;
         this.dose.Format = "#.00 mg";
         this.dose.Name = Mobilize.Web.CaseExtensions.String("dose");
         this.dose.Visible = true;
         this.dose.EditMask.UseFormat = true;
         this.dose.EditMask.Mask = "#.00";
         this.dose.EditMask.FocusRectangle = false;
         this.dose.Font.FontFace = "Tahoma";
         this.dose.Font.Height = -10;
         this.dose.Font.Weight = 400;
         this.dose.Font.FontFamily = "2";
         this.dose.Font.Pitch = "2";
         this.dose.Font.Charset = "0";
         this.dose.Background.Mode = 1;
         this.dose.Background.Color = "536870912";
         this.dose.EditMask.MaskDataType = Mobilize.Web.MaskDataType.NumericMask;
         this.t_5 = new Mobilize.Web.DmText();
         this.t_5.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.t_5.Alignment = 0;
         this.t_5.Text = "Social Security";
         this.t_5.Border = 0;
         this.t_5.Color = "33554432";
         this.t_5.X = 238;
         this.t_5.Y = 460;
         this.t_5.Height = 64;
         this.t_5.Width = 384;
         this.t_5.Name = Mobilize.Web.CaseExtensions.String("t_5");
         this.t_5.Visible = true;
         this.t_5.Font.FontFace = "Tahoma";
         this.t_5.Font.Height = -10;
         this.t_5.Font.Weight = 400;
         this.t_5.Font.FontFamily = "2";
         this.t_5.Font.Pitch = "2";
         this.t_5.Font.Charset = "0";
         this.t_5.Background.Mode = 1;
         this.t_5.Background.Color = "536870912";
         this.medicine = new Mobilize.Web.DmColumn();
         this.medicine.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.medicine.Id = 1;
         this.medicine.Alignment = 0;
         this.medicine.TabSequence = 40;
         this.medicine.Border = 2;
         this.medicine.Color = "33554432";
         this.medicine.X = 827;
         this.medicine.Y = 348;
         this.medicine.Height = 64;
         this.medicine.Width = 585;
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
         this.medicine.Background.Mode = 2;
         this.medicine.Background.Color = "1073741824";
         this.medicine.EditMask.MaskDataType = Mobilize.Web.MaskDataType.NumericMask;
         this.socialsecurity = new Mobilize.Web.DmColumn();
         this.socialsecurity.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.socialsecurity.Id = 2;
         this.socialsecurity.Alignment = 0;
         this.socialsecurity.TabSequence = 50;
         this.socialsecurity.Border = 2;
         this.socialsecurity.Color = "33554432";
         this.socialsecurity.X = 827;
         this.socialsecurity.Y = 456;
         this.socialsecurity.Height = 64;
         this.socialsecurity.Width = 594;
         this.socialsecurity.Format = "@@@-@@-@@@@";
         this.socialsecurity.Name = Mobilize.Web.CaseExtensions.String("socialsecurity");
         this.socialsecurity.Visible = true;
         this.socialsecurity.Edit.Limit = 0;
         this.socialsecurity.Edit.Case = "any";
         this.socialsecurity.Edit.Format = "@@@@@@@@";
         this.socialsecurity.Edit.FocusRectangle = false;
         this.socialsecurity.Edit.AutoSelect = false;
         this.socialsecurity.Font.FontFace = "Tahoma";
         this.socialsecurity.Font.Height = -10;
         this.socialsecurity.Font.Weight = 400;
         this.socialsecurity.Font.FontFamily = "2";
         this.socialsecurity.Font.Pitch = "2";
         this.socialsecurity.Font.Charset = "0";
         this.socialsecurity.Background.Mode = 2;
         this.socialsecurity.Background.Color = "1073741824";
         this.socialsecurity.EditMask.MaskDataType = Mobilize.Web.MaskDataType.StringMask;
         this.AddColumns(new Mobilize.Web.DB.Column[] { medicine_db1, socialsecurity_db2, dose_db3, iid_db4, patient_db5 });
         this.AddControls(new Mobilize.Web.DmControl[] { this.t_1, this.t_2, this.patient, this.t_4, this.iid, this.t_3, this.dose, this.t_5, this.medicine, this.socialsecurity });
         this.PopulateRadioButtons();
      }
   }

}