namespace notifycurrentcontrol
{

   [Mobilize.WebMap.Common.Attributes.Observable]
   public partial class w_dropdown
      : Mobilize.Web.Window, notifycurrentcontrol.Iw_dropdown
   {

      public override void Create()
      {
         this.st_2 = CreateInnerControl_st_2_type();
         this.st_1 = CreateInnerControl_st_1_type();
         this.dw_1 = CreateInnerControl_dw_1_type();
         this.Control = Mobilize.Web.ArrayExtensions.Clone<Mobilize.Web.IControl>(new Mobilize.Web.IControl[] { this.st_2, this.st_1, this.dw_1 });
      }

      public override void Destroy()
      {
         this.st_2 = null;
         this.st_1 = null;
         this.dw_1 = null;
      }

      public virtual void setvalues(short? row)
      {
         this.st_2.Text = Mobilize.Web.PlusFunctions.Plus("itemChanged - ", this.dw_1.GetItemString(row, 2));
      }

      protected virtual Iw_dropdownInner.Ist_2_type CreateInnerControl_st_2_type()
      {
         return Mobilize.Web.Application.Create<Iw_dropdownInner.Ist_2_type>(this);
      }

      protected virtual Iw_dropdownInner.Ist_1_type CreateInnerControl_st_1_type()
      {
         return Mobilize.Web.Application.Create<Iw_dropdownInner.Ist_1_type>(this);
      }

      protected virtual Iw_dropdownInner.Idw_1_type CreateInnerControl_dw_1_type()
      {
         return Mobilize.Web.Application.Create<Iw_dropdownInner.Idw_1_type>(this);
      }

      public class st_2_type
         : Mobilize.Web.StaticText, Iw_dropdownInner.Ist_2_type
      {

         public st_2_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_dropdown Parent => (w_dropdown)base.Parent;

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 73;
            this.Y = 560;
            this.Width = 672;
            this.Height = 64;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.TextColor = 33554432;
            this.BackColor = 67108864;
            this.FocusRectangle = false;
         }

      }

      public class st_1_type
         : Mobilize.Web.StaticText, Iw_dropdownInner.Ist_1_type
      {

         public st_1_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_dropdown Parent => (w_dropdown)base.Parent;

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 73;
            this.Y = 468;
            this.Width = 672;
            this.Height = 64;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.TextColor = 33554432;
            this.BackColor = 67108864;
            this.FocusRectangle = false;
         }

      }

      public class dw_1_type
         : Mobilize.Web.DataManagerControl, Iw_dropdownInner.Idw_1_type
      {

         public dw_1_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_dropdown Parent => (w_dropdown)base.Parent;

         public virtual short? ItemChanged(int? row, Mobilize.Web.IDmControl dwo, string data)
         {
            if ( Mobilize.Web.Comparison.Equals(dwo.Name, "street") == true )
            {
               if ( Mobilize.Web.TypeConversion.Integer(data) > 2 )
               {
                  if ( Mobilize.Web.TypeConversion.Integer(data) > 3 )
                  {
                     return 2 // Allow focus
                     ;
                  }
                  return 1;
               }
            }
            this.Parent.PostMethod("setvalues", new object[] { (short?)row });
            return null;
         }

         public virtual short? Clicked(short? xpos, short? ypos, int? row, Mobilize.Web.IDmControl dwo)
         {
            this.Parent.st_1.Text = Mobilize.Web.PlusFunctions.Plus("Clicked - ", this.Parent.dw_1.GetItemString(row, 2));
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 69;
            this.Y = 40;
            this.Width = 686;
            this.Height = 400;
            this.TabOrder = 10;
            this.Title = "none";
            this.DataObject = "d_street";
            this.LiveScroll = true;
            this.BorderStyle = Mobilize.Web.BorderStyle.StyleLowered;
            this.dwnitemchange = new Mobilize.Web.DataManagerItemChangedEventHandler(ItemChanged);
            this.dwnlbuttonclk = new Mobilize.Web.DataManagerClickedEventHandler(Clicked);
         }

      }

   }

}