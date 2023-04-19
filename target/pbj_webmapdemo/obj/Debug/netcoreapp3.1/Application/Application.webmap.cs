#pragma warning disable
#line 1 "Application\\Application.cs"
#pragma warning disable
#line 1 "Application\\Application.cs"
namespace pbj_webmapdemo
{

   public partial class Application
      : Mobilize.Web.Application, pbj_webmapdemo.IApplication
   {

      public Application(System.IServiceProvider provider)
      : base(provider)
      {
         this.AppName = "pbj_webmapdemo";
      }

      public void DoWmInit()
      {
         this.Variables.isAdmin = false;
         this.Variables.patients<Mobilize.Web.DynamicArray<models.Istr_patient>>();
         this.Variables.prescritions<Mobilize.Web.DynamicArray<models.Istr_prescription>>();
         this.Variables.medications<Mobilize.Web.DynamicArray<models.Iatr_medicine>>();
      }

      public virtual int? OpenWindow(string commandline)
      {
         pbj_webmapdemo.pbj_webmapdemoGlobalFunctions.f_connect();
         loadpatients();
         loadmedicines();
         loadprescriptions();
         Mobilize.Web.BuiltInExtensions.Open(Mobilize.Web.ReferenceExtensions.Ref<Mobilize.Web.IWindow>((Mobilize.Web.IWindow)Mobilize.Web.Application.CurrentApplication.Variables.w_pbj_main<pbj_webmapdemo.Iw_pbj_main>(), (v) => Mobilize.Web.Application.CurrentApplication.Variables.w_pbj_main = (pbj_webmapdemo.Iw_pbj_main)v, () => Mobilize.Web.Application.CurrentApplication.Variables.w_pbj_main<pbj_webmapdemo.Iw_pbj_main>()));
         return null;
      }

      public override void Create()
      {
         this.AppName = "pbj_webmapdemo";
         Mobilize.Web.Application.CurrentApplication.Variables.Message = Mobilize.Web.Application.Create<Mobilize.Web.IMessage>();
         Mobilize.Web.Application.CurrentApplication.Variables.SqlCa = Mobilize.Web.Application.Create<Mobilize.Web.ITransaction>();
         Mobilize.Web.Application.CurrentApplication.Variables.SqlDa = Mobilize.Web.Application.Create<Mobilize.Web.IDynamicDescriptionArea>();
         Mobilize.Web.Application.CurrentApplication.Variables.SqlSa = Mobilize.Web.Application.Create<Mobilize.Web.IDynamicStagingArea>();
         Mobilize.Web.Application.CurrentApplication.Variables.Error = Mobilize.Web.Application.Create<Mobilize.Web.IError>();
      }

      public override void Destroy()
      {
         Mobilize.Web.Application.CurrentApplication.Variables.SqlCa = null;
         Mobilize.Web.Application.CurrentApplication.Variables.SqlDa = null;
         Mobilize.Web.Application.CurrentApplication.Variables.SqlSa = null;
         Mobilize.Web.Application.CurrentApplication.Variables.Error = null;
         Mobilize.Web.Application.CurrentApplication.Variables.Message = null;
      }

      public virtual void loadpatients()
      {
         ((Mobilize.Web.IArray<models.Istr_patient>)(Mobilize.Web.Application.CurrentApplication.Variables.patients<Mobilize.Web.IArray<models.Istr_patient>>()))[1].iid = 1;
         ((Mobilize.Web.IArray<models.Istr_patient>)(Mobilize.Web.Application.CurrentApplication.Variables.patients<Mobilize.Web.IArray<models.Istr_patient>>()))[1].firstname = "Huey";
         ((Mobilize.Web.IArray<models.Istr_patient>)(Mobilize.Web.Application.CurrentApplication.Variables.patients<Mobilize.Web.IArray<models.Istr_patient>>()))[1].lastname = "Duck";
         ((Mobilize.Web.IArray<models.Istr_patient>)(Mobilize.Web.Application.CurrentApplication.Variables.patients<Mobilize.Web.IArray<models.Istr_patient>>()))[1].age = 20;
         ((Mobilize.Web.IArray<models.Istr_patient>)(Mobilize.Web.Application.CurrentApplication.Variables.patients<Mobilize.Web.IArray<models.Istr_patient>>()))[2].iid = 2;
         ((Mobilize.Web.IArray<models.Istr_patient>)(Mobilize.Web.Application.CurrentApplication.Variables.patients<Mobilize.Web.IArray<models.Istr_patient>>()))[2].firstname = "Dewey";
         ((Mobilize.Web.IArray<models.Istr_patient>)(Mobilize.Web.Application.CurrentApplication.Variables.patients<Mobilize.Web.IArray<models.Istr_patient>>()))[2].lastname = "Duck";
         ((Mobilize.Web.IArray<models.Istr_patient>)(Mobilize.Web.Application.CurrentApplication.Variables.patients<Mobilize.Web.IArray<models.Istr_patient>>()))[2].age = 20;
         ((Mobilize.Web.IArray<models.Istr_patient>)(Mobilize.Web.Application.CurrentApplication.Variables.patients<Mobilize.Web.IArray<models.Istr_patient>>()))[3].iid = 3;
         ((Mobilize.Web.IArray<models.Istr_patient>)(Mobilize.Web.Application.CurrentApplication.Variables.patients<Mobilize.Web.IArray<models.Istr_patient>>()))[3].firstname = "Louie";
         ((Mobilize.Web.IArray<models.Istr_patient>)(Mobilize.Web.Application.CurrentApplication.Variables.patients<Mobilize.Web.IArray<models.Istr_patient>>()))[3].lastname = "Duck";
         ((Mobilize.Web.IArray<models.Istr_patient>)(Mobilize.Web.Application.CurrentApplication.Variables.patients<Mobilize.Web.IArray<models.Istr_patient>>()))[3].age = 20;
      }

      public virtual void loadmedicines()
      {
         ((Mobilize.Web.IArray<models.Iatr_medicine>)(Mobilize.Web.Application.CurrentApplication.Variables.medications<Mobilize.Web.IArray<models.Iatr_medicine>>()))[1].iid = 1;
         ((Mobilize.Web.IArray<models.Iatr_medicine>)(Mobilize.Web.Application.CurrentApplication.Variables.medications<Mobilize.Web.IArray<models.Iatr_medicine>>()))[1].sname = "Vyndaqel";
         ((Mobilize.Web.IArray<models.Iatr_medicine>)(Mobilize.Web.Application.CurrentApplication.Variables.medications<Mobilize.Web.IArray<models.Iatr_medicine>>()))[2].iid = 2;
         ((Mobilize.Web.IArray<models.Iatr_medicine>)(Mobilize.Web.Application.CurrentApplication.Variables.medications<Mobilize.Web.IArray<models.Iatr_medicine>>()))[2].sname = "Duobrii";
         ((Mobilize.Web.IArray<models.Iatr_medicine>)(Mobilize.Web.Application.CurrentApplication.Variables.medications<Mobilize.Web.IArray<models.Iatr_medicine>>()))[3].iid = 3;
         ((Mobilize.Web.IArray<models.Iatr_medicine>)(Mobilize.Web.Application.CurrentApplication.Variables.medications<Mobilize.Web.IArray<models.Iatr_medicine>>()))[3].sname = "Jeuveau";
         ((Mobilize.Web.IArray<models.Iatr_medicine>)(Mobilize.Web.Application.CurrentApplication.Variables.medications<Mobilize.Web.IArray<models.Iatr_medicine>>()))[4].iid = 4;
         ((Mobilize.Web.IArray<models.Iatr_medicine>)(Mobilize.Web.Application.CurrentApplication.Variables.medications<Mobilize.Web.IArray<models.Iatr_medicine>>()))[4].sname = "Jatenzo";
         ((Mobilize.Web.IArray<models.Iatr_medicine>)(Mobilize.Web.Application.CurrentApplication.Variables.medications<Mobilize.Web.IArray<models.Iatr_medicine>>()))[5].iid = 5;
         ((Mobilize.Web.IArray<models.Iatr_medicine>)(Mobilize.Web.Application.CurrentApplication.Variables.medications<Mobilize.Web.IArray<models.Iatr_medicine>>()))[5].sname = "Tosymra";
         ((Mobilize.Web.IArray<models.Iatr_medicine>)(Mobilize.Web.Application.CurrentApplication.Variables.medications<Mobilize.Web.IArray<models.Iatr_medicine>>()))[6].iid = 6;
         ((Mobilize.Web.IArray<models.Iatr_medicine>)(Mobilize.Web.Application.CurrentApplication.Variables.medications<Mobilize.Web.IArray<models.Iatr_medicine>>()))[6].sname = "Paracetamol";
      }

      public virtual void loadprescriptions()
      {
         ((Mobilize.Web.IArray<models.Istr_prescription>)(Mobilize.Web.Application.CurrentApplication.Variables.prescritions<Mobilize.Web.IArray<models.Istr_prescription>>()))[1].iid = 1;
         ((Mobilize.Web.IArray<models.Istr_prescription>)(Mobilize.Web.Application.CurrentApplication.Variables.prescritions<Mobilize.Web.IArray<models.Istr_prescription>>()))[1].medicine = 1;
         ((Mobilize.Web.IArray<models.Istr_prescription>)(Mobilize.Web.Application.CurrentApplication.Variables.prescritions<Mobilize.Web.IArray<models.Istr_prescription>>()))[1].patient = 1;
         ((Mobilize.Web.IArray<models.Istr_prescription>)(Mobilize.Web.Application.CurrentApplication.Variables.prescritions<Mobilize.Web.IArray<models.Istr_prescription>>()))[1].dose = (decimal?)0.25M;
         ((Mobilize.Web.IArray<models.Istr_prescription>)(Mobilize.Web.Application.CurrentApplication.Variables.prescritions<Mobilize.Web.IArray<models.Istr_prescription>>()))[1].state = 1;
         ((Mobilize.Web.IArray<models.Istr_prescription>)(Mobilize.Web.Application.CurrentApplication.Variables.prescritions<Mobilize.Web.IArray<models.Istr_prescription>>()))[1].socialsecurity = "123121234";
         ((Mobilize.Web.IArray<models.Istr_prescription>)(Mobilize.Web.Application.CurrentApplication.Variables.prescritions<Mobilize.Web.IArray<models.Istr_prescription>>()))[2].iid = 2;
         ((Mobilize.Web.IArray<models.Istr_prescription>)(Mobilize.Web.Application.CurrentApplication.Variables.prescritions<Mobilize.Web.IArray<models.Istr_prescription>>()))[2].medicine = 1;
         ((Mobilize.Web.IArray<models.Istr_prescription>)(Mobilize.Web.Application.CurrentApplication.Variables.prescritions<Mobilize.Web.IArray<models.Istr_prescription>>()))[2].patient = 2;
         ((Mobilize.Web.IArray<models.Istr_prescription>)(Mobilize.Web.Application.CurrentApplication.Variables.prescritions<Mobilize.Web.IArray<models.Istr_prescription>>()))[2].dose = (decimal?)0.75M;
         ((Mobilize.Web.IArray<models.Istr_prescription>)(Mobilize.Web.Application.CurrentApplication.Variables.prescritions<Mobilize.Web.IArray<models.Istr_prescription>>()))[2].state = 1;
         ((Mobilize.Web.IArray<models.Istr_prescription>)(Mobilize.Web.Application.CurrentApplication.Variables.prescritions<Mobilize.Web.IArray<models.Istr_prescription>>()))[2].socialsecurity = "987871345";
         ((Mobilize.Web.IArray<models.Istr_prescription>)(Mobilize.Web.Application.CurrentApplication.Variables.prescritions<Mobilize.Web.IArray<models.Istr_prescription>>()))[3].iid = 3;
         ((Mobilize.Web.IArray<models.Istr_prescription>)(Mobilize.Web.Application.CurrentApplication.Variables.prescritions<Mobilize.Web.IArray<models.Istr_prescription>>()))[3].medicine = 6;
         ((Mobilize.Web.IArray<models.Istr_prescription>)(Mobilize.Web.Application.CurrentApplication.Variables.prescritions<Mobilize.Web.IArray<models.Istr_prescription>>()))[3].patient = 2;
         ((Mobilize.Web.IArray<models.Istr_prescription>)(Mobilize.Web.Application.CurrentApplication.Variables.prescritions<Mobilize.Web.IArray<models.Istr_prescription>>()))[3].dose = 1;
         ((Mobilize.Web.IArray<models.Istr_prescription>)(Mobilize.Web.Application.CurrentApplication.Variables.prescritions<Mobilize.Web.IArray<models.Istr_prescription>>()))[3].state = 1;
         ((Mobilize.Web.IArray<models.Istr_prescription>)(Mobilize.Web.Application.CurrentApplication.Variables.prescritions<Mobilize.Web.IArray<models.Istr_prescription>>()))[3].socialsecurity = "567901265";
         ((Mobilize.Web.IArray<models.Istr_prescription>)(Mobilize.Web.Application.CurrentApplication.Variables.prescritions<Mobilize.Web.IArray<models.Istr_prescription>>()))[4].iid = 4;
         ((Mobilize.Web.IArray<models.Istr_prescription>)(Mobilize.Web.Application.CurrentApplication.Variables.prescritions<Mobilize.Web.IArray<models.Istr_prescription>>()))[4].medicine = 2;
         ((Mobilize.Web.IArray<models.Istr_prescription>)(Mobilize.Web.Application.CurrentApplication.Variables.prescritions<Mobilize.Web.IArray<models.Istr_prescription>>()))[4].patient = 1;
         ((Mobilize.Web.IArray<models.Istr_prescription>)(Mobilize.Web.Application.CurrentApplication.Variables.prescritions<Mobilize.Web.IArray<models.Istr_prescription>>()))[4].dose = 1;
         ((Mobilize.Web.IArray<models.Istr_prescription>)(Mobilize.Web.Application.CurrentApplication.Variables.prescritions<Mobilize.Web.IArray<models.Istr_prescription>>()))[4].state = 1;
         ((Mobilize.Web.IArray<models.Istr_prescription>)(Mobilize.Web.Application.CurrentApplication.Variables.prescritions<Mobilize.Web.IArray<models.Istr_prescription>>()))[4].socialsecurity = "879437856";
         ((Mobilize.Web.IArray<models.Istr_prescription>)(Mobilize.Web.Application.CurrentApplication.Variables.prescritions<Mobilize.Web.IArray<models.Istr_prescription>>()))[5].iid = 5;
         ((Mobilize.Web.IArray<models.Istr_prescription>)(Mobilize.Web.Application.CurrentApplication.Variables.prescritions<Mobilize.Web.IArray<models.Istr_prescription>>()))[5].medicine = 2;
         ((Mobilize.Web.IArray<models.Istr_prescription>)(Mobilize.Web.Application.CurrentApplication.Variables.prescritions<Mobilize.Web.IArray<models.Istr_prescription>>()))[5].patient = 3;
         ((Mobilize.Web.IArray<models.Istr_prescription>)(Mobilize.Web.Application.CurrentApplication.Variables.prescritions<Mobilize.Web.IArray<models.Istr_prescription>>()))[5].dose = (decimal?)0.15M;
         ((Mobilize.Web.IArray<models.Istr_prescription>)(Mobilize.Web.Application.CurrentApplication.Variables.prescritions<Mobilize.Web.IArray<models.Istr_prescription>>()))[5].state = 1;
         ((Mobilize.Web.IArray<models.Istr_prescription>)(Mobilize.Web.Application.CurrentApplication.Variables.prescritions<Mobilize.Web.IArray<models.Istr_prescription>>()))[5].socialsecurity = "456879283";
         ((Mobilize.Web.IArray<models.Istr_prescription>)(Mobilize.Web.Application.CurrentApplication.Variables.prescritions<Mobilize.Web.IArray<models.Istr_prescription>>()))[6].iid = 6;
         ((Mobilize.Web.IArray<models.Istr_prescription>)(Mobilize.Web.Application.CurrentApplication.Variables.prescritions<Mobilize.Web.IArray<models.Istr_prescription>>()))[6].medicine = 2;
         ((Mobilize.Web.IArray<models.Istr_prescription>)(Mobilize.Web.Application.CurrentApplication.Variables.prescritions<Mobilize.Web.IArray<models.Istr_prescription>>()))[6].patient = 2;
         ((Mobilize.Web.IArray<models.Istr_prescription>)(Mobilize.Web.Application.CurrentApplication.Variables.prescritions<Mobilize.Web.IArray<models.Istr_prescription>>()))[6].dose = (decimal?)0.65M;
         ((Mobilize.Web.IArray<models.Istr_prescription>)(Mobilize.Web.Application.CurrentApplication.Variables.prescritions<Mobilize.Web.IArray<models.Istr_prescription>>()))[6].state = 1;
         ((Mobilize.Web.IArray<models.Istr_prescription>)(Mobilize.Web.Application.CurrentApplication.Variables.prescritions<Mobilize.Web.IArray<models.Istr_prescription>>()))[6].socialsecurity = "183932758";
         ((Mobilize.Web.IArray<models.Istr_prescription>)(Mobilize.Web.Application.CurrentApplication.Variables.prescritions<Mobilize.Web.IArray<models.Istr_prescription>>()))[7].iid = 7;
         ((Mobilize.Web.IArray<models.Istr_prescription>)(Mobilize.Web.Application.CurrentApplication.Variables.prescritions<Mobilize.Web.IArray<models.Istr_prescription>>()))[7].medicine = 2;
         ((Mobilize.Web.IArray<models.Istr_prescription>)(Mobilize.Web.Application.CurrentApplication.Variables.prescritions<Mobilize.Web.IArray<models.Istr_prescription>>()))[7].patient = 2;
         ((Mobilize.Web.IArray<models.Istr_prescription>)(Mobilize.Web.Application.CurrentApplication.Variables.prescritions<Mobilize.Web.IArray<models.Istr_prescription>>()))[7].dose = (decimal?)0.85M;
         ((Mobilize.Web.IArray<models.Istr_prescription>)(Mobilize.Web.Application.CurrentApplication.Variables.prescritions<Mobilize.Web.IArray<models.Istr_prescription>>()))[7].state = 1;
         ((Mobilize.Web.IArray<models.Istr_prescription>)(Mobilize.Web.Application.CurrentApplication.Variables.prescritions<Mobilize.Web.IArray<models.Istr_prescription>>()))[7].socialsecurity = "748293847";
         ((Mobilize.Web.IArray<models.Istr_prescription>)(Mobilize.Web.Application.CurrentApplication.Variables.prescritions<Mobilize.Web.IArray<models.Istr_prescription>>()))[8].iid = 8;
         ((Mobilize.Web.IArray<models.Istr_prescription>)(Mobilize.Web.Application.CurrentApplication.Variables.prescritions<Mobilize.Web.IArray<models.Istr_prescription>>()))[8].medicine = 5;
         ((Mobilize.Web.IArray<models.Istr_prescription>)(Mobilize.Web.Application.CurrentApplication.Variables.prescritions<Mobilize.Web.IArray<models.Istr_prescription>>()))[8].patient = 1;
         ((Mobilize.Web.IArray<models.Istr_prescription>)(Mobilize.Web.Application.CurrentApplication.Variables.prescritions<Mobilize.Web.IArray<models.Istr_prescription>>()))[8].dose = (decimal?)0.10M;
         ((Mobilize.Web.IArray<models.Istr_prescription>)(Mobilize.Web.Application.CurrentApplication.Variables.prescritions<Mobilize.Web.IArray<models.Istr_prescription>>()))[8].state = 1;
         ((Mobilize.Web.IArray<models.Istr_prescription>)(Mobilize.Web.Application.CurrentApplication.Variables.prescritions<Mobilize.Web.IArray<models.Istr_prescription>>()))[7].socialsecurity = "283943748";
      }

   }

}
#pragma warning restore
