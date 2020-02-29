namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SubscriptionItemCreateOptions : BaseOptions, IHasMetadata
    {
        [JsonProperty("billing_thresholds")]
        public emptyStringable BillingThresholds { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("payment_behavior")]
        public string PaymentBehavior { get; set; }

        [JsonProperty("plan")]
        public string Plan { get; set; }

        [JsonProperty("prorate")]
        public bool Prorate { get; set; }

        [JsonProperty("proration_behavior")]
        public string ProrationBehavior { get; set; }

        [JsonProperty("proration_date")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime ProrationDate { get; set; }

        [JsonProperty("quantity")]
        public long Quantity { get; set; }

        [JsonProperty("subscription")]
        public string Subscription { get; set; }

        [JsonProperty("tax_rates")]
        public emptyStringable TaxRates { get; set; }
    }
}
