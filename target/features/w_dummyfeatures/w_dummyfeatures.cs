namespace features
{

   [Mobilize.WebMap.Common.Attributes.Observable]
   public partial class w_dummyfeatures
      : Mobilize.Web.Window, features.Iw_dummyfeatures
   {

      public override void Create()
      {
         this.cb_1 = CreateInnerControl_cb_1_type();
         this.Control = Mobilize.Web.ArrayExtensions.Clone<Mobilize.Web.IControl>(new Mobilize.Web.IControl[] { this.cb_1 });
      }

      public override void Destroy()
      {
         this.cb_1 = null;
      }

      public virtual int? OpenWindow()
      { //TODO This window is required because of bug #241035

         return null;
      }

      public override void DoWmInit()
      {
         base.DoWmInit();
         this.open = new Mobilize.Web.OpenWindowEventHandler(OpenWindow);
      }

      protected virtual Iw_dummyfeaturesInner.Icb_1_type CreateInnerControl_cb_1_type()
      {
         return Mobilize.Web.Application.Create<Iw_dummyfeaturesInner.Icb_1_type>(this);
      }

      public class cb_1_type
         : Mobilize.Web.CommandButton, Iw_dummyfeaturesInner.Icb_1_type
      {

         public cb_1_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_dummyfeatures Parent => (w_dummyfeatures)base.Parent;

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 827;
            this.Y = 584;
            this.Width = 402;
            this.Height = 112;
            this.TabOrder = 10;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.Text = "none";
         }

      }

   }

}