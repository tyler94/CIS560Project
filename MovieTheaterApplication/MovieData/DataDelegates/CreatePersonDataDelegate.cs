using PersonData.Models;
using DataAccess;
using System.Data;
using System.Data.SqlClient;

namespace PersonData.DataDelegates
{
   internal class CreatePersonDataDelegate : NonQueryDataDelegate<Person>
   {
      public readonly string firstName;
      public readonly string lastName;
      private readonly string email;

      public CreatePersonDataDelegate(string firstName, string lastName, string email)
         : base("Person.CreatePerson")
      {
         this.firstName = firstName;
         this.lastName = lastName;
         this.email = email;
      }

      public override void PrepareCommand(SqlCommand command)
      {
         base.PrepareCommand(command);

         command.Parameters.AddWithValue("FirstName", firstName);
         command.Parameters.AddWithValue("LastName", lastName);
         command.Parameters.AddWithValue("Email", email);

         var p = command.Parameters.Add("PersonId", SqlDbType.Int);
         p.Direction = ParameterDirection.Output;
      }

      public override Person Translate(SqlCommand command)
      {
         return new Person((int)command.Parameters["PersonId"].Value, firstName, lastName, email);
      }
   }
}