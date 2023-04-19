#pragma warning disable
#line 1 "pbj_webmapdemo\\Iw_picture\\Iw_picture_Layout.cs"
#pragma warning disable
#line 1 "pbj_webmapdemo\\Iw_picture\\Iw_picture_Layout.cs"
namespace pbj_webmapdemo
{

   public interface Iw_picture
      : Mobilize.Web.IWindow
   {

      void Create();

      void Destroy();

      Iw_pictureInner.Icb_4_type cb_4 { get; set; }

      Iw_pictureInner.Icb_5_type cb_5 { get; set; }

      Iw_pictureInner.Icb_6_type cb_6 { get; set; }

      Iw_pictureInner.Icb_3_type cb_3 { get; set; }

      Iw_pictureInner.Icb_1_type cb_1 { get; set; }

      Iw_pictureInner.Ip_1_type p_1 { get; set; }

   }

   namespace Iw_pictureInner
   {

      public interface Icb_4_type
         : Mobilize.Web.ICommandButton
      {

         int? Clicked();

         void DoWmInit();

      }

      public interface Icb_5_type
         : Mobilize.Web.ICommandButton
      {

         int? Clicked();

         void DoWmInit();

      }

      public interface Icb_6_type
         : Mobilize.Web.ICommandButton
      {

         int? Clicked();

         void DoWmInit();

      }

      public interface Icb_3_type
         : Mobilize.Web.ICommandButton
      {

         void DoWmInit();

      }

      public interface Icb_1_type
         : Mobilize.Web.ICommandButton
      {

         int? Clicked();

         void DoWmInit();

      }

      public interface Ip_1_type
         : Mobilize.Web.IPicture
      {

         int? Clicked();

         void DoWmInit();

      }

   }
}
#pragma warning restore
