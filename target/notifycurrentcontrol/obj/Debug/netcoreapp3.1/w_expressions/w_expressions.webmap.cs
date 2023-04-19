#pragma warning disable
#line 1 "w_expressions\\w_expressions.cs"
#pragma warning disable
#line 1 "w_expressions\\w_expressions.cs"
namespace notifycurrentcontrol
{

   [Mobilize.WebMap.Common.Attributes.Observable]
   public partial class w_expressions
      : Mobilize.Web.Window, notifycurrentcontrol.Iw_expressions
   {

      public override void Create()
      {
         this.st_3 = CreateInnerControl_st_3_type();
         this.st_2 = CreateInnerControl_st_2_type();
         this.st_1 = CreateInnerControl_st_1_type();
         this.dw_1 = CreateInnerControl_dw_1_type();
         this.Control = Mobilize.Web.ArrayExtensions.Clone<Mobilize.Web.IControl>(new Mobilize.Web.IControl[] { this.st_3, this.st_2, this.st_1, this.dw_1 });
      }

      public override void Destroy()
      {
         this.st_3 = null;
         this.st_2 = null;
         this.st_1 = null;
         this.dw_1 = null;
      }

      protected virtual Iw_expressionsInner.Ist_3_type CreateInnerControl_st_3_type()
      {
         return Mobilize.Web.Application.Create<Iw_expressionsInner.Ist_3_type>(this);
      }

      protected virtual Iw_expressionsInner.Ist_2_type CreateInnerControl_st_2_type()
      {
         return Mobilize.Web.Application.Create<Iw_expressionsInner.Ist_2_type>(this);
      }

      protected virtual Iw_expressionsInner.Ist_1_type CreateInnerControl_st_1_type()
      {
         return Mobilize.Web.Application.Create<Iw_expressionsInner.Ist_1_type>(this);
      }

      protected virtual Iw_expressionsInner.Idw_1_type CreateInnerControl_dw_1_type()
      {
         return Mobilize.Web.Application.Create<Iw_expressionsInner.Idw_1_type>(this);
      }

      public partial class st_3_type
         : Mobilize.Web.StaticText, Iw_expressionsInner.Ist_3_type
      {

         public st_3_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_expressions Parent => (w_expressions)base.Parent;

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 1344;
            this.Y = 340;
            this.Width = 1042;
            this.Height = 128;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.TextColor = 33554432;
            this.BackColor = 67108864;
            this.Text = "3. Name is equal \"Name\" if the no visible column name is equal \"name0\".";
            this.FocusRectangle = false;
         }

      }

      public partial class st_2_type
         : Mobilize.Web.StaticText, Iw_expressionsInner.Ist_2_type
      {

         public st_2_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_expressions Parent => (w_expressions)base.Parent;

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 1349;
            this.Y = 128;
            this.Width = 997;
            this.Height = 200;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.TextColor = 33554432;
            this.BackColor = 67108864;
            this.Text = "2. Description will be \"n/a\" if street is zero, \"One\" if street is 1 else \"Unknown\".";
            this.FocusRectangle = false;
         }

      }

      public partial class st_1_type
         : Mobilize.Web.StaticText, Iw_expressionsInner.Ist_1_type
      {

         public st_1_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_expressions Parent => (w_expressions)base.Parent;

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 1353;
            this.Y = 44;
            this.Width = 1330;
            this.Height = 64;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.TextColor = 33554432;
            this.BackColor = 67108864;
            this.Text = "1. Street will be visible if street is zero.";
            this.FocusRectangle = false;
         }

      }

      public partial class dw_1_type
         : Mobilize.Web.DataManagerControl, Iw_expressionsInner.Idw_1_type
      {

         public dw_1_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_expressions Parent => (w_expressions)base.Parent;

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 50;
            this.Y = 48;
            this.Width = 1266;
            this.Height = 548;
            this.TabOrder = 10;
            this.Title = "none";
            this.DataObject = "d_expressions";
            this.LiveScroll = true;
            this.BorderStyle = Mobilize.Web.BorderStyle.StyleLowered;
         }

      }

   }

}
#pragma warning restore
