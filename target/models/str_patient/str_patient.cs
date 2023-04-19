namespace models
{

   [Mobilize.WebMap.Common.Attributes.Observable]
   public sealed class str_patient
      : Mobilize.Web.BaseStructure, models.Istr_patient
   {

      public str_patient()
      {
         firstname = "";
         lastname = "";
         age = 0;
         iid = 0;
      }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public string firstname { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public string lastname { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public short? age { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public short? iid { get; set; }

      public Istr_patient ByVal()
      {
         var newStructure = new str_patient();
         newStructure.firstname = this.firstname;
         newStructure.lastname = this.lastname;
         newStructure.age = this.age;
         newStructure.iid = this.iid;
         return newStructure;
      }

   }

}