#pragma warning disable
#line 1 "medicationcenter\\Iw_basemdi\\Iw_basemdi_Layout.cs"
#pragma warning disable
#line 1 "medicationcenter\\Iw_basemdi\\Iw_basemdi_Layout.cs"
namespace medicationcenter
{

   public interface Iw_basemdi
      : basecomponents.Iw_basewindow
   {

      void Create();

      void Destroy();

      Iw_basemdiInner.Imdi_1_type mdi_1 { get; set; }

   }

   namespace Iw_basemdiInner
   {

      public interface Imdi_1_type
         : Mobilize.Web.IMDIClient
      {

         void DoWmInit();

      }

   }
}
#pragma warning restore
