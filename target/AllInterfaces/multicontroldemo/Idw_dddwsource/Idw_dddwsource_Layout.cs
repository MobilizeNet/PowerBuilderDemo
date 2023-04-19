namespace multicontroldemo
{

   public interface Idw_dddwsource
      : Mobilize.Web.IDataManager
   {

      Mobilize.Web.DmText type_value_t { get; set; }

      Mobilize.Web.DmColumn type_name { get; set; }

      Mobilize.Web.DmColumn type_desc { get; set; }

      Mobilize.Web.DmColumn type_value { get; set; }

   }

}