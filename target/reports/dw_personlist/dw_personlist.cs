namespace reports
{

   [Mobilize.WebMap.Common.Attributes.Observable]
   public partial class dw_personlist
      : Mobilize.Web.DataManager, Mobilize.Web.IDataManager
   {

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText t_1 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmCompute compute_1 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmRectangle r_1 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmRectangle r_2 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmLine l_1 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmLine l_2 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmLine l_3 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmLine l_4 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmLine l_5 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmLine l_6 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmLine l_7 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText t_3 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText t_4 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText t_5 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText t_6 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText t_7 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText t_8 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn startdate { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn _name { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn lastname1 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn lastname2 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn age { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmLine l_8 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmLine l_9 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmLine l_10 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmLine l_11 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmLine l_12 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmLine l_13 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmLine l_14 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn registration { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmLine l_15 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmLine l_16 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmLine l_17 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmCompute compute_2 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmLine l_18 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmLine l_19 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmLine l_20 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmLine l_21 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmCompute compute_3 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText t_2 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmCompute compute_4 { get; set; }


      public dw_personlist()
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
         this.Header.Height = 280;
         this.Header.Color = "536870912";
         this.Summary.Height = 0;
         this.Summary.Color = "536870912";
         this.Footer.Height = 68;
         this.Footer.Color = "536870912";
         this.Detail.Height = 100;
         this.Detail.Color = "536870912";
         var name_db1 = new Mobilize.Web.DB.Column();
         name_db1.Type = Mobilize.Web.CaseExtensions.String("char(15)");
         name_db1.UpdateWhereClause = true;
         name_db1.Name = Mobilize.Web.CaseExtensions.String("name");
         name_db1.DbName = "Name";
         var lastname1_db2 = new Mobilize.Web.DB.Column();
         lastname1_db2.Type = Mobilize.Web.CaseExtensions.String("char(15)");
         lastname1_db2.UpdateWhereClause = true;
         lastname1_db2.Name = Mobilize.Web.CaseExtensions.String("lastname1");
         lastname1_db2.DbName = "LastName1";
         var lastname2_db3 = new Mobilize.Web.DB.Column();
         lastname2_db3.Type = Mobilize.Web.CaseExtensions.String("char(15)");
         lastname2_db3.UpdateWhereClause = true;
         lastname2_db3.Name = Mobilize.Web.CaseExtensions.String("lastname2");
         lastname2_db3.DbName = "LastName2";
         var age_db4 = new Mobilize.Web.DB.Column();
         age_db4.Type = Mobilize.Web.CaseExtensions.String("number");
         age_db4.UpdateWhereClause = true;
         age_db4.Name = Mobilize.Web.CaseExtensions.String("age");
         age_db4.DbName = "Age";
         var startdate_db5 = new Mobilize.Web.DB.Column();
         startdate_db5.Type = Mobilize.Web.CaseExtensions.String("date");
         startdate_db5.UpdateWhereClause = true;
         startdate_db5.Name = Mobilize.Web.CaseExtensions.String("startdate");
         startdate_db5.DbName = "StartDate";
         var country_db6 = new Mobilize.Web.DB.Column();
         country_db6.Type = Mobilize.Web.CaseExtensions.String("char(10)");
         country_db6.UpdateWhereClause = true;
         country_db6.Name = Mobilize.Web.CaseExtensions.String("country");
         country_db6.DbName = "Country";
         var registration_db7 = new Mobilize.Web.DB.Column();
         registration_db7.Type = Mobilize.Web.CaseExtensions.String("datetime");
         registration_db7.UpdateWhereClause = true;
         registration_db7.Name = Mobilize.Web.CaseExtensions.String("registration");
         registration_db7.DbName = "Registration";
         this.SortStatement = "country A startdate A ";
         var group1_dm = new Mobilize.Web.DmGroup();
         group1_dm.Level = 1;
         group1_dm.Header.Height = 128;
         group1_dm.Trailer.Height = 104;
         group1_dm.NewPage = true;
         group1_dm.Header.Color = "536870912";
         group1_dm.Trailer.Color = "536870912";
         group1_dm.GroupBy(new string[] { ("country") });
         var group2_dm = new Mobilize.Web.DmGroup();
         group2_dm.Level = 2;
         group2_dm.Header.Height = 104;
         group2_dm.Trailer.Height = 104;
         group2_dm.Header.Color = "536870912";
         group2_dm.Trailer.Color = "536870912";
         group2_dm.GroupBy(new string[] { ("startdate") });
         this.t_1 = new Mobilize.Web.DmText();
         this.t_1.Band = Mobilize.Web.CaseExtensions.String("header");
         this.t_1.Alignment = 0;
         this.t_1.Text = "Person Information";
         this.t_1.Border = 0;
         this.t_1.Color = "33554432";
         this.t_1.X = 658;
         this.t_1.Y = 64;
         this.t_1.Height = 92;
         this.t_1.Width = 965;
         this.t_1.Name = Mobilize.Web.CaseExtensions.String("t_1");
         this.t_1.Visible = true;
         this.t_1.Font.FontFace = "Verdana";
         this.t_1.Font.Height = -14;
         this.t_1.Font.Weight = 700;
         this.t_1.Font.FontFamily = "2";
         this.t_1.Font.Pitch = "2";
         this.t_1.Font.Charset = "0";
         this.t_1.Background.Mode = 2;
         this.t_1.Background.Color = "1073741824";
         this.compute_1 = new Mobilize.Web.DmCompute();
         this.compute_1.Band = Mobilize.Web.CaseExtensions.String("header.1");
         this.compute_1.Alignment = 0;
         this.compute_1.Expression = " \"These people are from: \" + country ";
         this.compute_1.Border = 2;
         this.compute_1.Color = "33554432";
         this.compute_1.X = 1728;
         this.compute_1.Y = 16;
         this.compute_1.Height = 92;
         this.compute_1.Width = 873;
         this.compute_1.Format = "[GENERAL]";
         this.compute_1.Name = Mobilize.Web.CaseExtensions.String("compute_1");
         this.compute_1.Visible = true;
         this.compute_1.Font.FontFace = "Times New Roman";
         this.compute_1.Font.Height = -9;
         this.compute_1.Font.Weight = 400;
         this.compute_1.Font.FontFamily = "1";
         this.compute_1.Font.Pitch = "2";
         this.compute_1.Font.Charset = "0";
         this.compute_1.Background.Mode = 2;
         this.compute_1.Background.Color = "1073741824";
         this.r_1 = new Mobilize.Web.DmRectangle();
         this.r_1.Band = Mobilize.Web.CaseExtensions.String("header.1");
         this.r_1.X = 1609;
         this.r_1.Y = 0;
         this.r_1.Height = 120;
         this.r_1.Width = 110;
         this.r_1.Name = Mobilize.Web.CaseExtensions.String("r_1");
         this.r_1.Visible = true;
         this.r_1.Brush.Hatch = "6";
         this.r_1.Brush.Color = "33554432";
         this.r_1.Pen.Style = 2;
         this.r_1.Pen.Width = 5;
         this.r_1.Pen.Color = "33554431";
         this.r_1.Background.Mode = 2;
         this.r_1.Background.Color = "33554432";
         this.r_2 = new Mobilize.Web.DmRectangle();
         this.r_2.Band = Mobilize.Web.CaseExtensions.String("header.1");
         this.r_2.X = 2638;
         this.r_2.Y = 4;
         this.r_2.Height = 120;
         this.r_2.Width = 110;
         this.r_2.Name = Mobilize.Web.CaseExtensions.String("r_2");
         this.r_2.Visible = true;
         this.r_2.Brush.Hatch = "6";
         this.r_2.Brush.Color = "33554432";
         this.r_2.Pen.Style = 2;
         this.r_2.Pen.Width = 5;
         this.r_2.Pen.Color = "33554431";
         this.r_2.Background.Mode = 2;
         this.r_2.Background.Color = "33554432";
         this.l_1 = new Mobilize.Web.DmLine();
         this.l_1.Band = Mobilize.Web.CaseExtensions.String("header.2");
         this.l_1.X1 = 23;
         this.l_1.Y1 = 0;
         this.l_1.X2 = 2441;
         this.l_1.Y2 = 0;
         this.l_1.Name = Mobilize.Web.CaseExtensions.String("l_1");
         this.l_1.Visible = true;
         this.l_1.Pen.Style = 0;
         this.l_1.Pen.Width = 5;
         this.l_1.Pen.Color = "33554432";
         this.l_1.Background.Mode = 2;
         this.l_1.Background.Color = "1073741824";
         this.l_2 = new Mobilize.Web.DmLine();
         this.l_2.Band = Mobilize.Web.CaseExtensions.String("header.2");
         this.l_2.X1 = 23;
         this.l_2.Y1 = 0;
         this.l_2.X2 = 23;
         this.l_2.Y2 = 100;
         this.l_2.Name = Mobilize.Web.CaseExtensions.String("l_2");
         this.l_2.Visible = true;
         this.l_2.Pen.Style = 0;
         this.l_2.Pen.Width = 5;
         this.l_2.Pen.Color = "33554432";
         this.l_2.Background.Mode = 2;
         this.l_2.Background.Color = "1073741824";
         this.l_3 = new Mobilize.Web.DmLine();
         this.l_3.Band = Mobilize.Web.CaseExtensions.String("header.2");
         this.l_3.X1 = 2441;
         this.l_3.Y1 = 0;
         this.l_3.X2 = 2441;
         this.l_3.Y2 = 100;
         this.l_3.Name = Mobilize.Web.CaseExtensions.String("l_3");
         this.l_3.Visible = true;
         this.l_3.Pen.Style = 0;
         this.l_3.Pen.Width = 5;
         this.l_3.Pen.Color = "33554432";
         this.l_3.Background.Mode = 2;
         this.l_3.Background.Color = "1073741824";
         this.l_4 = new Mobilize.Web.DmLine();
         this.l_4.Band = Mobilize.Web.CaseExtensions.String("header.2");
         this.l_4.X1 = 471;
         this.l_4.Y1 = 0;
         this.l_4.X2 = 471;
         this.l_4.Y2 = 100;
         this.l_4.Name = Mobilize.Web.CaseExtensions.String("l_4");
         this.l_4.Visible = true;
         this.l_4.Pen.Style = 0;
         this.l_4.Pen.Width = 5;
         this.l_4.Pen.Color = "33554432";
         this.l_4.Background.Mode = 2;
         this.l_4.Background.Color = "1073741824";
         this.l_5 = new Mobilize.Web.DmLine();
         this.l_5.Band = Mobilize.Web.CaseExtensions.String("header.2");
         this.l_5.X1 = 1010;
         this.l_5.Y1 = 0;
         this.l_5.X2 = 1010;
         this.l_5.Y2 = 100;
         this.l_5.Name = Mobilize.Web.CaseExtensions.String("l_5");
         this.l_5.Visible = true;
         this.l_5.Pen.Style = 0;
         this.l_5.Pen.Width = 5;
         this.l_5.Pen.Color = "33554432";
         this.l_5.Background.Mode = 2;
         this.l_5.Background.Color = "1073741824";
         this.l_6 = new Mobilize.Web.DmLine();
         this.l_6.Band = Mobilize.Web.CaseExtensions.String("header.2");
         this.l_6.X1 = 1527;
         this.l_6.Y1 = 0;
         this.l_6.X2 = 1527;
         this.l_6.Y2 = 100;
         this.l_6.Name = Mobilize.Web.CaseExtensions.String("l_6");
         this.l_6.Visible = true;
         this.l_6.Pen.Style = 0;
         this.l_6.Pen.Width = 5;
         this.l_6.Pen.Color = "33554432";
         this.l_6.Background.Mode = 2;
         this.l_6.Background.Color = "1073741824";
         this.l_7 = new Mobilize.Web.DmLine();
         this.l_7.Band = Mobilize.Web.CaseExtensions.String("header.2");
         this.l_7.X1 = 2002;
         this.l_7.Y1 = 0;
         this.l_7.X2 = 2002;
         this.l_7.Y2 = 100;
         this.l_7.Name = Mobilize.Web.CaseExtensions.String("l_7");
         this.l_7.Visible = true;
         this.l_7.Pen.Style = 0;
         this.l_7.Pen.Width = 5;
         this.l_7.Pen.Color = "33554432";
         this.l_7.Background.Mode = 2;
         this.l_7.Background.Color = "1073741824";
         this.t_3 = new Mobilize.Web.DmText();
         this.t_3.Band = Mobilize.Web.CaseExtensions.String("header.2");
         this.t_3.Alignment = 0;
         this.t_3.Text = "Name";
         this.t_3.Border = 0;
         this.t_3.Color = "33554432";
         this.t_3.X = 91;
         this.t_3.Y = 24;
         this.t_3.Height = 64;
         this.t_3.Width = 160;
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
         this.t_4 = new Mobilize.Web.DmText();
         this.t_4.Band = Mobilize.Web.CaseExtensions.String("header.2");
         this.t_4.Alignment = 0;
         this.t_4.Text = "LastName 1";
         this.t_4.Border = 0;
         this.t_4.Color = "33554432";
         this.t_4.X = 530;
         this.t_4.Y = 24;
         this.t_4.Height = 64;
         this.t_4.Width = 343;
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
         this.t_5 = new Mobilize.Web.DmText();
         this.t_5.Band = Mobilize.Web.CaseExtensions.String("header.2");
         this.t_5.Alignment = 0;
         this.t_5.Text = "LastName2";
         this.t_5.Border = 0;
         this.t_5.Color = "33554432";
         this.t_5.X = 1065;
         this.t_5.Y = 20;
         this.t_5.Height = 64;
         this.t_5.Width = 325;
         this.t_5.Name = Mobilize.Web.CaseExtensions.String("t_5");
         this.t_5.Visible = true;
         this.t_5.Font.FontFace = "Tahoma";
         this.t_5.Font.Height = -10;
         this.t_5.Font.Weight = 700;
         this.t_5.Font.FontFamily = "2";
         this.t_5.Font.Pitch = "2";
         this.t_5.Font.Charset = "0";
         this.t_5.Background.Mode = 2;
         this.t_5.Background.Color = "1073741824";
         this.t_6 = new Mobilize.Web.DmText();
         this.t_6.Band = Mobilize.Web.CaseExtensions.String("header.2");
         this.t_6.Alignment = 0;
         this.t_6.Text = "Age";
         this.t_6.Border = 0;
         this.t_6.Color = "33554432";
         this.t_6.X = 1691;
         this.t_6.Y = 20;
         this.t_6.Height = 64;
         this.t_6.Width = 123;
         this.t_6.Name = Mobilize.Web.CaseExtensions.String("t_6");
         this.t_6.Visible = true;
         this.t_6.Font.FontFace = "Tahoma";
         this.t_6.Font.Height = -10;
         this.t_6.Font.Weight = 700;
         this.t_6.Font.FontFamily = "2";
         this.t_6.Font.Pitch = "2";
         this.t_6.Font.Charset = "0";
         this.t_6.Background.Mode = 2;
         this.t_6.Background.Color = "1073741824";
         this.t_7 = new Mobilize.Web.DmText();
         this.t_7.Band = Mobilize.Web.CaseExtensions.String("header.2");
         this.t_7.Alignment = 0;
         this.t_7.Text = "Reg. Date";
         this.t_7.Border = 0;
         this.t_7.Color = "33554432";
         this.t_7.X = 2071;
         this.t_7.Y = 28;
         this.t_7.Height = 64;
         this.t_7.Width = 293;
         this.t_7.Name = Mobilize.Web.CaseExtensions.String("t_7");
         this.t_7.Visible = true;
         this.t_7.Font.FontFace = "Tahoma";
         this.t_7.Font.Height = -10;
         this.t_7.Font.Weight = 700;
         this.t_7.Font.FontFamily = "2";
         this.t_7.Font.Pitch = "2";
         this.t_7.Font.Charset = "0";
         this.t_7.Background.Mode = 2;
         this.t_7.Background.Color = "1073741824";
         this.t_8 = new Mobilize.Web.DmText();
         this.t_8.Band = Mobilize.Web.CaseExtensions.String("header.2");
         this.t_8.Alignment = 0;
         this.t_8.Text = "Start Date: ";
         this.t_8.Border = 0;
         this.t_8.Color = "33554432";
         this.t_8.X = 2533;
         this.t_8.Y = 32;
         this.t_8.Height = 64;
         this.t_8.Width = 306;
         this.t_8.Name = Mobilize.Web.CaseExtensions.String("t_8");
         this.t_8.Visible = true;
         this.t_8.Font.FontFace = "Tahoma";
         this.t_8.Font.Height = -10;
         this.t_8.Font.Weight = 400;
         this.t_8.Font.FontFamily = "2";
         this.t_8.Font.Pitch = "2";
         this.t_8.Font.Charset = "0";
         this.t_8.Background.Mode = 2;
         this.t_8.Background.Color = "1073741824";
         this.startdate = new Mobilize.Web.DmColumn();
         this.startdate.Band = Mobilize.Web.CaseExtensions.String("header.2");
         this.startdate.Id = 5;
         this.startdate.Alignment = 0;
         this.startdate.TabSequence = 60;
         this.startdate.Border = 0;
         this.startdate.Color = "33554432";
         this.startdate.X = 2871;
         this.startdate.Y = 32;
         this.startdate.Height = 64;
         this.startdate.Width = 325;
         this.startdate.Format = "[general]";
         this.startdate.Name = Mobilize.Web.CaseExtensions.String("startdate");
         this.startdate.Visible = true;
         this.startdate.Edit.Limit = 0;
         this.startdate.Edit.Case = "any";
         this.startdate.Edit.FocusRectangle = false;
         this.startdate.Edit.AutoSelect = false;
         this.startdate.Font.FontFace = "Tahoma";
         this.startdate.Font.Height = -10;
         this.startdate.Font.Weight = 400;
         this.startdate.Font.FontFamily = "2";
         this.startdate.Font.Pitch = "2";
         this.startdate.Font.Charset = "0";
         this.startdate.Background.Mode = 1;
         this.startdate.Background.Color = "536870912";
         this.startdate.EditMask.MaskDataType = Mobilize.Web.MaskDataType.DateMask;
         this._name = new Mobilize.Web.DmColumn();
         this._name.Band = Mobilize.Web.CaseExtensions.String("detail");
         this._name.Id = 1;
         this._name.Alignment = 0;
         this._name.TabSequence = 10;
         this._name.Border = 0;
         this._name.Color = "33554432";
         this._name.X = 41;
         this._name.Y = 12;
         this._name.Height = 76;
         this._name.Width = 379;
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
         this.lastname1 = new Mobilize.Web.DmColumn();
         this.lastname1.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.lastname1.Id = 2;
         this.lastname1.Alignment = 0;
         this.lastname1.TabSequence = 20;
         this.lastname1.Border = 0;
         this.lastname1.Color = "33554432";
         this.lastname1.X = 539;
         this.lastname1.Y = 12;
         this.lastname1.Height = 76;
         this.lastname1.Width = 411;
         this.lastname1.Format = "[general]";
         this.lastname1.Name = Mobilize.Web.CaseExtensions.String("lastname1");
         this.lastname1.Visible = true;
         this.lastname1.Edit.Limit = 0;
         this.lastname1.Edit.Case = "any";
         this.lastname1.Edit.FocusRectangle = false;
         this.lastname1.Edit.AutoSelect = true;
         this.lastname1.Edit.AutoHScroll = true;
         this.lastname1.Font.FontFace = "Tahoma";
         this.lastname1.Font.Height = -10;
         this.lastname1.Font.Weight = 400;
         this.lastname1.Font.FontFamily = "2";
         this.lastname1.Font.Pitch = "2";
         this.lastname1.Font.Charset = "0";
         this.lastname1.Background.Mode = 1;
         this.lastname1.Background.Color = "536870912";
         this.lastname1.EditMask.MaskDataType = Mobilize.Web.MaskDataType.StringMask;
         this.lastname2 = new Mobilize.Web.DmColumn();
         this.lastname2.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.lastname2.Id = 3;
         this.lastname2.Alignment = 0;
         this.lastname2.TabSequence = 30;
         this.lastname2.Border = 0;
         this.lastname2.Color = "33554432";
         this.lastname2.X = 1079;
         this.lastname2.Y = 12;
         this.lastname2.Height = 76;
         this.lastname2.Width = 411;
         this.lastname2.Format = "[general]";
         this.lastname2.Name = Mobilize.Web.CaseExtensions.String("lastname2");
         this.lastname2.Visible = true;
         this.lastname2.Edit.Limit = 0;
         this.lastname2.Edit.Case = "any";
         this.lastname2.Edit.FocusRectangle = false;
         this.lastname2.Edit.AutoSelect = true;
         this.lastname2.Edit.AutoHScroll = true;
         this.lastname2.Font.FontFace = "Tahoma";
         this.lastname2.Font.Height = -10;
         this.lastname2.Font.Weight = 400;
         this.lastname2.Font.FontFamily = "2";
         this.lastname2.Font.Pitch = "2";
         this.lastname2.Font.Charset = "0";
         this.lastname2.Background.Mode = 1;
         this.lastname2.Background.Color = "536870912";
         this.lastname2.EditMask.MaskDataType = Mobilize.Web.MaskDataType.StringMask;
         this.age = new Mobilize.Web.DmColumn();
         this.age.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.age.Id = 4;
         this.age.Alignment = 1;
         this.age.TabSequence = 40;
         this.age.Border = 0;
         this.age.Color = "33554432";
         this.age.X = 1669;
         this.age.Y = 8;
         this.age.Height = 76;
         this.age.Width = 219;
         this.age.Format = "[general]";
         this.age.Name = Mobilize.Web.CaseExtensions.String("age");
         this.age.Visible = true;
         this.age.Edit.Limit = 0;
         this.age.Edit.Case = "any";
         this.age.Edit.FocusRectangle = false;
         this.age.Edit.AutoSelect = true;
         this.age.Edit.AutoHScroll = true;
         this.age.Font.FontFace = "Tahoma";
         this.age.Font.Height = -10;
         this.age.Font.Weight = 400;
         this.age.Font.FontFamily = "2";
         this.age.Font.Pitch = "2";
         this.age.Font.Charset = "0";
         this.age.Background.Mode = 1;
         this.age.Background.Color = "536870912";
         this.age.EditMask.MaskDataType = Mobilize.Web.MaskDataType.NumericMask;
         this.l_8 = new Mobilize.Web.DmLine();
         this.l_8.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.l_8.X1 = 23;
         this.l_8.Y1 = 0;
         this.l_8.X2 = 2441;
         this.l_8.Y2 = 0;
         this.l_8.Name = Mobilize.Web.CaseExtensions.String("l_8");
         this.l_8.Visible = true;
         this.l_8.Pen.Style = 0;
         this.l_8.Pen.Width = 5;
         this.l_8.Pen.Color = "33554432";
         this.l_8.Background.Mode = 2;
         this.l_8.Background.Color = "33554431";
         this.l_9 = new Mobilize.Web.DmLine();
         this.l_9.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.l_9.X1 = 23;
         this.l_9.Y1 = 0;
         this.l_9.X2 = 23;
         this.l_9.Y2 = 100;
         this.l_9.Name = Mobilize.Web.CaseExtensions.String("l_9");
         this.l_9.Visible = true;
         this.l_9.Pen.Style = 0;
         this.l_9.Pen.Width = 5;
         this.l_9.Pen.Color = "33554432";
         this.l_9.Background.Mode = 2;
         this.l_9.Background.Color = "33554431";
         this.l_10 = new Mobilize.Web.DmLine();
         this.l_10.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.l_10.X1 = 471;
         this.l_10.Y1 = 0;
         this.l_10.X2 = 471;
         this.l_10.Y2 = 100;
         this.l_10.Name = Mobilize.Web.CaseExtensions.String("l_10");
         this.l_10.Visible = true;
         this.l_10.Pen.Style = 0;
         this.l_10.Pen.Width = 5;
         this.l_10.Pen.Color = "33554432";
         this.l_10.Background.Mode = 2;
         this.l_10.Background.Color = "33554431";
         this.l_11 = new Mobilize.Web.DmLine();
         this.l_11.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.l_11.X1 = 1010;
         this.l_11.Y1 = 0;
         this.l_11.X2 = 1010;
         this.l_11.Y2 = 100;
         this.l_11.Name = Mobilize.Web.CaseExtensions.String("l_11");
         this.l_11.Visible = true;
         this.l_11.Pen.Style = 0;
         this.l_11.Pen.Width = 5;
         this.l_11.Pen.Color = "33554432";
         this.l_11.Background.Mode = 2;
         this.l_11.Background.Color = "33554431";
         this.l_12 = new Mobilize.Web.DmLine();
         this.l_12.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.l_12.X1 = 1527;
         this.l_12.Y1 = 0;
         this.l_12.X2 = 1527;
         this.l_12.Y2 = 100;
         this.l_12.Name = Mobilize.Web.CaseExtensions.String("l_12");
         this.l_12.Visible = true;
         this.l_12.Pen.Style = 0;
         this.l_12.Pen.Width = 5;
         this.l_12.Pen.Color = "33554432";
         this.l_12.Background.Mode = 2;
         this.l_12.Background.Color = "1073741824";
         this.l_13 = new Mobilize.Web.DmLine();
         this.l_13.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.l_13.X1 = 2002;
         this.l_13.Y1 = 0;
         this.l_13.X2 = 2002;
         this.l_13.Y2 = 100;
         this.l_13.Name = Mobilize.Web.CaseExtensions.String("l_13");
         this.l_13.Visible = true;
         this.l_13.Pen.Style = 0;
         this.l_13.Pen.Width = 5;
         this.l_13.Pen.Color = "33554432";
         this.l_13.Background.Mode = 2;
         this.l_13.Background.Color = "1073741824";
         this.l_14 = new Mobilize.Web.DmLine();
         this.l_14.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.l_14.X1 = 2441;
         this.l_14.Y1 = 0;
         this.l_14.X2 = 2441;
         this.l_14.Y2 = 100;
         this.l_14.Name = Mobilize.Web.CaseExtensions.String("l_14");
         this.l_14.Visible = true;
         this.l_14.Pen.Style = 0;
         this.l_14.Pen.Width = 5;
         this.l_14.Pen.Color = "33554432";
         this.l_14.Background.Mode = 2;
         this.l_14.Background.Color = "33554431";
         this.registration = new Mobilize.Web.DmColumn();
         this.registration.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.registration.Id = 7;
         this.registration.Alignment = 0;
         this.registration.TabSequence = 50;
         this.registration.Border = 0;
         this.registration.Color = "33554432";
         this.registration.X = 2030;
         this.registration.Y = 16;
         this.registration.Height = 64;
         this.registration.Width = 393;
         this.registration.Format = "mm/dd/yyyy hh:mm";
         this.registration.Name = Mobilize.Web.CaseExtensions.String("registration");
         this.registration.Visible = true;
         this.registration.Edit.Limit = 0;
         this.registration.Edit.Case = "any";
         this.registration.Edit.FocusRectangle = false;
         this.registration.Edit.AutoSelect = false;
         this.registration.Font.FontFace = "Tahoma";
         this.registration.Font.Height = -8;
         this.registration.Font.Weight = 400;
         this.registration.Font.FontFamily = "2";
         this.registration.Font.Pitch = "2";
         this.registration.Font.Charset = "0";
         this.registration.Background.Mode = 1;
         this.registration.Background.Color = "536870912";
         this.registration.EditMask.MaskDataType = Mobilize.Web.MaskDataType.DateTimeMask;
         this.l_15 = new Mobilize.Web.DmLine();
         this.l_15.Band = Mobilize.Web.CaseExtensions.String("trailer.2");
         this.l_15.X1 = 23;
         this.l_15.Y1 = 0;
         this.l_15.X2 = 2441;
         this.l_15.Y2 = 0;
         this.l_15.Name = Mobilize.Web.CaseExtensions.String("l_15");
         this.l_15.Visible = true;
         this.l_15.Pen.Style = 0;
         this.l_15.Pen.Width = 5;
         this.l_15.Pen.Color = "33554432";
         this.l_15.Background.Mode = 2;
         this.l_15.Background.Color = "1073741824";
         this.l_16 = new Mobilize.Web.DmLine();
         this.l_16.Band = Mobilize.Web.CaseExtensions.String("trailer.2");
         this.l_16.X1 = 23;
         this.l_16.Y1 = 0;
         this.l_16.X2 = 23;
         this.l_16.Y2 = 100;
         this.l_16.Name = Mobilize.Web.CaseExtensions.String("l_16");
         this.l_16.Visible = true;
         this.l_16.Pen.Style = 0;
         this.l_16.Pen.Width = 5;
         this.l_16.Pen.Color = "33554432";
         this.l_16.Background.Mode = 2;
         this.l_16.Background.Color = "1073741824";
         this.l_17 = new Mobilize.Web.DmLine();
         this.l_17.Band = Mobilize.Web.CaseExtensions.String("trailer.2");
         this.l_17.X1 = 2441;
         this.l_17.Y1 = 0;
         this.l_17.X2 = 2441;
         this.l_17.Y2 = 100;
         this.l_17.Name = Mobilize.Web.CaseExtensions.String("l_17");
         this.l_17.Visible = true;
         this.l_17.Pen.Style = 0;
         this.l_17.Pen.Width = 5;
         this.l_17.Pen.Color = "33554432";
         this.l_17.Background.Mode = 2;
         this.l_17.Background.Color = "1073741824";
         this.compute_2 = new Mobilize.Web.DmCompute();
         this.compute_2.Band = Mobilize.Web.CaseExtensions.String("trailer.2");
         this.compute_2.Alignment = 0;
         this.compute_2.Expression = "\"Total Count of people per age: \" +  count( age for group 2 )";
         this.compute_2.Border = 0;
         this.compute_2.Color = "33554432";
         this.compute_2.X = 1079;
         this.compute_2.Y = 24;
         this.compute_2.Height = 64;
         this.compute_2.Width = 1294;
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
         this.l_18 = new Mobilize.Web.DmLine();
         this.l_18.Band = Mobilize.Web.CaseExtensions.String("trailer.1");
         this.l_18.X1 = 23;
         this.l_18.Y1 = 0;
         this.l_18.X2 = 2441;
         this.l_18.Y2 = 0;
         this.l_18.Name = Mobilize.Web.CaseExtensions.String("l_18");
         this.l_18.Visible = true;
         this.l_18.Pen.Style = 0;
         this.l_18.Pen.Width = 5;
         this.l_18.Pen.Color = "33554432";
         this.l_18.Background.Mode = 2;
         this.l_18.Background.Color = "33554431";
         this.l_19 = new Mobilize.Web.DmLine();
         this.l_19.Band = Mobilize.Web.CaseExtensions.String("trailer.1");
         this.l_19.X1 = 23;
         this.l_19.Y1 = 100;
         this.l_19.X2 = 2441;
         this.l_19.Y2 = 100;
         this.l_19.Name = Mobilize.Web.CaseExtensions.String("l_19");
         this.l_19.Visible = true;
         this.l_19.Pen.Style = 0;
         this.l_19.Pen.Width = 5;
         this.l_19.Pen.Color = "33554432";
         this.l_19.Background.Mode = 2;
         this.l_19.Background.Color = "33554431";
         this.l_20 = new Mobilize.Web.DmLine();
         this.l_20.Band = Mobilize.Web.CaseExtensions.String("trailer.1");
         this.l_20.X1 = 2441;
         this.l_20.Y1 = 0;
         this.l_20.X2 = 2441;
         this.l_20.Y2 = 100;
         this.l_20.Name = Mobilize.Web.CaseExtensions.String("l_20");
         this.l_20.Visible = true;
         this.l_20.Pen.Style = 0;
         this.l_20.Pen.Width = 5;
         this.l_20.Pen.Color = "33554432";
         this.l_20.Background.Mode = 2;
         this.l_20.Background.Color = "33554431";
         this.l_21 = new Mobilize.Web.DmLine();
         this.l_21.Band = Mobilize.Web.CaseExtensions.String("trailer.1");
         this.l_21.X1 = 23;
         this.l_21.Y1 = 0;
         this.l_21.X2 = 23;
         this.l_21.Y2 = 100;
         this.l_21.Name = Mobilize.Web.CaseExtensions.String("l_21");
         this.l_21.Visible = true;
         this.l_21.Pen.Style = 0;
         this.l_21.Pen.Width = 5;
         this.l_21.Pen.Color = "33554432";
         this.l_21.Background.Mode = 2;
         this.l_21.Background.Color = "33554431";
         this.compute_3 = new Mobilize.Web.DmCompute();
         this.compute_3.Band = Mobilize.Web.CaseExtensions.String("trailer.1");
         this.compute_3.Alignment = 0;
         this.compute_3.Expression = "\"Sum of age per country \" + sum(age for group 1)";
         this.compute_3.Border = 0;
         this.compute_3.Color = "33554432";
         this.compute_3.X = 937;
         this.compute_3.Y = 28;
         this.compute_3.Height = 64;
         this.compute_3.Width = 1435;
         this.compute_3.Format = "[GENERAL]";
         this.compute_3.Name = Mobilize.Web.CaseExtensions.String("compute_3");
         this.compute_3.Visible = true;
         this.compute_3.Font.FontFace = "Tahoma";
         this.compute_3.Font.Height = -10;
         this.compute_3.Font.Weight = 400;
         this.compute_3.Font.FontFamily = "2";
         this.compute_3.Font.Pitch = "2";
         this.compute_3.Font.Charset = "0";
         this.compute_3.Font.Underline = true;
         this.compute_3.Background.Mode = 1;
         this.compute_3.Background.Color = "536870912";
         this.t_2 = new Mobilize.Web.DmText();
         this.t_2.Band = Mobilize.Web.CaseExtensions.String("footer");
         this.t_2.Alignment = 0;
         this.t_2.Text = "Mobilize  Test";
         this.t_2.Border = 0;
         this.t_2.Color = "33554432";
         this.t_2.X = 1243;
         this.t_2.Y = 8;
         this.t_2.Height = 64;
         this.t_2.Width = 361;
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
         this.compute_4 = new Mobilize.Web.DmCompute();
         this.compute_4.Band = Mobilize.Web.CaseExtensions.String("footer");
         this.compute_4.Alignment = 0;
         this.compute_4.Expression = "\"Page \" + page()";
         this.compute_4.Border = 0;
         this.compute_4.Color = "33554432";
         this.compute_4.X = 2121;
         this.compute_4.Y = 4;
         this.compute_4.Height = 76;
         this.compute_4.Width = 457;
         this.compute_4.Format = "[GENERAL]";
         this.compute_4.Name = Mobilize.Web.CaseExtensions.String("compute_4");
         this.compute_4.Visible = true;
         this.compute_4.Font.FontFace = "Tahoma";
         this.compute_4.Font.Height = -9;
         this.compute_4.Font.Weight = 400;
         this.compute_4.Font.FontFamily = "2";
         this.compute_4.Font.Pitch = "2";
         this.compute_4.Font.Charset = "0";
         this.compute_4.Background.Mode = 2;
         this.compute_4.Background.Color = "1073741824";
         this.AddColumns(new Mobilize.Web.DB.Column[] { name_db1, lastname1_db2, lastname2_db3, age_db4, startdate_db5, country_db6, registration_db7 });
         this.AddControls(new Mobilize.Web.DmControl[] { this.t_1, this.compute_1, this.r_1, this.r_2, this.l_1, this.l_2, this.l_3, this.l_4, this.l_5, this.l_6, this.l_7, this.t_3, this.t_4, this.t_5, this.t_6, this.t_7, this.t_8, this.startdate, this._name, this.lastname1, this.lastname2, this.age, this.l_8, this.l_9, this.l_10, this.l_11, this.l_12, this.l_13, this.l_14, this.registration, this.l_15, this.l_16, this.l_17, this.compute_2, this.l_18, this.l_19, this.l_20, this.l_21, this.compute_3, this.t_2, this.compute_4 });
         this.AddGroups(new Mobilize.Web.DmGroup[] { group1_dm, group2_dm });
         this.PopulateRadioButtons();
      }
   }

}