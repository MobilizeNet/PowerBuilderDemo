namespace medicationcenter
{

   public interface Iw_prescriptionmant
      : medicationcenter.Iw_tabbase
   {

      void DoWmInit();

      void Create();

      void Destroy();

      void saveadd();

      void saveremove();

      bool? isvalidadddata(short? _id, short? patient, short? medicine, decimal? dose);

      short? getnextprescription();

      int? OpenWindow();

      void ev_loadcontent();

      void savedata();

      Iw_prescriptionmantInner.Iuo_1_type uo_1 { get; set; }

      bool? dirtyadd { get; set; }

      bool? dirtyremove { get; set; }

      Mobilize.Web.VoidEventHandler savedataEventHandler { get; set; }

   }

   namespace Iw_prescriptionmantInner
   {

      public interface Iuo_1_type
         : medicationcenter.Iou_showallprescriptions
      {

         Mobilize.Web.VoidEventHandler DestroyEventHandler { get; set; }

         void DoWmInit();

      }

      public interface Itab_1_type
         : medicationcenter.Iw_tabbaseInner.Itab_1_type
      {

         void adddirty();

         void removedirty();

         void dosearch();

         int? SelectionChanged(short? oldindex, short? newindex);

         Mobilize.Web.VoidEventHandler ev_loadcontentEventHandler { get; set; }

         void ev_loadcontent();

         void DoWmInit();

      }

   }
}