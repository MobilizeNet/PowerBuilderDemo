namespace reports
{

   public interface Idw_product
      : Mobilize.Web.IDataManager
   {

      Mobilize.Web.DmColumn _name { get; set; }

      Mobilize.Web.DmColumn price { get; set; }

      Mobilize.Web.DmColumn vendor { get; set; }

      Mobilize.Web.DmText t_4 { get; set; }

      Mobilize.Web.DmText t_3 { get; set; }

      Mobilize.Web.DmText t_2 { get; set; }

      Mobilize.Web.DmText t_1 { get; set; }

      Mobilize.Web.DmColumn _id { get; set; }

      Mobilize.Web.DmCompute compute_1 { get; set; }

      Mobilize.Web.DmCompute compute_2 { get; set; }

      Mobilize.Web.DmColumn category { get; set; }

   }

}