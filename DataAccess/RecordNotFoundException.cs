using System;

namespace DataAccess
{
   public class RecordNotFoundException : Exception
   {
      public RecordNotFoundException(string key)
         : base($"The requested record with key [{key}] does not exist.")
      {
      }
   }
}
