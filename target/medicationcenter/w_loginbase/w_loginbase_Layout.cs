namespace medicationcenter
{

   public partial class w_loginbase
   {

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_loginbaseInner.Icbx_admin_type cbx_admin { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_loginbaseInner.Ist_pass_type st_pass { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_loginbaseInner.Ist_user_type st_user { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_loginbaseInner.Isle_pass_type sle_pass { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_loginbaseInner.Isle_user_type sle_user { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_loginbaseInner.Iuo_okcancel_type uo_okcancel { get; set; }


      public w_loginbase(Mobilize.Web.BaseControl parent = null)
      : base(parent)
      {
         this.Width = 1659;
         this.Height = 944;
         this.Title = "Medication Center";
         this.MinBox = false;
         this.MaxBox = false;
         this.Resizable = false;
         this.WindowType = Mobilize.Web.WindowType.Response;
      }
   }

}