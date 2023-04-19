namespace basecomponents
{

   public interface Idw_showallbase
      : basecomponents.Idw_basedw
   {

      void Create();

      void Destroy();

      void DoWmInit();

      void updatedata();

      Mobilize.Web.VoidEventHandler updatedataEventHandler { get; set; }

   }

}