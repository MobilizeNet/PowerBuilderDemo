namespace medicationcenter
{

   public interface Id_removeprescription
      : Mobilize.Web.IDataManager
   {

      Mobilize.Web.DmLine l_1 { get; set; }

      Mobilize.Web.DmText t_1 { get; set; }

      Mobilize.Web.DmText id_t { get; set; }

      Mobilize.Web.DmColumn iid { get; set; }

   }

}