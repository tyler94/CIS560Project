using System;
using System.Transactions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonData;
using PersonData.Models;

namespace PersonTest
{
   [TestClass]
   public class SqlAddressRepositoryTest
   {
      const string connectionString = @"Server=(localdb)\MSSQLLocalDb;Database=johnkeller;Integrated Security=SSPI;";

      private static string GetTestString() => Guid.NewGuid().ToString("N");

      private SqlPersonRepository personRepo;
      private SqlAddressRepository addressRepo;
      private TransactionScope transaction;

      [TestInitialize]
      public void InitializeTest()
      {
         personRepo = new SqlPersonRepository(connectionString);
         addressRepo = new SqlAddressRepository(connectionString);

         transaction = new TransactionScope();
      }

      [TestCleanup]
      public void CleanupTest()
      {
         transaction.Dispose();
      }

      [TestMethod]
      public void SaveAddressShouldWork()
      {
         var line1 = GetTestString();
         var city = GetTestString();

         var p = personRepo.CreatePerson("Test", "Person", "person@test.com");
         addressRepo.SaveAddress(p.PersonId, AddressType.Home, line1, null, city, "ST", "12345");

         var addresses = addressRepo.RetrieveAdresses(p.PersonId);

         Assert.IsNotNull(addresses);
         Assert.AreEqual(1, addresses.Count);

         var a = addresses[0];

         Assert.AreEqual(p.PersonId, a.PersonId);
         Assert.AreEqual(AddressType.Home, a.AddressType);
         Assert.AreEqual(line1, a.Line1);
         Assert.IsNull(a.Line2);
         Assert.AreEqual(city, a.City);
         Assert.AreEqual("ST", a.StateCode);
         Assert.AreEqual("12345", a.ZipCode);
      }

      [TestMethod]
      public void RetrieveAddressesShouldOnlyReturnAddressesForPerson()
      {
         var city = GetTestString();

         var p = personRepo.CreatePerson("Test", "Person1", "person1@test.com");
         addressRepo.SaveAddress(p.PersonId, AddressType.Home, "Person 1 Address", null, city, "ST", "12345");

         p = personRepo.CreatePerson("Test", "Person2", "person2@test.com");
         addressRepo.SaveAddress(p.PersonId, AddressType.Home, "Person 2 Address", null, city, "ST", "12345");
         addressRepo.SaveAddress(p.PersonId, AddressType.Work, "Person 2 Address", null, city, "ST", "12345");

         var addresses = addressRepo.RetrieveAdresses(p.PersonId);

         Assert.IsNotNull(addresses);
         Assert.AreEqual(2, addresses.Count);

         var a = addresses[0];

         var t = a.AddressType;
         Assert.IsTrue(t == AddressType.Home || t == AddressType.Work);
         Assert.AreEqual(p.PersonId, a.PersonId);
         Assert.AreEqual("Person 2 Address", a.Line1);
         Assert.IsNull(a.Line2);
         Assert.AreEqual(city, a.City);
         Assert.AreEqual("ST", a.StateCode);
         Assert.AreEqual("12345", a.ZipCode);

         a = addresses[1];
         Assert.AreEqual(t == AddressType.Home ? AddressType.Work : AddressType.Home, a.AddressType);
         Assert.AreEqual(p.PersonId, a.PersonId);
         Assert.AreEqual("Person 2 Address", a.Line1);
         Assert.IsNull(a.Line2);
         Assert.AreEqual(city, a.City);
         Assert.AreEqual("ST", a.StateCode);
         Assert.AreEqual("12345", a.ZipCode);
      }
   }
}
