namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class PlanUpdateOptions : BaseOptions, IHasMetadata
    {
        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("nickname")]
        public string Nickname { get; set; }

        [JsonProperty("product")]
        public string Product { get; set; }

        [JsonProperty("trial_period_days")]
        public long TrialPeriodDays { get; set; }
    }
}
