using System;

namespace DataAccess
{
   public interface IDataRowReader
   {
      bool Read();
      byte GetByte(string name);
      byte GetByte(string name, byte defaultValue);
      DateTimeOffset GetDateTimeOffset(string name);
      DateTimeOffset GetDateTimeOffset(string name, DateTimeOffset defaultValue);
      int GetInt32(string name);
      int GetInt32(string name, int defaultValue);
      string GetString(string name);
      string GetString(string name, string defaultValue);
      T GetValue<T>(string name);
      T GetValue<T>(string name, T defaultValue);
   }
}