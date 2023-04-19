namespace medicationcenter
{

   public static class medicationcenterGlobalFunctions
   {

      public static short? verifyuser(string user, string password)
      {
         if ( (Mobilize.Web.Comparison.Equals(user, "admin") & Mobilize.Web.Comparison.Equals(password, "root")) == true )
         {
            return 1;
         }
         if ( (Mobilize.Web.Comparison.Equals(user, "nonadmin") & Mobilize.Web.Comparison.Equals(password, "noroot")) == true )
         {
            return 2;
         }
         return (short?)(-1);
      }

   }

}