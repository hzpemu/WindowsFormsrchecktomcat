﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.1008
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsrchecktomcat
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="sellcentre")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region 可扩展性方法定义
    partial void OnCreated();
    partial void Insertuserlog(userlog instance);
    partial void Updateuserlog(userlog instance);
    partial void Deleteuserlog(userlog instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::WindowsFormsrchecktomcat.Properties.Settings.Default.sellcentreConnectionString, mappingSource)
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
		
		public System.Data.Linq.Table<userlog> userlog
		{
			get
			{
				return this.GetTable<userlog>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.userlog")]
	public partial class userlog : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _name;
		
		private string _realname;
		
		private string _userlog1;
		
		private System.DateTime _date;
		
		private System.Guid _only;
		
		private string _IP;
		
		private string _hostname;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnrealnameChanging(string value);
    partial void OnrealnameChanged();
    partial void Onuserlog1Changing(string value);
    partial void Onuserlog1Changed();
    partial void OndateChanging(System.DateTime value);
    partial void OndateChanged();
    partial void OnonlyChanging(System.Guid value);
    partial void OnonlyChanged();
    partial void OnIPChanging(string value);
    partial void OnIPChanged();
    partial void OnhostnameChanging(string value);
    partial void OnhostnameChanged();
    #endregion
		
		public userlog()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_realname", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string realname
		{
			get
			{
				return this._realname;
			}
			set
			{
				if ((this._realname != value))
				{
					this.OnrealnameChanging(value);
					this.SendPropertyChanging();
					this._realname = value;
					this.SendPropertyChanged("realname");
					this.OnrealnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="userlog", Storage="_userlog1", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string userlog1
		{
			get
			{
				return this._userlog1;
			}
			set
			{
				if ((this._userlog1 != value))
				{
					this.Onuserlog1Changing(value);
					this.SendPropertyChanging();
					this._userlog1 = value;
					this.SendPropertyChanged("userlog1");
					this.Onuserlog1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_date", DbType="DateTime NOT NULL", IsDbGenerated=true)]
		public System.DateTime date
		{
			get
			{
				return this._date;
			}
			set
			{
				if ((this._date != value))
				{
					this.OndateChanging(value);
					this.SendPropertyChanging();
					this._date = value;
					this.SendPropertyChanged("date");
					this.OndateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[only]", Storage="_only", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true, IsDbGenerated=true)]
		public System.Guid only
		{
			get
			{
				return this._only;
			}
			set
			{
				if ((this._only != value))
				{
					this.OnonlyChanging(value);
					this.SendPropertyChanging();
					this._only = value;
					this.SendPropertyChanged("only");
					this.OnonlyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IP", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string IP
		{
			get
			{
				return this._IP;
			}
			set
			{
				if ((this._IP != value))
				{
					this.OnIPChanging(value);
					this.SendPropertyChanging();
					this._IP = value;
					this.SendPropertyChanged("IP");
					this.OnIPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_hostname", DbType="NVarChar(50)")]
		public string hostname
		{
			get
			{
				return this._hostname;
			}
			set
			{
				if ((this._hostname != value))
				{
					this.OnhostnameChanging(value);
					this.SendPropertyChanging();
					this._hostname = value;
					this.SendPropertyChanged("hostname");
					this.OnhostnameChanged();
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
	}
}
#pragma warning restore 1591
