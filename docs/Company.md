[//]: # (CLASS:Intrinio.SDK.Model.Company)

[//]: # (KIND:object)

### Intrinio.SDK.Model.Company
#### Properties

[//]: # (START_DEFINITION)

Name | Type | Description
------------ | ------------- | -------------
**Id** | string | The Intrinio ID of the company &nbsp;
**Ticker** | string | The stock market ticker symbol associated with the company&#39;s common stock securities &nbsp;
**Name** | string | The company&#39;s common name &nbsp;
**Lei** | string | The Legal Entity Identifier (LEI) assigned to the company &nbsp;
**LegalName** | string | The company&#39;s official legal name &nbsp;
**StockExchange** | string | The Stock Exchange where the company&#39;s common stock is primarily traded &nbsp;
**Sic** | string | The Standard Industrial Classification (SIC) determined by the company and filed with the SEC &nbsp;
**ShortDescription** | string | A one or two sentence description of the company&#39;s operations &nbsp;
**LongDescription** | string | A one paragraph description of the company&#39;s operations and other corporate actions &nbsp;
**Ceo** | string | The Chief Executive Officer of the company &nbsp;
**CompanyUrl** | string | The URL of the company&#39;s primary corporate website or primary internet property &nbsp;
**BusinessAddress** | string | The company&#39;s business address &nbsp;
**MailingAddress** | string | The mailing address reported by the company &nbsp;
**BusinessPhoneNo** | string | The phone number reported by the company &nbsp;
**HqAddress1** | string | The company&#39;s headquarters address - line 1 &nbsp;
**HqAddress2** | string | The company&#39;s headquarters address - line 2 &nbsp;
**HqAddressCity** | string | The company&#39;s headquarters city &nbsp;
**HqAddressPostalCode** | string | The company&#39;s headquarters postal code &nbsp;
**EntityLegalForm** | string | The company&#39;s legal organization form &nbsp;
**Cik** | string | The Central Index Key (CIK) assigned to the company by the SEC as a unique identifier, used in SEC filings &nbsp;
**LatestFilingDate** | DateTime? | The date of the company&#39;s last filing with the SEC &nbsp;
**HqState** | string | The state (US &amp; Canada Only) where the company headquarters are located &nbsp;
**HqCountry** | string | The country where the company headquarters are located &nbsp;
**IncState** | string | The state (US &amp; Canada Only) where the company is incorporated &nbsp;
**IncCountry** | string | The country where the company is incorporated &nbsp;
**Employees** | int? | The number of employees working for the company &nbsp;
**EntityStatus** | string |  &nbsp;
**Sector** | string | The company&#39;s operating sector &nbsp;
**IndustryCategory** | string | The company&#39;s operating industry category &nbsp;
**IndustryGroup** | string | The company&#39;s operating industry group &nbsp;
**Template** | string | The financial statement template used by Intrinio to standardize the as reported data &nbsp;
**StandardizedActive** | bool? | If true, the company has standardized and as reported fundamental data via the Intrinio API; if false, the company has as-reported data only &nbsp;
**FirstFundamentalDate** | DateTime? | The period end date of the company&#39;s first reported fundamental &nbsp;
**LastFundamentalDate** | DateTime? | The period end date of the company&#39;s last reported fundamental &nbsp;
**FirstStockPriceDate** | DateTime? | The date of the company&#39;s first stock price, based on the company&#39;s primary security, which is typically traded on US exchages &nbsp;
**LastStockPriceDate** | DateTime? | The date of the company&#39;s last stock price, based on the company&#39;s primary security, which is typically traded on US exchages &nbsp;

[//]: # (END_DEFINITION)


