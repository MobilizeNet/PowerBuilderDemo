#pragma warning disable
#line 1 "pbj_webmapdemo\\IApplication\\IApplication_Layout.cs"
#pragma warning disable
#line 1 "pbj_webmapdemo\\IApplication\\IApplication_Layout.cs"
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
#pragma warning restore
