

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
    /// A news article about a company
    /// </summary>
    [DataContract]
    public partial class CompanyNewsSummary :  IEquatable<CompanyNewsSummary>, IValidatableObject
    {
        /// <summary>
        /// The news source.
        /// </summary>
        /// <value>The news source.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SourceEnum
        {
            
            /// <summary>
            /// Enum Yahoo for value: yahoo
            /// </summary>
            [EnumMember(Value = "yahoo")]
            Yahoo = 1,
            
            /// <summary>
            /// Enum Moody for value: moody
            /// </summary>
            [EnumMember(Value = "moody")]
            Moody = 2,
            
            /// <summary>
            /// Enum Moodyusnews for value: moody_us_news
            /// </summary>
            [EnumMember(Value = "moody_us_news")]
            Moodyusnews = 3,
            
            /// <summary>
            /// Enum Moodyuspressreleases for value: moody_us_press_releases
            /// </summary>
            [EnumMember(Value = "moody_us_press_releases")]
            Moodyuspressreleases = 4
        }

        /// <summary>
        /// The news source.
        /// </summary>
        /// <value>The news source.</value>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public SourceEnum? Source { get; set; }
        /// <summary>
        /// The news sentiment.
        /// </summary>
        /// <value>The news sentiment.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ArticleSentimentEnum
        {
            
            /// <summary>
            /// Enum Positive for value: positive
            /// </summary>
            [EnumMember(Value = "positive")]
            Positive = 1,
            
            /// <summary>
            /// Enum Neutral for value: neutral
            /// </summary>
            [EnumMember(Value = "neutral")]
            Neutral = 2,
            
            /// <summary>
            /// Enum Negative for value: negative
            /// </summary>
            [EnumMember(Value = "negative")]
            Negative = 3
        }

        /// <summary>
        /// The news sentiment.
        /// </summary>
        /// <value>The news sentiment.</value>
        [DataMember(Name="article_sentiment", EmitDefaultValue=false)]
        public ArticleSentimentEnum? ArticleSentiment { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyNewsSummary" /> class.
        /// </summary>
        /// <param name="Id">The Intrinio ID for the news article.</param>
        /// <param name="Title">The title of the news article.</param>
        /// <param name="PublicationDate">The publication date of the news article.</param>
        /// <param name="Url">The url of the news article.</param>
        /// <param name="Summary">A summary of the news article.</param>
        /// <param name="Source">The news source..</param>
        /// <param name="Topics">Topics.</param>
        /// <param name="Copyright">The copyright of the news article.</param>
        /// <param name="Language">The language code of the news article.</param>
        /// <param name="WordCount">The word count of the news article.</param>
        /// <param name="Spam">Whether the news article is marked as spam or not.</param>
        /// <param name="BusinessRelevance">How strongly correlated the news article is to the business.</param>
        /// <param name="ArticleSentiment">The news sentiment..</param>
        /// <param name="ArticleSentimentConfidence">The confidence score of the sentiment rating.</param>
        public CompanyNewsSummary(string Id = default(string), string Title = default(string), DateTime? PublicationDate = default(DateTime?), string Url = default(string), string Summary = default(string), SourceEnum? Source = default(SourceEnum?), List<NewsTopic> Topics = default(List<NewsTopic>), string Copyright = default(string), string Language = default(string), int? WordCount = default(int?), bool? Spam = default(bool?), decimal? BusinessRelevance = default(decimal?), ArticleSentimentEnum? ArticleSentiment = default(ArticleSentimentEnum?), decimal? ArticleSentimentConfidence = default(decimal?))
        {
            this.Id = Id;
            this.Title = Title;
            this.PublicationDate = PublicationDate;
            this.Url = Url;
            this.Summary = Summary;
            this.Source = Source;
            this.Topics = Topics;
            this.Copyright = Copyright;
            this.Language = Language;
            this.WordCount = WordCount;
            this.Spam = Spam;
            this.BusinessRelevance = BusinessRelevance;
            this.ArticleSentiment = ArticleSentiment;
            this.ArticleSentimentConfidence = ArticleSentimentConfidence;
        }
        
        /// <summary>
        /// The Intrinio ID for the news article
        /// </summary>
        /// <value>The Intrinio ID for the news article</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The title of the news article
        /// </summary>
        /// <value>The title of the news article</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// The publication date of the news article
        /// </summary>
        /// <value>The publication date of the news article</value>
        [DataMember(Name="publication_date", EmitDefaultValue=false)]
        public DateTime? PublicationDate { get; set; }

        /// <summary>
        /// The url of the news article
        /// </summary>
        /// <value>The url of the news article</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// A summary of the news article
        /// </summary>
        /// <value>A summary of the news article</value>
        [DataMember(Name="summary", EmitDefaultValue=false)]
        public string Summary { get; set; }


        /// <summary>
        /// Gets or Sets Topics
        /// </summary>
        [DataMember(Name="topics", EmitDefaultValue=false)]
        public List<NewsTopic> Topics { get; set; }

        /// <summary>
        /// The copyright of the news article
        /// </summary>
        /// <value>The copyright of the news article</value>
        [DataMember(Name="copyright", EmitDefaultValue=false)]
        public string Copyright { get; set; }

        /// <summary>
        /// The language code of the news article
        /// </summary>
        /// <value>The language code of the news article</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; set; }

        /// <summary>
        /// The word count of the news article
        /// </summary>
        /// <value>The word count of the news article</value>
        [DataMember(Name="word_count", EmitDefaultValue=false)]
        public int? WordCount { get; set; }

        /// <summary>
        /// Whether the news article is marked as spam or not
        /// </summary>
        /// <value>Whether the news article is marked as spam or not</value>
        [DataMember(Name="spam", EmitDefaultValue=false)]
        public bool? Spam { get; set; }

        /// <summary>
        /// How strongly correlated the news article is to the business
        /// </summary>
        /// <value>How strongly correlated the news article is to the business</value>
        [DataMember(Name="business_relevance", EmitDefaultValue=false)]
        public decimal? BusinessRelevance { get; set; }


        /// <summary>
        /// The confidence score of the sentiment rating
        /// </summary>
        /// <value>The confidence score of the sentiment rating</value>
        [DataMember(Name="article_sentiment_confidence", EmitDefaultValue=false)]
        public decimal? ArticleSentimentConfidence { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompanyNewsSummary {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  PublicationDate: ").Append(PublicationDate).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Summary: ").Append(Summary).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Topics: ").Append(Topics).Append("\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  WordCount: ").Append(WordCount).Append("\n");
            sb.Append("  Spam: ").Append(Spam).Append("\n");
            sb.Append("  BusinessRelevance: ").Append(BusinessRelevance).Append("\n");
            sb.Append("  ArticleSentiment: ").Append(ArticleSentiment).Append("\n");
            sb.Append("  ArticleSentimentConfidence: ").Append(ArticleSentimentConfidence).Append("\n");
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
            return this.Equals(input as CompanyNewsSummary);
        }

        /// <summary>
        /// Returns true if CompanyNewsSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of CompanyNewsSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompanyNewsSummary input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.PublicationDate == input.PublicationDate ||
                    (this.PublicationDate != null &&
                    this.PublicationDate.Equals(input.PublicationDate))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.Summary == input.Summary ||
                    (this.Summary != null &&
                    this.Summary.Equals(input.Summary))
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.Topics == input.Topics ||
                    this.Topics != null &&
                    this.Topics.SequenceEqual(input.Topics)
                ) && 
                (
                    this.Copyright == input.Copyright ||
                    (this.Copyright != null &&
                    this.Copyright.Equals(input.Copyright))
                ) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
                ) && 
                (
                    this.WordCount == input.WordCount ||
                    (this.WordCount != null &&
                    this.WordCount.Equals(input.WordCount))
                ) && 
                (
                    this.Spam == input.Spam ||
                    (this.Spam != null &&
                    this.Spam.Equals(input.Spam))
                ) && 
                (
                    this.BusinessRelevance == input.BusinessRelevance ||
                    (this.BusinessRelevance != null &&
                    this.BusinessRelevance.Equals(input.BusinessRelevance))
                ) && 
                (
                    this.ArticleSentiment == input.ArticleSentiment ||
                    (this.ArticleSentiment != null &&
                    this.ArticleSentiment.Equals(input.ArticleSentiment))
                ) && 
                (
                    this.ArticleSentimentConfidence == input.ArticleSentimentConfidence ||
                    (this.ArticleSentimentConfidence != null &&
                    this.ArticleSentimentConfidence.Equals(input.ArticleSentimentConfidence))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.PublicationDate != null)
                    hashCode = hashCode * 59 + this.PublicationDate.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.Summary != null)
                    hashCode = hashCode * 59 + this.Summary.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.Topics != null)
                    hashCode = hashCode * 59 + this.Topics.GetHashCode();
                if (this.Copyright != null)
                    hashCode = hashCode * 59 + this.Copyright.GetHashCode();
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.WordCount != null)
                    hashCode = hashCode * 59 + this.WordCount.GetHashCode();
                if (this.Spam != null)
                    hashCode = hashCode * 59 + this.Spam.GetHashCode();
                if (this.BusinessRelevance != null)
                    hashCode = hashCode * 59 + this.BusinessRelevance.GetHashCode();
                if (this.ArticleSentiment != null)
                    hashCode = hashCode * 59 + this.ArticleSentiment.GetHashCode();
                if (this.ArticleSentimentConfidence != null)
                    hashCode = hashCode * 59 + this.ArticleSentimentConfidence.GetHashCode();
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
