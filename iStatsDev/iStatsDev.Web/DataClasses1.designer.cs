﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4016
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace myistats.Web
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.Runtime.Serialization;
	using System.ComponentModel;
	using System;
	
	
	[System.Data.Linq.Mapping.DatabaseAttribute(Name="myistats")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    partial void InsertEvent(Event instance);
    partial void UpdateEvent(Event instance);
    partial void DeleteEvent(Event instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["myistatsConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
		
		public System.Data.Linq.Table<Event> Events
		{
			get
			{
				return this.GetTable<Event>();
			}
		}
	}
	
	[Table(Name="dbo.[User]")]
	[DataContract()]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _UserId;
		
		private int _Status;
		
		private string _Email;
		
		private string _FirstName;
		
		private string _MiddleName;
		
		private string _LastName;
		
		private int _UserType;
		
		private System.DateTime _CreationDT;
		
		private System.Nullable<System.DateTime> _FirstLoginDT;
		
		private System.Nullable<System.DateTime> _ClosingDT;
		
		private System.Nullable<System.DateTime> _LastLoginDT;
		
		private System.Data.Linq.Binary _Password;
		
		private EntitySet<Event> _Events;
		
		private bool serializing;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUserIdChanging(int value);
    partial void OnUserIdChanged();
    partial void OnStatusChanging(int value);
    partial void OnStatusChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    partial void OnMiddleNameChanging(string value);
    partial void OnMiddleNameChanged();
    partial void OnLastNameChanging(string value);
    partial void OnLastNameChanged();
    partial void OnUserTypeChanging(int value);
    partial void OnUserTypeChanged();
    partial void OnCreationDTChanging(System.DateTime value);
    partial void OnCreationDTChanged();
    partial void OnFirstLoginDTChanging(System.Nullable<System.DateTime> value);
    partial void OnFirstLoginDTChanged();
    partial void OnClosingDTChanging(System.Nullable<System.DateTime> value);
    partial void OnClosingDTChanged();
    partial void OnLastLoginDTChanging(System.Nullable<System.DateTime> value);
    partial void OnLastLoginDTChanged();
    partial void OnPasswordChanging(System.Data.Linq.Binary value);
    partial void OnPasswordChanged();
    #endregion
		
		public User()
		{
			this.Initialize();
		}
		
		[Column(Storage="_UserId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		[DataMember(Order=1)]
		public int UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				if ((this._UserId != value))
				{
					this.OnUserIdChanging(value);
					this.SendPropertyChanging();
					this._UserId = value;
					this.SendPropertyChanged("UserId");
					this.OnUserIdChanged();
				}
			}
		}
		
		[Column(Storage="_Status", DbType="Int NOT NULL")]
		[DataMember(Order=2)]
		public int Status
		{
			get
			{
				return this._Status;
			}
			set
			{
				if ((this._Status != value))
				{
					this.OnStatusChanging(value);
					this.SendPropertyChanging();
					this._Status = value;
					this.SendPropertyChanged("Status");
					this.OnStatusChanged();
				}
			}
		}
		
		[Column(Storage="_Email", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		[DataMember(Order=3)]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[Column(Storage="_FirstName", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		[DataMember(Order=4)]
		public string FirstName
		{
			get
			{
				return this._FirstName;
			}
			set
			{
				if ((this._FirstName != value))
				{
					this.OnFirstNameChanging(value);
					this.SendPropertyChanging();
					this._FirstName = value;
					this.SendPropertyChanged("FirstName");
					this.OnFirstNameChanged();
				}
			}
		}
		
		[Column(Storage="_MiddleName", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		[DataMember(Order=5)]
		public string MiddleName
		{
			get
			{
				return this._MiddleName;
			}
			set
			{
				if ((this._MiddleName != value))
				{
					this.OnMiddleNameChanging(value);
					this.SendPropertyChanging();
					this._MiddleName = value;
					this.SendPropertyChanged("MiddleName");
					this.OnMiddleNameChanged();
				}
			}
		}
		
		[Column(Storage="_LastName", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		[DataMember(Order=6)]
		public string LastName
		{
			get
			{
				return this._LastName;
			}
			set
			{
				if ((this._LastName != value))
				{
					this.OnLastNameChanging(value);
					this.SendPropertyChanging();
					this._LastName = value;
					this.SendPropertyChanged("LastName");
					this.OnLastNameChanged();
				}
			}
		}
		
		[Column(Storage="_UserType", DbType="Int NOT NULL")]
		[DataMember(Order=7)]
		public int UserType
		{
			get
			{
				return this._UserType;
			}
			set
			{
				if ((this._UserType != value))
				{
					this.OnUserTypeChanging(value);
					this.SendPropertyChanging();
					this._UserType = value;
					this.SendPropertyChanged("UserType");
					this.OnUserTypeChanged();
				}
			}
		}
		
		[Column(Storage="_CreationDT", DbType="DateTime NOT NULL")]
		[DataMember(Order=8)]
		public System.DateTime CreationDT
		{
			get
			{
				return this._CreationDT;
			}
			set
			{
				if ((this._CreationDT != value))
				{
					this.OnCreationDTChanging(value);
					this.SendPropertyChanging();
					this._CreationDT = value;
					this.SendPropertyChanged("CreationDT");
					this.OnCreationDTChanged();
				}
			}
		}
		
		[Column(Storage="_FirstLoginDT", DbType="DateTime")]
		[DataMember(Order=9)]
		public System.Nullable<System.DateTime> FirstLoginDT
		{
			get
			{
				return this._FirstLoginDT;
			}
			set
			{
				if ((this._FirstLoginDT != value))
				{
					this.OnFirstLoginDTChanging(value);
					this.SendPropertyChanging();
					this._FirstLoginDT = value;
					this.SendPropertyChanged("FirstLoginDT");
					this.OnFirstLoginDTChanged();
				}
			}
		}
		
		[Column(Storage="_ClosingDT", DbType="DateTime")]
		[DataMember(Order=10)]
		public System.Nullable<System.DateTime> ClosingDT
		{
			get
			{
				return this._ClosingDT;
			}
			set
			{
				if ((this._ClosingDT != value))
				{
					this.OnClosingDTChanging(value);
					this.SendPropertyChanging();
					this._ClosingDT = value;
					this.SendPropertyChanged("ClosingDT");
					this.OnClosingDTChanged();
				}
			}
		}
		
		[Column(Storage="_LastLoginDT", DbType="DateTime")]
		[DataMember(Order=11)]
		public System.Nullable<System.DateTime> LastLoginDT
		{
			get
			{
				return this._LastLoginDT;
			}
			set
			{
				if ((this._LastLoginDT != value))
				{
					this.OnLastLoginDTChanging(value);
					this.SendPropertyChanging();
					this._LastLoginDT = value;
					this.SendPropertyChanged("LastLoginDT");
					this.OnLastLoginDTChanged();
				}
			}
		}
		
		[Column(Storage="_Password", DbType="Binary(256)", UpdateCheck=UpdateCheck.Never)]
		[DataMember(Order=12)]
		public System.Data.Linq.Binary Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[Association(Name="User_Event", Storage="_Events", ThisKey="UserId", OtherKey="UserId")]
		[DataMember(Order=13, EmitDefaultValue=false)]
		public EntitySet<Event> Events
		{
			get
			{
				if ((this.serializing 
							&& (this._Events.HasLoadedOrAssignedValues == false)))
				{
					return null;
				}
				return this._Events;
			}
			set
			{
				this._Events.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Events(Event entity)
		{
			this.SendPropertyChanging();
			entity.User = this;
		}
		
		private void detach_Events(Event entity)
		{
			this.SendPropertyChanging();
			entity.User = null;
		}
		
		private void Initialize()
		{
			this._Events = new EntitySet<Event>(new Action<Event>(this.attach_Events), new Action<Event>(this.detach_Events));
			OnCreated();
		}
		
		[OnDeserializing()]
		[System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
		public void OnDeserializing(StreamingContext context)
		{
			this.Initialize();
		}
		
		[OnSerializing()]
		[System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
		public void OnSerializing(StreamingContext context)
		{
			this.serializing = true;
		}
		
		[OnSerialized()]
		[System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
		public void OnSerialized(StreamingContext context)
		{
			this.serializing = false;
		}
	}
	
	[Table(Name="dbo.Events")]
	[DataContract()]
	public partial class Event : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private System.DateTime _DateTime;
		
		private System.Nullable<int> _UserId;
		
		private int _Type;
		
		private string _Message;
		
		private EntityRef<User> _User;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnDateTimeChanging(System.DateTime value);
    partial void OnDateTimeChanged();
    partial void OnUserIdChanging(System.Nullable<int> value);
    partial void OnUserIdChanged();
    partial void OnTypeChanging(int value);
    partial void OnTypeChanged();
    partial void OnMessageChanging(string value);
    partial void OnMessageChanged();
    #endregion
		
		public Event()
		{
			this.Initialize();
		}
		
		[Column(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		[DataMember(Order=1)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[Column(Storage="_DateTime", DbType="DateTime NOT NULL")]
		[DataMember(Order=2)]
		public System.DateTime DateTime
		{
			get
			{
				return this._DateTime;
			}
			set
			{
				if ((this._DateTime != value))
				{
					this.OnDateTimeChanging(value);
					this.SendPropertyChanging();
					this._DateTime = value;
					this.SendPropertyChanged("DateTime");
					this.OnDateTimeChanged();
				}
			}
		}
		
		[Column(Storage="_UserId", DbType="Int")]
		[DataMember(Order=3)]
		public System.Nullable<int> UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				if ((this._UserId != value))
				{
					if (this._User.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUserIdChanging(value);
					this.SendPropertyChanging();
					this._UserId = value;
					this.SendPropertyChanged("UserId");
					this.OnUserIdChanged();
				}
			}
		}
		
		[Column(Storage="_Type", DbType="Int NOT NULL")]
		[DataMember(Order=4)]
		public int Type
		{
			get
			{
				return this._Type;
			}
			set
			{
				if ((this._Type != value))
				{
					this.OnTypeChanging(value);
					this.SendPropertyChanging();
					this._Type = value;
					this.SendPropertyChanged("Type");
					this.OnTypeChanged();
				}
			}
		}
		
		[Column(Storage="_Message", DbType="VarChar(512)")]
		[DataMember(Order=5)]
		public string Message
		{
			get
			{
				return this._Message;
			}
			set
			{
				if ((this._Message != value))
				{
					this.OnMessageChanging(value);
					this.SendPropertyChanging();
					this._Message = value;
					this.SendPropertyChanged("Message");
					this.OnMessageChanged();
				}
			}
		}
		
		[Association(Name="User_Event", Storage="_User", ThisKey="UserId", OtherKey="UserId", IsForeignKey=true)]
		public User User
		{
			get
			{
				return this._User.Entity;
			}
			set
			{
				User previousValue = this._User.Entity;
				if (((previousValue != value) 
							|| (this._User.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._User.Entity = null;
						previousValue.Events.Remove(this);
					}
					this._User.Entity = value;
					if ((value != null))
					{
						value.Events.Add(this);
						this._UserId = value.UserId;
					}
					else
					{
						this._UserId = default(Nullable<int>);
					}
					this.SendPropertyChanged("User");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void Initialize()
		{
			this._User = default(EntityRef<User>);
			OnCreated();
		}
		
		[OnDeserializing()]
		[System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
		public void OnDeserializing(StreamingContext context)
		{
			this.Initialize();
		}
	}
}
#pragma warning restore 1591
