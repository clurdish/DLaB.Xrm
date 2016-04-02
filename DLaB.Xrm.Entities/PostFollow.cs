//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DLaB.Xrm.Entities
{
	
	/// <summary>
	/// Represents a user following the activity feed of an object.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("postfollow")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "8.0.1.7297")]
	public partial class PostFollow : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public struct Fields
		{
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string OwnerId = "ownerid";
			public const string OwningBusinessUnit = "owningbusinessunit";
			public const string OwningTeam = "owningteam";
			public const string OwningUser = "owninguser";
			public const string PostFollowId = "postfollowid";
			public const string Id = "postfollowid";
			public const string RegardingObjectId = "regardingobjectid";
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
			public const string YammerPostState = "yammerpoststate";
			public const string account_PostFollows = "account_PostFollows";
			public const string appointment_PostFollows = "appointment_PostFollows";
			public const string business_unit_postfollows = "business_unit_postfollows";
			public const string competitor_PostFollows = "competitor_PostFollows";
			public const string contact_PostFollows = "contact_PostFollows";
			public const string incident_PostFollows = "incident_PostFollows";
			public const string knowledgearticle_PostFollows = "knowledgearticle_PostFollows";
			public const string lead_PostFollows = "lead_PostFollows";
			public const string lk_PostFollow_createdby = "lk_PostFollow_createdby";
			public const string lk_postfollow_createdonbehalfby = "lk_postfollow_createdonbehalfby";
			public const string opportunity_PostFollows = "opportunity_PostFollows";
			public const string OwningTeam_postfollows = "OwningTeam_postfollows";
			public const string phonecall_PostFollows = "phonecall_PostFollows";
			public const string processsession_PostFollows = "processsession_PostFollows";
			public const string queue_PostFollows = "queue_PostFollows";
			public const string recurringappointmentmaster_PostFollows = "recurringappointmentmaster_PostFollows";
			public const string systemuser_PostFollows = "systemuser_PostFollows";
			public const string task_PostFollows = "task_PostFollows";
			public const string user_owner_postfollows = "user_owner_postfollows";
		}

		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public PostFollow() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "postfollow";
		
		public const int EntityTypeCode = 8003;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		[System.Diagnostics.DebuggerNonUserCode()]
		private void OnPropertyChanged(string propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		[System.Diagnostics.DebuggerNonUserCode()]
		private void OnPropertyChanging(string propertyName)
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
			}
		}
		
		/// <summary>
		/// Shows who created the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CreatedBy");
				this.SetAttributeValue("createdby", value);
				this.OnPropertyChanged("CreatedBy");
			}
		}
		
		/// <summary>
		/// Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics CRM options.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CreatedOn");
				this.SetAttributeValue("createdon", value);
				this.OnPropertyChanged("CreatedOn");
			}
		}
		
		/// <summary>
		/// Shows who created the record on behalf of another user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CreatedOnBehalfBy");
				this.SetAttributeValue("createdonbehalfby", value);
				this.OnPropertyChanged("CreatedOnBehalfBy");
			}
		}
		
		/// <summary>
		/// Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
		public Microsoft.Xrm.Sdk.EntityReference OwnerId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ownerid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("OwnerId");
				this.SetAttributeValue("ownerid", value);
				this.OnPropertyChanged("OwnerId");
			}
		}
		
		/// <summary>
		/// Unique identifier for the business unit that owns the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("OwningBusinessUnit");
				this.SetAttributeValue("owningbusinessunit", value);
				this.OnPropertyChanged("OwningBusinessUnit");
			}
		}
		
		/// <summary>
		/// Unique identifier of the team who owns the follow.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
		public Microsoft.Xrm.Sdk.EntityReference OwningTeam
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("OwningTeam");
				this.SetAttributeValue("owningteam", value);
				this.OnPropertyChanged("OwningTeam");
			}
		}
		
		/// <summary>
		/// Unique identifier for the user who owns the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		public Microsoft.Xrm.Sdk.EntityReference OwningUser
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("OwningUser");
				this.SetAttributeValue("owninguser", value);
				this.OnPropertyChanged("OwningUser");
			}
		}
		
		/// <summary>
		/// Shows the ID of the post follow.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("postfollowid")]
		public System.Nullable<System.Guid> PostFollowId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("postfollowid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("PostFollowId");
				this.SetAttributeValue("postfollowid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("PostFollowId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("postfollowid")]
		public override System.Guid Id
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return base.Id;
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.PostFollowId = value;
			}
		}
		
		/// <summary>
		/// Choose the parent record for the followed post to identify the customer, opportunity, case, or other record type that the post most closely relates to.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
		public Microsoft.Xrm.Sdk.EntityReference RegardingObjectId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("regardingobjectid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("RegardingObjectId");
				this.SetAttributeValue("regardingobjectid", value);
				this.OnPropertyChanged("RegardingObjectId");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezoneruleversionnumber")]
		public System.Nullable<int> TimeZoneRuleVersionNumber
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("timezoneruleversionnumber");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("TimeZoneRuleVersionNumber");
				this.SetAttributeValue("timezoneruleversionnumber", value);
				this.OnPropertyChanged("TimeZoneRuleVersionNumber");
			}
		}
		
		/// <summary>
		/// Time zone code that was in use when the record was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("utcconversiontimezonecode")]
		public System.Nullable<int> UTCConversionTimeZoneCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("utcconversiontimezonecode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("UTCConversionTimeZoneCode");
				this.SetAttributeValue("utcconversiontimezonecode", value);
				this.OnPropertyChanged("UTCConversionTimeZoneCode");
			}
		}
		
		/// <summary>
		/// Internal Use Only
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yammerpoststate")]
		public System.Nullable<int> YammerPostState
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("yammerpoststate");
			}
		}
		
		/// <summary>
		/// 1:N PostFollow_AsyncOperations
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("PostFollow_AsyncOperations")]
		public System.Collections.Generic.IEnumerable<DLaB.Xrm.Entities.AsyncOperation> PostFollow_AsyncOperations
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<DLaB.Xrm.Entities.AsyncOperation>("PostFollow_AsyncOperations", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("PostFollow_AsyncOperations");
				this.SetRelatedEntities<DLaB.Xrm.Entities.AsyncOperation>("PostFollow_AsyncOperations", null, value);
				this.OnPropertyChanged("PostFollow_AsyncOperations");
			}
		}
		
		/// <summary>
		/// N:1 account_PostFollows
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("account_PostFollows")]
		public DLaB.Xrm.Entities.Account account_PostFollows
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.Account>("account_PostFollows", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("account_PostFollows");
				this.SetRelatedEntity<DLaB.Xrm.Entities.Account>("account_PostFollows", null, value);
				this.OnPropertyChanged("account_PostFollows");
			}
		}
		
		/// <summary>
		/// N:1 appointment_PostFollows
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("appointment_PostFollows")]
		public DLaB.Xrm.Entities.Appointment appointment_PostFollows
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.Appointment>("appointment_PostFollows", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("appointment_PostFollows");
				this.SetRelatedEntity<DLaB.Xrm.Entities.Appointment>("appointment_PostFollows", null, value);
				this.OnPropertyChanged("appointment_PostFollows");
			}
		}
		
		/// <summary>
		/// N:1 business_unit_postfollows
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_postfollows")]
		public DLaB.Xrm.Entities.BusinessUnit business_unit_postfollows
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.BusinessUnit>("business_unit_postfollows", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("business_unit_postfollows");
				this.SetRelatedEntity<DLaB.Xrm.Entities.BusinessUnit>("business_unit_postfollows", null, value);
				this.OnPropertyChanged("business_unit_postfollows");
			}
		}
		
		/// <summary>
		/// N:1 competitor_PostFollows
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("competitor_PostFollows")]
		public DLaB.Xrm.Entities.Competitor competitor_PostFollows
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.Competitor>("competitor_PostFollows", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("competitor_PostFollows");
				this.SetRelatedEntity<DLaB.Xrm.Entities.Competitor>("competitor_PostFollows", null, value);
				this.OnPropertyChanged("competitor_PostFollows");
			}
		}
		
		/// <summary>
		/// N:1 contact_PostFollows
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contact_PostFollows")]
		public DLaB.Xrm.Entities.Contact contact_PostFollows
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.Contact>("contact_PostFollows", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("contact_PostFollows");
				this.SetRelatedEntity<DLaB.Xrm.Entities.Contact>("contact_PostFollows", null, value);
				this.OnPropertyChanged("contact_PostFollows");
			}
		}
		
		/// <summary>
		/// N:1 incident_PostFollows
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("incident_PostFollows")]
		public DLaB.Xrm.Entities.Incident incident_PostFollows
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.Incident>("incident_PostFollows", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("incident_PostFollows");
				this.SetRelatedEntity<DLaB.Xrm.Entities.Incident>("incident_PostFollows", null, value);
				this.OnPropertyChanged("incident_PostFollows");
			}
		}
		
		/// <summary>
		/// N:1 knowledgearticle_PostFollows
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("knowledgearticle_PostFollows")]
		public DLaB.Xrm.Entities.KnowledgeArticle knowledgearticle_PostFollows
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.KnowledgeArticle>("knowledgearticle_PostFollows", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("knowledgearticle_PostFollows");
				this.SetRelatedEntity<DLaB.Xrm.Entities.KnowledgeArticle>("knowledgearticle_PostFollows", null, value);
				this.OnPropertyChanged("knowledgearticle_PostFollows");
			}
		}
		
		/// <summary>
		/// N:1 lead_PostFollows
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lead_PostFollows")]
		public DLaB.Xrm.Entities.Lead lead_PostFollows
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.Lead>("lead_PostFollows", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lead_PostFollows");
				this.SetRelatedEntity<DLaB.Xrm.Entities.Lead>("lead_PostFollows", null, value);
				this.OnPropertyChanged("lead_PostFollows");
			}
		}
		
		/// <summary>
		/// N:1 lk_PostFollow_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_PostFollow_createdby")]
		public DLaB.Xrm.Entities.SystemUser lk_PostFollow_createdby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_PostFollow_createdby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_PostFollow_createdby");
				this.SetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_PostFollow_createdby", null, value);
				this.OnPropertyChanged("lk_PostFollow_createdby");
			}
		}
		
		/// <summary>
		/// N:1 lk_postfollow_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_postfollow_createdonbehalfby")]
		public DLaB.Xrm.Entities.SystemUser lk_postfollow_createdonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_postfollow_createdonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_postfollow_createdonbehalfby");
				this.SetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_postfollow_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_postfollow_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 opportunity_PostFollows
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunity_PostFollows")]
		public DLaB.Xrm.Entities.Opportunity opportunity_PostFollows
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.Opportunity>("opportunity_PostFollows", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("opportunity_PostFollows");
				this.SetRelatedEntity<DLaB.Xrm.Entities.Opportunity>("opportunity_PostFollows", null, value);
				this.OnPropertyChanged("opportunity_PostFollows");
			}
		}
		
		/// <summary>
		/// N:1 OwningTeam_postfollows
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("OwningTeam_postfollows")]
		public DLaB.Xrm.Entities.Team OwningTeam_postfollows
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.Team>("OwningTeam_postfollows", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("OwningTeam_postfollows");
				this.SetRelatedEntity<DLaB.Xrm.Entities.Team>("OwningTeam_postfollows", null, value);
				this.OnPropertyChanged("OwningTeam_postfollows");
			}
		}
		
		/// <summary>
		/// N:1 phonecall_PostFollows
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("phonecall_PostFollows")]
		public DLaB.Xrm.Entities.PhoneCall phonecall_PostFollows
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.PhoneCall>("phonecall_PostFollows", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("phonecall_PostFollows");
				this.SetRelatedEntity<DLaB.Xrm.Entities.PhoneCall>("phonecall_PostFollows", null, value);
				this.OnPropertyChanged("phonecall_PostFollows");
			}
		}
		
		/// <summary>
		/// N:1 processsession_PostFollows
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processsession_PostFollows")]
		public DLaB.Xrm.Entities.ProcessSession processsession_PostFollows
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.ProcessSession>("processsession_PostFollows", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("processsession_PostFollows");
				this.SetRelatedEntity<DLaB.Xrm.Entities.ProcessSession>("processsession_PostFollows", null, value);
				this.OnPropertyChanged("processsession_PostFollows");
			}
		}
		
		/// <summary>
		/// N:1 queue_PostFollows
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("queue_PostFollows")]
		public DLaB.Xrm.Entities.Queue queue_PostFollows
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.Queue>("queue_PostFollows", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("queue_PostFollows");
				this.SetRelatedEntity<DLaB.Xrm.Entities.Queue>("queue_PostFollows", null, value);
				this.OnPropertyChanged("queue_PostFollows");
			}
		}
		
		/// <summary>
		/// N:1 recurringappointmentmaster_PostFollows
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("recurringappointmentmaster_PostFollows")]
		public DLaB.Xrm.Entities.RecurringAppointmentMaster recurringappointmentmaster_PostFollows
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.RecurringAppointmentMaster>("recurringappointmentmaster_PostFollows", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("recurringappointmentmaster_PostFollows");
				this.SetRelatedEntity<DLaB.Xrm.Entities.RecurringAppointmentMaster>("recurringappointmentmaster_PostFollows", null, value);
				this.OnPropertyChanged("recurringappointmentmaster_PostFollows");
			}
		}
		
		/// <summary>
		/// N:1 systemuser_PostFollows
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("systemuser_PostFollows")]
		public DLaB.Xrm.Entities.SystemUser systemuser_PostFollows
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("systemuser_PostFollows", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("systemuser_PostFollows");
				this.SetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("systemuser_PostFollows", null, value);
				this.OnPropertyChanged("systemuser_PostFollows");
			}
		}
		
		/// <summary>
		/// N:1 task_PostFollows
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("task_PostFollows")]
		public DLaB.Xrm.Entities.Task task_PostFollows
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.Task>("task_PostFollows", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("task_PostFollows");
				this.SetRelatedEntity<DLaB.Xrm.Entities.Task>("task_PostFollows", null, value);
				this.OnPropertyChanged("task_PostFollows");
			}
		}
		
		/// <summary>
		/// N:1 user_owner_postfollows
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_owner_postfollows")]
		public DLaB.Xrm.Entities.SystemUser user_owner_postfollows
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("user_owner_postfollows", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("user_owner_postfollows");
				this.SetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("user_owner_postfollows", null, value);
				this.OnPropertyChanged("user_owner_postfollows");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public PostFollow(object anonymousType) : 
				this()
		{
            foreach (var p in anonymousType.GetType().GetProperties())
            {
                var value = p.GetValue(anonymousType, null);
                var name = p.Name.ToLower();
            
                if (name.EndsWith("enum") && value.GetType().BaseType == typeof(System.Enum))
                {
                    value = new Microsoft.Xrm.Sdk.OptionSetValue((int) value);
                    name = name.Remove(name.Length - "enum".Length);
                }
            
                switch (name)
                {
                    case "id":
                        base.Id = (System.Guid)value;
                        Attributes["postfollowid"] = base.Id;
                        break;
                    case "postfollowid":
                        var id = (System.Nullable<System.Guid>) value;
                        if(id == null){ continue; }
                        base.Id = id.Value;
                        Attributes[name] = base.Id;
                        break;
                    case "formattedvalues":
                        // Add Support for FormattedValues
                        FormattedValues.AddRange((Microsoft.Xrm.Sdk.FormattedValueCollection)value);
                        break;
                    default:
                        Attributes[name] = value;
                        break;
                }
            }
		}
	}
}