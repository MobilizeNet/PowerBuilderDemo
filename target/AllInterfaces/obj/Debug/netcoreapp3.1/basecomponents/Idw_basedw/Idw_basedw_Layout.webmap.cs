#pragma warning disable
#line 1 "basecomponents\\Idw_basedw\\Idw_basedw_Layout.cs"
#pragma warning disable
#line 1 "basecomponents\\Idw_basedw\\Idw_basedw_Layout.cs"
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
#pragma warning restore
