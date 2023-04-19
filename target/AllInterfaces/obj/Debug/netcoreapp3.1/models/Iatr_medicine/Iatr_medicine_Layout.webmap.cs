#pragma warning disable
#line 1 "models\\Iatr_medicine\\Iatr_medicine_Layout.cs"
#pragma warning disable
#line 1 "models\\Iatr_medicine\\Iatr_medicine_Layout.cs"
namespace models
{

   public interface Iatr_medicine
      : Mobilize.Web.IBaseStructure
   {

      string sname { get; set; }

      short? iid { get; set; }

      Iatr_medicine ByVal();

   }

}
#pragma warning restore
