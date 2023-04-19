namespace medicationcenter
{

   [Mobilize.WebMap.Common.Attributes.Observable]
   public partial class tb_tabbase
      : Mobilize.Web.Tab, medicationcenter.Itb_tabbase
   {

      public override void Create()
      {
         this.tabpage_add = CreateInnerControl_tabpage_add_type();
         this.tabpage_remove = CreateInnerControl_tabpage_remove_type();
         this.tabpage_search = CreateInnerControl_tabpage_search_type();
         this.Control = Mobilize.Web.ArrayExtensions.Clone<Mobilize.Web.IControl>(new Mobilize.Web.IUserObject[] { this.tabpage_add, this.tabpage_remove, this.tabpage_search });
      }

      public override void Destroy()
      {
         this.tabpage_add = null;
         this.tabpage_remove = null;
         this.tabpage_search = null;
      }

      public virtual void loadremovedata(Mobilize.Web.IDataManagerControl dw)
      {
         models.Istr_prescription presc = Mobilize.Web.Application.Create<models.Istr_prescription>();
         short? i = 0, offset = 0;
         Mobilize.Web.IDataManagerChild dddw = Mobilize.Web.Application.Create<Mobilize.Web.IDataManagerChild>();
         short? result = 0;
         result = dw.GetChild("iid", dddw);
         if ( Mobilize.Web.BuiltInExtensions.IsValid(dddw) == true )
         {
            dddw.Reset();
            for ( i = 1; i <= ((Mobilize.Web.IArray<models.Istr_prescription>)(Mobilize.Web.Application.CurrentApplication.Variables.prescritions<Mobilize.Web.IArray<models.Istr_prescription>>())).GetUpperBound(); ++i )
            {
               presc = ((Mobilize.Web.IArray<models.Istr_prescription>)(Mobilize.Web.Application.CurrentApplication.Variables.prescritions<Mobilize.Web.IArray<models.Istr_prescription>>()))[i]?.ByVal();
               if ( Mobilize.Web.Comparison.Equals(presc.state, 1) == true )
               {
                  dddw.InsertRow(0);
                  dddw.SetItem(i - offset, "id", presc.iid);
                  dddw.SetItem(i - offset, "prescdata", Mobilize.Web.PlusFunctions.Plus(Mobilize.Web.PlusFunctions.Plus(Mobilize.Web.PlusFunctions.Plus(Mobilize.Web.PlusFunctions.Plus(Mobilize.Web.PlusFunctions.Plus(basecomponents.basecomponentsGlobalFunctions.getpatienbyid(presc.patient), ", "), basecomponents.basecomponentsGlobalFunctions.getmedicinebyid(presc.medicine)), ", "), Mobilize.Web.CaseExtensions.String(presc.dose)), " gr"));
               }
               else
               {
                  offset = (short?)(offset + 1);
               }
            }
         }
      }

      public virtual void resetadddata()
      {
         this.tabpage_add.dw_add.Reset();
         this.tabpage_add.dw_add.InsertRow(0);
      }

      public override void DoWmInit()
      {
         base.DoWmInit();
         this.adddirtyEventHandler = this.adddirty;
         this.removedirtyEventHandler = this.removedirty;
         this.dosearchEventHandler = this.dosearch;
      }

      public virtual void adddirty()
      {
      }

      public virtual void removedirty()
      {
      }

      public virtual void dosearch()
      {
      }

      protected virtual Itb_tabbaseInner.Itabpage_add_type CreateInnerControl_tabpage_add_type()
      {
         return Mobilize.Web.Application.Create<Itb_tabbaseInner.Itabpage_add_type>(this);
      }

      protected virtual Itb_tabbaseInner.Itabpage_remove_type CreateInnerControl_tabpage_remove_type()
      {
         return Mobilize.Web.Application.Create<Itb_tabbaseInner.Itabpage_remove_type>(this);
      }

      protected virtual Itb_tabbaseInner.Itabpage_search_type CreateInnerControl_tabpage_search_type()
      {
         return Mobilize.Web.Application.Create<Itb_tabbaseInner.Itabpage_search_type>(this);
      }

      public partial class tabpage_add_type
         : Mobilize.Web.UserObject, Itb_tabbaseInner.Itabpage_add_type
      {

         public tabpage_add_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new tb_tabbase Parent => (tb_tabbase)base.Parent;

         public virtual void adddirty()
         {
            this.Parent.adddirty();
         }

         [Mobilize.WebMap.Common.Attributes.Intercepted]
         public Itb_tabbaseInner.Itabpage_add_typeInner.Idw_add_type dw_add { get; set; }

         public Mobilize.Web.VoidEventHandler CreateEventHandler { get; set; }

         public Mobilize.Web.VoidEventHandler DestroyEventHandler { get; set; }

         public Mobilize.Web.VoidEventHandler adddirtyEventHandler { get; set; }

         public override void Create()
         {
            this.dw_add = CreateInnerControl_dw_add_type();
            this.Control = Mobilize.Web.ArrayExtensions.Clone<Mobilize.Web.IControl>(new Mobilize.Web.IControl[] { this.dw_add });
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 18;
            this.Y = 112;
            this.Width = 2551;
            this.Height = 880;
            this.BackColor = 67108864;
            this.Text = "Add Prescription";
            this.TabTextColor = 33554432;
            this.PictureMaskColor = 536870912;
            this.adddirtyEventHandler = this.adddirty;
         }

         protected virtual Itb_tabbaseInner.Itabpage_add_typeInner.Idw_add_type CreateInnerControl_dw_add_type()
         {
            return Mobilize.Web.Application.Create<Itb_tabbaseInner.Itabpage_add_typeInner.Idw_add_type>(this);
         }

         public class dw_add_type
            : Mobilize.Web.DataManagerControl, Itb_tabbaseInner.Itabpage_add_typeInner.Idw_add_type
         {

            public dw_add_type(Mobilize.Web.BaseControl parent)
            : base(parent)
            {
            }

            private new tb_tabbase.tabpage_add_type Parent => (tb_tabbase.tabpage_add_type)base.Parent;

            public virtual short? ItemChanged(int? row, Mobilize.Web.IDmControl dwo, string data)
            {
               this.Parent.adddirty();
               return null;
            }

            public virtual void resetdata()
            {
               this.Reset();
               this.InsertRow(0);
            }

            public Mobilize.Web.VoidEventHandler resetdataEventHandler { get; set; }

            public override void DoWmInit()
            {
               base.DoWmInit();
               this.X = 27;
               this.Y = 48;
               this.Width = 2501;
               this.Height = 796;
               this.TabOrder = 10;
               this.Title = "none";
               this.DataObject = "d_addprescription";
               this.LiveScroll = true;
               this.BorderStyle = Mobilize.Web.BorderStyle.StyleLowered;
               this.dwnitemchange = new Mobilize.Web.DataManagerItemChangedEventHandler(ItemChanged);
               this.resetdataEventHandler = this.resetdata;
            }

         }

      }

      public partial class tabpage_remove_type
         : Mobilize.Web.UserObject, Itb_tabbaseInner.Itabpage_remove_type
      {

         public tabpage_remove_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new tb_tabbase Parent => (tb_tabbase)base.Parent;

         public virtual void removedirty()
         {
            this.Parent.removedirty();
         }

         [Mobilize.WebMap.Common.Attributes.Intercepted]
         public Itb_tabbaseInner.Itabpage_remove_typeInner.Idw_remove_type dw_remove { get; set; }

         public Mobilize.Web.VoidEventHandler CreateEventHandler { get; set; }

         public Mobilize.Web.VoidEventHandler DestroyEventHandler { get; set; }

         public Mobilize.Web.VoidEventHandler removedirtyEventHandler { get; set; }

         public override void Create()
         {
            this.dw_remove = CreateInnerControl_dw_remove_type();
            this.Control = Mobilize.Web.ArrayExtensions.Clone<Mobilize.Web.IControl>(new Mobilize.Web.IControl[] { this.dw_remove });
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 18;
            this.Y = 112;
            this.Width = 2551;
            this.Height = 880;
            this.BackColor = 67108864;
            this.Text = "Remove Prescription";
            this.TabTextColor = 33554432;
            this.PictureMaskColor = 536870912;
            this.removedirtyEventHandler = this.removedirty;
         }

         protected virtual Itb_tabbaseInner.Itabpage_remove_typeInner.Idw_remove_type CreateInnerControl_dw_remove_type()
         {
            return Mobilize.Web.Application.Create<Itb_tabbaseInner.Itabpage_remove_typeInner.Idw_remove_type>(this);
         }

         public class dw_remove_type
            : Mobilize.Web.DataManagerControl, Itb_tabbaseInner.Itabpage_remove_typeInner.Idw_remove_type
         {

            public dw_remove_type(Mobilize.Web.BaseControl parent)
            : base(parent)
            {
            }

            private new tb_tabbase.tabpage_remove_type Parent => (tb_tabbase.tabpage_remove_type)base.Parent;

            public virtual short? ItemChanged(int? row, Mobilize.Web.IDmControl dwo, string data)
            {
               this.Parent.removedirty();
               return null;
            }

            public virtual int? Constructor()
            {
               Parent.Parent.loadremovedata(this);
               return null;
            }

            public virtual void reloadremovedata()
            {
               Parent.Parent.loadremovedata(this);
            }

            public virtual void resetdata()
            {
               this.Reset();
               this.InsertRow(0);
            }

            public Mobilize.Web.VoidEventHandler reloadremovedataEventHandler { get; set; }

            public Mobilize.Web.VoidEventHandler resetdataEventHandler { get; set; }

            public override void DoWmInit()
            {
               base.DoWmInit();
               this.X = 27;
               this.Y = 48;
               this.Width = 2501;
               this.Height = 796;
               this.TabOrder = 10;
               this.Title = "none";
               this.DataObject = "d_removeprescription";
               this.LiveScroll = true;
               this.BorderStyle = Mobilize.Web.BorderStyle.StyleLowered;
               this.dwnitemchange = new Mobilize.Web.DataManagerItemChangedEventHandler(ItemChanged);
               this.constructor = new Mobilize.Web.ConstructorEventHandler(Constructor);
               this.reloadremovedataEventHandler = this.reloadremovedata;
               this.resetdataEventHandler = this.resetdata;
            }

         }

      }

      public partial class tabpage_search_type
         : Mobilize.Web.UserObject, Itb_tabbaseInner.Itabpage_search_type
      {

         public tabpage_search_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new tb_tabbase Parent => (tb_tabbase)base.Parent;

         public virtual void dosearch()
         {
            this.Parent.dosearch();
         }

         [Mobilize.WebMap.Common.Attributes.Intercepted]
         public Itb_tabbaseInner.Itabpage_search_typeInner.Idw_search_type dw_search { get; set; }

         public Mobilize.Web.VoidEventHandler CreateEventHandler { get; set; }

         public Mobilize.Web.VoidEventHandler DestroyEventHandler { get; set; }

         public Mobilize.Web.VoidEventHandler dosearchEventHandler { get; set; }

         public override void Create()
         {
            this.dw_search = CreateInnerControl_dw_search_type();
            this.Control = Mobilize.Web.ArrayExtensions.Clone<Mobilize.Web.IControl>(new Mobilize.Web.IControl[] { this.dw_search });
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 18;
            this.Y = 112;
            this.Width = 2551;
            this.Height = 880;
            this.BackColor = 67108864;
            this.Text = "Search";
            this.TabTextColor = 33554432;
            this.PictureMaskColor = 536870912;
            this.dosearchEventHandler = this.dosearch;
         }

         protected virtual Itb_tabbaseInner.Itabpage_search_typeInner.Idw_search_type CreateInnerControl_dw_search_type()
         {
            return Mobilize.Web.Application.Create<Itb_tabbaseInner.Itabpage_search_typeInner.Idw_search_type>(this);
         }

         public class dw_search_type
            : basecomponents.dw_basedw, Itb_tabbaseInner.Itabpage_search_typeInner.Idw_search_type
         {

            public dw_search_type(Mobilize.Web.BaseControl parent)
            : base(parent)
            {
            }

            private new tb_tabbase.tabpage_search_type Parent => (tb_tabbase.tabpage_search_type)base.Parent;

            public virtual short? ButtonClicked(int? row, int? actionreturncode, Mobilize.Web.IDmControl dwo)
            {
               short? AncestorReturnValue = null;
               this.Parent.dosearch();
               return null;
            }

            public override void DoWmInit()
            {
               base.DoWmInit();
               this.X = 27;
               this.Y = 48;
               this.Width = 2501;
               this.Height = 796;
               this.TabOrder = 10;
               this.DataObject = "d_searchprescription";
               this.dwnbuttonclicked = new Mobilize.Web.ButtonClickedEventHandler(ButtonClicked);
            }

         }

      }

   }

}