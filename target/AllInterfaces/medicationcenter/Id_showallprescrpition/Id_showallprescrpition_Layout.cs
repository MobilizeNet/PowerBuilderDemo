namespace medicationcenter
{

   public interface Id_showallprescrpition
      : Mobilize.Web.IDataManager
   {

      Mobilize.Web.DmText id_t { get; set; }

      Mobilize.Web.DmText medicine_t { get; set; }

      Mobilize.Web.DmText patient_t { get; set; }

      Mobilize.Web.DmText dose_t { get; set; }

      Mobilize.Web.DmText socialsecurity_t { get; set; }

      Mobilize.Web.DmColumn iid { get; set; }

      Mobilize.Web.DmColumn medicine { get; set; }

      Mobilize.Web.DmColumn patient { get; set; }

      Mobilize.Web.DmColumn dose { get; set; }

      Mobilize.Web.DmColumn socialsecurity { get; set; }

      Mobilize.Web.DmText t_1 { get; set; }

      Mobilize.Web.DmCompute compute_1 { get; set; }

   }

}