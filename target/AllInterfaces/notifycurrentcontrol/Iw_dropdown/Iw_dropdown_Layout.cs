namespace notifycurrentcontrol
{

   public interface Iw_dropdown
      : Mobilize.Web.IWindow
   {

      void Create();

      void Destroy();

      void setvalues(short? row);

      Iw_dropdownInner.Ist_2_type st_2 { get; set; }

      Iw_dropdownInner.Ist_1_type st_1 { get; set; }

      Iw_dropdownInner.Idw_1_type dw_1 { get; set; }

   }

   namespace Iw_dropdownInner
   {

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

         short? ItemChanged(int? row, Mobilize.Web.IDmControl dwo, string data);

         short? Clicked(short? xpos, short? ypos, int? row, Mobilize.Web.IDmControl dwo);

         void DoWmInit();

      }

   }
}