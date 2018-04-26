// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.AzureStack.Management.Storage.Admin.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Storage farm.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Farm : Resource
    {
        /// <summary>
        /// Initializes a new instance of the Farm class.
        /// </summary>
        public Farm()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Farm class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="location">Resource location.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="farmId">Farm identifier.</param>
        /// <param name="version">Resource version.</param>
        /// <param name="settingsStore">The settings of storage farm.</param>
        /// <param name="settingsPollingIntervalInSecond">The polling interval
        /// (in second).</param>
        /// <param name="retentionPeriodForDeletedStorageAccountsInDays">The
        /// retention period (in days) for deleted storage account.</param>
        /// <param name="hostStyleHttpPort">Host style HTTP port.</param>
        /// <param name="hostStyleHttpsPort">Host style HTTPs port.</param>
        /// <param name="corsAllowedOriginsList">The list of allowed
        /// origins.</param>
        /// <param name="dataCenterUriHostSuffixes">The suffixes of URI of
        /// hosts in data center.</param>
        /// <param name="bandwidthThrottleIsEnabled">Switch of bandwidth
        /// throttle enablement.</param>
        /// <param name="usageCollectionIntervalInSeconds">Interval (in
        /// seconds) of storage usage collection.</param>
        /// <param name="feedbackRefreshIntervalInSeconds">Interval (in
        /// seconds) of feedback refresh.</param>
        /// <param name="numberOfAccountsToSync">Number of accounts to
        /// sync.</param>
        /// <param
        /// name="defaultThrottleProbabilityDecayIntervalInSeconds">Interval
        /// (in seconds) of default throttle probability decay.</param>
        /// <param name="gracePeriodForFullThrottlingInRefreshIntervals">Grace
        /// period for full throttling in refresh intervals.</param>
        /// <param name="gracePeriodMaxThrottleProbability">Maximum probability
        /// of throttle in grace period.</param>
        /// <param name="overallRequestThresholdInTps">Overall request
        /// threshold (in TPS).</param>
        /// <param name="defaultRequestThresholdInTps">Default request
        /// threshold (in TPS).</param>
        /// <param name="minimumRequestThresholdInTps">Minimum request
        /// threshold (in TPS).</param>
        /// <param name="toleranceFactorForTps">Tolerance factor for
        /// TPS.</param>
        /// <param name="overallIngressThresholdInGbps">Overall ingress
        /// threshold (in Gbps)</param>
        /// <param name="defaultIngressThresholdInGbps">Default ingress
        /// threshold (in Gbps).</param>
        /// <param name="minimumIngressThresholdInGbps">Minimum ingress
        /// threshold (in Gbps).</param>
        /// <param name="toleranceFactorForIngress">Tolerance factor for
        /// ingress.</param>
        /// <param name="overallIntranetIngressThresholdInGbps">Overall
        /// Intranet ingress threshold (in Gbps).</param>
        /// <param name="defaultIntranetIngressThresholdInGbps">Default
        /// Intranet ingress threshold (in Gbps).</param>
        /// <param name="minimumIntranetIngressThresholdInGbps">Minimum
        /// Intranet ingress threshold (in Gbps).</param>
        /// <param name="toleranceFactorForIntranetIngress">Tolerance factor
        /// for Intranet ingress.</param>
        /// <param name="overallEgressThresholdInGbps">Overall egress threshold
        /// (in Gbps).</param>
        /// <param name="defaultEgressThresholdInGbps">Default egress threshold
        /// (in Gbps).</param>
        /// <param name="minimumEgressThresholdInGbps">Minimum egress threshold
        /// (in Gbps).</param>
        /// <param name="toleranceFactorForEgress">Tolerance factor for
        /// egress.</param>
        /// <param name="overallIntranetEgressThresholdInGbps">Overall Intranet
        /// egress threshold (in Gbps).</param>
        /// <param name="defaultIntranetEgressThresholdInGbps">Default Intranet
        /// egress threshold (in Gbps).</param>
        /// <param name="minimumIntranetEgressThresholdInGbps">Minimum Intranet
        /// egress threshold (in Gbps).</param>
        /// <param name="toleranceFactorForIntranetEgress">Tolerance factor for
        /// Intranet egress.</param>
        /// <param name="overallTotalIngressThresholdInGbps">Overall total
        /// ingress threshold (in Gbps).</param>
        /// <param name="defaultTotalIngressThresholdInGbps">Default total
        /// ingress threshold (in Gbps).</param>
        /// <param name="minimumTotalIngressThresholdInGbps">Minimum total
        /// ingress threshold (in Gbps).</param>
        /// <param name="toleranceFactorForTotalIngress">Tolerance factor for
        /// total ingress.</param>
        /// <param name="overallTotalEgressThresholdInGbps">Overall total
        /// egress threshold (in Gbps).</param>
        /// <param name="defaultTotalEgressThresholdInGbps">Default total
        /// egress threshold (in Gbps).</param>
        /// <param name="minimumTotalEgressThresholdInGbps">Minimum total
        /// egress threshold (in Gbp</param>
        /// <param name="toleranceFactorForTotalEgress">Tolerance factor for
        /// total egress.</param>
        public Farm(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string farmId = default(string), string version = default(string), string settingsStore = default(string), int? settingsPollingIntervalInSecond = default(int?), int? retentionPeriodForDeletedStorageAccountsInDays = default(int?), int? hostStyleHttpPort = default(int?), int? hostStyleHttpsPort = default(int?), string corsAllowedOriginsList = default(string), string dataCenterUriHostSuffixes = default(string), bool? bandwidthThrottleIsEnabled = default(bool?), int? usageCollectionIntervalInSeconds = default(int?), int? feedbackRefreshIntervalInSeconds = default(int?), int? numberOfAccountsToSync = default(int?), int? defaultThrottleProbabilityDecayIntervalInSeconds = default(int?), int? gracePeriodForFullThrottlingInRefreshIntervals = default(int?), double? gracePeriodMaxThrottleProbability = default(double?), double? overallRequestThresholdInTps = default(double?), double? defaultRequestThresholdInTps = default(double?), double? minimumRequestThresholdInTps = default(double?), double? toleranceFactorForTps = default(double?), double? overallIngressThresholdInGbps = default(double?), double? defaultIngressThresholdInGbps = default(double?), double? minimumIngressThresholdInGbps = default(double?), double? toleranceFactorForIngress = default(double?), double? overallIntranetIngressThresholdInGbps = default(double?), double? defaultIntranetIngressThresholdInGbps = default(double?), double? minimumIntranetIngressThresholdInGbps = default(double?), double? toleranceFactorForIntranetIngress = default(double?), double? overallEgressThresholdInGbps = default(double?), double? defaultEgressThresholdInGbps = default(double?), double? minimumEgressThresholdInGbps = default(double?), double? toleranceFactorForEgress = default(double?), double? overallIntranetEgressThresholdInGbps = default(double?), double? defaultIntranetEgressThresholdInGbps = default(double?), double? minimumIntranetEgressThresholdInGbps = default(double?), double? toleranceFactorForIntranetEgress = default(double?), double? overallTotalIngressThresholdInGbps = default(double?), double? defaultTotalIngressThresholdInGbps = default(double?), double? minimumTotalIngressThresholdInGbps = default(double?), double? toleranceFactorForTotalIngress = default(double?), double? overallTotalEgressThresholdInGbps = default(double?), double? defaultTotalEgressThresholdInGbps = default(double?), double? minimumTotalEgressThresholdInGbps = default(double?), double? toleranceFactorForTotalEgress = default(double?))
            : base(id, name, type, location, tags)
        {
            FarmId = farmId;
            Version = version;
            SettingsStore = settingsStore;
            SettingsPollingIntervalInSecond = settingsPollingIntervalInSecond;
            RetentionPeriodForDeletedStorageAccountsInDays = retentionPeriodForDeletedStorageAccountsInDays;
            HostStyleHttpPort = hostStyleHttpPort;
            HostStyleHttpsPort = hostStyleHttpsPort;
            CorsAllowedOriginsList = corsAllowedOriginsList;
            DataCenterUriHostSuffixes = dataCenterUriHostSuffixes;
            BandwidthThrottleIsEnabled = bandwidthThrottleIsEnabled;
            UsageCollectionIntervalInSeconds = usageCollectionIntervalInSeconds;
            FeedbackRefreshIntervalInSeconds = feedbackRefreshIntervalInSeconds;
            NumberOfAccountsToSync = numberOfAccountsToSync;
            DefaultThrottleProbabilityDecayIntervalInSeconds = defaultThrottleProbabilityDecayIntervalInSeconds;
            GracePeriodForFullThrottlingInRefreshIntervals = gracePeriodForFullThrottlingInRefreshIntervals;
            GracePeriodMaxThrottleProbability = gracePeriodMaxThrottleProbability;
            OverallRequestThresholdInTps = overallRequestThresholdInTps;
            DefaultRequestThresholdInTps = defaultRequestThresholdInTps;
            MinimumRequestThresholdInTps = minimumRequestThresholdInTps;
            ToleranceFactorForTps = toleranceFactorForTps;
            OverallIngressThresholdInGbps = overallIngressThresholdInGbps;
            DefaultIngressThresholdInGbps = defaultIngressThresholdInGbps;
            MinimumIngressThresholdInGbps = minimumIngressThresholdInGbps;
            ToleranceFactorForIngress = toleranceFactorForIngress;
            OverallIntranetIngressThresholdInGbps = overallIntranetIngressThresholdInGbps;
            DefaultIntranetIngressThresholdInGbps = defaultIntranetIngressThresholdInGbps;
            MinimumIntranetIngressThresholdInGbps = minimumIntranetIngressThresholdInGbps;
            ToleranceFactorForIntranetIngress = toleranceFactorForIntranetIngress;
            OverallEgressThresholdInGbps = overallEgressThresholdInGbps;
            DefaultEgressThresholdInGbps = defaultEgressThresholdInGbps;
            MinimumEgressThresholdInGbps = minimumEgressThresholdInGbps;
            ToleranceFactorForEgress = toleranceFactorForEgress;
            OverallIntranetEgressThresholdInGbps = overallIntranetEgressThresholdInGbps;
            DefaultIntranetEgressThresholdInGbps = defaultIntranetEgressThresholdInGbps;
            MinimumIntranetEgressThresholdInGbps = minimumIntranetEgressThresholdInGbps;
            ToleranceFactorForIntranetEgress = toleranceFactorForIntranetEgress;
            OverallTotalIngressThresholdInGbps = overallTotalIngressThresholdInGbps;
            DefaultTotalIngressThresholdInGbps = defaultTotalIngressThresholdInGbps;
            MinimumTotalIngressThresholdInGbps = minimumTotalIngressThresholdInGbps;
            ToleranceFactorForTotalIngress = toleranceFactorForTotalIngress;
            OverallTotalEgressThresholdInGbps = overallTotalEgressThresholdInGbps;
            DefaultTotalEgressThresholdInGbps = defaultTotalEgressThresholdInGbps;
            MinimumTotalEgressThresholdInGbps = minimumTotalEgressThresholdInGbps;
            ToleranceFactorForTotalEgress = toleranceFactorForTotalEgress;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets farm identifier.
        /// </summary>
        [JsonProperty(PropertyName = "properties.farmId")]
        public string FarmId { get; private set; }

        /// <summary>
        /// Gets resource version.
        /// </summary>
        [JsonProperty(PropertyName = "properties.version")]
        public string Version { get; private set; }

        /// <summary>
        /// Gets the settings of storage farm.
        /// </summary>
        [JsonProperty(PropertyName = "properties.settingsStore")]
        public string SettingsStore { get; private set; }

        /// <summary>
        /// Gets the polling interval (in second).
        /// </summary>
        [JsonProperty(PropertyName = "properties.settings.settingsPollingIntervalInSecond")]
        public int? SettingsPollingIntervalInSecond { get; private set; }

        /// <summary>
        /// Gets the retention period (in days) for deleted storage account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.settings.retentionPeriodForDeletedStorageAccountsInDays")]
        public int? RetentionPeriodForDeletedStorageAccountsInDays { get; private set; }

        /// <summary>
        /// Gets host style HTTP port.
        /// </summary>
        [JsonProperty(PropertyName = "properties.settings.hostStyleHttpPort")]
        public int? HostStyleHttpPort { get; private set; }

        /// <summary>
        /// Gets host style HTTPs port.
        /// </summary>
        [JsonProperty(PropertyName = "properties.settings.hostStyleHttpsPort")]
        public int? HostStyleHttpsPort { get; private set; }

        /// <summary>
        /// Gets the list of allowed origins.
        /// </summary>
        [JsonProperty(PropertyName = "properties.settings.corsAllowedOriginsList")]
        public string CorsAllowedOriginsList { get; private set; }

        /// <summary>
        /// Gets the suffixes of URI of hosts in data center.
        /// </summary>
        [JsonProperty(PropertyName = "properties.settings.dataCenterUriHostSuffixes")]
        public string DataCenterUriHostSuffixes { get; private set; }

        /// <summary>
        /// Gets switch of bandwidth throttle enablement.
        /// </summary>
        [JsonProperty(PropertyName = "properties.settings.bandwidthThrottleIsEnabled")]
        public bool? BandwidthThrottleIsEnabled { get; private set; }

        /// <summary>
        /// Gets interval (in seconds) of storage usage collection.
        /// </summary>
        [JsonProperty(PropertyName = "properties.settings.usageCollectionIntervalInSeconds")]
        public int? UsageCollectionIntervalInSeconds { get; private set; }

        /// <summary>
        /// Gets interval (in seconds) of feedback refresh.
        /// </summary>
        [JsonProperty(PropertyName = "properties.settings.feedbackRefreshIntervalInSeconds")]
        public int? FeedbackRefreshIntervalInSeconds { get; private set; }

        /// <summary>
        /// Gets number of accounts to sync.
        /// </summary>
        [JsonProperty(PropertyName = "properties.settings.numberOfAccountsToSync")]
        public int? NumberOfAccountsToSync { get; private set; }

        /// <summary>
        /// Gets interval (in seconds) of default throttle probability decay.
        /// </summary>
        [JsonProperty(PropertyName = "properties.settings.defaultThrottleProbabilityDecayIntervalInSeconds")]
        public int? DefaultThrottleProbabilityDecayIntervalInSeconds { get; private set; }

        /// <summary>
        /// Gets grace period for full throttling in refresh intervals.
        /// </summary>
        [JsonProperty(PropertyName = "properties.settings.gracePeriodForFullThrottlingInRefreshIntervals")]
        public int? GracePeriodForFullThrottlingInRefreshIntervals { get; private set; }

        /// <summary>
        /// Gets maximum probability of throttle in grace period.
        /// </summary>
        [JsonProperty(PropertyName = "properties.settings.gracePeriodMaxThrottleProbability")]
        public double? GracePeriodMaxThrottleProbability { get; private set; }

        /// <summary>
        /// Gets overall request threshold (in TPS).
        /// </summary>
        [JsonProperty(PropertyName = "properties.settings.overallRequestThresholdInTps")]
        public double? OverallRequestThresholdInTps { get; private set; }

        /// <summary>
        /// Gets default request threshold (in TPS).
        /// </summary>
        [JsonProperty(PropertyName = "properties.settings.defaultRequestThresholdInTps")]
        public double? DefaultRequestThresholdInTps { get; private set; }

        /// <summary>
        /// Gets minimum request threshold (in TPS).
        /// </summary>
        [JsonProperty(PropertyName = "properties.settings.minimumRequestThresholdInTps")]
        public double? MinimumRequestThresholdInTps { get; private set; }

        /// <summary>
        /// Gets tolerance factor for TPS.
        /// </summary>
        [JsonProperty(PropertyName = "properties.settings.toleranceFactorForTps")]
        public double? ToleranceFactorForTps { get; private set; }

        /// <summary>
        /// Gets overall ingress threshold (in Gbps)
        /// </summary>
        [JsonProperty(PropertyName = "properties.settings.overallIngressThresholdInGbps")]
        public double? OverallIngressThresholdInGbps { get; private set; }

        /// <summary>
        /// Gets default ingress threshold (in Gbps).
        /// </summary>
        [JsonProperty(PropertyName = "properties.settings.defaultIngressThresholdInGbps")]
        public double? DefaultIngressThresholdInGbps { get; private set; }

        /// <summary>
        /// Gets minimum ingress threshold (in Gbps).
        /// </summary>
        [JsonProperty(PropertyName = "properties.settings.minimumIngressThresholdInGbps")]
        public double? MinimumIngressThresholdInGbps { get; private set; }

        /// <summary>
        /// Gets tolerance factor for ingress.
        /// </summary>
        [JsonProperty(PropertyName = "properties.settings.toleranceFactorForIngress")]
        public double? ToleranceFactorForIngress { get; private set; }

        /// <summary>
        /// Gets overall Intranet ingress threshold (in Gbps).
        /// </summary>
        [JsonProperty(PropertyName = "properties.settings.overallIntranetIngressThresholdInGbps")]
        public double? OverallIntranetIngressThresholdInGbps { get; private set; }

        /// <summary>
        /// Gets default Intranet ingress threshold (in Gbps).
        /// </summary>
        [JsonProperty(PropertyName = "properties.settings.defaultIntranetIngressThresholdInGbps")]
        public double? DefaultIntranetIngressThresholdInGbps { get; private set; }

        /// <summary>
        /// Gets minimum Intranet ingress threshold (in Gbps).
        /// </summary>
        [JsonProperty(PropertyName = "properties.settings.minimumIntranetIngressThresholdInGbps")]
        public double? MinimumIntranetIngressThresholdInGbps { get; private set; }

        /// <summary>
        /// Gets tolerance factor for Intranet ingress.
        /// </summary>
        [JsonProperty(PropertyName = "properties.settings.toleranceFactorForIntranetIngress")]
        public double? ToleranceFactorForIntranetIngress { get; private set; }

        /// <summary>
        /// Gets overall egress threshold (in Gbps).
        /// </summary>
        [JsonProperty(PropertyName = "properties.settings.overallEgressThresholdInGbps")]
        public double? OverallEgressThresholdInGbps { get; private set; }

        /// <summary>
        /// Gets default egress threshold (in Gbps).
        /// </summary>
        [JsonProperty(PropertyName = "properties.settings.defaultEgressThresholdInGbps")]
        public double? DefaultEgressThresholdInGbps { get; private set; }

        /// <summary>
        /// Gets minimum egress threshold (in Gbps).
        /// </summary>
        [JsonProperty(PropertyName = "properties.settings.minimumEgressThresholdInGbps")]
        public double? MinimumEgressThresholdInGbps { get; private set; }

        /// <summary>
        /// Gets tolerance factor for egress.
        /// </summary>
        [JsonProperty(PropertyName = "properties.settings.toleranceFactorForEgress")]
        public double? ToleranceFactorForEgress { get; private set; }

        /// <summary>
        /// Gets overall Intranet egress threshold (in Gbps).
        /// </summary>
        [JsonProperty(PropertyName = "properties.settings.overallIntranetEgressThresholdInGbps")]
        public double? OverallIntranetEgressThresholdInGbps { get; private set; }

        /// <summary>
        /// Gets default Intranet egress threshold (in Gbps).
        /// </summary>
        [JsonProperty(PropertyName = "properties.settings.defaultIntranetEgressThresholdInGbps")]
        public double? DefaultIntranetEgressThresholdInGbps { get; private set; }

        /// <summary>
        /// Gets minimum Intranet egress threshold (in Gbps).
        /// </summary>
        [JsonProperty(PropertyName = "properties.settings.minimumIntranetEgressThresholdInGbps")]
        public double? MinimumIntranetEgressThresholdInGbps { get; private set; }

        /// <summary>
        /// Gets tolerance factor for Intranet egress.
        /// </summary>
        [JsonProperty(PropertyName = "properties.settings.toleranceFactorForIntranetEgress")]
        public double? ToleranceFactorForIntranetEgress { get; private set; }

        /// <summary>
        /// Gets overall total ingress threshold (in Gbps).
        /// </summary>
        [JsonProperty(PropertyName = "properties.settings.overallTotalIngressThresholdInGbps")]
        public double? OverallTotalIngressThresholdInGbps { get; private set; }

        /// <summary>
        /// Gets default total ingress threshold (in Gbps).
        /// </summary>
        [JsonProperty(PropertyName = "properties.settings.defaultTotalIngressThresholdInGbps")]
        public double? DefaultTotalIngressThresholdInGbps { get; private set; }

        /// <summary>
        /// Gets minimum total ingress threshold (in Gbps).
        /// </summary>
        [JsonProperty(PropertyName = "properties.settings.minimumTotalIngressThresholdInGbps")]
        public double? MinimumTotalIngressThresholdInGbps { get; private set; }

        /// <summary>
        /// Gets tolerance factor for total ingress.
        /// </summary>
        [JsonProperty(PropertyName = "properties.settings.toleranceFactorForTotalIngress")]
        public double? ToleranceFactorForTotalIngress { get; private set; }

        /// <summary>
        /// Gets overall total egress threshold (in Gbps).
        /// </summary>
        [JsonProperty(PropertyName = "properties.settings.overallTotalEgressThresholdInGbps")]
        public double? OverallTotalEgressThresholdInGbps { get; private set; }

        /// <summary>
        /// Gets default total egress threshold (in Gbps).
        /// </summary>
        [JsonProperty(PropertyName = "properties.settings.defaultTotalEgressThresholdInGbps")]
        public double? DefaultTotalEgressThresholdInGbps { get; private set; }

        /// <summary>
        /// Gets minimum total egress threshold (in Gbp
        /// </summary>
        [JsonProperty(PropertyName = "properties.settings.minimumTotalEgressThresholdInGbps")]
        public double? MinimumTotalEgressThresholdInGbps { get; private set; }

        /// <summary>
        /// Gets tolerance factor for total egress.
        /// </summary>
        [JsonProperty(PropertyName = "properties.settings.toleranceFactorForTotalEgress")]
        public double? ToleranceFactorForTotalEgress { get; private set; }

    }
}