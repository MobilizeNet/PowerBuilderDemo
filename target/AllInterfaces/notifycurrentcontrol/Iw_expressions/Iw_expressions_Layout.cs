namespace notifycurrentcontrol
{

   public interface Iw_expressions
      : Mobilize.Web.IWindow
   {

      void Create();

      void Destroy();

      Iw_expressionsInner.Ist_3_type st_3 { get; set; }

      Iw_expressionsInner.Ist_2_type st_2 { get; set; }

      Iw_expressionsInner.Ist_1_type st_1 { get; set; }

      Iw_expressionsInner.Idw_1_type dw_1 { get; set; }

   }

   namespace Iw_expressionsInner
   {

      public interface Ist_3_type
         : Mobilize.Web.IStaticText
      {

         void DoWmInit();

      }

      public interface Ist_2_type
         : Mobilize.Web.IStaticText
      {

         void DoWmInit();

      }

      public interface Ist_1_type
         : Mobilize.Web.IStaticText
      {

         void DoWmInit();

      }

      public interface Idw_1_type
         : Mobilize.Web.IDataManagerControl
      {

         void DoWmInit();

      }

   }
}