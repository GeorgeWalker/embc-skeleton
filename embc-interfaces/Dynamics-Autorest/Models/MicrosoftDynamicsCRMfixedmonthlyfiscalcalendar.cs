// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Jag.Embc.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// fixedmonthlyfiscalcalendar
    /// </summary>
    public partial class MicrosoftDynamicsCRMfixedmonthlyfiscalcalendar
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMfixedmonthlyfiscalcalendar class.
        /// </summary>
        public MicrosoftDynamicsCRMfixedmonthlyfiscalcalendar()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMfixedmonthlyfiscalcalendar class.
        /// </summary>
        public MicrosoftDynamicsCRMfixedmonthlyfiscalcalendar(string _modifiedonbehalfbyValue = default(string), object period10 = default(object), object period5Base = default(object), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string userfiscalcalendarid = default(string), string _businessunitidValue = default(string), object period13Base = default(object), object period11Base = default(object), string _salespersonidValue = default(string), object period11 = default(object), object period12 = default(object), string _transactioncurrencyidValue = default(string), object period9Base = default(object), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), object period13 = default(object), object period5 = default(object), object period2 = default(object), int? utcconversiontimezonecode = default(int?), object period2Base = default(object), object period1 = default(object), object period8Base = default(object), object period7 = default(object), object period3Base = default(object), object exchangerate = default(object), object period8 = default(object), object period9 = default(object), object period3 = default(object), object period4Base = default(object), int? fiscalperiodtype = default(int?), object period1Base = default(object), string _createdonbehalfbyValue = default(string), System.DateTimeOffset? effectiveon = default(System.DateTimeOffset?), object period10Base = default(object), string _createdbyValue = default(string), object period6 = default(object), object period4 = default(object), string _modifiedbyValue = default(string), int? timezoneruleversionnumber = default(int?), object period12Base = default(object), object period6Base = default(object), object period7Base = default(object), IList<MicrosoftDynamicsCRMbulkdeletefailure> fixedMonthlyFiscalCalendarBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMasyncoperation> fixedMonthlyFiscalCalendarAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), MicrosoftDynamicsCRMsystemuser salespersonid = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser))
        {
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Period10 = period10;
            Period5Base = period5Base;
            Createdon = createdon;
            Userfiscalcalendarid = userfiscalcalendarid;
            this._businessunitidValue = _businessunitidValue;
            Period13Base = period13Base;
            Period11Base = period11Base;
            this._salespersonidValue = _salespersonidValue;
            Period11 = period11;
            Period12 = period12;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            Period9Base = period9Base;
            Modifiedon = modifiedon;
            Period13 = period13;
            Period5 = period5;
            Period2 = period2;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Period2Base = period2Base;
            Period1 = period1;
            Period8Base = period8Base;
            Period7 = period7;
            Period3Base = period3Base;
            Exchangerate = exchangerate;
            Period8 = period8;
            Period9 = period9;
            Period3 = period3;
            Period4Base = period4Base;
            Fiscalperiodtype = fiscalperiodtype;
            Period1Base = period1Base;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Effectiveon = effectiveon;
            Period10Base = period10Base;
            this._createdbyValue = _createdbyValue;
            Period6 = period6;
            Period4 = period4;
            this._modifiedbyValue = _modifiedbyValue;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Period12Base = period12Base;
            Period6Base = period6Base;
            Period7Base = period7Base;
            FixedMonthlyFiscalCalendarBulkDeleteFailures = fixedMonthlyFiscalCalendarBulkDeleteFailures;
            Transactioncurrencyid = transactioncurrencyid;
            Createdonbehalfby = createdonbehalfby;
            Createdby = createdby;
            Modifiedby = modifiedby;
            FixedMonthlyFiscalCalendarAsyncOperations = fixedMonthlyFiscalCalendarAsyncOperations;
            Salespersonid = salespersonid;
            Modifiedonbehalfby = modifiedonbehalfby;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "period10")]
        public object Period10 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "period5_base")]
        public object Period5Base { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "userfiscalcalendarid")]
        public string Userfiscalcalendarid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_businessunitid_value")]
        public string _businessunitidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "period13_base")]
        public object Period13Base { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "period11_base")]
        public object Period11Base { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_salespersonid_value")]
        public string _salespersonidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "period11")]
        public object Period11 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "period12")]
        public object Period12 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "period9_base")]
        public object Period9Base { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "period13")]
        public object Period13 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "period5")]
        public object Period5 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "period2")]
        public object Period2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "period2_base")]
        public object Period2Base { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "period1")]
        public object Period1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "period8_base")]
        public object Period8Base { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "period7")]
        public object Period7 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "period3_base")]
        public object Period3Base { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public object Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "period8")]
        public object Period8 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "period9")]
        public object Period9 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "period3")]
        public object Period3 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "period4_base")]
        public object Period4Base { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fiscalperiodtype")]
        public int? Fiscalperiodtype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "period1_base")]
        public object Period1Base { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "effectiveon")]
        public System.DateTimeOffset? Effectiveon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "period10_base")]
        public object Period10Base { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "period6")]
        public object Period6 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "period4")]
        public object Period4 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "period12_base")]
        public object Period12Base { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "period6_base")]
        public object Period6Base { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "period7_base")]
        public object Period7Base { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FixedMonthlyFiscalCalendar_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> FixedMonthlyFiscalCalendarBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FixedMonthlyFiscalCalendar_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> FixedMonthlyFiscalCalendarAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "salespersonid")]
        public MicrosoftDynamicsCRMsystemuser Salespersonid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

    }
}
