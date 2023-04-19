namespace multicontroldemo
{

   public interface Idw_allcontrols_two
      : Mobilize.Web.IDataManager
   {

      Mobilize.Web.DmColumn prospect { get; set; }

      Mobilize.Web.DmText password_t { get; set; }

      Mobilize.Web.DmText department_t { get; set; }

      Mobilize.Web.DmText full_name_t { get; set; }

      Mobilize.Web.DmColumn full_name { get; set; }

      Mobilize.Web.DmColumn password { get; set; }

      Mobilize.Web.DmColumn department { get; set; }

      Mobilize.Web.DmColumn domain { get; set; }

      Mobilize.Web.DmText code_t { get; set; }

      Mobilize.Web.DmColumn code { get; set; }

      Mobilize.Web.DmCompute compute_full_info { get; set; }

      Mobilize.Web.DmText revenuew_t { get; set; }

      Mobilize.Web.DmColumn logo { get; set; }

      Mobilize.Web.DmText last_meeting_t { get; set; }

      Mobilize.Web.DmColumn revenuew { get; set; }

      Mobilize.Web.DmColumn last_meeting { get; set; }

   }

}