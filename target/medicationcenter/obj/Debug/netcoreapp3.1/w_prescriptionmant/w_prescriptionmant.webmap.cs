#pragma warning disable
#line 1 "w_prescriptionmant\\w_prescriptionmant.cs"
#pragma warning disable
#line 1 "w_prescriptionmant\\w_prescriptionmant.cs"
namespace medicationcenter
{

   [Mobilize.WebMap.Common.Attributes.Observable]
   public partial class w_prescriptionmant
      : medicationcenter.w_tabbase, medicationcenter.Iw_prescriptionmant
   {

      public override void DoWmInit()
      {
         base.DoWmInit();
         dirtyadd = false;
         dirtyremove = false;
         this.open = new Mobilize.Web.OpenWindowEventHandler(OpenWindow);
         ;
         this.savedataEventHandler = this.savedata;
      }

      public override void Create()
      {
         short? iCurrent = 0;
         base.Create();
         if ( Mobilize.Web.Comparison.Equals(this.MenuName, "m_adminmaint") == true )
         {
            this.MenuID = Mobilize.Web.Application.Create<medicationcenter.Im_adminmaint>(this);
         }
         this.uo_1 = CreateInnerControl_uo_1_type();
         iCurrent = (short?)this.Control.GetUpperBound();
         this.Control[iCurrent + 1] = this.uo_1;
      }

      public override void Destroy()
      {
         base.Destroy();
         if ( Mobilize.Web.BuiltInExtensions.IsValid(this.MenuID) == true )
         {
            this.MenuID = null;
         }
         this.uo_1 = null;
      }

      public virtual void saveadd()
      {
         short? upper = 0;
         short? result = 0;
         Mobilize.Web.IDataManagerControl dwadd = Mobilize.Web.Application.Default<Mobilize.Web.IDataManagerControl>();
         dwadd = this.tab_1.tabpage_add.dw_add;
         result = dwadd.AcceptText();
         if ( (Mobilize.Web.Comparison.Equals(result, 1) & this.isvalidadddata(0, Mobilize.Web.TypeConversion.Integer(dwadd.GetItemNumber(1, "patient")), Mobilize.Web.TypeConversion.Integer(dwadd.GetItemNumber(1, "medicine")), dwadd.GetItemDecimal(1, "dose"))) == true )
         {
            upper = (short?)(((Mobilize.Web.IArray<models.Istr_prescription>)(Mobilize.Web.Application.CurrentApplication.Variables.prescritions<Mobilize.Web.IArray<models.Istr_prescription>>())).GetUpperBound() + 1);
            ((Mobilize.Web.IArray<models.Istr_prescription>)(Mobilize.Web.Application.CurrentApplication.Variables.prescritions<Mobilize.Web.IArray<models.Istr_prescription>>()))[upper].iid = getnextprescription();
            ((Mobilize.Web.IArray<models.Istr_prescription>)(Mobilize.Web.Application.CurrentApplication.Variables.prescritions<Mobilize.Web.IArray<models.Istr_prescription>>()))[upper].patient = Mobilize.Web.TypeConversion.Integer(dwadd.GetItemNumber(1, "patient"));
            ((Mobilize.Web.IArray<models.Istr_prescription>)(Mobilize.Web.Application.CurrentApplication.Variables.prescritions<Mobilize.Web.IArray<models.Istr_prescription>>()))[upper].medicine = Mobilize.Web.TypeConversion.Integer(dwadd.GetItemNumber(1, "medicine"));
            ((Mobilize.Web.IArray<models.Istr_prescription>)(Mobilize.Web.Application.CurrentApplication.Variables.prescritions<Mobilize.Web.IArray<models.Istr_prescription>>()))[upper].dose = dwadd.GetItemDecimal(1, "dose");
            ((Mobilize.Web.IArray<models.Istr_prescription>)(Mobilize.Web.Application.CurrentApplication.Variables.prescritions<Mobilize.Web.IArray<models.Istr_prescription>>()))[upper].socialsecurity = dwadd.GetItemString(1, "socialsecurity");
            ((Mobilize.Web.IArray<models.Istr_prescription>)(Mobilize.Web.Application.CurrentApplication.Variables.prescritions<Mobilize.Web.IArray<models.Istr_prescription>>()))[upper].state = 1;
         }
         else
         {
            Mobilize.Web.MessageBox.Show("Invalid Data", "Invalid Data");
         }
         this.dirtyadd = false;
         this.tab_1.tabpage_add.dw_add.TriggerEvent("resetdata");
      }

      public virtual void saveremove()
      {
         short? result = 0, _id = 0;
         Mobilize.Web.IDataManagerControl dwremove = Mobilize.Web.Application.Default<Mobilize.Web.IDataManagerControl>();
         this.dirtyremove = false;
         dwremove = this.tab_1.tabpage_remove.dw_remove;
         result = dwremove.AcceptText();
         _id = Mobilize.Web.TypeConversion.Integer(dwremove.GetItemNumber(1, "iid"));
         if ( !Mobilize.Web.BuiltInExtensions.IsNull(_id) == true )
         {
            basecomponents.basecomponentsGlobalFunctions.setprescriptionstate(_id, (short?)(-1));
         }
         this.tab_1.tabpage_remove.dw_remove.resetdata();
      }

      public virtual bool? isvalidadddata(short? _id, short? patient, short? medicine, decimal? dose)
      {
         return !(Mobilize.Web.BuiltInExtensions.IsNull(_id) | Mobilize.Web.BuiltInExtensions.IsNull(patient) | Mobilize.Web.BuiltInExtensions.IsNull(medicine) | Mobilize.Web.Comparison.Equals(medicine, -1) | Mobilize.Web.Comparison.Equals(patient, -1));
      }

      public virtual short? getnextprescription()
      {
         return (short?)((Mobilize.Web.IArray<models.Istr_prescription>)(Mobilize.Web.Application.CurrentApplication.Variables.prescritions<Mobilize.Web.IArray<models.Istr_prescription>>())).GetUpperBound();
      }

      public override int? OpenWindow()
      {
         int? AncestorReturnValue = null;
         AncestorReturnValue = base.OpenWindow();
         this.Width = 3297;
         this.Height = 2100;
         this.tab_1.SelectedTab = Mobilize.Web.TypeConversion.Integer(((Mobilize.Web.IMessage)(Mobilize.Web.Application.CurrentApplication.Variables.message<Mobilize.Web.IMessage>())).DoubleParm);
         if ( !(bool?)(Mobilize.Web.Application.CurrentApplication.Variables.isAdmin<bool?>()) == true )
         {
            this.tab_1.tabpage_add.Visible = false;
            this.tab_1.tabpage_remove.Visible = false;
         }
         return null;
      }

      public override void ev_loadcontent()
      {
         base.ev_loadcontent();
         this.tab_1.tabpage_add.dw_add.InsertRow(0);
         this.tab_1.tabpage_remove.dw_remove.InsertRow(0);
         this.tab_1.tabpage_search.dw_search.InsertRow(0);
         this.tab_1.tabpage_add.dw_add.SetItem(1, "medicine", -1);
         this.tab_1.tabpage_add.dw_add.SetItem(1, "patient", -1);
         this.tab_1.tabpage_search.dw_search.SetItem(1, "searchby", 1);
      }

      public virtual void savedata()
      {
         if ( (this.dirtyadd) == true )
         {
            saveadd();
         }
         if ( (this.dirtyremove) == true )
         {
            saveremove();
         }
         this.uo_1.dw_all.updatedata();
         this.tab_1.tabpage_remove.dw_remove.reloadremovedata();
      }

      protected virtual Iw_prescriptionmantInner.Iuo_1_type CreateInnerControl_uo_1_type()
      {
         return Mobilize.Web.Application.Create<Iw_prescriptionmantInner.Iuo_1_type>(this);
      }

      protected override medicationcenter.Iw_tabbaseInner.Itab_1_type CreateInnerControl_tab_1_type()
      {
         return Mobilize.Web.Application.Create<Iw_prescriptionmantInner.Itab_1_type>(this);
      }

      public partial class uo_1_type
         : medicationcenter.ou_showallprescriptions, Iw_prescriptionmantInner.Iuo_1_type
      {

         public uo_1_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_prescriptionmant Parent => (w_prescriptionmant)base.Parent;

         public Mobilize.Web.VoidEventHandler DestroyEventHandler { get; set; }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 9;
            this.Y = 1080;
            this.Width = 3013;
            this.Height = 840;
            this.TabOrder = 30;
            this.BringToTop = true;
         }

      }

