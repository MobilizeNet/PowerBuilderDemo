namespace models
{

   [Mobilize.WebMap.Common.Attributes.Observable]
   public sealed class atr_medicine
      : Mobilize.Web.BaseStructure, models.Iatr_medicine
   {

      public atr_medicine()
      {
         sname = "";
         iid = 0;
      }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public string sname { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public short? iid { get; set; }

      public Iatr_medicine ByVal()
      {
         var newStructure = new atr_medicine();
         newStructure.sname = this.sname;
         newStructure.iid = this.iid;
         return newStructure;
      }

   }

}