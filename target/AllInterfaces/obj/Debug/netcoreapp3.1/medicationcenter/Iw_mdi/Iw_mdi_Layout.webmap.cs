#pragma warning disable
#line 1 "medicationcenter\\Iw_mdi\\Iw_mdi_Layout.cs"
#pragma warning disable
#line 1 "medicationcenter\\Iw_mdi\\Iw_mdi_Layout.cs"
namespace medicationcenter
{

   public interface Iw_mdi
      : medicationcenter.Iw_basemdi
   {

      void Create();

      void Destroy();

      void ev_loadcontent();

      void DoWmInit();

   }

   namespace Iw_mdiInner
   {

      public interface Imdi_1_type
         : medicationcenter.Iw_basemdiInner.Imdi_1_type
      {
      }

   }
}
#pragma warning restore
