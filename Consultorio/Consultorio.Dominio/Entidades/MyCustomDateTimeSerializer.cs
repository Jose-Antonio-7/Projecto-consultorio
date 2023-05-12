using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using System;
using System.Collections.Generic;
using System.Text;

namespace Consultorio.Dominio.Entidades
{
    public class MyCustomDateTimeSerializer<TDateTime> : IBsonSerializer
    {
        static MyCustomDateTimeSerializer()
        {
            if (typeof(TDateTime) != typeof(DateTime) && typeof(TDateTime) != typeof(DateTime?))
            {
                throw new InvalidOperationException($"MyCustomDateTimeSerializer could be used only with {nameof(DateTime)} or {nameof(Nullable<DateTime>)}");
            }
        }

        public object Deserialize(BsonDeserializationContext context, BsonDeserializationArgs args)
        {
            var dateTime = context.Reader.ReadDateTime();
            if (typeof(TDateTime) == typeof(DateTime?))
            {
                if (dateTime == BsonConstants.UnixEpoch.Millisecond)
                {
                    return null;
                }
                else
                {
                    return new DateTime(dateTime);
                }
            }
            else
            {
                return new DateTime(dateTime);
            }
        }

        public void Serialize(BsonSerializationContext context, BsonSerializationArgs args, object value)
        {
            if (value == null)
            {
                context.Writer.WriteInt64(BsonConstants.UnixEpoch.Millisecond);
            }
            else
            {
                context.Writer.WriteDateTime(((DateTime)value).Ticks);
            }
        }

        public Type ValueType => typeof(TDateTime);
    }
}
