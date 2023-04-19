namespace multicontroldemo
{

   [Mobilize.WebMap.Common.Attributes.Observable]
   public partial class d_dw_control_sampler
      : Mobilize.Web.DataManager, Mobilize.Web.IDataManager
   {

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText name_field_t { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn name_field { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText age_field_t { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn age_field { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText description_field_t { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn description_field { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText date_field_t { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn date_field { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText event_date_field_t { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn event_date_field { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText salary_field_t { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn salary_field { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn flag_field { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText t_1 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn options_field { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText t_2 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn drop_field { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText t_3 { get; set; }


      public d_dw_control_sampler()
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
         this.Detail.Height = 800;
         this.Detail.Color = "536870912";
         var options_field_db1 = new Mobilize.Web.DB.Column();
         options_field_db1.Type = Mobilize.Web.CaseExtensions.String("number");
         options_field_db1.UpdateWhereClause = true;
         options_field_db1.Name = Mobilize.Web.CaseExtensions.String("options_field");
         options_field_db1.DbName = "name_2";
         options_field_db1.Values = "First\t100/Second\t300/";
         var name_field_db2 = new Mobilize.Web.DB.Column();
         name_field_db2.Type = Mobilize.Web.CaseExtensions.String("char(50)");
         name_field_db2.UpdateWhereClause = true;
         name_field_db2.Name = Mobilize.Web.CaseExtensions.String("name_field");
         name_field_db2.DbName = "name_field";
         var age_field_db3 = new Mobilize.Web.DB.Column();
         age_field_db3.Type = Mobilize.Web.CaseExtensions.String("number");
         age_field_db3.UpdateWhereClause = true;
         age_field_db3.Name = Mobilize.Web.CaseExtensions.String("age_field");
         age_field_db3.DbName = "age_field";
         var drop_field_db4 = new Mobilize.Web.DB.Column();
         drop_field_db4.Type = Mobilize.Web.CaseExtensions.String("number");
         drop_field_db4.UpdateWhereClause = true;
         drop_field_db4.Name = Mobilize.Web.CaseExtensions.String("drop_field");
         drop_field_db4.DbName = "name_3";
         drop_field_db4.Values = "FirstOpt\t399/SecondOpt\t400/Third\t482/";
         var flag_field_db5 = new Mobilize.Web.DB.Column();
         flag_field_db5.Type = Mobilize.Web.CaseExtensions.String("number");
         flag_field_db5.UpdateWhereClause = true;
         flag_field_db5.Name = Mobilize.Web.CaseExtensions.String("flag_field");
         flag_field_db5.DbName = "name_1";
         flag_field_db5.Values = "\t88/\t55";
         var description_field_db6 = new Mobilize.Web.DB.Column();
         description_field_db6.Type = Mobilize.Web.CaseExtensions.String("char(500)");
         description_field_db6.UpdateWhereClause = true;
         description_field_db6.Name = Mobilize.Web.CaseExtensions.String("description_field");
         description_field_db6.DbName = "description_field";
         var date_field_db7 = new Mobilize.Web.DB.Column();
         date_field_db7.Type = Mobilize.Web.CaseExtensions.String("date");
         date_field_db7.UpdateWhereClause = true;
         date_field_db7.Name = Mobilize.Web.CaseExtensions.String("date_field");
         date_field_db7.DbName = "date_field";
         var event_date_field_db8 = new Mobilize.Web.DB.Column();
         event_date_field_db8.Type = Mobilize.Web.CaseExtensions.String("datetime");
         event_date_field_db8.UpdateWhereClause = true;
         event_date_field_db8.Name = Mobilize.Web.CaseExtensions.String("event_date_field");
         event_date_field_db8.DbName = "event_date_field";
         var salary_field_db9 = new Mobilize.Web.DB.Column();
         salary_field_db9.Type = Mobilize.Web.CaseExtensions.String("decimal(2)");
         salary_field_db9.UpdateWhereClause = true;
         salary_field_db9.Name = Mobilize.Web.CaseExtensions.String("salary_field");
         salary_field_db9.DbName = "salary_field";
         this.name_field_t = new Mobilize.Web.DmText();
         this.name_field_t.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.name_field_t.Alignment = 1;
         this.name_field_t.Text = "Name Field:";
         this.name_field_t.Border = 0;
         this.name_field_t.Color = "33554432";
         this.name_field_t.X = 37;
         this.name_field_t.Y = 4;
         this.name_field_t.Height = 64;
         this.name_field_t.Width = 471;
         this.name_field_t.Name = Mobilize.Web.CaseExtensions.String("name_field_t");
         this.name_field_t.Visible = true;
         this.name_field_t.Font.FontFace = "Tahoma";
         this.name_field_t.Font.Height = -10;
         this.name_field_t.Font.Weight = 400;
         this.name_field_t.Font.FontFamily = "2";
         this.name_field_t.Font.Pitch = "2";
         this.name_field_t.Font.Charset = "0";
         this.name_field_t.Background.Mode = 1;
         this.name_field_t.Background.Color = "536870912";
         this.name_field = new Mobilize.Web.DmColumn();
         this.name_field.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.name_field.Id = 2;
         this.name_field.Alignment = 0;
         this.name_field.TabSequence = 10;
         this.name_field.Border = 0;
         this.name_field.Color = "33554432";
         this.name_field.X = 544;
         this.name_field.Y = 4;
         this.name_field.Height = 76;
         this.name_field.Width = 274;
         this.name_field.Format = "[general]";
         this.name_field.Name = Mobilize.Web.CaseExtensions.String("name_field");
         this.name_field.Visible = true;
         this.name_field.Edit.Limit = 0;
         this.name_field.Edit.Case = "any";
         this.name_field.Edit.FocusRectangle = false;
         this.name_field.Edit.AutoSelect = true;
         this.name_field.Edit.AutoHScroll = true;
         this.name_field.Font.FontFace = "Tahoma";
         this.name_field.Font.Height = -10;
         this.name_field.Font.Weight = 400;
         this.name_field.Font.FontFamily = "2";
         this.name_field.Font.Pitch = "2";
         this.name_field.Font.Charset = "0";
         this.name_field.Background.Mode = 1;
         this.name_field.Background.Color = "536870912";
         this.name_field.EditMask.MaskDataType = Mobilize.Web.MaskDataType.StringMask;
         this.age_field_t = new Mobilize.Web.DmText();
         this.age_field_t.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.age_field_t.Alignment = 1;
         this.age_field_t.Text = "Age Field:";
         this.age_field_t.Border = 0;
         this.age_field_t.Color = "33554432";
         this.age_field_t.X = 37;
         this.age_field_t.Y = 140;
         this.age_field_t.Height = 64;
         this.age_field_t.Width = 471;
         this.age_field_t.Name = Mobilize.Web.CaseExtensions.String("age_field_t");
         this.age_field_t.Visible = true;
         this.age_field_t.Font.FontFace = "Tahoma";
         this.age_field_t.Font.Height = -10;
         this.age_field_t.Font.Weight = 400;
         this.age_field_t.Font.FontFamily = "2";
         this.age_field_t.Font.Pitch = "2";
         this.age_field_t.Font.Charset = "0";
         this.age_field_t.Background.Mode = 1;
         this.age_field_t.Background.Color = "536870912";
         this.age_field = new Mobilize.Web.DmColumn();
         this.age_field.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.age_field.Id = 3;
         this.age_field.Alignment = 1;
         this.age_field.TabSequence = 20;
         this.age_field.Border = 0;
         this.age_field.Color = "33554432";
         this.age_field.X = 544;
         this.age_field.Y = 140;
         this.age_field.Height = 76;
         this.age_field.Width = 219;
         this.age_field.Format = "[general]";
         this.age_field.Name = Mobilize.Web.CaseExtensions.String("age_field");
         this.age_field.Visible = true;
         this.age_field.Edit.Limit = 0;
         this.age_field.Edit.Case = "any";
         this.age_field.Edit.FocusRectangle = false;
         this.age_field.Edit.AutoSelect = true;
         this.age_field.Edit.AutoHScroll = true;
         this.age_field.Font.FontFace = "Tahoma";
         this.age_field.Font.Height = -10;
         this.age_field.Font.Weight = 400;
         this.age_field.Font.FontFamily = "2";
         this.age_field.Font.Pitch = "2";
         this.age_field.Font.Charset = "0";
         this.age_field.Background.Mode = 1;
         this.age_field.Background.Color = "536870912";
         this.age_field.EditMask.MaskDataType = Mobilize.Web.MaskDataType.NumericMask;
         this.description_field_t = new Mobilize.Web.DmText();
         this.description_field_t.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.description_field_t.Alignment = 1;
         this.description_field_t.Text = "Description Field:";
         this.description_field_t.Border = 0;
         this.description_field_t.Color = "33554432";
         this.description_field_t.X = 37;
         this.description_field_t.Y = 276;
         this.description_field_t.Height = 64;
         this.description_field_t.Width = 471;
         this.description_field_t.Name = Mobilize.Web.CaseExtensions.String("description_field_t");
         this.description_field_t.Visible = true;
         this.description_field_t.Font.FontFace = "Tahoma";
         this.description_field_t.Font.Height = -10;
         this.description_field_t.Font.Weight = 400;
         this.description_field_t.Font.FontFamily = "2";
         this.description_field_t.Font.Pitch = "2";
         this.description_field_t.Font.Charset = "0";
         this.description_field_t.Background.Mode = 1;
         this.description_field_t.Background.Color = "536870912";
         this.description_field = new Mobilize.Web.DmColumn();
         this.description_field.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.description_field.Id = 6;
         this.description_field.Alignment = 0;
         this.description_field.TabSequence = 30;
         this.description_field.Border = 0;
         this.description_field.Color = "33554432";
         this.description_field.X = 549;
         this.description_field.Y = 276;
         this.description_field.Height = 292;
         this.description_field.Width = 1024;
         this.description_field.Format = "[general]";
         this.description_field.Name = Mobilize.Web.CaseExtensions.String("description_field");
         this.description_field.Visible = true;
         this.description_field.Edit.Limit = 0;
         this.description_field.Edit.Case = "any";
         this.description_field.Edit.FocusRectangle = false;
         this.description_field.Edit.AutoSelect = true;
         this.description_field.Edit.AutoHScroll = true;
         this.description_field.Font.FontFace = "Tahoma";
         this.description_field.Font.Height = -10;
         this.description_field.Font.Weight = 400;
         this.description_field.Font.FontFamily = "2";
         this.description_field.Font.Pitch = "2";
         this.description_field.Font.Charset = "0";
         this.description_field.Background.Mode = 1;
         this.description_field.Background.Color = "536870912";
         this.description_field.EditMask.MaskDataType = Mobilize.Web.MaskDataType.StringMask;
         this.date_field_t = new Mobilize.Web.DmText();
         this.date_field_t.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.date_field_t.Alignment = 1;
         this.date_field_t.Text = "Date Field:";
         this.date_field_t.Border = 0;
         this.date_field_t.Color = "33554432";
         this.date_field_t.X = 46;
         this.date_field_t.Y = 592;
         this.date_field_t.Height = 64;
         this.date_field_t.Width = 471;
         this.date_field_t.Name = Mobilize.Web.CaseExtensions.String("date_field_t");
         this.date_field_t.Visible = true;
         this.date_field_t.Font.FontFace = "Tahoma";
         this.date_field_t.Font.Height = -10;
         this.date_field_t.Font.Weight = 400;
         this.date_field_t.Font.FontFamily = "2";
         this.date_field_t.Font.Pitch = "2";
         this.date_field_t.Font.Charset = "0";
         this.date_field_t.Background.Mode = 1;
         this.date_field_t.Background.Color = "536870912";
         this.date_field = new Mobilize.Web.DmColumn();
         this.date_field.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.date_field.Id = 7;
         this.date_field.Alignment = 0;
         this.date_field.TabSequence = 40;
         this.date_field.Border = 0;
         this.date_field.Color = "33554432";
         this.date_field.X = 553;
         this.date_field.Y = 592;
         this.date_field.Height = 76;
         this.date_field.Width = 219;
         this.date_field.Format = "[general]";
         this.date_field.Name = Mobilize.Web.CaseExtensions.String("date_field");
         this.date_field.Visible = true;
         this.date_field.Edit.Limit = 0;
         this.date_field.Edit.Case = "any";
         this.date_field.Edit.FocusRectangle = false;
         this.date_field.Edit.AutoSelect = true;
         this.date_field.Edit.AutoHScroll = true;
         this.date_field.Font.FontFace = "Tahoma";
         this.date_field.Font.Height = -10;
         this.date_field.Font.Weight = 400;
         this.date_field.Font.FontFamily = "2";
         this.date_field.Font.Pitch = "2";
         this.date_field.Font.Charset = "0";
         this.date_field.Background.Mode = 1;
         this.date_field.Background.Color = "536870912";
         this.date_field.EditMask.MaskDataType = Mobilize.Web.MaskDataType.DateMask;
         this.event_date_field_t = new Mobilize.Web.DmText();
         this.event_date_field_t.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.event_date_field_t.Alignment = 1;
         this.event_date_field_t.Text = "Event Date Field:";
         this.event_date_field_t.Border = 0;
         this.event_date_field_t.Color = "33554432";
         this.event_date_field_t.X = 937;
         this.event_date_field_t.Y = 592;
         this.event_date_field_t.Height = 64;
         this.event_date_field_t.Width = 471;
         this.event_date_field_t.Name = Mobilize.Web.CaseExtensions.String("event_date_field_t");
         this.event_date_field_t.Visible = true;
         this.event_date_field_t.Font.FontFace = "Tahoma";
         this.event_date_field_t.Font.Height = -10;
         this.event_date_field_t.Font.Weight = 400;
         this.event_date_field_t.Font.FontFamily = "2";
         this.event_date_field_t.Font.Pitch = "2";
         this.event_date_field_t.Font.Charset = "0";
         this.event_date_field_t.Background.Mode = 1;
         this.event_date_field_t.Background.Color = "536870912";
         this.event_date_field = new Mobilize.Web.DmColumn();
         this.event_date_field.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.event_date_field.Id = 8;
         this.event_date_field.Alignment = 0;
         this.event_date_field.TabSequence = 50;
         this.event_date_field.Border = 0;
         this.event_date_field.Color = "33554432";
         this.event_date_field.X = 1445;
         this.event_date_field.Y = 592;
         this.event_date_field.Height = 76;
         this.event_date_field.Width = 219;
         this.event_date_field.Format = "[shortdate] [time]";
         this.event_date_field.Name = Mobilize.Web.CaseExtensions.String("event_date_field");
         this.event_date_field.Visible = true;
         this.event_date_field.Edit.Limit = 0;
         this.event_date_field.Edit.Case = "any";
         this.event_date_field.Edit.FocusRectangle = false;
         this.event_date_field.Edit.AutoSelect = true;
         this.event_date_field.Edit.AutoHScroll = true;
         this.event_date_field.Font.FontFace = "Tahoma";
         this.event_date_field.Font.Height = -10;
         this.event_date_field.Font.Weight = 400;
         this.event_date_field.Font.FontFamily = "2";
         this.event_date_field.Font.Pitch = "2";
         this.event_date_field.Font.Charset = "0";
         this.event_date_field.Background.Mode = 1;
         this.event_date_field.Background.Color = "536870912";
         this.event_date_field.EditMask.MaskDataType = Mobilize.Web.MaskDataType.DateTimeMask;
         this.salary_field_t = new Mobilize.Web.DmText();
         this.salary_field_t.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.salary_field_t.Alignment = 1;
         this.salary_field_t.Text = "Salary Field:";
         this.salary_field_t.Border = 0;
         this.salary_field_t.Color = "33554432";
         this.salary_field_t.X = 937;
         this.salary_field_t.Y = 728;
         this.salary_field_t.Height = 64;
         this.salary_field_t.Width = 471;
         this.salary_field_t.Name = Mobilize.Web.CaseExtensions.String("salary_field_t");
         this.salary_field_t.Visible = true;
         this.salary_field_t.Font.FontFace = "Tahoma";
         this.salary_field_t.Font.Height = -10;
         this.salary_field_t.Font.Weight = 400;
         this.salary_field_t.Font.FontFamily = "2";
         this.salary_field_t.Font.Pitch = "2";
         this.salary_field_t.Font.Charset = "0";
         this.salary_field_t.Background.Mode = 1;
         this.salary_field_t.Background.Color = "536870912";
         this.salary_field = new Mobilize.Web.DmColumn();
         this.salary_field.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.salary_field.Id = 9;
         this.salary_field.Alignment = 0;
         this.salary_field.TabSequence = 60;
         this.salary_field.Border = 0;
         this.salary_field.Color = "33554432";
         this.salary_field.X = 1445;
         this.salary_field.Y = 728;
         this.salary_field.Height = 76;
         this.salary_field.Width = 219;
         this.salary_field.Format = "[general]";
         this.salary_field.Name = Mobilize.Web.CaseExtensions.String("salary_field");
         this.salary_field.Visible = true;
         this.salary_field.Edit.Limit = 0;
         this.salary_field.Edit.Case = "any";
         this.salary_field.Edit.FocusRectangle = false;
         this.salary_field.Edit.AutoSelect = true;
         this.salary_field.Edit.AutoHScroll = true;
         this.salary_field.Font.FontFace = "Tahoma";
         this.salary_field.Font.Height = -10;
         this.salary_field.Font.Weight = 400;
         this.salary_field.Font.FontFamily = "2";
         this.salary_field.Font.Pitch = "2";
         this.salary_field.Font.Charset = "0";
         this.salary_field.Background.Mode = 1;
         this.salary_field.Background.Color = "536870912";
         this.salary_field.EditMask.MaskDataType = Mobilize.Web.MaskDataType.DecimalMask;
         this.flag_field = new Mobilize.Web.DmColumn();
         this.flag_field.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.flag_field.Id = 5;
         this.flag_field.Alignment = 0;
         this.flag_field.TabSequence = 70;
         this.flag_field.Border = 0;
         this.flag_field.Color = "33554432";
         this.flag_field.X = 1326;
         this.flag_field.Y = 20;
         this.flag_field.Height = 64;
         this.flag_field.Width = 215;
         this.flag_field.Format = "[general]";
         this.flag_field.Name = Mobilize.Web.CaseExtensions.String("flag_field");
         this.flag_field.Visible = true;
         this.flag_field.CheckBox.Text = "";
         this.flag_field.CheckBox.On = "88";
         this.flag_field.CheckBox.Off = "55";
         this.flag_field.Font.FontFace = "Tahoma";
         this.flag_field.Font.Height = -10;
         this.flag_field.Font.Weight = 400;
         this.flag_field.Font.FontFamily = "2";
         this.flag_field.Font.Pitch = "2";
         this.flag_field.Font.Charset = "0";
         this.flag_field.Background.Mode = 1;
         this.flag_field.Background.Color = "536870912";
         this.flag_field.EditMask.MaskDataType = Mobilize.Web.MaskDataType.NumericMask;
         this.t_1 = new Mobilize.Web.DmText();
         this.t_1.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.t_1.Alignment = 0;
         this.t_1.Text = "Flag";
         this.t_1.Border = 0;
         this.t_1.Color = "33554432";
         this.t_1.X = 1157;
         this.t_1.Y = 16;
         this.t_1.Height = 64;
         this.t_1.Width = 110;
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
         this.options_field = new Mobilize.Web.DmColumn();
         this.options_field.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.options_field.Id = 1;
         this.options_field.Alignment = 0;
         this.options_field.TabSequence = 80;
         this.options_field.Border = 0;
         this.options_field.Color = "33554432";
         this.options_field.X = 1399;
         this.options_field.Y = 124;
         this.options_field.Height = 132;
         this.options_field.Width = 494;
         this.options_field.Format = "[general]";
         this.options_field.Name = Mobilize.Web.CaseExtensions.String("options_field");
         this.options_field.Visible = true;
         this.options_field.RadioButtons.Columns = 1;
         this.options_field.Font.FontFace = "Tahoma";
         this.options_field.Font.Height = -10;
         this.options_field.Font.Weight = 400;
         this.options_field.Font.FontFamily = "2";
         this.options_field.Font.Pitch = "2";
         this.options_field.Font.Charset = "0";
         this.options_field.Background.Mode = 1;
         this.options_field.Background.Color = "536870912";
         this.options_field.EditMask.MaskDataType = Mobilize.Web.MaskDataType.NumericMask;
         this.t_2 = new Mobilize.Web.DmText();
         this.t_2.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.t_2.Alignment = 0;
         this.t_2.Text = "Options";
         this.t_2.Border = 0;
         this.t_2.Color = "33554432";
         this.t_2.X = 1138;
         this.t_2.Y = 120;
         this.t_2.Height = 64;
         this.t_2.Width = 197;
         this.t_2.Name = Mobilize.Web.CaseExtensions.String("t_2");
         this.t_2.Visible = true;
         this.t_2.Font.FontFace = "Tahoma";
         this.t_2.Font.Height = -10;
         this.t_2.Font.Weight = 400;
         this.t_2.Font.FontFamily = "2";
         this.t_2.Font.Pitch = "2";
         this.t_2.Font.Charset = "0";
         this.t_2.Background.Mode = 2;
         this.t_2.Background.Color = "1073741824";
         this.drop_field = new Mobilize.Web.DmColumn();
         this.drop_field.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.drop_field.Id = 4;
         this.drop_field.Alignment = 0;
         this.drop_field.TabSequence = 90;
         this.drop_field.Border = 0;
         this.drop_field.Color = "33554432";
         this.drop_field.X = 1915;
         this.drop_field.Y = 304;
         this.drop_field.Height = 76;
         this.drop_field.Width = 489;
         this.drop_field.Format = "[general]";
         this.drop_field.Name = Mobilize.Web.CaseExtensions.String("drop_field");
         this.drop_field.Visible = true;
         this.drop_field.DdLb.Limit = 0;
         this.drop_field.DdLb.AllowEdit = false;
         this.drop_field.DdLb.Case = Mobilize.Web.CaseExtensions.String("any");
         this.drop_field.Font.FontFace = "Tahoma";
         this.drop_field.Font.Height = -10;
         this.drop_field.Font.Weight = 400;
         this.drop_field.Font.FontFamily = "2";
         this.drop_field.Font.Pitch = "2";
         this.drop_field.Font.Charset = "0";
         this.drop_field.Background.Mode = 1;
         this.drop_field.Background.Color = "536870912";
         this.drop_field.EditMask.MaskDataType = Mobilize.Web.MaskDataType.NumericMask;
         this.t_3 = new Mobilize.Web.DmText();
         this.t_3.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.t_3.Alignment = 0;
         this.t_3.Text = "LOptions";
         this.t_3.Border = 0;
         this.t_3.Color = "33554432";
         this.t_3.X = 1646;
         this.t_3.Y = 304;
         this.t_3.Height = 64;
         this.t_3.Width = 224;
         this.t_3.Name = Mobilize.Web.CaseExtensions.String("t_3");
         this.t_3.Visible = true;
         this.t_3.Font.FontFace = "Tahoma";
         this.t_3.Font.Height = -10;
         this.t_3.Font.Weight = 400;
         this.t_3.Font.FontFamily = "2";
         this.t_3.Font.Pitch = "2";
         this.t_3.Font.Charset = "0";
         this.t_3.Background.Mode = 2;
         this.t_3.Background.Color = "1073741824";
         this.AddColumns(new Mobilize.Web.DB.Column[] { options_field_db1, name_field_db2, age_field_db3, drop_field_db4, flag_field_db5, description_field_db6, date_field_db7, event_date_field_db8, salary_field_db9 });
         this.AddControls(new Mobilize.Web.DmControl[] { this.name_field_t, this.name_field, this.age_field_t, this.age_field, this.description_field_t, this.description_field, this.date_field_t, this.date_field, this.event_date_field_t, this.event_date_field, this.salary_field_t, this.salary_field, this.flag_field, this.t_1, this.options_field, this.t_2, this.drop_field, this.t_3 });
         this.PopulateRadioButtons();
      }
   }

}