namespace notifycurrentcontrol
{

   public interface Id_users
      : Mobilize.Web.IDataManager
   {

      Mobilize.Web.DmText id_t { get; set; }

      Mobilize.Web.DmColumn _id { get; set; }

      Mobilize.Web.DmText name_t { get; set; }

      Mobilize.Web.DmColumn _name { get; set; }

      Mobilize.Web.DmText street_t { get; set; }

      Mobilize.Web.DmColumn street { get; set; }

      Mobilize.Web.DmText state_t { get; set; }

      Mobilize.Web.DmColumn state { get; set; }

      Mobilize.Web.DmText address_t { get; set; }

      Mobilize.Web.DmColumn address { get; set; }

      Mobilize.Web.DmText company_t { get; set; }

      Mobilize.Web.DmColumn company { get; set; }

   }

}