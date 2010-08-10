﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4927
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcForum.Models
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	
	
	[System.Data.Linq.Mapping.DatabaseAttribute(Name="MvcForum")]
	public partial class MvcForumDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertQuestion(MvcForum.Question instance);
    partial void UpdateQuestion(MvcForum.Question instance);
    partial void DeleteQuestion(MvcForum.Question instance);
    partial void InsertAnswer(MvcForum.Answer instance);
    partial void UpdateAnswer(MvcForum.Answer instance);
    partial void DeleteAnswer(MvcForum.Answer instance);
    partial void InsertUser(MvcForum.User instance);
    partial void UpdateUser(MvcForum.User instance);
    partial void DeleteUser(MvcForum.User instance);
    #endregion
		
		public MvcForumDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["MvcForumConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public MvcForumDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MvcForumDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MvcForumDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MvcForumDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<MvcForum.Question> Questions
		{
			get
			{
				return this.GetTable<MvcForum.Question>();
			}
		}
		
		public System.Data.Linq.Table<MvcForum.Answer> Answers
		{
			get
			{
				return this.GetTable<MvcForum.Answer>();
			}
		}
		
		public System.Data.Linq.Table<MvcForum.User> Users
		{
			get
			{
				return this.GetTable<MvcForum.User>();
			}
		}
	}
}
namespace MvcForum
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.ComponentModel;
	using System;
	
	
	[Table(Name="dbo.Questions")]
	public partial class Question : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _Id;
		
		private string _Title;
		
		private string _Body;
		
		private System.DateTime _CreatedOn;
		
		private EntitySet<Answer> _Answers;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(long value);
    partial void OnIdChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnBodyChanging(string value);
    partial void OnBodyChanged();
    partial void OnCreatedOnChanging(System.DateTime value);
    partial void OnCreatedOnChanged();
    #endregion
		
		public Question()
		{
			this._Answers = new EntitySet<Answer>(new Action<Answer>(this.attach_Answers), new Action<Answer>(this.detach_Answers));
			OnCreated();
		}
		
		[Column(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long Id
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
		
		[Column(Storage="_Title", DbType="VarChar(300) NOT NULL", CanBeNull=false)]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this.OnTitleChanging(value);
					this.SendPropertyChanging();
					this._Title = value;
					this.SendPropertyChanged("Title");
					this.OnTitleChanged();
				}
			}
		}
		
		[Column(Storage="_Body", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Body
		{
			get
			{
				return this._Body;
			}
			set
			{
				if ((this._Body != value))
				{
					this.OnBodyChanging(value);
					this.SendPropertyChanging();
					this._Body = value;
					this.SendPropertyChanged("Body");
					this.OnBodyChanged();
				}
			}
		}
		
		[Column(Storage="_CreatedOn", DbType="SmallDateTime NOT NULL")]
		public System.DateTime CreatedOn
		{
			get
			{
				return this._CreatedOn;
			}
			set
			{
				if ((this._CreatedOn != value))
				{
					this.OnCreatedOnChanging(value);
					this.SendPropertyChanging();
					this._CreatedOn = value;
					this.SendPropertyChanged("CreatedOn");
					this.OnCreatedOnChanged();
				}
			}
		}
		
		[Association(Name="Question_Answer", Storage="_Answers", ThisKey="Id", OtherKey="QuestionId")]
		public EntitySet<Answer> Answers
		{
			get
			{
				return this._Answers;
			}
			set
			{
				this._Answers.Assign(value);
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
		
		private void attach_Answers(Answer entity)
		{
			this.SendPropertyChanging();
			entity.Question = this;
		}
		
		private void detach_Answers(Answer entity)
		{
			this.SendPropertyChanging();
			entity.Question = null;
		}
	}
	
	[Table(Name="dbo.Answers")]
	public partial class Answer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _Id;
		
		private long _QuestionId;
		
		private string _Body;
		
		private System.DateTime _CreatedOn;
		
		private EntityRef<Question> _Question;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(long value);
    partial void OnIdChanged();
    partial void OnQuestionIdChanging(long value);
    partial void OnQuestionIdChanged();
    partial void OnBodyChanging(string value);
    partial void OnBodyChanged();
    partial void OnCreatedOnChanging(System.DateTime value);
    partial void OnCreatedOnChanged();
    #endregion
		
		public Answer()
		{
			this._Question = default(EntityRef<Question>);
			OnCreated();
		}
		
		[Column(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long Id
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
		
		[Column(Storage="_QuestionId", DbType="BigInt NOT NULL")]
		public long QuestionId
		{
			get
			{
				return this._QuestionId;
			}
			set
			{
				if ((this._QuestionId != value))
				{
					if (this._Question.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnQuestionIdChanging(value);
					this.SendPropertyChanging();
					this._QuestionId = value;
					this.SendPropertyChanged("QuestionId");
					this.OnQuestionIdChanged();
				}
			}
		}
		
		[Column(Storage="_Body", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Body
		{
			get
			{
				return this._Body;
			}
			set
			{
				if ((this._Body != value))
				{
					this.OnBodyChanging(value);
					this.SendPropertyChanging();
					this._Body = value;
					this.SendPropertyChanged("Body");
					this.OnBodyChanged();
				}
			}
		}
		
		[Column(Storage="_CreatedOn", DbType="SmallDateTime NOT NULL")]
		public System.DateTime CreatedOn
		{
			get
			{
				return this._CreatedOn;
			}
			set
			{
				if ((this._CreatedOn != value))
				{
					this.OnCreatedOnChanging(value);
					this.SendPropertyChanging();
					this._CreatedOn = value;
					this.SendPropertyChanged("CreatedOn");
					this.OnCreatedOnChanged();
				}
			}
		}
		
		[Association(Name="Question_Answer", Storage="_Question", ThisKey="QuestionId", OtherKey="Id", IsForeignKey=true)]
		public Question Question
		{
			get
			{
				return this._Question.Entity;
			}
			set
			{
				Question previousValue = this._Question.Entity;
				if (((previousValue != value) 
							|| (this._Question.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Question.Entity = null;
						previousValue.Answers.Remove(this);
					}
					this._Question.Entity = value;
					if ((value != null))
					{
						value.Answers.Add(this);
						this._QuestionId = value.Id;
					}
					else
					{
						this._QuestionId = default(long);
					}
					this.SendPropertyChanged("Question");
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
	
	[Table(Name="dbo.Users")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _Id;
		
		private string _UserName;
		
		private string _Password;
		
		private System.DateTime _CreatedOn;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(long value);
    partial void OnIdChanged();
    partial void OnUserNameChanging(string value);
    partial void OnUserNameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnCreatedOnChanging(System.DateTime value);
    partial void OnCreatedOnChanged();
    #endregion
		
		public User()
		{
			OnCreated();
		}
		
		[Column(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long Id
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
		
		[Column(Storage="_UserName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string UserName
		{
			get
			{
				return this._UserName;
			}
			set
			{
				if ((this._UserName != value))
				{
					this.OnUserNameChanging(value);
					this.SendPropertyChanging();
					this._UserName = value;
					this.SendPropertyChanged("UserName");
					this.OnUserNameChanged();
				}
			}
		}
		
		[Column(Storage="_Password", DbType="VarChar(200) NOT NULL", CanBeNull=false)]
		public string Password
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
		
		[Column(Storage="_CreatedOn", DbType="SmallDateTime NOT NULL")]
		public System.DateTime CreatedOn
		{
			get
			{
				return this._CreatedOn;
			}
			set
			{
				if ((this._CreatedOn != value))
				{
					this.OnCreatedOnChanging(value);
					this.SendPropertyChanging();
					this._CreatedOn = value;
					this.SendPropertyChanged("CreatedOn");
					this.OnCreatedOnChanged();
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