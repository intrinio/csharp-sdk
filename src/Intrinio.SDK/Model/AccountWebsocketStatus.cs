

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Intrinio.SDK.Client.SwaggerDateConverter;

namespace Intrinio.SDK.Model
{
    /// <summary>
    /// The websocket status summary for a connection.
    /// </summary>
    [DataContract]
    public partial class AccountWebsocketStatus :  IEquatable<AccountWebsocketStatus>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountWebsocketStatus" /> class.
        /// </summary>
        /// <param name="Feed">The feed name for the connection..</param>
        /// <param name="FeedConnectionNumber">The connection number for this account within a feed..</param>
        /// <param name="Ip">The IP address detected for the client connection..</param>
        /// <param name="ConnectedOn">The UTC time this client connection connected to the server..</param>
        /// <param name="StatusUpdatedOn">The UTC time the server updated this client connection status data..</param>
        /// <param name="IsDelayed">Whether this connection is delayed an extra 15 minutes from the source. Note that the Delayed SIP source is already delayed, so this value will be false for those connections..</param>
        /// <param name="IsFirehose">The client connection is in firehose mode (all channels subscribed)..</param>
        /// <param name="TradeSubscriptions">The count of channel subscriptions for trade events..</param>
        /// <param name="QuoteSubscriptions">The count of channel subscriptions for ask and bid events..</param>
        /// <param name="RefreshSubscriptions">The count of channel subscriptions for refresh events (OPRA options feed only)..</param>
        /// <param name="UnusualActivitySubscriptions">The count of channel subscriptions for unusual activity events (OPRA options feed only)..</param>
        /// <param name="PacketsPerSecond">The packets per second sent since the last status update..</param>
        /// <param name="TotalPacketsSent">The total packets sent since the beginning of this connection.  A packet is a group of events sent as one message over the websocket..</param>
        /// <param name="EventsPerSecond">The events per second sent since the last status update..</param>
        /// <param name="TotalEvents">The total events sent to this connection&#39;s server-side queue since the beginning of this connection.  An event is an individual occurrence of a trade, quote, etc..</param>
        /// <param name="TotalSentEvents">The total events sent to the client inside packets. A packet is a group of events sent as one message over the websocket..</param>
        /// <param name="TotalDrops">The total number of events dropped from the connection&#39;s server-side queue.  Event drops happen when the connection&#39;s server-side queue is full. The server-side queue fills due to client-side connections not receiving packets fast enough, which can be caused by a slow network, or clients not decoupling processing of packets from the receipt of packets..</param>
        /// <param name="QueueDepthPercentage">The percentage that the connection&#39;s server-side queue is full. 0-100..</param>
        public AccountWebsocketStatus(string Feed = default(string), int? FeedConnectionNumber = default(int?), string Ip = default(string), DateTime? ConnectedOn = default(DateTime?), DateTime? StatusUpdatedOn = default(DateTime?), bool? IsDelayed = default(bool?), bool? IsFirehose = default(bool?), int? TradeSubscriptions = default(int?), int? QuoteSubscriptions = default(int?), int? RefreshSubscriptions = default(int?), int? UnusualActivitySubscriptions = default(int?), decimal? PacketsPerSecond = default(decimal?), string TotalPacketsSent = default(string), decimal? EventsPerSecond = default(decimal?), string TotalEvents = default(string), string TotalSentEvents = default(string), string TotalDrops = default(string), decimal? QueueDepthPercentage = default(decimal?))
        {
            this.Feed = Feed;
            this.FeedConnectionNumber = FeedConnectionNumber;
            this.Ip = Ip;
            this.ConnectedOn = ConnectedOn;
            this.StatusUpdatedOn = StatusUpdatedOn;
            this.IsDelayed = IsDelayed;
            this.IsFirehose = IsFirehose;
            this.TradeSubscriptions = TradeSubscriptions;
            this.QuoteSubscriptions = QuoteSubscriptions;
            this.RefreshSubscriptions = RefreshSubscriptions;
            this.UnusualActivitySubscriptions = UnusualActivitySubscriptions;
            this.PacketsPerSecond = PacketsPerSecond;
            this.TotalPacketsSent = TotalPacketsSent;
            this.EventsPerSecond = EventsPerSecond;
            this.TotalEvents = TotalEvents;
            this.TotalSentEvents = TotalSentEvents;
            this.TotalDrops = TotalDrops;
            this.QueueDepthPercentage = QueueDepthPercentage;
        }
        
        /// <summary>
        /// The feed name for the connection.
        /// </summary>
        /// <value>The feed name for the connection.</value>
        [DataMember(Name="feed", EmitDefaultValue=false)]
        public string Feed { get; set; }

