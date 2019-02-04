

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
    /// Financial statement data for a Municipality and a Fiscal Year
    /// </summary>
    [DataContract]
    public partial class MunicipalityFinancial :  IEquatable<MunicipalityFinancial>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MunicipalityFinancial" /> class.
        /// </summary>
        /// <param name="FiscalYear">The fiscal year from which the financial data came from.</param>
        /// <param name="CurrentAssets">Government-wide holdings that can be liquidated on short notice.</param>
        /// <param name="NonCurrentAssets">Government-wide holdings not intended for near-term liquidation.</param>
        /// <param name="DeferredOutflows">Government-wide consumptions of net position applicable to a future year.</param>
        /// <param name="TotalAssets">Government-wide holdings.</param>
        /// <param name="TotalAssetsPlusDeferredOutflows">Sum of government-wide total assets and deferred outflows of resources.</param>
        /// <param name="CurrentLiabilities">Government-wide liabilities that typically become due within one year.</param>
        /// <param name="CurrentPortionOfLongTermDebt">Government-wide portion of long term obligations, such as bond and loan debt coming due within the next year.</param>
        /// <param name="NetPensionLiability">Government-wide liability for employee pensions net of the fiduciary net position of pension plans in which the government has an interest.</param>
        /// <param name="NetOpebLiability">Government-wide liability for other postemployment benefits (OPEB). These are benefits (such as death benefits, life insurance, disability, and long-term care) that are paid in the period after employment and that are provided separately from a pension plan, as well as healthcare benefits paid in the period after employment, regardless of the manner in which they are provided. OPEB does not include termination benefits or termination payments for sick leave. Liability is reported net of any OPEB assets the government may control..</param>
        /// <param name="AllOtherLongTermDebt">Government-wide liabilities not elsewhere classified.</param>
        /// <param name="TotalLiabilities">The sum of the Municipality&#39;s all other long term debt, net open liability, net pension liability, and current portion of long term debt.</param>
        /// <param name="DeferredInflows">Government-wide acquisitions of net position applicable to a future year.</param>
        /// <param name="TotalLiabilitiesPlusDeferredInflows">Sum of government-wide liabilities and deferred inflows of resources.</param>
        /// <param name="TotalNetPosition">Government-wide assets and deferred outflows less government-wide liabilities and deferred inflows.</param>
        /// <param name="TotalUnrestrictedNetPosition">Net amount of government-wide assets, deferred outflows of resources, liabilities, and deferred inflows of resources that are not included in the determination of net investment in capital assets or the restricted components of net position.</param>
        /// <param name="TotalExpenses">Decreases in net position that occurred during the past year, government-wide.</param>
        /// <param name="ChargesForServices">Charges for services is the term used for a broad category of program revenues that arise from charges to customers, applicants, or others who purchase, use, or directly benefit from the goods, services, or privileges provided, or are otherwise directly affected by the services. Revenues in this category include fees charged for specific services, such as water use or garbage collection; licenses and permits, such as dog licenses, liquor licenses, and building permits; operating special assessments, such as for street cleaning or special street lighting; and any other amounts charged to service recipients. Fines and forfeitures are also included in this category because they result from direct charges to those who are otherwise directly affected by a program or service, even though they receive no benefit. Payments from other governments for goods or services should be reported in this category..</param>
        /// <param name="OperatingGrantsAndContributions">Program-specific grants and contributions - includes revenues arising from mandatory and voluntary nonexchange transactions with other governments, organizations, or individuals that are restricted for use in a particular program. Some grants and contributions consist of capital assets or resources that are restricted for capital purposes—to purchase, construct, or renovate capital assets associated with a specific program. These should be reported separately from grants and contributions that may be used either for operating expenses or for capital expenditures of the program at the discretion of the reporting government. These categories of program revenue are specifically attributable to a program and reduce the net expense of that program to the reporting government. For example, a state may provide an operating grant to a county sheriff&#39;s department for a drug-awareness-and-enforcement program..</param>
        /// <param name="CapitalGrantsAndContributions">Program-specific grants and contributions - includes revenues arising from mandatory and voluntary nonexchange transactions with other governments, organizations, or individuals that are restricted for use in a particular program. Some grants and contributions consist of capital assets or resources that are restricted for capital purposes—to purchase, construct, or renovate capital assets associated with a specific program. These should be reported separately from grants and contributions that may be used either for operating expenses or for capital expenditures of the program at the discretion of the reporting government. These categories of program revenue are specifically attributable to a program and reduce the net expense of that program to the reporting government. For example, a state may provide a capital grant to finance construction of a new jail..</param>
        /// <param name="GeneralRevenues">All revenues are general revenues unless they are required to be reported as program revenues. All taxes, even those that are levied for a specific purpose, are general revenues and should be reported by type of tax—for example, sales tax, property tax, franchise tax, income tax. All other nontax revenues (including interest, grants, and contributions) that do not meet the criteria to be reported as program revenues should also be reported as general revenues. General revenues should be reported after total net expense of the government&#39;s functions..</param>
        /// <param name="OtherRevenues">Government-wide revenues not elsewhere classified.</param>
        /// <param name="TotalRevenues">Increases in net position that occurred during the past year, government-wide.</param>
        /// <param name="ChangeInNetAssets">Difference between the government&#39;s net position at the end of the fiscal year and the government&#39;s net position at the beginning of the fiscal year.</param>
        /// <param name="NonSpendableGeneralFundBalance">The portion of general fund balance classified as nonspendable. The nonspendable fund balance classification includes amounts that cannot be spent because they are either (a) not in spendable form or (b) legally or contractually required to be maintained intact. The “not in spendable form” criterion includes items that are not expected to be converted to cash, for example, inventories and prepaid amounts. It also includes the long-term amount of loans and notes receivable, as well as property acquired for resale. However, if the use of the proceeds from the collection of those receivables or from the sale of those properties is restricted, committed, or assigned, then they should be included in the appropriate fund balance classification (restricted, committed, or assigned), rather than nonspendable fund balance. The corpus (or principal) of a permanent fund is an example of an amount that is legally or contractually required to be maintained intact..</param>
        /// <param name="RestrictedGeneralFundBalance">The portion of general fund balance classified as restricted. Fund balance should be reported as restricted when constraints placed on the use of resources are either (a) Externally imposed by creditors (such as through debt covenants), grantors, contributors, or laws or regulations of other governments or (b) Imposed by law through constitutional provisions or enabling legislation..</param>
        /// <param name="CommittedGeneralFundBalance">The portion of general fund balance classified as committed. Amounts that can only be used for specific purposes pursuant to constraints imposed by formal action of the government’s highest level of decision-making authority should be reported as committed fund balance. Those committed amounts cannot be used for any other purpose unless the government removes or changes the specified use by taking the same type of action (for example, legislation, resolution, ordinance) it employed to previously commit those amounts. The authorization specifying the purposes for which amounts can be used should have the consent of both the legislative and executive branches of the government, if applicable. Committed fund balance also should incorporate contractual obligations to the extent that existing resources in the fund have been specifically committed for use in satisfying those contractual requirements..</param>
        /// <param name="UnassignedGeneralFundBalance">The portion of general fund balance classified as unassigned. Unassigned fund balance is the residual classification for the general fund. This classification represents fund balance that has not been assigned to other funds and that has not been restricted, committed, or assigned to specific purposes within the general fund. The general fund should be the only fund that reports a positive unassigned fund balance amount. In other governmental funds, if expenditures incurred for specific purposes exceeded the amounts restricted, committed, or assigned to those purposes, it may be necessary to report a negative unassigned fund balance..</param>
        /// <param name="AssignedGeneralFundBalance">The portion of general fund balance classified as assigned. Amounts that are constrained by the government’s intent to be used for specific purposes, but are neither restricted nor committed, should be reported as assigned fund balance, except for stabilization arrangements.. Intent should be expressed by (a) the governing body itself or (b) a body (a budget or finance committee, for example) or official to which the governing body has delegated the authority to assign amounts to be used for specific purposes..</param>
        /// <param name="TotalGeneralFundBalance">General fund balance in all classifications. Fund balance is the difference between governmental fund assets and deferred outflows of resources, and liabilities and deferred inflows of resources. It is sometimes referred to as fund equity. The general fund is used to account for and report all financial resources not accounted for and reported in another governmental fund..</param>
        /// <param name="NonSpendableGovernmentalFundBalance">For all governmental funds, the aggregate of fund balances that are classified as nonspendable. The nonspendable fund balance classification includes amounts that cannot be spent because they are either (a) not in spendable form or (b) legally or contractually required to be maintained intact. The “not in spendable form” criterion includes items that are not expected to be converted to cash, for example, inventories and prepaid amounts. It also includes the long-term amount of loans and notes receivable, as well as property acquired for resale. However, if the use of the proceeds from the collection of those receivables or from the sale of those properties is restricted, committed, or assigned, then they should be included in the appropriate fund balance classification (restricted, committed, or assigned), rather than nonspendable fund balance..</param>
        /// <param name="RestrictedGovernmentalFundBalance">For all governmental funds, the aggregate of fund balances that are classified as restricted. Fund balance should be reported as restricted when constraints placed on the use of resources are either (a) Externally imposed by creditors (such as through debt covenants), grantors, contributors, or laws or regulations of other governments; or (b) Imposed by law through constitutional provisions or enabling legislation..</param>
        /// <param name="CommittedGovernmentalFundBalance">For all governmental funds, the aggregate of fund balances that are classified as committed. Amounts that can only be used for specific purposes pursuant to constraints imposed by formal action of the government’s highest level of decision-making authority should be reported as committed fund balance. Those committed amounts cannot be used for any other purpose unless the government removes or changes the specified use by taking the same type of action (for example, legislation, resolution, ordinance) it employed to previously commit those amounts. The authorization specifying the purposes for which amounts can be used should have the consent of both the legislative and executive branches of the government, if applicable. Committed fund balance also should incorporate contractual obligations to the extent that existing resources in the fund have been specifically committed for use in satisfying those contractual requirements..</param>
        /// <param name="UnassignedGovernmentalFundBalance">For all governmental funds, the aggregate of fund balances that are classified as unassigned. Unassigned fund balance is the residual classification for the general fund. This classification represents fund balance that has not been assigned to other funds and that has not been restricted, committed, or assigned to specific purposes within the general fund. The general fund should be the only fund that reports a positive unassigned fund balance amount. In other governmental funds, if expenditures incurred for specific purposes exceeded the amounts restricted, committed, or assigned to those purposes, it may be necessary to report a negative unassigned fund balance..</param>
        /// <param name="AssignedGovernmentalFundBalance">For all governmental funds, the aggregate of fund balances that are classified as assigned. Amounts that are constrained by the government’s intent to be used for specific purposes, but are neither restricted nor committed, should be reported as assigned fund balance, except for stabilization arrangements.. Intent should be expressed by (a) the governing body itself or (b) a body (a budget or finance committee, for example) or official to which the governing body has delegated the authority to assign amounts to be used for specific purposes..</param>
        /// <param name="TotalGovernmentalFundBalance">For all governmental funds, the aggregate of all fund balances in any classification. Fund balance is the difference between governmental fund assets and deferred outflows of resources, and liabilities and deferred inflows of resources. It is sometimes referred to as fund equity. Governmental funds are used to account for general government activities that are financed primarily through taxes, intergovernmental revenues, and other nonexchange revenues..</param>
        /// <param name="GeneralFundRevenues">Increases in financial resources attributable to the general fund. The general fund is used to account for and report all financial resources not accounted for and reported in another governmental fund..</param>
        /// <param name="GeneralFundExpenditures">Decreases in financial resources attributable to the general fund. The general fund is used to account for and report all financial resources not accounted for and reported in another governmental fund..</param>
        /// <param name="GeneralFundRevenuesOverUnderExpenditure">Difference between general fund revenues and expenditures.  If positive, this amount is called a surplus.  If negative, it represents a deficit. The general fund is used to account for and report all financial resources not accounted for and reported in another governmental fund..</param>
        /// <param name="GovernmentalFundRevenues">Increases in financial resources attributable to any governmental fund. Governmental funds are used to account for general government activities that are financed primarily through taxes, intergovernmental revenues, and other nonexchange revenues..</param>
        /// <param name="GovernmentalFundExpenditures">Decreases in financial resources attributable to any governmental fund. Governmental funds are used to account for general government activities that are financed primarily through taxes, intergovernmental revenues, and other nonexchange revenues..</param>
        /// <param name="GovernmentalFundRevenuesOverUnderExpenditure">Difference between revenues and expenditures attributable to all governmental funds.  If positive, this amount is called a surplus.  If negative, it represents a deficit. Governmental funds are used to account for general government activities that are financed primarily through taxes, intergovernmental revenues, and other nonexchange revenues..</param>
        public MunicipalityFinancial(decimal? FiscalYear = default(decimal?), decimal? CurrentAssets = default(decimal?), decimal? NonCurrentAssets = default(decimal?), decimal? DeferredOutflows = default(decimal?), decimal? TotalAssets = default(decimal?), decimal? TotalAssetsPlusDeferredOutflows = default(decimal?), decimal? CurrentLiabilities = default(decimal?), decimal? CurrentPortionOfLongTermDebt = default(decimal?), decimal? NetPensionLiability = default(decimal?), decimal? NetOpebLiability = default(decimal?), decimal? AllOtherLongTermDebt = default(decimal?), decimal? TotalLiabilities = default(decimal?), decimal? DeferredInflows = default(decimal?), decimal? TotalLiabilitiesPlusDeferredInflows = default(decimal?), decimal? TotalNetPosition = default(decimal?), decimal? TotalUnrestrictedNetPosition = default(decimal?), decimal? TotalExpenses = default(decimal?), decimal? ChargesForServices = default(decimal?), decimal? OperatingGrantsAndContributions = default(decimal?), decimal? CapitalGrantsAndContributions = default(decimal?), decimal? GeneralRevenues = default(decimal?), decimal? OtherRevenues = default(decimal?), decimal? TotalRevenues = default(decimal?), decimal? ChangeInNetAssets = default(decimal?), decimal? NonSpendableGeneralFundBalance = default(decimal?), decimal? RestrictedGeneralFundBalance = default(decimal?), decimal? CommittedGeneralFundBalance = default(decimal?), decimal? UnassignedGeneralFundBalance = default(decimal?), decimal? AssignedGeneralFundBalance = default(decimal?), decimal? TotalGeneralFundBalance = default(decimal?), decimal? NonSpendableGovernmentalFundBalance = default(decimal?), decimal? RestrictedGovernmentalFundBalance = default(decimal?), decimal? CommittedGovernmentalFundBalance = default(decimal?), decimal? UnassignedGovernmentalFundBalance = default(decimal?), decimal? AssignedGovernmentalFundBalance = default(decimal?), decimal? TotalGovernmentalFundBalance = default(decimal?), decimal? GeneralFundRevenues = default(decimal?), decimal? GeneralFundExpenditures = default(decimal?), decimal? GeneralFundRevenuesOverUnderExpenditure = default(decimal?), decimal? GovernmentalFundRevenues = default(decimal?), decimal? GovernmentalFundExpenditures = default(decimal?), decimal? GovernmentalFundRevenuesOverUnderExpenditure = default(decimal?))
        {
            this.FiscalYear = FiscalYear;
            this.CurrentAssets = CurrentAssets;
            this.NonCurrentAssets = NonCurrentAssets;
            this.DeferredOutflows = DeferredOutflows;
            this.TotalAssets = TotalAssets;
            this.TotalAssetsPlusDeferredOutflows = TotalAssetsPlusDeferredOutflows;
            this.CurrentLiabilities = CurrentLiabilities;
            this.CurrentPortionOfLongTermDebt = CurrentPortionOfLongTermDebt;
            this.NetPensionLiability = NetPensionLiability;
            this.NetOpebLiability = NetOpebLiability;
            this.AllOtherLongTermDebt = AllOtherLongTermDebt;
            this.TotalLiabilities = TotalLiabilities;
            this.DeferredInflows = DeferredInflows;
            this.TotalLiabilitiesPlusDeferredInflows = TotalLiabilitiesPlusDeferredInflows;
            this.TotalNetPosition = TotalNetPosition;
            this.TotalUnrestrictedNetPosition = TotalUnrestrictedNetPosition;
            this.TotalExpenses = TotalExpenses;
            this.ChargesForServices = ChargesForServices;
            this.OperatingGrantsAndContributions = OperatingGrantsAndContributions;
            this.CapitalGrantsAndContributions = CapitalGrantsAndContributions;
            this.GeneralRevenues = GeneralRevenues;
            this.OtherRevenues = OtherRevenues;
            this.TotalRevenues = TotalRevenues;
            this.ChangeInNetAssets = ChangeInNetAssets;
            this.NonSpendableGeneralFundBalance = NonSpendableGeneralFundBalance;
            this.RestrictedGeneralFundBalance = RestrictedGeneralFundBalance;
            this.CommittedGeneralFundBalance = CommittedGeneralFundBalance;
            this.UnassignedGeneralFundBalance = UnassignedGeneralFundBalance;
            this.AssignedGeneralFundBalance = AssignedGeneralFundBalance;
            this.TotalGeneralFundBalance = TotalGeneralFundBalance;
            this.NonSpendableGovernmentalFundBalance = NonSpendableGovernmentalFundBalance;
            this.RestrictedGovernmentalFundBalance = RestrictedGovernmentalFundBalance;
            this.CommittedGovernmentalFundBalance = CommittedGovernmentalFundBalance;
            this.UnassignedGovernmentalFundBalance = UnassignedGovernmentalFundBalance;
            this.AssignedGovernmentalFundBalance = AssignedGovernmentalFundBalance;
            this.TotalGovernmentalFundBalance = TotalGovernmentalFundBalance;
            this.GeneralFundRevenues = GeneralFundRevenues;
            this.GeneralFundExpenditures = GeneralFundExpenditures;
            this.GeneralFundRevenuesOverUnderExpenditure = GeneralFundRevenuesOverUnderExpenditure;
            this.GovernmentalFundRevenues = GovernmentalFundRevenues;
            this.GovernmentalFundExpenditures = GovernmentalFundExpenditures;
            this.GovernmentalFundRevenuesOverUnderExpenditure = GovernmentalFundRevenuesOverUnderExpenditure;
        }
        
        /// <summary>
        /// The fiscal year from which the financial data came from
        /// </summary>
        /// <value>The fiscal year from which the financial data came from</value>
        [DataMember(Name="fiscal_year", EmitDefaultValue=false)]
        public decimal? FiscalYear { get; set; }

        /// <summary>
        /// Government-wide holdings that can be liquidated on short notice
        /// </summary>
        /// <value>Government-wide holdings that can be liquidated on short notice</value>
        [DataMember(Name="current_assets", EmitDefaultValue=false)]
        public decimal? CurrentAssets { get; set; }

        /// <summary>
        /// Government-wide holdings not intended for near-term liquidation
        /// </summary>
        /// <value>Government-wide holdings not intended for near-term liquidation</value>
        [DataMember(Name="non_current_assets", EmitDefaultValue=false)]
        public decimal? NonCurrentAssets { get; set; }

        /// <summary>
        /// Government-wide consumptions of net position applicable to a future year
        /// </summary>
        /// <value>Government-wide consumptions of net position applicable to a future year</value>
        [DataMember(Name="deferred_outflows", EmitDefaultValue=false)]
        public decimal? DeferredOutflows { get; set; }

        /// <summary>
        /// Government-wide holdings
        /// </summary>
        /// <value>Government-wide holdings</value>
        [DataMember(Name="total_assets", EmitDefaultValue=false)]
        public decimal? TotalAssets { get; set; }

        /// <summary>
        /// Sum of government-wide total assets and deferred outflows of resources
        /// </summary>
        /// <value>Sum of government-wide total assets and deferred outflows of resources</value>
        [DataMember(Name="total_assets_plus_deferred_outflows", EmitDefaultValue=false)]
        public decimal? TotalAssetsPlusDeferredOutflows { get; set; }

        /// <summary>
        /// Government-wide liabilities that typically become due within one year
        /// </summary>
        /// <value>Government-wide liabilities that typically become due within one year</value>
        [DataMember(Name="current_liabilities", EmitDefaultValue=false)]
        public decimal? CurrentLiabilities { get; set; }

        /// <summary>
        /// Government-wide portion of long term obligations, such as bond and loan debt coming due within the next year
        /// </summary>
        /// <value>Government-wide portion of long term obligations, such as bond and loan debt coming due within the next year</value>
        [DataMember(Name="current_portion_of_long_term_debt", EmitDefaultValue=false)]
        public decimal? CurrentPortionOfLongTermDebt { get; set; }

        /// <summary>
        /// Government-wide liability for employee pensions net of the fiduciary net position of pension plans in which the government has an interest
        /// </summary>
        /// <value>Government-wide liability for employee pensions net of the fiduciary net position of pension plans in which the government has an interest</value>
        [DataMember(Name="net_pension_liability", EmitDefaultValue=false)]
        public decimal? NetPensionLiability { get; set; }

        /// <summary>
        /// Government-wide liability for other postemployment benefits (OPEB). These are benefits (such as death benefits, life insurance, disability, and long-term care) that are paid in the period after employment and that are provided separately from a pension plan, as well as healthcare benefits paid in the period after employment, regardless of the manner in which they are provided. OPEB does not include termination benefits or termination payments for sick leave. Liability is reported net of any OPEB assets the government may control.
        /// </summary>
        /// <value>Government-wide liability for other postemployment benefits (OPEB). These are benefits (such as death benefits, life insurance, disability, and long-term care) that are paid in the period after employment and that are provided separately from a pension plan, as well as healthcare benefits paid in the period after employment, regardless of the manner in which they are provided. OPEB does not include termination benefits or termination payments for sick leave. Liability is reported net of any OPEB assets the government may control.</value>
        [DataMember(Name="net_opeb_liability", EmitDefaultValue=false)]
        public decimal? NetOpebLiability { get; set; }

        /// <summary>
        /// Government-wide liabilities not elsewhere classified
        /// </summary>
        /// <value>Government-wide liabilities not elsewhere classified</value>
        [DataMember(Name="all_other_long_term_debt", EmitDefaultValue=false)]
        public decimal? AllOtherLongTermDebt { get; set; }

        /// <summary>
        /// The sum of the Municipality&#39;s all other long term debt, net open liability, net pension liability, and current portion of long term debt
        /// </summary>
        /// <value>The sum of the Municipality&#39;s all other long term debt, net open liability, net pension liability, and current portion of long term debt</value>
        [DataMember(Name="total_liabilities", EmitDefaultValue=false)]
        public decimal? TotalLiabilities { get; set; }

        /// <summary>
        /// Government-wide acquisitions of net position applicable to a future year
        /// </summary>
        /// <value>Government-wide acquisitions of net position applicable to a future year</value>
        [DataMember(Name="deferred_inflows", EmitDefaultValue=false)]
        public decimal? DeferredInflows { get; set; }

        /// <summary>
        /// Sum of government-wide liabilities and deferred inflows of resources
        /// </summary>
        /// <value>Sum of government-wide liabilities and deferred inflows of resources</value>
        [DataMember(Name="total_liabilities_plus_deferred_inflows", EmitDefaultValue=false)]
        public decimal? TotalLiabilitiesPlusDeferredInflows { get; set; }

        /// <summary>
        /// Government-wide assets and deferred outflows less government-wide liabilities and deferred inflows
        /// </summary>
        /// <value>Government-wide assets and deferred outflows less government-wide liabilities and deferred inflows</value>
        [DataMember(Name="total_net_position", EmitDefaultValue=false)]
        public decimal? TotalNetPosition { get; set; }

        /// <summary>
        /// Net amount of government-wide assets, deferred outflows of resources, liabilities, and deferred inflows of resources that are not included in the determination of net investment in capital assets or the restricted components of net position
        /// </summary>
        /// <value>Net amount of government-wide assets, deferred outflows of resources, liabilities, and deferred inflows of resources that are not included in the determination of net investment in capital assets or the restricted components of net position</value>
        [DataMember(Name="total_unrestricted_net_position", EmitDefaultValue=false)]
        public decimal? TotalUnrestrictedNetPosition { get; set; }

        /// <summary>
        /// Decreases in net position that occurred during the past year, government-wide
        /// </summary>
        /// <value>Decreases in net position that occurred during the past year, government-wide</value>
        [DataMember(Name="total_expenses", EmitDefaultValue=false)]
        public decimal? TotalExpenses { get; set; }

        /// <summary>
        /// Charges for services is the term used for a broad category of program revenues that arise from charges to customers, applicants, or others who purchase, use, or directly benefit from the goods, services, or privileges provided, or are otherwise directly affected by the services. Revenues in this category include fees charged for specific services, such as water use or garbage collection; licenses and permits, such as dog licenses, liquor licenses, and building permits; operating special assessments, such as for street cleaning or special street lighting; and any other amounts charged to service recipients. Fines and forfeitures are also included in this category because they result from direct charges to those who are otherwise directly affected by a program or service, even though they receive no benefit. Payments from other governments for goods or services should be reported in this category.
        /// </summary>
        /// <value>Charges for services is the term used for a broad category of program revenues that arise from charges to customers, applicants, or others who purchase, use, or directly benefit from the goods, services, or privileges provided, or are otherwise directly affected by the services. Revenues in this category include fees charged for specific services, such as water use or garbage collection; licenses and permits, such as dog licenses, liquor licenses, and building permits; operating special assessments, such as for street cleaning or special street lighting; and any other amounts charged to service recipients. Fines and forfeitures are also included in this category because they result from direct charges to those who are otherwise directly affected by a program or service, even though they receive no benefit. Payments from other governments for goods or services should be reported in this category.</value>
        [DataMember(Name="charges_for_services", EmitDefaultValue=false)]
        public decimal? ChargesForServices { get; set; }

        /// <summary>
        /// Program-specific grants and contributions - includes revenues arising from mandatory and voluntary nonexchange transactions with other governments, organizations, or individuals that are restricted for use in a particular program. Some grants and contributions consist of capital assets or resources that are restricted for capital purposes—to purchase, construct, or renovate capital assets associated with a specific program. These should be reported separately from grants and contributions that may be used either for operating expenses or for capital expenditures of the program at the discretion of the reporting government. These categories of program revenue are specifically attributable to a program and reduce the net expense of that program to the reporting government. For example, a state may provide an operating grant to a county sheriff&#39;s department for a drug-awareness-and-enforcement program.
        /// </summary>
        /// <value>Program-specific grants and contributions - includes revenues arising from mandatory and voluntary nonexchange transactions with other governments, organizations, or individuals that are restricted for use in a particular program. Some grants and contributions consist of capital assets or resources that are restricted for capital purposes—to purchase, construct, or renovate capital assets associated with a specific program. These should be reported separately from grants and contributions that may be used either for operating expenses or for capital expenditures of the program at the discretion of the reporting government. These categories of program revenue are specifically attributable to a program and reduce the net expense of that program to the reporting government. For example, a state may provide an operating grant to a county sheriff&#39;s department for a drug-awareness-and-enforcement program.</value>
        [DataMember(Name="operating_grants_and_contributions", EmitDefaultValue=false)]
        public decimal? OperatingGrantsAndContributions { get; set; }

        /// <summary>
        /// Program-specific grants and contributions - includes revenues arising from mandatory and voluntary nonexchange transactions with other governments, organizations, or individuals that are restricted for use in a particular program. Some grants and contributions consist of capital assets or resources that are restricted for capital purposes—to purchase, construct, or renovate capital assets associated with a specific program. These should be reported separately from grants and contributions that may be used either for operating expenses or for capital expenditures of the program at the discretion of the reporting government. These categories of program revenue are specifically attributable to a program and reduce the net expense of that program to the reporting government. For example, a state may provide a capital grant to finance construction of a new jail.
        /// </summary>
        /// <value>Program-specific grants and contributions - includes revenues arising from mandatory and voluntary nonexchange transactions with other governments, organizations, or individuals that are restricted for use in a particular program. Some grants and contributions consist of capital assets or resources that are restricted for capital purposes—to purchase, construct, or renovate capital assets associated with a specific program. These should be reported separately from grants and contributions that may be used either for operating expenses or for capital expenditures of the program at the discretion of the reporting government. These categories of program revenue are specifically attributable to a program and reduce the net expense of that program to the reporting government. For example, a state may provide a capital grant to finance construction of a new jail.</value>
        [DataMember(Name="capital_grants_and_contributions", EmitDefaultValue=false)]
        public decimal? CapitalGrantsAndContributions { get; set; }

        /// <summary>
        /// All revenues are general revenues unless they are required to be reported as program revenues. All taxes, even those that are levied for a specific purpose, are general revenues and should be reported by type of tax—for example, sales tax, property tax, franchise tax, income tax. All other nontax revenues (including interest, grants, and contributions) that do not meet the criteria to be reported as program revenues should also be reported as general revenues. General revenues should be reported after total net expense of the government&#39;s functions.
        /// </summary>
        /// <value>All revenues are general revenues unless they are required to be reported as program revenues. All taxes, even those that are levied for a specific purpose, are general revenues and should be reported by type of tax—for example, sales tax, property tax, franchise tax, income tax. All other nontax revenues (including interest, grants, and contributions) that do not meet the criteria to be reported as program revenues should also be reported as general revenues. General revenues should be reported after total net expense of the government&#39;s functions.</value>
        [DataMember(Name="general_revenues", EmitDefaultValue=false)]
        public decimal? GeneralRevenues { get; set; }

        /// <summary>
        /// Government-wide revenues not elsewhere classified
        /// </summary>
        /// <value>Government-wide revenues not elsewhere classified</value>
        [DataMember(Name="other_revenues", EmitDefaultValue=false)]
        public decimal? OtherRevenues { get; set; }

        /// <summary>
        /// Increases in net position that occurred during the past year, government-wide
        /// </summary>
        /// <value>Increases in net position that occurred during the past year, government-wide</value>
        [DataMember(Name="total_revenues", EmitDefaultValue=false)]
        public decimal? TotalRevenues { get; set; }

        /// <summary>
        /// Difference between the government&#39;s net position at the end of the fiscal year and the government&#39;s net position at the beginning of the fiscal year
        /// </summary>
        /// <value>Difference between the government&#39;s net position at the end of the fiscal year and the government&#39;s net position at the beginning of the fiscal year</value>
        [DataMember(Name="change_in_net_assets", EmitDefaultValue=false)]
        public decimal? ChangeInNetAssets { get; set; }

        /// <summary>
        /// The portion of general fund balance classified as nonspendable. The nonspendable fund balance classification includes amounts that cannot be spent because they are either (a) not in spendable form or (b) legally or contractually required to be maintained intact. The “not in spendable form” criterion includes items that are not expected to be converted to cash, for example, inventories and prepaid amounts. It also includes the long-term amount of loans and notes receivable, as well as property acquired for resale. However, if the use of the proceeds from the collection of those receivables or from the sale of those properties is restricted, committed, or assigned, then they should be included in the appropriate fund balance classification (restricted, committed, or assigned), rather than nonspendable fund balance. The corpus (or principal) of a permanent fund is an example of an amount that is legally or contractually required to be maintained intact.
        /// </summary>
        /// <value>The portion of general fund balance classified as nonspendable. The nonspendable fund balance classification includes amounts that cannot be spent because they are either (a) not in spendable form or (b) legally or contractually required to be maintained intact. The “not in spendable form” criterion includes items that are not expected to be converted to cash, for example, inventories and prepaid amounts. It also includes the long-term amount of loans and notes receivable, as well as property acquired for resale. However, if the use of the proceeds from the collection of those receivables or from the sale of those properties is restricted, committed, or assigned, then they should be included in the appropriate fund balance classification (restricted, committed, or assigned), rather than nonspendable fund balance. The corpus (or principal) of a permanent fund is an example of an amount that is legally or contractually required to be maintained intact.</value>
        [DataMember(Name="non_spendable_general_fund_balance", EmitDefaultValue=false)]
        public decimal? NonSpendableGeneralFundBalance { get; set; }

        /// <summary>
        /// The portion of general fund balance classified as restricted. Fund balance should be reported as restricted when constraints placed on the use of resources are either (a) Externally imposed by creditors (such as through debt covenants), grantors, contributors, or laws or regulations of other governments or (b) Imposed by law through constitutional provisions or enabling legislation.
        /// </summary>
        /// <value>The portion of general fund balance classified as restricted. Fund balance should be reported as restricted when constraints placed on the use of resources are either (a) Externally imposed by creditors (such as through debt covenants), grantors, contributors, or laws or regulations of other governments or (b) Imposed by law through constitutional provisions or enabling legislation.</value>
        [DataMember(Name="restricted_general_fund_balance", EmitDefaultValue=false)]
        public decimal? RestrictedGeneralFundBalance { get; set; }

        /// <summary>
        /// The portion of general fund balance classified as committed. Amounts that can only be used for specific purposes pursuant to constraints imposed by formal action of the government’s highest level of decision-making authority should be reported as committed fund balance. Those committed amounts cannot be used for any other purpose unless the government removes or changes the specified use by taking the same type of action (for example, legislation, resolution, ordinance) it employed to previously commit those amounts. The authorization specifying the purposes for which amounts can be used should have the consent of both the legislative and executive branches of the government, if applicable. Committed fund balance also should incorporate contractual obligations to the extent that existing resources in the fund have been specifically committed for use in satisfying those contractual requirements.
        /// </summary>
        /// <value>The portion of general fund balance classified as committed. Amounts that can only be used for specific purposes pursuant to constraints imposed by formal action of the government’s highest level of decision-making authority should be reported as committed fund balance. Those committed amounts cannot be used for any other purpose unless the government removes or changes the specified use by taking the same type of action (for example, legislation, resolution, ordinance) it employed to previously commit those amounts. The authorization specifying the purposes for which amounts can be used should have the consent of both the legislative and executive branches of the government, if applicable. Committed fund balance also should incorporate contractual obligations to the extent that existing resources in the fund have been specifically committed for use in satisfying those contractual requirements.</value>
        [DataMember(Name="committed_general_fund_balance", EmitDefaultValue=false)]
        public decimal? CommittedGeneralFundBalance { get; set; }

        /// <summary>
        /// The portion of general fund balance classified as unassigned. Unassigned fund balance is the residual classification for the general fund. This classification represents fund balance that has not been assigned to other funds and that has not been restricted, committed, or assigned to specific purposes within the general fund. The general fund should be the only fund that reports a positive unassigned fund balance amount. In other governmental funds, if expenditures incurred for specific purposes exceeded the amounts restricted, committed, or assigned to those purposes, it may be necessary to report a negative unassigned fund balance.
        /// </summary>
        /// <value>The portion of general fund balance classified as unassigned. Unassigned fund balance is the residual classification for the general fund. This classification represents fund balance that has not been assigned to other funds and that has not been restricted, committed, or assigned to specific purposes within the general fund. The general fund should be the only fund that reports a positive unassigned fund balance amount. In other governmental funds, if expenditures incurred for specific purposes exceeded the amounts restricted, committed, or assigned to those purposes, it may be necessary to report a negative unassigned fund balance.</value>
        [DataMember(Name="unassigned_general_fund_balance", EmitDefaultValue=false)]
        public decimal? UnassignedGeneralFundBalance { get; set; }

        /// <summary>
        /// The portion of general fund balance classified as assigned. Amounts that are constrained by the government’s intent to be used for specific purposes, but are neither restricted nor committed, should be reported as assigned fund balance, except for stabilization arrangements.. Intent should be expressed by (a) the governing body itself or (b) a body (a budget or finance committee, for example) or official to which the governing body has delegated the authority to assign amounts to be used for specific purposes.
        /// </summary>
        /// <value>The portion of general fund balance classified as assigned. Amounts that are constrained by the government’s intent to be used for specific purposes, but are neither restricted nor committed, should be reported as assigned fund balance, except for stabilization arrangements.. Intent should be expressed by (a) the governing body itself or (b) a body (a budget or finance committee, for example) or official to which the governing body has delegated the authority to assign amounts to be used for specific purposes.</value>
        [DataMember(Name="assigned_general_fund_balance", EmitDefaultValue=false)]
        public decimal? AssignedGeneralFundBalance { get; set; }

        /// <summary>
        /// General fund balance in all classifications. Fund balance is the difference between governmental fund assets and deferred outflows of resources, and liabilities and deferred inflows of resources. It is sometimes referred to as fund equity. The general fund is used to account for and report all financial resources not accounted for and reported in another governmental fund.
        /// </summary>
        /// <value>General fund balance in all classifications. Fund balance is the difference between governmental fund assets and deferred outflows of resources, and liabilities and deferred inflows of resources. It is sometimes referred to as fund equity. The general fund is used to account for and report all financial resources not accounted for and reported in another governmental fund.</value>
        [DataMember(Name="total_general_fund_balance", EmitDefaultValue=false)]
        public decimal? TotalGeneralFundBalance { get; set; }

        /// <summary>
        /// For all governmental funds, the aggregate of fund balances that are classified as nonspendable. The nonspendable fund balance classification includes amounts that cannot be spent because they are either (a) not in spendable form or (b) legally or contractually required to be maintained intact. The “not in spendable form” criterion includes items that are not expected to be converted to cash, for example, inventories and prepaid amounts. It also includes the long-term amount of loans and notes receivable, as well as property acquired for resale. However, if the use of the proceeds from the collection of those receivables or from the sale of those properties is restricted, committed, or assigned, then they should be included in the appropriate fund balance classification (restricted, committed, or assigned), rather than nonspendable fund balance.
        /// </summary>
        /// <value>For all governmental funds, the aggregate of fund balances that are classified as nonspendable. The nonspendable fund balance classification includes amounts that cannot be spent because they are either (a) not in spendable form or (b) legally or contractually required to be maintained intact. The “not in spendable form” criterion includes items that are not expected to be converted to cash, for example, inventories and prepaid amounts. It also includes the long-term amount of loans and notes receivable, as well as property acquired for resale. However, if the use of the proceeds from the collection of those receivables or from the sale of those properties is restricted, committed, or assigned, then they should be included in the appropriate fund balance classification (restricted, committed, or assigned), rather than nonspendable fund balance.</value>
        [DataMember(Name="non_spendable_governmental_fund_balance", EmitDefaultValue=false)]
        public decimal? NonSpendableGovernmentalFundBalance { get; set; }

        /// <summary>
        /// For all governmental funds, the aggregate of fund balances that are classified as restricted. Fund balance should be reported as restricted when constraints placed on the use of resources are either (a) Externally imposed by creditors (such as through debt covenants), grantors, contributors, or laws or regulations of other governments; or (b) Imposed by law through constitutional provisions or enabling legislation.
        /// </summary>
        /// <value>For all governmental funds, the aggregate of fund balances that are classified as restricted. Fund balance should be reported as restricted when constraints placed on the use of resources are either (a) Externally imposed by creditors (such as through debt covenants), grantors, contributors, or laws or regulations of other governments; or (b) Imposed by law through constitutional provisions or enabling legislation.</value>
        [DataMember(Name="restricted_governmental_fund_balance", EmitDefaultValue=false)]
        public decimal? RestrictedGovernmentalFundBalance { get; set; }

        /// <summary>
        /// For all governmental funds, the aggregate of fund balances that are classified as committed. Amounts that can only be used for specific purposes pursuant to constraints imposed by formal action of the government’s highest level of decision-making authority should be reported as committed fund balance. Those committed amounts cannot be used for any other purpose unless the government removes or changes the specified use by taking the same type of action (for example, legislation, resolution, ordinance) it employed to previously commit those amounts. The authorization specifying the purposes for which amounts can be used should have the consent of both the legislative and executive branches of the government, if applicable. Committed fund balance also should incorporate contractual obligations to the extent that existing resources in the fund have been specifically committed for use in satisfying those contractual requirements.
        /// </summary>
        /// <value>For all governmental funds, the aggregate of fund balances that are classified as committed. Amounts that can only be used for specific purposes pursuant to constraints imposed by formal action of the government’s highest level of decision-making authority should be reported as committed fund balance. Those committed amounts cannot be used for any other purpose unless the government removes or changes the specified use by taking the same type of action (for example, legislation, resolution, ordinance) it employed to previously commit those amounts. The authorization specifying the purposes for which amounts can be used should have the consent of both the legislative and executive branches of the government, if applicable. Committed fund balance also should incorporate contractual obligations to the extent that existing resources in the fund have been specifically committed for use in satisfying those contractual requirements.</value>
        [DataMember(Name="committed_governmental_fund_balance", EmitDefaultValue=false)]
        public decimal? CommittedGovernmentalFundBalance { get; set; }

        /// <summary>
        /// For all governmental funds, the aggregate of fund balances that are classified as unassigned. Unassigned fund balance is the residual classification for the general fund. This classification represents fund balance that has not been assigned to other funds and that has not been restricted, committed, or assigned to specific purposes within the general fund. The general fund should be the only fund that reports a positive unassigned fund balance amount. In other governmental funds, if expenditures incurred for specific purposes exceeded the amounts restricted, committed, or assigned to those purposes, it may be necessary to report a negative unassigned fund balance.
        /// </summary>
        /// <value>For all governmental funds, the aggregate of fund balances that are classified as unassigned. Unassigned fund balance is the residual classification for the general fund. This classification represents fund balance that has not been assigned to other funds and that has not been restricted, committed, or assigned to specific purposes within the general fund. The general fund should be the only fund that reports a positive unassigned fund balance amount. In other governmental funds, if expenditures incurred for specific purposes exceeded the amounts restricted, committed, or assigned to those purposes, it may be necessary to report a negative unassigned fund balance.</value>
        [DataMember(Name="unassigned_governmental_fund_balance", EmitDefaultValue=false)]
        public decimal? UnassignedGovernmentalFundBalance { get; set; }

        /// <summary>
        /// For all governmental funds, the aggregate of fund balances that are classified as assigned. Amounts that are constrained by the government’s intent to be used for specific purposes, but are neither restricted nor committed, should be reported as assigned fund balance, except for stabilization arrangements.. Intent should be expressed by (a) the governing body itself or (b) a body (a budget or finance committee, for example) or official to which the governing body has delegated the authority to assign amounts to be used for specific purposes.
        /// </summary>
        /// <value>For all governmental funds, the aggregate of fund balances that are classified as assigned. Amounts that are constrained by the government’s intent to be used for specific purposes, but are neither restricted nor committed, should be reported as assigned fund balance, except for stabilization arrangements.. Intent should be expressed by (a) the governing body itself or (b) a body (a budget or finance committee, for example) or official to which the governing body has delegated the authority to assign amounts to be used for specific purposes.</value>
        [DataMember(Name="assigned_governmental_fund_balance", EmitDefaultValue=false)]
        public decimal? AssignedGovernmentalFundBalance { get; set; }

        /// <summary>
        /// For all governmental funds, the aggregate of all fund balances in any classification. Fund balance is the difference between governmental fund assets and deferred outflows of resources, and liabilities and deferred inflows of resources. It is sometimes referred to as fund equity. Governmental funds are used to account for general government activities that are financed primarily through taxes, intergovernmental revenues, and other nonexchange revenues.
        /// </summary>
        /// <value>For all governmental funds, the aggregate of all fund balances in any classification. Fund balance is the difference between governmental fund assets and deferred outflows of resources, and liabilities and deferred inflows of resources. It is sometimes referred to as fund equity. Governmental funds are used to account for general government activities that are financed primarily through taxes, intergovernmental revenues, and other nonexchange revenues.</value>
        [DataMember(Name="total_governmental_fund_balance", EmitDefaultValue=false)]
        public decimal? TotalGovernmentalFundBalance { get; set; }

        /// <summary>
        /// Increases in financial resources attributable to the general fund. The general fund is used to account for and report all financial resources not accounted for and reported in another governmental fund.
        /// </summary>
        /// <value>Increases in financial resources attributable to the general fund. The general fund is used to account for and report all financial resources not accounted for and reported in another governmental fund.</value>
        [DataMember(Name="general_fund_revenues", EmitDefaultValue=false)]
        public decimal? GeneralFundRevenues { get; set; }

        /// <summary>
        /// Decreases in financial resources attributable to the general fund. The general fund is used to account for and report all financial resources not accounted for and reported in another governmental fund.
        /// </summary>
        /// <value>Decreases in financial resources attributable to the general fund. The general fund is used to account for and report all financial resources not accounted for and reported in another governmental fund.</value>
        [DataMember(Name="general_fund_expenditures", EmitDefaultValue=false)]
        public decimal? GeneralFundExpenditures { get; set; }

        /// <summary>
        /// Difference between general fund revenues and expenditures.  If positive, this amount is called a surplus.  If negative, it represents a deficit. The general fund is used to account for and report all financial resources not accounted for and reported in another governmental fund.
        /// </summary>
        /// <value>Difference between general fund revenues and expenditures.  If positive, this amount is called a surplus.  If negative, it represents a deficit. The general fund is used to account for and report all financial resources not accounted for and reported in another governmental fund.</value>
        [DataMember(Name="general_fund_revenues_over_under_expenditure", EmitDefaultValue=false)]
        public decimal? GeneralFundRevenuesOverUnderExpenditure { get; set; }

        /// <summary>
        /// Increases in financial resources attributable to any governmental fund. Governmental funds are used to account for general government activities that are financed primarily through taxes, intergovernmental revenues, and other nonexchange revenues.
        /// </summary>
        /// <value>Increases in financial resources attributable to any governmental fund. Governmental funds are used to account for general government activities that are financed primarily through taxes, intergovernmental revenues, and other nonexchange revenues.</value>
        [DataMember(Name="governmental_fund_revenues", EmitDefaultValue=false)]
        public decimal? GovernmentalFundRevenues { get; set; }

        /// <summary>
        /// Decreases in financial resources attributable to any governmental fund. Governmental funds are used to account for general government activities that are financed primarily through taxes, intergovernmental revenues, and other nonexchange revenues.
        /// </summary>
        /// <value>Decreases in financial resources attributable to any governmental fund. Governmental funds are used to account for general government activities that are financed primarily through taxes, intergovernmental revenues, and other nonexchange revenues.</value>
        [DataMember(Name="governmental_fund_expenditures", EmitDefaultValue=false)]
        public decimal? GovernmentalFundExpenditures { get; set; }

        /// <summary>
        /// Difference between revenues and expenditures attributable to all governmental funds.  If positive, this amount is called a surplus.  If negative, it represents a deficit. Governmental funds are used to account for general government activities that are financed primarily through taxes, intergovernmental revenues, and other nonexchange revenues.
        /// </summary>
        /// <value>Difference between revenues and expenditures attributable to all governmental funds.  If positive, this amount is called a surplus.  If negative, it represents a deficit. Governmental funds are used to account for general government activities that are financed primarily through taxes, intergovernmental revenues, and other nonexchange revenues.</value>
        [DataMember(Name="governmental_fund_revenues_over_under_expenditure", EmitDefaultValue=false)]
        public decimal? GovernmentalFundRevenuesOverUnderExpenditure { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MunicipalityFinancial {\n");
            sb.Append("  FiscalYear: ").Append(FiscalYear).Append("\n");
            sb.Append("  CurrentAssets: ").Append(CurrentAssets).Append("\n");
            sb.Append("  NonCurrentAssets: ").Append(NonCurrentAssets).Append("\n");
            sb.Append("  DeferredOutflows: ").Append(DeferredOutflows).Append("\n");
            sb.Append("  TotalAssets: ").Append(TotalAssets).Append("\n");
            sb.Append("  TotalAssetsPlusDeferredOutflows: ").Append(TotalAssetsPlusDeferredOutflows).Append("\n");
            sb.Append("  CurrentLiabilities: ").Append(CurrentLiabilities).Append("\n");
            sb.Append("  CurrentPortionOfLongTermDebt: ").Append(CurrentPortionOfLongTermDebt).Append("\n");
            sb.Append("  NetPensionLiability: ").Append(NetPensionLiability).Append("\n");
            sb.Append("  NetOpebLiability: ").Append(NetOpebLiability).Append("\n");
            sb.Append("  AllOtherLongTermDebt: ").Append(AllOtherLongTermDebt).Append("\n");
            sb.Append("  TotalLiabilities: ").Append(TotalLiabilities).Append("\n");
            sb.Append("  DeferredInflows: ").Append(DeferredInflows).Append("\n");
            sb.Append("  TotalLiabilitiesPlusDeferredInflows: ").Append(TotalLiabilitiesPlusDeferredInflows).Append("\n");
            sb.Append("  TotalNetPosition: ").Append(TotalNetPosition).Append("\n");
            sb.Append("  TotalUnrestrictedNetPosition: ").Append(TotalUnrestrictedNetPosition).Append("\n");
            sb.Append("  TotalExpenses: ").Append(TotalExpenses).Append("\n");
            sb.Append("  ChargesForServices: ").Append(ChargesForServices).Append("\n");
            sb.Append("  OperatingGrantsAndContributions: ").Append(OperatingGrantsAndContributions).Append("\n");
            sb.Append("  CapitalGrantsAndContributions: ").Append(CapitalGrantsAndContributions).Append("\n");
            sb.Append("  GeneralRevenues: ").Append(GeneralRevenues).Append("\n");
            sb.Append("  OtherRevenues: ").Append(OtherRevenues).Append("\n");
            sb.Append("  TotalRevenues: ").Append(TotalRevenues).Append("\n");
            sb.Append("  ChangeInNetAssets: ").Append(ChangeInNetAssets).Append("\n");
            sb.Append("  NonSpendableGeneralFundBalance: ").Append(NonSpendableGeneralFundBalance).Append("\n");
            sb.Append("  RestrictedGeneralFundBalance: ").Append(RestrictedGeneralFundBalance).Append("\n");
            sb.Append("  CommittedGeneralFundBalance: ").Append(CommittedGeneralFundBalance).Append("\n");
            sb.Append("  UnassignedGeneralFundBalance: ").Append(UnassignedGeneralFundBalance).Append("\n");
            sb.Append("  AssignedGeneralFundBalance: ").Append(AssignedGeneralFundBalance).Append("\n");
            sb.Append("  TotalGeneralFundBalance: ").Append(TotalGeneralFundBalance).Append("\n");
            sb.Append("  NonSpendableGovernmentalFundBalance: ").Append(NonSpendableGovernmentalFundBalance).Append("\n");
            sb.Append("  RestrictedGovernmentalFundBalance: ").Append(RestrictedGovernmentalFundBalance).Append("\n");
            sb.Append("  CommittedGovernmentalFundBalance: ").Append(CommittedGovernmentalFundBalance).Append("\n");
            sb.Append("  UnassignedGovernmentalFundBalance: ").Append(UnassignedGovernmentalFundBalance).Append("\n");
            sb.Append("  AssignedGovernmentalFundBalance: ").Append(AssignedGovernmentalFundBalance).Append("\n");
            sb.Append("  TotalGovernmentalFundBalance: ").Append(TotalGovernmentalFundBalance).Append("\n");
            sb.Append("  GeneralFundRevenues: ").Append(GeneralFundRevenues).Append("\n");
            sb.Append("  GeneralFundExpenditures: ").Append(GeneralFundExpenditures).Append("\n");
            sb.Append("  GeneralFundRevenuesOverUnderExpenditure: ").Append(GeneralFundRevenuesOverUnderExpenditure).Append("\n");
            sb.Append("  GovernmentalFundRevenues: ").Append(GovernmentalFundRevenues).Append("\n");
            sb.Append("  GovernmentalFundExpenditures: ").Append(GovernmentalFundExpenditures).Append("\n");
            sb.Append("  GovernmentalFundRevenuesOverUnderExpenditure: ").Append(GovernmentalFundRevenuesOverUnderExpenditure).Append("\n");
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
            return this.Equals(input as MunicipalityFinancial);
        }

        /// <summary>
        /// Returns true if MunicipalityFinancial instances are equal
        /// </summary>
        /// <param name="input">Instance of MunicipalityFinancial to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MunicipalityFinancial input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FiscalYear == input.FiscalYear ||
                    (this.FiscalYear != null &&
                    this.FiscalYear.Equals(input.FiscalYear))
                ) && 
                (
                    this.CurrentAssets == input.CurrentAssets ||
                    (this.CurrentAssets != null &&
                    this.CurrentAssets.Equals(input.CurrentAssets))
                ) && 
                (
                    this.NonCurrentAssets == input.NonCurrentAssets ||
                    (this.NonCurrentAssets != null &&
                    this.NonCurrentAssets.Equals(input.NonCurrentAssets))
                ) && 
                (
                    this.DeferredOutflows == input.DeferredOutflows ||
                    (this.DeferredOutflows != null &&
                    this.DeferredOutflows.Equals(input.DeferredOutflows))
                ) && 
                (
                    this.TotalAssets == input.TotalAssets ||
                    (this.TotalAssets != null &&
                    this.TotalAssets.Equals(input.TotalAssets))
                ) && 
                (
                    this.TotalAssetsPlusDeferredOutflows == input.TotalAssetsPlusDeferredOutflows ||
                    (this.TotalAssetsPlusDeferredOutflows != null &&
                    this.TotalAssetsPlusDeferredOutflows.Equals(input.TotalAssetsPlusDeferredOutflows))
                ) && 
                (
                    this.CurrentLiabilities == input.CurrentLiabilities ||
                    (this.CurrentLiabilities != null &&
                    this.CurrentLiabilities.Equals(input.CurrentLiabilities))
                ) && 
                (
                    this.CurrentPortionOfLongTermDebt == input.CurrentPortionOfLongTermDebt ||
                    (this.CurrentPortionOfLongTermDebt != null &&
                    this.CurrentPortionOfLongTermDebt.Equals(input.CurrentPortionOfLongTermDebt))
                ) && 
                (
                    this.NetPensionLiability == input.NetPensionLiability ||
                    (this.NetPensionLiability != null &&
                    this.NetPensionLiability.Equals(input.NetPensionLiability))
                ) && 
                (
                    this.NetOpebLiability == input.NetOpebLiability ||
                    (this.NetOpebLiability != null &&
                    this.NetOpebLiability.Equals(input.NetOpebLiability))
                ) && 
                (
                    this.AllOtherLongTermDebt == input.AllOtherLongTermDebt ||
                    (this.AllOtherLongTermDebt != null &&
                    this.AllOtherLongTermDebt.Equals(input.AllOtherLongTermDebt))
                ) && 
                (
                    this.TotalLiabilities == input.TotalLiabilities ||
                    (this.TotalLiabilities != null &&
                    this.TotalLiabilities.Equals(input.TotalLiabilities))
                ) && 
                (
                    this.DeferredInflows == input.DeferredInflows ||
                    (this.DeferredInflows != null &&
                    this.DeferredInflows.Equals(input.DeferredInflows))
                ) && 
                (
                    this.TotalLiabilitiesPlusDeferredInflows == input.TotalLiabilitiesPlusDeferredInflows ||
                    (this.TotalLiabilitiesPlusDeferredInflows != null &&
                    this.TotalLiabilitiesPlusDeferredInflows.Equals(input.TotalLiabilitiesPlusDeferredInflows))
                ) && 
                (
                    this.TotalNetPosition == input.TotalNetPosition ||
                    (this.TotalNetPosition != null &&
                    this.TotalNetPosition.Equals(input.TotalNetPosition))
                ) && 
                (
                    this.TotalUnrestrictedNetPosition == input.TotalUnrestrictedNetPosition ||
                    (this.TotalUnrestrictedNetPosition != null &&
                    this.TotalUnrestrictedNetPosition.Equals(input.TotalUnrestrictedNetPosition))
                ) && 
                (
                    this.TotalExpenses == input.TotalExpenses ||
                    (this.TotalExpenses != null &&
                    this.TotalExpenses.Equals(input.TotalExpenses))
                ) && 
                (
                    this.ChargesForServices == input.ChargesForServices ||
                    (this.ChargesForServices != null &&
                    this.ChargesForServices.Equals(input.ChargesForServices))
                ) && 
                (
                    this.OperatingGrantsAndContributions == input.OperatingGrantsAndContributions ||
                    (this.OperatingGrantsAndContributions != null &&
                    this.OperatingGrantsAndContributions.Equals(input.OperatingGrantsAndContributions))
                ) && 
                (
                    this.CapitalGrantsAndContributions == input.CapitalGrantsAndContributions ||
                    (this.CapitalGrantsAndContributions != null &&
                    this.CapitalGrantsAndContributions.Equals(input.CapitalGrantsAndContributions))
                ) && 
                (
                    this.GeneralRevenues == input.GeneralRevenues ||
                    (this.GeneralRevenues != null &&
                    this.GeneralRevenues.Equals(input.GeneralRevenues))
                ) && 
                (
                    this.OtherRevenues == input.OtherRevenues ||
                    (this.OtherRevenues != null &&
                    this.OtherRevenues.Equals(input.OtherRevenues))
                ) && 
                (
                    this.TotalRevenues == input.TotalRevenues ||
                    (this.TotalRevenues != null &&
                    this.TotalRevenues.Equals(input.TotalRevenues))
                ) && 
                (
                    this.ChangeInNetAssets == input.ChangeInNetAssets ||
                    (this.ChangeInNetAssets != null &&
                    this.ChangeInNetAssets.Equals(input.ChangeInNetAssets))
                ) && 
                (
                    this.NonSpendableGeneralFundBalance == input.NonSpendableGeneralFundBalance ||
                    (this.NonSpendableGeneralFundBalance != null &&
                    this.NonSpendableGeneralFundBalance.Equals(input.NonSpendableGeneralFundBalance))
                ) && 
                (
                    this.RestrictedGeneralFundBalance == input.RestrictedGeneralFundBalance ||
                    (this.RestrictedGeneralFundBalance != null &&
                    this.RestrictedGeneralFundBalance.Equals(input.RestrictedGeneralFundBalance))
                ) && 
                (
                    this.CommittedGeneralFundBalance == input.CommittedGeneralFundBalance ||
                    (this.CommittedGeneralFundBalance != null &&
                    this.CommittedGeneralFundBalance.Equals(input.CommittedGeneralFundBalance))
                ) && 
                (
                    this.UnassignedGeneralFundBalance == input.UnassignedGeneralFundBalance ||
                    (this.UnassignedGeneralFundBalance != null &&
                    this.UnassignedGeneralFundBalance.Equals(input.UnassignedGeneralFundBalance))
                ) && 
                (
                    this.AssignedGeneralFundBalance == input.AssignedGeneralFundBalance ||
                    (this.AssignedGeneralFundBalance != null &&
                    this.AssignedGeneralFundBalance.Equals(input.AssignedGeneralFundBalance))
                ) && 
                (
                    this.TotalGeneralFundBalance == input.TotalGeneralFundBalance ||
                    (this.TotalGeneralFundBalance != null &&
                    this.TotalGeneralFundBalance.Equals(input.TotalGeneralFundBalance))
                ) && 
                (
                    this.NonSpendableGovernmentalFundBalance == input.NonSpendableGovernmentalFundBalance ||
                    (this.NonSpendableGovernmentalFundBalance != null &&
                    this.NonSpendableGovernmentalFundBalance.Equals(input.NonSpendableGovernmentalFundBalance))
                ) && 
                (
                    this.RestrictedGovernmentalFundBalance == input.RestrictedGovernmentalFundBalance ||
                    (this.RestrictedGovernmentalFundBalance != null &&
                    this.RestrictedGovernmentalFundBalance.Equals(input.RestrictedGovernmentalFundBalance))
                ) && 
                (
                    this.CommittedGovernmentalFundBalance == input.CommittedGovernmentalFundBalance ||
                    (this.CommittedGovernmentalFundBalance != null &&
                    this.CommittedGovernmentalFundBalance.Equals(input.CommittedGovernmentalFundBalance))
                ) && 
                (
                    this.UnassignedGovernmentalFundBalance == input.UnassignedGovernmentalFundBalance ||
                    (this.UnassignedGovernmentalFundBalance != null &&
                    this.UnassignedGovernmentalFundBalance.Equals(input.UnassignedGovernmentalFundBalance))
                ) && 
                (
                    this.AssignedGovernmentalFundBalance == input.AssignedGovernmentalFundBalance ||
                    (this.AssignedGovernmentalFundBalance != null &&
                    this.AssignedGovernmentalFundBalance.Equals(input.AssignedGovernmentalFundBalance))
                ) && 
                (
                    this.TotalGovernmentalFundBalance == input.TotalGovernmentalFundBalance ||
                    (this.TotalGovernmentalFundBalance != null &&
                    this.TotalGovernmentalFundBalance.Equals(input.TotalGovernmentalFundBalance))
                ) && 
                (
                    this.GeneralFundRevenues == input.GeneralFundRevenues ||
                    (this.GeneralFundRevenues != null &&
                    this.GeneralFundRevenues.Equals(input.GeneralFundRevenues))
                ) && 
                (
                    this.GeneralFundExpenditures == input.GeneralFundExpenditures ||
                    (this.GeneralFundExpenditures != null &&
                    this.GeneralFundExpenditures.Equals(input.GeneralFundExpenditures))
                ) && 
                (
                    this.GeneralFundRevenuesOverUnderExpenditure == input.GeneralFundRevenuesOverUnderExpenditure ||
                    (this.GeneralFundRevenuesOverUnderExpenditure != null &&
                    this.GeneralFundRevenuesOverUnderExpenditure.Equals(input.GeneralFundRevenuesOverUnderExpenditure))
                ) && 
                (
                    this.GovernmentalFundRevenues == input.GovernmentalFundRevenues ||
                    (this.GovernmentalFundRevenues != null &&
                    this.GovernmentalFundRevenues.Equals(input.GovernmentalFundRevenues))
                ) && 
                (
                    this.GovernmentalFundExpenditures == input.GovernmentalFundExpenditures ||
                    (this.GovernmentalFundExpenditures != null &&
                    this.GovernmentalFundExpenditures.Equals(input.GovernmentalFundExpenditures))
                ) && 
                (
                    this.GovernmentalFundRevenuesOverUnderExpenditure == input.GovernmentalFundRevenuesOverUnderExpenditure ||
                    (this.GovernmentalFundRevenuesOverUnderExpenditure != null &&
                    this.GovernmentalFundRevenuesOverUnderExpenditure.Equals(input.GovernmentalFundRevenuesOverUnderExpenditure))
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
                if (this.FiscalYear != null)
                    hashCode = hashCode * 59 + this.FiscalYear.GetHashCode();
                if (this.CurrentAssets != null)
                    hashCode = hashCode * 59 + this.CurrentAssets.GetHashCode();
                if (this.NonCurrentAssets != null)
                    hashCode = hashCode * 59 + this.NonCurrentAssets.GetHashCode();
                if (this.DeferredOutflows != null)
                    hashCode = hashCode * 59 + this.DeferredOutflows.GetHashCode();
                if (this.TotalAssets != null)
                    hashCode = hashCode * 59 + this.TotalAssets.GetHashCode();
                if (this.TotalAssetsPlusDeferredOutflows != null)
                    hashCode = hashCode * 59 + this.TotalAssetsPlusDeferredOutflows.GetHashCode();
                if (this.CurrentLiabilities != null)
                    hashCode = hashCode * 59 + this.CurrentLiabilities.GetHashCode();
                if (this.CurrentPortionOfLongTermDebt != null)
                    hashCode = hashCode * 59 + this.CurrentPortionOfLongTermDebt.GetHashCode();
                if (this.NetPensionLiability != null)
                    hashCode = hashCode * 59 + this.NetPensionLiability.GetHashCode();
                if (this.NetOpebLiability != null)
                    hashCode = hashCode * 59 + this.NetOpebLiability.GetHashCode();
                if (this.AllOtherLongTermDebt != null)
                    hashCode = hashCode * 59 + this.AllOtherLongTermDebt.GetHashCode();
                if (this.TotalLiabilities != null)
                    hashCode = hashCode * 59 + this.TotalLiabilities.GetHashCode();
                if (this.DeferredInflows != null)
                    hashCode = hashCode * 59 + this.DeferredInflows.GetHashCode();
                if (this.TotalLiabilitiesPlusDeferredInflows != null)
                    hashCode = hashCode * 59 + this.TotalLiabilitiesPlusDeferredInflows.GetHashCode();
                if (this.TotalNetPosition != null)
                    hashCode = hashCode * 59 + this.TotalNetPosition.GetHashCode();
                if (this.TotalUnrestrictedNetPosition != null)
                    hashCode = hashCode * 59 + this.TotalUnrestrictedNetPosition.GetHashCode();
                if (this.TotalExpenses != null)
                    hashCode = hashCode * 59 + this.TotalExpenses.GetHashCode();
                if (this.ChargesForServices != null)
                    hashCode = hashCode * 59 + this.ChargesForServices.GetHashCode();
                if (this.OperatingGrantsAndContributions != null)
                    hashCode = hashCode * 59 + this.OperatingGrantsAndContributions.GetHashCode();
                if (this.CapitalGrantsAndContributions != null)
                    hashCode = hashCode * 59 + this.CapitalGrantsAndContributions.GetHashCode();
                if (this.GeneralRevenues != null)
                    hashCode = hashCode * 59 + this.GeneralRevenues.GetHashCode();
                if (this.OtherRevenues != null)
                    hashCode = hashCode * 59 + this.OtherRevenues.GetHashCode();
                if (this.TotalRevenues != null)
                    hashCode = hashCode * 59 + this.TotalRevenues.GetHashCode();
                if (this.ChangeInNetAssets != null)
                    hashCode = hashCode * 59 + this.ChangeInNetAssets.GetHashCode();
                if (this.NonSpendableGeneralFundBalance != null)
                    hashCode = hashCode * 59 + this.NonSpendableGeneralFundBalance.GetHashCode();
                if (this.RestrictedGeneralFundBalance != null)
                    hashCode = hashCode * 59 + this.RestrictedGeneralFundBalance.GetHashCode();
                if (this.CommittedGeneralFundBalance != null)
                    hashCode = hashCode * 59 + this.CommittedGeneralFundBalance.GetHashCode();
                if (this.UnassignedGeneralFundBalance != null)
                    hashCode = hashCode * 59 + this.UnassignedGeneralFundBalance.GetHashCode();
                if (this.AssignedGeneralFundBalance != null)
                    hashCode = hashCode * 59 + this.AssignedGeneralFundBalance.GetHashCode();
                if (this.TotalGeneralFundBalance != null)
                    hashCode = hashCode * 59 + this.TotalGeneralFundBalance.GetHashCode();
                if (this.NonSpendableGovernmentalFundBalance != null)
                    hashCode = hashCode * 59 + this.NonSpendableGovernmentalFundBalance.GetHashCode();
                if (this.RestrictedGovernmentalFundBalance != null)
                    hashCode = hashCode * 59 + this.RestrictedGovernmentalFundBalance.GetHashCode();
                if (this.CommittedGovernmentalFundBalance != null)
                    hashCode = hashCode * 59 + this.CommittedGovernmentalFundBalance.GetHashCode();
                if (this.UnassignedGovernmentalFundBalance != null)
                    hashCode = hashCode * 59 + this.UnassignedGovernmentalFundBalance.GetHashCode();
                if (this.AssignedGovernmentalFundBalance != null)
                    hashCode = hashCode * 59 + this.AssignedGovernmentalFundBalance.GetHashCode();
                if (this.TotalGovernmentalFundBalance != null)
                    hashCode = hashCode * 59 + this.TotalGovernmentalFundBalance.GetHashCode();
                if (this.GeneralFundRevenues != null)
                    hashCode = hashCode * 59 + this.GeneralFundRevenues.GetHashCode();
                if (this.GeneralFundExpenditures != null)
                    hashCode = hashCode * 59 + this.GeneralFundExpenditures.GetHashCode();
                if (this.GeneralFundRevenuesOverUnderExpenditure != null)
                    hashCode = hashCode * 59 + this.GeneralFundRevenuesOverUnderExpenditure.GetHashCode();
                if (this.GovernmentalFundRevenues != null)
                    hashCode = hashCode * 59 + this.GovernmentalFundRevenues.GetHashCode();
                if (this.GovernmentalFundExpenditures != null)
                    hashCode = hashCode * 59 + this.GovernmentalFundExpenditures.GetHashCode();
                if (this.GovernmentalFundRevenuesOverUnderExpenditure != null)
                    hashCode = hashCode * 59 + this.GovernmentalFundRevenuesOverUnderExpenditure.GetHashCode();
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
