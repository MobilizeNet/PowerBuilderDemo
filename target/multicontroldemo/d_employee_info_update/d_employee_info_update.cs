namespace multicontroldemo
{

   [Mobilize.WebMap.Common.Attributes.Observable]
   public partial class d_employee_info_update
      : Mobilize.Web.DataManager, Mobilize.Web.IDataManager
   {

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmGroupBox gb_1 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText tname_t { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn tname { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn tdescription { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText tdepartment_t { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn tdepartment { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText thiredate_t { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn thiredate { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn tage { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText tage_t { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText tsalary_t { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn tsalary { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText tcategory_t { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn tcategory { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText tlastlogin_t { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn tlastlogin { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn tregistered { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn level { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText t_1 { get; set; }


      public d_employee_info_update()
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
         this.Header.Height = 20;
         this.Header.Color = "536870912";
         this.Summary.Height = 0;
         this.Summary.Color = "536870912";
         this.Footer.Height = 0;
         this.Footer.Color = "536870912";
         this.Detail.Height = 748;
         this.Detail.Color = "536870912";
         var level_db1 = new Mobilize.Web.DB.Column();
         level_db1.Type = Mobilize.Web.CaseExtensions.String("char(1)");
         level_db1.UpdateWhereClause = false;
         level_db1.Name = Mobilize.Web.CaseExtensions.String("level");
         level_db1.DbName = "name_2";
         level_db1.Initial = "A";
         level_db1.Values = "First\tA/Second\tB/";
         var tregistered_db2 = new Mobilize.Web.DB.Column();
         tregistered_db2.Type = Mobilize.Web.CaseExtensions.String("number");
         tregistered_db2.UpdateWhereClause = false;
         tregistered_db2.Name = Mobilize.Web.CaseExtensions.String("tregistered");
         tregistered_db2.DbName = "name_1";
         tregistered_db2.Initial = "200";
         tregistered_db2.Values = "Registered\t200/Registered\t0";
         var tname_db3 = new Mobilize.Web.DB.Column();
         tname_db3.Type = Mobilize.Web.CaseExtensions.String("char(10)");
         tname_db3.UpdateWhereClause = false;
         tname_db3.Name = Mobilize.Web.CaseExtensions.String("tname");
         tname_db3.DbName = "tname";
         var tage_db4 = new Mobilize.Web.DB.Column();
         tage_db4.Type = Mobilize.Web.CaseExtensions.String("number");
         tage_db4.UpdateWhereClause = false;
         tage_db4.Name = Mobilize.Web.CaseExtensions.String("tage");
         tage_db4.DbName = "tage";
         var tdescription_db5 = new Mobilize.Web.DB.Column();
         tdescription_db5.Type = Mobilize.Web.CaseExtensions.String("char(200)");
         tdescription_db5.UpdateWhereClause = false;
         tdescription_db5.Name = Mobilize.Web.CaseExtensions.String("tdescription");
         tdescription_db5.DbName = "tdescription";
         var tdepartment_db6 = new Mobilize.Web.DB.Column();
         tdepartment_db6.Type = Mobilize.Web.CaseExtensions.String("number");
         tdepartment_db6.UpdateWhereClause = false;
         tdepartment_db6.Name = Mobilize.Web.CaseExtensions.String("tdepartment");
         tdepartment_db6.DbName = "tdepartment";
         var tsalary_db7 = new Mobilize.Web.DB.Column();
         tsalary_db7.Type = Mobilize.Web.CaseExtensions.String("decimal(2)");
         tsalary_db7.UpdateWhereClause = false;
         tsalary_db7.Name = Mobilize.Web.CaseExtensions.String("tsalary");
         tsalary_db7.DbName = "tsalary";
         var tcategory_db8 = new Mobilize.Web.DB.Column();
         tcategory_db8.Type = Mobilize.Web.CaseExtensions.String("number");
         tcategory_db8.UpdateWhereClause = false;
         tcategory_db8.Name = Mobilize.Web.CaseExtensions.String("tcategory");
         tcategory_db8.DbName = "tcategory";
         tcategory_db8.Values = "J1\t10/J2\t20/J3\t30/";
         var thiredate_db9 = new Mobilize.Web.DB.Column();
         thiredate_db9.Type = Mobilize.Web.CaseExtensions.String("date");
         thiredate_db9.UpdateWhereClause = false;
         thiredate_db9.Name = Mobilize.Web.CaseExtensions.String("thiredate");
         thiredate_db9.DbName = "thiredate";
         var tlastlogin_db10 = new Mobilize.Web.DB.Column();
         tlastlogin_db10.Type = Mobilize.Web.CaseExtensions.String("datetime");
         tlastlogin_db10.UpdateWhereClause = false;
         tlastlogin_db10.Name = Mobilize.Web.CaseExtensions.String("tlastlogin");
         tlastlogin_db10.DbName = "tlastlogin";
         this.gb_1 = new Mobilize.Web.DmGroupBox();
         this.gb_1.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.gb_1.Text = "Description";
         this.gb_1.Border = "2";
         this.gb_1.Color = "33554432";
         this.gb_1.X = 101;
         this.gb_1.Y = 100;
         this.gb_1.Height = 344;
         this.gb_1.Width = 2048;
         this.gb_1.Name = Mobilize.Web.CaseExtensions.String("gb_1");
         this.gb_1.Visible = true;
         this.gb_1.Font.FontFace = "Tahoma";
         this.gb_1.Font.Height = -10;
         this.gb_1.Font.Weight = 400;
         this.gb_1.Font.FontFamily = "2";
         this.gb_1.Font.Pitch = "2";
         this.gb_1.Font.Charset = "0";
         this.gb_1.Background.Mode = 2;
         this.gb_1.Background.Color = "1073741824";
         this.tname_t = new Mobilize.Web.DmText();
         this.tname_t.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.tname_t.Alignment = 1;
         this.tname_t.Text = "Name:";
         this.tname_t.Border = 0;
         this.tname_t.Color = "33554432";
         this.tname_t.X = 37;
         this.tname_t.Y = 4;
         this.tname_t.Height = 64;
         this.tname_t.Width = 361;
         this.tname_t.Name = Mobilize.Web.CaseExtensions.String("tname_t");
         this.tname_t.Visible = true;
         this.tname_t.Font.FontFace = "Tahoma";
         this.tname_t.Font.Height = -10;
         this.tname_t.Font.Weight = 400;
         this.tname_t.Font.FontFamily = "2";
         this.tname_t.Font.Pitch = "2";
         this.tname_t.Font.Charset = "0";
         this.tname_t.Background.Mode = 1;
         this.tname_t.Background.Color = "536870912";
         this.tname = new Mobilize.Web.DmColumn();
         this.tname.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.tname.Id = 3;
         this.tname.Alignment = 0;
         this.tname.TabSequence = 10;
         this.tname.Border = 0;
         this.tname.Color = "33554432";
         this.tname.X = 434;
         this.tname.Y = 4;
         this.tname.Height = 80;
         this.tname.Width = 649;
         this.tname.Format = "[general]";
         this.tname.Name = Mobilize.Web.CaseExtensions.String("tname");
         this.tname.Visible = true;
         this.tname.Edit.Limit = 0;
         this.tname.Edit.Case = "any";
         this.tname.Edit.FocusRectangle = false;
         this.tname.Edit.AutoSelect = true;
         this.tname.Edit.AutoHScroll = true;
         this.tname.Font.FontFace = "Tahoma";
         this.tname.Font.Height = -10;
         this.tname.Font.Weight = 400;
         this.tname.Font.FontFamily = "2";
         this.tname.Font.Pitch = "2";
         this.tname.Font.Charset = "0";
         this.tname.Background.Mode = 1;
         this.tname.Background.Color = "536870912";
         this.tname.EditMask.MaskDataType = Mobilize.Web.MaskDataType.StringMask;
         this.tdescription = new Mobilize.Web.DmColumn();
         this.tdescription.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.tdescription.Id = 5;
         this.tdescription.Alignment = 0;
         this.tdescription.TabSequence = 30;
         this.tdescription.Border = 0;
         this.tdescription.Color = "33554432";
         this.tdescription.X = 128;
         this.tdescription.Y = 176;
         this.tdescription.Height = 236;
         this.tdescription.Width = 1989;
         this.tdescription.Format = "[general]";
         this.tdescription.Name = Mobilize.Web.CaseExtensions.String("tdescription");
         this.tdescription.Visible = true;
         this.tdescription.Edit.Limit = 0;
         this.tdescription.Edit.Case = "any";
         this.tdescription.Edit.FocusRectangle = false;
         this.tdescription.Edit.AutoSelect = true;
         this.tdescription.Edit.AutoHScroll = true;
         this.tdescription.Font.FontFace = "Tahoma";
         this.tdescription.Font.Height = -10;
         this.tdescription.Font.Weight = 400;
         this.tdescription.Font.FontFamily = "2";
         this.tdescription.Font.Pitch = "2";
         this.tdescription.Font.Charset = "0";
         this.tdescription.Background.Mode = 1;
         this.tdescription.Background.Color = "536870912";
         this.tdescription.EditMask.MaskDataType = Mobilize.Web.MaskDataType.StringMask;
         this.tdepartment_t = new Mobilize.Web.DmText();
         this.tdepartment_t.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.tdepartment_t.Alignment = 1;
         this.tdepartment_t.Text = "Department";
         this.tdepartment_t.Border = 0;
         this.tdepartment_t.Color = "33554432";
         this.tdepartment_t.X = 1806;
         this.tdepartment_t.Y = 12;
         this.tdepartment_t.Height = 64;
         this.tdepartment_t.Width = 361;
         this.tdepartment_t.Name = Mobilize.Web.CaseExtensions.String("tdepartment_t");
         this.tdepartment_t.Visible = true;
         this.tdepartment_t.Font.FontFace = "Tahoma";
         this.tdepartment_t.Font.Height = -10;
         this.tdepartment_t.Font.Weight = 400;
         this.tdepartment_t.Font.FontFamily = "2";
         this.tdepartment_t.Font.Pitch = "2";
         this.tdepartment_t.Font.Charset = "0";
         this.tdepartment_t.Background.Mode = 1;
         this.tdepartment_t.Background.Color = "536870912";
         this.tdepartment = new Mobilize.Web.DmColumn();
         this.tdepartment.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.tdepartment.Id = 6;
         this.tdepartment.Alignment = 1;
         this.tdepartment.TabSequence = 40;
         this.tdepartment.Border = 0;
         this.tdepartment.Color = "33554432";
         this.tdepartment.X = 2199;
         this.tdepartment.Y = 4;
         this.tdepartment.Height = 76;
         this.tdepartment.Width = 338;
         this.tdepartment.Format = "[general]";
         this.tdepartment.Name = Mobilize.Web.CaseExtensions.String("tdepartment");
         this.tdepartment.Visible = true;
         this.tdepartment.DdDm.DataManager = Mobilize.Web.CaseExtensions.String("d_employee_dept_info_update_dddw");
         this.tdepartment.DdDm.DisplayColumn = Mobilize.Web.CaseExtensions.String("tdname");
         this.tdepartment.DdDm.DataColumn = Mobilize.Web.CaseExtensions.String("tdip");
         this.tdepartment.DdDm.PercentWidth = 0;
         this.tdepartment.DdDm.Lines = 0;
         this.tdepartment.DdDm.Limit = 0;
         this.tdepartment.DdDm.AllowEdit = false;
         this.tdepartment.DdDm.UseAsBorder = false;
         this.tdepartment.DdDm.Case = Mobilize.Web.CaseExtensions.String("any");
         this.tdepartment.Font.FontFace = "Tahoma";
         this.tdepartment.Font.Height = -10;
         this.tdepartment.Font.Weight = 400;
         this.tdepartment.Font.FontFamily = "2";
         this.tdepartment.Font.Pitch = "2";
         this.tdepartment.Font.Charset = "0";
         this.tdepartment.Background.Mode = 1;
         this.tdepartment.Background.Color = "536870912";
         this.tdepartment.EditMask.MaskDataType = Mobilize.Web.MaskDataType.NumericMask;
         this.thiredate_t = new Mobilize.Web.DmText();
         this.thiredate_t.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.thiredate_t.Alignment = 1;
         this.thiredate_t.Text = "Hire date:";
         this.thiredate_t.Border = 0;
         this.thiredate_t.Color = "33554432";
         this.thiredate_t.X = 46;
         this.thiredate_t.Y = 620;
         this.thiredate_t.Height = 64;
         this.thiredate_t.Width = 361;
         this.thiredate_t.Name = Mobilize.Web.CaseExtensions.String("thiredate_t");
         this.thiredate_t.Visible = true;
         this.thiredate_t.Font.FontFace = "Tahoma";
         this.thiredate_t.Font.Height = -10;
         this.thiredate_t.Font.Weight = 400;
         this.thiredate_t.Font.FontFamily = "2";
         this.thiredate_t.Font.Pitch = "2";
         this.thiredate_t.Font.Charset = "0";
         this.thiredate_t.Background.Mode = 1;
         this.thiredate_t.Background.Color = "536870912";
         this.thiredate = new Mobilize.Web.DmColumn();
         this.thiredate.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.thiredate.Id = 9;
         this.thiredate.Alignment = 0;
         this.thiredate.TabSequence = 70;
         this.thiredate.Border = 0;
         this.thiredate.Color = "33554432";
         this.thiredate.X = 480;
         this.thiredate.Y = 616;
         this.thiredate.Height = 76;
         this.thiredate.Width = 421;
         this.thiredate.Format = "[general]";
         this.thiredate.Name = Mobilize.Web.CaseExtensions.String("thiredate");
         this.thiredate.Visible = true;
         this.thiredate.EditMask.Mask = "mm/dd/yyyy";
         this.thiredate.EditMask.FocusRectangle = false;
         this.thiredate.Font.FontFace = "Tahoma";
         this.thiredate.Font.Height = -10;
         this.thiredate.Font.Weight = 400;
         this.thiredate.Font.FontFamily = "2";
         this.thiredate.Font.Pitch = "2";
         this.thiredate.Font.Charset = "0";
         this.thiredate.Background.Mode = 1;
         this.thiredate.Background.Color = "536870912";
         this.thiredate.EditMask.MaskDataType = Mobilize.Web.MaskDataType.DateMask;
         this.tage = new Mobilize.Web.DmColumn();
         this.tage.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.tage.Id = 4;
         this.tage.Alignment = 1;
         this.tage.TabSequence = 20;
         this.tage.Border = 0;
         this.tage.Color = "33554432";
         this.tage.X = 1522;
         this.tage.Y = 8;
         this.tage.Height = 76;
         this.tage.Width = 219;
         this.tage.Format = "[general]";
         this.tage.Name = Mobilize.Web.CaseExtensions.String("tage");
         this.tage.Visible = true;
         this.tage.Edit.Limit = 0;
         this.tage.Edit.Case = "any";
         this.tage.Edit.FocusRectangle = false;
         this.tage.Edit.AutoSelect = true;
         this.tage.Edit.AutoHScroll = true;
         this.tage.Font.FontFace = "Tahoma";
         this.tage.Font.Height = -10;
         this.tage.Font.Weight = 400;
         this.tage.Font.FontFamily = "2";
         this.tage.Font.Pitch = "2";
         this.tage.Font.Charset = "0";
         this.tage.Background.Mode = 1;
         this.tage.Background.Color = "536870912";
         this.tage.EditMask.MaskDataType = Mobilize.Web.MaskDataType.NumericMask;
         this.tage_t = new Mobilize.Web.DmText();
         this.tage_t.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.tage_t.Alignment = 1;
         this.tage_t.Text = "Age";
         this.tage_t.Border = 0;
         this.tage_t.Color = "33554432";
         this.tage_t.X = 1129;
         this.tage_t.Y = 8;
         this.tage_t.Height = 64;
         this.tage_t.Width = 361;
         this.tage_t.Name = Mobilize.Web.CaseExtensions.String("tage_t");
         this.tage_t.Visible = true;
         this.tage_t.Font.FontFace = "Tahoma";
         this.tage_t.Font.Height = -10;
         this.tage_t.Font.Weight = 400;
         this.tage_t.Font.FontFamily = "2";
         this.tage_t.Font.Pitch = "2";
         this.tage_t.Font.Charset = "0";
         this.tage_t.Background.Mode = 1;
         this.tage_t.Background.Color = "536870912";
         this.tsalary_t = new Mobilize.Web.DmText();
         this.tsalary_t.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.tsalary_t.Alignment = 1;
         this.tsalary_t.Text = "Salary";
         this.tsalary_t.Border = 0;
         this.tsalary_t.Color = "33554432";
         this.tsalary_t.X = 64;
         this.tsalary_t.Y = 508;
         this.tsalary_t.Height = 64;
         this.tsalary_t.Width = 361;
         this.tsalary_t.Name = Mobilize.Web.CaseExtensions.String("tsalary_t");
         this.tsalary_t.Visible = true;
         this.tsalary_t.Font.FontFace = "Tahoma";
         this.tsalary_t.Font.Height = -10;
         this.tsalary_t.Font.Weight = 400;
         this.tsalary_t.Font.FontFamily = "2";
         this.tsalary_t.Font.Pitch = "2";
         this.tsalary_t.Font.Charset = "0";
         this.tsalary_t.Background.Mode = 1;
         this.tsalary_t.Background.Color = "536870912";
         this.tsalary = new Mobilize.Web.DmColumn();
         this.tsalary.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.tsalary.Id = 7;
         this.tsalary.Alignment = 0;
         this.tsalary.TabSequence = 50;
         this.tsalary.Border = 0;
         this.tsalary.Color = "33554432";
         this.tsalary.X = 466;
         this.tsalary.Y = 508;
         this.tsalary.Height = 92;
         this.tsalary.Width = 366;
         this.tsalary.Format = "[general]";
         this.tsalary.Name = Mobilize.Web.CaseExtensions.String("tsalary");
         this.tsalary.Visible = true;
         this.tsalary.EditMask.Mask = "###,###.00";
         this.tsalary.EditMask.FocusRectangle = false;
         this.tsalary.Font.FontFace = "Tahoma";
         this.tsalary.Font.Height = -10;
         this.tsalary.Font.Weight = 400;
         this.tsalary.Font.FontFamily = "2";
         this.tsalary.Font.Pitch = "2";
         this.tsalary.Font.Charset = "0";
         this.tsalary.Background.Mode = 1;
         this.tsalary.Background.Color = "536870912";
         this.tsalary.EditMask.MaskDataType = Mobilize.Web.MaskDataType.DecimalMask;
         this.tcategory_t = new Mobilize.Web.DmText();
         this.tcategory_t.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.tcategory_t.Alignment = 1;
         this.tcategory_t.Text = "Category";
         this.tcategory_t.Border = 0;
         this.tcategory_t.Color = "33554432";
         this.tcategory_t.X = 859;
         this.tcategory_t.Y = 504;
         this.tcategory_t.Height = 64;
         this.tcategory_t.Width = 361;
         this.tcategory_t.Name = Mobilize.Web.CaseExtensions.String("tcategory_t");
         this.tcategory_t.Visible = true;
         this.tcategory_t.Font.FontFace = "Tahoma";
         this.tcategory_t.Font.Height = -10;
         this.tcategory_t.Font.Weight = 400;
         this.tcategory_t.Font.FontFamily = "2";
         this.tcategory_t.Font.Pitch = "2";
         this.tcategory_t.Font.Charset = "0";
         this.tcategory_t.Background.Mode = 1;
         this.tcategory_t.Background.Color = "536870912";
         this.tcategory = new Mobilize.Web.DmColumn();
         this.tcategory.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.tcategory.Id = 8;
         this.tcategory.Alignment = 1;
         this.tcategory.TabSequence = 60;
         this.tcategory.Border = 0;
         this.tcategory.Color = "33554432";
         this.tcategory.X = 1271;
         this.tcategory.Y = 516;
         this.tcategory.Height = 84;
         this.tcategory.Width = 329;
         this.tcategory.Format = "[general]";
         this.tcategory.Name = Mobilize.Web.CaseExtensions.String("tcategory");
         this.tcategory.Visible = true;
         this.tcategory.DdLb.Limit = 0;
         this.tcategory.DdLb.AllowEdit = false;
         this.tcategory.DdLb.Case = Mobilize.Web.CaseExtensions.String("any");
         this.tcategory.Font.FontFace = "Tahoma";
         this.tcategory.Font.Height = -10;
         this.tcategory.Font.Weight = 400;
         this.tcategory.Font.FontFamily = "2";
         this.tcategory.Font.Pitch = "2";
         this.tcategory.Font.Charset = "0";
         this.tcategory.Background.Mode = 1;
         this.tcategory.Background.Color = "536870912";
         this.tcategory.EditMask.MaskDataType = Mobilize.Web.MaskDataType.NumericMask;
         this.tlastlogin_t = new Mobilize.Web.DmText();
         this.tlastlogin_t.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.tlastlogin_t.Alignment = 1;
         this.tlastlogin_t.Text = "Last login:";
         this.tlastlogin_t.Border = 0;
         this.tlastlogin_t.Color = "33554432";
         this.tlastlogin_t.X = 997;
         this.tlastlogin_t.Y = 632;
         this.tlastlogin_t.Height = 64;
         this.tlastlogin_t.Width = 361;
         this.tlastlogin_t.Name = Mobilize.Web.CaseExtensions.String("tlastlogin_t");
         this.tlastlogin_t.Visible = true;
         this.tlastlogin_t.Font.FontFace = "Tahoma";
         this.tlastlogin_t.Font.Height = -10;
         this.tlastlogin_t.Font.Weight = 400;
         this.tlastlogin_t.Font.FontFamily = "2";
         this.tlastlogin_t.Font.Pitch = "2";
         this.tlastlogin_t.Font.Charset = "0";
         this.tlastlogin_t.Background.Mode = 1;
         this.tlastlogin_t.Background.Color = "536870912";
         this.tlastlogin = new Mobilize.Web.DmColumn();
         this.tlastlogin.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.tlastlogin.Id = 10;
         this.tlastlogin.Alignment = 0;
         this.tlastlogin.TabSequence = 80;
         this.tlastlogin.Border = 0;
         this.tlastlogin.Color = "33554432";
         this.tlastlogin.X = 1394;
         this.tlastlogin.Y = 632;
         this.tlastlogin.Height = 72;
         this.tlastlogin.Width = 805;
         this.tlastlogin.Format = "[shortdate] [time]";
         this.tlastlogin.Name = Mobilize.Web.CaseExtensions.String("tlastlogin");
         this.tlastlogin.Visible = true;
         this.tlastlogin.EditMask.Mask = "mm/dd/yyyy hh:mm:ss:fff";
         this.tlastlogin.EditMask.FocusRectangle = false;
         this.tlastlogin.Font.FontFace = "Tahoma";
         this.tlastlogin.Font.Height = -10;
         this.tlastlogin.Font.Weight = 400;
         this.tlastlogin.Font.FontFamily = "2";
         this.tlastlogin.Font.Pitch = "2";
         this.tlastlogin.Font.Charset = "0";
         this.tlastlogin.Background.Mode = 1;
         this.tlastlogin.Background.Color = "536870912";
         this.tlastlogin.EditMask.MaskDataType = Mobilize.Web.MaskDataType.DateTimeMask;
         this.tregistered = new Mobilize.Web.DmColumn();
         this.tregistered.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.tregistered.Id = 2;
         this.tregistered.Alignment = 0;
         this.tregistered.TabSequence = 90;
         this.tregistered.Border = 0;
         this.tregistered.Color = "33554432";
         this.tregistered.X = 2226;
         this.tregistered.Y = 144;
         this.tregistered.Height = 80;
         this.tregistered.Width = 398;
         this.tregistered.Name = Mobilize.Web.CaseExtensions.String("tregistered");
         this.tregistered.Visible = true;
         this.tregistered.CheckBox.Text = "Registered";
         this.tregistered.CheckBox.On = "200";
         this.tregistered.CheckBox.Off = "0";
         this.tregistered.Font.FontFace = "Tahoma";
         this.tregistered.Font.Height = -10;
         this.tregistered.Font.Weight = 400;
         this.tregistered.Font.FontFamily = "2";
         this.tregistered.Font.Pitch = "2";
         this.tregistered.Font.Charset = "0";
         this.tregistered.Background.Mode = 2;
         this.tregistered.Background.Color = "1073741824";
         this.level = new Mobilize.Web.DmColumn();
         this.level.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.level.Id = 1;
         this.level.Alignment = 0;
         this.level.TabSequence = 100;
         this.level.Border = 0;
         this.level.Color = "33554432";
         this.level.X = 2217;
         this.level.Y = 396;
         this.level.Height = 136;
         this.level.Width = 274;
         this.level.Name = Mobilize.Web.CaseExtensions.String("level");
         this.level.Visible = true;
         this.level.RadioButtons.Columns = 1;
         this.level.Font.FontFace = "Tahoma";
         this.level.Font.Height = -10;
         this.level.Font.Weight = 400;
         this.level.Font.FontFamily = "2";
         this.level.Font.Pitch = "2";
         this.level.Font.Charset = "0";
         this.level.Background.Mode = 2;
         this.level.Background.Color = "1073741824";
         this.t_1 = new Mobilize.Web.DmText();
         this.t_1.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.t_1.Alignment = 0;
         this.t_1.Text = "Level";
         this.t_1.Border = 0;
         this.t_1.Color = "33554432";
         this.t_1.X = 2240;
         this.t_1.Y = 284;
         this.t_1.Height = 64;
         this.t_1.Width = 133;
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
         this.AddColumns(new Mobilize.Web.DB.Column[] { level_db1, tregistered_db2, tname_db3, tage_db4, tdescription_db5, tdepartment_db6, tsalary_db7, tcategory_db8, thiredate_db9, tlastlogin_db10 });
         this.AddControls(new Mobilize.Web.DmControl[] { this.gb_1, this.tname_t, this.tname, this.tdescription, this.tdepartment_t, this.tdepartment, this.thiredate_t, this.thiredate, this.tage, this.tage_t, this.tsalary_t, this.tsalary, this.tcategory_t, this.tcategory, this.tlastlogin_t, this.tlastlogin, this.tregistered, this.level, this.t_1 });
         this.PopulateRadioButtons();
      }
   }

}