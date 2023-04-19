namespace multicontroldemo
{

   public partial class w_dw_control_sampler_events
   {

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_dw_control_sampler_eventsInner.Icb_3_type cb_3 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_dw_control_sampler_eventsInner.Icb_2_type cb_2 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_dw_control_sampler_eventsInner.Icb_1_type cb_1 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_dw_control_sampler_eventsInner.Imle_log_type mle_log { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_dw_control_sampler_eventsInner.Idw_1_type dw_1 { get; set; }


      public w_dw_control_sampler_events(Mobilize.Web.BaseControl parent = null)
      : base(parent)
      {
         this.Width = 3817;
         this.Height = 1720;
         this.TitleBar = true;
         this.Title = "Untitled";
         this.ControlMenu = true;
         this.MinBox = true;
         this.MaxBox = true;
         this.Resizable = true;
         this.BackColor = 67108864;
         this.Icon = "AppIcon!";
         this.Center = true;
      }
   }

}