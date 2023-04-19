namespace models
{

   [Mobilize.WebMap.Common.Attributes.Observable]
   public sealed class str_prescription
      : Mobilize.Web.BaseStructure, models.Istr_prescription
   {

      public str_prescription()
      {
         dose = null;
         iid = 0;
         medicine = 0;
         patient = 0;
         state = 0;
         socialsecurity = "";
      }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public decimal? dose { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public short? iid { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public short? medicine { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public short? patient { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public short? state { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public string socialsecurity { get; set; }

      public Istr_prescription ByVal()
      {
         var newStructure = new str_prescription();
         newStructure.dose = this.dose;
         newStructure.iid = this.iid;
         newStructure.medicine = this.medicine;
         newStructure.patient = this.patient;
         newStructure.state = this.state;
         newStructure.socialsecurity = this.socialsecurity;
         return newStructure;
      }

   }

}