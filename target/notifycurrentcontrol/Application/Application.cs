namespace notifycurrentcontrol
{

   public class Application
      : Mobilize.Web.Application, notifycurrentcontrol.IApplication
   {

      public Application(System.IServiceProvider provider)
      : base(provider)
      {
         this.AppName = "notifycurrentcontrol";
      }

      public void DoWmInit()
      {
      }

      public virtual int? OpenWindow(string commandline)
      { //open(w_window)

         Mobilize.Web.BuiltInExtensions.Open(Mobilize.Web.ReferenceExtensions.Ref<Mobilize.Web.IWindow>((Mobilize.Web.IWindow)Mobilize.Web.Application.CurrentApplication.Variables.w_shareddatawindow<notifycurrentcontrol.Iw_shareddatawindow>(), (v) => Mobilize.Web.Application.CurrentApplication.Variables.w_shareddatawindow = (notifycurrentcontrol.Iw_shareddatawindow)v, () => Mobilize.Web.Application.CurrentApplication.Variables.w_shareddatawindow<notifycurrentcontrol.Iw_shareddatawindow>()));
         return null;
      //open(w_dropdown)
      //open(w_expressions)
      }

      public override void Create()
      {
         this.AppName = "notifycurrentcontrol";
         Mobilize.Web.Application.CurrentApplication.Variables.message = Mobilize.Web.Application.Create<Mobilize.Web.IMessage>();
         Mobilize.Web.Application.CurrentApplication.Variables.sqlca = Mobilize.Web.Application.Create<Mobilize.Web.ITransaction>();
         Mobilize.Web.Application.CurrentApplication.Variables.SqlDa = Mobilize.Web.Application.Create<Mobilize.Web.IDynamicDescriptionArea>();
         Mobilize.Web.Application.CurrentApplication.Variables.SqlSa = Mobilize.Web.Application.Create<Mobilize.Web.IDynamicStagingArea>();
         Mobilize.Web.Application.CurrentApplication.Variables.Error = Mobilize.Web.Application.Create<Mobilize.Web.IError>();
      }

      public override void Destroy()
      {
         Mobilize.Web.Application.CurrentApplication.Variables.sqlca = null;
         Mobilize.Web.Application.CurrentApplication.Variables.SqlDa = null;
         Mobilize.Web.Application.CurrentApplication.Variables.SqlSa = null;
         Mobilize.Web.Application.CurrentApplication.Variables.Error = null;
         Mobilize.Web.Application.CurrentApplication.Variables.message = null;
      }

   }

}