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
	/// Calendar representing the semi-annual span of time during which the financial activities of an organization are calculated.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("semiannualfiscalcalendar")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "8.0.1.7297")]
	public partial class SemiAnnualFiscalCalendar : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public struct Fields
		{
			public const string BusinessUnitId = "businessunitid";
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string EffectiveOn = "effectiveon";
			public const string ExchangeRate = "exchangerate";
			public const string FirstHalf = "firsthalf";
			public const string FirstHalf_Base = "firsthalf_base";
			public const string FiscalPeriodType = "fiscalperiodtype";
			public const string ImportSequenceNumber = "importsequencenumber";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string SalesPersonId = "salespersonid";
			public const string SecondHalf = "secondhalf";
			public const string SecondHalf_Base = "secondhalf_base";
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
			public const string TransactionCurrencyId = "transactioncurrencyid";
			public const string UserFiscalCalendarId = "userfiscalcalendarid";
			public const string Id = "userfiscalcalendarid";
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
			public const string lk_semiannualfiscalcalendar_createdby = "lk_semiannualfiscalcalendar_createdby";
			public const string lk_semiannualfiscalcalendar_createdonbehalfby = "lk_semiannualfiscalcalendar_createdonbehalfby";
			public const string lk_semiannualfiscalcalendar_modifiedby = "lk_semiannualfiscalcalendar_modifiedby";
			public const string lk_semiannualfiscalcalendar_modifiedonbehalfby = "lk_semiannualfiscalcalendar_modifiedonbehalfby";
			public const string lk_semiannualfiscalcalendar_salespersonid = "lk_semiannualfiscalcalendar_salespersonid";
			public const string transactioncurrency_semiannualfiscalcalendar = "transactioncurrency_semiannualfiscalcalendar";
		}

		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public SemiAnnualFiscalCalendar() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "semiannualfiscalcalendar";
		
		public const int EntityTypeCode = 2001;
		
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
		/// Unique identifier of the business unit with which the calendar is associated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("businessunitid")]
		public Microsoft.Xrm.Sdk.EntityReference BusinessUnitId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("businessunitid");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the semiannual fiscal calendar.
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
		/// Date and time when the quota for the semiannual fiscal calendar was created.
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
		/// Unique identifier of the delegate user who created the semiannualfiscalcalendar.
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
		/// Date and time when the semiannual fiscal calendar sales quota takes effect.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("effectiveon")]
		public System.Nullable<System.DateTime> EffectiveOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("effectiveon");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("EffectiveOn");
				this.SetAttributeValue("effectiveon", value);
				this.OnPropertyChanged("EffectiveOn");
			}
		}
		
		/// <summary>
		/// Exchange rate for the currency associated with the semiannual fiscal calendar with respect to the base currency.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangerate")]
		public System.Nullable<decimal> ExchangeRate
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<decimal>>("exchangerate");
			}
		}
		
		/// <summary>
		/// Sales quota for the first half of the fiscal year.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("firsthalf")]
		public Microsoft.Xrm.Sdk.Money FirstHalf
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("firsthalf");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("FirstHalf");
				this.SetAttributeValue("firsthalf", value);
				this.OnPropertyChanged("FirstHalf");
			}
		}
		
		/// <summary>
		/// Base currency equivalent for the sales quota for the first half of the fiscal year.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("firsthalf_base")]
		public Microsoft.Xrm.Sdk.Money FirstHalf_Base
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("firsthalf_base");
			}
		}
		
		/// <summary>
		/// Type of fiscal period used in the sales quota.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fiscalperiodtype")]
		public System.Nullable<int> FiscalPeriodType
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("fiscalperiodtype");
			}
		}
		
		/// <summary>
		/// Unique identifier of the data import or data migration that created this record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importsequencenumber")]
		public System.Nullable<int> ImportSequenceNumber
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("importsequencenumber");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ImportSequenceNumber");
				this.SetAttributeValue("importsequencenumber", value);
				this.OnPropertyChanged("ImportSequenceNumber");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who last modified the semiannual fiscal calendar.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ModifiedBy");
				this.SetAttributeValue("modifiedby", value);
				this.OnPropertyChanged("ModifiedBy");
			}
		}
		
		/// <summary>
		/// Date and time when the semiannual fiscal calendar was last modified.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ModifiedOn");
				this.SetAttributeValue("modifiedon", value);
				this.OnPropertyChanged("ModifiedOn");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who last modified the semiannualfiscalcalendar.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ModifiedOnBehalfBy");
				this.SetAttributeValue("modifiedonbehalfby", value);
				this.OnPropertyChanged("ModifiedOnBehalfBy");
			}
		}
		
		/// <summary>
		/// Unique identifier of the associated salesperson.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("salespersonid")]
		public Microsoft.Xrm.Sdk.EntityReference SalesPersonId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("salespersonid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("SalesPersonId");
				this.SetAttributeValue("salespersonid", value);
				this.OnPropertyChanged("SalesPersonId");
			}
		}
		
		/// <summary>
		/// Sales quota for the second half of the fiscal year.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("secondhalf")]
		public Microsoft.Xrm.Sdk.Money SecondHalf
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("secondhalf");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("SecondHalf");
				this.SetAttributeValue("secondhalf", value);
				this.OnPropertyChanged("SecondHalf");
			}
		}
		
		/// <summary>
		/// Base currency equivalent of the sales quota for the second half of the fiscal year.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("secondhalf_base")]
		public Microsoft.Xrm.Sdk.Money SecondHalf_Base
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("secondhalf_base");
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
		/// Unique identifier of the currency associated with the semiannual fiscal calendar.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
		public Microsoft.Xrm.Sdk.EntityReference TransactionCurrencyId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("transactioncurrencyid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("TransactionCurrencyId");
				this.SetAttributeValue("transactioncurrencyid", value);
				this.OnPropertyChanged("TransactionCurrencyId");
			}
		}
		
		/// <summary>
		/// Unique identifier for the user who created the semiannual fiscal calendar.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("userfiscalcalendarid")]
		public System.Nullable<System.Guid> UserFiscalCalendarId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("userfiscalcalendarid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("UserFiscalCalendarId");
				this.SetAttributeValue("userfiscalcalendarid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("UserFiscalCalendarId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("userfiscalcalendarid")]
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
				this.UserFiscalCalendarId = value;
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
		/// 1:N SemiAnnualFiscalCalendar_AsyncOperations
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SemiAnnualFiscalCalendar_AsyncOperations")]
		public System.Collections.Generic.IEnumerable<DLaB.Xrm.Entities.AsyncOperation> SemiAnnualFiscalCalendar_AsyncOperations
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<DLaB.Xrm.Entities.AsyncOperation>("SemiAnnualFiscalCalendar_AsyncOperations", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("SemiAnnualFiscalCalendar_AsyncOperations");
				this.SetRelatedEntities<DLaB.Xrm.Entities.AsyncOperation>("SemiAnnualFiscalCalendar_AsyncOperations", null, value);
				this.OnPropertyChanged("SemiAnnualFiscalCalendar_AsyncOperations");
			}
		}
		
		/// <summary>
		/// 1:N SemiAnnualFiscalCalendar_BulkDeleteFailures
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SemiAnnualFiscalCalendar_BulkDeleteFailures")]
		public System.Collections.Generic.IEnumerable<DLaB.Xrm.Entities.BulkDeleteFailure> SemiAnnualFiscalCalendar_BulkDeleteFailures
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<DLaB.Xrm.Entities.BulkDeleteFailure>("SemiAnnualFiscalCalendar_BulkDeleteFailures", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("SemiAnnualFiscalCalendar_BulkDeleteFailures");
				this.SetRelatedEntities<DLaB.Xrm.Entities.BulkDeleteFailure>("SemiAnnualFiscalCalendar_BulkDeleteFailures", null, value);
				this.OnPropertyChanged("SemiAnnualFiscalCalendar_BulkDeleteFailures");
			}
		}
		
		/// <summary>
		/// N:1 lk_semiannualfiscalcalendar_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_semiannualfiscalcalendar_createdby")]
		public DLaB.Xrm.Entities.SystemUser lk_semiannualfiscalcalendar_createdby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_semiannualfiscalcalendar_createdby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_semiannualfiscalcalendar_createdby");
				this.SetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_semiannualfiscalcalendar_createdby", null, value);
				this.OnPropertyChanged("lk_semiannualfiscalcalendar_createdby");
			}
		}
		
		/// <summary>
		/// N:1 lk_semiannualfiscalcalendar_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_semiannualfiscalcalendar_createdonbehalfby")]
		public DLaB.Xrm.Entities.SystemUser lk_semiannualfiscalcalendar_createdonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_semiannualfiscalcalendar_createdonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_semiannualfiscalcalendar_createdonbehalfby");
				this.SetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_semiannualfiscalcalendar_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_semiannualfiscalcalendar_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_semiannualfiscalcalendar_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_semiannualfiscalcalendar_modifiedby")]
		public DLaB.Xrm.Entities.SystemUser lk_semiannualfiscalcalendar_modifiedby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_semiannualfiscalcalendar_modifiedby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_semiannualfiscalcalendar_modifiedby");
				this.SetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_semiannualfiscalcalendar_modifiedby", null, value);
				this.OnPropertyChanged("lk_semiannualfiscalcalendar_modifiedby");
			}
		}
		
		/// <summary>
		/// N:1 lk_semiannualfiscalcalendar_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_semiannualfiscalcalendar_modifiedonbehalfby")]
		public DLaB.Xrm.Entities.SystemUser lk_semiannualfiscalcalendar_modifiedonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_semiannualfiscalcalendar_modifiedonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_semiannualfiscalcalendar_modifiedonbehalfby");
				this.SetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_semiannualfiscalcalendar_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_semiannualfiscalcalendar_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_semiannualfiscalcalendar_salespersonid
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("salespersonid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_semiannualfiscalcalendar_salespersonid")]
		public DLaB.Xrm.Entities.SystemUser lk_semiannualfiscalcalendar_salespersonid
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_semiannualfiscalcalendar_salespersonid", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_semiannualfiscalcalendar_salespersonid");
				this.SetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_semiannualfiscalcalendar_salespersonid", null, value);
				this.OnPropertyChanged("lk_semiannualfiscalcalendar_salespersonid");
			}
		}
		
		/// <summary>
		/// N:1 transactioncurrency_semiannualfiscalcalendar
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("transactioncurrency_semiannualfiscalcalendar")]
		public DLaB.Xrm.Entities.TransactionCurrency transactioncurrency_semiannualfiscalcalendar
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.TransactionCurrency>("transactioncurrency_semiannualfiscalcalendar", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("transactioncurrency_semiannualfiscalcalendar");
				this.SetRelatedEntity<DLaB.Xrm.Entities.TransactionCurrency>("transactioncurrency_semiannualfiscalcalendar", null, value);
				this.OnPropertyChanged("transactioncurrency_semiannualfiscalcalendar");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public SemiAnnualFiscalCalendar(object anonymousType) : 
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
                        Attributes["userfiscalcalendarid"] = base.Id;
                        break;
                    case "userfiscalcalendarid":
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