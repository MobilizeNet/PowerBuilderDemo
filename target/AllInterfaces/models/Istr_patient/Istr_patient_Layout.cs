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