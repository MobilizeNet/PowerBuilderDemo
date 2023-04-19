#pragma warning disable
#line 1 "pbj_webmapdemo\\Iw_static_text\\Iw_static_text_Layout.cs"
#pragma warning disable
#line 1 "pbj_webmapdemo\\Iw_static_text\\Iw_static_text_Layout.cs"
namespace pbj_webmapdemo
{

   public interface Iw_static_text
      : Mobilize.Web.IWindow
   {

      void Create();

      void Destroy();

      Iw_static_textInner.Ist_1_type st_1 { get; set; }

      Iw_static_textInner.Icb_enable_type cb_enable { get; set; }

      Iw_static_textInner.Icb_visible_type cb_visible { get; set; }

      Iw_static_textInner.Icb_text_type cb_text { get; set; }

      Iw_static_textInner.Icb_showhide_type cb_showhide { get; set; }

   }

   namespace Iw_static_textInner
   {

      public interface Ist_1_type
         : Mobilize.Web.IStaticText
      {

         void DoWmInit();

      }

      public interface Icb_enable_type
         : Mobilize.Web.ICommandButton
      {

         int? Clicked();

         void DoWmInit();

      }

      public interface Icb_visible_type
         : Mobilize.Web.ICommandButton
      {

         int? Clicked();

         void DoWmInit();

      }

      public interface Icb_text_type
         : Mobilize.Web.ICommandButton
      {

         int? Clicked();

         void DoWmInit();

      }

      public interface Icb_showhide_type
         : Mobilize.Web.ICommandButton
      {

         int? Clicked();

         void DoWmInit();

      }

   }
}
#pragma warning restore
