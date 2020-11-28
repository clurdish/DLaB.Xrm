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
	/// 
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("connectionroleassociation")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9369")]
	public partial class ConnectionRoleAssociation : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public static class Fields
		{
			public const string AssociatedConnectionRoleId = "associatedconnectionroleid";
			public const string ConnectionRoleAssociationId = "connectionroleassociationid";
			public const string Id = "connectionroleassociationid";
			public const string ConnectionRoleId = "connectionroleid";
			public const string VersionNumber = "versionnumber";
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public ConnectionRoleAssociation() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "connectionroleassociation";
		
		public const string PrimaryIdAttribute = "connectionroleassociationid";
		
		public const int EntityTypeCode = 3232;
		
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
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("associatedconnectionroleid")]
		public System.Nullable<System.Guid> AssociatedConnectionRoleId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("associatedconnectionroleid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("AssociatedConnectionRoleId");
				this.SetAttributeValue("associatedconnectionroleid", value);
				this.OnPropertyChanged("AssociatedConnectionRoleId");
			}
		}
		
		/// <summary>
		/// Unique identifier of the connection role association.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("connectionroleassociationid")]
		public System.Nullable<System.Guid> ConnectionRoleAssociationId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("connectionroleassociationid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ConnectionRoleAssociationId");
				this.SetAttributeValue("connectionroleassociationid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("ConnectionRoleAssociationId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("connectionroleassociationid")]
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
				this.ConnectionRoleAssociationId = value;
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("connectionroleid")]
		public System.Nullable<System.Guid> ConnectionRoleId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("connectionroleid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ConnectionRoleId");
				this.SetAttributeValue("connectionroleid", value);
				this.OnPropertyChanged("ConnectionRoleId");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
		
		/// <summary>
		/// 1:N userentityinstancedata_connectionroleassociation
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_connectionroleassociation")]
		public System.Collections.Generic.IEnumerable<DLaB.Xrm.Entities.UserEntityInstanceData> userentityinstancedata_connectionroleassociation
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<DLaB.Xrm.Entities.UserEntityInstanceData>("userentityinstancedata_connectionroleassociation", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("userentityinstancedata_connectionroleassociation");
				this.SetRelatedEntities<DLaB.Xrm.Entities.UserEntityInstanceData>("userentityinstancedata_connectionroleassociation", null, value);
				this.OnPropertyChanged("userentityinstancedata_connectionroleassociation");
			}
		}
		
		/// <summary>
		/// N:N connectionroleassociation_association
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("connectionroleassociation_association")]
		public System.Collections.Generic.IEnumerable<DLaB.Xrm.Entities.ConnectionRole> connectionroleassociation_association
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<DLaB.Xrm.Entities.ConnectionRole>("connectionroleassociation_association", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("connectionroleassociation_association");
				this.SetRelatedEntities<DLaB.Xrm.Entities.ConnectionRole>("connectionroleassociation_association", null, value);
				this.OnPropertyChanged("connectionroleassociation_association");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public ConnectionRoleAssociation(object anonymousType) : 
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
                        Attributes["connectionroleassociationid"] = base.Id;
                        break;
                    case "connectionroleassociationid":
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