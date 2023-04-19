namespace multicontroldemo
{

   public interface Id_employee_info_update
      : Mobilize.Web.IDataManager
   {

      Mobilize.Web.DmGroupBox gb_1 { get; set; }

      Mobilize.Web.DmText tname_t { get; set; }

      Mobilize.Web.DmColumn tname { get; set; }

      Mobilize.Web.DmColumn tdescription { get; set; }

      Mobilize.Web.DmText tdepartment_t { get; set; }

      Mobilize.Web.DmColumn tdepartment { get; set; }

      Mobilize.Web.DmText thiredate_t { get; set; }

      Mobilize.Web.DmColumn thiredate { get; set; }

      Mobilize.Web.DmColumn tage { get; set; }

      Mobilize.Web.DmText tage_t { get; set; }

      Mobilize.Web.DmText tsalary_t { get; set; }

      Mobilize.Web.DmColumn tsalary { get; set; }

      Mobilize.Web.DmText tcategory_t { get; set; }

      Mobilize.Web.DmColumn tcategory { get; set; }

      Mobilize.Web.DmText tlastlogin_t { get; set; }

      Mobilize.Web.DmColumn tlastlogin { get; set; }

      Mobilize.Web.DmColumn tregistered { get; set; }

      Mobilize.Web.DmColumn level { get; set; }

      Mobilize.Web.DmText t_1 { get; set; }

   }

}