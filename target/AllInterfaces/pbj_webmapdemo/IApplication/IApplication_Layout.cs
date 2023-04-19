namespace pbj_webmapdemo
{

   public interface IApplication
      : Mobilize.Web.IApplication
   {

      void DoWmInit();

      int? OpenWindow(string commandline);

      void Create();

      void Destroy();

      void loadpatients();

      void loadmedicines();

      void loadprescriptions();

   }

}