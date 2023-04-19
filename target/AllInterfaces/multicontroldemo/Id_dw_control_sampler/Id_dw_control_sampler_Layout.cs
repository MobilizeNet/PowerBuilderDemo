namespace multicontroldemo
{

   public interface Id_dw_control_sampler
      : Mobilize.Web.IDataManager
   {

      Mobilize.Web.DmText name_field_t { get; set; }

      Mobilize.Web.DmColumn name_field { get; set; }

      Mobilize.Web.DmText age_field_t { get; set; }

      Mobilize.Web.DmColumn age_field { get; set; }

      Mobilize.Web.DmText description_field_t { get; set; }

      Mobilize.Web.DmColumn description_field { get; set; }

      Mobilize.Web.DmText date_field_t { get; set; }

      Mobilize.Web.DmColumn date_field { get; set; }

      Mobilize.Web.DmText event_date_field_t { get; set; }

      Mobilize.Web.DmColumn event_date_field { get; set; }

      Mobilize.Web.DmText salary_field_t { get; set; }

      Mobilize.Web.DmColumn salary_field { get; set; }

      Mobilize.Web.DmColumn flag_field { get; set; }

      Mobilize.Web.DmText t_1 { get; set; }

      Mobilize.Web.DmColumn options_field { get; set; }

      Mobilize.Web.DmText t_2 { get; set; }

      Mobilize.Web.DmColumn drop_field { get; set; }

      Mobilize.Web.DmText t_3 { get; set; }

   }

}