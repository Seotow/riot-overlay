using System;
using System.Text.Json.Serialization;

namespace Farsight.Web;

public class SubscriptionStatusResponse
{
	public string? Status { get; set; }

	public string? PlanId { get; set; }

	public string? Plan { get; set; }

	public string? Tier { get; set; }

	[JsonIgnore]
	public string? EffectivePlan => Plan ?? Tier;

	public DateTime? EndDate { get; set; }

	public string[]? Features { get; set; }
}
