#pragma warning disable
#line 1 "multicontroldemo\\Idw_allcontrols_one\\Idw_allcontrols_one_Layout.cs"
#pragma warning disable
#line 1 "multicontroldemo\\Idw_allcontrols_one\\Idw_allcontrols_one_Layout.cs"
namespace multicontroldemo
{

   public interface Idw_allcontrols_one
      : Mobilize.Web.IDataManager
   {

      Mobilize.Web.DmText t_name { get; set; }

      Mobilize.Web.DmColumn _name { get; set; }

      Mobilize.Web.DmButton b_change_state { get; set; }

      Mobilize.Web.DmText t_hire_date { get; set; }

      Mobilize.Web.DmText t_schedule { get; set; }

      Mobilize.Web.DmText t_phone { get; set; }

      Mobilize.Web.DmText t_gender { get; set; }

      Mobilize.Web.DmText t_type { get; set; }

      Mobilize.Web.DmText t_social_number { get; set; }

      Mobilize.Web.DmColumn gender { get; set; }

      Mobilize.Web.DmColumn type { get; set; }

      Mobilize.Web.DmCompute compute_percentage { get; set; }

      Mobilize.Web.DmColumn active { get; set; }

      Mobilize.Web.DmColumn account { get; set; }

      Mobilize.Web.DmColumn social_number { get; set; }

      Mobilize.Web.DmColumn phone { get; set; }

      Mobilize.Web.DmColumn hire_date { get; set; }

      Mobilize.Web.DmColumn schedule { get; set; }

      Mobilize.Web.DmColumn dist_code { get; set; }

   }

}
#pragma warning restore
