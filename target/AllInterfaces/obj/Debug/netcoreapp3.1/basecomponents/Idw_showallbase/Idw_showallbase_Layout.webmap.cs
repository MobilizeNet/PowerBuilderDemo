#pragma warning disable
#line 1 "basecomponents\\Idw_showallbase\\Idw_showallbase_Layout.cs"
#pragma warning disable
#line 1 "basecomponents\\Idw_showallbase\\Idw_showallbase_Layout.cs"
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
#pragma warning restore
