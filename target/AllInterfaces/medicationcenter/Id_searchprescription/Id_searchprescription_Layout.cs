namespace medicationcenter
{

   public interface Id_searchprescription
      : Mobilize.Web.IDataManager
   {

      Mobilize.Web.DmText patient_t { get; set; }

      Mobilize.Web.DmColumn patient { get; set; }

      Mobilize.Web.DmText medication_t { get; set; }

      Mobilize.Web.DmColumn medication { get; set; }

      Mobilize.Web.DmButton b_1 { get; set; }

      Mobilize.Web.DmText t_search { get; set; }

      Mobilize.Web.DmColumn searchby { get; set; }

   }

}