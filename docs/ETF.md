[//]: # (CLASS:Intrinio.SDK.Model.ETF)

[//]: # (KIND:object)

### Intrinio.SDK.Model.ETF
#### Properties

[//]: # (START_DEFINITION)

Name | Type | Description
------------ | ------------- | -------------
**Id** | string | The Intrinio ID of the ETF &nbsp;
**Name** | string | The common name of the ETF &nbsp;
**Ticker** | string | The common ticker symbol for the ETF &nbsp;
**FigiTicker** | string | The OpenFIGI ticker for the ETF &nbsp;
**Ric** | string | Reuters Instrument Code (RIC) for the ETF &nbsp;
**Isin** | string | International Securities Identification Number (ISIN) for the ETF &nbsp;
**Sedol** | string | Stock Exchange Daily Official List (SEDOL) for the ETF &nbsp;
**ExchangeMic** | string | The exchange Market Identifier Code (MIC) from the International Standards Organization (ISO) &nbsp;
**Sponsor** | string | The fund manager (ETF) or issuing bank (ETN) &nbsp;
**Type** | string | High-level classification for the ETF based on its intended investment objective &nbsp;
**Description** | string | The ETF description as published by the ETF sponsor &nbsp;
**InceptionDate** | DateTime? | Inception Date for the ETF as published by the ETF sponsor &nbsp;
**DataChangeDate** | DateTime? | The last date on which there was a change in a classifications data field for this ETF &nbsp;
**CloseDate** | DateTime? | The date on which this ETF was de-listed if it is no longer listed &nbsp;
**IsLiveListed** | bool? | If true, the ETF is still listed on an exchange; if false, the ETF is no longer listed &nbsp;
**LegalStructure** | string | The legal structure as defined in the prospectus &nbsp;
**IntradayNavTicker** | string | Intra-day NAV ticker for the Exchange Traded Fund (ETF) &nbsp;
**PrimaryTicker** | string | The primary ticker field is used for Exchange Traded Products (ETPs) that have multiple listings and share classes. If an ETP has multiple listings or share classes, the same primary ticker is assigned to all the listings and share classes &nbsp;
**PrimaryTickerCountryCode** | string | 2 letter ISO country code for the country of the primary listing &nbsp;
**PrimaryListingRegion** | string | Geographic region in the country of the primary listing falls &nbsp;
**NetExpenseRatio** | decimal? | Gross expense net of Fee Waivers, as a percentage of net assets as published by the ETF Sponsor &nbsp;
**AssetClass** | string | Captures the underlying nature of the securities in the Exchanged Traded Product (ETP) &nbsp;
**OtherAssetTypes** | string | If &#39;asset_class&#39; field is classified as &#39;Other Asset Types&#39; this field captures the specific category of the underlying assets &nbsp;
**MarketCapRange** | string | Equity ETFs are classified as falling into categories based on the description of their investment strategy in the prospectus.  Examples (&#39;Mega Cap&#39;, &#39;Large Cap&#39;, &#39;Mid Cap&#39;, etc.) &nbsp;
**HoldsOnlyNyseStocks** | bool? | If true, the ETF is an equity ETF and holds only stocks listed on NYSE &nbsp;
**HoldsOnlyNasdaqStocks** | bool? | If false, the ETF is an equity ETF and holds only stocks listed on Nasdaq &nbsp;
**GrowthValueTilt** | string | Classifies equity ETFs as either &#39;Growth&#39; or Value&#39; based on the stated style tilt in the ETF prospectus. Equity ETFs that do not have a stated style tilt are classified as &#39;Core / Blend&#39; &nbsp;
**GrowthType** | string | For ETFs that are classified as &#39;Growth&#39; in &#39;growth_value_tilt&#39;, this field further identifies those where the stocks in the ETF are both selected and weighted based on their growth (style factor) scores &nbsp;
**ValueType** | string | For ETFs that are classified as &#39;Value&#39; in &#39;growth_value_tilt&#39;, this field further identifies those where the stocks in the ETF are both selected and weighted based on their value (style factor) scores &nbsp;
**Sector** | string | For equity ETFs that aim to provide targeted exposure to a sector or industry, this field identifies the Sector that it provides the exposure to &nbsp;
**Industry** | string | For equity ETFs that aim to provide targeted exposure to an industry, this field identifies the Industry that it provides the exposure to. &nbsp;
**SubIndustry** | string | For equity ETFs that aim to provide targeted exposure to a sub-industry, this field identifies the sub-industry that it provides the exposure to &nbsp;
**CrossSectorTheme** | string | For equity ETFs that aim to provide targeted exposure to a specific investment theme that cuts across GICS sectors, this field identifies the specific cross-sector theme.  Examples (&#39;Agri-business&#39;, &#39;Natural Resources&#39;, &#39;Green Investing&#39;, etc.) &nbsp;
**NaturalResourcesType** | string | For ETFs that are classified as &#39;Natural Resources&#39; in the &#39;cross_sector_theme&#39; field, this field provides further detail on the type of Natural Resources exposure. &nbsp;
**ExcludesFinancials** | bool? | For equity ETFs, identifies those ETFs where the underlying fund holdings will not hold financials stocks, based on the funds intended objective &nbsp;
**ExcludesTechnology** | bool? | For equity ETFs, identifies those ETFs where the underlying fund holdings will not hold technology stocks, based on the funds intended objective &nbsp;
**UsOrExcludesUs** | string | Takes the value of &#39;Domestic&#39; for US exposure, &#39;International&#39; for non-US exposure and &#39;Global&#39; for exposure that includes all regions including the US &nbsp;
**DevelopedEmerging** | string | This field identifies the stage of development of the markets that the ETF provides exposure to &nbsp;
**SpecializedRegion** | string | This field is populated if the ETF provides targeted exposure to a specific type of geography-based grouping that does not fall into a specific country or continent grouping.  Examples (&#39;BRIC&#39;, &#39;Chindia&#39;, etc.) &nbsp;
**Continent** | string | This field is populated if the ETF provides targeted exposure to a specific continent or country within that Continent &nbsp;
**LatinAmericaSubGroup** | string | For ETFs that are classified as &#39;Latin America&#39; in the &#39;continent&#39; field, this field provides further detail on the type of regional exposure &nbsp;
**EuropeSubGroup** | string | For ETFs that are classified as &#39;Europe&#39; in the &#39;continent&#39; field, this field provides further detail on the type of regional exposure &nbsp;
**AsiaSubGroup** | string | For ETFs that are classified as &#39;Asia&#39; in the &#39;continent&#39; field, this field provides further detail on the type of regional exposure &nbsp;
**SpecificCountry** | string | This field is populated if the ETF provides targeted exposure to a specific country &nbsp;
**ChinaListingLocation** | string | For ETFs that are classified as &#39;China&#39; in the &#39;country&#39; field, this field provides further detail on the type of exposure in the underlying securities &nbsp;
**UsState** | string | Takes the value of a US state if the ETF provides targeted exposure to the municipal bonds or equities of companies operating in a specific state in the US &nbsp;
**RealEstate** | string | For ETFs that provide targeted real estate exposure, this field is populated if the ETF provides targeted exposure to a specific segment of the real estate market &nbsp;
**IndexWeightingScheme** | string | For ETFs that track an underlying index, this field provides detail on the index weighting type &nbsp;
**MarketCapWeightingType** | string | For ETFs that take the value &#39;Market Cap Weighted&#39; in the &#39;index_weighting_scheme&#39; field, this field provides detail on the market cap weighting type &nbsp;
**FundamentalWeightingType** | string | For ETFs that take the value ‘Fundamental Weighted’ in the &#39;index_weighting_scheme&#39; field, this field provides detail on the fundamental weighting methodology &nbsp;
**DividendWeightingType** | string | For ETFs that take the value &#39;Dividend Weighted&#39; in the &#39;index_weighting_scheme&#39; field, this field provides detail on the dividend weighting methodology &nbsp;
**BondType** | string | For ETFs where &#39;asset_class_type&#39; is &#39;Bonds&#39;, this field provides detail on the type of bonds held in the ETF &nbsp;
**GovernmentBondTypes** | string | For bond ETFs that take the value &#39;Treasury &amp; Government&#39; in &#39;bond_type&#39;, this field provides detail on the exposure &nbsp;
**MunicipalBondRegion** | string | For bond ETFs that take the value &#39;Municipal&#39; in &#39;bond_type&#39;, this field provides additional detail on the geographic exposure &nbsp;
**MunicipalVrdo** | bool? | For bond ETFs that take the value &#39;Municipal&#39; in &#39;bond_type&#39;, this field identifies those ETFs that specifically provide exposure to Variable Rate Demand Obligations &nbsp;
**MortgageBondTypes** | string | For bond ETFs that take the value &#39;Mortgage&#39; in &#39;bond_type&#39;, this field provides additional detail on the type of underlying securities &nbsp;
**BondTaxStatus** | string | For all US bond ETFs, this field provides additional detail on the tax treatment of the underlying securities &nbsp;
**CreditQuality** | string | For all bond ETFs, this field helps to identify if the ETF provides targeted exposure to securities of a specific credit quality range &nbsp;
**AverageMaturity** | string | For all bond ETFs, this field helps to identify if the ETF provides targeted exposure to securities of a specific maturity range &nbsp;
**SpecificMaturityYear** | int? | For all bond ETFs that take the value &#39;Specific Maturity Year&#39; in the &#39;average_maturity&#39; field, this field specifies the calendar year &nbsp;
**BondCurrencyDenomination** | string | For all bond ETFs, this field provides additional detail on the currency denomination of the underlying securities &nbsp;
**Laddered** | bool? | For bond ETFs, this field identifies those ETFs that specifically hold bonds in a laddered structure, where the bonds are scheduled to mature in an annual, sequential structure &nbsp;
**ZeroCoupon** | bool? | For bond ETFs, this field identifies those ETFs that specifically hold zero coupon Treasury Bills &nbsp;
**FloatingRate** | bool? | For bond ETFs, this field identifies those ETFs that specifically hold floating rate bonds &nbsp;
**BuildAmericaBonds** | bool? | For municipal bond ETFs, this field identifies those ETFs that specifically hold Build America Bonds &nbsp;
**CommodityTypes** | string | For ETFs where &#39;asset_class_type&#39; is &#39;Commodities&#39;, this field provides detail on the type of commodities held in the ETF &nbsp;
**EnergyType** | string | For ETFs where &#39;commodity_type&#39; is &#39;Energy&#39;, this field provides detail on the type of energy exposure provided by the ETF &nbsp;
**AgriculturalType** | string | For ETFs where &#39;commodity_type&#39; is &#39;Agricultural&#39;, this field provides detail on the type of agricultural exposure provided by the ETF &nbsp;
**MetalType** | string | For ETFs where &#39;commodity_type&#39; is &#39;Gold &amp; Metals&#39;, this field provides detail on the type of exposure provided by the ETF &nbsp;
**InverseLeveraged** | string | This field is populated if the ETF provides inverse or leveraged exposure &nbsp;
**TargetDateMultiAssetType** | string | For ETFs where &#39;asset_class_type&#39; is &#39;Target Date / MultiAsset&#39;, this field provides detail on the type of commodities held in the ETF &nbsp;
**CurrencyHedged** | bool? | This field is populated if the ETF’s strategy involves hedging currency exposure &nbsp;
**CurrencyPair** | string | This field is populated if the ETF’s strategy involves providing exposure to the movements of a currency or involves hedging currency exposure &nbsp;
**SocialEnvironmentalType** | string | This field is populated if the ETF’s strategy involves providing exposure to a specific social or environmental theme &nbsp;
**CleanEnergyType** | string | This field is populated if the ETF has a value of &#39;Clean Energy&#39; in the &#39;social_environmental_type&#39; field. &nbsp;
**DividendType** | string | This field is populated if the ETF has an intended investment objective of holding dividend-oriented stocks as stated in the prospectus &nbsp;
**RegularDividendPayorType** | string | This field is populated if the ETF has a value of &#39;Dividend – Regular Payors&#39; in the &#39;dividend_type&#39; field &nbsp;
**HoldsMlPs** | bool? | If true, the ETF’s investment objective explicitly specifies that it holds MLPs as an intended part of its investment strategy &nbsp;
**HoldsPreferredStock** | bool? | If true, the ETF’s investment objective explicitly specifies that it holds preferred stock as an intended part of its investment strategy &nbsp;
**HoldsClosedEndFunds** | bool? | IF true, if the ETF’s investment objective explicitly specifies that it holds closed end funds as an intended part of its investment strategy &nbsp;
**QuantStrategiesType** | string | This field is populated if the ETF has either an index-linked or active strategy that is based on a proprietary quantitative strategy &nbsp;
**OtherQuantModels** | string | For ETFs where &#39;quant_strategies_type&#39; is &#39;Other Quant Model&#39;, this field provides the name of the specific proprietary quant model used as the underlying strategy for the ETF &nbsp;
**HedgeFundType** | string | For ETFs where &#39;other_asset_types&#39; is &#39;Hedge Fund Replication&#39;, this field provides detail on the type of hedge fund replication strategy &nbsp;
**DerivativesBased** | string | This field is populated if the ETF holds either listed or over-the-counter derivatives in its portfolio &nbsp;
**HoldsAdRs** | bool? | If true, he ETF’s investment objective explicitly specifies that it holds American Depositary Receipts (ADRs) as an intended part of its investment strategy &nbsp;
**IndexLinked** | string | This field identifies whether an ETF is index linked or active &nbsp;
**IncludesShortExposure** | bool? | This field is populated if the ETF has short exposure in any of its holdings e.g. in a long/short or inverse ETF &nbsp;
**IndexName** | string | This field identifies the name of the underlying index tracked by the ETF, if applicable &nbsp;
**ParentIndex** | string | This field identifies the name of the parent index, which represents the broader universe from which the index underlying the ETF is created, if applicable &nbsp;
**IndexFamily** | string | This field identifies the index family to which the index underlying the ETF belongs. The index family is represented as categorized by the index provider &nbsp;
**BroaderIndexFamily** | string | This field identifies the broader index family to which the index underlying the ETF belongs. The broader index family is represented as categorized by the index provider &nbsp;
**IndexProvider** | string | This field identifies the Index provider for the index underlying the ETF, if applicable &nbsp;
**FundFamily** | string | This field identifies the fund family to which the ETF belongs, as categorized by the ETF Sponsor &nbsp;
**IndexTicker** | string | This field identifies the OpenFIGI ticker for the Index underlying the ETF &nbsp;
**EtnIssuingBank** | string | If the product is an Exchange Traded Note (ETN), this field identifies the issuing bank &nbsp;
**EtnMaturityDate** | DateTime? | If the product is an ETN, this field identifies the maturity date for the ETN &nbsp;
**Livestock** | string | For ETFs where &#39;commodity_type&#39; is &#39;Livestock&#39;, this field provides detail on the type of livestock exposure provided by the ETF &nbsp;
**DynamicFuturesRoll** | bool? | If the product holds futures contracts, this field identifies those products where the roll strategy is dynamic (rather than entirely rules based), so as to minimize roll costs &nbsp;
**IndexProviderCode** | string | This field provides the First Bridge code for each Index provider, corresponding to the index underlying the ETF if applicable &nbsp;
**SingleCategoryDesignation** | string | This categorization is created for those users who want every ETF to be ‘forced’ into a single bucket, so that the assets for all categories will always sum to the total market &nbsp;
**RegisteredCountries** | string | The list of countries where the ETF is legally registered for sale. This may differ from where the ETF is domiciled or traded, particularly in Europe &nbsp;
**IssuingEntityCountryCode** | string | The name of the legal entity that issued the Exchange Traded Product (ETP) &nbsp;
**Ucits** | bool? | If true, the Exchange Traded Product (ETP) is Undertakings for the Collective Investment in Transferable Securities (UCITS) compliant &nbsp;
**ReplicationStructure** | string | The replication structure of the Exchange Traded Product (ETP) &nbsp;
**Domicile** | string | 2 letter ISO country code for the country where the ETP is domiciled &nbsp;
**BaseCurrency** | string | Base currency of the Exchange Traded Product (ETP) in which the net asset value (NAV) is calculated. Reported using the 3-digit ISO currency code &nbsp;
**ListingCurrency** | string | Listing currency of the Exchange Traded Product (ETP) in which it is traded. Reported using the 3-digit ISO currency code &nbsp;
**FundListingDate** | DateTime? | The date on which the Exchange Traded Product (ETP) or share class of the ETP is listed on a specific exchange &nbsp;
**ListingCountryCode** | string | 2 letter ISO country code for the country where the Exchange Traded Product (ETP) is listed &nbsp;
**ListingRegion** | string | The region in which this specific ETF is listed &nbsp;
**SmartvsTraditionalBeta** | string | This field identifies whether an ETF provides &#39;Traditional&#39; beta exposure or &#39;Smart&#39; beta exposure. ETFs that are active (i.e. non-indexed), leveraged / inverse or have a proprietary quant model (i.e. that don’t provide indexed exposure to a targeted factor) are classified separately &nbsp;
**SmartvsTraditionalBetaLevel2** | string | This field provides further detail within the traditional and smart beta categories &nbsp;
**IncomeCategory** | string | Identifies if an Exchange Traded Fund (ETF) falls into a category that is specifically designed to provide a high yield or income &nbsp;
**EtpStructureType** | string | Classifies Exchange Traded Products (ETPs) into very broad categories based on its legal structure &nbsp;
**MonthEndAssets** | decimal? | Net assets in millions of dollars as of the most recent month end &nbsp;
**EtfPortfolioTurnover** | decimal? | The percentage of positions turned over in the last 12 months &nbsp;
**FirstbridgeId** | string | The FirstBridge unique identifier for the Exchange Traded Fund (ETF) &nbsp;
**FirstbridgeParentId** | string | The FirstBridge unique identifier of the parent Exchange Traded Fund (ETF), if applicable &nbsp;
**NumberOfHoldings** | int? | The number of holdings for this Exchange Traded Fund (ETF) &nbsp;

[//]: # (END_DEFINITION)


