#pragma warning disable
#line 1 "medicationcenter\\Itb_tabbase\\Itb_tabbase_Layout.cs"
#pragma warning disable
#line 1 "medicationcenter\\Itb_tabbase\\Itb_tabbase_Layout.cs"
namespace medicationcenter
{

   public interface Itb_tabbase
      : Mobilize.Web.ITab
   {

      void Create();

      void Destroy();

      void loadremovedata(Mobilize.Web.IDataManagerControl dw);

      void resetadddata();

      void DoWmInit();

      void adddirty();

      void removedirty();

      void dosearch();

      Itb_tabbaseInner.Itabpage_add_type tabpage_add { get; set; }

      Itb_tabbaseInner.Itabpage_remove_type tabpage_remove { get; set; }

      Itb_tabbaseInner.Itabpage_search_type tabpage_search { get; set; }

      Mobilize.Web.VoidEventHandler adddirtyEventHandler { get; set; }

      Mobilize.Web.VoidEventHandler removedirtyEventHandler { get; set; }

      Mobilize.Web.VoidEventHandler dosearchEventHandler { get; set; }

   }

   namespace Itb_tabbaseInner
   {

      public interface Itabpage_add_type
         : Mobilize.Web.IUserObject
      {

         void adddirty();

         Itb_tabbaseInner.Itabpage_add_typeInner.Idw_add_type dw_add { get; set; }

         Mobilize.Web.VoidEventHandler CreateEventHandler { get; set; }

         Mobilize.Web.VoidEventHandler DestroyEventHandler { get; set; }

         Mobilize.Web.VoidEventHandler adddirtyEventHandler { get; set; }

         void Create();

         void DoWmInit();

      }

      namespace Itabpage_add_typeInner
      {

         public interface Idw_add_type
            : Mobilize.Web.IDataManagerControl
         {

            short? ItemChanged(int? row, Mobilize.Web.IDmControl dwo, string data);

            void resetdata();

            Mobilize.Web.VoidEventHandler resetdataEventHandler { get; set; }

            void DoWmInit();

         }

      }

      public interface Itabpage_remove_type
         : Mobilize.Web.IUserObject
      {

         void removedirty();

         Itb_tabbaseInner.Itabpage_remove_typeInner.Idw_remove_type dw_remove { get; set; }

         Mobilize.Web.VoidEventHandler CreateEventHandler { get; set; }

         Mobilize.Web.VoidEventHandler DestroyEventHandler { get; set; }

         Mobilize.Web.VoidEventHandler removedirtyEventHandler { get; set; }

         void Create();

         void DoWmInit();

      }

      namespace Itabpage_remove_typeInner
      {

         public interface Idw_remove_type
            : Mobilize.Web.IDataManagerControl
         {

            short? ItemChanged(int? row, Mobilize.Web.IDmControl dwo, string data);

            int? Constructor();

            void reloadremovedata();

            void resetdata();

            Mobilize.Web.VoidEventHandler reloadremovedataEventHandler { get; set; }

            Mobilize.Web.VoidEventHandler resetdataEventHandler { get; set; }

            void DoWmInit();

         }

      }

      public interface Itabpage_search_type
         : Mobilize.Web.IUserObject
      {

         void dosearch();

         Itb_tabbaseInner.Itabpage_search_typeInner.Idw_search_type dw_search { get; set; }

         Mobilize.Web.VoidEventHandler CreateEventHandler { get; set; }

         Mobilize.Web.VoidEventHandler DestroyEventHandler { get; set; }

         Mobilize.Web.VoidEventHandler dosearchEventHandler { get; set; }

         void Create();

         void DoWmInit();

      }

      namespace Itabpage_search_typeInner
      {

         public interface Idw_search_type
            : basecomponents.Idw_basedw
         {

            short? ButtonClicked(int? row, int? actionreturncode, Mobilize.Web.IDmControl dwo);

            void DoWmInit();

         }

      }
   }
}
#pragma warning restore
