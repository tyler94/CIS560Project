using System;
using System.Data.SqlClient;

namespace DataAccess
{
   /// <summary>
   /// Simple wrapper class for more concise code by the callers.
   /// Other "getters" supported by <see cref="SqlDataReader"/> can easily be added.
   /// </summary>
   internal class DataRowReader : IDataRowReader
   {
      private readonly SqlDataReader reader;

      public DataRowReader(SqlDataReader reader)
      {
         this.reader = reader;
      }

      public bool Read()
      {
         return reader.Read();
      }

      public int GetInt32(string name)
      {
         return GetValue(name, reader.GetInt32);
      }

      public int GetInt32(string name, int defaultValue)
      {
         return GetValue(name, reader.GetInt32, defaultValue);
      }

      public byte GetByte(string name)
      {
         return GetValue(name, reader.GetByte);
      }

      public byte GetByte(string name, byte defaultValue)
      {
         return GetValue(name, reader.GetByte, defaultValue);
      }

      public bool GetBoolean(string name)
      {
         return GetValue(name, reader.GetBoolean);
      }

      public bool GetBoolean(string name, bool defaultValue)
      {
         return GetValue(name, reader.GetBoolean, defaultValue);
      }

      public string GetString(string name)
      {
         return GetValue(name, reader.GetString);
      }

      public string GetString(string name, string defaultValue)
      {
         return GetValue(name, reader.GetString, defaultValue);
      }

      public DateTimeOffset GetDateTimeOffset(string name)
      {
         return GetValue(name, reader.GetDateTimeOffset);
      }

      public DateTimeOffset GetDateTimeOffset(string name, DateTimeOffset defaultValue)
      {
         return GetValue(name, reader.GetDateTimeOffset, defaultValue);
      }

      public T GetValue<T>(string name)
      {
         return (T)GetValue(name, reader.GetValue);
      }

      public T GetValue<T>(string name, T defaultValue)
      {
         return (T)GetValue(name, reader.GetValue, defaultValue);
      }

      public bool IsDbNull(string name)
      {
         return reader.IsDBNull(GetOrdinal(name));
      }

      private int GetOrdinal(string name)
      {
         try
         {
            return reader.GetOrdinal(name);
         }
         catch (IndexOutOfRangeException ex)
         {
            throw new ColumnNotFoundException(name, ex);
         }
      }

      private T GetValue<T>(string name, Func<int, T> getter)
      {
         return getter(GetOrdinal(name));
      }

      private T GetValue<T>(string name, Func<int, T> getter, T defaultValue)
      {
         var ordinal = GetOrdinal(name);

         return reader.IsDBNull(ordinal)
            ? defaultValue
            : getter(ordinal);
      }
   }
}