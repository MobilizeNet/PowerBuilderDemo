#pragma warning disable
#line 1 "medicationcenter\\Iw_tabbase\\Iw_tabbase_Layout.cs"
#pragma warning disable
#line 1 "medicationcenter\\Iw_tabbase\\Iw_tabbase_Layout.cs"
namespace medicationcenter
{

   public interface Iw_tabbase
      : basecomponents.Iw_basewindow
   {

      void Create();

      void Destroy();

      Iw_tabbaseInner.Itab_1_type tab_1 { get; set; }

   }

   namespace Iw_tabbaseInner
   {

      public interface Itab_1_type
         : medicationcenter.Itb_tabbase
      {

         void DoWmInit();

      }

   }
}
#pragma warning restore
