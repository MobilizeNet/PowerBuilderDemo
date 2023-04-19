namespace models
{

   public interface Iatr_medicine
      : Mobilize.Web.IBaseStructure
   {

      string sname { get; set; }

      short? iid { get; set; }

      Iatr_medicine ByVal();

   }

}