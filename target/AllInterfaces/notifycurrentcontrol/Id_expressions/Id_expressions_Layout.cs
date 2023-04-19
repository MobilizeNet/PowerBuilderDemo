namespace notifycurrentcontrol
{

   public interface Id_expressions
      : Mobilize.Web.IDataManager
   {

      Mobilize.Web.DmText id_t { get; set; }

      Mobilize.Web.DmText street_t { get; set; }

      Mobilize.Web.DmText t_1 { get; set; }

      Mobilize.Web.DmColumn _id { get; set; }

      Mobilize.Web.DmColumn street { get; set; }

      Mobilize.Web.DmCompute compute_1 { get; set; }

      Mobilize.Web.DmCompute compute_2 { get; set; }

      Mobilize.Web.DmText t_2 { get; set; }

   }

}