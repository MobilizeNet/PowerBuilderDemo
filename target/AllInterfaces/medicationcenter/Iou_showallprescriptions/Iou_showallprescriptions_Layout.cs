namespace medicationcenter
{

   public interface Iou_showallprescriptions
      : Mobilize.Web.IUserObject
   {

      void Create();

      void Destroy();

      int? Constructor();

      void DoWmInit();

      Iou_showallprescriptionsInner.Idw_all_type dw_all { get; set; }

   }

   namespace Iou_showallprescriptionsInner
   {

      public interface Idw_all_type
         : medicationcenter.Idw_showallprescriptions
      {

         void DoWmInit();

      }

   }
}