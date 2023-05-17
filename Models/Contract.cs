using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

public class Contract {
    public Guid Id { get; set; }
    public Guid CustomerId { get; set; }
    public Guid[] ClaimIds { get; set; }
    public string Cover { get; set; }

    [JsonConverter(typeof(StringEnumConverter))]
    public ContractStatus Status { get; set; }
}

public enum ContractStatus
{
    Active,
    Inactive
}