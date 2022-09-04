using System.ComponentModel.DataAnnotations;
using Vorn.Hub.EntityHub;
namespace Vorn.Caas;
[EntityHubTracable]
public class Sms : IEntityHubTracable
{
    [Key]
    public int Id { get; set; }
    public string? Text { get; set; }
    public string? Status { get; set; }
    public long MessageId { get; set; }
    public string? LineNumber { get; set; }
    public string? PhoneNumber { get; set; }
    public int StatusCode { get; set; }
    public bool IsDelivered { get; set; }
    public DateTime SendDateTime { get; set; }
    public DateTime DeliveryDateTime { get; set; }
    public bool Incoming { get; set; }
}
