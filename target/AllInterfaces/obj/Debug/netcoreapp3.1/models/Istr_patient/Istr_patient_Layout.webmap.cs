#pragma warning disable
#line 1 "models\\Istr_patient\\Istr_patient_Layout.cs"
#pragma warning disable
#line 1 "models\\Istr_patient\\Istr_patient_Layout.cs"
namespace models
{

   public interface Istr_patient
      : Mobilize.Web.IBaseStructure
   {

      string firstname { get; set; }

      string lastname { get; set; }

      short? age { get; set; }

      short? iid { get; set; }

      Istr_patient ByVal();

   }

}
#pragma warning restore
