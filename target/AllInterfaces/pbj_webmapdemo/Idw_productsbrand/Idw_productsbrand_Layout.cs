namespace pbj_webmapdemo
{

   public interface Idw_productsbrand
      : Mobilize.Web.IDataManager
   {

      Mobilize.Web.DmText id_t { get; set; }

      Mobilize.Web.DmText name_t { get; set; }

      Mobilize.Web.DmText brandid_t { get; set; }

      Mobilize.Web.DmColumn _id { get; set; }

      Mobilize.Web.DmColumn _name { get; set; }

      Mobilize.Web.DmColumn brandid { get; set; }

   }

}