namespace medicationcenter
{

   public interface Id_addprescription
      : Mobilize.Web.IDataManager
   {

      Mobilize.Web.DmText t_1 { get; set; }

      Mobilize.Web.DmText t_2 { get; set; }

      Mobilize.Web.DmColumn patient { get; set; }

      Mobilize.Web.DmText t_4 { get; set; }

      Mobilize.Web.DmColumn iid { get; set; }

      Mobilize.Web.DmText t_3 { get; set; }

      Mobilize.Web.DmColumn dose { get; set; }

      Mobilize.Web.DmText t_5 { get; set; }

      Mobilize.Web.DmColumn medicine { get; set; }

      Mobilize.Web.DmColumn socialsecurity { get; set; }

   }

}