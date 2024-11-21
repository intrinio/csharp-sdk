

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
    /// ESGComprehensiveRating
    /// </summary>
    [DataContract]
    public partial class ESGComprehensiveRating :  IEquatable<ESGComprehensiveRating>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ESGComprehensiveRating" /> class.
        /// </summary>
        /// <param name="Date">Indicates the date on which the ESG Rating was calculated..</param>
        /// <param name="CountryAverageRating">The average ESG rating of all companies in a particular country in which the company is a peer of..</param>
        /// <param name="IndustryAverageRating">The average ESG rating of all companies in a particular industry in which the company is a peer of..</param>
        /// <param name="OverallRating">The company&#39;s overall aggregated ESG rating, taking into account its ESG scoring from the Community, Employee, Enviroment, and Governance categories..</param>
        /// <param name="CommunityRating">The Community Category reflects a companys citizenship, charitable giving, and volunteerism. This category covers the company&#39;s human rights record and treatment of its supply chain. It also covers the environmental and social impacts of the companys products and services, and the development of sustainable products, processes and technologies..</param>
        /// <param name="EmployeeRating">The Employees category includes disclosure of policies, programs, and performance in diversity, labor relations and labor rights. The evaluation focuses on the quality of policies and programs, compliance with national laws and regulations, and proactive management initiatives. The category includes evaluation of inclusive diversity policies, fair treatment of all employees, robust diversity (EEO-1) programs and training..</param>
        /// <param name="EnvironmentRating">The Environment category data covers a company&#39;s interactions with the environment at large, including use of natural resources. The category evaluates corporate environmental performance, compliance with environmental regulations, and mitigation of environmental footprint. It also includes leadership in addressing climate change through appropriate policies and strategies..</param>
        /// <param name="GovernanceRating">Corporate governance refers to leadership structure and the values that determine corporate direction, ethics and performance. The Governance category covers disclosure of policies and procedures, board independence and diversity, executive compensation, attention to stakeholder concerns, and evaluation of a company&#39;s culture of ethical leadership and compliance..</param>
        /// <param name="HumanRightsAndSupplyChainRating">The Human Rights and Supply Chain subcategory measures a company&#39;s commitment to respecting fundamental human rights conventions. This subcategory covers a company&#39;s transparency in overseas sourcing disclosure and monitoring. The subcategory also covers the relationship with and respect for the human rights of indigenous peoples near its proposed or current operations..</param>
        /// <param name="CommunityDevAndPhilanthropyRating">The Community Development and Philanthropy subcategory covers the relationship between a company and the communities within which it is embedded. It reflects a company&#39;s community citizenship through charitable giving, donations of goods, and volunteerism of staff time. It also includes protecting public health (e.g., avoidance of industrial accidents) and managing the social impacts of its operations..</param>
        /// <param name="ProductRating">The Product subcategory covers the responsibility of a company for the development, design, and management of its products and services. This subcategory reflects a company&#39;s capacity to reduce environmental costs, create new market opportunities, and produce or market goods and services that enhance the health and quality of life for consumers..</param>
        /// <param name="CompensationAndBenefitsRating">The Compensation and Benefits subcategory covers a company&#39;s capacity to increase its workforce loyalty and productivity. It includes benefits that engage employees and improve worker development. This subcategory also focuses on long-term employment growth and stability by promotion practices, lay-off practices, and relations with retired employees..</param>
        /// <param name="DiversityAndLaborRightsRating">The Diversity and Labor Rights subcategory covers workplace policies and practices covering fair and non-discriminatory treatment of employees. It covers a company&#39;s labor-management relations and participation by employees. Fundamental labor rights include freedom of association and protection of the right to organize..</param>
        /// <param name="TrainingHealthAndSafetyRating">The Training, Safety and Health subcategory measures a company&#39;s effectiveness in providing a healthy and safe workplace. It includes programs to support the health, well-being and productivity of all employees. This subcategory includes workplace policies and programs that boost employee morale, workplace productivity and worker development..</param>
        /// <param name="EnergyClimateChangeRating">The Energy and Climate Change subcategory measures a company&#39;s effectiveness in addressing climate change through appropriate policies and strategies. The subcategory includes energy use, emissions to air of CO2 and other Greenhouse Gas Emissions (GHG) and other alternative environmental technologies..</param>
        /// <param name="EnvironmentPolicyAndReportingRating">The Environmental Policy and Reporting subcategory includes a company&#39;s policies and intention to reduce the environmental impact of a company. The data includes the company&#39;s environmental reporting performance, adherence to environmental reporting standards and compliance with investor, regulatory and stakeholders&#39; requests for transparency. Compliance data consists of breaches of regulatory limits and accidental releases..</param>
        /// <param name="ResourceManagementRating">The Resource Management subcategory covers how efficiently resources are used in manufacturing and delivering products and services. It includes a company&#39;s capacity to reduce the use of materials, energy or water, and to find more efficient solutions by improving its supply chain management. This subcategory includes environmental performance relative to production size..</param>
        /// <param name="BoardRating">The Board subcategory covers a company&#39;s effectiveness in following best practices in corporate governance principles related to board membership. It includes how the company provides competitive and proportionate management compensation and its ability to incent executives and board members to achieve both financial and extra-financial targets..</param>
        /// <param name="LeadershipEthicsRating">The Leadership Ethics subcategory measures how a company manages its relationships with its various stakeholders, including investors, customers, communities, and regulators. It measures a company&#39;s commitment and effectiveness toward the vision of integrating social and environmental aspects into the overall core strategy. It also measures whether sustainability principles are integrated from the top down into the day-to-day operations of the company..</param>
        /// <param name="TransparencyReportingRating">The Transparency and Reporting subcategory rates factors including are corporate policies and practices aligned with sustainability goals. It also covers whether the company is a signatory of Global Compact and other leading global entities. It evaluates the assurance (3rd party audit) of the accuracy, completeness, and reliability of its Sustainability or Corporate Social Responsibility reports..</param>
        /// <param name="CountryPercentileRank">The percentile rank of the company&#39;s ESG rating in comparison to it&#39;s country peers..</param>
        /// <param name="IndustryPercentileRank">The percentile rank of the company&#39;s ESG rating in comparison to it&#39;s industry peers..</param>
        /// <param name="OverallPercentileRank">The percentile rank of the company&#39;s overall ESG rating in comparison to all companies within the CSRHub ESG universe..</param>
        /// <param name="CommunityPercentileRank">The percentile rank of the company&#39;s Community rating in comparison to all companies within the CSRHub ESG universe..</param>
        /// <param name="EmployeePercentileRank">The percentile rank of the company&#39;s Employee rating in comparison to all companies within the CSRHub ESG universe..</param>
        /// <param name="EnvironmentPercentileRank">The percentile rank of the company&#39;s Environment rating in comparison to all companies within the CSRHub ESG universe..</param>
        /// <param name="GovernancePercentileRank">The percentile rank of the company&#39;s Governance rating in comparison to all companies within the CSRHub ESG universe..</param>
        /// <param name="HumanRightsAndSupplyChainPercentileRank">The percentile rank of the company&#39;s Human Rights and Supply Chain rating in comparison to all companies within the CSRHub ESG universe..</param>
        /// <param name="CommunityDevAndPhilanthropyPercentileRank">The percentile rank of the company&#39;s Community, Dev, and Philanthropy rating in comparison to all companies within the CSRHub ESG universe..</param>
        /// <param name="ProductPercentileRank">The percentile rank of the company&#39;s Product rating in comparison to all companies within the CSRHub ESG universe..</param>
        /// <param name="CompensationAndBenefitsPercentileRank">The percentile rank of the company&#39;s Compensation and Benefits rating in comparison to all companies within the CSRHub ESG universe..</param>
        /// <param name="DiversityAndLaborRightsPercentileRank">The percentile rank of the company&#39;s Diversity and Labor Rights rating in comparison to all companies within the CSRHub ESG universe..</param>
        /// <param name="TrainingHealthAndSafetyPercentileRank">The percentile rank of the company&#39;s Training, Health, and Safety rating in comparison to all companies within the CSRHub ESG universe..</param>
        /// <param name="EnergyClimateChangePercentileRank">The percentile rank of the company&#39;s Energy Climate Change rating in comparison to all companies within the CSRHub ESG universe..</param>
        /// <param name="EnvironmentPolicyAndReportingPercentileRank">The percentile rank of the company&#39;s Environment Policy and Reporting rating in comparison to all companies within the CSRHub ESG universe..</param>
        /// <param name="ResourceManagementPercentileRank">The percentile rank of the company&#39;s Resource Management rating in comparison to all companies within the CSRHub ESG universe..</param>
        /// <param name="BoardPercentileRank">The percentile rank of the company&#39;s Board rating in comparison to all companies within the CSRHub ESG universe..</param>
        /// <param name="LeadershipEthicsPercentileRank">The percentile rank of the company&#39;s Leadership Ethics rating in comparison to all companies within the CSRHub ESG universe..</param>
        /// <param name="TransparencyReportingPercentileRank">The percentile rank of the company&#39;s Transaperency Reporting rating in comparison to all companies within the CSRHub ESG universe..</param>
        public ESGComprehensiveRating(DateTime? Date = default(DateTime?), decimal? CountryAverageRating = default(decimal?), decimal? IndustryAverageRating = default(decimal?), decimal? OverallRating = default(decimal?), decimal? CommunityRating = default(decimal?), decimal? EmployeeRating = default(decimal?), decimal? EnvironmentRating = default(decimal?), decimal? GovernanceRating = default(decimal?), decimal? HumanRightsAndSupplyChainRating = default(decimal?), decimal? CommunityDevAndPhilanthropyRating = default(decimal?), decimal? ProductRating = default(decimal?), decimal? CompensationAndBenefitsRating = default(decimal?), decimal? DiversityAndLaborRightsRating = default(decimal?), decimal? TrainingHealthAndSafetyRating = default(decimal?), decimal? EnergyClimateChangeRating = default(decimal?), decimal? EnvironmentPolicyAndReportingRating = default(decimal?), decimal? ResourceManagementRating = default(decimal?), decimal? BoardRating = default(decimal?), decimal? LeadershipEthicsRating = default(decimal?), decimal? TransparencyReportingRating = default(decimal?), decimal? CountryPercentileRank = default(decimal?), decimal? IndustryPercentileRank = default(decimal?), decimal? OverallPercentileRank = default(decimal?), decimal? CommunityPercentileRank = default(decimal?), decimal? EmployeePercentileRank = default(decimal?), decimal? EnvironmentPercentileRank = default(decimal?), decimal? GovernancePercentileRank = default(decimal?), decimal? HumanRightsAndSupplyChainPercentileRank = default(decimal?), decimal? CommunityDevAndPhilanthropyPercentileRank = default(decimal?), decimal? ProductPercentileRank = default(decimal?), decimal? CompensationAndBenefitsPercentileRank = default(decimal?), decimal? DiversityAndLaborRightsPercentileRank = default(decimal?), decimal? TrainingHealthAndSafetyPercentileRank = default(decimal?), decimal? EnergyClimateChangePercentileRank = default(decimal?), decimal? EnvironmentPolicyAndReportingPercentileRank = default(decimal?), decimal? ResourceManagementPercentileRank = default(decimal?), decimal? BoardPercentileRank = default(decimal?), decimal? LeadershipEthicsPercentileRank = default(decimal?), decimal? TransparencyReportingPercentileRank = default(decimal?))
        {
            this.Date = Date;
            this.CountryAverageRating = CountryAverageRating;
            this.IndustryAverageRating = IndustryAverageRating;
            this.OverallRating = OverallRating;
            this.CommunityRating = CommunityRating;
            this.EmployeeRating = EmployeeRating;
            this.EnvironmentRating = EnvironmentRating;
            this.GovernanceRating = GovernanceRating;
            this.HumanRightsAndSupplyChainRating = HumanRightsAndSupplyChainRating;
            this.CommunityDevAndPhilanthropyRating = CommunityDevAndPhilanthropyRating;
            this.ProductRating = ProductRating;
            this.CompensationAndBenefitsRating = CompensationAndBenefitsRating;
            this.DiversityAndLaborRightsRating = DiversityAndLaborRightsRating;
            this.TrainingHealthAndSafetyRating = TrainingHealthAndSafetyRating;
            this.EnergyClimateChangeRating = EnergyClimateChangeRating;
            this.EnvironmentPolicyAndReportingRating = EnvironmentPolicyAndReportingRating;
            this.ResourceManagementRating = ResourceManagementRating;
            this.BoardRating = BoardRating;
            this.LeadershipEthicsRating = LeadershipEthicsRating;
            this.TransparencyReportingRating = TransparencyReportingRating;
            this.CountryPercentileRank = CountryPercentileRank;
            this.IndustryPercentileRank = IndustryPercentileRank;
            this.OverallPercentileRank = OverallPercentileRank;
            this.CommunityPercentileRank = CommunityPercentileRank;
            this.EmployeePercentileRank = EmployeePercentileRank;
            this.EnvironmentPercentileRank = EnvironmentPercentileRank;
            this.GovernancePercentileRank = GovernancePercentileRank;
            this.HumanRightsAndSupplyChainPercentileRank = HumanRightsAndSupplyChainPercentileRank;
            this.CommunityDevAndPhilanthropyPercentileRank = CommunityDevAndPhilanthropyPercentileRank;
            this.ProductPercentileRank = ProductPercentileRank;
            this.CompensationAndBenefitsPercentileRank = CompensationAndBenefitsPercentileRank;
            this.DiversityAndLaborRightsPercentileRank = DiversityAndLaborRightsPercentileRank;
            this.TrainingHealthAndSafetyPercentileRank = TrainingHealthAndSafetyPercentileRank;
            this.EnergyClimateChangePercentileRank = EnergyClimateChangePercentileRank;
            this.EnvironmentPolicyAndReportingPercentileRank = EnvironmentPolicyAndReportingPercentileRank;
            this.ResourceManagementPercentileRank = ResourceManagementPercentileRank;
            this.BoardPercentileRank = BoardPercentileRank;
            this.LeadershipEthicsPercentileRank = LeadershipEthicsPercentileRank;
            this.TransparencyReportingPercentileRank = TransparencyReportingPercentileRank;
        }
        
        /// <summary>
        /// Indicates the date on which the ESG Rating was calculated.
        /// </summary>
        /// <value>Indicates the date on which the ESG Rating was calculated.</value>
        [DataMember(Name="date", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? Date { get; set; }

        /// <summary>
        /// The average ESG rating of all companies in a particular country in which the company is a peer of.
        /// </summary>
        /// <value>The average ESG rating of all companies in a particular country in which the company is a peer of.</value>
        [DataMember(Name="country_average_rating", EmitDefaultValue=false)]
        public decimal? CountryAverageRating { get; set; }

        /// <summary>
        /// The average ESG rating of all companies in a particular industry in which the company is a peer of.
        /// </summary>
        /// <value>The average ESG rating of all companies in a particular industry in which the company is a peer of.</value>
        [DataMember(Name="industry_average_rating", EmitDefaultValue=false)]
        public decimal? IndustryAverageRating { get; set; }

        /// <summary>
        /// The company&#39;s overall aggregated ESG rating, taking into account its ESG scoring from the Community, Employee, Enviroment, and Governance categories.
        /// </summary>
        /// <value>The company&#39;s overall aggregated ESG rating, taking into account its ESG scoring from the Community, Employee, Enviroment, and Governance categories.</value>
        [DataMember(Name="overall_rating", EmitDefaultValue=false)]
        public decimal? OverallRating { get; set; }

        /// <summary>
        /// The Community Category reflects a companys citizenship, charitable giving, and volunteerism. This category covers the company&#39;s human rights record and treatment of its supply chain. It also covers the environmental and social impacts of the companys products and services, and the development of sustainable products, processes and technologies.
        /// </summary>
        /// <value>The Community Category reflects a companys citizenship, charitable giving, and volunteerism. This category covers the company&#39;s human rights record and treatment of its supply chain. It also covers the environmental and social impacts of the companys products and services, and the development of sustainable products, processes and technologies.</value>
        [DataMember(Name="community_rating", EmitDefaultValue=false)]
        public decimal? CommunityRating { get; set; }

        /// <summary>
        /// The Employees category includes disclosure of policies, programs, and performance in diversity, labor relations and labor rights. The evaluation focuses on the quality of policies and programs, compliance with national laws and regulations, and proactive management initiatives. The category includes evaluation of inclusive diversity policies, fair treatment of all employees, robust diversity (EEO-1) programs and training.
        /// </summary>
        /// <value>The Employees category includes disclosure of policies, programs, and performance in diversity, labor relations and labor rights. The evaluation focuses on the quality of policies and programs, compliance with national laws and regulations, and proactive management initiatives. The category includes evaluation of inclusive diversity policies, fair treatment of all employees, robust diversity (EEO-1) programs and training.</value>
        [DataMember(Name="employee_rating", EmitDefaultValue=false)]
        public decimal? EmployeeRating { get; set; }

        /// <summary>
        /// The Environment category data covers a company&#39;s interactions with the environment at large, including use of natural resources. The category evaluates corporate environmental performance, compliance with environmental regulations, and mitigation of environmental footprint. It also includes leadership in addressing climate change through appropriate policies and strategies.
        /// </summary>
        /// <value>The Environment category data covers a company&#39;s interactions with the environment at large, including use of natural resources. The category evaluates corporate environmental performance, compliance with environmental regulations, and mitigation of environmental footprint. It also includes leadership in addressing climate change through appropriate policies and strategies.</value>
        [DataMember(Name="environment_rating", EmitDefaultValue=false)]
        public decimal? EnvironmentRating { get; set; }

        /// <summary>
        /// Corporate governance refers to leadership structure and the values that determine corporate direction, ethics and performance. The Governance category covers disclosure of policies and procedures, board independence and diversity, executive compensation, attention to stakeholder concerns, and evaluation of a company&#39;s culture of ethical leadership and compliance.
        /// </summary>
        /// <value>Corporate governance refers to leadership structure and the values that determine corporate direction, ethics and performance. The Governance category covers disclosure of policies and procedures, board independence and diversity, executive compensation, attention to stakeholder concerns, and evaluation of a company&#39;s culture of ethical leadership and compliance.</value>
        [DataMember(Name="governance_rating", EmitDefaultValue=false)]
        public decimal? GovernanceRating { get; set; }

        /// <summary>
        /// The Human Rights and Supply Chain subcategory measures a company&#39;s commitment to respecting fundamental human rights conventions. This subcategory covers a company&#39;s transparency in overseas sourcing disclosure and monitoring. The subcategory also covers the relationship with and respect for the human rights of indigenous peoples near its proposed or current operations.
        /// </summary>
        /// <value>The Human Rights and Supply Chain subcategory measures a company&#39;s commitment to respecting fundamental human rights conventions. This subcategory covers a company&#39;s transparency in overseas sourcing disclosure and monitoring. The subcategory also covers the relationship with and respect for the human rights of indigenous peoples near its proposed or current operations.</value>
        [DataMember(Name="human_rights_and_supply_chain_rating", EmitDefaultValue=false)]
        public decimal? HumanRightsAndSupplyChainRating { get; set; }

        /// <summary>
        /// The Community Development and Philanthropy subcategory covers the relationship between a company and the communities within which it is embedded. It reflects a company&#39;s community citizenship through charitable giving, donations of goods, and volunteerism of staff time. It also includes protecting public health (e.g., avoidance of industrial accidents) and managing the social impacts of its operations.
        /// </summary>
        /// <value>The Community Development and Philanthropy subcategory covers the relationship between a company and the communities within which it is embedded. It reflects a company&#39;s community citizenship through charitable giving, donations of goods, and volunteerism of staff time. It also includes protecting public health (e.g., avoidance of industrial accidents) and managing the social impacts of its operations.</value>
        [DataMember(Name="community_dev_and_philanthropy_rating", EmitDefaultValue=false)]
        public decimal? CommunityDevAndPhilanthropyRating { get; set; }

        /// <summary>
        /// The Product subcategory covers the responsibility of a company for the development, design, and management of its products and services. This subcategory reflects a company&#39;s capacity to reduce environmental costs, create new market opportunities, and produce or market goods and services that enhance the health and quality of life for consumers.
        /// </summary>
        /// <value>The Product subcategory covers the responsibility of a company for the development, design, and management of its products and services. This subcategory reflects a company&#39;s capacity to reduce environmental costs, create new market opportunities, and produce or market goods and services that enhance the health and quality of life for consumers.</value>
        [DataMember(Name="product_rating", EmitDefaultValue=false)]
        public decimal? ProductRating { get; set; }

        /// <summary>
        /// The Compensation and Benefits subcategory covers a company&#39;s capacity to increase its workforce loyalty and productivity. It includes benefits that engage employees and improve worker development. This subcategory also focuses on long-term employment growth and stability by promotion practices, lay-off practices, and relations with retired employees.
        /// </summary>
        /// <value>The Compensation and Benefits subcategory covers a company&#39;s capacity to increase its workforce loyalty and productivity. It includes benefits that engage employees and improve worker development. This subcategory also focuses on long-term employment growth and stability by promotion practices, lay-off practices, and relations with retired employees.</value>
        [DataMember(Name="compensation_and_benefits_rating", EmitDefaultValue=false)]
        public decimal? CompensationAndBenefitsRating { get; set; }

        /// <summary>
        /// The Diversity and Labor Rights subcategory covers workplace policies and practices covering fair and non-discriminatory treatment of employees. It covers a company&#39;s labor-management relations and participation by employees. Fundamental labor rights include freedom of association and protection of the right to organize.
        /// </summary>
        /// <value>The Diversity and Labor Rights subcategory covers workplace policies and practices covering fair and non-discriminatory treatment of employees. It covers a company&#39;s labor-management relations and participation by employees. Fundamental labor rights include freedom of association and protection of the right to organize.</value>
        [DataMember(Name="diversity_and_labor_rights_rating", EmitDefaultValue=false)]
        public decimal? DiversityAndLaborRightsRating { get; set; }

        /// <summary>
        /// The Training, Safety and Health subcategory measures a company&#39;s effectiveness in providing a healthy and safe workplace. It includes programs to support the health, well-being and productivity of all employees. This subcategory includes workplace policies and programs that boost employee morale, workplace productivity and worker development.
        /// </summary>
        /// <value>The Training, Safety and Health subcategory measures a company&#39;s effectiveness in providing a healthy and safe workplace. It includes programs to support the health, well-being and productivity of all employees. This subcategory includes workplace policies and programs that boost employee morale, workplace productivity and worker development.</value>
        [DataMember(Name="training_health_and_safety_rating", EmitDefaultValue=false)]
        public decimal? TrainingHealthAndSafetyRating { get; set; }

        /// <summary>
        /// The Energy and Climate Change subcategory measures a company&#39;s effectiveness in addressing climate change through appropriate policies and strategies. The subcategory includes energy use, emissions to air of CO2 and other Greenhouse Gas Emissions (GHG) and other alternative environmental technologies.
        /// </summary>
        /// <value>The Energy and Climate Change subcategory measures a company&#39;s effectiveness in addressing climate change through appropriate policies and strategies. The subcategory includes energy use, emissions to air of CO2 and other Greenhouse Gas Emissions (GHG) and other alternative environmental technologies.</value>
        [DataMember(Name="energy_climate_change_rating", EmitDefaultValue=false)]
        public decimal? EnergyClimateChangeRating { get; set; }

        /// <summary>
        /// The Environmental Policy and Reporting subcategory includes a company&#39;s policies and intention to reduce the environmental impact of a company. The data includes the company&#39;s environmental reporting performance, adherence to environmental reporting standards and compliance with investor, regulatory and stakeholders&#39; requests for transparency. Compliance data consists of breaches of regulatory limits and accidental releases.
        /// </summary>
        /// <value>The Environmental Policy and Reporting subcategory includes a company&#39;s policies and intention to reduce the environmental impact of a company. The data includes the company&#39;s environmental reporting performance, adherence to environmental reporting standards and compliance with investor, regulatory and stakeholders&#39; requests for transparency. Compliance data consists of breaches of regulatory limits and accidental releases.</value>
        [DataMember(Name="environment_policy_and_reporting_rating", EmitDefaultValue=false)]
        public decimal? EnvironmentPolicyAndReportingRating { get; set; }

        /// <summary>
        /// The Resource Management subcategory covers how efficiently resources are used in manufacturing and delivering products and services. It includes a company&#39;s capacity to reduce the use of materials, energy or water, and to find more efficient solutions by improving its supply chain management. This subcategory includes environmental performance relative to production size.
        /// </summary>
        /// <value>The Resource Management subcategory covers how efficiently resources are used in manufacturing and delivering products and services. It includes a company&#39;s capacity to reduce the use of materials, energy or water, and to find more efficient solutions by improving its supply chain management. This subcategory includes environmental performance relative to production size.</value>
        [DataMember(Name="resource_management_rating", EmitDefaultValue=false)]
        public decimal? ResourceManagementRating { get; set; }

        /// <summary>
        /// The Board subcategory covers a company&#39;s effectiveness in following best practices in corporate governance principles related to board membership. It includes how the company provides competitive and proportionate management compensation and its ability to incent executives and board members to achieve both financial and extra-financial targets.
        /// </summary>
        /// <value>The Board subcategory covers a company&#39;s effectiveness in following best practices in corporate governance principles related to board membership. It includes how the company provides competitive and proportionate management compensation and its ability to incent executives and board members to achieve both financial and extra-financial targets.</value>
        [DataMember(Name="board_rating", EmitDefaultValue=false)]
        public decimal? BoardRating { get; set; }

        /// <summary>
        /// The Leadership Ethics subcategory measures how a company manages its relationships with its various stakeholders, including investors, customers, communities, and regulators. It measures a company&#39;s commitment and effectiveness toward the vision of integrating social and environmental aspects into the overall core strategy. It also measures whether sustainability principles are integrated from the top down into the day-to-day operations of the company.
        /// </summary>
        /// <value>The Leadership Ethics subcategory measures how a company manages its relationships with its various stakeholders, including investors, customers, communities, and regulators. It measures a company&#39;s commitment and effectiveness toward the vision of integrating social and environmental aspects into the overall core strategy. It also measures whether sustainability principles are integrated from the top down into the day-to-day operations of the company.</value>
        [DataMember(Name="leadership_ethics_rating", EmitDefaultValue=false)]
        public decimal? LeadershipEthicsRating { get; set; }

        /// <summary>
        /// The Transparency and Reporting subcategory rates factors including are corporate policies and practices aligned with sustainability goals. It also covers whether the company is a signatory of Global Compact and other leading global entities. It evaluates the assurance (3rd party audit) of the accuracy, completeness, and reliability of its Sustainability or Corporate Social Responsibility reports.
        /// </summary>
        /// <value>The Transparency and Reporting subcategory rates factors including are corporate policies and practices aligned with sustainability goals. It also covers whether the company is a signatory of Global Compact and other leading global entities. It evaluates the assurance (3rd party audit) of the accuracy, completeness, and reliability of its Sustainability or Corporate Social Responsibility reports.</value>
        [DataMember(Name="transparency_reporting_rating", EmitDefaultValue=false)]
        public decimal? TransparencyReportingRating { get; set; }

        /// <summary>
        /// The percentile rank of the company&#39;s ESG rating in comparison to it&#39;s country peers.
        /// </summary>
        /// <value>The percentile rank of the company&#39;s ESG rating in comparison to it&#39;s country peers.</value>
        [DataMember(Name="country_percentile_rank", EmitDefaultValue=false)]
        public decimal? CountryPercentileRank { get; set; }

        /// <summary>
        /// The percentile rank of the company&#39;s ESG rating in comparison to it&#39;s industry peers.
        /// </summary>
        /// <value>The percentile rank of the company&#39;s ESG rating in comparison to it&#39;s industry peers.</value>
        [DataMember(Name="industry_percentile_rank", EmitDefaultValue=false)]
        public decimal? IndustryPercentileRank { get; set; }

        /// <summary>
        /// The percentile rank of the company&#39;s overall ESG rating in comparison to all companies within the CSRHub ESG universe.
        /// </summary>
        /// <value>The percentile rank of the company&#39;s overall ESG rating in comparison to all companies within the CSRHub ESG universe.</value>
        [DataMember(Name="overall_percentile_rank", EmitDefaultValue=false)]
        public decimal? OverallPercentileRank { get; set; }

        /// <summary>
        /// The percentile rank of the company&#39;s Community rating in comparison to all companies within the CSRHub ESG universe.
        /// </summary>
        /// <value>The percentile rank of the company&#39;s Community rating in comparison to all companies within the CSRHub ESG universe.</value>
        [DataMember(Name="community_percentile_rank", EmitDefaultValue=false)]
        public decimal? CommunityPercentileRank { get; set; }

        /// <summary>
        /// The percentile rank of the company&#39;s Employee rating in comparison to all companies within the CSRHub ESG universe.
        /// </summary>
        /// <value>The percentile rank of the company&#39;s Employee rating in comparison to all companies within the CSRHub ESG universe.</value>
        [DataMember(Name="employee_percentile_rank", EmitDefaultValue=false)]
        public decimal? EmployeePercentileRank { get; set; }

        /// <summary>
        /// The percentile rank of the company&#39;s Environment rating in comparison to all companies within the CSRHub ESG universe.
        /// </summary>
        /// <value>The percentile rank of the company&#39;s Environment rating in comparison to all companies within the CSRHub ESG universe.</value>
        [DataMember(Name="environment_percentile_rank", EmitDefaultValue=false)]
        public decimal? EnvironmentPercentileRank { get; set; }

        /// <summary>
        /// The percentile rank of the company&#39;s Governance rating in comparison to all companies within the CSRHub ESG universe.
        /// </summary>
        /// <value>The percentile rank of the company&#39;s Governance rating in comparison to all companies within the CSRHub ESG universe.</value>
        [DataMember(Name="governance_percentile_rank", EmitDefaultValue=false)]
        public decimal? GovernancePercentileRank { get; set; }

        /// <summary>
        /// The percentile rank of the company&#39;s Human Rights and Supply Chain rating in comparison to all companies within the CSRHub ESG universe.
        /// </summary>
        /// <value>The percentile rank of the company&#39;s Human Rights and Supply Chain rating in comparison to all companies within the CSRHub ESG universe.</value>
        [DataMember(Name="human_rights_and_supply_chain_percentile_rank", EmitDefaultValue=false)]
        public decimal? HumanRightsAndSupplyChainPercentileRank { get; set; }

        /// <summary>
        /// The percentile rank of the company&#39;s Community, Dev, and Philanthropy rating in comparison to all companies within the CSRHub ESG universe.
        /// </summary>
        /// <value>The percentile rank of the company&#39;s Community, Dev, and Philanthropy rating in comparison to all companies within the CSRHub ESG universe.</value>
        [DataMember(Name="community_dev_and_philanthropy_percentile_rank", EmitDefaultValue=false)]
        public decimal? CommunityDevAndPhilanthropyPercentileRank { get; set; }

        /// <summary>
        /// The percentile rank of the company&#39;s Product rating in comparison to all companies within the CSRHub ESG universe.
        /// </summary>
        /// <value>The percentile rank of the company&#39;s Product rating in comparison to all companies within the CSRHub ESG universe.</value>
        [DataMember(Name="product_percentile_rank", EmitDefaultValue=false)]
        public decimal? ProductPercentileRank { get; set; }

        /// <summary>
        /// The percentile rank of the company&#39;s Compensation and Benefits rating in comparison to all companies within the CSRHub ESG universe.
        /// </summary>
        /// <value>The percentile rank of the company&#39;s Compensation and Benefits rating in comparison to all companies within the CSRHub ESG universe.</value>
        [DataMember(Name="compensation_and_benefits_percentile_rank", EmitDefaultValue=false)]
        public decimal? CompensationAndBenefitsPercentileRank { get; set; }

        /// <summary>
        /// The percentile rank of the company&#39;s Diversity and Labor Rights rating in comparison to all companies within the CSRHub ESG universe.
        /// </summary>
        /// <value>The percentile rank of the company&#39;s Diversity and Labor Rights rating in comparison to all companies within the CSRHub ESG universe.</value>
        [DataMember(Name="diversity_and_labor_rights_percentile_rank", EmitDefaultValue=false)]
        public decimal? DiversityAndLaborRightsPercentileRank { get; set; }

        /// <summary>
        /// The percentile rank of the company&#39;s Training, Health, and Safety rating in comparison to all companies within the CSRHub ESG universe.
        /// </summary>
        /// <value>The percentile rank of the company&#39;s Training, Health, and Safety rating in comparison to all companies within the CSRHub ESG universe.</value>
        [DataMember(Name="training_health_and_safety_percentile_rank", EmitDefaultValue=false)]
        public decimal? TrainingHealthAndSafetyPercentileRank { get; set; }

        /// <summary>
        /// The percentile rank of the company&#39;s Energy Climate Change rating in comparison to all companies within the CSRHub ESG universe.
        /// </summary>
        /// <value>The percentile rank of the company&#39;s Energy Climate Change rating in comparison to all companies within the CSRHub ESG universe.</value>
        [DataMember(Name="energy_climate_change_percentile_rank", EmitDefaultValue=false)]
        public decimal? EnergyClimateChangePercentileRank { get; set; }

        /// <summary>
        /// The percentile rank of the company&#39;s Environment Policy and Reporting rating in comparison to all companies within the CSRHub ESG universe.
        /// </summary>
        /// <value>The percentile rank of the company&#39;s Environment Policy and Reporting rating in comparison to all companies within the CSRHub ESG universe.</value>
        [DataMember(Name="environment_policy_and_reporting_percentile_rank", EmitDefaultValue=false)]
        public decimal? EnvironmentPolicyAndReportingPercentileRank { get; set; }

        /// <summary>
        /// The percentile rank of the company&#39;s Resource Management rating in comparison to all companies within the CSRHub ESG universe.
        /// </summary>
        /// <value>The percentile rank of the company&#39;s Resource Management rating in comparison to all companies within the CSRHub ESG universe.</value>
        [DataMember(Name="resource_management_percentile_rank", EmitDefaultValue=false)]
        public decimal? ResourceManagementPercentileRank { get; set; }

        /// <summary>
        /// The percentile rank of the company&#39;s Board rating in comparison to all companies within the CSRHub ESG universe.
        /// </summary>
        /// <value>The percentile rank of the company&#39;s Board rating in comparison to all companies within the CSRHub ESG universe.</value>
        [DataMember(Name="board_percentile_rank", EmitDefaultValue=false)]
        public decimal? BoardPercentileRank { get; set; }

        /// <summary>
        /// The percentile rank of the company&#39;s Leadership Ethics rating in comparison to all companies within the CSRHub ESG universe.
        /// </summary>
        /// <value>The percentile rank of the company&#39;s Leadership Ethics rating in comparison to all companies within the CSRHub ESG universe.</value>
        [DataMember(Name="leadership_ethics_percentile_rank", EmitDefaultValue=false)]
        public decimal? LeadershipEthicsPercentileRank { get; set; }

        /// <summary>
        /// The percentile rank of the company&#39;s Transaperency Reporting rating in comparison to all companies within the CSRHub ESG universe.
        /// </summary>
        /// <value>The percentile rank of the company&#39;s Transaperency Reporting rating in comparison to all companies within the CSRHub ESG universe.</value>
        [DataMember(Name="transparency_reporting_percentile_rank", EmitDefaultValue=false)]
        public decimal? TransparencyReportingPercentileRank { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ESGComprehensiveRating {\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  CountryAverageRating: ").Append(CountryAverageRating).Append("\n");
            sb.Append("  IndustryAverageRating: ").Append(IndustryAverageRating).Append("\n");
            sb.Append("  OverallRating: ").Append(OverallRating).Append("\n");
            sb.Append("  CommunityRating: ").Append(CommunityRating).Append("\n");
            sb.Append("  EmployeeRating: ").Append(EmployeeRating).Append("\n");
            sb.Append("  EnvironmentRating: ").Append(EnvironmentRating).Append("\n");
            sb.Append("  GovernanceRating: ").Append(GovernanceRating).Append("\n");
            sb.Append("  HumanRightsAndSupplyChainRating: ").Append(HumanRightsAndSupplyChainRating).Append("\n");
            sb.Append("  CommunityDevAndPhilanthropyRating: ").Append(CommunityDevAndPhilanthropyRating).Append("\n");
            sb.Append("  ProductRating: ").Append(ProductRating).Append("\n");
            sb.Append("  CompensationAndBenefitsRating: ").Append(CompensationAndBenefitsRating).Append("\n");
            sb.Append("  DiversityAndLaborRightsRating: ").Append(DiversityAndLaborRightsRating).Append("\n");
            sb.Append("  TrainingHealthAndSafetyRating: ").Append(TrainingHealthAndSafetyRating).Append("\n");
            sb.Append("  EnergyClimateChangeRating: ").Append(EnergyClimateChangeRating).Append("\n");
            sb.Append("  EnvironmentPolicyAndReportingRating: ").Append(EnvironmentPolicyAndReportingRating).Append("\n");
            sb.Append("  ResourceManagementRating: ").Append(ResourceManagementRating).Append("\n");
            sb.Append("  BoardRating: ").Append(BoardRating).Append("\n");
            sb.Append("  LeadershipEthicsRating: ").Append(LeadershipEthicsRating).Append("\n");
            sb.Append("  TransparencyReportingRating: ").Append(TransparencyReportingRating).Append("\n");
            sb.Append("  CountryPercentileRank: ").Append(CountryPercentileRank).Append("\n");
            sb.Append("  IndustryPercentileRank: ").Append(IndustryPercentileRank).Append("\n");
            sb.Append("  OverallPercentileRank: ").Append(OverallPercentileRank).Append("\n");
            sb.Append("  CommunityPercentileRank: ").Append(CommunityPercentileRank).Append("\n");
            sb.Append("  EmployeePercentileRank: ").Append(EmployeePercentileRank).Append("\n");
            sb.Append("  EnvironmentPercentileRank: ").Append(EnvironmentPercentileRank).Append("\n");
            sb.Append("  GovernancePercentileRank: ").Append(GovernancePercentileRank).Append("\n");
            sb.Append("  HumanRightsAndSupplyChainPercentileRank: ").Append(HumanRightsAndSupplyChainPercentileRank).Append("\n");
            sb.Append("  CommunityDevAndPhilanthropyPercentileRank: ").Append(CommunityDevAndPhilanthropyPercentileRank).Append("\n");
            sb.Append("  ProductPercentileRank: ").Append(ProductPercentileRank).Append("\n");
            sb.Append("  CompensationAndBenefitsPercentileRank: ").Append(CompensationAndBenefitsPercentileRank).Append("\n");
            sb.Append("  DiversityAndLaborRightsPercentileRank: ").Append(DiversityAndLaborRightsPercentileRank).Append("\n");
            sb.Append("  TrainingHealthAndSafetyPercentileRank: ").Append(TrainingHealthAndSafetyPercentileRank).Append("\n");
            sb.Append("  EnergyClimateChangePercentileRank: ").Append(EnergyClimateChangePercentileRank).Append("\n");
            sb.Append("  EnvironmentPolicyAndReportingPercentileRank: ").Append(EnvironmentPolicyAndReportingPercentileRank).Append("\n");
            sb.Append("  ResourceManagementPercentileRank: ").Append(ResourceManagementPercentileRank).Append("\n");
            sb.Append("  BoardPercentileRank: ").Append(BoardPercentileRank).Append("\n");
            sb.Append("  LeadershipEthicsPercentileRank: ").Append(LeadershipEthicsPercentileRank).Append("\n");
            sb.Append("  TransparencyReportingPercentileRank: ").Append(TransparencyReportingPercentileRank).Append("\n");
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
            return this.Equals(input as ESGComprehensiveRating);
        }

        /// <summary>
        /// Returns true if ESGComprehensiveRating instances are equal
        /// </summary>
        /// <param name="input">Instance of ESGComprehensiveRating to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ESGComprehensiveRating input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.CountryAverageRating == input.CountryAverageRating ||
                    (this.CountryAverageRating != null &&
                    this.CountryAverageRating.Equals(input.CountryAverageRating))
                ) && 
                (
                    this.IndustryAverageRating == input.IndustryAverageRating ||
                    (this.IndustryAverageRating != null &&
                    this.IndustryAverageRating.Equals(input.IndustryAverageRating))
                ) && 
                (
                    this.OverallRating == input.OverallRating ||
                    (this.OverallRating != null &&
                    this.OverallRating.Equals(input.OverallRating))
                ) && 
                (
                    this.CommunityRating == input.CommunityRating ||
                    (this.CommunityRating != null &&
                    this.CommunityRating.Equals(input.CommunityRating))
                ) && 
                (
                    this.EmployeeRating == input.EmployeeRating ||
                    (this.EmployeeRating != null &&
                    this.EmployeeRating.Equals(input.EmployeeRating))
                ) && 
                (
                    this.EnvironmentRating == input.EnvironmentRating ||
                    (this.EnvironmentRating != null &&
                    this.EnvironmentRating.Equals(input.EnvironmentRating))
                ) && 
                (
                    this.GovernanceRating == input.GovernanceRating ||
                    (this.GovernanceRating != null &&
                    this.GovernanceRating.Equals(input.GovernanceRating))
                ) && 
                (
                    this.HumanRightsAndSupplyChainRating == input.HumanRightsAndSupplyChainRating ||
                    (this.HumanRightsAndSupplyChainRating != null &&
                    this.HumanRightsAndSupplyChainRating.Equals(input.HumanRightsAndSupplyChainRating))
                ) && 
                (
                    this.CommunityDevAndPhilanthropyRating == input.CommunityDevAndPhilanthropyRating ||
                    (this.CommunityDevAndPhilanthropyRating != null &&
                    this.CommunityDevAndPhilanthropyRating.Equals(input.CommunityDevAndPhilanthropyRating))
                ) && 
                (
                    this.ProductRating == input.ProductRating ||
                    (this.ProductRating != null &&
                    this.ProductRating.Equals(input.ProductRating))
                ) && 
                (
                    this.CompensationAndBenefitsRating == input.CompensationAndBenefitsRating ||
                    (this.CompensationAndBenefitsRating != null &&
                    this.CompensationAndBenefitsRating.Equals(input.CompensationAndBenefitsRating))
                ) && 
                (
                    this.DiversityAndLaborRightsRating == input.DiversityAndLaborRightsRating ||
                    (this.DiversityAndLaborRightsRating != null &&
                    this.DiversityAndLaborRightsRating.Equals(input.DiversityAndLaborRightsRating))
                ) && 
                (
                    this.TrainingHealthAndSafetyRating == input.TrainingHealthAndSafetyRating ||
                    (this.TrainingHealthAndSafetyRating != null &&
                    this.TrainingHealthAndSafetyRating.Equals(input.TrainingHealthAndSafetyRating))
                ) && 
                (
                    this.EnergyClimateChangeRating == input.EnergyClimateChangeRating ||
                    (this.EnergyClimateChangeRating != null &&
                    this.EnergyClimateChangeRating.Equals(input.EnergyClimateChangeRating))
                ) && 
                (
                    this.EnvironmentPolicyAndReportingRating == input.EnvironmentPolicyAndReportingRating ||
                    (this.EnvironmentPolicyAndReportingRating != null &&
                    this.EnvironmentPolicyAndReportingRating.Equals(input.EnvironmentPolicyAndReportingRating))
                ) && 
                (
                    this.ResourceManagementRating == input.ResourceManagementRating ||
                    (this.ResourceManagementRating != null &&
                    this.ResourceManagementRating.Equals(input.ResourceManagementRating))
                ) && 
                (
                    this.BoardRating == input.BoardRating ||
                    (this.BoardRating != null &&
                    this.BoardRating.Equals(input.BoardRating))
                ) && 
                (
                    this.LeadershipEthicsRating == input.LeadershipEthicsRating ||
                    (this.LeadershipEthicsRating != null &&
                    this.LeadershipEthicsRating.Equals(input.LeadershipEthicsRating))
                ) && 
                (
                    this.TransparencyReportingRating == input.TransparencyReportingRating ||
                    (this.TransparencyReportingRating != null &&
                    this.TransparencyReportingRating.Equals(input.TransparencyReportingRating))
                ) && 
                (
                    this.CountryPercentileRank == input.CountryPercentileRank ||
                    (this.CountryPercentileRank != null &&
                    this.CountryPercentileRank.Equals(input.CountryPercentileRank))
                ) && 
                (
                    this.IndustryPercentileRank == input.IndustryPercentileRank ||
                    (this.IndustryPercentileRank != null &&
                    this.IndustryPercentileRank.Equals(input.IndustryPercentileRank))
                ) && 
                (
                    this.OverallPercentileRank == input.OverallPercentileRank ||
                    (this.OverallPercentileRank != null &&
                    this.OverallPercentileRank.Equals(input.OverallPercentileRank))
                ) && 
                (
                    this.CommunityPercentileRank == input.CommunityPercentileRank ||
                    (this.CommunityPercentileRank != null &&
                    this.CommunityPercentileRank.Equals(input.CommunityPercentileRank))
                ) && 
                (
                    this.EmployeePercentileRank == input.EmployeePercentileRank ||
                    (this.EmployeePercentileRank != null &&
                    this.EmployeePercentileRank.Equals(input.EmployeePercentileRank))
                ) && 
                (
                    this.EnvironmentPercentileRank == input.EnvironmentPercentileRank ||
                    (this.EnvironmentPercentileRank != null &&
                    this.EnvironmentPercentileRank.Equals(input.EnvironmentPercentileRank))
                ) && 
                (
                    this.GovernancePercentileRank == input.GovernancePercentileRank ||
                    (this.GovernancePercentileRank != null &&
                    this.GovernancePercentileRank.Equals(input.GovernancePercentileRank))
                ) && 
                (
                    this.HumanRightsAndSupplyChainPercentileRank == input.HumanRightsAndSupplyChainPercentileRank ||
                    (this.HumanRightsAndSupplyChainPercentileRank != null &&
                    this.HumanRightsAndSupplyChainPercentileRank.Equals(input.HumanRightsAndSupplyChainPercentileRank))
                ) && 
                (
                    this.CommunityDevAndPhilanthropyPercentileRank == input.CommunityDevAndPhilanthropyPercentileRank ||
                    (this.CommunityDevAndPhilanthropyPercentileRank != null &&
                    this.CommunityDevAndPhilanthropyPercentileRank.Equals(input.CommunityDevAndPhilanthropyPercentileRank))
                ) && 
                (
                    this.ProductPercentileRank == input.ProductPercentileRank ||
                    (this.ProductPercentileRank != null &&
                    this.ProductPercentileRank.Equals(input.ProductPercentileRank))
                ) && 
                (
                    this.CompensationAndBenefitsPercentileRank == input.CompensationAndBenefitsPercentileRank ||
                    (this.CompensationAndBenefitsPercentileRank != null &&
                    this.CompensationAndBenefitsPercentileRank.Equals(input.CompensationAndBenefitsPercentileRank))
                ) && 
                (
                    this.DiversityAndLaborRightsPercentileRank == input.DiversityAndLaborRightsPercentileRank ||
                    (this.DiversityAndLaborRightsPercentileRank != null &&
                    this.DiversityAndLaborRightsPercentileRank.Equals(input.DiversityAndLaborRightsPercentileRank))
                ) && 
                (
                    this.TrainingHealthAndSafetyPercentileRank == input.TrainingHealthAndSafetyPercentileRank ||
                    (this.TrainingHealthAndSafetyPercentileRank != null &&
                    this.TrainingHealthAndSafetyPercentileRank.Equals(input.TrainingHealthAndSafetyPercentileRank))
                ) && 
                (
                    this.EnergyClimateChangePercentileRank == input.EnergyClimateChangePercentileRank ||
                    (this.EnergyClimateChangePercentileRank != null &&
                    this.EnergyClimateChangePercentileRank.Equals(input.EnergyClimateChangePercentileRank))
                ) && 
                (
                    this.EnvironmentPolicyAndReportingPercentileRank == input.EnvironmentPolicyAndReportingPercentileRank ||
                    (this.EnvironmentPolicyAndReportingPercentileRank != null &&
                    this.EnvironmentPolicyAndReportingPercentileRank.Equals(input.EnvironmentPolicyAndReportingPercentileRank))
                ) && 
                (
                    this.ResourceManagementPercentileRank == input.ResourceManagementPercentileRank ||
                    (this.ResourceManagementPercentileRank != null &&
                    this.ResourceManagementPercentileRank.Equals(input.ResourceManagementPercentileRank))
                ) && 
                (
                    this.BoardPercentileRank == input.BoardPercentileRank ||
                    (this.BoardPercentileRank != null &&
                    this.BoardPercentileRank.Equals(input.BoardPercentileRank))
                ) && 
                (
                    this.LeadershipEthicsPercentileRank == input.LeadershipEthicsPercentileRank ||
                    (this.LeadershipEthicsPercentileRank != null &&
                    this.LeadershipEthicsPercentileRank.Equals(input.LeadershipEthicsPercentileRank))
                ) && 
                (
                    this.TransparencyReportingPercentileRank == input.TransparencyReportingPercentileRank ||
                    (this.TransparencyReportingPercentileRank != null &&
                    this.TransparencyReportingPercentileRank.Equals(input.TransparencyReportingPercentileRank))
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
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.CountryAverageRating != null)
                    hashCode = hashCode * 59 + this.CountryAverageRating.GetHashCode();
                if (this.IndustryAverageRating != null)
                    hashCode = hashCode * 59 + this.IndustryAverageRating.GetHashCode();
                if (this.OverallRating != null)
                    hashCode = hashCode * 59 + this.OverallRating.GetHashCode();
                if (this.CommunityRating != null)
                    hashCode = hashCode * 59 + this.CommunityRating.GetHashCode();
                if (this.EmployeeRating != null)
                    hashCode = hashCode * 59 + this.EmployeeRating.GetHashCode();
                if (this.EnvironmentRating != null)
                    hashCode = hashCode * 59 + this.EnvironmentRating.GetHashCode();
                if (this.GovernanceRating != null)
                    hashCode = hashCode * 59 + this.GovernanceRating.GetHashCode();
                if (this.HumanRightsAndSupplyChainRating != null)
                    hashCode = hashCode * 59 + this.HumanRightsAndSupplyChainRating.GetHashCode();
                if (this.CommunityDevAndPhilanthropyRating != null)
                    hashCode = hashCode * 59 + this.CommunityDevAndPhilanthropyRating.GetHashCode();
                if (this.ProductRating != null)
                    hashCode = hashCode * 59 + this.ProductRating.GetHashCode();
                if (this.CompensationAndBenefitsRating != null)
                    hashCode = hashCode * 59 + this.CompensationAndBenefitsRating.GetHashCode();
                if (this.DiversityAndLaborRightsRating != null)
                    hashCode = hashCode * 59 + this.DiversityAndLaborRightsRating.GetHashCode();
                if (this.TrainingHealthAndSafetyRating != null)
                    hashCode = hashCode * 59 + this.TrainingHealthAndSafetyRating.GetHashCode();
                if (this.EnergyClimateChangeRating != null)
                    hashCode = hashCode * 59 + this.EnergyClimateChangeRating.GetHashCode();
                if (this.EnvironmentPolicyAndReportingRating != null)
                    hashCode = hashCode * 59 + this.EnvironmentPolicyAndReportingRating.GetHashCode();
                if (this.ResourceManagementRating != null)
                    hashCode = hashCode * 59 + this.ResourceManagementRating.GetHashCode();
                if (this.BoardRating != null)
                    hashCode = hashCode * 59 + this.BoardRating.GetHashCode();
                if (this.LeadershipEthicsRating != null)
                    hashCode = hashCode * 59 + this.LeadershipEthicsRating.GetHashCode();
                if (this.TransparencyReportingRating != null)
                    hashCode = hashCode * 59 + this.TransparencyReportingRating.GetHashCode();
                if (this.CountryPercentileRank != null)
                    hashCode = hashCode * 59 + this.CountryPercentileRank.GetHashCode();
                if (this.IndustryPercentileRank != null)
                    hashCode = hashCode * 59 + this.IndustryPercentileRank.GetHashCode();
                if (this.OverallPercentileRank != null)
                    hashCode = hashCode * 59 + this.OverallPercentileRank.GetHashCode();
                if (this.CommunityPercentileRank != null)
                    hashCode = hashCode * 59 + this.CommunityPercentileRank.GetHashCode();
                if (this.EmployeePercentileRank != null)
                    hashCode = hashCode * 59 + this.EmployeePercentileRank.GetHashCode();
                if (this.EnvironmentPercentileRank != null)
                    hashCode = hashCode * 59 + this.EnvironmentPercentileRank.GetHashCode();
                if (this.GovernancePercentileRank != null)
                    hashCode = hashCode * 59 + this.GovernancePercentileRank.GetHashCode();
                if (this.HumanRightsAndSupplyChainPercentileRank != null)
                    hashCode = hashCode * 59 + this.HumanRightsAndSupplyChainPercentileRank.GetHashCode();
                if (this.CommunityDevAndPhilanthropyPercentileRank != null)
                    hashCode = hashCode * 59 + this.CommunityDevAndPhilanthropyPercentileRank.GetHashCode();
                if (this.ProductPercentileRank != null)
                    hashCode = hashCode * 59 + this.ProductPercentileRank.GetHashCode();
                if (this.CompensationAndBenefitsPercentileRank != null)
                    hashCode = hashCode * 59 + this.CompensationAndBenefitsPercentileRank.GetHashCode();
                if (this.DiversityAndLaborRightsPercentileRank != null)
                    hashCode = hashCode * 59 + this.DiversityAndLaborRightsPercentileRank.GetHashCode();
                if (this.TrainingHealthAndSafetyPercentileRank != null)
                    hashCode = hashCode * 59 + this.TrainingHealthAndSafetyPercentileRank.GetHashCode();
                if (this.EnergyClimateChangePercentileRank != null)
                    hashCode = hashCode * 59 + this.EnergyClimateChangePercentileRank.GetHashCode();
                if (this.EnvironmentPolicyAndReportingPercentileRank != null)
                    hashCode = hashCode * 59 + this.EnvironmentPolicyAndReportingPercentileRank.GetHashCode();
                if (this.ResourceManagementPercentileRank != null)
                    hashCode = hashCode * 59 + this.ResourceManagementPercentileRank.GetHashCode();
                if (this.BoardPercentileRank != null)
                    hashCode = hashCode * 59 + this.BoardPercentileRank.GetHashCode();
                if (this.LeadershipEthicsPercentileRank != null)
                    hashCode = hashCode * 59 + this.LeadershipEthicsPercentileRank.GetHashCode();
                if (this.TransparencyReportingPercentileRank != null)
                    hashCode = hashCode * 59 + this.TransparencyReportingPercentileRank.GetHashCode();
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
