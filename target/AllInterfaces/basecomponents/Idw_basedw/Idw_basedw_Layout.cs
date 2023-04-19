namespace basecomponents
{

   public interface Idw_basedw
      : Mobilize.Web.IDataManagerControl
   {

      void Create();

      void Destroy();

      void resetdata();

      void DoWmInit();

      Mobilize.Web.VoidEventHandler resetdataEventHandler { get; set; }

   }

}