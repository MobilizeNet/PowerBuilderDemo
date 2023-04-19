#pragma warning disable
#line 1 "pbj_webmapdemoGlobalFunctions\\pbj_webmapdemoGlobalFunctions.cs"
#pragma warning disable
#line 1 "pbj_webmapdemoGlobalFunctions\\pbj_webmapdemoGlobalFunctions.cs"
namespace pbj_webmapdemo
{

   public static partial class pbj_webmapdemoGlobalFunctions
   {

      public static void f_connect()
      {
         string str = "";
         if ( Mobilize.Web.Comparison.Equals(Mobilize.Web.BuiltInExtensions.RegistryGet("HKEY_LOCAL_MACHINE\\Integration", "DBMS", Mobilize.Web.ReferenceExtensions.Ref<object>((object)str, (v) => str = (string)v, () => str)), 1) == true )
         {
            ((Mobilize.Web.ITransaction)(Mobilize.Web.Application.CurrentApplication.Variables.SQLCA<Mobilize.Web.ITransaction>())).DBMS = str;
            Mobilize.Web.BuiltInExtensions.RegistryGet("HKEY_LOCAL_MACHINE\\Integration", "DBParm", Mobilize.Web.ReferenceExtensions.Ref<object>((object)str, (v) => str = (string)v, () => str));
            ((Mobilize.Web.ITransaction)(Mobilize.Web.Application.CurrentApplication.Variables.SQLCA<Mobilize.Web.ITransaction>())).DBParm = str;
            Mobilize.Web.BuiltInExtensions.RegistryGet("HKEY_LOCAL_MACHINE\\Integration", "ServerName", Mobilize.Web.ReferenceExtensions.Ref<object>((object)str, (v) => str = (string)v, () => str));
            ((Mobilize.Web.ITransaction)(Mobilize.Web.Application.CurrentApplication.Variables.SQLCA<Mobilize.Web.ITransaction>())).ServerName = str;
            ((Mobilize.Web.ITransaction)(Mobilize.Web.Application.CurrentApplication.Variables.SQLCA<Mobilize.Web.ITransaction>())).Connect();
         }
         else
         {
            ((Mobilize.Web.ITransaction)(Mobilize.Web.Application.CurrentApplication.Variables.SQLCA<Mobilize.Web.ITransaction>())).DBMS = "ODBC";
            ((Mobilize.Web.ITransaction)(Mobilize.Web.Application.CurrentApplication.Variables.SQLCA<Mobilize.Web.ITransaction>())).AutoCommit = false;
            ((Mobilize.Web.ITransaction)(Mobilize.Web.Application.CurrentApplication.Variables.SQLCA<Mobilize.Web.ITransaction>())).DBParm = "ConnectString='DSN=PBJDemo;UID=adminartinsoft;PWD=Password2011'";
            ((Mobilize.Web.ITransaction)(Mobilize.Web.Application.CurrentApplication.Variables.SQLCA<Mobilize.Web.ITransaction>())).Connect();
            if ( Mobilize.Web.Comparison.NotEquals(((Mobilize.Web.ITransaction)(Mobilize.Web.Application.CurrentApplication.Variables.sqlca<Mobilize.Web.ITransaction>())).SQLCode, 0) == true )
            {
            // TODO commented out to avoid failing when conneciton to the Db was not possible
            //messagebox("connect", sqlca.sqlErrText, stopsign!)
            // halt close
            }
         }
      }

   }

}
#pragma warning restore
