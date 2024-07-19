

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text.RegularExpressions;
using RestSharp;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Intrinio.SDK.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IZacksApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Zacks Analyst Ratings
        /// </summary>
        /// <remarks>
        /// This database offers consensus analyst recommendations for over 5,000 US and Canadian listed companies.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) (optional)</param>
        /// <param name="startDate">Limit ratings to those on or after this date (optional)</param>
        /// <param name="endDate">Limit ratings to those on or before this date (optional)</param>
        /// <param name="meanGreater">Return only records with a mean (average) higher than this value (optional)</param>
        /// <param name="meanLess">Return only records with a mean (average) lower than this value (optional)</param>
        /// <param name="strongBuysGreater">Return only records with more than this many Strong Buy recommendations (optional)</param>
        /// <param name="strongBuysLess">Return only records with fewer than this many Strong Buy recommendations (optional)</param>
        /// <param name="buysGreater">Return only records with more than this many Buy recommendations (optional)</param>
        /// <param name="buysLess">Return only records with fewer than this many Buy recommendations (optional)</param>
        /// <param name="holdsGreater">Return only records with more than this many Hold recommendations (optional)</param>
        /// <param name="holdsLess">Return only records with fewer than this many Hold recommendations (optional)</param>
        /// <param name="sellsGreater">Return only records with more than this many Sell recommendations (optional)</param>
        /// <param name="sellsLess">Return only records with fewer than this many Sell recommendations (optional)</param>
        /// <param name="strongSellsGreater">Return only records with more than this many Strong Sell recommendations (optional)</param>
        /// <param name="strongSellsLess">Return only records with fewer than this many Strong Sell recommendations (optional)</param>
        /// <param name="totalGreater">Return only records with more than this many recommendations, regardless of type (optional)</param>
        /// <param name="totalLess">Return only records with fewer than this many recommendations, regardless of type (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseZacksAnalystRatings</returns>
        ApiResponseZacksAnalystRatings GetZacksAnalystRatings (string identifier = null, DateTime? startDate = null, DateTime? endDate = null, decimal? meanGreater = null, decimal? meanLess = null, int? strongBuysGreater = null, int? strongBuysLess = null, int? buysGreater = null, int? buysLess = null, int? holdsGreater = null, int? holdsLess = null, int? sellsGreater = null, int? sellsLess = null, int? strongSellsGreater = null, int? strongSellsLess = null, int? totalGreater = null, int? totalLess = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Zacks Analyst Ratings
        /// </summary>
        /// <remarks>
        /// This database offers consensus analyst recommendations for over 5,000 US and Canadian listed companies.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) (optional)</param>
        /// <param name="startDate">Limit ratings to those on or after this date (optional)</param>
        /// <param name="endDate">Limit ratings to those on or before this date (optional)</param>
        /// <param name="meanGreater">Return only records with a mean (average) higher than this value (optional)</param>
        /// <param name="meanLess">Return only records with a mean (average) lower than this value (optional)</param>
        /// <param name="strongBuysGreater">Return only records with more than this many Strong Buy recommendations (optional)</param>
        /// <param name="strongBuysLess">Return only records with fewer than this many Strong Buy recommendations (optional)</param>
        /// <param name="buysGreater">Return only records with more than this many Buy recommendations (optional)</param>
        /// <param name="buysLess">Return only records with fewer than this many Buy recommendations (optional)</param>
        /// <param name="holdsGreater">Return only records with more than this many Hold recommendations (optional)</param>
        /// <param name="holdsLess">Return only records with fewer than this many Hold recommendations (optional)</param>
        /// <param name="sellsGreater">Return only records with more than this many Sell recommendations (optional)</param>
        /// <param name="sellsLess">Return only records with fewer than this many Sell recommendations (optional)</param>
        /// <param name="strongSellsGreater">Return only records with more than this many Strong Sell recommendations (optional)</param>
        /// <param name="strongSellsLess">Return only records with fewer than this many Strong Sell recommendations (optional)</param>
        /// <param name="totalGreater">Return only records with more than this many recommendations, regardless of type (optional)</param>
        /// <param name="totalLess">Return only records with fewer than this many recommendations, regardless of type (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseZacksAnalystRatings</returns>
        ApiResponse<ApiResponseZacksAnalystRatings> GetZacksAnalystRatingsWithHttpInfo (string identifier = null, DateTime? startDate = null, DateTime? endDate = null, decimal? meanGreater = null, decimal? meanLess = null, int? strongBuysGreater = null, int? strongBuysLess = null, int? buysGreater = null, int? buysLess = null, int? holdsGreater = null, int? holdsLess = null, int? sellsGreater = null, int? sellsLess = null, int? strongSellsGreater = null, int? strongSellsLess = null, int? totalGreater = null, int? totalLess = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Zacks EBITDA Consensus
        /// </summary>
        /// <remarks>
        /// This database offers consensus EBITDA-related estimates for over 4,000 US and Canadian listed companies.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID) (optional)</param>
        /// <param name="type">Limit EBITDA estimates to this type (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseZacksEBITDAConsensus</returns>
        ApiResponseZacksEBITDAConsensus GetZacksEbitdaConsensus (string identifier = null, string type = null, string nextPage = null);

        /// <summary>
        /// Zacks EBITDA Consensus
        /// </summary>
        /// <remarks>
        /// This database offers consensus EBITDA-related estimates for over 4,000 US and Canadian listed companies.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID) (optional)</param>
        /// <param name="type">Limit EBITDA estimates to this type (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseZacksEBITDAConsensus</returns>
        ApiResponse<ApiResponseZacksEBITDAConsensus> GetZacksEbitdaConsensusWithHttpInfo (string identifier = null, string type = null, string nextPage = null);
        /// <summary>
        /// Zacks EPS Estimates
        /// </summary>
        /// <remarks>
        /// This database offers consensus earnings estimates for over 5,000 US and Canadian listed companies.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID) (optional)</param>
        /// <param name="startDate">Limit EPS estimates to those on or after this date (optional)</param>
        /// <param name="endDate">Limit EPS estimates to those on or before this date (optional)</param>
        /// <param name="fiscalYear">Only for the given fiscal year (optional)</param>
        /// <param name="fiscalPeriod">The fiscal period (optional)</param>
        /// <param name="calendarYear">Only for the given calendar year (optional)</param>
        /// <param name="calendarPeriod">The calendar period (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseZacksEPSEstimates</returns>
        ApiResponseZacksEPSEstimates GetZacksEpsEstimates (string identifier = null, DateTime? startDate = null, DateTime? endDate = null, int? fiscalYear = null, string fiscalPeriod = null, int? calendarYear = null, string calendarPeriod = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Zacks EPS Estimates
        /// </summary>
        /// <remarks>
        /// This database offers consensus earnings estimates for over 5,000 US and Canadian listed companies.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID) (optional)</param>
        /// <param name="startDate">Limit EPS estimates to those on or after this date (optional)</param>
        /// <param name="endDate">Limit EPS estimates to those on or before this date (optional)</param>
        /// <param name="fiscalYear">Only for the given fiscal year (optional)</param>
        /// <param name="fiscalPeriod">The fiscal period (optional)</param>
        /// <param name="calendarYear">Only for the given calendar year (optional)</param>
        /// <param name="calendarPeriod">The calendar period (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseZacksEPSEstimates</returns>
        ApiResponse<ApiResponseZacksEPSEstimates> GetZacksEpsEstimatesWithHttpInfo (string identifier = null, DateTime? startDate = null, DateTime? endDate = null, int? fiscalYear = null, string fiscalPeriod = null, int? calendarYear = null, string calendarPeriod = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Zacks EPS Growth Rates
        /// </summary>
        /// <remarks>
        /// This database offers consensus EPS growth rate estimates, comparing company estimates to historical company estimates, industry estimates, and S&amp;P 500 index estimates.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="company">Filings for the given &#x60;company&#x60; identifier (ticker, CIK, LEI, Intrinio ID) (optional)</param>
        /// <param name="industryGroupName">Return only growth rates for companies in the given Zacks industry group name (optional)</param>
        /// <param name="industryGroupNumber">Return only growth rates for companies in the given Zacks industry group number (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseZacksEPSGrowthRates</returns>
        ApiResponseZacksEPSGrowthRates GetZacksEpsGrowthRates (string company = null, string industryGroupName = null, string industryGroupNumber = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Zacks EPS Growth Rates
        /// </summary>
        /// <remarks>
        /// This database offers consensus EPS growth rate estimates, comparing company estimates to historical company estimates, industry estimates, and S&amp;P 500 index estimates.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="company">Filings for the given &#x60;company&#x60; identifier (ticker, CIK, LEI, Intrinio ID) (optional)</param>
        /// <param name="industryGroupName">Return only growth rates for companies in the given Zacks industry group name (optional)</param>
        /// <param name="industryGroupNumber">Return only growth rates for companies in the given Zacks industry group number (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseZacksEPSGrowthRates</returns>
        ApiResponse<ApiResponseZacksEPSGrowthRates> GetZacksEpsGrowthRatesWithHttpInfo (string company = null, string industryGroupName = null, string industryGroupNumber = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Zacks EPS Surprises
        /// </summary>
        /// <remarks>
        /// This database returns historical estimated and actual earnings, guidance, and announcement dates for 17,000+ US and Canadian listed companies.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Limit EPS surprises to those on or after this date (optional)</param>
        /// <param name="endDate">Limit EPS surprises to those on or before this date (optional)</param>
        /// <param name="epsActualGreater">Return only records with an actual EPS higher than this value (optional)</param>
        /// <param name="epsActualLess">Return only records with an actual EPS lower than this value (optional)</param>
        /// <param name="epsMeanEstimateGreater">Return only records with an EPS mean estimate greater than this value (optional)</param>
        /// <param name="epsMeanEstimateLess">Return only records with an EPS mean estimate lower than this value (optional)</param>
        /// <param name="epsAmountDiffGreater">Return only records with an EPS amount difference greater than this value (optional)</param>
        /// <param name="epsAmountDiffLess">Return only records with an EPS amount difference less than this value (optional)</param>
        /// <param name="epsPercentDiffGreater">Return only records with an EPS percent difference greater than this value (optional)</param>
        /// <param name="epsPercentDiffLess">Return only records with an EPS percent difference less than this value (optional)</param>
        /// <param name="epsCountEstimateGreater">Return only records with an EPS count estimate greater than this value (optional)</param>
        /// <param name="epsCountEstimateLess">Return only records with an EPS count estimate less than this value (optional)</param>
        /// <param name="epsStdDevEstimateGreater">Return only records with an EPS standard deviation greater than this value (optional)</param>
        /// <param name="epsStdDevEstimateLess">Return only records with an EPS standard deviation less than this value (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseZacksEPSSurprises</returns>
        ApiResponseZacksEPSSurprises GetZacksEpsSurprises (DateTime? startDate = null, DateTime? endDate = null, decimal? epsActualGreater = null, decimal? epsActualLess = null, decimal? epsMeanEstimateGreater = null, decimal? epsMeanEstimateLess = null, decimal? epsAmountDiffGreater = null, decimal? epsAmountDiffLess = null, decimal? epsPercentDiffGreater = null, decimal? epsPercentDiffLess = null, decimal? epsCountEstimateGreater = null, decimal? epsCountEstimateLess = null, decimal? epsStdDevEstimateGreater = null, decimal? epsStdDevEstimateLess = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Zacks EPS Surprises
        /// </summary>
        /// <remarks>
        /// This database returns historical estimated and actual earnings, guidance, and announcement dates for 17,000+ US and Canadian listed companies.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Limit EPS surprises to those on or after this date (optional)</param>
        /// <param name="endDate">Limit EPS surprises to those on or before this date (optional)</param>
        /// <param name="epsActualGreater">Return only records with an actual EPS higher than this value (optional)</param>
        /// <param name="epsActualLess">Return only records with an actual EPS lower than this value (optional)</param>
        /// <param name="epsMeanEstimateGreater">Return only records with an EPS mean estimate greater than this value (optional)</param>
        /// <param name="epsMeanEstimateLess">Return only records with an EPS mean estimate lower than this value (optional)</param>
        /// <param name="epsAmountDiffGreater">Return only records with an EPS amount difference greater than this value (optional)</param>
        /// <param name="epsAmountDiffLess">Return only records with an EPS amount difference less than this value (optional)</param>
        /// <param name="epsPercentDiffGreater">Return only records with an EPS percent difference greater than this value (optional)</param>
        /// <param name="epsPercentDiffLess">Return only records with an EPS percent difference less than this value (optional)</param>
        /// <param name="epsCountEstimateGreater">Return only records with an EPS count estimate greater than this value (optional)</param>
        /// <param name="epsCountEstimateLess">Return only records with an EPS count estimate less than this value (optional)</param>
        /// <param name="epsStdDevEstimateGreater">Return only records with an EPS standard deviation greater than this value (optional)</param>
        /// <param name="epsStdDevEstimateLess">Return only records with an EPS standard deviation less than this value (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseZacksEPSSurprises</returns>
        ApiResponse<ApiResponseZacksEPSSurprises> GetZacksEpsSurprisesWithHttpInfo (DateTime? startDate = null, DateTime? endDate = null, decimal? epsActualGreater = null, decimal? epsActualLess = null, decimal? epsMeanEstimateGreater = null, decimal? epsMeanEstimateLess = null, decimal? epsAmountDiffGreater = null, decimal? epsAmountDiffLess = null, decimal? epsPercentDiffGreater = null, decimal? epsPercentDiffLess = null, decimal? epsCountEstimateGreater = null, decimal? epsCountEstimateLess = null, decimal? epsStdDevEstimateGreater = null, decimal? epsStdDevEstimateLess = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Zacks ETF Holdings
        /// </summary>
        /// <remarks>
        /// Returns Zacks ETF holdings data
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="etfTicker">Return holdings of the ETF with the given ticker (optional)</param>
        /// <param name="holdingSymbol">Return holdings where the instrument being held has the given trading symbol (optional)</param>
        /// <param name="weightGreater">Return on the holdings with a weight greater than (optional)</param>
        /// <param name="weightLess">Return on the holdings with a weight less than (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseZacksETFHoldings</returns>
        ApiResponseZacksETFHoldings GetZacksEtfHoldings (string etfTicker = null, string holdingSymbol = null, decimal? weightGreater = null, decimal? weightLess = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Zacks ETF Holdings
        /// </summary>
        /// <remarks>
        /// Returns Zacks ETF holdings data
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="etfTicker">Return holdings of the ETF with the given ticker (optional)</param>
        /// <param name="holdingSymbol">Return holdings where the instrument being held has the given trading symbol (optional)</param>
        /// <param name="weightGreater">Return on the holdings with a weight greater than (optional)</param>
        /// <param name="weightLess">Return on the holdings with a weight less than (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseZacksETFHoldings</returns>
        ApiResponse<ApiResponseZacksETFHoldings> GetZacksEtfHoldingsWithHttpInfo (string etfTicker = null, string holdingSymbol = null, decimal? weightGreater = null, decimal? weightLess = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Zacks Forward PE Estimates
        /// </summary>
        /// <remarks>
        /// This database offers price-to-earning ratio estimates for over 4,000 US and Canadian listed companies.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseZacksForwardPEs</returns>
        ApiResponseZacksForwardPEs GetZacksForwardPe (string nextPage = null);

        /// <summary>
        /// Zacks Forward PE Estimates
        /// </summary>
        /// <remarks>
        /// This database offers price-to-earning ratio estimates for over 4,000 US and Canadian listed companies.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseZacksForwardPEs</returns>
        ApiResponse<ApiResponseZacksForwardPEs> GetZacksForwardPeWithHttpInfo (string nextPage = null);
        /// <summary>
        /// Zacks Forward PE by identifer
        /// </summary>
        /// <remarks>
        /// Returns the forward PE estimates for the identifier
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Intrinio ID or ticker for a Security</param>
        /// <returns>ZacksForwardPE</returns>
        ZacksForwardPE GetZacksForwardPeByIdentifier (string identifier);

        /// <summary>
        /// Zacks Forward PE by identifer
        /// </summary>
        /// <remarks>
        /// Returns the forward PE estimates for the identifier
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Intrinio ID or ticker for a Security</param>
        /// <returns>ApiResponse of ZacksForwardPE</returns>
        ApiResponse<ZacksForwardPE> GetZacksForwardPeByIdentifierWithHttpInfo (string identifier);
        /// <summary>
        /// Zacks Institutional Holding Companies
        /// </summary>
        /// <remarks>
        /// Returns Zacks institutional holding companies data
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ticker">Return companies with the given ticker (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseZacksInstitutionalHoldingCompanies</returns>
        ApiResponseZacksInstitutionalHoldingCompanies GetZacksInstitutionalHoldingCompanies (string ticker = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Zacks Institutional Holding Companies
        /// </summary>
        /// <remarks>
        /// Returns Zacks institutional holding companies data
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ticker">Return companies with the given ticker (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseZacksInstitutionalHoldingCompanies</returns>
        ApiResponse<ApiResponseZacksInstitutionalHoldingCompanies> GetZacksInstitutionalHoldingCompaniesWithHttpInfo (string ticker = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Zacks Institutional Holding Owners
        /// </summary>
        /// <remarks>
        /// Returns Zacks institutional holding owners data
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cik">Return owners with the given Central Index Key (CIK) (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseZacksInstitutionalHoldingOwners</returns>
        ApiResponseZacksInstitutionalHoldingOwners GetZacksInstitutionalHoldingOwners (string cik = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Zacks Institutional Holding Owners
        /// </summary>
        /// <remarks>
        /// Returns Zacks institutional holding owners data
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cik">Return owners with the given Central Index Key (CIK) (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseZacksInstitutionalHoldingOwners</returns>
        ApiResponse<ApiResponseZacksInstitutionalHoldingOwners> GetZacksInstitutionalHoldingOwnersWithHttpInfo (string cik = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Zacks Institutional Holdings
        /// </summary>
        /// <remarks>
        /// Returns Zacks institutional holdings data
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ticker">Return holdings where the company being held has the given ticker (optional)</param>
        /// <param name="ownerCik">Return holdings where the owner/holder has the given Central Index Key (CIK) (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseZacksInstitutionalHoldings</returns>
        ApiResponseZacksInstitutionalHoldings GetZacksInstitutionalHoldings (string ticker = null, string ownerCik = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Zacks Institutional Holdings
        /// </summary>
        /// <remarks>
        /// Returns Zacks institutional holdings data
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ticker">Return holdings where the company being held has the given ticker (optional)</param>
        /// <param name="ownerCik">Return holdings where the owner/holder has the given Central Index Key (CIK) (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseZacksInstitutionalHoldings</returns>
        ApiResponse<ApiResponseZacksInstitutionalHoldings> GetZacksInstitutionalHoldingsWithHttpInfo (string ticker = null, string ownerCik = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Zacks Long Term Growth Rates
        /// </summary>
        /// <remarks>
        /// This database offers consensus long term growth rate estimates, including insight into changes in estimates and revisions over time.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseZacksLongTermGrowthRates</returns>
        ApiResponseZacksLongTermGrowthRates GetZacksLongTermGrowthRates (string identifier = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Zacks Long Term Growth Rates
        /// </summary>
        /// <remarks>
        /// This database offers consensus long term growth rate estimates, including insight into changes in estimates and revisions over time.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseZacksLongTermGrowthRates</returns>
        ApiResponse<ApiResponseZacksLongTermGrowthRates> GetZacksLongTermGrowthRatesWithHttpInfo (string identifier = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Zacks Sales Estimates
        /// </summary>
        /// <remarks>
        /// This database offers consensus sales estimates for over 5,000 US and Canadian listed companies.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID) (optional)</param>
        /// <param name="startDate">Limit Sales estimates to those on or after this date (optional)</param>
        /// <param name="endDate">Limit Sales estimates to those on or before this date (optional)</param>
        /// <param name="fiscalYear">Only for the given fiscal year (optional)</param>
        /// <param name="fiscalPeriod">The fiscal period (optional)</param>
        /// <param name="calendarYear">Only for the given calendar year (optional)</param>
        /// <param name="calendarPeriod">The calendar period (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage2">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseZacksSalesEstimates</returns>
        ApiResponseZacksSalesEstimates GetZacksSalesEstimates (string identifier = null, DateTime? startDate = null, DateTime? endDate = null, int? fiscalYear = null, string fiscalPeriod = null, int? calendarYear = null, string calendarPeriod = null, string nextPage = null, int? pageSize = null, string nextPage2 = null);

        /// <summary>
        /// Zacks Sales Estimates
        /// </summary>
        /// <remarks>
        /// This database offers consensus sales estimates for over 5,000 US and Canadian listed companies.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID) (optional)</param>
        /// <param name="startDate">Limit Sales estimates to those on or after this date (optional)</param>
        /// <param name="endDate">Limit Sales estimates to those on or before this date (optional)</param>
        /// <param name="fiscalYear">Only for the given fiscal year (optional)</param>
        /// <param name="fiscalPeriod">The fiscal period (optional)</param>
        /// <param name="calendarYear">Only for the given calendar year (optional)</param>
        /// <param name="calendarPeriod">The calendar period (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage2">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseZacksSalesEstimates</returns>
        ApiResponse<ApiResponseZacksSalesEstimates> GetZacksSalesEstimatesWithHttpInfo (string identifier = null, DateTime? startDate = null, DateTime? endDate = null, int? fiscalYear = null, string fiscalPeriod = null, int? calendarYear = null, string calendarPeriod = null, string nextPage = null, int? pageSize = null, string nextPage2 = null);
        /// <summary>
        /// Zacks Sales Surprises
        /// </summary>
        /// <remarks>
        /// This database returns historical estimated and actual sales, guidance, and announcement dates for 17,000+ US and Canadian listed companies.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Limit sales surprises to those on or after this date (optional)</param>
        /// <param name="endDate">Limit sales surprises to those on or before this date (optional)</param>
        /// <param name="salesActualGreater">Return only records with an actual sales higher than this value (optional)</param>
        /// <param name="salesActualLess">Return only records with an actual sales lower than this value (optional)</param>
        /// <param name="salesMeanEstimateGreater">Return only records with a sales mean estimate greater than this value (optional)</param>
        /// <param name="salesMeanEstimateLess">Return only records with a sales mean estimate lower than this value (optional)</param>
        /// <param name="salesAmountDiffGreater">Return only records with a sales amount difference greater than this value (optional)</param>
        /// <param name="salesAmountDiffLess">Return only records with a sales amount difference less than this value (optional)</param>
        /// <param name="salesPercentDiffGreater">Return only records with a sales percent difference greater than this value (optional)</param>
        /// <param name="salesPercentDiffLess">Return only records with a sales percent difference less than this value (optional)</param>
        /// <param name="salesCountEstimateGreater">Return only records with a sales count estimate greater than this value (optional)</param>
        /// <param name="salesCountEstimateLess">Return only records with a sales count estimate less than this value (optional)</param>
        /// <param name="salesStdDevEstimateGreater">Return only records with a sales standard deviation greater than this value (optional)</param>
        /// <param name="salesStdDevEstimateLess">Return only records with a sales standard deviation less than this value (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseZacksSalesSurprises</returns>
        ApiResponseZacksSalesSurprises GetZacksSalesSurprises (DateTime? startDate = null, DateTime? endDate = null, decimal? salesActualGreater = null, decimal? salesActualLess = null, decimal? salesMeanEstimateGreater = null, decimal? salesMeanEstimateLess = null, decimal? salesAmountDiffGreater = null, decimal? salesAmountDiffLess = null, decimal? salesPercentDiffGreater = null, decimal? salesPercentDiffLess = null, decimal? salesCountEstimateGreater = null, decimal? salesCountEstimateLess = null, decimal? salesStdDevEstimateGreater = null, decimal? salesStdDevEstimateLess = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Zacks Sales Surprises
        /// </summary>
        /// <remarks>
        /// This database returns historical estimated and actual sales, guidance, and announcement dates for 17,000+ US and Canadian listed companies.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Limit sales surprises to those on or after this date (optional)</param>
        /// <param name="endDate">Limit sales surprises to those on or before this date (optional)</param>
        /// <param name="salesActualGreater">Return only records with an actual sales higher than this value (optional)</param>
        /// <param name="salesActualLess">Return only records with an actual sales lower than this value (optional)</param>
        /// <param name="salesMeanEstimateGreater">Return only records with a sales mean estimate greater than this value (optional)</param>
        /// <param name="salesMeanEstimateLess">Return only records with a sales mean estimate lower than this value (optional)</param>
        /// <param name="salesAmountDiffGreater">Return only records with a sales amount difference greater than this value (optional)</param>
        /// <param name="salesAmountDiffLess">Return only records with a sales amount difference less than this value (optional)</param>
        /// <param name="salesPercentDiffGreater">Return only records with a sales percent difference greater than this value (optional)</param>
        /// <param name="salesPercentDiffLess">Return only records with a sales percent difference less than this value (optional)</param>
        /// <param name="salesCountEstimateGreater">Return only records with a sales count estimate greater than this value (optional)</param>
        /// <param name="salesCountEstimateLess">Return only records with a sales count estimate less than this value (optional)</param>
        /// <param name="salesStdDevEstimateGreater">Return only records with a sales standard deviation greater than this value (optional)</param>
        /// <param name="salesStdDevEstimateLess">Return only records with a sales standard deviation less than this value (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseZacksSalesSurprises</returns>
        ApiResponse<ApiResponseZacksSalesSurprises> GetZacksSalesSurprisesWithHttpInfo (DateTime? startDate = null, DateTime? endDate = null, decimal? salesActualGreater = null, decimal? salesActualLess = null, decimal? salesMeanEstimateGreater = null, decimal? salesMeanEstimateLess = null, decimal? salesAmountDiffGreater = null, decimal? salesAmountDiffLess = null, decimal? salesPercentDiffGreater = null, decimal? salesPercentDiffLess = null, decimal? salesCountEstimateGreater = null, decimal? salesCountEstimateLess = null, decimal? salesStdDevEstimateGreater = null, decimal? salesStdDevEstimateLess = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Zacks Target Price Consensuses
        /// </summary>
        /// <remarks>
        /// Returns the latest Zacks target price consensus data
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">Filings for the given &#x60;company&#x60; identifier (ticker, CIK, LEI, Intrinio ID) (optional)</param>
        /// <param name="industryGroupNumber">Return only growth rates for companies in the given Zacks industry group number (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseZacksTargetPriceConsensuses</returns>
        ApiResponseZacksTargetPriceConsensuses GetZacksTargetPriceConsensuses (string identifier = null, string industryGroupNumber = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Zacks Target Price Consensuses
        /// </summary>
        /// <remarks>
        /// Returns the latest Zacks target price consensus data
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">Filings for the given &#x60;company&#x60; identifier (ticker, CIK, LEI, Intrinio ID) (optional)</param>
        /// <param name="industryGroupNumber">Return only growth rates for companies in the given Zacks industry group number (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseZacksTargetPriceConsensuses</returns>
        ApiResponse<ApiResponseZacksTargetPriceConsensuses> GetZacksTargetPriceConsensusesWithHttpInfo (string identifier = null, string industryGroupNumber = null, int? pageSize = null, string nextPage = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Zacks Analyst Ratings
        /// </summary>
        /// <remarks>
        /// This database offers consensus analyst recommendations for over 5,000 US and Canadian listed companies.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) (optional)</param>
        /// <param name="startDate">Limit ratings to those on or after this date (optional)</param>
        /// <param name="endDate">Limit ratings to those on or before this date (optional)</param>
        /// <param name="meanGreater">Return only records with a mean (average) higher than this value (optional)</param>
        /// <param name="meanLess">Return only records with a mean (average) lower than this value (optional)</param>
        /// <param name="strongBuysGreater">Return only records with more than this many Strong Buy recommendations (optional)</param>
        /// <param name="strongBuysLess">Return only records with fewer than this many Strong Buy recommendations (optional)</param>
        /// <param name="buysGreater">Return only records with more than this many Buy recommendations (optional)</param>
        /// <param name="buysLess">Return only records with fewer than this many Buy recommendations (optional)</param>
        /// <param name="holdsGreater">Return only records with more than this many Hold recommendations (optional)</param>
        /// <param name="holdsLess">Return only records with fewer than this many Hold recommendations (optional)</param>
        /// <param name="sellsGreater">Return only records with more than this many Sell recommendations (optional)</param>
        /// <param name="sellsLess">Return only records with fewer than this many Sell recommendations (optional)</param>
        /// <param name="strongSellsGreater">Return only records with more than this many Strong Sell recommendations (optional)</param>
        /// <param name="strongSellsLess">Return only records with fewer than this many Strong Sell recommendations (optional)</param>
        /// <param name="totalGreater">Return only records with more than this many recommendations, regardless of type (optional)</param>
        /// <param name="totalLess">Return only records with fewer than this many recommendations, regardless of type (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseZacksAnalystRatings</returns>
        System.Threading.Tasks.Task<ApiResponseZacksAnalystRatings> GetZacksAnalystRatingsAsync (string identifier = null, DateTime? startDate = null, DateTime? endDate = null, decimal? meanGreater = null, decimal? meanLess = null, int? strongBuysGreater = null, int? strongBuysLess = null, int? buysGreater = null, int? buysLess = null, int? holdsGreater = null, int? holdsLess = null, int? sellsGreater = null, int? sellsLess = null, int? strongSellsGreater = null, int? strongSellsLess = null, int? totalGreater = null, int? totalLess = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Zacks Analyst Ratings
        /// </summary>
        /// <remarks>
        /// This database offers consensus analyst recommendations for over 5,000 US and Canadian listed companies.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) (optional)</param>
        /// <param name="startDate">Limit ratings to those on or after this date (optional)</param>
        /// <param name="endDate">Limit ratings to those on or before this date (optional)</param>
        /// <param name="meanGreater">Return only records with a mean (average) higher than this value (optional)</param>
        /// <param name="meanLess">Return only records with a mean (average) lower than this value (optional)</param>
        /// <param name="strongBuysGreater">Return only records with more than this many Strong Buy recommendations (optional)</param>
        /// <param name="strongBuysLess">Return only records with fewer than this many Strong Buy recommendations (optional)</param>
        /// <param name="buysGreater">Return only records with more than this many Buy recommendations (optional)</param>
        /// <param name="buysLess">Return only records with fewer than this many Buy recommendations (optional)</param>
        /// <param name="holdsGreater">Return only records with more than this many Hold recommendations (optional)</param>
        /// <param name="holdsLess">Return only records with fewer than this many Hold recommendations (optional)</param>
        /// <param name="sellsGreater">Return only records with more than this many Sell recommendations (optional)</param>
        /// <param name="sellsLess">Return only records with fewer than this many Sell recommendations (optional)</param>
        /// <param name="strongSellsGreater">Return only records with more than this many Strong Sell recommendations (optional)</param>
        /// <param name="strongSellsLess">Return only records with fewer than this many Strong Sell recommendations (optional)</param>
        /// <param name="totalGreater">Return only records with more than this many recommendations, regardless of type (optional)</param>
        /// <param name="totalLess">Return only records with fewer than this many recommendations, regardless of type (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseZacksAnalystRatings)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseZacksAnalystRatings>> GetZacksAnalystRatingsAsyncWithHttpInfo (string identifier = null, DateTime? startDate = null, DateTime? endDate = null, decimal? meanGreater = null, decimal? meanLess = null, int? strongBuysGreater = null, int? strongBuysLess = null, int? buysGreater = null, int? buysLess = null, int? holdsGreater = null, int? holdsLess = null, int? sellsGreater = null, int? sellsLess = null, int? strongSellsGreater = null, int? strongSellsLess = null, int? totalGreater = null, int? totalLess = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Zacks EBITDA Consensus
        /// </summary>
        /// <remarks>
        /// This database offers consensus EBITDA-related estimates for over 4,000 US and Canadian listed companies.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID) (optional)</param>
        /// <param name="type">Limit EBITDA estimates to this type (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseZacksEBITDAConsensus</returns>
        System.Threading.Tasks.Task<ApiResponseZacksEBITDAConsensus> GetZacksEbitdaConsensusAsync (string identifier = null, string type = null, string nextPage = null);

        /// <summary>
        /// Zacks EBITDA Consensus
        /// </summary>
        /// <remarks>
        /// This database offers consensus EBITDA-related estimates for over 4,000 US and Canadian listed companies.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID) (optional)</param>
        /// <param name="type">Limit EBITDA estimates to this type (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseZacksEBITDAConsensus)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseZacksEBITDAConsensus>> GetZacksEbitdaConsensusAsyncWithHttpInfo (string identifier = null, string type = null, string nextPage = null);
        /// <summary>
        /// Zacks EPS Estimates
        /// </summary>
        /// <remarks>
        /// This database offers consensus earnings estimates for over 5,000 US and Canadian listed companies.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID) (optional)</param>
        /// <param name="startDate">Limit EPS estimates to those on or after this date (optional)</param>
        /// <param name="endDate">Limit EPS estimates to those on or before this date (optional)</param>
        /// <param name="fiscalYear">Only for the given fiscal year (optional)</param>
        /// <param name="fiscalPeriod">The fiscal period (optional)</param>
        /// <param name="calendarYear">Only for the given calendar year (optional)</param>
        /// <param name="calendarPeriod">The calendar period (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseZacksEPSEstimates</returns>
        System.Threading.Tasks.Task<ApiResponseZacksEPSEstimates> GetZacksEpsEstimatesAsync (string identifier = null, DateTime? startDate = null, DateTime? endDate = null, int? fiscalYear = null, string fiscalPeriod = null, int? calendarYear = null, string calendarPeriod = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Zacks EPS Estimates
        /// </summary>
        /// <remarks>
        /// This database offers consensus earnings estimates for over 5,000 US and Canadian listed companies.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID) (optional)</param>
        /// <param name="startDate">Limit EPS estimates to those on or after this date (optional)</param>
        /// <param name="endDate">Limit EPS estimates to those on or before this date (optional)</param>
        /// <param name="fiscalYear">Only for the given fiscal year (optional)</param>
        /// <param name="fiscalPeriod">The fiscal period (optional)</param>
        /// <param name="calendarYear">Only for the given calendar year (optional)</param>
        /// <param name="calendarPeriod">The calendar period (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseZacksEPSEstimates)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseZacksEPSEstimates>> GetZacksEpsEstimatesAsyncWithHttpInfo (string identifier = null, DateTime? startDate = null, DateTime? endDate = null, int? fiscalYear = null, string fiscalPeriod = null, int? calendarYear = null, string calendarPeriod = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Zacks EPS Growth Rates
        /// </summary>
        /// <remarks>
        /// This database offers consensus EPS growth rate estimates, comparing company estimates to historical company estimates, industry estimates, and S&amp;P 500 index estimates.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="company">Filings for the given &#x60;company&#x60; identifier (ticker, CIK, LEI, Intrinio ID) (optional)</param>
        /// <param name="industryGroupName">Return only growth rates for companies in the given Zacks industry group name (optional)</param>
        /// <param name="industryGroupNumber">Return only growth rates for companies in the given Zacks industry group number (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseZacksEPSGrowthRates</returns>
        System.Threading.Tasks.Task<ApiResponseZacksEPSGrowthRates> GetZacksEpsGrowthRatesAsync (string company = null, string industryGroupName = null, string industryGroupNumber = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Zacks EPS Growth Rates
        /// </summary>
        /// <remarks>
        /// This database offers consensus EPS growth rate estimates, comparing company estimates to historical company estimates, industry estimates, and S&amp;P 500 index estimates.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="company">Filings for the given &#x60;company&#x60; identifier (ticker, CIK, LEI, Intrinio ID) (optional)</param>
        /// <param name="industryGroupName">Return only growth rates for companies in the given Zacks industry group name (optional)</param>
        /// <param name="industryGroupNumber">Return only growth rates for companies in the given Zacks industry group number (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseZacksEPSGrowthRates)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseZacksEPSGrowthRates>> GetZacksEpsGrowthRatesAsyncWithHttpInfo (string company = null, string industryGroupName = null, string industryGroupNumber = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Zacks EPS Surprises
        /// </summary>
        /// <remarks>
        /// This database returns historical estimated and actual earnings, guidance, and announcement dates for 17,000+ US and Canadian listed companies.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Limit EPS surprises to those on or after this date (optional)</param>
        /// <param name="endDate">Limit EPS surprises to those on or before this date (optional)</param>
        /// <param name="epsActualGreater">Return only records with an actual EPS higher than this value (optional)</param>
        /// <param name="epsActualLess">Return only records with an actual EPS lower than this value (optional)</param>
        /// <param name="epsMeanEstimateGreater">Return only records with an EPS mean estimate greater than this value (optional)</param>
        /// <param name="epsMeanEstimateLess">Return only records with an EPS mean estimate lower than this value (optional)</param>
        /// <param name="epsAmountDiffGreater">Return only records with an EPS amount difference greater than this value (optional)</param>
        /// <param name="epsAmountDiffLess">Return only records with an EPS amount difference less than this value (optional)</param>
        /// <param name="epsPercentDiffGreater">Return only records with an EPS percent difference greater than this value (optional)</param>
        /// <param name="epsPercentDiffLess">Return only records with an EPS percent difference less than this value (optional)</param>
        /// <param name="epsCountEstimateGreater">Return only records with an EPS count estimate greater than this value (optional)</param>
        /// <param name="epsCountEstimateLess">Return only records with an EPS count estimate less than this value (optional)</param>
        /// <param name="epsStdDevEstimateGreater">Return only records with an EPS standard deviation greater than this value (optional)</param>
        /// <param name="epsStdDevEstimateLess">Return only records with an EPS standard deviation less than this value (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseZacksEPSSurprises</returns>
        System.Threading.Tasks.Task<ApiResponseZacksEPSSurprises> GetZacksEpsSurprisesAsync (DateTime? startDate = null, DateTime? endDate = null, decimal? epsActualGreater = null, decimal? epsActualLess = null, decimal? epsMeanEstimateGreater = null, decimal? epsMeanEstimateLess = null, decimal? epsAmountDiffGreater = null, decimal? epsAmountDiffLess = null, decimal? epsPercentDiffGreater = null, decimal? epsPercentDiffLess = null, decimal? epsCountEstimateGreater = null, decimal? epsCountEstimateLess = null, decimal? epsStdDevEstimateGreater = null, decimal? epsStdDevEstimateLess = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Zacks EPS Surprises
        /// </summary>
        /// <remarks>
        /// This database returns historical estimated and actual earnings, guidance, and announcement dates for 17,000+ US and Canadian listed companies.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Limit EPS surprises to those on or after this date (optional)</param>
        /// <param name="endDate">Limit EPS surprises to those on or before this date (optional)</param>
        /// <param name="epsActualGreater">Return only records with an actual EPS higher than this value (optional)</param>
        /// <param name="epsActualLess">Return only records with an actual EPS lower than this value (optional)</param>
        /// <param name="epsMeanEstimateGreater">Return only records with an EPS mean estimate greater than this value (optional)</param>
        /// <param name="epsMeanEstimateLess">Return only records with an EPS mean estimate lower than this value (optional)</param>
        /// <param name="epsAmountDiffGreater">Return only records with an EPS amount difference greater than this value (optional)</param>
        /// <param name="epsAmountDiffLess">Return only records with an EPS amount difference less than this value (optional)</param>
        /// <param name="epsPercentDiffGreater">Return only records with an EPS percent difference greater than this value (optional)</param>
        /// <param name="epsPercentDiffLess">Return only records with an EPS percent difference less than this value (optional)</param>
        /// <param name="epsCountEstimateGreater">Return only records with an EPS count estimate greater than this value (optional)</param>
        /// <param name="epsCountEstimateLess">Return only records with an EPS count estimate less than this value (optional)</param>
        /// <param name="epsStdDevEstimateGreater">Return only records with an EPS standard deviation greater than this value (optional)</param>
        /// <param name="epsStdDevEstimateLess">Return only records with an EPS standard deviation less than this value (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseZacksEPSSurprises)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseZacksEPSSurprises>> GetZacksEpsSurprisesAsyncWithHttpInfo (DateTime? startDate = null, DateTime? endDate = null, decimal? epsActualGreater = null, decimal? epsActualLess = null, decimal? epsMeanEstimateGreater = null, decimal? epsMeanEstimateLess = null, decimal? epsAmountDiffGreater = null, decimal? epsAmountDiffLess = null, decimal? epsPercentDiffGreater = null, decimal? epsPercentDiffLess = null, decimal? epsCountEstimateGreater = null, decimal? epsCountEstimateLess = null, decimal? epsStdDevEstimateGreater = null, decimal? epsStdDevEstimateLess = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Zacks ETF Holdings
        /// </summary>
        /// <remarks>
        /// Returns Zacks ETF holdings data
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="etfTicker">Return holdings of the ETF with the given ticker (optional)</param>
        /// <param name="holdingSymbol">Return holdings where the instrument being held has the given trading symbol (optional)</param>
        /// <param name="weightGreater">Return on the holdings with a weight greater than (optional)</param>
        /// <param name="weightLess">Return on the holdings with a weight less than (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseZacksETFHoldings</returns>
        System.Threading.Tasks.Task<ApiResponseZacksETFHoldings> GetZacksEtfHoldingsAsync (string etfTicker = null, string holdingSymbol = null, decimal? weightGreater = null, decimal? weightLess = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Zacks ETF Holdings
        /// </summary>
        /// <remarks>
        /// Returns Zacks ETF holdings data
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="etfTicker">Return holdings of the ETF with the given ticker (optional)</param>
        /// <param name="holdingSymbol">Return holdings where the instrument being held has the given trading symbol (optional)</param>
        /// <param name="weightGreater">Return on the holdings with a weight greater than (optional)</param>
        /// <param name="weightLess">Return on the holdings with a weight less than (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseZacksETFHoldings)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseZacksETFHoldings>> GetZacksEtfHoldingsAsyncWithHttpInfo (string etfTicker = null, string holdingSymbol = null, decimal? weightGreater = null, decimal? weightLess = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Zacks Forward PE Estimates
        /// </summary>
        /// <remarks>
        /// This database offers price-to-earning ratio estimates for over 4,000 US and Canadian listed companies.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseZacksForwardPEs</returns>
        System.Threading.Tasks.Task<ApiResponseZacksForwardPEs> GetZacksForwardPeAsync (string nextPage = null);

        /// <summary>
        /// Zacks Forward PE Estimates
        /// </summary>
        /// <remarks>
        /// This database offers price-to-earning ratio estimates for over 4,000 US and Canadian listed companies.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseZacksForwardPEs)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseZacksForwardPEs>> GetZacksForwardPeAsyncWithHttpInfo (string nextPage = null);
        /// <summary>
        /// Zacks Forward PE by identifer
        /// </summary>
        /// <remarks>
        /// Returns the forward PE estimates for the identifier
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Intrinio ID or ticker for a Security</param>
        /// <returns>Task of ZacksForwardPE</returns>
        System.Threading.Tasks.Task<ZacksForwardPE> GetZacksForwardPeByIdentifierAsync (string identifier);

        /// <summary>
        /// Zacks Forward PE by identifer
        /// </summary>
        /// <remarks>
        /// Returns the forward PE estimates for the identifier
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Intrinio ID or ticker for a Security</param>
        /// <returns>Task of ApiResponse (ZacksForwardPE)</returns>
        System.Threading.Tasks.Task<ApiResponse<ZacksForwardPE>> GetZacksForwardPeByIdentifierAsyncWithHttpInfo (string identifier);
        /// <summary>
        /// Zacks Institutional Holding Companies
        /// </summary>
        /// <remarks>
        /// Returns Zacks institutional holding companies data
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ticker">Return companies with the given ticker (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseZacksInstitutionalHoldingCompanies</returns>
        System.Threading.Tasks.Task<ApiResponseZacksInstitutionalHoldingCompanies> GetZacksInstitutionalHoldingCompaniesAsync (string ticker = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Zacks Institutional Holding Companies
        /// </summary>
        /// <remarks>
        /// Returns Zacks institutional holding companies data
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ticker">Return companies with the given ticker (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseZacksInstitutionalHoldingCompanies)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseZacksInstitutionalHoldingCompanies>> GetZacksInstitutionalHoldingCompaniesAsyncWithHttpInfo (string ticker = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Zacks Institutional Holding Owners
        /// </summary>
        /// <remarks>
        /// Returns Zacks institutional holding owners data
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cik">Return owners with the given Central Index Key (CIK) (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseZacksInstitutionalHoldingOwners</returns>
        System.Threading.Tasks.Task<ApiResponseZacksInstitutionalHoldingOwners> GetZacksInstitutionalHoldingOwnersAsync (string cik = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Zacks Institutional Holding Owners
        /// </summary>
        /// <remarks>
        /// Returns Zacks institutional holding owners data
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cik">Return owners with the given Central Index Key (CIK) (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseZacksInstitutionalHoldingOwners)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseZacksInstitutionalHoldingOwners>> GetZacksInstitutionalHoldingOwnersAsyncWithHttpInfo (string cik = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Zacks Institutional Holdings
        /// </summary>
        /// <remarks>
        /// Returns Zacks institutional holdings data
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ticker">Return holdings where the company being held has the given ticker (optional)</param>
        /// <param name="ownerCik">Return holdings where the owner/holder has the given Central Index Key (CIK) (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseZacksInstitutionalHoldings</returns>
        System.Threading.Tasks.Task<ApiResponseZacksInstitutionalHoldings> GetZacksInstitutionalHoldingsAsync (string ticker = null, string ownerCik = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Zacks Institutional Holdings
        /// </summary>
        /// <remarks>
        /// Returns Zacks institutional holdings data
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ticker">Return holdings where the company being held has the given ticker (optional)</param>
        /// <param name="ownerCik">Return holdings where the owner/holder has the given Central Index Key (CIK) (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseZacksInstitutionalHoldings)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseZacksInstitutionalHoldings>> GetZacksInstitutionalHoldingsAsyncWithHttpInfo (string ticker = null, string ownerCik = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Zacks Long Term Growth Rates
        /// </summary>
        /// <remarks>
        /// This database offers consensus long term growth rate estimates, including insight into changes in estimates and revisions over time.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseZacksLongTermGrowthRates</returns>
        System.Threading.Tasks.Task<ApiResponseZacksLongTermGrowthRates> GetZacksLongTermGrowthRatesAsync (string identifier = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Zacks Long Term Growth Rates
        /// </summary>
        /// <remarks>
        /// This database offers consensus long term growth rate estimates, including insight into changes in estimates and revisions over time.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseZacksLongTermGrowthRates)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseZacksLongTermGrowthRates>> GetZacksLongTermGrowthRatesAsyncWithHttpInfo (string identifier = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Zacks Sales Estimates
        /// </summary>
        /// <remarks>
        /// This database offers consensus sales estimates for over 5,000 US and Canadian listed companies.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID) (optional)</param>
        /// <param name="startDate">Limit Sales estimates to those on or after this date (optional)</param>
        /// <param name="endDate">Limit Sales estimates to those on or before this date (optional)</param>
        /// <param name="fiscalYear">Only for the given fiscal year (optional)</param>
        /// <param name="fiscalPeriod">The fiscal period (optional)</param>
        /// <param name="calendarYear">Only for the given calendar year (optional)</param>
        /// <param name="calendarPeriod">The calendar period (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage2">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseZacksSalesEstimates</returns>
        System.Threading.Tasks.Task<ApiResponseZacksSalesEstimates> GetZacksSalesEstimatesAsync (string identifier = null, DateTime? startDate = null, DateTime? endDate = null, int? fiscalYear = null, string fiscalPeriod = null, int? calendarYear = null, string calendarPeriod = null, string nextPage = null, int? pageSize = null, string nextPage2 = null);

        /// <summary>
        /// Zacks Sales Estimates
        /// </summary>
        /// <remarks>
        /// This database offers consensus sales estimates for over 5,000 US and Canadian listed companies.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID) (optional)</param>
        /// <param name="startDate">Limit Sales estimates to those on or after this date (optional)</param>
        /// <param name="endDate">Limit Sales estimates to those on or before this date (optional)</param>
        /// <param name="fiscalYear">Only for the given fiscal year (optional)</param>
        /// <param name="fiscalPeriod">The fiscal period (optional)</param>
        /// <param name="calendarYear">Only for the given calendar year (optional)</param>
        /// <param name="calendarPeriod">The calendar period (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage2">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseZacksSalesEstimates)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseZacksSalesEstimates>> GetZacksSalesEstimatesAsyncWithHttpInfo (string identifier = null, DateTime? startDate = null, DateTime? endDate = null, int? fiscalYear = null, string fiscalPeriod = null, int? calendarYear = null, string calendarPeriod = null, string nextPage = null, int? pageSize = null, string nextPage2 = null);
        /// <summary>
        /// Zacks Sales Surprises
        /// </summary>
        /// <remarks>
        /// This database returns historical estimated and actual sales, guidance, and announcement dates for 17,000+ US and Canadian listed companies.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Limit sales surprises to those on or after this date (optional)</param>
        /// <param name="endDate">Limit sales surprises to those on or before this date (optional)</param>
        /// <param name="salesActualGreater">Return only records with an actual sales higher than this value (optional)</param>
        /// <param name="salesActualLess">Return only records with an actual sales lower than this value (optional)</param>
        /// <param name="salesMeanEstimateGreater">Return only records with a sales mean estimate greater than this value (optional)</param>
        /// <param name="salesMeanEstimateLess">Return only records with a sales mean estimate lower than this value (optional)</param>
        /// <param name="salesAmountDiffGreater">Return only records with a sales amount difference greater than this value (optional)</param>
        /// <param name="salesAmountDiffLess">Return only records with a sales amount difference less than this value (optional)</param>
        /// <param name="salesPercentDiffGreater">Return only records with a sales percent difference greater than this value (optional)</param>
        /// <param name="salesPercentDiffLess">Return only records with a sales percent difference less than this value (optional)</param>
        /// <param name="salesCountEstimateGreater">Return only records with a sales count estimate greater than this value (optional)</param>
        /// <param name="salesCountEstimateLess">Return only records with a sales count estimate less than this value (optional)</param>
        /// <param name="salesStdDevEstimateGreater">Return only records with a sales standard deviation greater than this value (optional)</param>
        /// <param name="salesStdDevEstimateLess">Return only records with a sales standard deviation less than this value (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseZacksSalesSurprises</returns>
        System.Threading.Tasks.Task<ApiResponseZacksSalesSurprises> GetZacksSalesSurprisesAsync (DateTime? startDate = null, DateTime? endDate = null, decimal? salesActualGreater = null, decimal? salesActualLess = null, decimal? salesMeanEstimateGreater = null, decimal? salesMeanEstimateLess = null, decimal? salesAmountDiffGreater = null, decimal? salesAmountDiffLess = null, decimal? salesPercentDiffGreater = null, decimal? salesPercentDiffLess = null, decimal? salesCountEstimateGreater = null, decimal? salesCountEstimateLess = null, decimal? salesStdDevEstimateGreater = null, decimal? salesStdDevEstimateLess = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Zacks Sales Surprises
        /// </summary>
        /// <remarks>
        /// This database returns historical estimated and actual sales, guidance, and announcement dates for 17,000+ US and Canadian listed companies.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Limit sales surprises to those on or after this date (optional)</param>
        /// <param name="endDate">Limit sales surprises to those on or before this date (optional)</param>
        /// <param name="salesActualGreater">Return only records with an actual sales higher than this value (optional)</param>
        /// <param name="salesActualLess">Return only records with an actual sales lower than this value (optional)</param>
        /// <param name="salesMeanEstimateGreater">Return only records with a sales mean estimate greater than this value (optional)</param>
        /// <param name="salesMeanEstimateLess">Return only records with a sales mean estimate lower than this value (optional)</param>
        /// <param name="salesAmountDiffGreater">Return only records with a sales amount difference greater than this value (optional)</param>
        /// <param name="salesAmountDiffLess">Return only records with a sales amount difference less than this value (optional)</param>
        /// <param name="salesPercentDiffGreater">Return only records with a sales percent difference greater than this value (optional)</param>
        /// <param name="salesPercentDiffLess">Return only records with a sales percent difference less than this value (optional)</param>
        /// <param name="salesCountEstimateGreater">Return only records with a sales count estimate greater than this value (optional)</param>
        /// <param name="salesCountEstimateLess">Return only records with a sales count estimate less than this value (optional)</param>
        /// <param name="salesStdDevEstimateGreater">Return only records with a sales standard deviation greater than this value (optional)</param>
        /// <param name="salesStdDevEstimateLess">Return only records with a sales standard deviation less than this value (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseZacksSalesSurprises)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseZacksSalesSurprises>> GetZacksSalesSurprisesAsyncWithHttpInfo (DateTime? startDate = null, DateTime? endDate = null, decimal? salesActualGreater = null, decimal? salesActualLess = null, decimal? salesMeanEstimateGreater = null, decimal? salesMeanEstimateLess = null, decimal? salesAmountDiffGreater = null, decimal? salesAmountDiffLess = null, decimal? salesPercentDiffGreater = null, decimal? salesPercentDiffLess = null, decimal? salesCountEstimateGreater = null, decimal? salesCountEstimateLess = null, decimal? salesStdDevEstimateGreater = null, decimal? salesStdDevEstimateLess = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Zacks Target Price Consensuses
        /// </summary>
        /// <remarks>
        /// Returns the latest Zacks target price consensus data
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">Filings for the given &#x60;company&#x60; identifier (ticker, CIK, LEI, Intrinio ID) (optional)</param>
        /// <param name="industryGroupNumber">Return only growth rates for companies in the given Zacks industry group number (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseZacksTargetPriceConsensuses</returns>
        System.Threading.Tasks.Task<ApiResponseZacksTargetPriceConsensuses> GetZacksTargetPriceConsensusesAsync (string identifier = null, string industryGroupNumber = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Zacks Target Price Consensuses
        /// </summary>
        /// <remarks>
        /// Returns the latest Zacks target price consensus data
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">Filings for the given &#x60;company&#x60; identifier (ticker, CIK, LEI, Intrinio ID) (optional)</param>
        /// <param name="industryGroupNumber">Return only growth rates for companies in the given Zacks industry group number (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseZacksTargetPriceConsensuses)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseZacksTargetPriceConsensuses>> GetZacksTargetPriceConsensusesAsyncWithHttpInfo (string identifier = null, string industryGroupNumber = null, int? pageSize = null, string nextPage = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ZacksApi : IZacksApi
    {
        private Intrinio.SDK.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ZacksApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ZacksApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = Intrinio.SDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ZacksApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ZacksApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Intrinio.SDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.Options.BaseUrl.ToString();
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
        public Intrinio.SDK.Client.ExceptionFactory ExceptionFactory
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
        /// Zacks Analyst Ratings This database offers consensus analyst recommendations for over 5,000 US and Canadian listed companies.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) (optional)</param>
        /// <param name="startDate">Limit ratings to those on or after this date (optional)</param>
        /// <param name="endDate">Limit ratings to those on or before this date (optional)</param>
        /// <param name="meanGreater">Return only records with a mean (average) higher than this value (optional)</param>
        /// <param name="meanLess">Return only records with a mean (average) lower than this value (optional)</param>
        /// <param name="strongBuysGreater">Return only records with more than this many Strong Buy recommendations (optional)</param>
        /// <param name="strongBuysLess">Return only records with fewer than this many Strong Buy recommendations (optional)</param>
        /// <param name="buysGreater">Return only records with more than this many Buy recommendations (optional)</param>
        /// <param name="buysLess">Return only records with fewer than this many Buy recommendations (optional)</param>
        /// <param name="holdsGreater">Return only records with more than this many Hold recommendations (optional)</param>
        /// <param name="holdsLess">Return only records with fewer than this many Hold recommendations (optional)</param>
        /// <param name="sellsGreater">Return only records with more than this many Sell recommendations (optional)</param>
        /// <param name="sellsLess">Return only records with fewer than this many Sell recommendations (optional)</param>
        /// <param name="strongSellsGreater">Return only records with more than this many Strong Sell recommendations (optional)</param>
        /// <param name="strongSellsLess">Return only records with fewer than this many Strong Sell recommendations (optional)</param>
        /// <param name="totalGreater">Return only records with more than this many recommendations, regardless of type (optional)</param>
        /// <param name="totalLess">Return only records with fewer than this many recommendations, regardless of type (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseZacksAnalystRatings</returns>
        public ApiResponseZacksAnalystRatings GetZacksAnalystRatings (string identifier = null, DateTime? startDate = null, DateTime? endDate = null, decimal? meanGreater = null, decimal? meanLess = null, int? strongBuysGreater = null, int? strongBuysLess = null, int? buysGreater = null, int? buysLess = null, int? holdsGreater = null, int? holdsLess = null, int? sellsGreater = null, int? sellsLess = null, int? strongSellsGreater = null, int? strongSellsLess = null, int? totalGreater = null, int? totalLess = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseZacksAnalystRatings> localVarResponse = GetZacksAnalystRatingsWithHttpInfo(identifier, startDate, endDate, meanGreater, meanLess, strongBuysGreater, strongBuysLess, buysGreater, buysLess, holdsGreater, holdsLess, sellsGreater, sellsLess, strongSellsGreater, strongSellsLess, totalGreater, totalLess, pageSize, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Zacks Analyst Ratings This database offers consensus analyst recommendations for over 5,000 US and Canadian listed companies.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) (optional)</param>
        /// <param name="startDate">Limit ratings to those on or after this date (optional)</param>
        /// <param name="endDate">Limit ratings to those on or before this date (optional)</param>
        /// <param name="meanGreater">Return only records with a mean (average) higher than this value (optional)</param>
        /// <param name="meanLess">Return only records with a mean (average) lower than this value (optional)</param>
        /// <param name="strongBuysGreater">Return only records with more than this many Strong Buy recommendations (optional)</param>
        /// <param name="strongBuysLess">Return only records with fewer than this many Strong Buy recommendations (optional)</param>
        /// <param name="buysGreater">Return only records with more than this many Buy recommendations (optional)</param>
        /// <param name="buysLess">Return only records with fewer than this many Buy recommendations (optional)</param>
        /// <param name="holdsGreater">Return only records with more than this many Hold recommendations (optional)</param>
        /// <param name="holdsLess">Return only records with fewer than this many Hold recommendations (optional)</param>
        /// <param name="sellsGreater">Return only records with more than this many Sell recommendations (optional)</param>
        /// <param name="sellsLess">Return only records with fewer than this many Sell recommendations (optional)</param>
        /// <param name="strongSellsGreater">Return only records with more than this many Strong Sell recommendations (optional)</param>
        /// <param name="strongSellsLess">Return only records with fewer than this many Strong Sell recommendations (optional)</param>
        /// <param name="totalGreater">Return only records with more than this many recommendations, regardless of type (optional)</param>
        /// <param name="totalLess">Return only records with fewer than this many recommendations, regardless of type (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseZacksAnalystRatings</returns>
        
        
        public ApiResponse< ApiResponseZacksAnalystRatings > GetZacksAnalystRatingsWithHttpInfo (string identifier = null, DateTime? startDate = null, DateTime? endDate = null, decimal? meanGreater = null, decimal? meanLess = null, int? strongBuysGreater = null, int? strongBuysLess = null, int? buysGreater = null, int? buysLess = null, int? holdsGreater = null, int? holdsLess = null, int? sellsGreater = null, int? sellsLess = null, int? strongSellsGreater = null, int? strongSellsLess = null, int? totalGreater = null, int? totalLess = null, int? pageSize = null, string nextPage = null)
        {

            var localVarPath = "/zacks/analyst_ratings";
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
            
            
            if (identifier != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "identifier", identifier)); // query parameter
            if (startDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
            if (endDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
            if (meanGreater != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "mean_greater", meanGreater)); // query parameter
            if (meanLess != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "mean_less", meanLess)); // query parameter
            if (strongBuysGreater != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "strong_buys_greater", strongBuysGreater)); // query parameter
            if (strongBuysLess != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "strong_buys_less", strongBuysLess)); // query parameter
            if (buysGreater != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "buys_greater", buysGreater)); // query parameter
            if (buysLess != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "buys_less", buysLess)); // query parameter
            if (holdsGreater != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "holds_greater", holdsGreater)); // query parameter
            if (holdsLess != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "holds_less", holdsLess)); // query parameter
            if (sellsGreater != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sells_greater", sellsGreater)); // query parameter
            if (sellsLess != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sells_less", sellsLess)); // query parameter
            if (strongSellsGreater != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "strong_sells_greater", strongSellsGreater)); // query parameter
            if (strongSellsLess != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "strong_sells_less", strongSellsLess)); // query parameter
            if (totalGreater != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "total_greater", totalGreater)); // query parameter
            if (totalLess != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "total_less", totalLess)); // query parameter
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetZacksAnalystRatings", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseZacksAnalystRatings>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseZacksAnalystRatings) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseZacksAnalystRatings)));
        }

        /// <summary>
        /// Zacks Analyst Ratings This database offers consensus analyst recommendations for over 5,000 US and Canadian listed companies.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) (optional)</param>
        /// <param name="startDate">Limit ratings to those on or after this date (optional)</param>
        /// <param name="endDate">Limit ratings to those on or before this date (optional)</param>
        /// <param name="meanGreater">Return only records with a mean (average) higher than this value (optional)</param>
        /// <param name="meanLess">Return only records with a mean (average) lower than this value (optional)</param>
        /// <param name="strongBuysGreater">Return only records with more than this many Strong Buy recommendations (optional)</param>
        /// <param name="strongBuysLess">Return only records with fewer than this many Strong Buy recommendations (optional)</param>
        /// <param name="buysGreater">Return only records with more than this many Buy recommendations (optional)</param>
        /// <param name="buysLess">Return only records with fewer than this many Buy recommendations (optional)</param>
        /// <param name="holdsGreater">Return only records with more than this many Hold recommendations (optional)</param>
        /// <param name="holdsLess">Return only records with fewer than this many Hold recommendations (optional)</param>
        /// <param name="sellsGreater">Return only records with more than this many Sell recommendations (optional)</param>
        /// <param name="sellsLess">Return only records with fewer than this many Sell recommendations (optional)</param>
        /// <param name="strongSellsGreater">Return only records with more than this many Strong Sell recommendations (optional)</param>
        /// <param name="strongSellsLess">Return only records with fewer than this many Strong Sell recommendations (optional)</param>
        /// <param name="totalGreater">Return only records with more than this many recommendations, regardless of type (optional)</param>
        /// <param name="totalLess">Return only records with fewer than this many recommendations, regardless of type (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseZacksAnalystRatings</returns>
        public async System.Threading.Tasks.Task<ApiResponseZacksAnalystRatings> GetZacksAnalystRatingsAsync (string identifier = null, DateTime? startDate = null, DateTime? endDate = null, decimal? meanGreater = null, decimal? meanLess = null, int? strongBuysGreater = null, int? strongBuysLess = null, int? buysGreater = null, int? buysLess = null, int? holdsGreater = null, int? holdsLess = null, int? sellsGreater = null, int? sellsLess = null, int? strongSellsGreater = null, int? strongSellsLess = null, int? totalGreater = null, int? totalLess = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseZacksAnalystRatings> localVarResponse = await GetZacksAnalystRatingsAsyncWithHttpInfo(identifier, startDate, endDate, meanGreater, meanLess, strongBuysGreater, strongBuysLess, buysGreater, buysLess, holdsGreater, holdsLess, sellsGreater, sellsLess, strongSellsGreater, strongSellsLess, totalGreater, totalLess, pageSize, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Zacks Analyst Ratings This database offers consensus analyst recommendations for over 5,000 US and Canadian listed companies.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) (optional)</param>
        /// <param name="startDate">Limit ratings to those on or after this date (optional)</param>
        /// <param name="endDate">Limit ratings to those on or before this date (optional)</param>
        /// <param name="meanGreater">Return only records with a mean (average) higher than this value (optional)</param>
        /// <param name="meanLess">Return only records with a mean (average) lower than this value (optional)</param>
        /// <param name="strongBuysGreater">Return only records with more than this many Strong Buy recommendations (optional)</param>
        /// <param name="strongBuysLess">Return only records with fewer than this many Strong Buy recommendations (optional)</param>
        /// <param name="buysGreater">Return only records with more than this many Buy recommendations (optional)</param>
        /// <param name="buysLess">Return only records with fewer than this many Buy recommendations (optional)</param>
        /// <param name="holdsGreater">Return only records with more than this many Hold recommendations (optional)</param>
        /// <param name="holdsLess">Return only records with fewer than this many Hold recommendations (optional)</param>
        /// <param name="sellsGreater">Return only records with more than this many Sell recommendations (optional)</param>
        /// <param name="sellsLess">Return only records with fewer than this many Sell recommendations (optional)</param>
        /// <param name="strongSellsGreater">Return only records with more than this many Strong Sell recommendations (optional)</param>
        /// <param name="strongSellsLess">Return only records with fewer than this many Strong Sell recommendations (optional)</param>
        /// <param name="totalGreater">Return only records with more than this many recommendations, regardless of type (optional)</param>
        /// <param name="totalLess">Return only records with fewer than this many recommendations, regardless of type (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseZacksAnalystRatings)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseZacksAnalystRatings>> GetZacksAnalystRatingsAsyncWithHttpInfo (string identifier = null, DateTime? startDate = null, DateTime? endDate = null, decimal? meanGreater = null, decimal? meanLess = null, int? strongBuysGreater = null, int? strongBuysLess = null, int? buysGreater = null, int? buysLess = null, int? holdsGreater = null, int? holdsLess = null, int? sellsGreater = null, int? sellsLess = null, int? strongSellsGreater = null, int? strongSellsLess = null, int? totalGreater = null, int? totalLess = null, int? pageSize = null, string nextPage = null)
        {

            var localVarPath = "/zacks/analyst_ratings";
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
              

            if (identifier != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "identifier", identifier)); // query parameter
            if (startDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
            if (endDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
            if (meanGreater != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "mean_greater", meanGreater)); // query parameter
            if (meanLess != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "mean_less", meanLess)); // query parameter
            if (strongBuysGreater != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "strong_buys_greater", strongBuysGreater)); // query parameter
            if (strongBuysLess != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "strong_buys_less", strongBuysLess)); // query parameter
            if (buysGreater != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "buys_greater", buysGreater)); // query parameter
            if (buysLess != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "buys_less", buysLess)); // query parameter
            if (holdsGreater != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "holds_greater", holdsGreater)); // query parameter
            if (holdsLess != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "holds_less", holdsLess)); // query parameter
            if (sellsGreater != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sells_greater", sellsGreater)); // query parameter
            if (sellsLess != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sells_less", sellsLess)); // query parameter
            if (strongSellsGreater != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "strong_sells_greater", strongSellsGreater)); // query parameter
            if (strongSellsLess != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "strong_sells_less", strongSellsLess)); // query parameter
            if (totalGreater != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "total_greater", totalGreater)); // query parameter
            if (totalLess != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "total_less", totalLess)); // query parameter
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetZacksAnalystRatings", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseZacksAnalystRatings>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseZacksAnalystRatings) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseZacksAnalystRatings)));
        }

        /// <summary>
        /// Zacks EBITDA Consensus This database offers consensus EBITDA-related estimates for over 4,000 US and Canadian listed companies.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID) (optional)</param>
        /// <param name="type">Limit EBITDA estimates to this type (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseZacksEBITDAConsensus</returns>
        public ApiResponseZacksEBITDAConsensus GetZacksEbitdaConsensus (string identifier = null, string type = null, string nextPage = null)
        {
             ApiResponse<ApiResponseZacksEBITDAConsensus> localVarResponse = GetZacksEbitdaConsensusWithHttpInfo(identifier, type, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Zacks EBITDA Consensus This database offers consensus EBITDA-related estimates for over 4,000 US and Canadian listed companies.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID) (optional)</param>
        /// <param name="type">Limit EBITDA estimates to this type (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseZacksEBITDAConsensus</returns>
        
        
        public ApiResponse< ApiResponseZacksEBITDAConsensus > GetZacksEbitdaConsensusWithHttpInfo (string identifier = null, string type = null, string nextPage = null)
        {

            var localVarPath = "/zacks/ebitda_consensus";
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
            
            
            if (identifier != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "identifier", identifier)); // query parameter
            if (type != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "type", type)); // query parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetZacksEbitdaConsensus", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseZacksEBITDAConsensus>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseZacksEBITDAConsensus) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseZacksEBITDAConsensus)));
        }

        /// <summary>
        /// Zacks EBITDA Consensus This database offers consensus EBITDA-related estimates for over 4,000 US and Canadian listed companies.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID) (optional)</param>
        /// <param name="type">Limit EBITDA estimates to this type (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseZacksEBITDAConsensus</returns>
        public async System.Threading.Tasks.Task<ApiResponseZacksEBITDAConsensus> GetZacksEbitdaConsensusAsync (string identifier = null, string type = null, string nextPage = null)
        {
             ApiResponse<ApiResponseZacksEBITDAConsensus> localVarResponse = await GetZacksEbitdaConsensusAsyncWithHttpInfo(identifier, type, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Zacks EBITDA Consensus This database offers consensus EBITDA-related estimates for over 4,000 US and Canadian listed companies.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID) (optional)</param>
        /// <param name="type">Limit EBITDA estimates to this type (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseZacksEBITDAConsensus)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseZacksEBITDAConsensus>> GetZacksEbitdaConsensusAsyncWithHttpInfo (string identifier = null, string type = null, string nextPage = null)
        {

            var localVarPath = "/zacks/ebitda_consensus";
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
              

            if (identifier != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "identifier", identifier)); // query parameter
            if (type != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "type", type)); // query parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetZacksEbitdaConsensus", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseZacksEBITDAConsensus>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseZacksEBITDAConsensus) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseZacksEBITDAConsensus)));
        }

        /// <summary>
        /// Zacks EPS Estimates This database offers consensus earnings estimates for over 5,000 US and Canadian listed companies.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID) (optional)</param>
        /// <param name="startDate">Limit EPS estimates to those on or after this date (optional)</param>
        /// <param name="endDate">Limit EPS estimates to those on or before this date (optional)</param>
        /// <param name="fiscalYear">Only for the given fiscal year (optional)</param>
        /// <param name="fiscalPeriod">The fiscal period (optional)</param>
        /// <param name="calendarYear">Only for the given calendar year (optional)</param>
        /// <param name="calendarPeriod">The calendar period (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseZacksEPSEstimates</returns>
        public ApiResponseZacksEPSEstimates GetZacksEpsEstimates (string identifier = null, DateTime? startDate = null, DateTime? endDate = null, int? fiscalYear = null, string fiscalPeriod = null, int? calendarYear = null, string calendarPeriod = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseZacksEPSEstimates> localVarResponse = GetZacksEpsEstimatesWithHttpInfo(identifier, startDate, endDate, fiscalYear, fiscalPeriod, calendarYear, calendarPeriod, pageSize, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Zacks EPS Estimates This database offers consensus earnings estimates for over 5,000 US and Canadian listed companies.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID) (optional)</param>
        /// <param name="startDate">Limit EPS estimates to those on or after this date (optional)</param>
        /// <param name="endDate">Limit EPS estimates to those on or before this date (optional)</param>
        /// <param name="fiscalYear">Only for the given fiscal year (optional)</param>
        /// <param name="fiscalPeriod">The fiscal period (optional)</param>
        /// <param name="calendarYear">Only for the given calendar year (optional)</param>
        /// <param name="calendarPeriod">The calendar period (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseZacksEPSEstimates</returns>
        
        
        public ApiResponse< ApiResponseZacksEPSEstimates > GetZacksEpsEstimatesWithHttpInfo (string identifier = null, DateTime? startDate = null, DateTime? endDate = null, int? fiscalYear = null, string fiscalPeriod = null, int? calendarYear = null, string calendarPeriod = null, int? pageSize = null, string nextPage = null)
        {

            var localVarPath = "/zacks/eps_estimates";
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
            
            
            if (identifier != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "identifier", identifier)); // query parameter
            if (startDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
            if (endDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
            if (fiscalYear != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "fiscal_year", fiscalYear)); // query parameter
            if (fiscalPeriod != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "fiscal_period", fiscalPeriod)); // query parameter
            if (calendarYear != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "calendar_year", calendarYear)); // query parameter
            if (calendarPeriod != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "calendar_period", calendarPeriod)); // query parameter
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetZacksEpsEstimates", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseZacksEPSEstimates>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseZacksEPSEstimates) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseZacksEPSEstimates)));
        }

        /// <summary>
        /// Zacks EPS Estimates This database offers consensus earnings estimates for over 5,000 US and Canadian listed companies.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID) (optional)</param>
        /// <param name="startDate">Limit EPS estimates to those on or after this date (optional)</param>
        /// <param name="endDate">Limit EPS estimates to those on or before this date (optional)</param>
        /// <param name="fiscalYear">Only for the given fiscal year (optional)</param>
        /// <param name="fiscalPeriod">The fiscal period (optional)</param>
        /// <param name="calendarYear">Only for the given calendar year (optional)</param>
        /// <param name="calendarPeriod">The calendar period (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseZacksEPSEstimates</returns>
        public async System.Threading.Tasks.Task<ApiResponseZacksEPSEstimates> GetZacksEpsEstimatesAsync (string identifier = null, DateTime? startDate = null, DateTime? endDate = null, int? fiscalYear = null, string fiscalPeriod = null, int? calendarYear = null, string calendarPeriod = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseZacksEPSEstimates> localVarResponse = await GetZacksEpsEstimatesAsyncWithHttpInfo(identifier, startDate, endDate, fiscalYear, fiscalPeriod, calendarYear, calendarPeriod, pageSize, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Zacks EPS Estimates This database offers consensus earnings estimates for over 5,000 US and Canadian listed companies.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID) (optional)</param>
        /// <param name="startDate">Limit EPS estimates to those on or after this date (optional)</param>
        /// <param name="endDate">Limit EPS estimates to those on or before this date (optional)</param>
        /// <param name="fiscalYear">Only for the given fiscal year (optional)</param>
        /// <param name="fiscalPeriod">The fiscal period (optional)</param>
        /// <param name="calendarYear">Only for the given calendar year (optional)</param>
        /// <param name="calendarPeriod">The calendar period (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseZacksEPSEstimates)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseZacksEPSEstimates>> GetZacksEpsEstimatesAsyncWithHttpInfo (string identifier = null, DateTime? startDate = null, DateTime? endDate = null, int? fiscalYear = null, string fiscalPeriod = null, int? calendarYear = null, string calendarPeriod = null, int? pageSize = null, string nextPage = null)
        {

            var localVarPath = "/zacks/eps_estimates";
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
              

            if (identifier != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "identifier", identifier)); // query parameter
            if (startDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
            if (endDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
            if (fiscalYear != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "fiscal_year", fiscalYear)); // query parameter
            if (fiscalPeriod != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "fiscal_period", fiscalPeriod)); // query parameter
            if (calendarYear != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "calendar_year", calendarYear)); // query parameter
            if (calendarPeriod != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "calendar_period", calendarPeriod)); // query parameter
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetZacksEpsEstimates", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseZacksEPSEstimates>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseZacksEPSEstimates) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseZacksEPSEstimates)));
        }

        /// <summary>
        /// Zacks EPS Growth Rates This database offers consensus EPS growth rate estimates, comparing company estimates to historical company estimates, industry estimates, and S&amp;P 500 index estimates.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="company">Filings for the given &#x60;company&#x60; identifier (ticker, CIK, LEI, Intrinio ID) (optional)</param>
        /// <param name="industryGroupName">Return only growth rates for companies in the given Zacks industry group name (optional)</param>
        /// <param name="industryGroupNumber">Return only growth rates for companies in the given Zacks industry group number (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseZacksEPSGrowthRates</returns>
        public ApiResponseZacksEPSGrowthRates GetZacksEpsGrowthRates (string company = null, string industryGroupName = null, string industryGroupNumber = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseZacksEPSGrowthRates> localVarResponse = GetZacksEpsGrowthRatesWithHttpInfo(company, industryGroupName, industryGroupNumber, pageSize, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Zacks EPS Growth Rates This database offers consensus EPS growth rate estimates, comparing company estimates to historical company estimates, industry estimates, and S&amp;P 500 index estimates.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="company">Filings for the given &#x60;company&#x60; identifier (ticker, CIK, LEI, Intrinio ID) (optional)</param>
        /// <param name="industryGroupName">Return only growth rates for companies in the given Zacks industry group name (optional)</param>
        /// <param name="industryGroupNumber">Return only growth rates for companies in the given Zacks industry group number (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseZacksEPSGrowthRates</returns>
        
        
        public ApiResponse< ApiResponseZacksEPSGrowthRates > GetZacksEpsGrowthRatesWithHttpInfo (string company = null, string industryGroupName = null, string industryGroupNumber = null, int? pageSize = null, string nextPage = null)
        {

            var localVarPath = "/zacks/eps_growth_rates";
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
            
            
            if (company != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "company", company)); // query parameter
            if (industryGroupName != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "industry_group_name", industryGroupName)); // query parameter
            if (industryGroupNumber != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "industry_group_number", industryGroupNumber)); // query parameter
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetZacksEpsGrowthRates", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseZacksEPSGrowthRates>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseZacksEPSGrowthRates) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseZacksEPSGrowthRates)));
        }

        /// <summary>
        /// Zacks EPS Growth Rates This database offers consensus EPS growth rate estimates, comparing company estimates to historical company estimates, industry estimates, and S&amp;P 500 index estimates.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="company">Filings for the given &#x60;company&#x60; identifier (ticker, CIK, LEI, Intrinio ID) (optional)</param>
        /// <param name="industryGroupName">Return only growth rates for companies in the given Zacks industry group name (optional)</param>
        /// <param name="industryGroupNumber">Return only growth rates for companies in the given Zacks industry group number (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseZacksEPSGrowthRates</returns>
        public async System.Threading.Tasks.Task<ApiResponseZacksEPSGrowthRates> GetZacksEpsGrowthRatesAsync (string company = null, string industryGroupName = null, string industryGroupNumber = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseZacksEPSGrowthRates> localVarResponse = await GetZacksEpsGrowthRatesAsyncWithHttpInfo(company, industryGroupName, industryGroupNumber, pageSize, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Zacks EPS Growth Rates This database offers consensus EPS growth rate estimates, comparing company estimates to historical company estimates, industry estimates, and S&amp;P 500 index estimates.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="company">Filings for the given &#x60;company&#x60; identifier (ticker, CIK, LEI, Intrinio ID) (optional)</param>
        /// <param name="industryGroupName">Return only growth rates for companies in the given Zacks industry group name (optional)</param>
        /// <param name="industryGroupNumber">Return only growth rates for companies in the given Zacks industry group number (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseZacksEPSGrowthRates)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseZacksEPSGrowthRates>> GetZacksEpsGrowthRatesAsyncWithHttpInfo (string company = null, string industryGroupName = null, string industryGroupNumber = null, int? pageSize = null, string nextPage = null)
        {

            var localVarPath = "/zacks/eps_growth_rates";
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
              

            if (company != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "company", company)); // query parameter
            if (industryGroupName != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "industry_group_name", industryGroupName)); // query parameter
            if (industryGroupNumber != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "industry_group_number", industryGroupNumber)); // query parameter
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetZacksEpsGrowthRates", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseZacksEPSGrowthRates>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseZacksEPSGrowthRates) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseZacksEPSGrowthRates)));
        }

        /// <summary>
        /// Zacks EPS Surprises This database returns historical estimated and actual earnings, guidance, and announcement dates for 17,000+ US and Canadian listed companies.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Limit EPS surprises to those on or after this date (optional)</param>
        /// <param name="endDate">Limit EPS surprises to those on or before this date (optional)</param>
        /// <param name="epsActualGreater">Return only records with an actual EPS higher than this value (optional)</param>
        /// <param name="epsActualLess">Return only records with an actual EPS lower than this value (optional)</param>
        /// <param name="epsMeanEstimateGreater">Return only records with an EPS mean estimate greater than this value (optional)</param>
        /// <param name="epsMeanEstimateLess">Return only records with an EPS mean estimate lower than this value (optional)</param>
        /// <param name="epsAmountDiffGreater">Return only records with an EPS amount difference greater than this value (optional)</param>
        /// <param name="epsAmountDiffLess">Return only records with an EPS amount difference less than this value (optional)</param>
        /// <param name="epsPercentDiffGreater">Return only records with an EPS percent difference greater than this value (optional)</param>
        /// <param name="epsPercentDiffLess">Return only records with an EPS percent difference less than this value (optional)</param>
        /// <param name="epsCountEstimateGreater">Return only records with an EPS count estimate greater than this value (optional)</param>
        /// <param name="epsCountEstimateLess">Return only records with an EPS count estimate less than this value (optional)</param>
        /// <param name="epsStdDevEstimateGreater">Return only records with an EPS standard deviation greater than this value (optional)</param>
        /// <param name="epsStdDevEstimateLess">Return only records with an EPS standard deviation less than this value (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseZacksEPSSurprises</returns>
        public ApiResponseZacksEPSSurprises GetZacksEpsSurprises (DateTime? startDate = null, DateTime? endDate = null, decimal? epsActualGreater = null, decimal? epsActualLess = null, decimal? epsMeanEstimateGreater = null, decimal? epsMeanEstimateLess = null, decimal? epsAmountDiffGreater = null, decimal? epsAmountDiffLess = null, decimal? epsPercentDiffGreater = null, decimal? epsPercentDiffLess = null, decimal? epsCountEstimateGreater = null, decimal? epsCountEstimateLess = null, decimal? epsStdDevEstimateGreater = null, decimal? epsStdDevEstimateLess = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseZacksEPSSurprises> localVarResponse = GetZacksEpsSurprisesWithHttpInfo(startDate, endDate, epsActualGreater, epsActualLess, epsMeanEstimateGreater, epsMeanEstimateLess, epsAmountDiffGreater, epsAmountDiffLess, epsPercentDiffGreater, epsPercentDiffLess, epsCountEstimateGreater, epsCountEstimateLess, epsStdDevEstimateGreater, epsStdDevEstimateLess, pageSize, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Zacks EPS Surprises This database returns historical estimated and actual earnings, guidance, and announcement dates for 17,000+ US and Canadian listed companies.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Limit EPS surprises to those on or after this date (optional)</param>
        /// <param name="endDate">Limit EPS surprises to those on or before this date (optional)</param>
        /// <param name="epsActualGreater">Return only records with an actual EPS higher than this value (optional)</param>
        /// <param name="epsActualLess">Return only records with an actual EPS lower than this value (optional)</param>
        /// <param name="epsMeanEstimateGreater">Return only records with an EPS mean estimate greater than this value (optional)</param>
        /// <param name="epsMeanEstimateLess">Return only records with an EPS mean estimate lower than this value (optional)</param>
        /// <param name="epsAmountDiffGreater">Return only records with an EPS amount difference greater than this value (optional)</param>
        /// <param name="epsAmountDiffLess">Return only records with an EPS amount difference less than this value (optional)</param>
        /// <param name="epsPercentDiffGreater">Return only records with an EPS percent difference greater than this value (optional)</param>
        /// <param name="epsPercentDiffLess">Return only records with an EPS percent difference less than this value (optional)</param>
        /// <param name="epsCountEstimateGreater">Return only records with an EPS count estimate greater than this value (optional)</param>
        /// <param name="epsCountEstimateLess">Return only records with an EPS count estimate less than this value (optional)</param>
        /// <param name="epsStdDevEstimateGreater">Return only records with an EPS standard deviation greater than this value (optional)</param>
        /// <param name="epsStdDevEstimateLess">Return only records with an EPS standard deviation less than this value (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseZacksEPSSurprises</returns>
        
        
        public ApiResponse< ApiResponseZacksEPSSurprises > GetZacksEpsSurprisesWithHttpInfo (DateTime? startDate = null, DateTime? endDate = null, decimal? epsActualGreater = null, decimal? epsActualLess = null, decimal? epsMeanEstimateGreater = null, decimal? epsMeanEstimateLess = null, decimal? epsAmountDiffGreater = null, decimal? epsAmountDiffLess = null, decimal? epsPercentDiffGreater = null, decimal? epsPercentDiffLess = null, decimal? epsCountEstimateGreater = null, decimal? epsCountEstimateLess = null, decimal? epsStdDevEstimateGreater = null, decimal? epsStdDevEstimateLess = null, int? pageSize = null, string nextPage = null)
        {

            var localVarPath = "/zacks/eps_surprises";
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
            
            
            if (startDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
            if (endDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
            if (epsActualGreater != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "eps_actual_greater", epsActualGreater)); // query parameter
            if (epsActualLess != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "eps_actual_less", epsActualLess)); // query parameter
            if (epsMeanEstimateGreater != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "eps_mean_estimate_greater", epsMeanEstimateGreater)); // query parameter
            if (epsMeanEstimateLess != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "eps_mean_estimate_less", epsMeanEstimateLess)); // query parameter
            if (epsAmountDiffGreater != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "eps_amount_diff_greater", epsAmountDiffGreater)); // query parameter
            if (epsAmountDiffLess != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "eps_amount_diff_less", epsAmountDiffLess)); // query parameter
            if (epsPercentDiffGreater != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "eps_percent_diff_greater", epsPercentDiffGreater)); // query parameter
            if (epsPercentDiffLess != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "eps_percent_diff_less", epsPercentDiffLess)); // query parameter
            if (epsCountEstimateGreater != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "eps_count_estimate_greater", epsCountEstimateGreater)); // query parameter
            if (epsCountEstimateLess != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "eps_count_estimate_less", epsCountEstimateLess)); // query parameter
            if (epsStdDevEstimateGreater != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "eps_std_dev_estimate_greater", epsStdDevEstimateGreater)); // query parameter
            if (epsStdDevEstimateLess != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "eps_std_dev_estimate_less", epsStdDevEstimateLess)); // query parameter
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetZacksEpsSurprises", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseZacksEPSSurprises>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseZacksEPSSurprises) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseZacksEPSSurprises)));
        }

        /// <summary>
        /// Zacks EPS Surprises This database returns historical estimated and actual earnings, guidance, and announcement dates for 17,000+ US and Canadian listed companies.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Limit EPS surprises to those on or after this date (optional)</param>
        /// <param name="endDate">Limit EPS surprises to those on or before this date (optional)</param>
        /// <param name="epsActualGreater">Return only records with an actual EPS higher than this value (optional)</param>
        /// <param name="epsActualLess">Return only records with an actual EPS lower than this value (optional)</param>
        /// <param name="epsMeanEstimateGreater">Return only records with an EPS mean estimate greater than this value (optional)</param>
        /// <param name="epsMeanEstimateLess">Return only records with an EPS mean estimate lower than this value (optional)</param>
        /// <param name="epsAmountDiffGreater">Return only records with an EPS amount difference greater than this value (optional)</param>
        /// <param name="epsAmountDiffLess">Return only records with an EPS amount difference less than this value (optional)</param>
        /// <param name="epsPercentDiffGreater">Return only records with an EPS percent difference greater than this value (optional)</param>
        /// <param name="epsPercentDiffLess">Return only records with an EPS percent difference less than this value (optional)</param>
        /// <param name="epsCountEstimateGreater">Return only records with an EPS count estimate greater than this value (optional)</param>
        /// <param name="epsCountEstimateLess">Return only records with an EPS count estimate less than this value (optional)</param>
        /// <param name="epsStdDevEstimateGreater">Return only records with an EPS standard deviation greater than this value (optional)</param>
        /// <param name="epsStdDevEstimateLess">Return only records with an EPS standard deviation less than this value (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseZacksEPSSurprises</returns>
        public async System.Threading.Tasks.Task<ApiResponseZacksEPSSurprises> GetZacksEpsSurprisesAsync (DateTime? startDate = null, DateTime? endDate = null, decimal? epsActualGreater = null, decimal? epsActualLess = null, decimal? epsMeanEstimateGreater = null, decimal? epsMeanEstimateLess = null, decimal? epsAmountDiffGreater = null, decimal? epsAmountDiffLess = null, decimal? epsPercentDiffGreater = null, decimal? epsPercentDiffLess = null, decimal? epsCountEstimateGreater = null, decimal? epsCountEstimateLess = null, decimal? epsStdDevEstimateGreater = null, decimal? epsStdDevEstimateLess = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseZacksEPSSurprises> localVarResponse = await GetZacksEpsSurprisesAsyncWithHttpInfo(startDate, endDate, epsActualGreater, epsActualLess, epsMeanEstimateGreater, epsMeanEstimateLess, epsAmountDiffGreater, epsAmountDiffLess, epsPercentDiffGreater, epsPercentDiffLess, epsCountEstimateGreater, epsCountEstimateLess, epsStdDevEstimateGreater, epsStdDevEstimateLess, pageSize, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Zacks EPS Surprises This database returns historical estimated and actual earnings, guidance, and announcement dates for 17,000+ US and Canadian listed companies.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Limit EPS surprises to those on or after this date (optional)</param>
        /// <param name="endDate">Limit EPS surprises to those on or before this date (optional)</param>
        /// <param name="epsActualGreater">Return only records with an actual EPS higher than this value (optional)</param>
        /// <param name="epsActualLess">Return only records with an actual EPS lower than this value (optional)</param>
        /// <param name="epsMeanEstimateGreater">Return only records with an EPS mean estimate greater than this value (optional)</param>
        /// <param name="epsMeanEstimateLess">Return only records with an EPS mean estimate lower than this value (optional)</param>
        /// <param name="epsAmountDiffGreater">Return only records with an EPS amount difference greater than this value (optional)</param>
        /// <param name="epsAmountDiffLess">Return only records with an EPS amount difference less than this value (optional)</param>
        /// <param name="epsPercentDiffGreater">Return only records with an EPS percent difference greater than this value (optional)</param>
        /// <param name="epsPercentDiffLess">Return only records with an EPS percent difference less than this value (optional)</param>
        /// <param name="epsCountEstimateGreater">Return only records with an EPS count estimate greater than this value (optional)</param>
        /// <param name="epsCountEstimateLess">Return only records with an EPS count estimate less than this value (optional)</param>
        /// <param name="epsStdDevEstimateGreater">Return only records with an EPS standard deviation greater than this value (optional)</param>
        /// <param name="epsStdDevEstimateLess">Return only records with an EPS standard deviation less than this value (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseZacksEPSSurprises)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseZacksEPSSurprises>> GetZacksEpsSurprisesAsyncWithHttpInfo (DateTime? startDate = null, DateTime? endDate = null, decimal? epsActualGreater = null, decimal? epsActualLess = null, decimal? epsMeanEstimateGreater = null, decimal? epsMeanEstimateLess = null, decimal? epsAmountDiffGreater = null, decimal? epsAmountDiffLess = null, decimal? epsPercentDiffGreater = null, decimal? epsPercentDiffLess = null, decimal? epsCountEstimateGreater = null, decimal? epsCountEstimateLess = null, decimal? epsStdDevEstimateGreater = null, decimal? epsStdDevEstimateLess = null, int? pageSize = null, string nextPage = null)
        {

            var localVarPath = "/zacks/eps_surprises";
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
              

            if (startDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
            if (endDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
            if (epsActualGreater != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "eps_actual_greater", epsActualGreater)); // query parameter
            if (epsActualLess != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "eps_actual_less", epsActualLess)); // query parameter
            if (epsMeanEstimateGreater != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "eps_mean_estimate_greater", epsMeanEstimateGreater)); // query parameter
            if (epsMeanEstimateLess != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "eps_mean_estimate_less", epsMeanEstimateLess)); // query parameter
            if (epsAmountDiffGreater != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "eps_amount_diff_greater", epsAmountDiffGreater)); // query parameter
            if (epsAmountDiffLess != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "eps_amount_diff_less", epsAmountDiffLess)); // query parameter
            if (epsPercentDiffGreater != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "eps_percent_diff_greater", epsPercentDiffGreater)); // query parameter
            if (epsPercentDiffLess != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "eps_percent_diff_less", epsPercentDiffLess)); // query parameter
            if (epsCountEstimateGreater != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "eps_count_estimate_greater", epsCountEstimateGreater)); // query parameter
            if (epsCountEstimateLess != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "eps_count_estimate_less", epsCountEstimateLess)); // query parameter
            if (epsStdDevEstimateGreater != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "eps_std_dev_estimate_greater", epsStdDevEstimateGreater)); // query parameter
            if (epsStdDevEstimateLess != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "eps_std_dev_estimate_less", epsStdDevEstimateLess)); // query parameter
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetZacksEpsSurprises", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseZacksEPSSurprises>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseZacksEPSSurprises) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseZacksEPSSurprises)));
        }

        /// <summary>
        /// Zacks ETF Holdings Returns Zacks ETF holdings data
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="etfTicker">Return holdings of the ETF with the given ticker (optional)</param>
        /// <param name="holdingSymbol">Return holdings where the instrument being held has the given trading symbol (optional)</param>
        /// <param name="weightGreater">Return on the holdings with a weight greater than (optional)</param>
        /// <param name="weightLess">Return on the holdings with a weight less than (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseZacksETFHoldings</returns>
        public ApiResponseZacksETFHoldings GetZacksEtfHoldings (string etfTicker = null, string holdingSymbol = null, decimal? weightGreater = null, decimal? weightLess = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseZacksETFHoldings> localVarResponse = GetZacksEtfHoldingsWithHttpInfo(etfTicker, holdingSymbol, weightGreater, weightLess, pageSize, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Zacks ETF Holdings Returns Zacks ETF holdings data
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="etfTicker">Return holdings of the ETF with the given ticker (optional)</param>
        /// <param name="holdingSymbol">Return holdings where the instrument being held has the given trading symbol (optional)</param>
        /// <param name="weightGreater">Return on the holdings with a weight greater than (optional)</param>
        /// <param name="weightLess">Return on the holdings with a weight less than (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseZacksETFHoldings</returns>
        
        
        public ApiResponse< ApiResponseZacksETFHoldings > GetZacksEtfHoldingsWithHttpInfo (string etfTicker = null, string holdingSymbol = null, decimal? weightGreater = null, decimal? weightLess = null, int? pageSize = null, string nextPage = null)
        {

            var localVarPath = "/zacks/etf_holdings";
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
            
            
            if (etfTicker != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "etf_ticker", etfTicker)); // query parameter
            if (holdingSymbol != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "holding_symbol", holdingSymbol)); // query parameter
            if (weightGreater != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "weight_greater", weightGreater)); // query parameter
            if (weightLess != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "weight_less", weightLess)); // query parameter
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetZacksEtfHoldings", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseZacksETFHoldings>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseZacksETFHoldings) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseZacksETFHoldings)));
        }

        /// <summary>
        /// Zacks ETF Holdings Returns Zacks ETF holdings data
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="etfTicker">Return holdings of the ETF with the given ticker (optional)</param>
        /// <param name="holdingSymbol">Return holdings where the instrument being held has the given trading symbol (optional)</param>
        /// <param name="weightGreater">Return on the holdings with a weight greater than (optional)</param>
        /// <param name="weightLess">Return on the holdings with a weight less than (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseZacksETFHoldings</returns>
        public async System.Threading.Tasks.Task<ApiResponseZacksETFHoldings> GetZacksEtfHoldingsAsync (string etfTicker = null, string holdingSymbol = null, decimal? weightGreater = null, decimal? weightLess = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseZacksETFHoldings> localVarResponse = await GetZacksEtfHoldingsAsyncWithHttpInfo(etfTicker, holdingSymbol, weightGreater, weightLess, pageSize, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Zacks ETF Holdings Returns Zacks ETF holdings data
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="etfTicker">Return holdings of the ETF with the given ticker (optional)</param>
        /// <param name="holdingSymbol">Return holdings where the instrument being held has the given trading symbol (optional)</param>
        /// <param name="weightGreater">Return on the holdings with a weight greater than (optional)</param>
        /// <param name="weightLess">Return on the holdings with a weight less than (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseZacksETFHoldings)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseZacksETFHoldings>> GetZacksEtfHoldingsAsyncWithHttpInfo (string etfTicker = null, string holdingSymbol = null, decimal? weightGreater = null, decimal? weightLess = null, int? pageSize = null, string nextPage = null)
        {

            var localVarPath = "/zacks/etf_holdings";
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
              

            if (etfTicker != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "etf_ticker", etfTicker)); // query parameter
            if (holdingSymbol != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "holding_symbol", holdingSymbol)); // query parameter
            if (weightGreater != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "weight_greater", weightGreater)); // query parameter
            if (weightLess != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "weight_less", weightLess)); // query parameter
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetZacksEtfHoldings", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseZacksETFHoldings>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseZacksETFHoldings) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseZacksETFHoldings)));
        }

        /// <summary>
        /// Zacks Forward PE Estimates This database offers price-to-earning ratio estimates for over 4,000 US and Canadian listed companies.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseZacksForwardPEs</returns>
        public ApiResponseZacksForwardPEs GetZacksForwardPe (string nextPage = null)
        {
             ApiResponse<ApiResponseZacksForwardPEs> localVarResponse = GetZacksForwardPeWithHttpInfo(nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Zacks Forward PE Estimates This database offers price-to-earning ratio estimates for over 4,000 US and Canadian listed companies.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseZacksForwardPEs</returns>
        
        
        public ApiResponse< ApiResponseZacksForwardPEs > GetZacksForwardPeWithHttpInfo (string nextPage = null)
        {

            var localVarPath = "/zacks/forward_pe";
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

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetZacksForwardPe", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseZacksForwardPEs>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseZacksForwardPEs) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseZacksForwardPEs)));
        }

        /// <summary>
        /// Zacks Forward PE Estimates This database offers price-to-earning ratio estimates for over 4,000 US and Canadian listed companies.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseZacksForwardPEs</returns>
        public async System.Threading.Tasks.Task<ApiResponseZacksForwardPEs> GetZacksForwardPeAsync (string nextPage = null)
        {
             ApiResponse<ApiResponseZacksForwardPEs> localVarResponse = await GetZacksForwardPeAsyncWithHttpInfo(nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Zacks Forward PE Estimates This database offers price-to-earning ratio estimates for over 4,000 US and Canadian listed companies.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseZacksForwardPEs)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseZacksForwardPEs>> GetZacksForwardPeAsyncWithHttpInfo (string nextPage = null)
        {

            var localVarPath = "/zacks/forward_pe";
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

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetZacksForwardPe", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseZacksForwardPEs>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseZacksForwardPEs) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseZacksForwardPEs)));
        }

        /// <summary>
        /// Zacks Forward PE by identifer Returns the forward PE estimates for the identifier
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Intrinio ID or ticker for a Security</param>
        /// <returns>ZacksForwardPE</returns>
        public ZacksForwardPE GetZacksForwardPeByIdentifier (string identifier)
        {
             ApiResponse<ZacksForwardPE> localVarResponse = GetZacksForwardPeByIdentifierWithHttpInfo(identifier);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Zacks Forward PE by identifer Returns the forward PE estimates for the identifier
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Intrinio ID or ticker for a Security</param>
        /// <returns>ApiResponse of ZacksForwardPE</returns>
        
        
        public ApiResponse< ZacksForwardPE > GetZacksForwardPeByIdentifierWithHttpInfo (string identifier)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling ZacksApi->GetZacksForwardPeByIdentifier");

            var localVarPath = "/zacks/forward_pe/{identifier}";
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
            
            
            if (identifier != null) localVarPathParams.Add("identifier", Configuration.ApiClient.ParameterToString(identifier)); // path parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetZacksForwardPeByIdentifier", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ZacksForwardPE>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ZacksForwardPE) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ZacksForwardPE)));
        }

        /// <summary>
        /// Zacks Forward PE by identifer Returns the forward PE estimates for the identifier
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Intrinio ID or ticker for a Security</param>
        /// <returns>Task of ZacksForwardPE</returns>
        public async System.Threading.Tasks.Task<ZacksForwardPE> GetZacksForwardPeByIdentifierAsync (string identifier)
        {
             ApiResponse<ZacksForwardPE> localVarResponse = await GetZacksForwardPeByIdentifierAsyncWithHttpInfo(identifier);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Zacks Forward PE by identifer Returns the forward PE estimates for the identifier
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Intrinio ID or ticker for a Security</param>
        /// <returns>Task of ApiResponse (ZacksForwardPE)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ZacksForwardPE>> GetZacksForwardPeByIdentifierAsyncWithHttpInfo (string identifier)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling ZacksApi->GetZacksForwardPeByIdentifier");

            var localVarPath = "/zacks/forward_pe/{identifier}";
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
              

            if (identifier != null) localVarPathParams.Add("identifier", Configuration.ApiClient.ParameterToString(identifier)); // path parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetZacksForwardPeByIdentifier", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ZacksForwardPE>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ZacksForwardPE) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ZacksForwardPE)));
        }

        /// <summary>
        /// Zacks Institutional Holding Companies Returns Zacks institutional holding companies data
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ticker">Return companies with the given ticker (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseZacksInstitutionalHoldingCompanies</returns>
        public ApiResponseZacksInstitutionalHoldingCompanies GetZacksInstitutionalHoldingCompanies (string ticker = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseZacksInstitutionalHoldingCompanies> localVarResponse = GetZacksInstitutionalHoldingCompaniesWithHttpInfo(ticker, pageSize, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Zacks Institutional Holding Companies Returns Zacks institutional holding companies data
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ticker">Return companies with the given ticker (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseZacksInstitutionalHoldingCompanies</returns>
        
        
        public ApiResponse< ApiResponseZacksInstitutionalHoldingCompanies > GetZacksInstitutionalHoldingCompaniesWithHttpInfo (string ticker = null, int? pageSize = null, string nextPage = null)
        {

            var localVarPath = "/zacks/institutional_holdings/companies";
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
            
            
            if (ticker != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "ticker", ticker)); // query parameter
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetZacksInstitutionalHoldingCompanies", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseZacksInstitutionalHoldingCompanies>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseZacksInstitutionalHoldingCompanies) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseZacksInstitutionalHoldingCompanies)));
        }

        /// <summary>
        /// Zacks Institutional Holding Companies Returns Zacks institutional holding companies data
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ticker">Return companies with the given ticker (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseZacksInstitutionalHoldingCompanies</returns>
        public async System.Threading.Tasks.Task<ApiResponseZacksInstitutionalHoldingCompanies> GetZacksInstitutionalHoldingCompaniesAsync (string ticker = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseZacksInstitutionalHoldingCompanies> localVarResponse = await GetZacksInstitutionalHoldingCompaniesAsyncWithHttpInfo(ticker, pageSize, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Zacks Institutional Holding Companies Returns Zacks institutional holding companies data
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ticker">Return companies with the given ticker (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseZacksInstitutionalHoldingCompanies)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseZacksInstitutionalHoldingCompanies>> GetZacksInstitutionalHoldingCompaniesAsyncWithHttpInfo (string ticker = null, int? pageSize = null, string nextPage = null)
        {

            var localVarPath = "/zacks/institutional_holdings/companies";
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
              

            if (ticker != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "ticker", ticker)); // query parameter
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetZacksInstitutionalHoldingCompanies", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseZacksInstitutionalHoldingCompanies>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseZacksInstitutionalHoldingCompanies) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseZacksInstitutionalHoldingCompanies)));
        }

        /// <summary>
        /// Zacks Institutional Holding Owners Returns Zacks institutional holding owners data
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cik">Return owners with the given Central Index Key (CIK) (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseZacksInstitutionalHoldingOwners</returns>
        public ApiResponseZacksInstitutionalHoldingOwners GetZacksInstitutionalHoldingOwners (string cik = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseZacksInstitutionalHoldingOwners> localVarResponse = GetZacksInstitutionalHoldingOwnersWithHttpInfo(cik, pageSize, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Zacks Institutional Holding Owners Returns Zacks institutional holding owners data
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cik">Return owners with the given Central Index Key (CIK) (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseZacksInstitutionalHoldingOwners</returns>
        
        
        public ApiResponse< ApiResponseZacksInstitutionalHoldingOwners > GetZacksInstitutionalHoldingOwnersWithHttpInfo (string cik = null, int? pageSize = null, string nextPage = null)
        {

            var localVarPath = "/zacks/institutional_holdings/owners";
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
            
            
            if (cik != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "cik", cik)); // query parameter
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetZacksInstitutionalHoldingOwners", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseZacksInstitutionalHoldingOwners>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseZacksInstitutionalHoldingOwners) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseZacksInstitutionalHoldingOwners)));
        }

        /// <summary>
        /// Zacks Institutional Holding Owners Returns Zacks institutional holding owners data
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cik">Return owners with the given Central Index Key (CIK) (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseZacksInstitutionalHoldingOwners</returns>
        public async System.Threading.Tasks.Task<ApiResponseZacksInstitutionalHoldingOwners> GetZacksInstitutionalHoldingOwnersAsync (string cik = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseZacksInstitutionalHoldingOwners> localVarResponse = await GetZacksInstitutionalHoldingOwnersAsyncWithHttpInfo(cik, pageSize, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Zacks Institutional Holding Owners Returns Zacks institutional holding owners data
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cik">Return owners with the given Central Index Key (CIK) (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseZacksInstitutionalHoldingOwners)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseZacksInstitutionalHoldingOwners>> GetZacksInstitutionalHoldingOwnersAsyncWithHttpInfo (string cik = null, int? pageSize = null, string nextPage = null)
        {

            var localVarPath = "/zacks/institutional_holdings/owners";
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
              

            if (cik != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "cik", cik)); // query parameter
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetZacksInstitutionalHoldingOwners", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseZacksInstitutionalHoldingOwners>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseZacksInstitutionalHoldingOwners) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseZacksInstitutionalHoldingOwners)));
        }

        /// <summary>
        /// Zacks Institutional Holdings Returns Zacks institutional holdings data
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ticker">Return holdings where the company being held has the given ticker (optional)</param>
        /// <param name="ownerCik">Return holdings where the owner/holder has the given Central Index Key (CIK) (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseZacksInstitutionalHoldings</returns>
        public ApiResponseZacksInstitutionalHoldings GetZacksInstitutionalHoldings (string ticker = null, string ownerCik = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseZacksInstitutionalHoldings> localVarResponse = GetZacksInstitutionalHoldingsWithHttpInfo(ticker, ownerCik, pageSize, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Zacks Institutional Holdings Returns Zacks institutional holdings data
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ticker">Return holdings where the company being held has the given ticker (optional)</param>
        /// <param name="ownerCik">Return holdings where the owner/holder has the given Central Index Key (CIK) (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseZacksInstitutionalHoldings</returns>
        
        
        public ApiResponse< ApiResponseZacksInstitutionalHoldings > GetZacksInstitutionalHoldingsWithHttpInfo (string ticker = null, string ownerCik = null, int? pageSize = null, string nextPage = null)
        {

            var localVarPath = "/zacks/institutional_holdings";
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
            
            
            if (ticker != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "ticker", ticker)); // query parameter
            if (ownerCik != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "owner_cik", ownerCik)); // query parameter
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetZacksInstitutionalHoldings", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseZacksInstitutionalHoldings>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseZacksInstitutionalHoldings) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseZacksInstitutionalHoldings)));
        }

        /// <summary>
        /// Zacks Institutional Holdings Returns Zacks institutional holdings data
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ticker">Return holdings where the company being held has the given ticker (optional)</param>
        /// <param name="ownerCik">Return holdings where the owner/holder has the given Central Index Key (CIK) (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseZacksInstitutionalHoldings</returns>
        public async System.Threading.Tasks.Task<ApiResponseZacksInstitutionalHoldings> GetZacksInstitutionalHoldingsAsync (string ticker = null, string ownerCik = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseZacksInstitutionalHoldings> localVarResponse = await GetZacksInstitutionalHoldingsAsyncWithHttpInfo(ticker, ownerCik, pageSize, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Zacks Institutional Holdings Returns Zacks institutional holdings data
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ticker">Return holdings where the company being held has the given ticker (optional)</param>
        /// <param name="ownerCik">Return holdings where the owner/holder has the given Central Index Key (CIK) (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseZacksInstitutionalHoldings)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseZacksInstitutionalHoldings>> GetZacksInstitutionalHoldingsAsyncWithHttpInfo (string ticker = null, string ownerCik = null, int? pageSize = null, string nextPage = null)
        {

            var localVarPath = "/zacks/institutional_holdings";
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
              

            if (ticker != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "ticker", ticker)); // query parameter
            if (ownerCik != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "owner_cik", ownerCik)); // query parameter
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetZacksInstitutionalHoldings", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseZacksInstitutionalHoldings>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseZacksInstitutionalHoldings) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseZacksInstitutionalHoldings)));
        }

        /// <summary>
        /// Zacks Long Term Growth Rates This database offers consensus long term growth rate estimates, including insight into changes in estimates and revisions over time.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseZacksLongTermGrowthRates</returns>
        public ApiResponseZacksLongTermGrowthRates GetZacksLongTermGrowthRates (string identifier = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseZacksLongTermGrowthRates> localVarResponse = GetZacksLongTermGrowthRatesWithHttpInfo(identifier, pageSize, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Zacks Long Term Growth Rates This database offers consensus long term growth rate estimates, including insight into changes in estimates and revisions over time.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseZacksLongTermGrowthRates</returns>
        
        
        public ApiResponse< ApiResponseZacksLongTermGrowthRates > GetZacksLongTermGrowthRatesWithHttpInfo (string identifier = null, int? pageSize = null, string nextPage = null)
        {

            var localVarPath = "/zacks/long_term_growth_rates";
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
            
            
            if (identifier != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "identifier", identifier)); // query parameter
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetZacksLongTermGrowthRates", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseZacksLongTermGrowthRates>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseZacksLongTermGrowthRates) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseZacksLongTermGrowthRates)));
        }

        /// <summary>
        /// Zacks Long Term Growth Rates This database offers consensus long term growth rate estimates, including insight into changes in estimates and revisions over time.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseZacksLongTermGrowthRates</returns>
        public async System.Threading.Tasks.Task<ApiResponseZacksLongTermGrowthRates> GetZacksLongTermGrowthRatesAsync (string identifier = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseZacksLongTermGrowthRates> localVarResponse = await GetZacksLongTermGrowthRatesAsyncWithHttpInfo(identifier, pageSize, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Zacks Long Term Growth Rates This database offers consensus long term growth rate estimates, including insight into changes in estimates and revisions over time.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseZacksLongTermGrowthRates)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseZacksLongTermGrowthRates>> GetZacksLongTermGrowthRatesAsyncWithHttpInfo (string identifier = null, int? pageSize = null, string nextPage = null)
        {

            var localVarPath = "/zacks/long_term_growth_rates";
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
              

            if (identifier != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "identifier", identifier)); // query parameter
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetZacksLongTermGrowthRates", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseZacksLongTermGrowthRates>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseZacksLongTermGrowthRates) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseZacksLongTermGrowthRates)));
        }

        /// <summary>
        /// Zacks Sales Estimates This database offers consensus sales estimates for over 5,000 US and Canadian listed companies.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID) (optional)</param>
        /// <param name="startDate">Limit Sales estimates to those on or after this date (optional)</param>
        /// <param name="endDate">Limit Sales estimates to those on or before this date (optional)</param>
        /// <param name="fiscalYear">Only for the given fiscal year (optional)</param>
        /// <param name="fiscalPeriod">The fiscal period (optional)</param>
        /// <param name="calendarYear">Only for the given calendar year (optional)</param>
        /// <param name="calendarPeriod">The calendar period (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage2">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseZacksSalesEstimates</returns>
        public ApiResponseZacksSalesEstimates GetZacksSalesEstimates (string identifier = null, DateTime? startDate = null, DateTime? endDate = null, int? fiscalYear = null, string fiscalPeriod = null, int? calendarYear = null, string calendarPeriod = null, string nextPage = null, int? pageSize = null, string nextPage2 = null)
        {
             ApiResponse<ApiResponseZacksSalesEstimates> localVarResponse = GetZacksSalesEstimatesWithHttpInfo(identifier, startDate, endDate, fiscalYear, fiscalPeriod, calendarYear, calendarPeriod, nextPage, pageSize, nextPage2);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Zacks Sales Estimates This database offers consensus sales estimates for over 5,000 US and Canadian listed companies.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID) (optional)</param>
        /// <param name="startDate">Limit Sales estimates to those on or after this date (optional)</param>
        /// <param name="endDate">Limit Sales estimates to those on or before this date (optional)</param>
        /// <param name="fiscalYear">Only for the given fiscal year (optional)</param>
        /// <param name="fiscalPeriod">The fiscal period (optional)</param>
        /// <param name="calendarYear">Only for the given calendar year (optional)</param>
        /// <param name="calendarPeriod">The calendar period (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage2">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseZacksSalesEstimates</returns>
        
        
        public ApiResponse< ApiResponseZacksSalesEstimates > GetZacksSalesEstimatesWithHttpInfo (string identifier = null, DateTime? startDate = null, DateTime? endDate = null, int? fiscalYear = null, string fiscalPeriod = null, int? calendarYear = null, string calendarPeriod = null, string nextPage = null, int? pageSize = null, string nextPage2 = null)
        {

            var localVarPath = "/zacks/sales_estimates";
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
            
            
            if (identifier != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "identifier", identifier)); // query parameter
            if (startDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
            if (endDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
            if (fiscalYear != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "fiscal_year", fiscalYear)); // query parameter
            if (fiscalPeriod != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "fiscal_period", fiscalPeriod)); // query parameter
            if (calendarYear != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "calendar_year", calendarYear)); // query parameter
            if (calendarPeriod != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "calendar_period", calendarPeriod)); // query parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
            if (nextPage2 != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage2)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetZacksSalesEstimates", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseZacksSalesEstimates>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseZacksSalesEstimates) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseZacksSalesEstimates)));
        }

        /// <summary>
        /// Zacks Sales Estimates This database offers consensus sales estimates for over 5,000 US and Canadian listed companies.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID) (optional)</param>
        /// <param name="startDate">Limit Sales estimates to those on or after this date (optional)</param>
        /// <param name="endDate">Limit Sales estimates to those on or before this date (optional)</param>
        /// <param name="fiscalYear">Only for the given fiscal year (optional)</param>
        /// <param name="fiscalPeriod">The fiscal period (optional)</param>
        /// <param name="calendarYear">Only for the given calendar year (optional)</param>
        /// <param name="calendarPeriod">The calendar period (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage2">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseZacksSalesEstimates</returns>
        public async System.Threading.Tasks.Task<ApiResponseZacksSalesEstimates> GetZacksSalesEstimatesAsync (string identifier = null, DateTime? startDate = null, DateTime? endDate = null, int? fiscalYear = null, string fiscalPeriod = null, int? calendarYear = null, string calendarPeriod = null, string nextPage = null, int? pageSize = null, string nextPage2 = null)
        {
             ApiResponse<ApiResponseZacksSalesEstimates> localVarResponse = await GetZacksSalesEstimatesAsyncWithHttpInfo(identifier, startDate, endDate, fiscalYear, fiscalPeriod, calendarYear, calendarPeriod, nextPage, pageSize, nextPage2);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Zacks Sales Estimates This database offers consensus sales estimates for over 5,000 US and Canadian listed companies.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID) (optional)</param>
        /// <param name="startDate">Limit Sales estimates to those on or after this date (optional)</param>
        /// <param name="endDate">Limit Sales estimates to those on or before this date (optional)</param>
        /// <param name="fiscalYear">Only for the given fiscal year (optional)</param>
        /// <param name="fiscalPeriod">The fiscal period (optional)</param>
        /// <param name="calendarYear">Only for the given calendar year (optional)</param>
        /// <param name="calendarPeriod">The calendar period (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage2">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseZacksSalesEstimates)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseZacksSalesEstimates>> GetZacksSalesEstimatesAsyncWithHttpInfo (string identifier = null, DateTime? startDate = null, DateTime? endDate = null, int? fiscalYear = null, string fiscalPeriod = null, int? calendarYear = null, string calendarPeriod = null, string nextPage = null, int? pageSize = null, string nextPage2 = null)
        {

            var localVarPath = "/zacks/sales_estimates";
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
              

            if (identifier != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "identifier", identifier)); // query parameter
            if (startDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
            if (endDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
            if (fiscalYear != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "fiscal_year", fiscalYear)); // query parameter
            if (fiscalPeriod != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "fiscal_period", fiscalPeriod)); // query parameter
            if (calendarYear != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "calendar_year", calendarYear)); // query parameter
            if (calendarPeriod != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "calendar_period", calendarPeriod)); // query parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
            if (nextPage2 != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage2)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetZacksSalesEstimates", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseZacksSalesEstimates>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseZacksSalesEstimates) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseZacksSalesEstimates)));
        }

        /// <summary>
        /// Zacks Sales Surprises This database returns historical estimated and actual sales, guidance, and announcement dates for 17,000+ US and Canadian listed companies.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Limit sales surprises to those on or after this date (optional)</param>
        /// <param name="endDate">Limit sales surprises to those on or before this date (optional)</param>
        /// <param name="salesActualGreater">Return only records with an actual sales higher than this value (optional)</param>
        /// <param name="salesActualLess">Return only records with an actual sales lower than this value (optional)</param>
        /// <param name="salesMeanEstimateGreater">Return only records with a sales mean estimate greater than this value (optional)</param>
        /// <param name="salesMeanEstimateLess">Return only records with a sales mean estimate lower than this value (optional)</param>
        /// <param name="salesAmountDiffGreater">Return only records with a sales amount difference greater than this value (optional)</param>
        /// <param name="salesAmountDiffLess">Return only records with a sales amount difference less than this value (optional)</param>
        /// <param name="salesPercentDiffGreater">Return only records with a sales percent difference greater than this value (optional)</param>
        /// <param name="salesPercentDiffLess">Return only records with a sales percent difference less than this value (optional)</param>
        /// <param name="salesCountEstimateGreater">Return only records with a sales count estimate greater than this value (optional)</param>
        /// <param name="salesCountEstimateLess">Return only records with a sales count estimate less than this value (optional)</param>
        /// <param name="salesStdDevEstimateGreater">Return only records with a sales standard deviation greater than this value (optional)</param>
        /// <param name="salesStdDevEstimateLess">Return only records with a sales standard deviation less than this value (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseZacksSalesSurprises</returns>
        public ApiResponseZacksSalesSurprises GetZacksSalesSurprises (DateTime? startDate = null, DateTime? endDate = null, decimal? salesActualGreater = null, decimal? salesActualLess = null, decimal? salesMeanEstimateGreater = null, decimal? salesMeanEstimateLess = null, decimal? salesAmountDiffGreater = null, decimal? salesAmountDiffLess = null, decimal? salesPercentDiffGreater = null, decimal? salesPercentDiffLess = null, decimal? salesCountEstimateGreater = null, decimal? salesCountEstimateLess = null, decimal? salesStdDevEstimateGreater = null, decimal? salesStdDevEstimateLess = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseZacksSalesSurprises> localVarResponse = GetZacksSalesSurprisesWithHttpInfo(startDate, endDate, salesActualGreater, salesActualLess, salesMeanEstimateGreater, salesMeanEstimateLess, salesAmountDiffGreater, salesAmountDiffLess, salesPercentDiffGreater, salesPercentDiffLess, salesCountEstimateGreater, salesCountEstimateLess, salesStdDevEstimateGreater, salesStdDevEstimateLess, pageSize, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Zacks Sales Surprises This database returns historical estimated and actual sales, guidance, and announcement dates for 17,000+ US and Canadian listed companies.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Limit sales surprises to those on or after this date (optional)</param>
        /// <param name="endDate">Limit sales surprises to those on or before this date (optional)</param>
        /// <param name="salesActualGreater">Return only records with an actual sales higher than this value (optional)</param>
        /// <param name="salesActualLess">Return only records with an actual sales lower than this value (optional)</param>
        /// <param name="salesMeanEstimateGreater">Return only records with a sales mean estimate greater than this value (optional)</param>
        /// <param name="salesMeanEstimateLess">Return only records with a sales mean estimate lower than this value (optional)</param>
        /// <param name="salesAmountDiffGreater">Return only records with a sales amount difference greater than this value (optional)</param>
        /// <param name="salesAmountDiffLess">Return only records with a sales amount difference less than this value (optional)</param>
        /// <param name="salesPercentDiffGreater">Return only records with a sales percent difference greater than this value (optional)</param>
        /// <param name="salesPercentDiffLess">Return only records with a sales percent difference less than this value (optional)</param>
        /// <param name="salesCountEstimateGreater">Return only records with a sales count estimate greater than this value (optional)</param>
        /// <param name="salesCountEstimateLess">Return only records with a sales count estimate less than this value (optional)</param>
        /// <param name="salesStdDevEstimateGreater">Return only records with a sales standard deviation greater than this value (optional)</param>
        /// <param name="salesStdDevEstimateLess">Return only records with a sales standard deviation less than this value (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseZacksSalesSurprises</returns>
        
        
        public ApiResponse< ApiResponseZacksSalesSurprises > GetZacksSalesSurprisesWithHttpInfo (DateTime? startDate = null, DateTime? endDate = null, decimal? salesActualGreater = null, decimal? salesActualLess = null, decimal? salesMeanEstimateGreater = null, decimal? salesMeanEstimateLess = null, decimal? salesAmountDiffGreater = null, decimal? salesAmountDiffLess = null, decimal? salesPercentDiffGreater = null, decimal? salesPercentDiffLess = null, decimal? salesCountEstimateGreater = null, decimal? salesCountEstimateLess = null, decimal? salesStdDevEstimateGreater = null, decimal? salesStdDevEstimateLess = null, int? pageSize = null, string nextPage = null)
        {

            var localVarPath = "/zacks/sales_surprises";
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
            
            
            if (startDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
            if (endDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
            if (salesActualGreater != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sales_actual_greater", salesActualGreater)); // query parameter
            if (salesActualLess != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sales_actual_less", salesActualLess)); // query parameter
            if (salesMeanEstimateGreater != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sales_mean_estimate_greater", salesMeanEstimateGreater)); // query parameter
            if (salesMeanEstimateLess != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sales_mean_estimate_less", salesMeanEstimateLess)); // query parameter
            if (salesAmountDiffGreater != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sales_amount_diff_greater", salesAmountDiffGreater)); // query parameter
            if (salesAmountDiffLess != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sales_amount_diff_less", salesAmountDiffLess)); // query parameter
            if (salesPercentDiffGreater != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sales_percent_diff_greater", salesPercentDiffGreater)); // query parameter
            if (salesPercentDiffLess != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sales_percent_diff_less", salesPercentDiffLess)); // query parameter
            if (salesCountEstimateGreater != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sales_count_estimate_greater", salesCountEstimateGreater)); // query parameter
            if (salesCountEstimateLess != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sales_count_estimate_less", salesCountEstimateLess)); // query parameter
            if (salesStdDevEstimateGreater != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sales_std_dev_estimate_greater", salesStdDevEstimateGreater)); // query parameter
            if (salesStdDevEstimateLess != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sales_std_dev_estimate_less", salesStdDevEstimateLess)); // query parameter
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetZacksSalesSurprises", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseZacksSalesSurprises>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseZacksSalesSurprises) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseZacksSalesSurprises)));
        }

        /// <summary>
        /// Zacks Sales Surprises This database returns historical estimated and actual sales, guidance, and announcement dates for 17,000+ US and Canadian listed companies.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Limit sales surprises to those on or after this date (optional)</param>
        /// <param name="endDate">Limit sales surprises to those on or before this date (optional)</param>
        /// <param name="salesActualGreater">Return only records with an actual sales higher than this value (optional)</param>
        /// <param name="salesActualLess">Return only records with an actual sales lower than this value (optional)</param>
        /// <param name="salesMeanEstimateGreater">Return only records with a sales mean estimate greater than this value (optional)</param>
        /// <param name="salesMeanEstimateLess">Return only records with a sales mean estimate lower than this value (optional)</param>
        /// <param name="salesAmountDiffGreater">Return only records with a sales amount difference greater than this value (optional)</param>
        /// <param name="salesAmountDiffLess">Return only records with a sales amount difference less than this value (optional)</param>
        /// <param name="salesPercentDiffGreater">Return only records with a sales percent difference greater than this value (optional)</param>
        /// <param name="salesPercentDiffLess">Return only records with a sales percent difference less than this value (optional)</param>
        /// <param name="salesCountEstimateGreater">Return only records with a sales count estimate greater than this value (optional)</param>
        /// <param name="salesCountEstimateLess">Return only records with a sales count estimate less than this value (optional)</param>
        /// <param name="salesStdDevEstimateGreater">Return only records with a sales standard deviation greater than this value (optional)</param>
        /// <param name="salesStdDevEstimateLess">Return only records with a sales standard deviation less than this value (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseZacksSalesSurprises</returns>
        public async System.Threading.Tasks.Task<ApiResponseZacksSalesSurprises> GetZacksSalesSurprisesAsync (DateTime? startDate = null, DateTime? endDate = null, decimal? salesActualGreater = null, decimal? salesActualLess = null, decimal? salesMeanEstimateGreater = null, decimal? salesMeanEstimateLess = null, decimal? salesAmountDiffGreater = null, decimal? salesAmountDiffLess = null, decimal? salesPercentDiffGreater = null, decimal? salesPercentDiffLess = null, decimal? salesCountEstimateGreater = null, decimal? salesCountEstimateLess = null, decimal? salesStdDevEstimateGreater = null, decimal? salesStdDevEstimateLess = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseZacksSalesSurprises> localVarResponse = await GetZacksSalesSurprisesAsyncWithHttpInfo(startDate, endDate, salesActualGreater, salesActualLess, salesMeanEstimateGreater, salesMeanEstimateLess, salesAmountDiffGreater, salesAmountDiffLess, salesPercentDiffGreater, salesPercentDiffLess, salesCountEstimateGreater, salesCountEstimateLess, salesStdDevEstimateGreater, salesStdDevEstimateLess, pageSize, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Zacks Sales Surprises This database returns historical estimated and actual sales, guidance, and announcement dates for 17,000+ US and Canadian listed companies.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Limit sales surprises to those on or after this date (optional)</param>
        /// <param name="endDate">Limit sales surprises to those on or before this date (optional)</param>
        /// <param name="salesActualGreater">Return only records with an actual sales higher than this value (optional)</param>
        /// <param name="salesActualLess">Return only records with an actual sales lower than this value (optional)</param>
        /// <param name="salesMeanEstimateGreater">Return only records with a sales mean estimate greater than this value (optional)</param>
        /// <param name="salesMeanEstimateLess">Return only records with a sales mean estimate lower than this value (optional)</param>
        /// <param name="salesAmountDiffGreater">Return only records with a sales amount difference greater than this value (optional)</param>
        /// <param name="salesAmountDiffLess">Return only records with a sales amount difference less than this value (optional)</param>
        /// <param name="salesPercentDiffGreater">Return only records with a sales percent difference greater than this value (optional)</param>
        /// <param name="salesPercentDiffLess">Return only records with a sales percent difference less than this value (optional)</param>
        /// <param name="salesCountEstimateGreater">Return only records with a sales count estimate greater than this value (optional)</param>
        /// <param name="salesCountEstimateLess">Return only records with a sales count estimate less than this value (optional)</param>
        /// <param name="salesStdDevEstimateGreater">Return only records with a sales standard deviation greater than this value (optional)</param>
        /// <param name="salesStdDevEstimateLess">Return only records with a sales standard deviation less than this value (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseZacksSalesSurprises)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseZacksSalesSurprises>> GetZacksSalesSurprisesAsyncWithHttpInfo (DateTime? startDate = null, DateTime? endDate = null, decimal? salesActualGreater = null, decimal? salesActualLess = null, decimal? salesMeanEstimateGreater = null, decimal? salesMeanEstimateLess = null, decimal? salesAmountDiffGreater = null, decimal? salesAmountDiffLess = null, decimal? salesPercentDiffGreater = null, decimal? salesPercentDiffLess = null, decimal? salesCountEstimateGreater = null, decimal? salesCountEstimateLess = null, decimal? salesStdDevEstimateGreater = null, decimal? salesStdDevEstimateLess = null, int? pageSize = null, string nextPage = null)
        {

            var localVarPath = "/zacks/sales_surprises";
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
              

            if (startDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
            if (endDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
            if (salesActualGreater != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sales_actual_greater", salesActualGreater)); // query parameter
            if (salesActualLess != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sales_actual_less", salesActualLess)); // query parameter
            if (salesMeanEstimateGreater != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sales_mean_estimate_greater", salesMeanEstimateGreater)); // query parameter
            if (salesMeanEstimateLess != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sales_mean_estimate_less", salesMeanEstimateLess)); // query parameter
            if (salesAmountDiffGreater != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sales_amount_diff_greater", salesAmountDiffGreater)); // query parameter
            if (salesAmountDiffLess != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sales_amount_diff_less", salesAmountDiffLess)); // query parameter
            if (salesPercentDiffGreater != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sales_percent_diff_greater", salesPercentDiffGreater)); // query parameter
            if (salesPercentDiffLess != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sales_percent_diff_less", salesPercentDiffLess)); // query parameter
            if (salesCountEstimateGreater != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sales_count_estimate_greater", salesCountEstimateGreater)); // query parameter
            if (salesCountEstimateLess != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sales_count_estimate_less", salesCountEstimateLess)); // query parameter
            if (salesStdDevEstimateGreater != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sales_std_dev_estimate_greater", salesStdDevEstimateGreater)); // query parameter
            if (salesStdDevEstimateLess != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sales_std_dev_estimate_less", salesStdDevEstimateLess)); // query parameter
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetZacksSalesSurprises", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseZacksSalesSurprises>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseZacksSalesSurprises) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseZacksSalesSurprises)));
        }

        /// <summary>
        /// Zacks Target Price Consensuses Returns the latest Zacks target price consensus data
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">Filings for the given &#x60;company&#x60; identifier (ticker, CIK, LEI, Intrinio ID) (optional)</param>
        /// <param name="industryGroupNumber">Return only growth rates for companies in the given Zacks industry group number (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseZacksTargetPriceConsensuses</returns>
        public ApiResponseZacksTargetPriceConsensuses GetZacksTargetPriceConsensuses (string identifier = null, string industryGroupNumber = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseZacksTargetPriceConsensuses> localVarResponse = GetZacksTargetPriceConsensusesWithHttpInfo(identifier, industryGroupNumber, pageSize, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Zacks Target Price Consensuses Returns the latest Zacks target price consensus data
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">Filings for the given &#x60;company&#x60; identifier (ticker, CIK, LEI, Intrinio ID) (optional)</param>
        /// <param name="industryGroupNumber">Return only growth rates for companies in the given Zacks industry group number (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseZacksTargetPriceConsensuses</returns>
        
        
        public ApiResponse< ApiResponseZacksTargetPriceConsensuses > GetZacksTargetPriceConsensusesWithHttpInfo (string identifier = null, string industryGroupNumber = null, int? pageSize = null, string nextPage = null)
        {

            var localVarPath = "/zacks/target_price_consensuses";
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
            
            
            if (identifier != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "identifier", identifier)); // query parameter
            if (industryGroupNumber != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "industry_group_number", industryGroupNumber)); // query parameter
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetZacksTargetPriceConsensuses", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseZacksTargetPriceConsensuses>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseZacksTargetPriceConsensuses) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseZacksTargetPriceConsensuses)));
        }

        /// <summary>
        /// Zacks Target Price Consensuses Returns the latest Zacks target price consensus data
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">Filings for the given &#x60;company&#x60; identifier (ticker, CIK, LEI, Intrinio ID) (optional)</param>
        /// <param name="industryGroupNumber">Return only growth rates for companies in the given Zacks industry group number (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseZacksTargetPriceConsensuses</returns>
        public async System.Threading.Tasks.Task<ApiResponseZacksTargetPriceConsensuses> GetZacksTargetPriceConsensusesAsync (string identifier = null, string industryGroupNumber = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseZacksTargetPriceConsensuses> localVarResponse = await GetZacksTargetPriceConsensusesAsyncWithHttpInfo(identifier, industryGroupNumber, pageSize, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Zacks Target Price Consensuses Returns the latest Zacks target price consensus data
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">Filings for the given &#x60;company&#x60; identifier (ticker, CIK, LEI, Intrinio ID) (optional)</param>
        /// <param name="industryGroupNumber">Return only growth rates for companies in the given Zacks industry group number (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseZacksTargetPriceConsensuses)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseZacksTargetPriceConsensuses>> GetZacksTargetPriceConsensusesAsyncWithHttpInfo (string identifier = null, string industryGroupNumber = null, int? pageSize = null, string nextPage = null)
        {

            var localVarPath = "/zacks/target_price_consensuses";
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
              

            if (identifier != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "identifier", identifier)); // query parameter
            if (industryGroupNumber != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "industry_group_number", industryGroupNumber)); // query parameter
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetZacksTargetPriceConsensuses", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseZacksTargetPriceConsensuses>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseZacksTargetPriceConsensuses) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseZacksTargetPriceConsensuses)));
        }

    }
}
