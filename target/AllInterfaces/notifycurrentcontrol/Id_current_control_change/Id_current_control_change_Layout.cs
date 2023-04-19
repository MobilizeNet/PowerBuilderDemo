namespace notifycurrentcontrol
{

   public interface Id_current_control_change
      : Mobilize.Web.IDataManager
   {

      Mobilize.Web.DmText name_t { get; set; }

      Mobilize.Web.DmColumn _name { get; set; }

      Mobilize.Web.DmColumn address { get; set; }

      Mobilize.Web.DmText address_t { get; set; }

   }

}