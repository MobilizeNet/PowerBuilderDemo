namespace reports
{

   [Mobilize.WebMap.Common.Attributes.Observable]
   public partial class dw_birthday
      : Mobilize.Web.DataManager, Mobilize.Web.IDataManager
   {

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText t_5 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText t_1 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText t_2 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText t_3 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText t_4 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmLine l_1 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmLine l_2 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmLine l_3 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmLine l_5 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmLine l_6 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn when_1 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn where_1 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn lastname2_1 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn lastname1_1 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn name_1 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn when_2 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmLine l_8 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText t_6 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmLine l_7 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmLine l_9 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmLine l_10 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText t_10 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText t_9 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText t_8 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText t_7 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn name_2 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn lastname1_2 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn lastname2_2 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn where_2 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn when { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText t_11 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText t_12 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText t_13 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText t_14 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText t_15 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmLine l_12 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmLine l_14 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmLine l_11 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmLine l_13 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn when_3 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn where_3 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn lastname2_3 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn lastname1_3 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn name_3 { get; set; }


      public dw_birthday()
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
         this.RowsPerDetail = 3;
         this.Header.Height = 8;
         this.Header.Color = "536870912";
         this.Summary.Height = 0;
         this.Summary.Color = "536870912";
         this.Footer.Height = 0;
         this.Footer.Color = "536870912";
         this.Detail.Height = 760;
         this.Detail.Color = "536870912";
         var name_db1 = new Mobilize.Web.DB.Column();
         name_db1.Type = Mobilize.Web.CaseExtensions.String("char(10)");
         name_db1.UpdateWhereClause = true;
         name_db1.Name = Mobilize.Web.CaseExtensions.String("name");
         name_db1.DbName = "Name";
         var lastname1_db2 = new Mobilize.Web.DB.Column();
         lastname1_db2.Type = Mobilize.Web.CaseExtensions.String("char(10)");
         lastname1_db2.UpdateWhereClause = true;
         lastname1_db2.Name = Mobilize.Web.CaseExtensions.String("lastname1");
         lastname1_db2.DbName = "LastName1";
         var lastname2_db3 = new Mobilize.Web.DB.Column();
         lastname2_db3.Type = Mobilize.Web.CaseExtensions.String("char(10)");
         lastname2_db3.UpdateWhereClause = true;
         lastname2_db3.Name = Mobilize.Web.CaseExtensions.String("lastname2");
         lastname2_db3.DbName = "LastName2";
         var where_db4 = new Mobilize.Web.DB.Column();
         where_db4.Type = Mobilize.Web.CaseExtensions.String("char(100)");
         where_db4.UpdateWhereClause = true;
         where_db4.Name = Mobilize.Web.CaseExtensions.String("where");
         where_db4.DbName = "Where";
         var when_db5 = new Mobilize.Web.DB.Column();
         when_db5.Type = Mobilize.Web.CaseExtensions.String("datetime");
         when_db5.UpdateWhereClause = true;
         when_db5.Name = Mobilize.Web.CaseExtensions.String("when");
         when_db5.DbName = "when";
         this.t_5 = new Mobilize.Web.DmText();
         this.t_5.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.t_5.Alignment = 2;
         this.t_5.Text = "You're Invited";
         this.t_5.Border = 0;
         this.t_5.Color = "33554432";
         this.t_5.X = 87;
         this.t_5.Y = 12;
         this.t_5.Height = 100;
         this.t_5.Width = 827;
         this.t_5.Name = Mobilize.Web.CaseExtensions.String("t_5");
         this.t_5.Visible = true;
         this.t_5.Font.FontFace = "Tahoma";
         this.t_5.Font.Height = -16;
         this.t_5.Font.Weight = 400;
         this.t_5.Font.FontFamily = "2";
         this.t_5.Font.Pitch = "2";
         this.t_5.Font.Charset = "0";
         this.t_5.Background.Mode = 1;
         this.t_5.Background.Color = "536870912";
         this.t_1 = new Mobilize.Web.DmText();
         this.t_1.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.t_1.Alignment = 0;
         this.t_1.Text = "Name:";
         this.t_1.Border = 0;
         this.t_1.Color = "33554432";
         this.t_1.X = 73;
         this.t_1.Y = 184;
         this.t_1.Height = 64;
         this.t_1.Width = 183;
         this.t_1.Name = Mobilize.Web.CaseExtensions.String("t_1");
         this.t_1.Visible = true;
         this.t_1.Font.FontFace = "Tahoma";
         this.t_1.Font.Height = -10;
         this.t_1.Font.Weight = 700;
         this.t_1.Font.FontFamily = "2";
         this.t_1.Font.Pitch = "2";
         this.t_1.Font.Charset = "0";
         this.t_1.Background.Mode = 1;
         this.t_1.Background.Color = "536870912";
         this.t_2 = new Mobilize.Web.DmText();
         this.t_2.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.t_2.Alignment = 0;
         this.t_2.Text = "LastName:";
         this.t_2.Border = 0;
         this.t_2.Color = "33554432";
         this.t_2.X = 69;
         this.t_2.Y = 296;
         this.t_2.Height = 64;
         this.t_2.Width = 311;
         this.t_2.Name = Mobilize.Web.CaseExtensions.String("t_2");
         this.t_2.Visible = true;
         this.t_2.Font.FontFace = "Tahoma";
         this.t_2.Font.Height = -10;
         this.t_2.Font.Weight = 700;
         this.t_2.Font.FontFamily = "2";
         this.t_2.Font.Pitch = "2";
         this.t_2.Font.Charset = "0";
         this.t_2.Background.Mode = 1;
         this.t_2.Background.Color = "536870912";
         this.t_3 = new Mobilize.Web.DmText();
         this.t_3.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.t_3.Alignment = 0;
         this.t_3.Text = "Where:";
         this.t_3.Border = 0;
         this.t_3.Color = "33554432";
         this.t_3.X = 91;
         this.t_3.Y = 500;
         this.t_3.Height = 64;
         this.t_3.Width = 219;
         this.t_3.Name = Mobilize.Web.CaseExtensions.String("t_3");
         this.t_3.Visible = true;
         this.t_3.Font.FontFace = "Tahoma";
         this.t_3.Font.Height = -10;
         this.t_3.Font.Weight = 700;
         this.t_3.Font.FontFamily = "2";
         this.t_3.Font.Pitch = "2";
         this.t_3.Font.Charset = "0";
         this.t_3.Background.Mode = 1;
         this.t_3.Background.Color = "536870912";
         this.t_4 = new Mobilize.Web.DmText();
         this.t_4.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.t_4.Alignment = 0;
         this.t_4.Text = "When:";
         this.t_4.Border = 0;
         this.t_4.Color = "33554432";
         this.t_4.X = 91;
         this.t_4.Y = 636;
         this.t_4.Height = 64;
         this.t_4.Width = 192;
         this.t_4.Name = Mobilize.Web.CaseExtensions.String("t_4");
         this.t_4.Visible = true;
         this.t_4.Font.FontFace = "Tahoma";
         this.t_4.Font.Height = -10;
         this.t_4.Font.Weight = 700;
         this.t_4.Font.FontFamily = "2";
         this.t_4.Font.Pitch = "2";
         this.t_4.Font.Charset = "0";
         this.t_4.Background.Mode = 1;
         this.t_4.Background.Color = "536870912";
         this.l_1 = new Mobilize.Web.DmLine();
         this.l_1.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.l_1.X1 = 50;
         this.l_1.Y1 = 720;
         this.l_1.X2 = 1029;
         this.l_1.Y2 = 720;
         this.l_1.Name = Mobilize.Web.CaseExtensions.String("l_1");
         this.l_1.Visible = true;
         this.l_1.Pen.Style = 0;
         this.l_1.Pen.Width = 5;
         this.l_1.Pen.Color = "33554432";
         this.l_1.Background.Mode = 2;
         this.l_1.Background.Color = "1073741824";
         this.l_2 = new Mobilize.Web.DmLine();
         this.l_2.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.l_2.X1 = 46;
         this.l_2.Y1 = 0;
         this.l_2.X2 = 46;
         this.l_2.Y2 = 720;
         this.l_2.Name = Mobilize.Web.CaseExtensions.String("l_2");
         this.l_2.Visible = true;
         this.l_2.Pen.Style = 0;
         this.l_2.Pen.Width = 5;
         this.l_2.Pen.Color = "33554432";
         this.l_2.Background.Mode = 2;
         this.l_2.Background.Color = "1073741824";
         this.l_3 = new Mobilize.Web.DmLine();
         this.l_3.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.l_3.X1 = 46;
         this.l_3.Y1 = 0;
         this.l_3.X2 = 1029;
         this.l_3.Y2 = 0;
         this.l_3.Name = Mobilize.Web.CaseExtensions.String("l_3");
         this.l_3.Visible = true;
         this.l_3.Pen.Style = 0;
         this.l_3.Pen.Width = 5;
         this.l_3.Pen.Color = "33554432";
         this.l_3.Background.Mode = 2;
         this.l_3.Background.Color = "1073741824";
         this.l_5 = new Mobilize.Web.DmLine();
         this.l_5.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.l_5.X1 = 46;
         this.l_5.Y1 = 0;
         this.l_5.X2 = 1029;
         this.l_5.Y2 = 0;
         this.l_5.Name = Mobilize.Web.CaseExtensions.String("l_5");
         this.l_5.Visible = true;
         this.l_5.Pen.Style = 0;
         this.l_5.Pen.Width = 5;
         this.l_5.Pen.Color = "33554432";
         this.l_5.Background.Mode = 2;
         this.l_5.Background.Color = "1073741824";
         this.l_6 = new Mobilize.Web.DmLine();
         this.l_6.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.l_6.X1 = 1029;
         this.l_6.Y1 = 0;
         this.l_6.X2 = 1029;
         this.l_6.Y2 = 720;
         this.l_6.Name = Mobilize.Web.CaseExtensions.String("l_6");
         this.l_6.Visible = true;
         this.l_6.Pen.Style = 0;
         this.l_6.Pen.Width = 5;
         this.l_6.Pen.Color = "33554432";
         this.l_6.Background.Mode = 2;
         this.l_6.Background.Color = "1073741824";
         this.when_1 = new Mobilize.Web.DmColumn();
         this.when_1.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.when_1.Id = 5;
         this.when_1.Alignment = 0;
         this.when_1.TabSequence = 50;
         this.when_1.Border = 0;
         this.when_1.Color = "33554432";
         this.when_1.X = 466;
         this.when_1.Y = 624;
         this.when_1.Height = 76;
         this.when_1.Width = 521;
         this.when_1.Format = "[shortdate] [time]";
         this.when_1.RowInDetail = 1;
         this.when_1.Name = Mobilize.Web.CaseExtensions.String("when_1");
         this.when_1.Visible = true;
         this.when_1.EditMask.Mask = "mm/dd/yy hh:mm:ss";
         this.when_1.EditMask.FocusRectangle = false;
         this.when_1.Font.FontFace = "Tahoma";
         this.when_1.Font.Height = -10;
         this.when_1.Font.Weight = 400;
         this.when_1.Font.FontFamily = "2";
         this.when_1.Font.Pitch = "2";
         this.when_1.Font.Charset = "0";
         this.when_1.Background.Mode = 1;
         this.when_1.Background.Color = "536870912";
         this.when_1.EditMask.MaskDataType = Mobilize.Web.MaskDataType.DateTimeMask;
         this.where_1 = new Mobilize.Web.DmColumn();
         this.where_1.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.where_1.Id = 4;
         this.where_1.Alignment = 0;
         this.where_1.TabSequence = 40;
         this.where_1.Border = 0;
         this.where_1.Color = "33554432";
         this.where_1.X = 466;
         this.where_1.Y = 508;
         this.where_1.Height = 76;
         this.where_1.Width = 517;
         this.where_1.Format = "[general]";
         this.where_1.RowInDetail = 1;
         this.where_1.Name = Mobilize.Web.CaseExtensions.String("where_1");
         this.where_1.Visible = true;
         this.where_1.Edit.Limit = 0;
         this.where_1.Edit.Case = "any";
         this.where_1.Edit.AutoSelect = true;
         this.where_1.Edit.AutoHScroll = true;
         this.where_1.Font.FontFace = "Tahoma";
         this.where_1.Font.Height = -10;
         this.where_1.Font.Weight = 400;
         this.where_1.Font.FontFamily = "2";
         this.where_1.Font.Pitch = "2";
         this.where_1.Font.Charset = "0";
         this.where_1.Background.Mode = 1;
         this.where_1.Background.Color = "536870912";
         this.where_1.EditMask.MaskDataType = Mobilize.Web.MaskDataType.StringMask;
         this.lastname2_1 = new Mobilize.Web.DmColumn();
         this.lastname2_1.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.lastname2_1.Id = 3;
         this.lastname2_1.Alignment = 0;
         this.lastname2_1.TabSequence = 30;
         this.lastname2_1.Border = 0;
         this.lastname2_1.Color = "33554432";
         this.lastname2_1.X = 471;
         this.lastname2_1.Y = 400;
         this.lastname2_1.Height = 76;
         this.lastname2_1.Width = 274;
         this.lastname2_1.Format = "[general]";
         this.lastname2_1.RowInDetail = 1;
         this.lastname2_1.Name = Mobilize.Web.CaseExtensions.String("lastname2_1");
         this.lastname2_1.Visible = true;
         this.lastname2_1.Edit.Limit = 0;
         this.lastname2_1.Edit.Case = "any";
         this.lastname2_1.Edit.AutoSelect = true;
         this.lastname2_1.Edit.AutoHScroll = true;
         this.lastname2_1.Font.FontFace = "Tahoma";
         this.lastname2_1.Font.Height = -10;
         this.lastname2_1.Font.Weight = 400;
         this.lastname2_1.Font.FontFamily = "2";
         this.lastname2_1.Font.Pitch = "2";
         this.lastname2_1.Font.Charset = "0";
         this.lastname2_1.Background.Mode = 1;
         this.lastname2_1.Background.Color = "536870912";
         this.lastname2_1.EditMask.MaskDataType = Mobilize.Web.MaskDataType.StringMask;
         this.lastname1_1 = new Mobilize.Web.DmColumn();
         this.lastname1_1.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.lastname1_1.Id = 2;
         this.lastname1_1.Alignment = 0;
         this.lastname1_1.TabSequence = 20;
         this.lastname1_1.Border = 0;
         this.lastname1_1.Color = "33554432";
         this.lastname1_1.X = 471;
         this.lastname1_1.Y = 296;
         this.lastname1_1.Height = 76;
         this.lastname1_1.Width = 274;
         this.lastname1_1.Format = "[general]";
         this.lastname1_1.RowInDetail = 1;
         this.lastname1_1.Name = Mobilize.Web.CaseExtensions.String("lastname1_1");
         this.lastname1_1.Visible = true;
         this.lastname1_1.Edit.Limit = 0;
         this.lastname1_1.Edit.Case = "any";
         this.lastname1_1.Edit.AutoSelect = true;
         this.lastname1_1.Edit.AutoHScroll = true;
         this.lastname1_1.Font.FontFace = "Tahoma";
         this.lastname1_1.Font.Height = -10;
         this.lastname1_1.Font.Weight = 400;
         this.lastname1_1.Font.FontFamily = "2";
         this.lastname1_1.Font.Pitch = "2";
         this.lastname1_1.Font.Charset = "0";
         this.lastname1_1.Background.Mode = 1;
         this.lastname1_1.Background.Color = "536870912";
         this.lastname1_1.EditMask.MaskDataType = Mobilize.Web.MaskDataType.StringMask;
         this.name_1 = new Mobilize.Web.DmColumn();
         this.name_1.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.name_1.Id = 1;
         this.name_1.Alignment = 0;
         this.name_1.TabSequence = 10;
         this.name_1.Border = 0;
         this.name_1.Color = "33554432";
         this.name_1.X = 471;
         this.name_1.Y = 188;
         this.name_1.Height = 76;
         this.name_1.Width = 274;
         this.name_1.Format = "[general]";
         this.name_1.RowInDetail = 1;
         this.name_1.Name = Mobilize.Web.CaseExtensions.String("name_1");
         this.name_1.Visible = true;
         this.name_1.Edit.Limit = 0;
         this.name_1.Edit.Case = "any";
         this.name_1.Edit.AutoSelect = true;
         this.name_1.Edit.AutoHScroll = true;
         this.name_1.Font.FontFace = "Tahoma";
         this.name_1.Font.Height = -10;
         this.name_1.Font.Weight = 400;
         this.name_1.Font.FontFamily = "2";
         this.name_1.Font.Pitch = "2";
         this.name_1.Font.Charset = "0";
         this.name_1.Background.Mode = 1;
         this.name_1.Background.Color = "536870912";
         this.name_1.EditMask.MaskDataType = Mobilize.Web.MaskDataType.StringMask;
         this.when_2 = new Mobilize.Web.DmColumn();
         this.when_2.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.when_2.Id = 5;
         this.when_2.Alignment = 0;
         this.when_2.TabSequence = 100;
         this.when_2.Border = 0;
         this.when_2.Color = "33554432";
         this.when_2.X = 0;
         this.when_2.Y = 0;
         this.when_2.Height = 8;
         this.when_2.Width = 9;
         this.when_2.Format = "[shortdate] [time]";
         this.when_2.RowInDetail = 2;
         this.when_2.Name = Mobilize.Web.CaseExtensions.String("when_2");
         this.when_2.Visible = true;
         this.when_2.EditMask.Mask = "mm/dd/yy hh:mm:ss";
         this.when_2.EditMask.FocusRectangle = false;
         this.when_2.Font.FontFace = "Tahoma";
         this.when_2.Font.Height = -10;
         this.when_2.Font.Weight = 400;
         this.when_2.Font.FontFamily = "2";
         this.when_2.Font.Pitch = "2";
         this.when_2.Font.Charset = "0";
         this.when_2.Background.Mode = 1;
         this.when_2.Background.Color = "536870912";
         this.when_2.EditMask.MaskDataType = Mobilize.Web.MaskDataType.DateTimeMask;
         this.l_8 = new Mobilize.Web.DmLine();
         this.l_8.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.l_8.X1 = 1074;
         this.l_8.Y1 = 0;
         this.l_8.X2 = 2048;
         this.l_8.Y2 = 0;
         this.l_8.Name = Mobilize.Web.CaseExtensions.String("l_8");
         this.l_8.Visible = true;
         this.l_8.Pen.Style = 0;
         this.l_8.Pen.Width = 5;
         this.l_8.Pen.Color = "33554432";
         this.l_8.Background.Mode = 2;
         this.l_8.Background.Color = "1073741824";
         this.t_6 = new Mobilize.Web.DmText();
         this.t_6.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.t_6.Alignment = 2;
         this.t_6.Text = "You're Invited";
         this.t_6.Border = 0;
         this.t_6.Color = "33554432";
         this.t_6.X = 1111;
         this.t_6.Y = 0;
         this.t_6.Height = 100;
         this.t_6.Width = 827;
         this.t_6.Name = Mobilize.Web.CaseExtensions.String("t_6");
         this.t_6.Visible = true;
         this.t_6.Font.FontFace = "Tahoma";
         this.t_6.Font.Height = -16;
         this.t_6.Font.Weight = 400;
         this.t_6.Font.FontFamily = "2";
         this.t_6.Font.Pitch = "2";
         this.t_6.Font.Charset = "0";
         this.t_6.Background.Mode = 1;
         this.t_6.Background.Color = "536870912";
         this.l_7 = new Mobilize.Web.DmLine();
         this.l_7.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.l_7.X1 = 1070;
         this.l_7.Y1 = 0;
         this.l_7.X2 = 1070;
         this.l_7.Y2 = 720;
         this.l_7.Name = Mobilize.Web.CaseExtensions.String("l_7");
         this.l_7.Visible = true;
         this.l_7.Pen.Style = 0;
         this.l_7.Pen.Width = 5;
         this.l_7.Pen.Color = "33554432";
         this.l_7.Background.Mode = 2;
         this.l_7.Background.Color = "1073741824";
         this.l_9 = new Mobilize.Web.DmLine();
         this.l_9.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.l_9.X1 = 1070;
         this.l_9.Y1 = 724;
         this.l_9.X2 = 2043;
         this.l_9.Y2 = 724;
         this.l_9.Name = Mobilize.Web.CaseExtensions.String("l_9");
         this.l_9.Visible = true;
         this.l_9.Pen.Style = 0;
         this.l_9.Pen.Width = 5;
         this.l_9.Pen.Color = "33554432";
         this.l_9.Background.Mode = 2;
         this.l_9.Background.Color = "1073741824";
         this.l_10 = new Mobilize.Web.DmLine();
         this.l_10.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.l_10.X1 = 2043;
         this.l_10.Y1 = 0;
         this.l_10.X2 = 2043;
         this.l_10.Y2 = 724;
         this.l_10.Name = Mobilize.Web.CaseExtensions.String("l_10");
         this.l_10.Visible = true;
         this.l_10.Pen.Style = 0;
         this.l_10.Pen.Width = 5;
         this.l_10.Pen.Color = "33554432";
         this.l_10.Background.Mode = 2;
         this.l_10.Background.Color = "1073741824";
         this.t_10 = new Mobilize.Web.DmText();
         this.t_10.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.t_10.Alignment = 0;
         this.t_10.Text = "When:";
         this.t_10.Border = 0;
         this.t_10.Color = "33554432";
         this.t_10.X = 1111;
         this.t_10.Y = 632;
         this.t_10.Height = 64;
         this.t_10.Width = 192;
         this.t_10.Name = Mobilize.Web.CaseExtensions.String("t_10");
         this.t_10.Visible = true;
         this.t_10.Font.FontFace = "Tahoma";
         this.t_10.Font.Height = -10;
         this.t_10.Font.Weight = 700;
         this.t_10.Font.FontFamily = "2";
         this.t_10.Font.Pitch = "2";
         this.t_10.Font.Charset = "0";
         this.t_10.Background.Mode = 1;
         this.t_10.Background.Color = "536870912";
         this.t_9 = new Mobilize.Web.DmText();
         this.t_9.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.t_9.Alignment = 0;
         this.t_9.Text = "Where:";
         this.t_9.Border = 0;
         this.t_9.Color = "33554432";
         this.t_9.X = 1111;
         this.t_9.Y = 496;
         this.t_9.Height = 64;
         this.t_9.Width = 219;
         this.t_9.Name = Mobilize.Web.CaseExtensions.String("t_9");
         this.t_9.Visible = true;
         this.t_9.Font.FontFace = "Tahoma";
         this.t_9.Font.Height = -10;
         this.t_9.Font.Weight = 700;
         this.t_9.Font.FontFamily = "2";
         this.t_9.Font.Pitch = "2";
         this.t_9.Font.Charset = "0";
         this.t_9.Background.Mode = 1;
         this.t_9.Background.Color = "536870912";
         this.t_8 = new Mobilize.Web.DmText();
         this.t_8.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.t_8.Alignment = 0;
         this.t_8.Text = "LastName:";
         this.t_8.Border = 0;
         this.t_8.Color = "33554432";
         this.t_8.X = 1088;
         this.t_8.Y = 292;
         this.t_8.Height = 64;
         this.t_8.Width = 311;
         this.t_8.Name = Mobilize.Web.CaseExtensions.String("t_8");
         this.t_8.Visible = true;
         this.t_8.Font.FontFace = "Tahoma";
         this.t_8.Font.Height = -10;
         this.t_8.Font.Weight = 700;
         this.t_8.Font.FontFamily = "2";
         this.t_8.Font.Pitch = "2";
         this.t_8.Font.Charset = "0";
         this.t_8.Background.Mode = 1;
         this.t_8.Background.Color = "536870912";
         this.t_7 = new Mobilize.Web.DmText();
         this.t_7.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.t_7.Alignment = 0;
         this.t_7.Text = "Name:";
         this.t_7.Border = 0;
         this.t_7.Color = "33554432";
         this.t_7.X = 1093;
         this.t_7.Y = 180;
         this.t_7.Height = 64;
         this.t_7.Width = 183;
         this.t_7.Name = Mobilize.Web.CaseExtensions.String("t_7");
         this.t_7.Visible = true;
         this.t_7.Font.FontFace = "Tahoma";
         this.t_7.Font.Height = -10;
         this.t_7.Font.Weight = 700;
         this.t_7.Font.FontFamily = "2";
         this.t_7.Font.Pitch = "2";
         this.t_7.Font.Charset = "0";
         this.t_7.Background.Mode = 1;
         this.t_7.Background.Color = "536870912";
         this.name_2 = new Mobilize.Web.DmColumn();
         this.name_2.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.name_2.Id = 1;
         this.name_2.Alignment = 0;
         this.name_2.TabSequence = 60;
         this.name_2.Border = 0;
         this.name_2.Color = "33554432";
         this.name_2.X = 1504;
         this.name_2.Y = 180;
         this.name_2.Height = 76;
         this.name_2.Width = 270;
         this.name_2.Format = "[general]";
         this.name_2.RowInDetail = 2;
         this.name_2.Name = Mobilize.Web.CaseExtensions.String("name_2");
         this.name_2.Visible = true;
         this.name_2.Edit.Limit = 0;
         this.name_2.Edit.Case = "any";
         this.name_2.Edit.AutoSelect = true;
         this.name_2.Edit.AutoHScroll = true;
         this.name_2.Font.FontFace = "Tahoma";
         this.name_2.Font.Height = -10;
         this.name_2.Font.Weight = 400;
         this.name_2.Font.FontFamily = "2";
         this.name_2.Font.Pitch = "2";
         this.name_2.Font.Charset = "0";
         this.name_2.Background.Mode = 1;
         this.name_2.Background.Color = "536870912";
         this.name_2.EditMask.MaskDataType = Mobilize.Web.MaskDataType.StringMask;
         this.lastname1_2 = new Mobilize.Web.DmColumn();
         this.lastname1_2.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.lastname1_2.Id = 2;
         this.lastname1_2.Alignment = 0;
         this.lastname1_2.TabSequence = 70;
         this.lastname1_2.Border = 0;
         this.lastname1_2.Color = "33554432";
         this.lastname1_2.X = 1499;
         this.lastname1_2.Y = 292;
         this.lastname1_2.Height = 76;
         this.lastname1_2.Width = 274;
         this.lastname1_2.Format = "[general]";
         this.lastname1_2.RowInDetail = 2;
         this.lastname1_2.Name = Mobilize.Web.CaseExtensions.String("lastname1_2");
         this.lastname1_2.Visible = true;
         this.lastname1_2.Edit.Limit = 0;
         this.lastname1_2.Edit.Case = "any";
         this.lastname1_2.Edit.AutoSelect = true;
         this.lastname1_2.Edit.AutoHScroll = true;
         this.lastname1_2.Font.FontFace = "Tahoma";
         this.lastname1_2.Font.Height = -10;
         this.lastname1_2.Font.Weight = 400;
         this.lastname1_2.Font.FontFamily = "2";
         this.lastname1_2.Font.Pitch = "2";
         this.lastname1_2.Font.Charset = "0";
         this.lastname1_2.Background.Mode = 1;
         this.lastname1_2.Background.Color = "536870912";
         this.lastname1_2.EditMask.MaskDataType = Mobilize.Web.MaskDataType.StringMask;
         this.lastname2_2 = new Mobilize.Web.DmColumn();
         this.lastname2_2.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.lastname2_2.Id = 3;
         this.lastname2_2.Alignment = 0;
         this.lastname2_2.TabSequence = 80;
         this.lastname2_2.Border = 0;
         this.lastname2_2.Color = "33554432";
         this.lastname2_2.X = 1499;
         this.lastname2_2.Y = 400;
         this.lastname2_2.Height = 76;
         this.lastname2_2.Width = 274;
         this.lastname2_2.Format = "[general]";
         this.lastname2_2.RowInDetail = 2;
         this.lastname2_2.Name = Mobilize.Web.CaseExtensions.String("lastname2_2");
         this.lastname2_2.Visible = true;
         this.lastname2_2.Edit.Limit = 0;
         this.lastname2_2.Edit.Case = "any";
         this.lastname2_2.Edit.AutoSelect = true;
         this.lastname2_2.Edit.AutoHScroll = true;
         this.lastname2_2.Font.FontFace = "Tahoma";
         this.lastname2_2.Font.Height = -10;
         this.lastname2_2.Font.Weight = 400;
         this.lastname2_2.Font.FontFamily = "2";
         this.lastname2_2.Font.Pitch = "2";
         this.lastname2_2.Font.Charset = "0";
         this.lastname2_2.Background.Mode = 1;
         this.lastname2_2.Background.Color = "536870912";
         this.lastname2_2.EditMask.MaskDataType = Mobilize.Web.MaskDataType.StringMask;
         this.where_2 = new Mobilize.Web.DmColumn();
         this.where_2.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.where_2.Id = 4;
         this.where_2.Alignment = 0;
         this.where_2.TabSequence = 90;
         this.where_2.Border = 0;
         this.where_2.Color = "33554432";
         this.where_2.X = 1504;
         this.where_2.Y = 500;
         this.where_2.Height = 76;
         this.where_2.Width = 498;
         this.where_2.Format = "[general]";
         this.where_2.RowInDetail = 2;
         this.where_2.Name = Mobilize.Web.CaseExtensions.String("where_2");
         this.where_2.Visible = true;
         this.where_2.Edit.Limit = 0;
         this.where_2.Edit.Case = "any";
         this.where_2.Edit.AutoSelect = true;
         this.where_2.Edit.AutoHScroll = true;
         this.where_2.Font.FontFace = "Tahoma";
         this.where_2.Font.Height = -10;
         this.where_2.Font.Weight = 400;
         this.where_2.Font.FontFamily = "2";
         this.where_2.Font.Pitch = "2";
         this.where_2.Font.Charset = "0";
         this.where_2.Background.Mode = 1;
         this.where_2.Background.Color = "536870912";
         this.where_2.EditMask.MaskDataType = Mobilize.Web.MaskDataType.StringMask;
         this.when = new Mobilize.Web.DmColumn();
         this.when.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.when.Id = 5;
         this.when.Alignment = 0;
         this.when.TabSequence = 160;
         this.when.Border = 0;
         this.when.Color = "33554432";
         this.when.X = 1509;
         this.when.Y = 608;
         this.when.Height = 76;
         this.when.Width = 485;
         this.when.RowInDetail = 2;
         this.when.Name = Mobilize.Web.CaseExtensions.String("when");
         this.when.Visible = true;
         this.when.Edit.Limit = 0;
         this.when.Edit.Case = "any";
         this.when.Edit.FocusRectangle = false;
         this.when.Edit.AutoSelect = false;
         this.when.Font.FontFace = "Tahoma";
         this.when.Font.Height = -10;
         this.when.Font.Weight = 400;
         this.when.Font.FontFamily = "2";
         this.when.Font.Pitch = "2";
         this.when.Font.Charset = "0";
         this.when.Background.Mode = 2;
         this.when.Background.Color = "1073741824";
         this.t_11 = new Mobilize.Web.DmText();
         this.t_11.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.t_11.Alignment = 0;
         this.t_11.Text = "When:";
         this.t_11.Border = 0;
         this.t_11.Color = "33554432";
         this.t_11.X = 2112;
         this.t_11.Y = 636;
         this.t_11.Height = 64;
         this.t_11.Width = 192;
         this.t_11.Name = Mobilize.Web.CaseExtensions.String("t_11");
         this.t_11.Visible = true;
         this.t_11.Font.FontFace = "Tahoma";
         this.t_11.Font.Height = -10;
         this.t_11.Font.Weight = 700;
         this.t_11.Font.FontFamily = "2";
         this.t_11.Font.Pitch = "2";
         this.t_11.Font.Charset = "0";
         this.t_11.Background.Mode = 1;
         this.t_11.Background.Color = "536870912";
         this.t_12 = new Mobilize.Web.DmText();
         this.t_12.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.t_12.Alignment = 0;
         this.t_12.Text = "Where:";
         this.t_12.Border = 0;
         this.t_12.Color = "33554432";
         this.t_12.X = 2107;
         this.t_12.Y = 500;
         this.t_12.Height = 64;
         this.t_12.Width = 219;
         this.t_12.Name = Mobilize.Web.CaseExtensions.String("t_12");
         this.t_12.Visible = true;
         this.t_12.Font.FontFace = "Tahoma";
         this.t_12.Font.Height = -10;
         this.t_12.Font.Weight = 700;
         this.t_12.Font.FontFamily = "2";
         this.t_12.Font.Pitch = "2";
         this.t_12.Font.Charset = "0";
         this.t_12.Background.Mode = 1;
         this.t_12.Background.Color = "536870912";
         this.t_13 = new Mobilize.Web.DmText();
         this.t_13.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.t_13.Alignment = 0;
         this.t_13.Text = "LastName:";
         this.t_13.Border = 0;
         this.t_13.Color = "33554432";
         this.t_13.X = 2107;
         this.t_13.Y = 304;
         this.t_13.Height = 64;
         this.t_13.Width = 311;
         this.t_13.Name = Mobilize.Web.CaseExtensions.String("t_13");
         this.t_13.Visible = true;
         this.t_13.Font.FontFace = "Tahoma";
         this.t_13.Font.Height = -10;
         this.t_13.Font.Weight = 700;
         this.t_13.Font.FontFamily = "2";
         this.t_13.Font.Pitch = "2";
         this.t_13.Font.Charset = "0";
         this.t_13.Background.Mode = 1;
         this.t_13.Background.Color = "536870912";
         this.t_14 = new Mobilize.Web.DmText();
         this.t_14.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.t_14.Alignment = 0;
         this.t_14.Text = "Name:";
         this.t_14.Border = 0;
         this.t_14.Color = "33554432";
         this.t_14.X = 2107;
         this.t_14.Y = 184;
         this.t_14.Height = 64;
         this.t_14.Width = 183;
         this.t_14.Name = Mobilize.Web.CaseExtensions.String("t_14");
         this.t_14.Visible = true;
         this.t_14.Font.FontFace = "Tahoma";
         this.t_14.Font.Height = -10;
         this.t_14.Font.Weight = 700;
         this.t_14.Font.FontFamily = "2";
         this.t_14.Font.Pitch = "2";
         this.t_14.Font.Charset = "0";
         this.t_14.Background.Mode = 1;
         this.t_14.Background.Color = "536870912";
         this.t_15 = new Mobilize.Web.DmText();
         this.t_15.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.t_15.Alignment = 2;
         this.t_15.Text = "You're Invited";
         this.t_15.Border = 0;
         this.t_15.Color = "33554432";
         this.t_15.X = 2130;
         this.t_15.Y = 8;
         this.t_15.Height = 100;
         this.t_15.Width = 827;
         this.t_15.Name = Mobilize.Web.CaseExtensions.String("t_15");
         this.t_15.Visible = true;
         this.t_15.Font.FontFace = "Tahoma";
         this.t_15.Font.Height = -16;
         this.t_15.Font.Weight = 400;
         this.t_15.Font.FontFamily = "2";
         this.t_15.Font.Pitch = "2";
         this.t_15.Font.Charset = "0";
         this.t_15.Background.Mode = 1;
         this.t_15.Background.Color = "536870912";
         this.l_12 = new Mobilize.Web.DmLine();
         this.l_12.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.l_12.X1 = 2085;
         this.l_12.Y1 = 0;
         this.l_12.X2 = 3049;
         this.l_12.Y2 = 0;
         this.l_12.Name = Mobilize.Web.CaseExtensions.String("l_12");
         this.l_12.Visible = true;
         this.l_12.Pen.Style = 0;
         this.l_12.Pen.Width = 5;
         this.l_12.Pen.Color = "33554432";
         this.l_12.Background.Mode = 2;
         this.l_12.Background.Color = "1073741824";
         this.l_14 = new Mobilize.Web.DmLine();
         this.l_14.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.l_14.X1 = 3049;
         this.l_14.Y1 = 0;
         this.l_14.X2 = 3049;
         this.l_14.Y2 = 724;
         this.l_14.Name = Mobilize.Web.CaseExtensions.String("l_14");
         this.l_14.Visible = true;
         this.l_14.Pen.Style = 0;
         this.l_14.Pen.Width = 5;
         this.l_14.Pen.Color = "33554432";
         this.l_14.Background.Mode = 2;
         this.l_14.Background.Color = "1073741824";
         this.l_11 = new Mobilize.Web.DmLine();
         this.l_11.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.l_11.X1 = 2085;
         this.l_11.Y1 = 0;
         this.l_11.X2 = 2085;
         this.l_11.Y2 = 724;
         this.l_11.Name = Mobilize.Web.CaseExtensions.String("l_11");
         this.l_11.Visible = true;
         this.l_11.Pen.Style = 0;
         this.l_11.Pen.Width = 5;
         this.l_11.Pen.Color = "33554432";
         this.l_11.Background.Mode = 2;
         this.l_11.Background.Color = "1073741824";
         this.l_13 = new Mobilize.Web.DmLine();
         this.l_13.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.l_13.X1 = 2080;
         this.l_13.Y1 = 724;
         this.l_13.X2 = 3049;
         this.l_13.Y2 = 724;
         this.l_13.Name = Mobilize.Web.CaseExtensions.String("l_13");
         this.l_13.Visible = true;
         this.l_13.Pen.Style = 0;
         this.l_13.Pen.Width = 5;
         this.l_13.Pen.Color = "33554432";
         this.l_13.Background.Mode = 2;
         this.l_13.Background.Color = "1073741824";
         this.when_3 = new Mobilize.Web.DmColumn();
         this.when_3.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.when_3.Id = 5;
         this.when_3.Alignment = 0;
         this.when_3.TabSequence = 150;
         this.when_3.Border = 0;
         this.when_3.Color = "33554432";
         this.when_3.X = 2514;
         this.when_3.Y = 632;
         this.when_3.Height = 76;
         this.when_3.Width = 489;
         this.when_3.Format = "[shortdate] [time]";
         this.when_3.RowInDetail = 3;
         this.when_3.Name = Mobilize.Web.CaseExtensions.String("when_3");
         this.when_3.Visible = true;
         this.when_3.EditMask.Mask = "mm/dd/yy hh:mm:ss";
         this.when_3.EditMask.FocusRectangle = false;
         this.when_3.Font.FontFace = "Tahoma";
         this.when_3.Font.Height = -10;
         this.when_3.Font.Weight = 400;
         this.when_3.Font.FontFamily = "2";
         this.when_3.Font.Pitch = "2";
         this.when_3.Font.Charset = "0";
         this.when_3.Background.Mode = 1;
         this.when_3.Background.Color = "536870912";
         this.when_3.EditMask.MaskDataType = Mobilize.Web.MaskDataType.DateTimeMask;
         this.where_3 = new Mobilize.Web.DmColumn();
         this.where_3.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.where_3.Id = 4;
         this.where_3.Alignment = 0;
         this.where_3.TabSequence = 140;
         this.where_3.Border = 0;
         this.where_3.Color = "33554432";
         this.where_3.X = 2514;
         this.where_3.Y = 500;
         this.where_3.Height = 84;
         this.where_3.Width = 494;
         this.where_3.Format = "[general]";
         this.where_3.RowInDetail = 3;
         this.where_3.Name = Mobilize.Web.CaseExtensions.String("where_3");
         this.where_3.Visible = true;
         this.where_3.Edit.Limit = 0;
         this.where_3.Edit.Case = "any";
         this.where_3.Edit.AutoSelect = true;
         this.where_3.Edit.AutoHScroll = true;
         this.where_3.Font.FontFace = "Tahoma";
         this.where_3.Font.Height = -10;
         this.where_3.Font.Weight = 400;
         this.where_3.Font.FontFamily = "2";
         this.where_3.Font.Pitch = "2";
         this.where_3.Font.Charset = "0";
         this.where_3.Background.Mode = 1;
         this.where_3.Background.Color = "536870912";
         this.where_3.EditMask.MaskDataType = Mobilize.Web.MaskDataType.StringMask;
         this.lastname2_3 = new Mobilize.Web.DmColumn();
         this.lastname2_3.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.lastname2_3.Id = 3;
         this.lastname2_3.Alignment = 0;
         this.lastname2_3.TabSequence = 130;
         this.lastname2_3.Border = 0;
         this.lastname2_3.Color = "33554432";
         this.lastname2_3.X = 2505;
         this.lastname2_3.Y = 396;
         this.lastname2_3.Height = 76;
         this.lastname2_3.Width = 274;
         this.lastname2_3.Format = "[general]";
         this.lastname2_3.RowInDetail = 3;
         this.lastname2_3.Name = Mobilize.Web.CaseExtensions.String("lastname2_3");
         this.lastname2_3.Visible = true;
         this.lastname2_3.Edit.Limit = 0;
         this.lastname2_3.Edit.Case = "any";
         this.lastname2_3.Edit.AutoSelect = true;
         this.lastname2_3.Edit.AutoHScroll = true;
         this.lastname2_3.Font.FontFace = "Tahoma";
         this.lastname2_3.Font.Height = -10;
         this.lastname2_3.Font.Weight = 400;
         this.lastname2_3.Font.FontFamily = "2";
         this.lastname2_3.Font.Pitch = "2";
         this.lastname2_3.Font.Charset = "0";
         this.lastname2_3.Background.Mode = 1;
         this.lastname2_3.Background.Color = "536870912";
         this.lastname2_3.EditMask.MaskDataType = Mobilize.Web.MaskDataType.StringMask;
         this.lastname1_3 = new Mobilize.Web.DmColumn();
         this.lastname1_3.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.lastname1_3.Id = 2;
         this.lastname1_3.Alignment = 0;
         this.lastname1_3.TabSequence = 120;
         this.lastname1_3.Border = 0;
         this.lastname1_3.Color = "33554432";
         this.lastname1_3.X = 2505;
         this.lastname1_3.Y = 280;
         this.lastname1_3.Height = 76;
         this.lastname1_3.Width = 274;
         this.lastname1_3.Format = "[general]";
         this.lastname1_3.RowInDetail = 3;
         this.lastname1_3.Name = Mobilize.Web.CaseExtensions.String("lastname1_3");
         this.lastname1_3.Visible = true;
         this.lastname1_3.Edit.Limit = 0;
         this.lastname1_3.Edit.Case = "any";
         this.lastname1_3.Edit.AutoSelect = true;
         this.lastname1_3.Edit.AutoHScroll = true;
         this.lastname1_3.Font.FontFace = "Tahoma";
         this.lastname1_3.Font.Height = -10;
         this.lastname1_3.Font.Weight = 400;
         this.lastname1_3.Font.FontFamily = "2";
         this.lastname1_3.Font.Pitch = "2";
         this.lastname1_3.Font.Charset = "0";
         this.lastname1_3.Background.Mode = 1;
         this.lastname1_3.Background.Color = "536870912";
         this.lastname1_3.EditMask.MaskDataType = Mobilize.Web.MaskDataType.StringMask;
         this.name_3 = new Mobilize.Web.DmColumn();
         this.name_3.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.name_3.Id = 1;
         this.name_3.Alignment = 0;
         this.name_3.TabSequence = 110;
         this.name_3.Border = 0;
         this.name_3.Color = "33554432";
         this.name_3.X = 2505;
         this.name_3.Y = 176;
         this.name_3.Height = 76;
         this.name_3.Width = 274;
         this.name_3.Format = "[general]";
         this.name_3.RowInDetail = 3;
         this.name_3.Name = Mobilize.Web.CaseExtensions.String("name_3");
         this.name_3.Visible = true;
         this.name_3.Edit.Limit = 0;
         this.name_3.Edit.Case = "any";
         this.name_3.Edit.AutoSelect = true;
         this.name_3.Edit.AutoHScroll = true;
         this.name_3.Font.FontFace = "Tahoma";
         this.name_3.Font.Height = -10;
         this.name_3.Font.Weight = 400;
         this.name_3.Font.FontFamily = "2";
         this.name_3.Font.Pitch = "2";
         this.name_3.Font.Charset = "0";
         this.name_3.Background.Mode = 1;
         this.name_3.Background.Color = "536870912";
         this.name_3.EditMask.MaskDataType = Mobilize.Web.MaskDataType.StringMask;
         this.AddColumns(new Mobilize.Web.DB.Column[] { name_db1, lastname1_db2, lastname2_db3, where_db4, when_db5 });
         this.AddControls(new Mobilize.Web.DmControl[] { this.t_5, this.t_1, this.t_2, this.t_3, this.t_4, this.l_1, this.l_2, this.l_3, this.l_5, this.l_6, this.when_1, this.where_1, this.lastname2_1, this.lastname1_1, this.name_1, this.when_2, this.l_8, this.t_6, this.l_7, this.l_9, this.l_10, this.t_10, this.t_9, this.t_8, this.t_7, this.name_2, this.lastname1_2, this.lastname2_2, this.where_2, this.when, this.t_11, this.t_12, this.t_13, this.t_14, this.t_15, this.l_12, this.l_14, this.l_11, this.l_13, this.when_3, this.where_3, this.lastname2_3, this.lastname1_3, this.name_3 });
         this.PopulateRadioButtons();
      }
   }

}