        /// <summary>
        /// The connection number for this account within a feed.
        /// </summary>
        /// <value>The connection number for this account within a feed.</value>
        [DataMember(Name="feed_connection_number", EmitDefaultValue=false)]
        public int? FeedConnectionNumber { get; set; }

        /// <summary>
        /// The IP address detected for the client connection.
        /// </summary>
        /// <value>The IP address detected for the client connection.</value>
        [DataMember(Name="ip", EmitDefaultValue=false)]
        public string Ip { get; set; }

        /// <summary>
        /// The UTC time this client connection connected to the server.
        /// </summary>
        /// <value>The UTC time this client connection connected to the server.</value>
        [DataMember(Name="connected_on", EmitDefaultValue=false)]
        public DateTime? ConnectedOn { get; set; }

        /// <summary>
        /// The UTC time the server updated this client connection status data.
        /// </summary>
        /// <value>The UTC time the server updated this client connection status data.</value>
        [DataMember(Name="status_updated_on", EmitDefaultValue=false)]
        public DateTime? StatusUpdatedOn { get; set; }

        /// <summary>
        /// Whether this connection is delayed an extra 15 minutes from the source. Note that the Delayed SIP source is already delayed, so this value will be false for those connections.
        /// </summary>
        /// <value>Whether this connection is delayed an extra 15 minutes from the source. Note that the Delayed SIP source is already delayed, so this value will be false for those connections.</value>
        [DataMember(Name="is_delayed", EmitDefaultValue=false)]
        public bool? IsDelayed { get; set; }

        /// <summary>
        /// The client connection is in firehose mode (all channels subscribed).
        /// </summary>
        /// <value>The client connection is in firehose mode (all channels subscribed).</value>
        [DataMember(Name="is_firehose", EmitDefaultValue=false)]
        public bool? IsFirehose { get; set; }

        /// <summary>
        /// The count of channel subscriptions for trade events.
        /// </summary>
        /// <value>The count of channel subscriptions for trade events.</value>
        [DataMember(Name="trade_subscriptions", EmitDefaultValue=false)]
        public int? TradeSubscriptions { get; set; }

        /// <summary>
        /// The count of channel subscriptions for ask and bid events.
        /// </summary>
        /// <value>The count of channel subscriptions for ask and bid events.</value>
        [DataMember(Name="quote_subscriptions", EmitDefaultValue=false)]
        public int? QuoteSubscriptions { get; set; }

        /// <summary>
        /// The count of channel subscriptions for refresh events (OPRA options feed only).
        /// </summary>
        /// <value>The count of channel subscriptions for refresh events (OPRA options feed only).</value>
        [DataMember(Name="refresh_subscriptions", EmitDefaultValue=false)]
        public int? RefreshSubscriptions { get; set; }

        /// <summary>
        /// The count of channel subscriptions for unusual activity events (OPRA options feed only).
        /// </summary>
        /// <value>The count of channel subscriptions for unusual activity events (OPRA options feed only).</value>
        [DataMember(Name="unusual_activity_subscriptions", EmitDefaultValue=false)]
        public int? UnusualActivitySubscriptions { get; set; }

        /// <summary>
        /// The packets per second sent since the last status update.
        /// </summary>
        /// <value>The packets per second sent since the last status update.</value>
        [DataMember(Name="packets_per_second", EmitDefaultValue=false)]
        public decimal? PacketsPerSecond { get; set; }

        /// <summary>
        /// The total packets sent since the beginning of this connection.  A packet is a group of events sent as one message over the websocket.
        /// </summary>
        /// <value>The total packets sent since the beginning of this connection.  A packet is a group of events sent as one message over the websocket.</value>
        [DataMember(Name="total_packets_sent", EmitDefaultValue=false)]
        public string TotalPacketsSent { get; set; }

        /// <summary>
        /// The events per second sent since the last status update.
        /// </summary>
        /// <value>The events per second sent since the last status update.</value>
        [DataMember(Name="events_per_second", EmitDefaultValue=false)]
        public decimal? EventsPerSecond { get; set; }

        /// <summary>
        /// The total events sent to this connection&#39;s server-side queue since the beginning of this connection.  An event is an individual occurrence of a trade, quote, etc.
        /// </summary>
        /// <value>The total events sent to this connection&#39;s server-side queue since the beginning of this connection.  An event is an individual occurrence of a trade, quote, etc.</value>
        [DataMember(Name="total_events", EmitDefaultValue=false)]
        public string TotalEvents { get; set; }

