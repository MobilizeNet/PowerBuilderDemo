namespace reports
{

   [Mobilize.WebMap.Common.Attributes.Observable]
   public partial class w_main_report
      : Mobilize.Web.Window, reports.Iw_main_report
   {

      public override void Create()
      {
         this.cb_3 = CreateInnerControl_cb_3_type();
         this.cb_2 = CreateInnerControl_cb_2_type();
         this.cb_1 = CreateInnerControl_cb_1_type();
         this.dw_1 = CreateInnerControl_dw_1_type();
         this.Control = Mobilize.Web.ArrayExtensions.Clone<Mobilize.Web.IControl>(new Mobilize.Web.IControl[] { this.cb_3, this.cb_2, this.cb_1, this.dw_1 });
      }

      public override void Destroy()
      {
         this.cb_3 = null;
         this.cb_2 = null;
         this.cb_1 = null;
         this.dw_1 = null;
      }

      public virtual int? OpenWindow()
      {
         this.dw_1.DataObject = "dw_personlist";
         this.dw_1.Object.datawindow.print.preview = true;
         return null;
      //dw_1.retrieve()
      }

      public override void DoWmInit()
      {
         base.DoWmInit();
         this.open = new Mobilize.Web.OpenWindowEventHandler(OpenWindow);
      }

      protected virtual Iw_main_reportInner.Icb_3_type CreateInnerControl_cb_3_type()
      {
         return Mobilize.Web.Application.Create<Iw_main_reportInner.Icb_3_type>(this);
      }

      protected virtual Iw_main_reportInner.Icb_2_type CreateInnerControl_cb_2_type()
      {
         return Mobilize.Web.Application.Create<Iw_main_reportInner.Icb_2_type>(this);
      }

      protected virtual Iw_main_reportInner.Icb_1_type CreateInnerControl_cb_1_type()
      {
         return Mobilize.Web.Application.Create<Iw_main_reportInner.Icb_1_type>(this);
      }

      protected virtual Iw_main_reportInner.Idw_1_type CreateInnerControl_dw_1_type()
      {
         return Mobilize.Web.Application.Create<Iw_main_reportInner.Idw_1_type>(this);
      }

      public class cb_3_type
         : Mobilize.Web.CommandButton, Iw_main_reportInner.Icb_3_type
      {

         public cb_3_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_main_report Parent => (w_main_report)base.Parent;

         public virtual int? Clicked()
         {
            this.Parent.dw_1.DataObject = "dw_product";
            this.Parent.dw_1.SetRedraw(false);
            this.Parent.dw_1.InsertRow(1);
            this.Parent.dw_1.SetItem(1, "id", "69aff16332");
            this.Parent.dw_1.SetItem(1, "name", "Rice");
            this.Parent.dw_1.SetItem(1, "category", "Beans");
            this.Parent.dw_1.SetItem(1, "price", 2.00M);
            this.Parent.dw_1.SetItem(1, "vendor", "PlusProd");
            this.Parent.dw_1.InsertRow(2);
            this.Parent.dw_1.SetItem(2, "id", "fa3d29a86e");
            this.Parent.dw_1.SetItem(2, "name", "Corn");
            this.Parent.dw_1.SetItem(2, "category", "Beans");
            this.Parent.dw_1.SetItem(2, "price", 3.60M);
            this.Parent.dw_1.SetItem(2, "vendor", "Kell++");
            this.Parent.dw_1.InsertRow(3);
            this.Parent.dw_1.SetItem(3, "id", "d69c9e6147");
            this.Parent.dw_1.SetItem(3, "name", "Orange");
            this.Parent.dw_1.SetItem(3, "category", "Fruits");
            this.Parent.dw_1.SetItem(3, "price", 0.50M);
            this.Parent.dw_1.SetItem(3, "vendor", "DeliFruits");
            this.Parent.dw_1.InsertRow(4);
            this.Parent.dw_1.SetItem(4, "id", "d94644325b");
            this.Parent.dw_1.SetItem(4, "name", "Soap");
            this.Parent.dw_1.SetItem(4, "category", "Home");
            this.Parent.dw_1.SetItem(4, "price", 1.23M);
            this.Parent.dw_1.SetItem(4, "vendor", "HomeClean");
            this.Parent.dw_1.InsertRow(5);
            this.Parent.dw_1.SetItem(5, "id", "9e7c2fbc12");
            this.Parent.dw_1.SetItem(5, "name", "Water");
            this.Parent.dw_1.SetItem(5, "category", "Drinks");
            this.Parent.dw_1.SetItem(5, "price", 0.89M);
            this.Parent.dw_1.SetItem(5, "vendor", "DrinkMore");
            this.Parent.dw_1.InsertRow(6);
            this.Parent.dw_1.SetItem(6, "id", "85a4b4ea34");
            this.Parent.dw_1.SetItem(6, "name", "Shampoo");
            this.Parent.dw_1.SetItem(6, "category", "Home");
            this.Parent.dw_1.SetItem(6, "price", 1.10M);
            this.Parent.dw_1.SetItem(6, "vendor", "HeadClean");
            this.Parent.dw_1.InsertRow(7);
            this.Parent.dw_1.SetItem(7, "id", "d4d00ff4a1");
            this.Parent.dw_1.SetItem(7, "name", "Brush");
            this.Parent.dw_1.SetItem(7, "category", "Home");
            this.Parent.dw_1.SetItem(7, "price", 36.00M);
            this.Parent.dw_1.SetItem(7, "vendor", "HomeClean");
            this.Parent.dw_1.InsertRow(8);
            this.Parent.dw_1.SetItem(8, "id", "5943dc2bb2");
            this.Parent.dw_1.SetItem(8, "name", "WaterMelon");
            this.Parent.dw_1.SetItem(8, "category", "Fruits");
            this.Parent.dw_1.SetItem(8, "price", 9.30M);
            this.Parent.dw_1.SetItem(8, "vendor", "DeliFruits");
            this.Parent.dw_1.SetRedraw(true);
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 4681;
            this.Y = 620;
            this.Width = 384;
            this.Height = 112;
            this.TabOrder = 30;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.Text = "Report #3";
            this.bnclicked = new Mobilize.Web.ClickedEventHandler(Clicked);
         }

      }

      public class cb_2_type
         : Mobilize.Web.CommandButton, Iw_main_reportInner.Icb_2_type
      {

         public cb_2_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_main_report Parent => (w_main_report)base.Parent;

         public virtual int? Clicked()
         {
            this.Parent.dw_1.DataObject = "dw_birthday";
            this.Parent.dw_1.Object.datawindow.print.preview = false;
            this.Parent.dw_1.SetRedraw(false);
            this.Parent.dw_1.InsertRow(1);
            this.Parent.dw_1.SetItem(1, "name", "Amare");
            this.Parent.dw_1.SetItem(1, "lastname1", "Stark");
            this.Parent.dw_1.SetItem(1, "lastname2", "Ferrer");
            this.Parent.dw_1.SetItem(1, "where", "Charlottes's House");
            this.Parent.dw_1.SetItem(1, "when", Mobilize.Web.TypeConversion.DateTime("2006-06-06 06:06:06"));
            this.Parent.dw_1.InsertRow(2);
            this.Parent.dw_1.SetItem(2, "name", "Rudy");
            this.Parent.dw_1.SetItem(2, "lastname1", "Odom");
            this.Parent.dw_1.SetItem(2, "lastname2", "Soto");
            this.Parent.dw_1.SetItem(2, "where", "Charlottes's House");
            this.Parent.dw_1.SetItem(2, "when", Mobilize.Web.TypeConversion.DateTime("2006-06-06 06:06:06"));
            this.Parent.dw_1.InsertRow(3);
            this.Parent.dw_1.SetItem(3, "name", "Deon");
            this.Parent.dw_1.SetItem(3, "lastname1", "Strong");
            this.Parent.dw_1.SetItem(3, "lastname2", "Herrero");
            this.Parent.dw_1.SetItem(3, "where", "Charlottes's House");
            this.Parent.dw_1.SetItem(3, "when", Mobilize.Web.TypeConversion.DateTime("2006-06-06 06:06:06"));
            this.Parent.dw_1.InsertRow(4);
            this.Parent.dw_1.SetItem(4, "name", "Eden");
            this.Parent.dw_1.SetItem(4, "lastname1", "Mejia");
            this.Parent.dw_1.SetItem(4, "lastname2", "Ochoa");
            this.Parent.dw_1.SetItem(4, "where", "Charlottes's House");
            this.Parent.dw_1.SetItem(4, "when", Mobilize.Web.TypeConversion.DateTime("2006-06-06 06:06:06"));
            this.Parent.dw_1.InsertRow(5);
            this.Parent.dw_1.SetItem(5, "name", "Mike");
            this.Parent.dw_1.SetItem(5, "lastname1", "Deleon");
            this.Parent.dw_1.SetItem(5, "lastname2", "Cruz");
            this.Parent.dw_1.SetItem(5, "where", "Charlottes's House");
            this.Parent.dw_1.SetItem(5, "when", Mobilize.Web.TypeConversion.DateTime("2006-06-06 06:06:06"));
            this.Parent.dw_1.InsertRow(6);
            this.Parent.dw_1.SetItem(6, "name", "Caroline");
            this.Parent.dw_1.SetItem(6, "lastname1", "Bowers");
            this.Parent.dw_1.SetItem(6, "lastname2", "Romero");
            this.Parent.dw_1.SetItem(6, "where", "Charlottes's House");
            this.Parent.dw_1.SetItem(6, "when", Mobilize.Web.TypeConversion.DateTime("2006-06-06 06:06:06"));
            this.Parent.dw_1.SetRedraw(true);
            this.Parent.dw_1.Object.datawindow.print.preview = true;
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 4681;
            this.Y = 392;
            this.Width = 384;
            this.Height = 112;
            this.TabOrder = 30;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.Text = "Report #2";
            this.bnclicked = new Mobilize.Web.ClickedEventHandler(Clicked);
         }

      }

      public class cb_1_type
         : Mobilize.Web.CommandButton, Iw_main_reportInner.Icb_1_type
      {

         public cb_1_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_main_report Parent => (w_main_report)base.Parent;

         public virtual int? Clicked()
         {
            this.Parent.dw_1.DataObject = "dw_personlist";
            this.Parent.dw_1.Object.datawindow.print.preview = false;
            this.Parent.dw_1.SetRedraw(false);
            this.Parent.dw_1.InsertRow(1);
            this.Parent.dw_1.SetItem(1, "name", "Rylie");
            this.Parent.dw_1.SetItem(1, "LastName1", "Hogan");
            this.Parent.dw_1.SetItem(1, "LastName2", "Caballero");
            this.Parent.dw_1.SetItem(1, "age", 22);
            this.Parent.dw_1.SetItem(1, "startdate", Mobilize.Web.PbDate.Date(2019, 9, 22));
            this.Parent.dw_1.SetItem(1, "country", "Costa Rica");
            this.Parent.dw_1.SetItem(1, "Registration", Mobilize.Web.TypeConversion.DateTime("08/09/2003 08:00"));
            this.Parent.dw_1.InsertRow(2);
            this.Parent.dw_1.SetItem(2, "name", "Amari");
            this.Parent.dw_1.SetItem(2, "LastName1", "Soler");
            this.Parent.dw_1.SetItem(2, "LastName2", "Caballero");
            this.Parent.dw_1.SetItem(2, "age", 31);
            this.Parent.dw_1.SetItem(2, "startdate", Mobilize.Web.PbDate.Date("2001-09-13"));
            this.Parent.dw_1.SetItem(2, "country", "Costa Rica");
            this.Parent.dw_1.SetItem(2, "registration", Mobilize.Web.TypeConversion.DateTime("2017-03-06 06:59:32"));
            this.Parent.dw_1.InsertRow(3);
            this.Parent.dw_1.SetItem(3, "name", "Stacy");
            this.Parent.dw_1.SetItem(3, "LastName1", "Littler");
            this.Parent.dw_1.SetItem(3, "LastName2", "Aguilar");
            this.Parent.dw_1.SetItem(3, "age", 36);
            this.Parent.dw_1.SetItem(3, "startdate", Mobilize.Web.PbDate.Date(2012, 12, 12));
            this.Parent.dw_1.SetItem(3, "country", "Mexico");
            this.Parent.dw_1.SetItem(3, "registration", Mobilize.Web.TypeConversion.DateTime("2005-04-02 09:00:09"));
            this.Parent.dw_1.InsertRow(4);
            this.Parent.dw_1.SetItem(4, "name", "Devan");
            this.Parent.dw_1.SetItem(4, "LastName1", "Weber");
            this.Parent.dw_1.SetItem(4, "LastName2", "Alonso");
            this.Parent.dw_1.SetItem(4, "age", 56);
            this.Parent.dw_1.SetItem(4, "startdate", Mobilize.Web.PbDate.Date(2019, 9, 22));
            this.Parent.dw_1.SetItem(4, "country", "Costa Rica");
            this.Parent.dw_1.SetItem(4, "registration", Mobilize.Web.TypeConversion.DateTime("2009-02-14 00:00:00"));
            this.Parent.dw_1.InsertRow(5);
            this.Parent.dw_1.SetItem(5, "name", "Levi");
            this.Parent.dw_1.SetItem(5, "LastName1", "Ross");
            this.Parent.dw_1.SetItem(5, "LastName2", "Campos");
            this.Parent.dw_1.SetItem(5, "age", 36);
            this.Parent.dw_1.SetItem(5, "startdate", Mobilize.Web.PbDate.Date(2012, 12, 12));
            this.Parent.dw_1.SetItem(5, "country", "Norway");
            this.Parent.dw_1.SetItem(5, "registration", Mobilize.Web.TypeConversion.DateTime("2012-12-12 15:58:00"));
            this.Parent.dw_1.InsertRow(6);
            this.Parent.dw_1.SetItem(6, "name", "Miles");
            this.Parent.dw_1.SetItem(6, "LastName1", "Gentry");
            this.Parent.dw_1.SetItem(6, "LastName2", "Carmona");
            this.Parent.dw_1.SetItem(6, "age", 61);
            this.Parent.dw_1.SetItem(6, "startdate", Mobilize.Web.PbDate.Date(2001, 9, 13));
            this.Parent.dw_1.SetItem(6, "country", "Norway");
            this.Parent.dw_1.SetItem(6, "registration", Mobilize.Web.TypeConversion.DateTime("2017-03-06 06:59:32"));
            this.Parent.dw_1.InsertRow(7);
            this.Parent.dw_1.SetItem(7, "name", "Warren");
            this.Parent.dw_1.SetItem(7, "LastName1", "Perez");
            this.Parent.dw_1.SetItem(7, "LastName2", "Ortega");
            this.Parent.dw_1.SetItem(7, "age", 69);
            this.Parent.dw_1.SetItem(7, "startdate", Mobilize.Web.PbDate.Date(2019, 9, 22));
            this.Parent.dw_1.SetItem(7, "country", "Costa Rica");
            this.Parent.dw_1.SetItem(7, "registration", Mobilize.Web.TypeConversion.DateTime("2017-03-06 06:59:32"));
            this.Parent.dw_1.InsertRow(8);
            this.Parent.dw_1.SetItem(8, "name", "Jassie");
            this.Parent.dw_1.SetItem(8, "LastName1", "Webster");
            this.Parent.dw_1.SetItem(8, "LastName2", "Fernandez");
            this.Parent.dw_1.SetItem(8, "age", 87);
            this.Parent.dw_1.SetItem(8, "startdate", Mobilize.Web.PbDate.Date(2012, 12, 12));
            this.Parent.dw_1.SetItem(8, "country", "Costa Rica");
            this.Parent.dw_1.SetItem(8, "registration", Mobilize.Web.TypeConversion.DateTime("2005-04-02 09:00:09"));
            this.Parent.dw_1.InsertRow(9);
            this.Parent.dw_1.SetItem(9, "name", "Lyla");
            this.Parent.dw_1.SetItem(9, "LastName1", "Dickerson");
            this.Parent.dw_1.SetItem(9, "LastName2", "Ruiz");
            this.Parent.dw_1.SetItem(9, "age", 91);
            this.Parent.dw_1.SetItem(9, "startdate", Mobilize.Web.PbDate.Date("2001-09-13"));
            this.Parent.dw_1.SetItem(9, "country", "Costa Rica");
            this.Parent.dw_1.SetItem(9, "registration", Mobilize.Web.TypeConversion.DateTime("2005-04-02 09:00:09"));
            this.Parent.dw_1.InsertRow(10);
            this.Parent.dw_1.SetItem(10, "name", "Jayleen");
            this.Parent.dw_1.SetItem(10, "LastName1", "Downs");
            this.Parent.dw_1.SetItem(10, "LastName2", "Calvo");
            this.Parent.dw_1.SetItem(10, "age", 25);
            this.Parent.dw_1.SetItem(10, "startdate", Mobilize.Web.PbDate.Date(2001, 9, 13));
            this.Parent.dw_1.SetItem(10, "country", "Norway");
            this.Parent.dw_1.SetItem(10, "registration", Mobilize.Web.TypeConversion.DateTime("2005-04-02 09:00:09"));
            this.Parent.dw_1.InsertRow(11);
            this.Parent.dw_1.SetItem(11, "name", "Azaria");
            this.Parent.dw_1.SetItem(11, "LastName1", "Livingston");
            this.Parent.dw_1.SetItem(11, "LastName2", "Ibannes");
            this.Parent.dw_1.SetItem(11, "age", 26);
            this.Parent.dw_1.SetItem(11, "startdate", Mobilize.Web.PbDate.Date(2019, 9, 22));
            this.Parent.dw_1.SetItem(11, "country", "Costa Rica");
            this.Parent.dw_1.SetItem(11, "registration", Mobilize.Web.TypeConversion.DateTime("2017-03-06 06:59:32"));
            this.Parent.dw_1.InsertRow(12);
            this.Parent.dw_1.SetItem(12, "name", "Misael");
            this.Parent.dw_1.SetItem(12, "LastName1", "Cherry");
            this.Parent.dw_1.SetItem(12, "LastName2", "Alvarez");
            this.Parent.dw_1.SetItem(12, "age", 28);
            this.Parent.dw_1.SetItem(12, "startdate", Mobilize.Web.PbDate.Date(2012, 12, 12));
            this.Parent.dw_1.SetItem(12, "country", "Norway");
            this.Parent.dw_1.SetItem(12, "registration", Mobilize.Web.TypeConversion.DateTime("2009-02-14 00:00:00"));
            this.Parent.dw_1.InsertRow(13);
            this.Parent.dw_1.SetItem(13, "name", "Reese");
            this.Parent.dw_1.SetItem(13, "LastName1", "Gray");
            this.Parent.dw_1.SetItem(13, "LastName2", "Gil");
            this.Parent.dw_1.SetItem(13, "age", 20);
            this.Parent.dw_1.SetItem(13, "startdate", Mobilize.Web.PbDate.Date("2001-09-13"));
            this.Parent.dw_1.SetItem(13, "country", "Costa Rica");
            this.Parent.dw_1.SetItem(13, "registration", Mobilize.Web.TypeConversion.DateTime("2005-04-02 09:00:09"));
            this.Parent.dw_1.InsertRow(14);
            this.Parent.dw_1.SetItem(14, "name", "Amber");
            this.Parent.dw_1.SetItem(14, "LastName1", "Higgins");
            this.Parent.dw_1.SetItem(14, "LastName2", "Diaz");
            this.Parent.dw_1.SetItem(14, "age", 22);
            this.Parent.dw_1.SetItem(14, "startdate", Mobilize.Web.PbDate.Date(2019, 9, 22));
            this.Parent.dw_1.SetItem(14, "country", "Mexico");
            this.Parent.dw_1.SetItem(14, "registration", Mobilize.Web.TypeConversion.DateTime("2009-02-14 00:00:00"));
            this.Parent.dw_1.InsertRow(15);
            this.Parent.dw_1.SetItem(15, "name", "Mariana");
            this.Parent.dw_1.SetItem(15, "LastName1", "Pacheco");
            this.Parent.dw_1.SetItem(15, "LastName2", "Gomez");
            this.Parent.dw_1.SetItem(15, "age", 24);
            this.Parent.dw_1.SetItem(15, "startdate", Mobilize.Web.PbDate.Date(2001, 9, 13));
            this.Parent.dw_1.SetItem(15, "country", "Mexico");
            this.Parent.dw_1.SetItem(15, "registration", Mobilize.Web.TypeConversion.DateTime("2017-03-06 06:59:32"));
            this.Parent.dw_1.InsertRow(16);
            this.Parent.dw_1.SetItem(16, "name", "Zaid");
            this.Parent.dw_1.SetItem(16, "LastName1", "Balwin");
            this.Parent.dw_1.SetItem(16, "LastName2", "Pascual");
            this.Parent.dw_1.SetItem(16, "age", 21);
            this.Parent.dw_1.SetItem(16, "startdate", Mobilize.Web.PbDate.Date(2001, 9, 13));
            this.Parent.dw_1.SetItem(16, "country", "Mexico");
            this.Parent.dw_1.SetItem(16, "registration", Mobilize.Web.TypeConversion.DateTime("2005-04-02 09:00:09"));
            this.Parent.dw_1.InsertRow(17);
            this.Parent.dw_1.SetItem(17, "name", "Hamza");
            this.Parent.dw_1.SetItem(17, "LastName1", "Valentine");
            this.Parent.dw_1.SetItem(17, "LastName2", "Vicente");
            this.Parent.dw_1.SetItem(17, "age", 35);
            this.Parent.dw_1.SetItem(17, "startdate", Mobilize.Web.PbDate.Date(2012, 12, 12));
            this.Parent.dw_1.SetItem(17, "country", "Norway");
            this.Parent.dw_1.SetItem(17, "registration", Mobilize.Web.TypeConversion.DateTime("2017-03-06 06:59:32"));
            this.Parent.dw_1.InsertRow(18);
            this.Parent.dw_1.SetItem(18, "name", "Luz");
            this.Parent.dw_1.SetItem(18, "LastName1", "Sandoval");
            this.Parent.dw_1.SetItem(18, "LastName2", "Vicente");
            this.Parent.dw_1.SetItem(18, "age", 39);
            this.Parent.dw_1.SetItem(18, "startdate", Mobilize.Web.PbDate.Date(2012, 12, 12));
            this.Parent.dw_1.SetItem(18, "country", "Norway");
            this.Parent.dw_1.SetItem(18, "registration", Mobilize.Web.TypeConversion.DateTime("2009-02-14 00:00:00"));
            this.Parent.dw_1.InsertRow(19);
            this.Parent.dw_1.SetItem(19, "name", "Ariel");
            this.Parent.dw_1.SetItem(19, "LastName1", "Mccarty");
            this.Parent.dw_1.SetItem(19, "LastName2", "Rodriguez");
            this.Parent.dw_1.SetItem(19, "age", 36);
            this.Parent.dw_1.SetItem(19, "startdate", Mobilize.Web.PbDate.Date(2019, 9, 22));
            this.Parent.dw_1.SetItem(19, "country", "Norway");
            this.Parent.dw_1.SetItem(19, "registration", Mobilize.Web.TypeConversion.DateTime("2009-02-14 00:00:00"));
            this.Parent.dw_1.InsertRow(20);
            this.Parent.dw_1.SetItem(20, "name", "Aurora");
            this.Parent.dw_1.SetItem(20, "LastName1", "York");
            this.Parent.dw_1.SetItem(20, "LastName2", "Martin");
            this.Parent.dw_1.SetItem(20, "age", 41);
            this.Parent.dw_1.SetItem(20, "startdate", Mobilize.Web.PbDate.Date(2001, 9, 13));
            this.Parent.dw_1.SetItem(20, "country", "Norway");
            this.Parent.dw_1.SetItem(20, "registration", Mobilize.Web.TypeConversion.DateTime("2017-03-06 06:59:32"));
            this.Parent.dw_1.InsertRow(21);
            this.Parent.dw_1.SetItem(21, "name", "Skyler");
            this.Parent.dw_1.SetItem(21, "LastName1", "Erickson");
            this.Parent.dw_1.SetItem(21, "LastName2", "Castro");
            this.Parent.dw_1.SetItem(21, "age", 38);
            this.Parent.dw_1.SetItem(21, "startdate", Mobilize.Web.PbDate.Date(2012, 12, 12));
            this.Parent.dw_1.SetItem(21, "country", "Mexico");
            this.Parent.dw_1.SetItem(21, "registration", Mobilize.Web.TypeConversion.DateTime("2017-03-06 06:59:32"));
            this.Parent.dw_1.InsertRow(22);
            this.Parent.dw_1.SetItem(22, "name", "Kira");
            this.Parent.dw_1.SetItem(22, "LastName1", "Flowers");
            this.Parent.dw_1.SetItem(22, "LastName2", "Gallardo");
            this.Parent.dw_1.SetItem(22, "age", 35);
            this.Parent.dw_1.SetItem(22, "startdate", Mobilize.Web.PbDate.Date(2019, 9, 22));
            this.Parent.dw_1.SetItem(22, "country", "Costa Rica");
            this.Parent.dw_1.SetItem(22, "registration", Mobilize.Web.TypeConversion.DateTime("2005-04-02 09:00:09"));
            this.Parent.dw_1.InsertRow(23);
            this.Parent.dw_1.SetItem(23, "name", "Brent");
            this.Parent.dw_1.SetItem(23, "LastName1", "Atkinson");
            this.Parent.dw_1.SetItem(23, "LastName2", "Nieto");
            this.Parent.dw_1.SetItem(23, "age", 37);
            this.Parent.dw_1.SetItem(23, "startdate", Mobilize.Web.PbDate.Date(2012, 12, 12));
            this.Parent.dw_1.SetItem(23, "country", "Costa Rica");
            this.Parent.dw_1.SetItem(23, "registration", Mobilize.Web.TypeConversion.DateTime("2017-03-06 06:59:32"));
            this.Parent.dw_1.InsertRow(24);
            this.Parent.dw_1.SetItem(24, "name", "Alexia");
            this.Parent.dw_1.SetItem(24, "LastName1", "Baldwin");
            this.Parent.dw_1.SetItem(24, "LastName2", "Perez");
            this.Parent.dw_1.SetItem(24, "age", 31);
            this.Parent.dw_1.SetItem(24, "startdate", Mobilize.Web.PbDate.Date(2019, 9, 22));
            this.Parent.dw_1.SetItem(24, "country", "Mexico");
            this.Parent.dw_1.SetItem(24, "registration", Mobilize.Web.TypeConversion.DateTime("2005-04-02 09:00:09"));
            this.Parent.dw_1.InsertRow(25);
            this.Parent.dw_1.SetItem(25, "name", "Clara");
            this.Parent.dw_1.SetItem(25, "LastName1", "Holden");
            this.Parent.dw_1.SetItem(25, "LastName2", "Vidal");
            this.Parent.dw_1.SetItem(25, "age", 29);
            this.Parent.dw_1.SetItem(25, "startdate", Mobilize.Web.PbDate.Date("2001-09-13"));
            this.Parent.dw_1.SetItem(25, "country", "Costa Rica");
            this.Parent.dw_1.SetItem(25, "registration", Mobilize.Web.TypeConversion.DateTime("2005-04-02 09:00:09"));
            this.Parent.dw_1.SetSort("country A startdate A ");
            this.Parent.dw_1.Sort();
            this.Parent.dw_1.SetRedraw(true);
            this.Parent.dw_1.Object.datawindow.print.preview = true;
            return 1;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 4663;
            this.Y = 172;
            this.Width = 402;
            this.Height = 112;
            this.TabOrder = 20;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.Text = "Report #1";
            this.bnclicked = new Mobilize.Web.ClickedEventHandler(Clicked);
         }

      }

      public class dw_1_type
         : Mobilize.Web.DataManagerControl, Iw_main_reportInner.Idw_1_type
      {

         public dw_1_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_main_report Parent => (w_main_report)base.Parent;

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 128;
            this.Y = 140;
            this.Width = 4453;
            this.Height = 3192;
            this.TabOrder = 10;
            this.Title = "none";
            this.LiveScroll = true;
            this.BorderStyle = Mobilize.Web.BorderStyle.StyleLowered;
         }

      }

   }

}