      public partial class tab_1_type
         : medicationcenter.w_tabbase.tab_1_type, Iw_prescriptionmantInner.Itab_1_type
      {

         public tab_1_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_prescriptionmant Parent => (w_prescriptionmant)base.Parent;

         public override void adddirty()
         {
            base.adddirty();
            this.Parent.dirtyadd = true;
         }

         public override void removedirty()
         {
            base.removedirty();
            this.Parent.dirtyremove = true;
         }

         public override void dosearch()
         {
            short? patientId = 0;
            short? medicationId = 0;
            short? offset = 0;
            short? searchCriteria = 0, i = 0, upperpresc = 0;
            Mobilize.Web.IDataManagerControl dw = Mobilize.Web.Application.Default<Mobilize.Web.IDataManagerControl>(), dwresults = Mobilize.Web.Application.Default<Mobilize.Web.IDataManagerControl>();
            string patient = "", medication = "";
            bool? isValid = false;
            Mobilize.Web.IArray<models.Istr_prescription> results = new Mobilize.Web.DynamicArray<models.Istr_prescription>();
            base.dosearch();
            isValid = true;
            dw = this.tabpage_search.dw_search;
            dw.AcceptText();
            patient = dw.GetItemString(1, "patient");
            medication = dw.GetItemString(1, "medication");
            searchCriteria = Mobilize.Web.TypeConversion.Integer(dw.GetItemNumber(1, "searchby"));
            if ( Mobilize.Web.Comparison.Equals(searchCriteria, 1) == true )
            {
               if ( Mobilize.Web.BuiltInExtensions.IsNull(patient) == true )
               {
                  isValid = false;
               }
               else
               {
                  patientId = basecomponents.basecomponentsGlobalFunctions.getpatienid(patient);
                  if ( Mobilize.Web.Comparison.NotEquals(patientId, -1) == true )
                  {
                     for ( i = 1; i <= ((Mobilize.Web.IArray<models.Istr_prescription>)(Mobilize.Web.Application.CurrentApplication.Variables.prescritions<Mobilize.Web.IArray<models.Istr_prescription>>())).GetUpperBound(); ++i )
                     {
                        if ( Mobilize.Web.Comparison.Equals(((Mobilize.Web.IArray<models.Istr_prescription>)(Mobilize.Web.Application.CurrentApplication.Variables.prescritions<Mobilize.Web.IArray<models.Istr_prescription>>()))[i].patient, patientId) == true )
                        {
                           upperpresc = (short?)(results.GetUpperBound() + 1);
                           results[upperpresc] = ((Mobilize.Web.IArray<models.Istr_prescription>)(Mobilize.Web.Application.CurrentApplication.Variables.prescritions<Mobilize.Web.IArray<models.Istr_prescription>>()))[i]?.ByVal();
                        }
                     }
                  }
               }
            }
            else
            {
               if ( Mobilize.Web.BuiltInExtensions.IsNull(medication) == true )
               {
                  isValid = false;
               }
               else
               {
                  medicationId = basecomponents.basecomponentsGlobalFunctions.getmedicationid(medication);
                  if ( Mobilize.Web.Comparison.NotEquals(medicationId, -1) == true )
                  {
                     for ( i = 1; i <= ((Mobilize.Web.IArray<models.Istr_prescription>)(Mobilize.Web.Application.CurrentApplication.Variables.prescritions<Mobilize.Web.IArray<models.Istr_prescription>>())).GetUpperBound(); ++i )
                     {
                        if ( Mobilize.Web.Comparison.Equals(((Mobilize.Web.IArray<models.Istr_prescription>)(Mobilize.Web.Application.CurrentApplication.Variables.prescritions<Mobilize.Web.IArray<models.Istr_prescription>>()))[i].medicine, medicationId) == true )
                        {
                           upperpresc = (short?)(results.GetUpperBound() + 1);
                           results[upperpresc] = ((Mobilize.Web.IArray<models.Istr_prescription>)(Mobilize.Web.Application.CurrentApplication.Variables.prescritions<Mobilize.Web.IArray<models.Istr_prescription>>()))[i]?.ByVal();
                        }
                     }
                  }
               }
            }
            if ( (isValid) == true )
            {
               dwresults = this.Parent.uo_1.dw_all;
               dwresults.Reset();
               for ( i = 1; i <= results.GetUpperBound(); ++i )
               {
                  if ( Mobilize.Web.Comparison.Equals(((Mobilize.Web.IArray<models.Istr_prescription>)(Mobilize.Web.Application.CurrentApplication.Variables.prescritions<Mobilize.Web.IArray<models.Istr_prescription>>()))[i].state, 1) == true )
                  {
                     dwresults.InsertRow(0);
                     dwresults.SetItem(i - offset, "iid", results[i].iid);
                     dwresults.SetItem(i - offset, "medicine", results[i].medicine);
                     dwresults.SetItem(i - offset, "patient", results[i].patient);
                     dwresults.SetItem(i - offset, "dose", results[i].dose);
                  }
                  else
                  {
                     offset = (short?)(offset + 1);
                  }
               }
            }
            else
            {
               Mobilize.Web.MessageBox.Show("Error", "No data found");
            }
            this.tabpage_search.dw_search.resetdata();
            this.tabpage_search.dw_search.SetItem(1, "searchby", 1);
         }

         public virtual int? SelectionChanged(short? oldindex, short? newindex)
         {
            int? AncestorReturnValue = null;
            string patient = "";
            string medication = "";
            short? i = 0, j = 0;
            if ( Mobilize.Web.Comparison.Equals(newindex, 1) == true )
            {
               this.tabpage_add.dw_add.SetValue("patient", 1, Mobilize.Web.PlusFunctions.Plus(Mobilize.Web.PlusFunctions.Plus("None", "\t"), Mobilize.Web.CaseExtensions.String(-1)));
               this.tabpage_add.dw_add.SetValue("medicine", 1, Mobilize.Web.PlusFunctions.Plus(Mobilize.Web.PlusFunctions.Plus("None", "\t"), Mobilize.Web.CaseExtensions.String(-1)));
               for ( i = 2; i <= ((Mobilize.Web.IArray<models.Istr_patient>)(Mobilize.Web.Application.CurrentApplication.Variables.patients<Mobilize.Web.IArray<models.Istr_patient>>())).GetUpperBound() + 1; ++i )
               {
                  patient = Mobilize.Web.PlusFunctions.Plus(Mobilize.Web.PlusFunctions.Plus(Mobilize.Web.PlusFunctions.Plus(Mobilize.Web.PlusFunctions.Plus(((Mobilize.Web.IArray<models.Istr_patient>)(Mobilize.Web.Application.CurrentApplication.Variables.patients<Mobilize.Web.IArray<models.Istr_patient>>()))[i - 1].firstname, " "), ((Mobilize.Web.IArray<models.Istr_patient>)(Mobilize.Web.Application.CurrentApplication.Variables.patients<Mobilize.Web.IArray<models.Istr_patient>>()))[i - 1].lastname), "\t"), Mobilize.Web.CaseExtensions.String(((Mobilize.Web.IArray<models.Istr_patient>)(Mobilize.Web.Application.CurrentApplication.Variables.patients<Mobilize.Web.IArray<models.Istr_patient>>()))[i - 1].iid));
                  this.tabpage_add.dw_add.SetValue("patient", i, patient);
               }
               for ( j = 2; j <= ((Mobilize.Web.IArray<models.Iatr_medicine>)(Mobilize.Web.Application.CurrentApplication.Variables.medications<Mobilize.Web.IArray<models.Iatr_medicine>>())).GetUpperBound() + 1; ++j )
               {
                  medication = Mobilize.Web.PlusFunctions.Plus(Mobilize.Web.PlusFunctions.Plus(Mobilize.Web.CaseExtensions.String(((Mobilize.Web.IArray<models.Iatr_medicine>)(Mobilize.Web.Application.CurrentApplication.Variables.medications<Mobilize.Web.IArray<models.Iatr_medicine>>()))[j - 1].sname), "\t"), Mobilize.Web.CaseExtensions.String(((Mobilize.Web.IArray<models.Iatr_medicine>)(Mobilize.Web.Application.CurrentApplication.Variables.medications<Mobilize.Web.IArray<models.Iatr_medicine>>()))[j - 1].iid));
                  this.tabpage_add.dw_add.SetValue("medicine", j, medication);
               }
            }
            this.Parent.uo_1.dw_all.loaddata();
            return null;
         }

         public Mobilize.Web.VoidEventHandler ev_loadcontentEventHandler { get; set; }

         public virtual void ev_loadcontent()
         {
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 41;
            this.Y = 52;
            this.Width = 2606;
            this.Height = 1032;
            this.adddirtyEventHandler = this.adddirty;
            this.removedirtyEventHandler = this.removedirty;
            this.dosearchEventHandler = this.dosearch;
            this.tcnselchanged = new Mobilize.Web.TabSelectionChangEventHandler(SelectionChanged);
            this.ev_loadcontentEventHandler = this.ev_loadcontent;
         }

      }

   }

}
#pragma warning restore
