using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VDA_Application.Model
{
    public static class Extensions
    {
        // For value types
        public static T? GetValueSafe<T>(this NpgsqlDataReader reader, int ordinal)
        where T : struct
        {
            return !reader.IsDBNull(ordinal)
                ? reader.GetFieldValue<T>(ordinal)
                : (T?)null;
        }

        // For reference types
        public static T? GetValueSafeRef<T>(this NpgsqlDataReader reader, int ordinal)
        where T : class
        {
            return !reader.IsDBNull(ordinal) ? reader.GetFieldValue<T>(ordinal) : null;
        }

        // DateTime? -> DateOnly?
        public static DateOnly? FromDateTimeSafe(DateTime? dateTime)
        {
            return dateTime is null ? null : DateOnly.FromDateTime((DateTime)dateTime);
        }
    }
}
