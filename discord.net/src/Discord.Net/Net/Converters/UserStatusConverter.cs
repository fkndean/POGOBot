﻿using Newtonsoft.Json;
using System;

namespace Discord.Net.Converters
{
    public class UserStatusConverter : JsonConverter
    {
        public static readonly UserStatusConverter Instance = new UserStatusConverter();

        public override bool CanConvert(Type objectType) => true;
        public override bool CanRead => true;
        public override bool CanWrite => true;

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            switch ((string)reader.Value)
            {
                case "online":
                    return UserStatus.Online;
                case "idle":
                    return UserStatus.Idle;
                case "offline":
                    return UserStatus.Offline;
                case "dnd":
                    return UserStatus.DoNotDisturb;
                default:
                    throw new JsonSerializationException("Unknown user status");
            }
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            switch ((UserStatus)value)
            {
                case UserStatus.Online:
                    writer.WriteValue("online");
                    break;
                case UserStatus.Idle:
                    writer.WriteValue("idle");
                    break;
                case UserStatus.Offline:
                    writer.WriteValue("offline");
                    break;
                case UserStatus.DoNotDisturb:
                    writer.WriteValue("dnd");
                    break;
                default:
                    throw new JsonSerializationException("Invalid user status");
            }
        }
    }
}
