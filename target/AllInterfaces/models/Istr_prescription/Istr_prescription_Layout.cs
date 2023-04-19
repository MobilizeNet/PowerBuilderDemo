namespace models
{

   public interface Istr_prescription
      : Mobilize.Web.IBaseStructure
   {

      decimal? dose { get; set; }

      short? iid { get; set; }

      short? medicine { get; set; }

      short? patient { get; set; }

      short? state { get; set; }

      string socialsecurity { get; set; }

      Istr_prescription ByVal();

   }

}