using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using System;
using System.Collections.Generic;
using System.Text;

namespace Consultorio.Dominio.Entidades
{
    //public class DateTimeSerializer : IBsonDocumentSerializer<DateTime>
    //{
    //    public DateTime Deserialize(BsonDeserializationContext context, BsonDeserializationArgs args)
    //    {
    //        return BsonTypeMapper.MapToDotNetValue(context.Reader.ReadDateTime());
    //    }

    //    public void Serialize(BsonSerializationContext context, BsonSerializationArgs args, DateTime value)
    //    {
    //        context.Writer.WriteDateTime(BsonTypeMapper.MapToBsonValue(value));
    //    }

    //    public Type ValueType => typeof(DateTime);
    //}

}
