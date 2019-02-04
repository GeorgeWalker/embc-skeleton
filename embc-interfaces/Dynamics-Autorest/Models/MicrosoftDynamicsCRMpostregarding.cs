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
    /// postregarding
    /// </summary>
    public partial class MicrosoftDynamicsCRMpostregarding
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMpostregarding
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMpostregarding()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMpostregarding
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMpostregarding(string postregardingid = default(string), string _regardingobjectidValue = default(string), string _regardingobjectowningbusinessunitValue = default(string), System.DateTimeOffset? latestmanualpostmodifiedon = default(System.DateTimeOffset?), string _regardingobjectowneridValue = default(string), System.DateTimeOffset? latestautopostmodifiedon = default(System.DateTimeOffset?), string regardingobjecttypecodeforsharing = default(string), MicrosoftDynamicsCRMtask regardingobjectidTask = default(MicrosoftDynamicsCRMtask), MicrosoftDynamicsCRMappointment regardingobjectidAppointment = default(MicrosoftDynamicsCRMappointment), MicrosoftDynamicsCRMphonecall regardingobjectidPhonecall = default(MicrosoftDynamicsCRMphonecall), MicrosoftDynamicsCRMincident regardingobjectidIncident = default(MicrosoftDynamicsCRMincident), MicrosoftDynamicsCRMrecurringappointmentmaster regardingobjectidRecurringappointmentmaster = default(MicrosoftDynamicsCRMrecurringappointmentmaster), IList<MicrosoftDynamicsCRMpost> postPostRegardings = default(IList<MicrosoftDynamicsCRMpost>), MicrosoftDynamicsCRMaccount regardingobjectidAccount = default(MicrosoftDynamicsCRMaccount), MicrosoftDynamicsCRMsystemuser regardingobjectidSystemuser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMbusinessunit regardingobjectowningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), MicrosoftDynamicsCRMcontact regardingobjectidContact = default(MicrosoftDynamicsCRMcontact), MicrosoftDynamicsCRMopportunity regardingobjectidOpportunity = default(MicrosoftDynamicsCRMopportunity), MicrosoftDynamicsCRMlead regardingobjectidLead = default(MicrosoftDynamicsCRMlead), MicrosoftDynamicsCRMteam regardingobjectidTeam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMknowledgearticle regardingobjectidKnowledgearticle = default(MicrosoftDynamicsCRMknowledgearticle), MicrosoftDynamicsCRMqueue regardingobjectidQueue = default(MicrosoftDynamicsCRMqueue), MicrosoftDynamicsCRMcompetitor regardingobjectidCompetitor = default(MicrosoftDynamicsCRMcompetitor))
        {
            Postregardingid = postregardingid;
            this._regardingobjectidValue = _regardingobjectidValue;
            this._regardingobjectowningbusinessunitValue = _regardingobjectowningbusinessunitValue;
            Latestmanualpostmodifiedon = latestmanualpostmodifiedon;
            this._regardingobjectowneridValue = _regardingobjectowneridValue;
            Latestautopostmodifiedon = latestautopostmodifiedon;
            Regardingobjecttypecodeforsharing = regardingobjecttypecodeforsharing;
            RegardingobjectidTask = regardingobjectidTask;
            RegardingobjectidAppointment = regardingobjectidAppointment;
            RegardingobjectidPhonecall = regardingobjectidPhonecall;
            RegardingobjectidIncident = regardingobjectidIncident;
            RegardingobjectidRecurringappointmentmaster = regardingobjectidRecurringappointmentmaster;
            PostPostRegardings = postPostRegardings;
            RegardingobjectidAccount = regardingobjectidAccount;
            RegardingobjectidSystemuser = regardingobjectidSystemuser;
            Regardingobjectowningbusinessunit = regardingobjectowningbusinessunit;
            RegardingobjectidContact = regardingobjectidContact;
            RegardingobjectidOpportunity = regardingobjectidOpportunity;
            RegardingobjectidLead = regardingobjectidLead;
            RegardingobjectidTeam = regardingobjectidTeam;
            RegardingobjectidKnowledgearticle = regardingobjectidKnowledgearticle;
            RegardingobjectidQueue = regardingobjectidQueue;
            RegardingobjectidCompetitor = regardingobjectidCompetitor;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "postregardingid")]
        public string Postregardingid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_regardingobjectid_value")]
        public string _regardingobjectidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_regardingobjectowningbusinessunit_value")]
        public string _regardingobjectowningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "latestmanualpostmodifiedon")]
        public System.DateTimeOffset? Latestmanualpostmodifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_regardingobjectownerid_value")]
        public string _regardingobjectowneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "latestautopostmodifiedon")]
        public System.DateTimeOffset? Latestautopostmodifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjecttypecodeforsharing")]
        public string Regardingobjecttypecodeforsharing { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_task")]
        public MicrosoftDynamicsCRMtask RegardingobjectidTask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_appointment")]
        public MicrosoftDynamicsCRMappointment RegardingobjectidAppointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_phonecall")]
        public MicrosoftDynamicsCRMphonecall RegardingobjectidPhonecall { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_incident")]
        public MicrosoftDynamicsCRMincident RegardingobjectidIncident { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_recurringappointmentmaster")]
        public MicrosoftDynamicsCRMrecurringappointmentmaster RegardingobjectidRecurringappointmentmaster { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "post_PostRegardings")]
        public IList<MicrosoftDynamicsCRMpost> PostPostRegardings { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_account")]
        public MicrosoftDynamicsCRMaccount RegardingobjectidAccount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_systemuser")]
        public MicrosoftDynamicsCRMsystemuser RegardingobjectidSystemuser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectowningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Regardingobjectowningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_contact")]
        public MicrosoftDynamicsCRMcontact RegardingobjectidContact { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_opportunity")]
        public MicrosoftDynamicsCRMopportunity RegardingobjectidOpportunity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_lead")]
        public MicrosoftDynamicsCRMlead RegardingobjectidLead { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_team")]
        public MicrosoftDynamicsCRMteam RegardingobjectidTeam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_knowledgearticle")]
        public MicrosoftDynamicsCRMknowledgearticle RegardingobjectidKnowledgearticle { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_queue")]
        public MicrosoftDynamicsCRMqueue RegardingobjectidQueue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_competitor")]
        public MicrosoftDynamicsCRMcompetitor RegardingobjectidCompetitor { get; set; }

    }
}
