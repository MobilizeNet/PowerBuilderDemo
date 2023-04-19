namespace medicationcenter
{

   [Mobilize.WebMap.Common.Attributes.Observable]
   public partial class dw_showallprescriptions
      : basecomponents.dw_showallbase, medicationcenter.Idw_showallprescriptions
   {

      public override void Create()
      {
         base.Create();
      }

      public override void Destroy()
      {
         base.Destroy();
      }

      public virtual void loaddata()
      {
         short? i = 0, offset = 0;
         this.Reset();
         for ( i = 1; i <= ((Mobilize.Web.IArray<models.Istr_prescription>)(Mobilize.Web.Application.CurrentApplication.Variables.prescritions<Mobilize.Web.IArray<models.Istr_prescription>>())).GetUpperBound(); ++i )
         {
            if ( Mobilize.Web.Comparison.Equals(((Mobilize.Web.IArray<models.Istr_prescription>)(Mobilize.Web.Application.CurrentApplication.Variables.prescritions<Mobilize.Web.IArray<models.Istr_prescription>>()))[i].state, 1) == true )
            {
               this.InsertRow(0);
               this.SetItem(i - offset, "iid", ((Mobilize.Web.IArray<models.Istr_prescription>)(Mobilize.Web.Application.CurrentApplication.Variables.prescritions<Mobilize.Web.IArray<models.Istr_prescription>>()))[i].iid);
               this.SetItem(i - offset, "medicine", ((Mobilize.Web.IArray<models.Istr_prescription>)(Mobilize.Web.Application.CurrentApplication.Variables.prescritions<Mobilize.Web.IArray<models.Istr_prescription>>()))[i].medicine);
               this.SetItem(i - offset, "patient", ((Mobilize.Web.IArray<models.Istr_prescription>)(Mobilize.Web.Application.CurrentApplication.Variables.prescritions<Mobilize.Web.IArray<models.Istr_prescription>>()))[i].patient);
               this.SetItem(i - offset, "dose", ((Mobilize.Web.IArray<models.Istr_prescription>)(Mobilize.Web.Application.CurrentApplication.Variables.prescritions<Mobilize.Web.IArray<models.Istr_prescription>>()))[i].dose);
               this.SetItem(i - offset, "socialsecurity", ((Mobilize.Web.IArray<models.Istr_prescription>)(Mobilize.Web.Application.CurrentApplication.Variables.prescritions<Mobilize.Web.IArray<models.Istr_prescription>>()))[i].socialsecurity);
            }
            else
            {
               offset = (short?)(offset + 1);
            }
         }
      }

      public virtual void loadmedicines()
      {
         short? i = 0;
         for ( i = 1; i <= ((Mobilize.Web.IArray<models.Iatr_medicine>)(Mobilize.Web.Application.CurrentApplication.Variables.medications<Mobilize.Web.IArray<models.Iatr_medicine>>())).GetUpperBound(); ++i )
         {
            this.SetValue("medicine", i, Mobilize.Web.PlusFunctions.Plus(Mobilize.Web.PlusFunctions.Plus(Mobilize.Web.CaseExtensions.String(((Mobilize.Web.IArray<models.Iatr_medicine>)(Mobilize.Web.Application.CurrentApplication.Variables.medications<Mobilize.Web.IArray<models.Iatr_medicine>>()))[i].sname), "\t"), Mobilize.Web.CaseExtensions.String(((Mobilize.Web.IArray<models.Iatr_medicine>)(Mobilize.Web.Application.CurrentApplication.Variables.medications<Mobilize.Web.IArray<models.Iatr_medicine>>()))[i].iid)));
         }
      }

      public virtual void loadpatients()
      {
         short? i = 0;
         for ( i = 1; i <= ((Mobilize.Web.IArray<models.Istr_patient>)(Mobilize.Web.Application.CurrentApplication.Variables.patients<Mobilize.Web.IArray<models.Istr_patient>>())).GetUpperBound(); ++i )
         {
            this.SetValue("patient", i, Mobilize.Web.PlusFunctions.Plus(Mobilize.Web.PlusFunctions.Plus(Mobilize.Web.PlusFunctions.Plus(Mobilize.Web.PlusFunctions.Plus(((Mobilize.Web.IArray<models.Istr_patient>)(Mobilize.Web.Application.CurrentApplication.Variables.patients<Mobilize.Web.IArray<models.Istr_patient>>()))[i].firstname, " "), ((Mobilize.Web.IArray<models.Istr_patient>)(Mobilize.Web.Application.CurrentApplication.Variables.patients<Mobilize.Web.IArray<models.Istr_patient>>()))[i].lastname), "\t"), Mobilize.Web.CaseExtensions.String(((Mobilize.Web.IArray<models.Istr_patient>)(Mobilize.Web.Application.CurrentApplication.Variables.patients<Mobilize.Web.IArray<models.Istr_patient>>()))[i].iid)));
         }
      }

      public override void updatedata()
      {
         short? i = 0;
         base.updatedata();
         this.Reset();
         this.loadmedicines();
         this.loadpatients();
         this.loaddata();
      }

      public override void DoWmInit()
      {
         base.DoWmInit();
         ;
      }

   }

}