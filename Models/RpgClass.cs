using System.Text.Json.Serialization;

namespace dotnet_rpg.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgClass
    {
        Mesmer,
        Ranger,
        Guardian,
        Warrior,
        Necromancer,
        Elementalist,
        Revenant,
        Thief,
        Engineer
    }
}
