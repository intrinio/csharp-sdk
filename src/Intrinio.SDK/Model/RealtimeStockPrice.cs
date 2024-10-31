

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
    /// The realtime stock price of a security.
    /// </summary>
    [DataContract]
    public partial class RealtimeStockPrice :  IEquatable<RealtimeStockPrice>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeStockPrice" /> class.
        /// </summary>
        /// <param name="LastPrice">The price of the last trade..</param>
        /// <param name="LastTime">The date and time when the last trade occurred..</param>
        /// <param name="LastSize">The size of the last trade..</param>
        /// <param name="BidPrice">The price of the top bid order..</param>
        /// <param name="BidSize">The size of the top bid order..</param>
        /// <param name="BidTime">The date and time when the last bid occurred..</param>
        /// <param name="AskPrice">The price of the top ask order..</param>
        /// <param name="AskSize">The size of the top ask order..</param>
        /// <param name="AskTime">The date and time when the last ask occurred..</param>
        /// <param name="OpenPrice">The price at the open of the trading day..</param>
        /// <param name="ClosePrice">The price at the close of the trading day. (IEX only).</param>
        /// <param name="HighPrice">The high price for the trading day..</param>
        /// <param name="LowPrice">The low price for the trading day..</param>
        /// <param name="ExchangeVolume">The number of shares exchanged during the trading day on the exchange..</param>
        /// <param name="MarketVolume">The number of shares exchanged during the trading day for the whole market..</param>
        /// <param name="UpdatedOn">The date and time when the data was last updated..</param>
        /// <param name="EodClosePrice">The previous trading session&#39;s closing price..</param>
        /// <param name="EodCloseDate">The date of the previous trading session&#39;s closing price..</param>
        /// <param name="NormalMarketHoursLastTime">The date and time of the last trade that qualifies for last price consideration during normal market hours according to exchange rules on trade conditions..</param>
        /// <param name="NormalMarketHoursLastPrice">The price of the last that qualifies for last price consideration during normal market hours according to exchange rules on trade conditions..</param>
        /// <param name="NormalMarketHoursLastSize">The size of the last trade that qualifies for last price consideration during normal market hours according to exchange rules on trade conditions..</param>
        /// <param name="QualifiedLastPrice">The price of the last trade that qualifies for last price consideration according to exchange rules on trade conditions..</param>
        /// <param name="QualifiedLastTime">The date and time of the last trade that qualifies for last price consideration according to exchange rules on trade conditions..</param>
        /// <param name="QualifiedLastSize">The size of the last trade that qualifies for last price consideration according to exchange rules on trade conditions..</param>
        /// <param name="Source">The source of the data..</param>
        /// <param name="ListingVenue">The listing venue where the trade took place. Available only where source is SIP. Listing Venue Modifiers include: Q – Nasdaq | N – NYSE | A – NYSE American | P – NYSE Arca | u – Other OTC Markets | V – Investors Exchange LLC .</param>
        /// <param name="SalesConditions">When applicable, indicates any sales condition modifiers associated with the trade. Sales Condition Modifers include: @ – Regular Sale | A – Acquisition | B – Bunched Trade | C – Cash Sale | D – Distribution | E – Placeholder | F – Intermarket Sweep | G – Bunched Sold Trade  | H – Priced Variation Trade | I – Odd Lot Trade | K – Rule 155 Trade (AMEX) | L – Sold Last | M – Market Center Official Close | N – Next Day | O – Opening Prints  | P – Prior Reference Price | Q – Market Center Official Open | R – Seller | S – Split Trade | T – Form T | U – Extended Trading Hours (Sold Out of Sequence)  | V – Contingent Trade | W – Average Price Trade | X – Cross/Periodic Auction Trade | Y – Yellow Flag Regular Trade | Z – Sold (Out of Sequence)  | 1 – Stopped Stock (Regular Trade) | 4 – Derivatively Priced | 5 – Re-Opening Prints | 6 – Closing Prints | 7 – Qualified Contingent Trade (QCT)  | 8 – Placeholder for 611 Exempt | 9 – Corrected Consolidated Close (Per Listing Market) .</param>
        /// <param name="QuoteConditions">When applicable, indicates any quote condition modifiers associated with the trade. Quote Condition Modifiers include: R – Regular | A – Slow on Ask | – Slow on Bid | C – Closing | D – News Dissemination | F – Slow on ASK (LRP or Gap Quote)  | E – Slow on Bid (LRP or Gap Quote) | G – Trading Range Indication | H – Slow on Bid and Ask | I – Order Imbalance  |  J – Due to Related - News Dissemination | K – Due to Related - News Pending | O – Open | L – Closed  | M – Volatility Trading Pause | N – Non-Firm Quote | O – Opening | P – News Pending | S – Due to Related  | T – Resume | U – Slow on Bid and Ask (LRP or Gap Quote) | V – In View of Common | W – Slow on Bid and Ask (LRP or Gap Quote)  | X – Equipment Changeover | Y – Sub-Penny Trading | Z – No Open / No Resume | F – Fast Trading | U – Slow on Bid and Ask (Non-Firm)  | One-Sided – One-Sided | X – Order Influx | 0 – Special Opening Quote | Halted – Halted | Benchmark – Benchmark | Implied – Implied  | Exchange Best – Exchange Best | 1 – Market Wide Circuit Breaker Level 1 | 2 – Market Wide Circuit Breaker Level 2  | 3 – Market Wide Circuit Breaker Level 3 | Rotation – Rotation | Auto Exec Eligible – Auto Exec Eligible | Bid Side Firm – Bid Side Firm  | Ask Side Firm – Ask Side Firm | 4 – On Demand Intraday Auction | I – Indicative Value (OPRA) | 45 – Additional Information Required (CTS)  | 46 – Regulatory Concern (CTS) | 47 – Merger Effective | 49 – Corporate Action (CTS) | 50 – New Security Offering (CTS)  | 51 – Intraday Indicative Value Unavailable (CTS) .</param>
        /// <param name="MarketCenterCode">The market center character code..</param>
        /// <param name="IsDarkpool">Whether or not the current trade is from a darkpool or not..</param>
        /// <param name="Security">Security.</param>
        public RealtimeStockPrice(decimal? LastPrice = default(decimal?), DateTime? LastTime = default(DateTime?), decimal? LastSize = default(decimal?), decimal? BidPrice = default(decimal?), decimal? BidSize = default(decimal?), DateTime? BidTime = default(DateTime?), decimal? AskPrice = default(decimal?), decimal? AskSize = default(decimal?), DateTime? AskTime = default(DateTime?), decimal? OpenPrice = default(decimal?), decimal? ClosePrice = default(decimal?), decimal? HighPrice = default(decimal?), decimal? LowPrice = default(decimal?), decimal? ExchangeVolume = default(decimal?), decimal? MarketVolume = default(decimal?), DateTime? UpdatedOn = default(DateTime?), decimal? EodClosePrice = default(decimal?), DateTime? EodCloseDate = default(DateTime?), DateTime? NormalMarketHoursLastTime = default(DateTime?), decimal? NormalMarketHoursLastPrice = default(decimal?), decimal? NormalMarketHoursLastSize = default(decimal?), decimal? QualifiedLastPrice = default(decimal?), DateTime? QualifiedLastTime = default(DateTime?), decimal? QualifiedLastSize = default(decimal?), string Source = default(string), string ListingVenue = default(string), string SalesConditions = default(string), string QuoteConditions = default(string), string MarketCenterCode = default(string), bool? IsDarkpool = default(bool?), RealtimeStockPriceSecurity Security = default(RealtimeStockPriceSecurity))
        {
            this.LastPrice = LastPrice;
            this.LastTime = LastTime;
            this.LastSize = LastSize;
            this.BidPrice = BidPrice;
            this.BidSize = BidSize;
            this.BidTime = BidTime;
            this.AskPrice = AskPrice;
            this.AskSize = AskSize;
            this.AskTime = AskTime;
            this.OpenPrice = OpenPrice;
            this.ClosePrice = ClosePrice;
            this.HighPrice = HighPrice;
            this.LowPrice = LowPrice;
            this.ExchangeVolume = ExchangeVolume;
            this.MarketVolume = MarketVolume;
            this.UpdatedOn = UpdatedOn;
            this.EodClosePrice = EodClosePrice;
            this.EodCloseDate = EodCloseDate;
            this.NormalMarketHoursLastTime = NormalMarketHoursLastTime;
            this.NormalMarketHoursLastPrice = NormalMarketHoursLastPrice;
            this.NormalMarketHoursLastSize = NormalMarketHoursLastSize;
            this.QualifiedLastPrice = QualifiedLastPrice;
            this.QualifiedLastTime = QualifiedLastTime;
            this.QualifiedLastSize = QualifiedLastSize;
            this.Source = Source;
            this.ListingVenue = ListingVenue;
            this.SalesConditions = SalesConditions;
            this.QuoteConditions = QuoteConditions;
            this.MarketCenterCode = MarketCenterCode;
            this.IsDarkpool = IsDarkpool;
            this.Security = Security;
        }
        
        /// <summary>
        /// The price of the last trade.
        /// </summary>
        /// <value>The price of the last trade.</value>
        [DataMember(Name="last_price", EmitDefaultValue=false)]
        public decimal? LastPrice { get; set; }

        /// <summary>
        /// The date and time when the last trade occurred.
        /// </summary>
        /// <value>The date and time when the last trade occurred.</value>
        [DataMember(Name="last_time", EmitDefaultValue=false)]
        public DateTime? LastTime { get; set; }

        /// <summary>
        /// The size of the last trade.
        /// </summary>
        /// <value>The size of the last trade.</value>
        [DataMember(Name="last_size", EmitDefaultValue=false)]
        public decimal? LastSize { get; set; }

        /// <summary>
        /// The price of the top bid order.
        /// </summary>
        /// <value>The price of the top bid order.</value>
        [DataMember(Name="bid_price", EmitDefaultValue=false)]
        public decimal? BidPrice { get; set; }

        /// <summary>
        /// The size of the top bid order.
        /// </summary>
        /// <value>The size of the top bid order.</value>
        [DataMember(Name="bid_size", EmitDefaultValue=false)]
        public decimal? BidSize { get; set; }

        /// <summary>
        /// The date and time when the last bid occurred.
        /// </summary>
        /// <value>The date and time when the last bid occurred.</value>
        [DataMember(Name="bid_time", EmitDefaultValue=false)]
        public DateTime? BidTime { get; set; }

        /// <summary>
        /// The price of the top ask order.
        /// </summary>
        /// <value>The price of the top ask order.</value>
        [DataMember(Name="ask_price", EmitDefaultValue=false)]
        public decimal? AskPrice { get; set; }

        /// <summary>
        /// The size of the top ask order.
        /// </summary>
        /// <value>The size of the top ask order.</value>
        [DataMember(Name="ask_size", EmitDefaultValue=false)]
        public decimal? AskSize { get; set; }

        /// <summary>
        /// The date and time when the last ask occurred.
        /// </summary>
        /// <value>The date and time when the last ask occurred.</value>
        [DataMember(Name="ask_time", EmitDefaultValue=false)]
        public DateTime? AskTime { get; set; }

        /// <summary>
        /// The price at the open of the trading day.
        /// </summary>
        /// <value>The price at the open of the trading day.</value>
        [DataMember(Name="open_price", EmitDefaultValue=false)]
        public decimal? OpenPrice { get; set; }

        /// <summary>
        /// The price at the close of the trading day. (IEX only)
        /// </summary>
        /// <value>The price at the close of the trading day. (IEX only)</value>
        [DataMember(Name="close_price", EmitDefaultValue=false)]
        public decimal? ClosePrice { get; set; }

        /// <summary>
        /// The high price for the trading day.
        /// </summary>
        /// <value>The high price for the trading day.</value>
        [DataMember(Name="high_price", EmitDefaultValue=false)]
        public decimal? HighPrice { get; set; }

        /// <summary>
        /// The low price for the trading day.
        /// </summary>
        /// <value>The low price for the trading day.</value>
        [DataMember(Name="low_price", EmitDefaultValue=false)]
        public decimal? LowPrice { get; set; }

        /// <summary>
        /// The number of shares exchanged during the trading day on the exchange.
        /// </summary>
        /// <value>The number of shares exchanged during the trading day on the exchange.</value>
        [DataMember(Name="exchange_volume", EmitDefaultValue=false)]
        public decimal? ExchangeVolume { get; set; }

        /// <summary>
        /// The number of shares exchanged during the trading day for the whole market.
        /// </summary>
        /// <value>The number of shares exchanged during the trading day for the whole market.</value>
        [DataMember(Name="market_volume", EmitDefaultValue=false)]
        public decimal? MarketVolume { get; set; }

        /// <summary>
        /// The date and time when the data was last updated.
        /// </summary>
        /// <value>The date and time when the data was last updated.</value>
        [DataMember(Name="updated_on", EmitDefaultValue=false)]
        public DateTime? UpdatedOn { get; set; }

        /// <summary>
        /// The previous trading session&#39;s closing price.
        /// </summary>
        /// <value>The previous trading session&#39;s closing price.</value>
        [DataMember(Name="eod_close_price", EmitDefaultValue=false)]
        public decimal? EodClosePrice { get; set; }

        /// <summary>
        /// The date of the previous trading session&#39;s closing price.
        /// </summary>
        /// <value>The date of the previous trading session&#39;s closing price.</value>
        [DataMember(Name="eod_close_date", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? EodCloseDate { get; set; }

        /// <summary>
        /// The date and time of the last trade that qualifies for last price consideration during normal market hours according to exchange rules on trade conditions.
        /// </summary>
        /// <value>The date and time of the last trade that qualifies for last price consideration during normal market hours according to exchange rules on trade conditions.</value>
        [DataMember(Name="normal_market_hours_last_time", EmitDefaultValue=false)]
        public DateTime? NormalMarketHoursLastTime { get; set; }

        /// <summary>
        /// The price of the last that qualifies for last price consideration during normal market hours according to exchange rules on trade conditions.
        /// </summary>
        /// <value>The price of the last that qualifies for last price consideration during normal market hours according to exchange rules on trade conditions.</value>
        [DataMember(Name="normal_market_hours_last_price", EmitDefaultValue=false)]
        public decimal? NormalMarketHoursLastPrice { get; set; }

        /// <summary>
        /// The size of the last trade that qualifies for last price consideration during normal market hours according to exchange rules on trade conditions.
        /// </summary>
        /// <value>The size of the last trade that qualifies for last price consideration during normal market hours according to exchange rules on trade conditions.</value>
        [DataMember(Name="normal_market_hours_last_size", EmitDefaultValue=false)]
        public decimal? NormalMarketHoursLastSize { get; set; }

        /// <summary>
        /// The price of the last trade that qualifies for last price consideration according to exchange rules on trade conditions.
        /// </summary>
        /// <value>The price of the last trade that qualifies for last price consideration according to exchange rules on trade conditions.</value>
        [DataMember(Name="qualified_last_price", EmitDefaultValue=false)]
        public decimal? QualifiedLastPrice { get; set; }

        /// <summary>
        /// The date and time of the last trade that qualifies for last price consideration according to exchange rules on trade conditions.
        /// </summary>
        /// <value>The date and time of the last trade that qualifies for last price consideration according to exchange rules on trade conditions.</value>
        [DataMember(Name="qualified_last_time", EmitDefaultValue=false)]
        public DateTime? QualifiedLastTime { get; set; }

        /// <summary>
        /// The size of the last trade that qualifies for last price consideration according to exchange rules on trade conditions.
        /// </summary>
        /// <value>The size of the last trade that qualifies for last price consideration according to exchange rules on trade conditions.</value>
        [DataMember(Name="qualified_last_size", EmitDefaultValue=false)]
        public decimal? QualifiedLastSize { get; set; }

        /// <summary>
        /// The source of the data.
        /// </summary>
        /// <value>The source of the data.</value>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public string Source { get; set; }

        /// <summary>
        /// The listing venue where the trade took place. Available only where source is SIP. Listing Venue Modifiers include: Q – Nasdaq | N – NYSE | A – NYSE American | P – NYSE Arca | u – Other OTC Markets | V – Investors Exchange LLC 
        /// </summary>
        /// <value>The listing venue where the trade took place. Available only where source is SIP. Listing Venue Modifiers include: Q – Nasdaq | N – NYSE | A – NYSE American | P – NYSE Arca | u – Other OTC Markets | V – Investors Exchange LLC </value>
        [DataMember(Name="listing_venue", EmitDefaultValue=false)]
        public string ListingVenue { get; set; }

        /// <summary>
        /// When applicable, indicates any sales condition modifiers associated with the trade. Sales Condition Modifers include: @ – Regular Sale | A – Acquisition | B – Bunched Trade | C – Cash Sale | D – Distribution | E – Placeholder | F – Intermarket Sweep | G – Bunched Sold Trade  | H – Priced Variation Trade | I – Odd Lot Trade | K – Rule 155 Trade (AMEX) | L – Sold Last | M – Market Center Official Close | N – Next Day | O – Opening Prints  | P – Prior Reference Price | Q – Market Center Official Open | R – Seller | S – Split Trade | T – Form T | U – Extended Trading Hours (Sold Out of Sequence)  | V – Contingent Trade | W – Average Price Trade | X – Cross/Periodic Auction Trade | Y – Yellow Flag Regular Trade | Z – Sold (Out of Sequence)  | 1 – Stopped Stock (Regular Trade) | 4 – Derivatively Priced | 5 – Re-Opening Prints | 6 – Closing Prints | 7 – Qualified Contingent Trade (QCT)  | 8 – Placeholder for 611 Exempt | 9 – Corrected Consolidated Close (Per Listing Market) 
        /// </summary>
        /// <value>When applicable, indicates any sales condition modifiers associated with the trade. Sales Condition Modifers include: @ – Regular Sale | A – Acquisition | B – Bunched Trade | C – Cash Sale | D – Distribution | E – Placeholder | F – Intermarket Sweep | G – Bunched Sold Trade  | H – Priced Variation Trade | I – Odd Lot Trade | K – Rule 155 Trade (AMEX) | L – Sold Last | M – Market Center Official Close | N – Next Day | O – Opening Prints  | P – Prior Reference Price | Q – Market Center Official Open | R – Seller | S – Split Trade | T – Form T | U – Extended Trading Hours (Sold Out of Sequence)  | V – Contingent Trade | W – Average Price Trade | X – Cross/Periodic Auction Trade | Y – Yellow Flag Regular Trade | Z – Sold (Out of Sequence)  | 1 – Stopped Stock (Regular Trade) | 4 – Derivatively Priced | 5 – Re-Opening Prints | 6 – Closing Prints | 7 – Qualified Contingent Trade (QCT)  | 8 – Placeholder for 611 Exempt | 9 – Corrected Consolidated Close (Per Listing Market) </value>
        [DataMember(Name="sales_conditions", EmitDefaultValue=false)]
        public string SalesConditions { get; set; }

        /// <summary>
        /// When applicable, indicates any quote condition modifiers associated with the trade. Quote Condition Modifiers include: R – Regular | A – Slow on Ask | – Slow on Bid | C – Closing | D – News Dissemination | F – Slow on ASK (LRP or Gap Quote)  | E – Slow on Bid (LRP or Gap Quote) | G – Trading Range Indication | H – Slow on Bid and Ask | I – Order Imbalance  |  J – Due to Related - News Dissemination | K – Due to Related - News Pending | O – Open | L – Closed  | M – Volatility Trading Pause | N – Non-Firm Quote | O – Opening | P – News Pending | S – Due to Related  | T – Resume | U – Slow on Bid and Ask (LRP or Gap Quote) | V – In View of Common | W – Slow on Bid and Ask (LRP or Gap Quote)  | X – Equipment Changeover | Y – Sub-Penny Trading | Z – No Open / No Resume | F – Fast Trading | U – Slow on Bid and Ask (Non-Firm)  | One-Sided – One-Sided | X – Order Influx | 0 – Special Opening Quote | Halted – Halted | Benchmark – Benchmark | Implied – Implied  | Exchange Best – Exchange Best | 1 – Market Wide Circuit Breaker Level 1 | 2 – Market Wide Circuit Breaker Level 2  | 3 – Market Wide Circuit Breaker Level 3 | Rotation – Rotation | Auto Exec Eligible – Auto Exec Eligible | Bid Side Firm – Bid Side Firm  | Ask Side Firm – Ask Side Firm | 4 – On Demand Intraday Auction | I – Indicative Value (OPRA) | 45 – Additional Information Required (CTS)  | 46 – Regulatory Concern (CTS) | 47 – Merger Effective | 49 – Corporate Action (CTS) | 50 – New Security Offering (CTS)  | 51 – Intraday Indicative Value Unavailable (CTS) 
        /// </summary>
        /// <value>When applicable, indicates any quote condition modifiers associated with the trade. Quote Condition Modifiers include: R – Regular | A – Slow on Ask | – Slow on Bid | C – Closing | D – News Dissemination | F – Slow on ASK (LRP or Gap Quote)  | E – Slow on Bid (LRP or Gap Quote) | G – Trading Range Indication | H – Slow on Bid and Ask | I – Order Imbalance  |  J – Due to Related - News Dissemination | K – Due to Related - News Pending | O – Open | L – Closed  | M – Volatility Trading Pause | N – Non-Firm Quote | O – Opening | P – News Pending | S – Due to Related  | T – Resume | U – Slow on Bid and Ask (LRP or Gap Quote) | V – In View of Common | W – Slow on Bid and Ask (LRP or Gap Quote)  | X – Equipment Changeover | Y – Sub-Penny Trading | Z – No Open / No Resume | F – Fast Trading | U – Slow on Bid and Ask (Non-Firm)  | One-Sided – One-Sided | X – Order Influx | 0 – Special Opening Quote | Halted – Halted | Benchmark – Benchmark | Implied – Implied  | Exchange Best – Exchange Best | 1 – Market Wide Circuit Breaker Level 1 | 2 – Market Wide Circuit Breaker Level 2  | 3 – Market Wide Circuit Breaker Level 3 | Rotation – Rotation | Auto Exec Eligible – Auto Exec Eligible | Bid Side Firm – Bid Side Firm  | Ask Side Firm – Ask Side Firm | 4 – On Demand Intraday Auction | I – Indicative Value (OPRA) | 45 – Additional Information Required (CTS)  | 46 – Regulatory Concern (CTS) | 47 – Merger Effective | 49 – Corporate Action (CTS) | 50 – New Security Offering (CTS)  | 51 – Intraday Indicative Value Unavailable (CTS) </value>
        [DataMember(Name="quote_conditions", EmitDefaultValue=false)]
        public string QuoteConditions { get; set; }

        /// <summary>
        /// The market center character code.
        /// </summary>
        /// <value>The market center character code.</value>
        [DataMember(Name="market_center_code", EmitDefaultValue=false)]
        public string MarketCenterCode { get; set; }

        /// <summary>
        /// Whether or not the current trade is from a darkpool or not.
        /// </summary>
        /// <value>Whether or not the current trade is from a darkpool or not.</value>
        [DataMember(Name="is_darkpool", EmitDefaultValue=false)]
        public bool? IsDarkpool { get; set; }

        /// <summary>
        /// Gets or Sets Security
        /// </summary>
        [DataMember(Name="security", EmitDefaultValue=false)]
        public RealtimeStockPriceSecurity Security { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RealtimeStockPrice {\n");
            sb.Append("  LastPrice: ").Append(LastPrice).Append("\n");
            sb.Append("  LastTime: ").Append(LastTime).Append("\n");
            sb.Append("  LastSize: ").Append(LastSize).Append("\n");
            sb.Append("  BidPrice: ").Append(BidPrice).Append("\n");
            sb.Append("  BidSize: ").Append(BidSize).Append("\n");
            sb.Append("  BidTime: ").Append(BidTime).Append("\n");
            sb.Append("  AskPrice: ").Append(AskPrice).Append("\n");
            sb.Append("  AskSize: ").Append(AskSize).Append("\n");
            sb.Append("  AskTime: ").Append(AskTime).Append("\n");
            sb.Append("  OpenPrice: ").Append(OpenPrice).Append("\n");
            sb.Append("  ClosePrice: ").Append(ClosePrice).Append("\n");
            sb.Append("  HighPrice: ").Append(HighPrice).Append("\n");
            sb.Append("  LowPrice: ").Append(LowPrice).Append("\n");
            sb.Append("  ExchangeVolume: ").Append(ExchangeVolume).Append("\n");
            sb.Append("  MarketVolume: ").Append(MarketVolume).Append("\n");
            sb.Append("  UpdatedOn: ").Append(UpdatedOn).Append("\n");
            sb.Append("  EodClosePrice: ").Append(EodClosePrice).Append("\n");
            sb.Append("  EodCloseDate: ").Append(EodCloseDate).Append("\n");
            sb.Append("  NormalMarketHoursLastTime: ").Append(NormalMarketHoursLastTime).Append("\n");
            sb.Append("  NormalMarketHoursLastPrice: ").Append(NormalMarketHoursLastPrice).Append("\n");
            sb.Append("  NormalMarketHoursLastSize: ").Append(NormalMarketHoursLastSize).Append("\n");
            sb.Append("  QualifiedLastPrice: ").Append(QualifiedLastPrice).Append("\n");
            sb.Append("  QualifiedLastTime: ").Append(QualifiedLastTime).Append("\n");
            sb.Append("  QualifiedLastSize: ").Append(QualifiedLastSize).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  ListingVenue: ").Append(ListingVenue).Append("\n");
            sb.Append("  SalesConditions: ").Append(SalesConditions).Append("\n");
            sb.Append("  QuoteConditions: ").Append(QuoteConditions).Append("\n");
            sb.Append("  MarketCenterCode: ").Append(MarketCenterCode).Append("\n");
            sb.Append("  IsDarkpool: ").Append(IsDarkpool).Append("\n");
            sb.Append("  Security: ").Append(Security).Append("\n");
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
            return this.Equals(input as RealtimeStockPrice);
        }

        /// <summary>
        /// Returns true if RealtimeStockPrice instances are equal
        /// </summary>
        /// <param name="input">Instance of RealtimeStockPrice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RealtimeStockPrice input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LastPrice == input.LastPrice ||
                    (this.LastPrice != null &&
                    this.LastPrice.Equals(input.LastPrice))
                ) && 
                (
                    this.LastTime == input.LastTime ||
                    (this.LastTime != null &&
                    this.LastTime.Equals(input.LastTime))
                ) && 
                (
                    this.LastSize == input.LastSize ||
                    (this.LastSize != null &&
                    this.LastSize.Equals(input.LastSize))
                ) && 
                (
                    this.BidPrice == input.BidPrice ||
                    (this.BidPrice != null &&
                    this.BidPrice.Equals(input.BidPrice))
                ) && 
                (
                    this.BidSize == input.BidSize ||
                    (this.BidSize != null &&
                    this.BidSize.Equals(input.BidSize))
                ) && 
                (
                    this.BidTime == input.BidTime ||
                    (this.BidTime != null &&
                    this.BidTime.Equals(input.BidTime))
                ) && 
                (
                    this.AskPrice == input.AskPrice ||
                    (this.AskPrice != null &&
                    this.AskPrice.Equals(input.AskPrice))
                ) && 
                (
                    this.AskSize == input.AskSize ||
                    (this.AskSize != null &&
                    this.AskSize.Equals(input.AskSize))
                ) && 
                (
                    this.AskTime == input.AskTime ||
                    (this.AskTime != null &&
                    this.AskTime.Equals(input.AskTime))
                ) && 
                (
                    this.OpenPrice == input.OpenPrice ||
                    (this.OpenPrice != null &&
                    this.OpenPrice.Equals(input.OpenPrice))
                ) && 
                (
                    this.ClosePrice == input.ClosePrice ||
                    (this.ClosePrice != null &&
                    this.ClosePrice.Equals(input.ClosePrice))
                ) && 
                (
                    this.HighPrice == input.HighPrice ||
                    (this.HighPrice != null &&
                    this.HighPrice.Equals(input.HighPrice))
                ) && 
                (
                    this.LowPrice == input.LowPrice ||
                    (this.LowPrice != null &&
                    this.LowPrice.Equals(input.LowPrice))
                ) && 
                (
                    this.ExchangeVolume == input.ExchangeVolume ||
                    (this.ExchangeVolume != null &&
                    this.ExchangeVolume.Equals(input.ExchangeVolume))
                ) && 
                (
                    this.MarketVolume == input.MarketVolume ||
                    (this.MarketVolume != null &&
                    this.MarketVolume.Equals(input.MarketVolume))
                ) && 
                (
                    this.UpdatedOn == input.UpdatedOn ||
                    (this.UpdatedOn != null &&
                    this.UpdatedOn.Equals(input.UpdatedOn))
                ) && 
                (
                    this.EodClosePrice == input.EodClosePrice ||
                    (this.EodClosePrice != null &&
                    this.EodClosePrice.Equals(input.EodClosePrice))
                ) && 
                (
                    this.EodCloseDate == input.EodCloseDate ||
                    (this.EodCloseDate != null &&
                    this.EodCloseDate.Equals(input.EodCloseDate))
                ) && 
                (
                    this.NormalMarketHoursLastTime == input.NormalMarketHoursLastTime ||
                    (this.NormalMarketHoursLastTime != null &&
                    this.NormalMarketHoursLastTime.Equals(input.NormalMarketHoursLastTime))
                ) && 
                (
                    this.NormalMarketHoursLastPrice == input.NormalMarketHoursLastPrice ||
                    (this.NormalMarketHoursLastPrice != null &&
                    this.NormalMarketHoursLastPrice.Equals(input.NormalMarketHoursLastPrice))
                ) && 
                (
                    this.NormalMarketHoursLastSize == input.NormalMarketHoursLastSize ||
                    (this.NormalMarketHoursLastSize != null &&
                    this.NormalMarketHoursLastSize.Equals(input.NormalMarketHoursLastSize))
                ) && 
                (
                    this.QualifiedLastPrice == input.QualifiedLastPrice ||
                    (this.QualifiedLastPrice != null &&
                    this.QualifiedLastPrice.Equals(input.QualifiedLastPrice))
                ) && 
                (
                    this.QualifiedLastTime == input.QualifiedLastTime ||
                    (this.QualifiedLastTime != null &&
                    this.QualifiedLastTime.Equals(input.QualifiedLastTime))
                ) && 
                (
                    this.QualifiedLastSize == input.QualifiedLastSize ||
                    (this.QualifiedLastSize != null &&
                    this.QualifiedLastSize.Equals(input.QualifiedLastSize))
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.ListingVenue == input.ListingVenue ||
                    (this.ListingVenue != null &&
                    this.ListingVenue.Equals(input.ListingVenue))
                ) && 
                (
                    this.SalesConditions == input.SalesConditions ||
                    (this.SalesConditions != null &&
                    this.SalesConditions.Equals(input.SalesConditions))
                ) && 
                (
                    this.QuoteConditions == input.QuoteConditions ||
                    (this.QuoteConditions != null &&
                    this.QuoteConditions.Equals(input.QuoteConditions))
                ) && 
                (
                    this.MarketCenterCode == input.MarketCenterCode ||
                    (this.MarketCenterCode != null &&
                    this.MarketCenterCode.Equals(input.MarketCenterCode))
                ) && 
                (
                    this.IsDarkpool == input.IsDarkpool ||
                    (this.IsDarkpool != null &&
                    this.IsDarkpool.Equals(input.IsDarkpool))
                ) && 
                (
                    this.Security == input.Security ||
                    (this.Security != null &&
                    this.Security.Equals(input.Security))
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
                if (this.LastPrice != null)
                    hashCode = hashCode * 59 + this.LastPrice.GetHashCode();
                if (this.LastTime != null)
                    hashCode = hashCode * 59 + this.LastTime.GetHashCode();
                if (this.LastSize != null)
                    hashCode = hashCode * 59 + this.LastSize.GetHashCode();
                if (this.BidPrice != null)
                    hashCode = hashCode * 59 + this.BidPrice.GetHashCode();
                if (this.BidSize != null)
                    hashCode = hashCode * 59 + this.BidSize.GetHashCode();
                if (this.BidTime != null)
                    hashCode = hashCode * 59 + this.BidTime.GetHashCode();
                if (this.AskPrice != null)
                    hashCode = hashCode * 59 + this.AskPrice.GetHashCode();
                if (this.AskSize != null)
                    hashCode = hashCode * 59 + this.AskSize.GetHashCode();
                if (this.AskTime != null)
                    hashCode = hashCode * 59 + this.AskTime.GetHashCode();
                if (this.OpenPrice != null)
                    hashCode = hashCode * 59 + this.OpenPrice.GetHashCode();
                if (this.ClosePrice != null)
                    hashCode = hashCode * 59 + this.ClosePrice.GetHashCode();
                if (this.HighPrice != null)
                    hashCode = hashCode * 59 + this.HighPrice.GetHashCode();
                if (this.LowPrice != null)
                    hashCode = hashCode * 59 + this.LowPrice.GetHashCode();
                if (this.ExchangeVolume != null)
                    hashCode = hashCode * 59 + this.ExchangeVolume.GetHashCode();
                if (this.MarketVolume != null)
                    hashCode = hashCode * 59 + this.MarketVolume.GetHashCode();
                if (this.UpdatedOn != null)
                    hashCode = hashCode * 59 + this.UpdatedOn.GetHashCode();
                if (this.EodClosePrice != null)
                    hashCode = hashCode * 59 + this.EodClosePrice.GetHashCode();
                if (this.EodCloseDate != null)
                    hashCode = hashCode * 59 + this.EodCloseDate.GetHashCode();
                if (this.NormalMarketHoursLastTime != null)
                    hashCode = hashCode * 59 + this.NormalMarketHoursLastTime.GetHashCode();
                if (this.NormalMarketHoursLastPrice != null)
                    hashCode = hashCode * 59 + this.NormalMarketHoursLastPrice.GetHashCode();
                if (this.NormalMarketHoursLastSize != null)
                    hashCode = hashCode * 59 + this.NormalMarketHoursLastSize.GetHashCode();
                if (this.QualifiedLastPrice != null)
                    hashCode = hashCode * 59 + this.QualifiedLastPrice.GetHashCode();
                if (this.QualifiedLastTime != null)
                    hashCode = hashCode * 59 + this.QualifiedLastTime.GetHashCode();
                if (this.QualifiedLastSize != null)
                    hashCode = hashCode * 59 + this.QualifiedLastSize.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.ListingVenue != null)
                    hashCode = hashCode * 59 + this.ListingVenue.GetHashCode();
                if (this.SalesConditions != null)
                    hashCode = hashCode * 59 + this.SalesConditions.GetHashCode();
                if (this.QuoteConditions != null)
                    hashCode = hashCode * 59 + this.QuoteConditions.GetHashCode();
                if (this.MarketCenterCode != null)
                    hashCode = hashCode * 59 + this.MarketCenterCode.GetHashCode();
                if (this.IsDarkpool != null)
                    hashCode = hashCode * 59 + this.IsDarkpool.GetHashCode();
                if (this.Security != null)
                    hashCode = hashCode * 59 + this.Security.GetHashCode();
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