        /// <summary>
        /// The total events sent to the client inside packets. A packet is a group of events sent as one message over the websocket.
        /// </summary>
        /// <value>The total events sent to the client inside packets. A packet is a group of events sent as one message over the websocket.</value>
        [DataMember(Name="total_sent_events", EmitDefaultValue=false)]
        public string TotalSentEvents { get; set; }

        /// <summary>
        /// The total number of events dropped from the connection&#39;s server-side queue.  Event drops happen when the connection&#39;s server-side queue is full. The server-side queue fills due to client-side connections not receiving packets fast enough, which can be caused by a slow network, or clients not decoupling processing of packets from the receipt of packets.
        /// </summary>
        /// <value>The total number of events dropped from the connection&#39;s server-side queue.  Event drops happen when the connection&#39;s server-side queue is full. The server-side queue fills due to client-side connections not receiving packets fast enough, which can be caused by a slow network, or clients not decoupling processing of packets from the receipt of packets.</value>
        [DataMember(Name="total_drops", EmitDefaultValue=false)]
        public string TotalDrops { get; set; }

        /// <summary>
        /// The percentage that the connection&#39;s server-side queue is full. 0-100.
        /// </summary>
        /// <value>The percentage that the connection&#39;s server-side queue is full. 0-100.</value>
        [DataMember(Name="queue_depth_percentage", EmitDefaultValue=false)]
        public decimal? QueueDepthPercentage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountWebsocketStatus {\n");
            sb.Append("  Feed: ").Append(Feed).Append("\n");
            sb.Append("  FeedConnectionNumber: ").Append(FeedConnectionNumber).Append("\n");
            sb.Append("  Ip: ").Append(Ip).Append("\n");
            sb.Append("  ConnectedOn: ").Append(ConnectedOn).Append("\n");
            sb.Append("  StatusUpdatedOn: ").Append(StatusUpdatedOn).Append("\n");
            sb.Append("  IsDelayed: ").Append(IsDelayed).Append("\n");
            sb.Append("  IsFirehose: ").Append(IsFirehose).Append("\n");
            sb.Append("  TradeSubscriptions: ").Append(TradeSubscriptions).Append("\n");
            sb.Append("  QuoteSubscriptions: ").Append(QuoteSubscriptions).Append("\n");
            sb.Append("  RefreshSubscriptions: ").Append(RefreshSubscriptions).Append("\n");
            sb.Append("  UnusualActivitySubscriptions: ").Append(UnusualActivitySubscriptions).Append("\n");
            sb.Append("  PacketsPerSecond: ").Append(PacketsPerSecond).Append("\n");
            sb.Append("  TotalPacketsSent: ").Append(TotalPacketsSent).Append("\n");
            sb.Append("  EventsPerSecond: ").Append(EventsPerSecond).Append("\n");
            sb.Append("  TotalEvents: ").Append(TotalEvents).Append("\n");
            sb.Append("  TotalSentEvents: ").Append(TotalSentEvents).Append("\n");
            sb.Append("  TotalDrops: ").Append(TotalDrops).Append("\n");
            sb.Append("  QueueDepthPercentage: ").Append(QueueDepthPercentage).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AccountWebsocketStatus);
        }

        /// <summary>
        /// Returns true if AccountWebsocketStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountWebsocketStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountWebsocketStatus input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Feed == input.Feed ||
                    (this.Feed != null &&
                    this.Feed.Equals(input.Feed))
                ) && 
                (
                    this.FeedConnectionNumber == input.FeedConnectionNumber ||
                    (this.FeedConnectionNumber != null &&
                    this.FeedConnectionNumber.Equals(input.FeedConnectionNumber))
                ) && 
                (
                    this.Ip == input.Ip ||
                    (this.Ip != null &&
                    this.Ip.Equals(input.Ip))
                ) && 
                (
                    this.ConnectedOn == input.ConnectedOn ||
                    (this.ConnectedOn != null &&
                    this.ConnectedOn.Equals(input.ConnectedOn))
                ) && 
                (
                    this.StatusUpdatedOn == input.StatusUpdatedOn ||
                    (this.StatusUpdatedOn != null &&
                    this.StatusUpdatedOn.Equals(input.StatusUpdatedOn))
                ) && 
                (
                    this.IsDelayed == input.IsDelayed ||
                    (this.IsDelayed != null &&
                    this.IsDelayed.Equals(input.IsDelayed))
                ) && 
                (
                    this.IsFirehose == input.IsFirehose ||
                    (this.IsFirehose != null &&
                    this.IsFirehose.Equals(input.IsFirehose))
                ) && 
                (
                    this.TradeSubscriptions == input.TradeSubscriptions ||
                    (this.TradeSubscriptions != null &&
                    this.TradeSubscriptions.Equals(input.TradeSubscriptions))
                ) && 
                (
                    this.QuoteSubscriptions == input.QuoteSubscriptions ||
                    (this.QuoteSubscriptions != null &&
                    this.QuoteSubscriptions.Equals(input.QuoteSubscriptions))
                ) && 
                (
                    this.RefreshSubscriptions == input.RefreshSubscriptions ||
                    (this.RefreshSubscriptions != null &&
                    this.RefreshSubscriptions.Equals(input.RefreshSubscriptions))
                ) && 
                (
                    this.UnusualActivitySubscriptions == input.UnusualActivitySubscriptions ||
                    (this.UnusualActivitySubscriptions != null &&
                    this.UnusualActivitySubscriptions.Equals(input.UnusualActivitySubscriptions))
                ) && 
                (
                    this.PacketsPerSecond == input.PacketsPerSecond ||
                    (this.PacketsPerSecond != null &&
                    this.PacketsPerSecond.Equals(input.PacketsPerSecond))
                ) && 
                (
                    this.TotalPacketsSent == input.TotalPacketsSent ||
                    (this.TotalPacketsSent != null &&
                    this.TotalPacketsSent.Equals(input.TotalPacketsSent))
                ) && 
                (
                    this.EventsPerSecond == input.EventsPerSecond ||
                    (this.EventsPerSecond != null &&
                    this.EventsPerSecond.Equals(input.EventsPerSecond))
                ) && 
                (
                    this.TotalEvents == input.TotalEvents ||
                    (this.TotalEvents != null &&
                    this.TotalEvents.Equals(input.TotalEvents))
                ) && 
                (
                    this.TotalSentEvents == input.TotalSentEvents ||
                    (this.TotalSentEvents != null &&
                    this.TotalSentEvents.Equals(input.TotalSentEvents))
                ) && 
                (
                    this.TotalDrops == input.TotalDrops ||
                    (this.TotalDrops != null &&
                    this.TotalDrops.Equals(input.TotalDrops))
                ) && 
                (
                    this.QueueDepthPercentage == input.QueueDepthPercentage ||
                    (this.QueueDepthPercentage != null &&
                    this.QueueDepthPercentage.Equals(input.QueueDepthPercentage))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Feed != null)
                    hashCode = hashCode * 59 + this.Feed.GetHashCode();
                if (this.FeedConnectionNumber != null)
                    hashCode = hashCode * 59 + this.FeedConnectionNumber.GetHashCode();
                if (this.Ip != null)
                    hashCode = hashCode * 59 + this.Ip.GetHashCode();
                if (this.ConnectedOn != null)
                    hashCode = hashCode * 59 + this.ConnectedOn.GetHashCode();
                if (this.StatusUpdatedOn != null)
                    hashCode = hashCode * 59 + this.StatusUpdatedOn.GetHashCode();
                if (this.IsDelayed != null)
                    hashCode = hashCode * 59 + this.IsDelayed.GetHashCode();
                if (this.IsFirehose != null)
                    hashCode = hashCode * 59 + this.IsFirehose.GetHashCode();
                if (this.TradeSubscriptions != null)
                    hashCode = hashCode * 59 + this.TradeSubscriptions.GetHashCode();
                if (this.QuoteSubscriptions != null)
                    hashCode = hashCode * 59 + this.QuoteSubscriptions.GetHashCode();
                if (this.RefreshSubscriptions != null)
                    hashCode = hashCode * 59 + this.RefreshSubscriptions.GetHashCode();
                if (this.UnusualActivitySubscriptions != null)
                    hashCode = hashCode * 59 + this.UnusualActivitySubscriptions.GetHashCode();
                if (this.PacketsPerSecond != null)
                    hashCode = hashCode * 59 + this.PacketsPerSecond.GetHashCode();
                if (this.TotalPacketsSent != null)
                    hashCode = hashCode * 59 + this.TotalPacketsSent.GetHashCode();
                if (this.EventsPerSecond != null)
                    hashCode = hashCode * 59 + this.EventsPerSecond.GetHashCode();
                if (this.TotalEvents != null)
                    hashCode = hashCode * 59 + this.TotalEvents.GetHashCode();
                if (this.TotalSentEvents != null)
                    hashCode = hashCode * 59 + this.TotalSentEvents.GetHashCode();
                if (this.TotalDrops != null)
                    hashCode = hashCode * 59 + this.TotalDrops.GetHashCode();
                if (this.QueueDepthPercentage != null)
                    hashCode = hashCode * 59 + this.QueueDepthPercentage.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
