namespace pbj_webmapdemo
{

   public interface Iw_pbj_main
      : Mobilize.Web.IWindow
   {

      void Create();

      void Destroy();

      Iw_pbj_mainInner.Imdi_1_type mdi_1 { get; set; }

   }

   namespace Iw_pbj_mainInner
   {

      public interface Imdi_1_type
         : Mobilize.Web.IMDIClient
      {

         void DoWmInit();

      }

   }
}