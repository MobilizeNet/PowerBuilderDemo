namespace features
{

   public interface Iw_dummyfeatures
      : Mobilize.Web.IWindow
   {

      void Create();

      void Destroy();

      int? OpenWindow();

      void DoWmInit();

      Iw_dummyfeaturesInner.Icb_1_type cb_1 { get; set; }

   }

   namespace Iw_dummyfeaturesInner
   {

      public interface Icb_1_type
         : Mobilize.Web.ICommandButton
      {

         void DoWmInit();

      }

   }
}