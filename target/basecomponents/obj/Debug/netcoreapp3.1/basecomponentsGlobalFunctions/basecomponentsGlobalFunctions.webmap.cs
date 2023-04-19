#pragma warning disable
#line 1 "basecomponentsGlobalFunctions\\basecomponentsGlobalFunctions.cs"
#pragma warning disable
#line 1 "basecomponentsGlobalFunctions\\basecomponentsGlobalFunctions.cs"
namespace basecomponents
{

   public static partial class basecomponentsGlobalFunctions
   {

      public static short? getmedicationid(string _name)
      {
         short? i = 0;
         for ( i = 1; i <= ((Mobilize.Web.IArray<models.Iatr_medicine>)(Mobilize.Web.Application.CurrentApplication.Variables.medications<Mobilize.Web.IArray<models.Iatr_medicine>>())).GetUpperBound(); ++i )
         {
            if ( Mobilize.Web.Comparison.Equals(((Mobilize.Web.IArray<models.Iatr_medicine>)(Mobilize.Web.Application.CurrentApplication.Variables.medications<Mobilize.Web.IArray<models.Iatr_medicine>>()))[i].sname, _name) == true )
            {
               return ((Mobilize.Web.IArray<models.Iatr_medicine>)(Mobilize.Web.Application.CurrentApplication.Variables.medications<Mobilize.Web.IArray<models.Iatr_medicine>>()))[i].iid;
            }
         }
         return (short?)(-1);
      }

      public static string getmedicinebyid(short? _id)
      {
         short? i = 0;
         for ( i = 1; i <= ((Mobilize.Web.IArray<models.Iatr_medicine>)(Mobilize.Web.Application.CurrentApplication.Variables.medications<Mobilize.Web.IArray<models.Iatr_medicine>>())).GetUpperBound(); ++i )
         {
            if ( Mobilize.Web.Comparison.Equals(((Mobilize.Web.IArray<models.Iatr_medicine>)(Mobilize.Web.Application.CurrentApplication.Variables.medications<Mobilize.Web.IArray<models.Iatr_medicine>>()))[i].iid, _id) == true )
            {
               return ((Mobilize.Web.IArray<models.Iatr_medicine>)(Mobilize.Web.Application.CurrentApplication.Variables.medications<Mobilize.Web.IArray<models.Iatr_medicine>>()))[i].sname;
            }
         }
         return "";
      }

      public static string getpatienbyid(short? _id)
      {
         short? i = 0;
         for ( i = 1; i <= ((Mobilize.Web.IArray<models.Istr_patient>)(Mobilize.Web.Application.CurrentApplication.Variables.patients<Mobilize.Web.IArray<models.Istr_patient>>())).GetUpperBound(); ++i )
         {
            if ( Mobilize.Web.Comparison.Equals(((Mobilize.Web.IArray<models.Istr_patient>)(Mobilize.Web.Application.CurrentApplication.Variables.patients<Mobilize.Web.IArray<models.Istr_patient>>()))[i].iid, _id) == true )
            {
               return Mobilize.Web.PlusFunctions.Plus(Mobilize.Web.PlusFunctions.Plus(((Mobilize.Web.IArray<models.Istr_patient>)(Mobilize.Web.Application.CurrentApplication.Variables.patients<Mobilize.Web.IArray<models.Istr_patient>>()))[i].firstname, " "), ((Mobilize.Web.IArray<models.Istr_patient>)(Mobilize.Web.Application.CurrentApplication.Variables.patients<Mobilize.Web.IArray<models.Istr_patient>>()))[i].lastname);
            }
         }
         return "";
      }

      public static short? getpatienid(string _name)
      {
         short? i = 0;
         for ( i = 1; i <= ((Mobilize.Web.IArray<models.Istr_patient>)(Mobilize.Web.Application.CurrentApplication.Variables.patients<Mobilize.Web.IArray<models.Istr_patient>>())).GetUpperBound(); ++i )
         {
            if ( Mobilize.Web.Comparison.Equals(Mobilize.Web.PlusFunctions.Plus(Mobilize.Web.PlusFunctions.Plus(((Mobilize.Web.IArray<models.Istr_patient>)(Mobilize.Web.Application.CurrentApplication.Variables.patients<Mobilize.Web.IArray<models.Istr_patient>>()))[i].firstname, " "), ((Mobilize.Web.IArray<models.Istr_patient>)(Mobilize.Web.Application.CurrentApplication.Variables.patients<Mobilize.Web.IArray<models.Istr_patient>>()))[i].lastname), _name) == true )
            {
               return ((Mobilize.Web.IArray<models.Istr_patient>)(Mobilize.Web.Application.CurrentApplication.Variables.patients<Mobilize.Web.IArray<models.Istr_patient>>()))[i].iid;
            }
         }
         return (short?)(-1);
      }

      public static models.Istr_prescription getprescriptionbyid(short? _id)
      {
         short? i = 0;
         models.Istr_prescription defaultresult = Mobilize.Web.Application.Create<models.Istr_prescription>();
         for ( i = 1; i <= ((Mobilize.Web.IArray<models.Istr_prescription>)(Mobilize.Web.Application.CurrentApplication.Variables.prescritions<Mobilize.Web.IArray<models.Istr_prescription>>())).GetUpperBound(); ++i )
         {
            if ( Mobilize.Web.Comparison.Equals(((Mobilize.Web.IArray<models.Istr_prescription>)(Mobilize.Web.Application.CurrentApplication.Variables.prescritions<Mobilize.Web.IArray<models.Istr_prescription>>()))[i].iid, _id) == true )
            {
               return ((Mobilize.Web.IArray<models.Istr_prescription>)(Mobilize.Web.Application.CurrentApplication.Variables.prescritions<Mobilize.Web.IArray<models.Istr_prescription>>()))[i];
            }
         }
         return defaultresult;
      }

      public static void setprescriptionstate(short? _id, short? state)
      {
         short? i = 0;
         for ( i = 1; i <= ((Mobilize.Web.IArray<models.Istr_prescription>)(Mobilize.Web.Application.CurrentApplication.Variables.prescritions<Mobilize.Web.IArray<models.Istr_prescription>>())).GetUpperBound(); ++i )
         {
            if ( Mobilize.Web.Comparison.Equals(((Mobilize.Web.IArray<models.Istr_prescription>)(Mobilize.Web.Application.CurrentApplication.Variables.prescritions<Mobilize.Web.IArray<models.Istr_prescription>>()))[i].iid, _id) == true )
            {
               ((Mobilize.Web.IArray<models.Istr_prescription>)(Mobilize.Web.Application.CurrentApplication.Variables.prescritions<Mobilize.Web.IArray<models.Istr_prescription>>()))[i].state = state;
            }
         }
      }

   }

}
#pragma warning restore
