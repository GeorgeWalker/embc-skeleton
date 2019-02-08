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
    using System.Linq; using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// principal
    /// </summary>
    public partial class MicrosoftDynamicsCRMprincipal
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMprincipal
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMprincipal()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMprincipal
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMprincipal(string ownerid = default(string), IList<MicrosoftDynamicsCRMgovCommunity> ownerGovCommunity = default(IList<MicrosoftDynamicsCRMgovCommunity>), IList<MicrosoftDynamicsCRMgovIncidenttask> ownerGovIncidenttask = default(IList<MicrosoftDynamicsCRMgovIncidenttask>), IList<MicrosoftDynamicsCRMgovRegistration> ownerGovRegistration = default(IList<MicrosoftDynamicsCRMgovRegistration>), IList<MicrosoftDynamicsCRMlead> ownerLeads = default(IList<MicrosoftDynamicsCRMlead>), IList<MicrosoftDynamicsCRMdynamicpropertyinstance> ownerDynamicproperyinstance = default(IList<MicrosoftDynamicsCRMdynamicpropertyinstance>), IList<MicrosoftDynamicsCRMbookableresource> ownerBookableresource = default(IList<MicrosoftDynamicsCRMbookableresource>), IList<MicrosoftDynamicsCRMbookableresourcebooking> ownerBookableresourcebooking = default(IList<MicrosoftDynamicsCRMbookableresourcebooking>), IList<MicrosoftDynamicsCRMbookableresourcebookingheader> ownerBookableresourcebookingheader = default(IList<MicrosoftDynamicsCRMbookableresourcebookingheader>), IList<MicrosoftDynamicsCRMbookableresourcecategory> ownerBookableresourcecategory = default(IList<MicrosoftDynamicsCRMbookableresourcecategory>), IList<MicrosoftDynamicsCRMbookableresourcecategoryassn> ownerBookableresourcecategoryassn = default(IList<MicrosoftDynamicsCRMbookableresourcecategoryassn>), IList<MicrosoftDynamicsCRMbookableresourcecharacteristic> ownerBookableresourcecharacteristic = default(IList<MicrosoftDynamicsCRMbookableresourcecharacteristic>), IList<MicrosoftDynamicsCRMbookableresourcegroup> ownerBookableresourcegroup = default(IList<MicrosoftDynamicsCRMbookableresourcegroup>), IList<MicrosoftDynamicsCRMbookingstatus> ownerBookingstatus = default(IList<MicrosoftDynamicsCRMbookingstatus>), IList<MicrosoftDynamicsCRMcharacteristic> ownerCharacteristic = default(IList<MicrosoftDynamicsCRMcharacteristic>), IList<MicrosoftDynamicsCRMratingmodel> ownerRatingmodel = default(IList<MicrosoftDynamicsCRMratingmodel>), IList<MicrosoftDynamicsCRMratingvalue> ownerRatingvalue = default(IList<MicrosoftDynamicsCRMratingvalue>), IList<MicrosoftDynamicsCRMbulkoperation> bulkoperationOwnerOwnerid = default(IList<MicrosoftDynamicsCRMbulkoperation>), IList<MicrosoftDynamicsCRMcampaign> ownerCampaigns = default(IList<MicrosoftDynamicsCRMcampaign>), IList<MicrosoftDynamicsCRMcampaignactivity> campaignactivityOwnerOwnerid = default(IList<MicrosoftDynamicsCRMcampaignactivity>), IList<MicrosoftDynamicsCRMcampaignresponse> campaignresponseOwnerOwnerid = default(IList<MicrosoftDynamicsCRMcampaignresponse>), IList<MicrosoftDynamicsCRMlist> ownerLists = default(IList<MicrosoftDynamicsCRMlist>), IList<MicrosoftDynamicsCRMcontract> ownerContracts = default(IList<MicrosoftDynamicsCRMcontract>), IList<MicrosoftDynamicsCRMentitlement> ownerEntitlement = default(IList<MicrosoftDynamicsCRMentitlement>), IList<MicrosoftDynamicsCRMincident> ownerIncidents = default(IList<MicrosoftDynamicsCRMincident>), IList<MicrosoftDynamicsCRMincidentresolution> incidentresolutionOwnerOwnerid = default(IList<MicrosoftDynamicsCRMincidentresolution>), IList<MicrosoftDynamicsCRMserviceappointment> serviceappointmentOwnerOwnerid = default(IList<MicrosoftDynamicsCRMserviceappointment>), IList<MicrosoftDynamicsCRMentitlemententityallocationtypemapping> ownerEntitlemententityallocationtypemapping = default(IList<MicrosoftDynamicsCRMentitlemententityallocationtypemapping>), IList<MicrosoftDynamicsCRMmsdynCallablecontext> ownerMsdynCallablecontext = default(IList<MicrosoftDynamicsCRMmsdynCallablecontext>), IList<MicrosoftDynamicsCRMmsdynPlaybookactivity> ownerMsdynPlaybookactivity = default(IList<MicrosoftDynamicsCRMmsdynPlaybookactivity>), IList<MicrosoftDynamicsCRMmsdynPlaybookactivityattribute> ownerMsdynPlaybookactivityattribute = default(IList<MicrosoftDynamicsCRMmsdynPlaybookactivityattribute>), IList<MicrosoftDynamicsCRMmsdynPlaybookcategory> ownerMsdynPlaybookcategory = default(IList<MicrosoftDynamicsCRMmsdynPlaybookcategory>), IList<MicrosoftDynamicsCRMmsdynPlaybookinstance> ownerMsdynPlaybookinstance = default(IList<MicrosoftDynamicsCRMmsdynPlaybookinstance>), IList<MicrosoftDynamicsCRMmsdynPlaybooktemplate> ownerMsdynPlaybooktemplate = default(IList<MicrosoftDynamicsCRMmsdynPlaybooktemplate>), IList<MicrosoftDynamicsCRMinvoice> ownerInvoices = default(IList<MicrosoftDynamicsCRMinvoice>), IList<MicrosoftDynamicsCRMopportunity> ownerOpportunitys = default(IList<MicrosoftDynamicsCRMopportunity>), IList<MicrosoftDynamicsCRMopportunityclose> opportunitycloseOwnerOwnerid = default(IList<MicrosoftDynamicsCRMopportunityclose>), IList<MicrosoftDynamicsCRMorderclose> ordercloseOwnerOwnerid = default(IList<MicrosoftDynamicsCRMorderclose>), IList<MicrosoftDynamicsCRMquote> ownerQuotes = default(IList<MicrosoftDynamicsCRMquote>), IList<MicrosoftDynamicsCRMquoteclose> quotecloseOwnerOwnerid = default(IList<MicrosoftDynamicsCRMquoteclose>), IList<MicrosoftDynamicsCRMsalesorder> ownerSalesorders = default(IList<MicrosoftDynamicsCRMsalesorder>), IList<MicrosoftDynamicsCRMadminsettingsentity> ownerAdminsettingsentity = default(IList<MicrosoftDynamicsCRMadminsettingsentity>), IList<MicrosoftDynamicsCRMmsdynRelationshipinsightsunifiedconfig> ownerMsdynRelationshipinsightsunifiedconfig = default(IList<MicrosoftDynamicsCRMmsdynRelationshipinsightsunifiedconfig>), IList<MicrosoftDynamicsCRMmsdynSiconfig> ownerMsdynSiconfig = default(IList<MicrosoftDynamicsCRMmsdynSiconfig>), IList<MicrosoftDynamicsCRMmsdynUntrackedappointment> ownerMsdynUntrackedappointment = default(IList<MicrosoftDynamicsCRMmsdynUntrackedappointment>), IList<MicrosoftDynamicsCRMmsdynNotesanalysisconfig> ownerMsdynNotesanalysisconfig = default(IList<MicrosoftDynamicsCRMmsdynNotesanalysisconfig>), IList<MicrosoftDynamicsCRMmsdynIcebreakersconfig> ownerMsdynIcebreakersconfig = default(IList<MicrosoftDynamicsCRMmsdynIcebreakersconfig>), IList<MicrosoftDynamicsCRMmsdynPostalbum> ownerMsdynPostalbum = default(IList<MicrosoftDynamicsCRMmsdynPostalbum>), IList<MicrosoftDynamicsCRMmsdynWallsavedqueryusersettings> ownerMsdynWallsavedqueryusersettings = default(IList<MicrosoftDynamicsCRMmsdynWallsavedqueryusersettings>), IList<MicrosoftDynamicsCRMexchangesyncidmapping> ownerExchangesyncidmapping = default(IList<MicrosoftDynamicsCRMexchangesyncidmapping>), IList<MicrosoftDynamicsCRMinteractionforemail> ownerNewInteractionforemail = default(IList<MicrosoftDynamicsCRMinteractionforemail>), IList<MicrosoftDynamicsCRMknowledgearticle> ownerKnowledgearticle = default(IList<MicrosoftDynamicsCRMknowledgearticle>), IList<MicrosoftDynamicsCRMsharepointsite> ownerSharepointsite = default(IList<MicrosoftDynamicsCRMsharepointsite>), IList<MicrosoftDynamicsCRMsharepointdocumentlocation> ownerSharepointdocumentlocation = default(IList<MicrosoftDynamicsCRMsharepointdocumentlocation>), IList<MicrosoftDynamicsCRMgoal> ownerGoal = default(IList<MicrosoftDynamicsCRMgoal>), IList<MicrosoftDynamicsCRMmailbox> ownerMailbox = default(IList<MicrosoftDynamicsCRMmailbox>), IList<MicrosoftDynamicsCRMpersonaldocumenttemplate> ownerPersonaldocumenttemplates = default(IList<MicrosoftDynamicsCRMpersonaldocumenttemplate>), IList<MicrosoftDynamicsCRMaccount> ownerAccounts = default(IList<MicrosoftDynamicsCRMaccount>), IList<MicrosoftDynamicsCRMgoalrollupquery> ownerGoalrollupquery = default(IList<MicrosoftDynamicsCRMgoalrollupquery>), IList<MicrosoftDynamicsCRMpostfollow> ownerPostfollows = default(IList<MicrosoftDynamicsCRMpostfollow>), IList<MicrosoftDynamicsCRMworkflow> ownerWorkflows = default(IList<MicrosoftDynamicsCRMworkflow>), IList<MicrosoftDynamicsCRMuserquery> ownerUserquerys = default(IList<MicrosoftDynamicsCRMuserquery>), IList<MicrosoftDynamicsCRMimportmap> ownerImportmaps = default(IList<MicrosoftDynamicsCRMimportmap>), IList<MicrosoftDynamicsCRMrecurrencerule> ownerRecurrencerules = default(IList<MicrosoftDynamicsCRMrecurrencerule>), IList<MicrosoftDynamicsCRMmailmergetemplate> ownerMailmergetemplates = default(IList<MicrosoftDynamicsCRMmailmergetemplate>), IList<MicrosoftDynamicsCRMduplicaterule> ownerDuplicaterules = default(IList<MicrosoftDynamicsCRMduplicaterule>), IList<MicrosoftDynamicsCRMreport> ownerReports = default(IList<MicrosoftDynamicsCRMreport>), IList<MicrosoftDynamicsCRMactivitypointer> ownerActivitypointers = default(IList<MicrosoftDynamicsCRMactivitypointer>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> ownerMailboxtrackingfolder = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMactioncarduserstate> actionCardUserStateOwner = default(IList<MicrosoftDynamicsCRMactioncarduserstate>), IList<MicrosoftDynamicsCRMprincipalentitymap> ownerPrincipalentitymap = default(IList<MicrosoftDynamicsCRMprincipalentitymap>), IList<MicrosoftDynamicsCRMimportdata> ownerImportdatas = default(IList<MicrosoftDynamicsCRMimportdata>), IList<MicrosoftDynamicsCRMcategory> ownerCategories = default(IList<MicrosoftDynamicsCRMcategory>), IList<MicrosoftDynamicsCRMqueue> ownerQueues = default(IList<MicrosoftDynamicsCRMqueue>), IList<MicrosoftDynamicsCRMactioncard> ownerActioncards = default(IList<MicrosoftDynamicsCRMactioncard>), IList<MicrosoftDynamicsCRMuserqueryvisualization> ownerUserqueryvisualizations = default(IList<MicrosoftDynamicsCRMuserqueryvisualization>), IList<MicrosoftDynamicsCRMfeedback> ownerFeedback = default(IList<MicrosoftDynamicsCRMfeedback>), IList<MicrosoftDynamicsCRMannotation> ownerAnnotations = default(IList<MicrosoftDynamicsCRMannotation>), IList<MicrosoftDynamicsCRMuserform> ownerUserform = default(IList<MicrosoftDynamicsCRMuserform>), IList<MicrosoftDynamicsCRMasyncoperation> ownerAsyncoperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMsocialprofile> ownerSocialProfile = default(IList<MicrosoftDynamicsCRMsocialprofile>), IList<MicrosoftDynamicsCRMprocesssession> ownerProcesssessions = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMsla> ownerSlas = default(IList<MicrosoftDynamicsCRMsla>), IList<MicrosoftDynamicsCRMslakpiinstance> slakpiinstanceOwner = default(IList<MicrosoftDynamicsCRMslakpiinstance>), IList<MicrosoftDynamicsCRMemailserverprofile> ownerEmailserverprofile = default(IList<MicrosoftDynamicsCRMemailserverprofile>), IList<MicrosoftDynamicsCRMtemplate> ownerTemplates = default(IList<MicrosoftDynamicsCRMtemplate>), IList<MicrosoftDynamicsCRMcontact> ownerContacts = default(IList<MicrosoftDynamicsCRMcontact>), IList<MicrosoftDynamicsCRMimport> ownerImports = default(IList<MicrosoftDynamicsCRMimport>), IList<MicrosoftDynamicsCRMconnection> ownerConnections = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMimportfile> ownerImportfiles = default(IList<MicrosoftDynamicsCRMimportfile>), IList<MicrosoftDynamicsCRMimportlog> ownerImportlogs = default(IList<MicrosoftDynamicsCRMimportlog>), IList<MicrosoftDynamicsCRMsyncerror> ownerSyncError = default(IList<MicrosoftDynamicsCRMsyncerror>))
        {
            Ownerid = ownerid;
            OwnerGovCommunity = ownerGovCommunity;
            OwnerGovIncidenttask = ownerGovIncidenttask;
            OwnerGovRegistration = ownerGovRegistration;
            OwnerLeads = ownerLeads;
            OwnerDynamicproperyinstance = ownerDynamicproperyinstance;
            OwnerBookableresource = ownerBookableresource;
            OwnerBookableresourcebooking = ownerBookableresourcebooking;
            OwnerBookableresourcebookingheader = ownerBookableresourcebookingheader;
            OwnerBookableresourcecategory = ownerBookableresourcecategory;
            OwnerBookableresourcecategoryassn = ownerBookableresourcecategoryassn;
            OwnerBookableresourcecharacteristic = ownerBookableresourcecharacteristic;
            OwnerBookableresourcegroup = ownerBookableresourcegroup;
            OwnerBookingstatus = ownerBookingstatus;
            OwnerCharacteristic = ownerCharacteristic;
            OwnerRatingmodel = ownerRatingmodel;
            OwnerRatingvalue = ownerRatingvalue;
            BulkoperationOwnerOwnerid = bulkoperationOwnerOwnerid;
            OwnerCampaigns = ownerCampaigns;
            CampaignactivityOwnerOwnerid = campaignactivityOwnerOwnerid;
            CampaignresponseOwnerOwnerid = campaignresponseOwnerOwnerid;
            OwnerLists = ownerLists;
            OwnerContracts = ownerContracts;
            OwnerEntitlement = ownerEntitlement;
            OwnerIncidents = ownerIncidents;
            IncidentresolutionOwnerOwnerid = incidentresolutionOwnerOwnerid;
            ServiceappointmentOwnerOwnerid = serviceappointmentOwnerOwnerid;
            OwnerEntitlemententityallocationtypemapping = ownerEntitlemententityallocationtypemapping;
            OwnerMsdynCallablecontext = ownerMsdynCallablecontext;
            OwnerMsdynPlaybookactivity = ownerMsdynPlaybookactivity;
            OwnerMsdynPlaybookactivityattribute = ownerMsdynPlaybookactivityattribute;
            OwnerMsdynPlaybookcategory = ownerMsdynPlaybookcategory;
            OwnerMsdynPlaybookinstance = ownerMsdynPlaybookinstance;
            OwnerMsdynPlaybooktemplate = ownerMsdynPlaybooktemplate;
            OwnerInvoices = ownerInvoices;
            OwnerOpportunitys = ownerOpportunitys;
            OpportunitycloseOwnerOwnerid = opportunitycloseOwnerOwnerid;
            OrdercloseOwnerOwnerid = ordercloseOwnerOwnerid;
            OwnerQuotes = ownerQuotes;
            QuotecloseOwnerOwnerid = quotecloseOwnerOwnerid;
            OwnerSalesorders = ownerSalesorders;
            OwnerAdminsettingsentity = ownerAdminsettingsentity;
            OwnerMsdynRelationshipinsightsunifiedconfig = ownerMsdynRelationshipinsightsunifiedconfig;
            OwnerMsdynSiconfig = ownerMsdynSiconfig;
            OwnerMsdynUntrackedappointment = ownerMsdynUntrackedappointment;
            OwnerMsdynNotesanalysisconfig = ownerMsdynNotesanalysisconfig;
            OwnerMsdynIcebreakersconfig = ownerMsdynIcebreakersconfig;
            OwnerMsdynPostalbum = ownerMsdynPostalbum;
            OwnerMsdynWallsavedqueryusersettings = ownerMsdynWallsavedqueryusersettings;
            OwnerExchangesyncidmapping = ownerExchangesyncidmapping;
            OwnerNewInteractionforemail = ownerNewInteractionforemail;
            OwnerKnowledgearticle = ownerKnowledgearticle;
            OwnerSharepointsite = ownerSharepointsite;
            OwnerSharepointdocumentlocation = ownerSharepointdocumentlocation;
            OwnerGoal = ownerGoal;
            OwnerMailbox = ownerMailbox;
            OwnerPersonaldocumenttemplates = ownerPersonaldocumenttemplates;
            OwnerAccounts = ownerAccounts;
            OwnerGoalrollupquery = ownerGoalrollupquery;
            OwnerPostfollows = ownerPostfollows;
            OwnerWorkflows = ownerWorkflows;
            OwnerUserquerys = ownerUserquerys;
            OwnerImportmaps = ownerImportmaps;
            OwnerRecurrencerules = ownerRecurrencerules;
            OwnerMailmergetemplates = ownerMailmergetemplates;
            OwnerDuplicaterules = ownerDuplicaterules;
            OwnerReports = ownerReports;
            OwnerActivitypointers = ownerActivitypointers;
            OwnerMailboxtrackingfolder = ownerMailboxtrackingfolder;
            ActionCardUserStateOwner = actionCardUserStateOwner;
            OwnerPrincipalentitymap = ownerPrincipalentitymap;
            OwnerImportdatas = ownerImportdatas;
            OwnerCategories = ownerCategories;
            OwnerQueues = ownerQueues;
            OwnerActioncards = ownerActioncards;
            OwnerUserqueryvisualizations = ownerUserqueryvisualizations;
            OwnerFeedback = ownerFeedback;
            OwnerAnnotations = ownerAnnotations;
            OwnerUserform = ownerUserform;
            OwnerAsyncoperations = ownerAsyncoperations;
            OwnerSocialProfile = ownerSocialProfile;
            OwnerProcesssessions = ownerProcesssessions;
            OwnerSlas = ownerSlas;
            SlakpiinstanceOwner = slakpiinstanceOwner;
            OwnerEmailserverprofile = ownerEmailserverprofile;
            OwnerTemplates = ownerTemplates;
            OwnerContacts = ownerContacts;
            OwnerImports = ownerImports;
            OwnerConnections = ownerConnections;
            OwnerImportfiles = ownerImportfiles;
            OwnerImportlogs = ownerImportlogs;
            OwnerSyncError = ownerSyncError;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid")]
        public string Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner_gov_community")]
        [NotMapped] public IList<MicrosoftDynamicsCRMgovCommunity> OwnerGovCommunity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner_gov_incidenttask")]
        [NotMapped] public IList<MicrosoftDynamicsCRMgovIncidenttask> OwnerGovIncidenttask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner_gov_registration")]
        [NotMapped] public IList<MicrosoftDynamicsCRMgovRegistration> OwnerGovRegistration { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner_leads")]
        [NotMapped] public IList<MicrosoftDynamicsCRMlead> OwnerLeads { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Owner_dynamicproperyinstance")]
        [NotMapped] public IList<MicrosoftDynamicsCRMdynamicpropertyinstance> OwnerDynamicproperyinstance { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner_bookableresource")]
        [NotMapped] public IList<MicrosoftDynamicsCRMbookableresource> OwnerBookableresource { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner_bookableresourcebooking")]
        [NotMapped] public IList<MicrosoftDynamicsCRMbookableresourcebooking> OwnerBookableresourcebooking { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner_bookableresourcebookingheader")]
        [NotMapped] public IList<MicrosoftDynamicsCRMbookableresourcebookingheader> OwnerBookableresourcebookingheader { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner_bookableresourcecategory")]
        [NotMapped] public IList<MicrosoftDynamicsCRMbookableresourcecategory> OwnerBookableresourcecategory { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner_bookableresourcecategoryassn")]
        [NotMapped] public IList<MicrosoftDynamicsCRMbookableresourcecategoryassn> OwnerBookableresourcecategoryassn { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner_bookableresourcecharacteristic")]
        [NotMapped] public IList<MicrosoftDynamicsCRMbookableresourcecharacteristic> OwnerBookableresourcecharacteristic { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner_bookableresourcegroup")]
        [NotMapped] public IList<MicrosoftDynamicsCRMbookableresourcegroup> OwnerBookableresourcegroup { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner_bookingstatus")]
        [NotMapped] public IList<MicrosoftDynamicsCRMbookingstatus> OwnerBookingstatus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner_characteristic")]
        [NotMapped] public IList<MicrosoftDynamicsCRMcharacteristic> OwnerCharacteristic { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner_ratingmodel")]
        [NotMapped] public IList<MicrosoftDynamicsCRMratingmodel> OwnerRatingmodel { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner_ratingvalue")]
        [NotMapped] public IList<MicrosoftDynamicsCRMratingvalue> OwnerRatingvalue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bulkoperation_owner_ownerid")]
        [NotMapped] public IList<MicrosoftDynamicsCRMbulkoperation> BulkoperationOwnerOwnerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner_campaigns")]
        [NotMapped] public IList<MicrosoftDynamicsCRMcampaign> OwnerCampaigns { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "campaignactivity_owner_ownerid")]
        [NotMapped] public IList<MicrosoftDynamicsCRMcampaignactivity> CampaignactivityOwnerOwnerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "campaignresponse_owner_ownerid")]
        [NotMapped] public IList<MicrosoftDynamicsCRMcampaignresponse> CampaignresponseOwnerOwnerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner_lists")]
        [NotMapped] public IList<MicrosoftDynamicsCRMlist> OwnerLists { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner_contracts")]
        [NotMapped] public IList<MicrosoftDynamicsCRMcontract> OwnerContracts { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner_entitlement")]
        [NotMapped] public IList<MicrosoftDynamicsCRMentitlement> OwnerEntitlement { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner_incidents")]
        [NotMapped] public IList<MicrosoftDynamicsCRMincident> OwnerIncidents { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "incidentresolution_owner_ownerid")]
        [NotMapped] public IList<MicrosoftDynamicsCRMincidentresolution> IncidentresolutionOwnerOwnerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "serviceappointment_owner_ownerid")]
        [NotMapped] public IList<MicrosoftDynamicsCRMserviceappointment> ServiceappointmentOwnerOwnerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner_entitlemententityallocationtypemapping")]
        [NotMapped] public IList<MicrosoftDynamicsCRMentitlemententityallocationtypemapping> OwnerEntitlemententityallocationtypemapping { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner_msdyn_callablecontext")]
        [NotMapped] public IList<MicrosoftDynamicsCRMmsdynCallablecontext> OwnerMsdynCallablecontext { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner_msdyn_playbookactivity")]
        [NotMapped] public IList<MicrosoftDynamicsCRMmsdynPlaybookactivity> OwnerMsdynPlaybookactivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner_msdyn_playbookactivityattribute")]
        [NotMapped] public IList<MicrosoftDynamicsCRMmsdynPlaybookactivityattribute> OwnerMsdynPlaybookactivityattribute { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner_msdyn_playbookcategory")]
        [NotMapped] public IList<MicrosoftDynamicsCRMmsdynPlaybookcategory> OwnerMsdynPlaybookcategory { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner_msdyn_playbookinstance")]
        [NotMapped] public IList<MicrosoftDynamicsCRMmsdynPlaybookinstance> OwnerMsdynPlaybookinstance { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner_msdyn_playbooktemplate")]
        [NotMapped] public IList<MicrosoftDynamicsCRMmsdynPlaybooktemplate> OwnerMsdynPlaybooktemplate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner_invoices")]
        [NotMapped] public IList<MicrosoftDynamicsCRMinvoice> OwnerInvoices { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner_opportunitys")]
        [NotMapped] public IList<MicrosoftDynamicsCRMopportunity> OwnerOpportunitys { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "opportunityclose_owner_ownerid")]
        [NotMapped] public IList<MicrosoftDynamicsCRMopportunityclose> OpportunitycloseOwnerOwnerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "orderclose_owner_ownerid")]
        [NotMapped] public IList<MicrosoftDynamicsCRMorderclose> OrdercloseOwnerOwnerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner_quotes")]
        [NotMapped] public IList<MicrosoftDynamicsCRMquote> OwnerQuotes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quoteclose_owner_ownerid")]
        [NotMapped] public IList<MicrosoftDynamicsCRMquoteclose> QuotecloseOwnerOwnerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner_salesorders")]
        [NotMapped] public IList<MicrosoftDynamicsCRMsalesorder> OwnerSalesorders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner_adminsettingsentity")]
        [NotMapped] public IList<MicrosoftDynamicsCRMadminsettingsentity> OwnerAdminsettingsentity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner_msdyn_relationshipinsightsunifiedconfig")]
        [NotMapped] public IList<MicrosoftDynamicsCRMmsdynRelationshipinsightsunifiedconfig> OwnerMsdynRelationshipinsightsunifiedconfig { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner_msdyn_siconfig")]
        [NotMapped] public IList<MicrosoftDynamicsCRMmsdynSiconfig> OwnerMsdynSiconfig { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner_msdyn_untrackedappointment")]
        [NotMapped] public IList<MicrosoftDynamicsCRMmsdynUntrackedappointment> OwnerMsdynUntrackedappointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner_msdyn_notesanalysisconfig")]
        [NotMapped] public IList<MicrosoftDynamicsCRMmsdynNotesanalysisconfig> OwnerMsdynNotesanalysisconfig { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner_msdyn_icebreakersconfig")]
        [NotMapped] public IList<MicrosoftDynamicsCRMmsdynIcebreakersconfig> OwnerMsdynIcebreakersconfig { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner_msdyn_postalbum")]
        [NotMapped] public IList<MicrosoftDynamicsCRMmsdynPostalbum> OwnerMsdynPostalbum { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner_msdyn_wallsavedqueryusersettings")]
        [NotMapped] public IList<MicrosoftDynamicsCRMmsdynWallsavedqueryusersettings> OwnerMsdynWallsavedqueryusersettings { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner_exchangesyncidmapping")]
        [NotMapped] public IList<MicrosoftDynamicsCRMexchangesyncidmapping> OwnerExchangesyncidmapping { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner_new_interactionforemail")]
        [NotMapped] public IList<MicrosoftDynamicsCRMinteractionforemail> OwnerNewInteractionforemail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner_knowledgearticle")]
        [NotMapped] public IList<MicrosoftDynamicsCRMknowledgearticle> OwnerKnowledgearticle { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner_sharepointsite")]
        [NotMapped] public IList<MicrosoftDynamicsCRMsharepointsite> OwnerSharepointsite { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner_sharepointdocumentlocation")]
        [NotMapped] public IList<MicrosoftDynamicsCRMsharepointdocumentlocation> OwnerSharepointdocumentlocation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner_goal")]
        [NotMapped] public IList<MicrosoftDynamicsCRMgoal> OwnerGoal { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner_mailbox")]
        [NotMapped] public IList<MicrosoftDynamicsCRMmailbox> OwnerMailbox { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner_personaldocumenttemplates")]
        [NotMapped] public IList<MicrosoftDynamicsCRMpersonaldocumenttemplate> OwnerPersonaldocumenttemplates { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner_accounts")]
        [NotMapped] public IList<MicrosoftDynamicsCRMaccount> OwnerAccounts { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner_goalrollupquery")]
        [NotMapped] public IList<MicrosoftDynamicsCRMgoalrollupquery> OwnerGoalrollupquery { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner_postfollows")]
        [NotMapped] public IList<MicrosoftDynamicsCRMpostfollow> OwnerPostfollows { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner_workflows")]
        [NotMapped] public IList<MicrosoftDynamicsCRMworkflow> OwnerWorkflows { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner_userquerys")]
        [NotMapped] public IList<MicrosoftDynamicsCRMuserquery> OwnerUserquerys { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner_importmaps")]
        [NotMapped] public IList<MicrosoftDynamicsCRMimportmap> OwnerImportmaps { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner_recurrencerules")]
        [NotMapped] public IList<MicrosoftDynamicsCRMrecurrencerule> OwnerRecurrencerules { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner_mailmergetemplates")]
        [NotMapped] public IList<MicrosoftDynamicsCRMmailmergetemplate> OwnerMailmergetemplates { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner_duplicaterules")]
        [NotMapped] public IList<MicrosoftDynamicsCRMduplicaterule> OwnerDuplicaterules { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner_reports")]
        [NotMapped] public IList<MicrosoftDynamicsCRMreport> OwnerReports { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner_activitypointers")]
        [NotMapped] public IList<MicrosoftDynamicsCRMactivitypointer> OwnerActivitypointers { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner_mailboxtrackingfolder")]
        [NotMapped] public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> OwnerMailboxtrackingfolder { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ActionCardUserState_Owner")]
        [NotMapped] public IList<MicrosoftDynamicsCRMactioncarduserstate> ActionCardUserStateOwner { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner_principalentitymap")]
        [NotMapped] public IList<MicrosoftDynamicsCRMprincipalentitymap> OwnerPrincipalentitymap { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner_importdatas")]
        [NotMapped] public IList<MicrosoftDynamicsCRMimportdata> OwnerImportdatas { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner_categories")]
        [NotMapped] public IList<MicrosoftDynamicsCRMcategory> OwnerCategories { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner_queues")]
        [NotMapped] public IList<MicrosoftDynamicsCRMqueue> OwnerQueues { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner_actioncards")]
        [NotMapped] public IList<MicrosoftDynamicsCRMactioncard> OwnerActioncards { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner_userqueryvisualizations")]
        [NotMapped] public IList<MicrosoftDynamicsCRMuserqueryvisualization> OwnerUserqueryvisualizations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner_feedback")]
        [NotMapped] public IList<MicrosoftDynamicsCRMfeedback> OwnerFeedback { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner_annotations")]
        [NotMapped] public IList<MicrosoftDynamicsCRMannotation> OwnerAnnotations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner_userform")]
        [NotMapped] public IList<MicrosoftDynamicsCRMuserform> OwnerUserform { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner_asyncoperations")]
        [NotMapped] public IList<MicrosoftDynamicsCRMasyncoperation> OwnerAsyncoperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner_SocialProfile")]
        [NotMapped] public IList<MicrosoftDynamicsCRMsocialprofile> OwnerSocialProfile { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner_processsessions")]
        [NotMapped] public IList<MicrosoftDynamicsCRMprocesssession> OwnerProcesssessions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner_slas")]
        [NotMapped] public IList<MicrosoftDynamicsCRMsla> OwnerSlas { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "slakpiinstance_owner")]
        [NotMapped] public IList<MicrosoftDynamicsCRMslakpiinstance> SlakpiinstanceOwner { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner_emailserverprofile")]
        [NotMapped] public IList<MicrosoftDynamicsCRMemailserverprofile> OwnerEmailserverprofile { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner_templates")]
        [NotMapped] public IList<MicrosoftDynamicsCRMtemplate> OwnerTemplates { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner_contacts")]
        [NotMapped] public IList<MicrosoftDynamicsCRMcontact> OwnerContacts { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner_imports")]
        [NotMapped] public IList<MicrosoftDynamicsCRMimport> OwnerImports { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner_connections")]
        [NotMapped] public IList<MicrosoftDynamicsCRMconnection> OwnerConnections { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner_importfiles")]
        [NotMapped] public IList<MicrosoftDynamicsCRMimportfile> OwnerImportfiles { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner_importlogs")]
        [NotMapped] public IList<MicrosoftDynamicsCRMimportlog> OwnerImportlogs { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner_SyncError")]
        [NotMapped] public IList<MicrosoftDynamicsCRMsyncerror> OwnerSyncError { get; set; }

    }
}
