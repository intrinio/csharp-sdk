

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Intrinio.Client;
using Intrinio.Model;

namespace Intrinio.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IStandardizedTagApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Filter Standardized Tags
        /// </summary>
        /// <remarks>
        /// Returns Standarized Tags that match the given filters
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tag">Tag (optional)</param>
        /// <param name="type">Type (optional)</param>
        /// <param name="parent">ID of tag parent (optional)</param>
        /// <param name="statementCode">Statement Code (optional)</param>
        /// <param name="fsTemplate">Template (optional, default to industrial)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>List&lt;StandardizedTag&gt;</returns>
        List<StandardizedTag> FilterStandardizedTags (string tag = null, string type = null, string parent = null, string statementCode = null, string fsTemplate = null, string nextPage = null);

        /// <summary>
        /// Filter Standardized Tags
        /// </summary>
        /// <remarks>
        /// Returns Standarized Tags that match the given filters
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tag">Tag (optional)</param>
        /// <param name="type">Type (optional)</param>
        /// <param name="parent">ID of tag parent (optional)</param>
        /// <param name="statementCode">Statement Code (optional)</param>
        /// <param name="fsTemplate">Template (optional, default to industrial)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of List&lt;StandardizedTag&gt;</returns>
        ApiResponse<List<StandardizedTag>> FilterStandardizedTagsWithHttpInfo (string tag = null, string type = null, string parent = null, string statementCode = null, string fsTemplate = null, string nextPage = null);
        /// <summary>
        /// Get All Standardized Tags
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>List&lt;StandardizedTag&gt;</returns>
        List<StandardizedTag> GetAllStandardizedTags (string nextPage = null);

        /// <summary>
        /// Get All Standardized Tags
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of List&lt;StandardizedTag&gt;</returns>
        ApiResponse<List<StandardizedTag>> GetAllStandardizedTagsWithHttpInfo (string nextPage = null);
        /// <summary>
        /// Get a Standardized Tag by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tagId">The Intrinio ID for the tag</param>
        /// <returns>StandardizedTag</returns>
        StandardizedTag GetStandardizedTagById (string tagId);

        /// <summary>
        /// Get a Standardized Tag by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tagId">The Intrinio ID for the tag</param>
        /// <returns>ApiResponse of StandardizedTag</returns>
        ApiResponse<StandardizedTag> GetStandardizedTagByIdWithHttpInfo (string tagId);
        /// <summary>
        /// Get Data Point (Number) for The Standardized Tag
        /// </summary>
        /// <remarks>
        /// Returns a numeric data point for the Standardized Tag and entity &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio Standardized Tag ID or its tag</param>
        /// <param name="identifier">An identifier for an entity such as a Company, Security, Index, etc (Ticker, FIGI, ISIN, CUSIP, CIK, LEI, Intrinio ID)</param>
        /// <returns>DataPointNumber</returns>
        DataPointNumber GetStandardizedTagDataPointNumber (string id, string identifier);

        /// <summary>
        /// Get Data Point (Number) for The Standardized Tag
        /// </summary>
        /// <remarks>
        /// Returns a numeric data point for the Standardized Tag and entity &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio Standardized Tag ID or its tag</param>
        /// <param name="identifier">An identifier for an entity such as a Company, Security, Index, etc (Ticker, FIGI, ISIN, CUSIP, CIK, LEI, Intrinio ID)</param>
        /// <returns>ApiResponse of DataPointNumber</returns>
        ApiResponse<DataPointNumber> GetStandardizedTagDataPointNumberWithHttpInfo (string id, string identifier);
        /// <summary>
        /// Get Data Point (Text) for the Standardized Tag
        /// </summary>
        /// <remarks>
        /// Returns a text data point for the Standardized Tag and entity &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio Standardized Tag ID or its tag</param>
        /// <param name="identifier">An identifier for an entity such as a Company, Security, Index, etc (Ticker, FIGI, ISIN, CUSIP, CIK, LEI, Intrinio ID)</param>
        /// <returns>DataPointText</returns>
        DataPointText GetStandardizedTagDataPointText (string id, string identifier);

        /// <summary>
        /// Get Data Point (Text) for the Standardized Tag
        /// </summary>
        /// <remarks>
        /// Returns a text data point for the Standardized Tag and entity &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio Standardized Tag ID or its tag</param>
        /// <param name="identifier">An identifier for an entity such as a Company, Security, Index, etc (Ticker, FIGI, ISIN, CUSIP, CIK, LEI, Intrinio ID)</param>
        /// <returns>ApiResponse of DataPointText</returns>
        ApiResponse<DataPointText> GetStandardizedTagDataPointTextWithHttpInfo (string id, string identifier);
        /// <summary>
        /// Get Historical Data for the Standardized Tag
        /// </summary>
        /// <remarks>
        /// Returns historical values for the Standardized Tag and the Entity represented by the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio Standardized Tag ID or its tag</param>
        /// <param name="identifier">An identifier for an entity such as a Company, Security, Index, etc (Ticker, FIGI, ISIN, CUSIP, CIK, LEI, Intrinio ID)</param>
        /// <param name="type">Filter by type, when applicable (optional)</param>
        /// <param name="startDate">Get historical data on or after this date (optional)</param>
        /// <param name="endDate">Get historical date on or before this date (optional)</param>
        /// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>List&lt;HistoricalData&gt;</returns>
        List<HistoricalData> GetStandardizedTagHistoricalData (string id, string identifier, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, string nextPage = null);

        /// <summary>
        /// Get Historical Data for the Standardized Tag
        /// </summary>
        /// <remarks>
        /// Returns historical values for the Standardized Tag and the Entity represented by the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio Standardized Tag ID or its tag</param>
        /// <param name="identifier">An identifier for an entity such as a Company, Security, Index, etc (Ticker, FIGI, ISIN, CUSIP, CIK, LEI, Intrinio ID)</param>
        /// <param name="type">Filter by type, when applicable (optional)</param>
        /// <param name="startDate">Get historical data on or after this date (optional)</param>
        /// <param name="endDate">Get historical date on or before this date (optional)</param>
        /// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of List&lt;HistoricalData&gt;</returns>
        ApiResponse<List<HistoricalData>> GetStandardizedTagHistoricalDataWithHttpInfo (string id, string identifier, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, string nextPage = null);
        /// <summary>
        /// Search Standardized Tags
        /// </summary>
        /// <remarks>
        /// Searches for Standardized Tags matching the text &#x60;query&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query"></param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>List&lt;StandardizedTag&gt;</returns>
        List<StandardizedTag> SearchStandardizedTags (string query, string nextPage = null);

        /// <summary>
        /// Search Standardized Tags
        /// </summary>
        /// <remarks>
        /// Searches for Standardized Tags matching the text &#x60;query&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query"></param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of List&lt;StandardizedTag&gt;</returns>
        ApiResponse<List<StandardizedTag>> SearchStandardizedTagsWithHttpInfo (string query, string nextPage = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Filter Standardized Tags
        /// </summary>
        /// <remarks>
        /// Returns Standarized Tags that match the given filters
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tag">Tag (optional)</param>
        /// <param name="type">Type (optional)</param>
        /// <param name="parent">ID of tag parent (optional)</param>
        /// <param name="statementCode">Statement Code (optional)</param>
        /// <param name="fsTemplate">Template (optional, default to industrial)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of List&lt;StandardizedTag&gt;</returns>
        System.Threading.Tasks.Task<List<StandardizedTag>> FilterStandardizedTagsAsync (string tag = null, string type = null, string parent = null, string statementCode = null, string fsTemplate = null, string nextPage = null);

        /// <summary>
        /// Filter Standardized Tags
        /// </summary>
        /// <remarks>
        /// Returns Standarized Tags that match the given filters
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tag">Tag (optional)</param>
        /// <param name="type">Type (optional)</param>
        /// <param name="parent">ID of tag parent (optional)</param>
        /// <param name="statementCode">Statement Code (optional)</param>
        /// <param name="fsTemplate">Template (optional, default to industrial)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;StandardizedTag&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<StandardizedTag>>> FilterStandardizedTagsAsyncWithHttpInfo (string tag = null, string type = null, string parent = null, string statementCode = null, string fsTemplate = null, string nextPage = null);
        /// <summary>
        /// Get All Standardized Tags
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of List&lt;StandardizedTag&gt;</returns>
        System.Threading.Tasks.Task<List<StandardizedTag>> GetAllStandardizedTagsAsync (string nextPage = null);

        /// <summary>
        /// Get All Standardized Tags
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;StandardizedTag&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<StandardizedTag>>> GetAllStandardizedTagsAsyncWithHttpInfo (string nextPage = null);
        /// <summary>
        /// Get a Standardized Tag by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tagId">The Intrinio ID for the tag</param>
        /// <returns>Task of StandardizedTag</returns>
        System.Threading.Tasks.Task<StandardizedTag> GetStandardizedTagByIdAsync (string tagId);

        /// <summary>
        /// Get a Standardized Tag by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tagId">The Intrinio ID for the tag</param>
        /// <returns>Task of ApiResponse (StandardizedTag)</returns>
        System.Threading.Tasks.Task<ApiResponse<StandardizedTag>> GetStandardizedTagByIdAsyncWithHttpInfo (string tagId);
        /// <summary>
        /// Get Data Point (Number) for The Standardized Tag
        /// </summary>
        /// <remarks>
        /// Returns a numeric data point for the Standardized Tag and entity &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio Standardized Tag ID or its tag</param>
        /// <param name="identifier">An identifier for an entity such as a Company, Security, Index, etc (Ticker, FIGI, ISIN, CUSIP, CIK, LEI, Intrinio ID)</param>
        /// <returns>Task of DataPointNumber</returns>
        System.Threading.Tasks.Task<DataPointNumber> GetStandardizedTagDataPointNumberAsync (string id, string identifier);

        /// <summary>
        /// Get Data Point (Number) for The Standardized Tag
        /// </summary>
        /// <remarks>
        /// Returns a numeric data point for the Standardized Tag and entity &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio Standardized Tag ID or its tag</param>
        /// <param name="identifier">An identifier for an entity such as a Company, Security, Index, etc (Ticker, FIGI, ISIN, CUSIP, CIK, LEI, Intrinio ID)</param>
        /// <returns>Task of ApiResponse (DataPointNumber)</returns>
        System.Threading.Tasks.Task<ApiResponse<DataPointNumber>> GetStandardizedTagDataPointNumberAsyncWithHttpInfo (string id, string identifier);
        /// <summary>
        /// Get Data Point (Text) for the Standardized Tag
        /// </summary>
        /// <remarks>
        /// Returns a text data point for the Standardized Tag and entity &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio Standardized Tag ID or its tag</param>
        /// <param name="identifier">An identifier for an entity such as a Company, Security, Index, etc (Ticker, FIGI, ISIN, CUSIP, CIK, LEI, Intrinio ID)</param>
        /// <returns>Task of DataPointText</returns>
        System.Threading.Tasks.Task<DataPointText> GetStandardizedTagDataPointTextAsync (string id, string identifier);

        /// <summary>
        /// Get Data Point (Text) for the Standardized Tag
        /// </summary>
        /// <remarks>
        /// Returns a text data point for the Standardized Tag and entity &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio Standardized Tag ID or its tag</param>
        /// <param name="identifier">An identifier for an entity such as a Company, Security, Index, etc (Ticker, FIGI, ISIN, CUSIP, CIK, LEI, Intrinio ID)</param>
        /// <returns>Task of ApiResponse (DataPointText)</returns>
        System.Threading.Tasks.Task<ApiResponse<DataPointText>> GetStandardizedTagDataPointTextAsyncWithHttpInfo (string id, string identifier);
        /// <summary>
        /// Get Historical Data for the Standardized Tag
        /// </summary>
        /// <remarks>
        /// Returns historical values for the Standardized Tag and the Entity represented by the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio Standardized Tag ID or its tag</param>
        /// <param name="identifier">An identifier for an entity such as a Company, Security, Index, etc (Ticker, FIGI, ISIN, CUSIP, CIK, LEI, Intrinio ID)</param>
        /// <param name="type">Filter by type, when applicable (optional)</param>
        /// <param name="startDate">Get historical data on or after this date (optional)</param>
        /// <param name="endDate">Get historical date on or before this date (optional)</param>
        /// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of List&lt;HistoricalData&gt;</returns>
        System.Threading.Tasks.Task<List<HistoricalData>> GetStandardizedTagHistoricalDataAsync (string id, string identifier, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, string nextPage = null);

        /// <summary>
        /// Get Historical Data for the Standardized Tag
        /// </summary>
        /// <remarks>
        /// Returns historical values for the Standardized Tag and the Entity represented by the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio Standardized Tag ID or its tag</param>
        /// <param name="identifier">An identifier for an entity such as a Company, Security, Index, etc (Ticker, FIGI, ISIN, CUSIP, CIK, LEI, Intrinio ID)</param>
        /// <param name="type">Filter by type, when applicable (optional)</param>
        /// <param name="startDate">Get historical data on or after this date (optional)</param>
        /// <param name="endDate">Get historical date on or before this date (optional)</param>
        /// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;HistoricalData&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<HistoricalData>>> GetStandardizedTagHistoricalDataAsyncWithHttpInfo (string id, string identifier, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, string nextPage = null);
        /// <summary>
        /// Search Standardized Tags
        /// </summary>
        /// <remarks>
        /// Searches for Standardized Tags matching the text &#x60;query&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query"></param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of List&lt;StandardizedTag&gt;</returns>
        System.Threading.Tasks.Task<List<StandardizedTag>> SearchStandardizedTagsAsync (string query, string nextPage = null);

        /// <summary>
        /// Search Standardized Tags
        /// </summary>
        /// <remarks>
        /// Searches for Standardized Tags matching the text &#x60;query&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query"></param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;StandardizedTag&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<StandardizedTag>>> SearchStandardizedTagsAsyncWithHttpInfo (string query, string nextPage = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class StandardizedTagApi : IStandardizedTagApi
    {
        private Intrinio.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="StandardizedTagApi"/> class.
        /// </summary>
        /// <returns></returns>
        public StandardizedTagApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = Intrinio.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StandardizedTagApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public StandardizedTagApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Intrinio.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Intrinio.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Filter Standardized Tags Returns Standarized Tags that match the given filters
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tag">Tag (optional)</param>
        /// <param name="type">Type (optional)</param>
        /// <param name="parent">ID of tag parent (optional)</param>
        /// <param name="statementCode">Statement Code (optional)</param>
        /// <param name="fsTemplate">Template (optional, default to industrial)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>List&lt;StandardizedTag&gt;</returns>
        public List<StandardizedTag> FilterStandardizedTags (string tag = null, string type = null, string parent = null, string statementCode = null, string fsTemplate = null, string nextPage = null)
        {
             ApiResponse<List<StandardizedTag>> localVarResponse = FilterStandardizedTagsWithHttpInfo(tag, type, parent, statementCode, fsTemplate, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Filter Standardized Tags Returns Standarized Tags that match the given filters
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tag">Tag (optional)</param>
        /// <param name="type">Type (optional)</param>
        /// <param name="parent">ID of tag parent (optional)</param>
        /// <param name="statementCode">Statement Code (optional)</param>
        /// <param name="fsTemplate">Template (optional, default to industrial)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of List&lt;StandardizedTag&gt;</returns>
        public ApiResponse< List<StandardizedTag> > FilterStandardizedTagsWithHttpInfo (string tag = null, string type = null, string parent = null, string statementCode = null, string fsTemplate = null, string nextPage = null)
        {

            var localVarPath = "/standardized_tags/filter";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (tag != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "tag", tag)); // query parameter
            if (type != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "type", type)); // query parameter
            if (parent != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "parent", parent)); // query parameter
            if (statementCode != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "statement_code", statementCode)); // query parameter
            if (fsTemplate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "fs_template", fsTemplate)); // query parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

            // authentication (HttpHeaderApiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api-key")))
            {
                localVarHeaderParams["api-key"] = Configuration.GetApiKeyWithPrefix("api-key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("FilterStandardizedTags", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<StandardizedTag>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<StandardizedTag>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<StandardizedTag>)));
        }

        /// <summary>
        /// Filter Standardized Tags Returns Standarized Tags that match the given filters
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tag">Tag (optional)</param>
        /// <param name="type">Type (optional)</param>
        /// <param name="parent">ID of tag parent (optional)</param>
        /// <param name="statementCode">Statement Code (optional)</param>
        /// <param name="fsTemplate">Template (optional, default to industrial)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of List&lt;StandardizedTag&gt;</returns>
        public async System.Threading.Tasks.Task<List<StandardizedTag>> FilterStandardizedTagsAsync (string tag = null, string type = null, string parent = null, string statementCode = null, string fsTemplate = null, string nextPage = null)
        {
             ApiResponse<List<StandardizedTag>> localVarResponse = await FilterStandardizedTagsAsyncWithHttpInfo(tag, type, parent, statementCode, fsTemplate, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Filter Standardized Tags Returns Standarized Tags that match the given filters
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tag">Tag (optional)</param>
        /// <param name="type">Type (optional)</param>
        /// <param name="parent">ID of tag parent (optional)</param>
        /// <param name="statementCode">Statement Code (optional)</param>
        /// <param name="fsTemplate">Template (optional, default to industrial)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;StandardizedTag&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<StandardizedTag>>> FilterStandardizedTagsAsyncWithHttpInfo (string tag = null, string type = null, string parent = null, string statementCode = null, string fsTemplate = null, string nextPage = null)
        {

            var localVarPath = "/standardized_tags/filter";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (tag != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "tag", tag)); // query parameter
            if (type != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "type", type)); // query parameter
            if (parent != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "parent", parent)); // query parameter
            if (statementCode != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "statement_code", statementCode)); // query parameter
            if (fsTemplate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "fs_template", fsTemplate)); // query parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

            // authentication (HttpHeaderApiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api-key")))
            {
                localVarHeaderParams["api-key"] = Configuration.GetApiKeyWithPrefix("api-key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("FilterStandardizedTags", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<StandardizedTag>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<StandardizedTag>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<StandardizedTag>)));
        }

        /// <summary>
        /// Get All Standardized Tags 
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>List&lt;StandardizedTag&gt;</returns>
        public List<StandardizedTag> GetAllStandardizedTags (string nextPage = null)
        {
             ApiResponse<List<StandardizedTag>> localVarResponse = GetAllStandardizedTagsWithHttpInfo(nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get All Standardized Tags 
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of List&lt;StandardizedTag&gt;</returns>
        public ApiResponse< List<StandardizedTag> > GetAllStandardizedTagsWithHttpInfo (string nextPage = null)
        {

            var localVarPath = "/standardized_tags";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

            // authentication (HttpHeaderApiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api-key")))
            {
                localVarHeaderParams["api-key"] = Configuration.GetApiKeyWithPrefix("api-key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetAllStandardizedTags", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<StandardizedTag>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<StandardizedTag>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<StandardizedTag>)));
        }

        /// <summary>
        /// Get All Standardized Tags 
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of List&lt;StandardizedTag&gt;</returns>
        public async System.Threading.Tasks.Task<List<StandardizedTag>> GetAllStandardizedTagsAsync (string nextPage = null)
        {
             ApiResponse<List<StandardizedTag>> localVarResponse = await GetAllStandardizedTagsAsyncWithHttpInfo(nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get All Standardized Tags 
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;StandardizedTag&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<StandardizedTag>>> GetAllStandardizedTagsAsyncWithHttpInfo (string nextPage = null)
        {

            var localVarPath = "/standardized_tags";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

            // authentication (HttpHeaderApiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api-key")))
            {
                localVarHeaderParams["api-key"] = Configuration.GetApiKeyWithPrefix("api-key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetAllStandardizedTags", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<StandardizedTag>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<StandardizedTag>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<StandardizedTag>)));
        }

        /// <summary>
        /// Get a Standardized Tag by ID 
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tagId">The Intrinio ID for the tag</param>
        /// <returns>StandardizedTag</returns>
        public StandardizedTag GetStandardizedTagById (string tagId)
        {
             ApiResponse<StandardizedTag> localVarResponse = GetStandardizedTagByIdWithHttpInfo(tagId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Standardized Tag by ID 
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tagId">The Intrinio ID for the tag</param>
        /// <returns>ApiResponse of StandardizedTag</returns>
        public ApiResponse< StandardizedTag > GetStandardizedTagByIdWithHttpInfo (string tagId)
        {
            // verify the required parameter 'tagId' is set
            if (tagId == null)
                throw new ApiException(400, "Missing required parameter 'tagId' when calling StandardizedTagApi->GetStandardizedTagById");

            var localVarPath = "/standardized_tags/{tag_id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (tagId != null) localVarPathParams.Add("tag_id", Configuration.ApiClient.ParameterToString(tagId)); // path parameter

            // authentication (HttpHeaderApiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api-key")))
            {
                localVarHeaderParams["api-key"] = Configuration.GetApiKeyWithPrefix("api-key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetStandardizedTagById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<StandardizedTag>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StandardizedTag) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StandardizedTag)));
        }

        /// <summary>
        /// Get a Standardized Tag by ID 
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tagId">The Intrinio ID for the tag</param>
        /// <returns>Task of StandardizedTag</returns>
        public async System.Threading.Tasks.Task<StandardizedTag> GetStandardizedTagByIdAsync (string tagId)
        {
             ApiResponse<StandardizedTag> localVarResponse = await GetStandardizedTagByIdAsyncWithHttpInfo(tagId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a Standardized Tag by ID 
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tagId">The Intrinio ID for the tag</param>
        /// <returns>Task of ApiResponse (StandardizedTag)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<StandardizedTag>> GetStandardizedTagByIdAsyncWithHttpInfo (string tagId)
        {
            // verify the required parameter 'tagId' is set
            if (tagId == null)
                throw new ApiException(400, "Missing required parameter 'tagId' when calling StandardizedTagApi->GetStandardizedTagById");

            var localVarPath = "/standardized_tags/{tag_id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (tagId != null) localVarPathParams.Add("tag_id", Configuration.ApiClient.ParameterToString(tagId)); // path parameter

            // authentication (HttpHeaderApiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api-key")))
            {
                localVarHeaderParams["api-key"] = Configuration.GetApiKeyWithPrefix("api-key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetStandardizedTagById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<StandardizedTag>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StandardizedTag) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StandardizedTag)));
        }

        /// <summary>
        /// Get Data Point (Number) for The Standardized Tag Returns a numeric data point for the Standardized Tag and entity &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio Standardized Tag ID or its tag</param>
        /// <param name="identifier">An identifier for an entity such as a Company, Security, Index, etc (Ticker, FIGI, ISIN, CUSIP, CIK, LEI, Intrinio ID)</param>
        /// <returns>DataPointNumber</returns>
        public DataPointNumber GetStandardizedTagDataPointNumber (string id, string identifier)
        {
             ApiResponse<DataPointNumber> localVarResponse = GetStandardizedTagDataPointNumberWithHttpInfo(id, identifier);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Data Point (Number) for The Standardized Tag Returns a numeric data point for the Standardized Tag and entity &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio Standardized Tag ID or its tag</param>
        /// <param name="identifier">An identifier for an entity such as a Company, Security, Index, etc (Ticker, FIGI, ISIN, CUSIP, CIK, LEI, Intrinio ID)</param>
        /// <returns>ApiResponse of DataPointNumber</returns>
        public ApiResponse< DataPointNumber > GetStandardizedTagDataPointNumberWithHttpInfo (string id, string identifier)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling StandardizedTagApi->GetStandardizedTagDataPointNumber");
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling StandardizedTagApi->GetStandardizedTagDataPointNumber");

            var localVarPath = "/standardized_tags/{id}/data_point/{identifier}/number";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (identifier != null) localVarPathParams.Add("identifier", Configuration.ApiClient.ParameterToString(identifier)); // path parameter

            // authentication (HttpHeaderApiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api-key")))
            {
                localVarHeaderParams["api-key"] = Configuration.GetApiKeyWithPrefix("api-key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetStandardizedTagDataPointNumber", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DataPointNumber>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DataPointNumber) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DataPointNumber)));
        }

        /// <summary>
        /// Get Data Point (Number) for The Standardized Tag Returns a numeric data point for the Standardized Tag and entity &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio Standardized Tag ID or its tag</param>
        /// <param name="identifier">An identifier for an entity such as a Company, Security, Index, etc (Ticker, FIGI, ISIN, CUSIP, CIK, LEI, Intrinio ID)</param>
        /// <returns>Task of DataPointNumber</returns>
        public async System.Threading.Tasks.Task<DataPointNumber> GetStandardizedTagDataPointNumberAsync (string id, string identifier)
        {
             ApiResponse<DataPointNumber> localVarResponse = await GetStandardizedTagDataPointNumberAsyncWithHttpInfo(id, identifier);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Data Point (Number) for The Standardized Tag Returns a numeric data point for the Standardized Tag and entity &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio Standardized Tag ID or its tag</param>
        /// <param name="identifier">An identifier for an entity such as a Company, Security, Index, etc (Ticker, FIGI, ISIN, CUSIP, CIK, LEI, Intrinio ID)</param>
        /// <returns>Task of ApiResponse (DataPointNumber)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DataPointNumber>> GetStandardizedTagDataPointNumberAsyncWithHttpInfo (string id, string identifier)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling StandardizedTagApi->GetStandardizedTagDataPointNumber");
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling StandardizedTagApi->GetStandardizedTagDataPointNumber");

            var localVarPath = "/standardized_tags/{id}/data_point/{identifier}/number";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (identifier != null) localVarPathParams.Add("identifier", Configuration.ApiClient.ParameterToString(identifier)); // path parameter

            // authentication (HttpHeaderApiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api-key")))
            {
                localVarHeaderParams["api-key"] = Configuration.GetApiKeyWithPrefix("api-key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetStandardizedTagDataPointNumber", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DataPointNumber>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DataPointNumber) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DataPointNumber)));
        }

        /// <summary>
        /// Get Data Point (Text) for the Standardized Tag Returns a text data point for the Standardized Tag and entity &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio Standardized Tag ID or its tag</param>
        /// <param name="identifier">An identifier for an entity such as a Company, Security, Index, etc (Ticker, FIGI, ISIN, CUSIP, CIK, LEI, Intrinio ID)</param>
        /// <returns>DataPointText</returns>
        public DataPointText GetStandardizedTagDataPointText (string id, string identifier)
        {
             ApiResponse<DataPointText> localVarResponse = GetStandardizedTagDataPointTextWithHttpInfo(id, identifier);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Data Point (Text) for the Standardized Tag Returns a text data point for the Standardized Tag and entity &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio Standardized Tag ID or its tag</param>
        /// <param name="identifier">An identifier for an entity such as a Company, Security, Index, etc (Ticker, FIGI, ISIN, CUSIP, CIK, LEI, Intrinio ID)</param>
        /// <returns>ApiResponse of DataPointText</returns>
        public ApiResponse< DataPointText > GetStandardizedTagDataPointTextWithHttpInfo (string id, string identifier)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling StandardizedTagApi->GetStandardizedTagDataPointText");
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling StandardizedTagApi->GetStandardizedTagDataPointText");

            var localVarPath = "/standardized_tags/{id}/data_point/{identifier}/text";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (identifier != null) localVarPathParams.Add("identifier", Configuration.ApiClient.ParameterToString(identifier)); // path parameter

            // authentication (HttpHeaderApiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api-key")))
            {
                localVarHeaderParams["api-key"] = Configuration.GetApiKeyWithPrefix("api-key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetStandardizedTagDataPointText", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DataPointText>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DataPointText) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DataPointText)));
        }

        /// <summary>
        /// Get Data Point (Text) for the Standardized Tag Returns a text data point for the Standardized Tag and entity &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio Standardized Tag ID or its tag</param>
        /// <param name="identifier">An identifier for an entity such as a Company, Security, Index, etc (Ticker, FIGI, ISIN, CUSIP, CIK, LEI, Intrinio ID)</param>
        /// <returns>Task of DataPointText</returns>
        public async System.Threading.Tasks.Task<DataPointText> GetStandardizedTagDataPointTextAsync (string id, string identifier)
        {
             ApiResponse<DataPointText> localVarResponse = await GetStandardizedTagDataPointTextAsyncWithHttpInfo(id, identifier);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Data Point (Text) for the Standardized Tag Returns a text data point for the Standardized Tag and entity &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio Standardized Tag ID or its tag</param>
        /// <param name="identifier">An identifier for an entity such as a Company, Security, Index, etc (Ticker, FIGI, ISIN, CUSIP, CIK, LEI, Intrinio ID)</param>
        /// <returns>Task of ApiResponse (DataPointText)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DataPointText>> GetStandardizedTagDataPointTextAsyncWithHttpInfo (string id, string identifier)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling StandardizedTagApi->GetStandardizedTagDataPointText");
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling StandardizedTagApi->GetStandardizedTagDataPointText");

            var localVarPath = "/standardized_tags/{id}/data_point/{identifier}/text";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (identifier != null) localVarPathParams.Add("identifier", Configuration.ApiClient.ParameterToString(identifier)); // path parameter

            // authentication (HttpHeaderApiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api-key")))
            {
                localVarHeaderParams["api-key"] = Configuration.GetApiKeyWithPrefix("api-key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetStandardizedTagDataPointText", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DataPointText>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DataPointText) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DataPointText)));
        }

        /// <summary>
        /// Get Historical Data for the Standardized Tag Returns historical values for the Standardized Tag and the Entity represented by the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio Standardized Tag ID or its tag</param>
        /// <param name="identifier">An identifier for an entity such as a Company, Security, Index, etc (Ticker, FIGI, ISIN, CUSIP, CIK, LEI, Intrinio ID)</param>
        /// <param name="type">Filter by type, when applicable (optional)</param>
        /// <param name="startDate">Get historical data on or after this date (optional)</param>
        /// <param name="endDate">Get historical date on or before this date (optional)</param>
        /// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>List&lt;HistoricalData&gt;</returns>
        public List<HistoricalData> GetStandardizedTagHistoricalData (string id, string identifier, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, string nextPage = null)
        {
             ApiResponse<List<HistoricalData>> localVarResponse = GetStandardizedTagHistoricalDataWithHttpInfo(id, identifier, type, startDate, endDate, sortOrder, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Historical Data for the Standardized Tag Returns historical values for the Standardized Tag and the Entity represented by the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio Standardized Tag ID or its tag</param>
        /// <param name="identifier">An identifier for an entity such as a Company, Security, Index, etc (Ticker, FIGI, ISIN, CUSIP, CIK, LEI, Intrinio ID)</param>
        /// <param name="type">Filter by type, when applicable (optional)</param>
        /// <param name="startDate">Get historical data on or after this date (optional)</param>
        /// <param name="endDate">Get historical date on or before this date (optional)</param>
        /// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of List&lt;HistoricalData&gt;</returns>
        public ApiResponse< List<HistoricalData> > GetStandardizedTagHistoricalDataWithHttpInfo (string id, string identifier, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, string nextPage = null)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling StandardizedTagApi->GetStandardizedTagHistoricalData");
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling StandardizedTagApi->GetStandardizedTagHistoricalData");

            var localVarPath = "/standardized_tags/{id}/historical_data/{identifier}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (identifier != null) localVarPathParams.Add("identifier", Configuration.ApiClient.ParameterToString(identifier)); // path parameter
            if (type != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "type", type)); // query parameter
            if (startDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
            if (endDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
            if (sortOrder != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sort_order", sortOrder)); // query parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

            // authentication (HttpHeaderApiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api-key")))
            {
                localVarHeaderParams["api-key"] = Configuration.GetApiKeyWithPrefix("api-key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetStandardizedTagHistoricalData", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<HistoricalData>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<HistoricalData>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<HistoricalData>)));
        }

        /// <summary>
        /// Get Historical Data for the Standardized Tag Returns historical values for the Standardized Tag and the Entity represented by the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio Standardized Tag ID or its tag</param>
        /// <param name="identifier">An identifier for an entity such as a Company, Security, Index, etc (Ticker, FIGI, ISIN, CUSIP, CIK, LEI, Intrinio ID)</param>
        /// <param name="type">Filter by type, when applicable (optional)</param>
        /// <param name="startDate">Get historical data on or after this date (optional)</param>
        /// <param name="endDate">Get historical date on or before this date (optional)</param>
        /// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of List&lt;HistoricalData&gt;</returns>
        public async System.Threading.Tasks.Task<List<HistoricalData>> GetStandardizedTagHistoricalDataAsync (string id, string identifier, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, string nextPage = null)
        {
             ApiResponse<List<HistoricalData>> localVarResponse = await GetStandardizedTagHistoricalDataAsyncWithHttpInfo(id, identifier, type, startDate, endDate, sortOrder, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Historical Data for the Standardized Tag Returns historical values for the Standardized Tag and the Entity represented by the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio Standardized Tag ID or its tag</param>
        /// <param name="identifier">An identifier for an entity such as a Company, Security, Index, etc (Ticker, FIGI, ISIN, CUSIP, CIK, LEI, Intrinio ID)</param>
        /// <param name="type">Filter by type, when applicable (optional)</param>
        /// <param name="startDate">Get historical data on or after this date (optional)</param>
        /// <param name="endDate">Get historical date on or before this date (optional)</param>
        /// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;HistoricalData&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<HistoricalData>>> GetStandardizedTagHistoricalDataAsyncWithHttpInfo (string id, string identifier, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, string nextPage = null)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling StandardizedTagApi->GetStandardizedTagHistoricalData");
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling StandardizedTagApi->GetStandardizedTagHistoricalData");

            var localVarPath = "/standardized_tags/{id}/historical_data/{identifier}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (identifier != null) localVarPathParams.Add("identifier", Configuration.ApiClient.ParameterToString(identifier)); // path parameter
            if (type != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "type", type)); // query parameter
            if (startDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
            if (endDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
            if (sortOrder != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sort_order", sortOrder)); // query parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

            // authentication (HttpHeaderApiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api-key")))
            {
                localVarHeaderParams["api-key"] = Configuration.GetApiKeyWithPrefix("api-key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetStandardizedTagHistoricalData", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<HistoricalData>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<HistoricalData>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<HistoricalData>)));
        }

        /// <summary>
        /// Search Standardized Tags Searches for Standardized Tags matching the text &#x60;query&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query"></param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>List&lt;StandardizedTag&gt;</returns>
        public List<StandardizedTag> SearchStandardizedTags (string query, string nextPage = null)
        {
             ApiResponse<List<StandardizedTag>> localVarResponse = SearchStandardizedTagsWithHttpInfo(query, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search Standardized Tags Searches for Standardized Tags matching the text &#x60;query&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query"></param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of List&lt;StandardizedTag&gt;</returns>
        public ApiResponse< List<StandardizedTag> > SearchStandardizedTagsWithHttpInfo (string query, string nextPage = null)
        {
            // verify the required parameter 'query' is set
            if (query == null)
                throw new ApiException(400, "Missing required parameter 'query' when calling StandardizedTagApi->SearchStandardizedTags");

            var localVarPath = "/standardized_tags/search";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (query != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "query", query)); // query parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

            // authentication (HttpHeaderApiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api-key")))
            {
                localVarHeaderParams["api-key"] = Configuration.GetApiKeyWithPrefix("api-key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SearchStandardizedTags", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<StandardizedTag>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<StandardizedTag>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<StandardizedTag>)));
        }

        /// <summary>
        /// Search Standardized Tags Searches for Standardized Tags matching the text &#x60;query&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query"></param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of List&lt;StandardizedTag&gt;</returns>
        public async System.Threading.Tasks.Task<List<StandardizedTag>> SearchStandardizedTagsAsync (string query, string nextPage = null)
        {
             ApiResponse<List<StandardizedTag>> localVarResponse = await SearchStandardizedTagsAsyncWithHttpInfo(query, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search Standardized Tags Searches for Standardized Tags matching the text &#x60;query&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query"></param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;StandardizedTag&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<StandardizedTag>>> SearchStandardizedTagsAsyncWithHttpInfo (string query, string nextPage = null)
        {
            // verify the required parameter 'query' is set
            if (query == null)
                throw new ApiException(400, "Missing required parameter 'query' when calling StandardizedTagApi->SearchStandardizedTags");

            var localVarPath = "/standardized_tags/search";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (query != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "query", query)); // query parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

            // authentication (HttpHeaderApiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api-key")))
            {
                localVarHeaderParams["api-key"] = Configuration.GetApiKeyWithPrefix("api-key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SearchStandardizedTags", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<StandardizedTag>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<StandardizedTag>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<StandardizedTag>)));
        }

    }
}
