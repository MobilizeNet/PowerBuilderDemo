namespace medicationcenter
{

   public interface Idw_showallprescriptions
      : basecomponents.Idw_showallbase
   {

      void Create();

      void Destroy();

      void loaddata();

      void loadmedicines();

      void loadpatients();

      void updatedata();

      void DoWmInit();

   }

}