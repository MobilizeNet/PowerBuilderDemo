namespace multicontroldemo
{

   public interface Id_no_data
      : Mobilize.Web.IDataManager
   {

      Mobilize.Web.DmText field1_t { get; set; }

      Mobilize.Web.DmColumn field1 { get; set; }

      Mobilize.Web.DmText field2_t { get; set; }

      Mobilize.Web.DmColumn field2 { get; set; }

      Mobilize.Web.DmText field3_t { get; set; }

      Mobilize.Web.DmColumn field3 { get; set; }

   }

}