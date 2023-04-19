#pragma warning disable
#line 1 "notifycurrentcontrol\\IApplication\\IApplication_Layout.cs"
#pragma warning disable
#line 1 "notifycurrentcontrol\\IApplication\\IApplication_Layout.cs"
namespace notifycurrentcontrol
{

   public interface IApplication
      : Mobilize.Web.IApplication
   {

      void DoWmInit();

      int? OpenWindow(string commandline);

      void Create();

      void Destroy();

   }

}
#pragma warning restore
