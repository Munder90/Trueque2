﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Trueques
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="TRK")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void InsertCategoria(Categoria instance);
    partial void UpdateCategoria(Categoria instance);
    partial void DeleteCategoria(Categoria instance);
    partial void InsertUsuario(Usuario instance);
    partial void UpdateUsuario(Usuario instance);
    partial void DeleteUsuario(Usuario instance);
    partial void InsertEtiqueta(Etiqueta instance);
    partial void UpdateEtiqueta(Etiqueta instance);
    partial void DeleteEtiqueta(Etiqueta instance);
    partial void InsertProducto_B(Producto_B instance);
    partial void UpdateProducto_B(Producto_B instance);
    partial void DeleteProducto_B(Producto_B instance);
    partial void InsertProducto_T(Producto_T instance);
    partial void UpdateProducto_T(Producto_T instance);
    partial void DeleteProducto_T(Producto_T instance);
    partial void InsertTrueque(Trueque instance);
    partial void UpdateTrueque(Trueque instance);
    partial void DeleteTrueque(Trueque instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["TRKConnectionString"].ConnectionString, mappingSource)
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
		
		public System.Data.Linq.Table<Categoria> Categoria
		{
			get
			{
				return this.GetTable<Categoria>();
			}
		}
		
		public System.Data.Linq.Table<Usuario> Usuario
		{
			get
			{
				return this.GetTable<Usuario>();
			}
		}
		
		public System.Data.Linq.Table<Etiqueta> Etiqueta
		{
			get
			{
				return this.GetTable<Etiqueta>();
			}
		}
		
		public System.Data.Linq.Table<Producto_B> Producto_B
		{
			get
			{
				return this.GetTable<Producto_B>();
			}
		}
		
		public System.Data.Linq.Table<Producto_T> Producto_T
		{
			get
			{
				return this.GetTable<Producto_T>();
			}
		}
		
		public System.Data.Linq.Table<Trueque> Trueque
		{
			get
			{
				return this.GetTable<Trueque>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Categoria")]
	public partial class Categoria : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idCategoria;
		
		private string _nombreCat;
		
		private EntitySet<Producto_T> _Producto_T;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidCategoriaChanging(int value);
    partial void OnidCategoriaChanged();
    partial void OnnombreCatChanging(string value);
    partial void OnnombreCatChanged();
    #endregion
		
		public Categoria()
		{
			this._Producto_T = new EntitySet<Producto_T>(new Action<Producto_T>(this.attach_Producto_T), new Action<Producto_T>(this.detach_Producto_T));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idCategoria", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int idCategoria
		{
			get
			{
				return this._idCategoria;
			}
			set
			{
				if ((this._idCategoria != value))
				{
					this.OnidCategoriaChanging(value);
					this.SendPropertyChanging();
					this._idCategoria = value;
					this.SendPropertyChanged("idCategoria");
					this.OnidCategoriaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombreCat", DbType="VarChar(50)")]
		public string nombreCat
		{
			get
			{
				return this._nombreCat;
			}
			set
			{
				if ((this._nombreCat != value))
				{
					this.OnnombreCatChanging(value);
					this.SendPropertyChanging();
					this._nombreCat = value;
					this.SendPropertyChanged("nombreCat");
					this.OnnombreCatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Categoria_Producto_T", Storage="_Producto_T", ThisKey="idCategoria", OtherKey="idCategoria")]
		public EntitySet<Producto_T> Producto_T
		{
			get
			{
				return this._Producto_T;
			}
			set
			{
				this._Producto_T.Assign(value);
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
		
		private void attach_Producto_T(Producto_T entity)
		{
			this.SendPropertyChanging();
			entity.Categoria = this;
		}
		
		private void detach_Producto_T(Producto_T entity)
		{
			this.SendPropertyChanging();
			entity.Categoria = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Usuario")]
	public partial class Usuario : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idUsuario;
		
		private string _Nombre;
		
		private string _Apodo;
		
		private string _Ciudad;
		
		private string _Telefono;
		
		private string _Email;
		
		private string _Password;
		
		private string _Fecha_Nacimiento;
		
		private string _Nombre_Mascota;
		
		private string _Imagen_Perfil;
		
		private EntitySet<Producto_T> _Producto_T;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidUsuarioChanging(int value);
    partial void OnidUsuarioChanged();
    partial void OnNombreChanging(string value);
    partial void OnNombreChanged();
    partial void OnApodoChanging(string value);
    partial void OnApodoChanged();
    partial void OnCiudadChanging(string value);
    partial void OnCiudadChanged();
    partial void OnTelefonoChanging(string value);
    partial void OnTelefonoChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnFecha_NacimientoChanging(string value);
    partial void OnFecha_NacimientoChanged();
    partial void OnNombre_MascotaChanging(string value);
    partial void OnNombre_MascotaChanged();
    partial void OnImagen_PerfilChanging(string value);
    partial void OnImagen_PerfilChanged();
    #endregion
		
		public Usuario()
		{
			this._Producto_T = new EntitySet<Producto_T>(new Action<Producto_T>(this.attach_Producto_T), new Action<Producto_T>(this.detach_Producto_T));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idUsuario", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int idUsuario
		{
			get
			{
				return this._idUsuario;
			}
			set
			{
				if ((this._idUsuario != value))
				{
					this.OnidUsuarioChanging(value);
					this.SendPropertyChanging();
					this._idUsuario = value;
					this.SendPropertyChanged("idUsuario");
					this.OnidUsuarioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="VarChar(50)")]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this.OnNombreChanging(value);
					this.SendPropertyChanging();
					this._Nombre = value;
					this.SendPropertyChanged("Nombre");
					this.OnNombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Apodo", DbType="VarChar(50)")]
		public string Apodo
		{
			get
			{
				return this._Apodo;
			}
			set
			{
				if ((this._Apodo != value))
				{
					this.OnApodoChanging(value);
					this.SendPropertyChanging();
					this._Apodo = value;
					this.SendPropertyChanged("Apodo");
					this.OnApodoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ciudad", DbType="VarChar(50)")]
		public string Ciudad
		{
			get
			{
				return this._Ciudad;
			}
			set
			{
				if ((this._Ciudad != value))
				{
					this.OnCiudadChanging(value);
					this.SendPropertyChanging();
					this._Ciudad = value;
					this.SendPropertyChanged("Ciudad");
					this.OnCiudadChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Telefono", DbType="VarChar(50)")]
		public string Telefono
		{
			get
			{
				return this._Telefono;
			}
			set
			{
				if ((this._Telefono != value))
				{
					this.OnTelefonoChanging(value);
					this.SendPropertyChanging();
					this._Telefono = value;
					this.SendPropertyChanged("Telefono");
					this.OnTelefonoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(50)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(50)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fecha_Nacimiento", DbType="VarChar(50)")]
		public string Fecha_Nacimiento
		{
			get
			{
				return this._Fecha_Nacimiento;
			}
			set
			{
				if ((this._Fecha_Nacimiento != value))
				{
					this.OnFecha_NacimientoChanging(value);
					this.SendPropertyChanging();
					this._Fecha_Nacimiento = value;
					this.SendPropertyChanged("Fecha_Nacimiento");
					this.OnFecha_NacimientoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre_Mascota", DbType="VarChar(50)")]
		public string Nombre_Mascota
		{
			get
			{
				return this._Nombre_Mascota;
			}
			set
			{
				if ((this._Nombre_Mascota != value))
				{
					this.OnNombre_MascotaChanging(value);
					this.SendPropertyChanging();
					this._Nombre_Mascota = value;
					this.SendPropertyChanged("Nombre_Mascota");
					this.OnNombre_MascotaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Imagen_Perfil", DbType="VarChar(50)")]
		public string Imagen_Perfil
		{
			get
			{
				return this._Imagen_Perfil;
			}
			set
			{
				if ((this._Imagen_Perfil != value))
				{
					this.OnImagen_PerfilChanging(value);
					this.SendPropertyChanging();
					this._Imagen_Perfil = value;
					this.SendPropertyChanged("Imagen_Perfil");
					this.OnImagen_PerfilChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Usuario_Producto_T", Storage="_Producto_T", ThisKey="idUsuario", OtherKey="idUsuario")]
		public EntitySet<Producto_T> Producto_T
		{
			get
			{
				return this._Producto_T;
			}
			set
			{
				this._Producto_T.Assign(value);
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
		
		private void attach_Producto_T(Producto_T entity)
		{
			this.SendPropertyChanging();
			entity.Usuario = this;
		}
		
		private void detach_Producto_T(Producto_T entity)
		{
			this.SendPropertyChanging();
			entity.Usuario = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Etiqueta")]
	public partial class Etiqueta : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idEtiqueta;
		
		private string _descripcion;
		
		private EntitySet<Producto_B> _Producto_B;
		
		private EntitySet<Producto_T> _Producto_T;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidEtiquetaChanging(int value);
    partial void OnidEtiquetaChanged();
    partial void OndescripcionChanging(string value);
    partial void OndescripcionChanged();
    #endregion
		
		public Etiqueta()
		{
			this._Producto_B = new EntitySet<Producto_B>(new Action<Producto_B>(this.attach_Producto_B), new Action<Producto_B>(this.detach_Producto_B));
			this._Producto_T = new EntitySet<Producto_T>(new Action<Producto_T>(this.attach_Producto_T), new Action<Producto_T>(this.detach_Producto_T));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idEtiqueta", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int idEtiqueta
		{
			get
			{
				return this._idEtiqueta;
			}
			set
			{
				if ((this._idEtiqueta != value))
				{
					this.OnidEtiquetaChanging(value);
					this.SendPropertyChanging();
					this._idEtiqueta = value;
					this.SendPropertyChanged("idEtiqueta");
					this.OnidEtiquetaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_descripcion", DbType="VarChar(50)")]
		public string descripcion
		{
			get
			{
				return this._descripcion;
			}
			set
			{
				if ((this._descripcion != value))
				{
					this.OndescripcionChanging(value);
					this.SendPropertyChanging();
					this._descripcion = value;
					this.SendPropertyChanged("descripcion");
					this.OndescripcionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Etiqueta_Producto_B", Storage="_Producto_B", ThisKey="idEtiqueta", OtherKey="idEtiquetaB")]
		public EntitySet<Producto_B> Producto_B
		{
			get
			{
				return this._Producto_B;
			}
			set
			{
				this._Producto_B.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Etiqueta_Producto_T", Storage="_Producto_T", ThisKey="idEtiqueta", OtherKey="idEtiqueta")]
		public EntitySet<Producto_T> Producto_T
		{
			get
			{
				return this._Producto_T;
			}
			set
			{
				this._Producto_T.Assign(value);
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
		
		private void attach_Producto_B(Producto_B entity)
		{
			this.SendPropertyChanging();
			entity.Etiqueta = this;
		}
		
		private void detach_Producto_B(Producto_B entity)
		{
			this.SendPropertyChanging();
			entity.Etiqueta = null;
		}
		
		private void attach_Producto_T(Producto_T entity)
		{
			this.SendPropertyChanging();
			entity.Etiqueta = this;
		}
		
		private void detach_Producto_T(Producto_T entity)
		{
			this.SendPropertyChanging();
			entity.Etiqueta = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Producto_B")]
	public partial class Producto_B : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idProductoB;
		
		private string _nombreProductoB;
		
		private System.Data.Linq.Binary _imgProductoB;
		
		private System.Nullable<int> _idEtiquetaB;
		
		private System.Nullable<int> _idProductoT;
		
		private EntitySet<Trueque> _Trueque;
		
		private EntityRef<Etiqueta> _Etiqueta;
		
		private EntityRef<Producto_T> _Producto_T;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidProductoBChanging(int value);
    partial void OnidProductoBChanged();
    partial void OnnombreProductoBChanging(string value);
    partial void OnnombreProductoBChanged();
    partial void OnimgProductoBChanging(System.Data.Linq.Binary value);
    partial void OnimgProductoBChanged();
    partial void OnidEtiquetaBChanging(System.Nullable<int> value);
    partial void OnidEtiquetaBChanged();
    partial void OnidProductoTChanging(System.Nullable<int> value);
    partial void OnidProductoTChanged();
    #endregion
		
		public Producto_B()
		{
			this._Trueque = new EntitySet<Trueque>(new Action<Trueque>(this.attach_Trueque), new Action<Trueque>(this.detach_Trueque));
			this._Etiqueta = default(EntityRef<Etiqueta>);
			this._Producto_T = default(EntityRef<Producto_T>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idProductoB", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int idProductoB
		{
			get
			{
				return this._idProductoB;
			}
			set
			{
				if ((this._idProductoB != value))
				{
					this.OnidProductoBChanging(value);
					this.SendPropertyChanging();
					this._idProductoB = value;
					this.SendPropertyChanged("idProductoB");
					this.OnidProductoBChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombreProductoB", DbType="VarChar(50)")]
		public string nombreProductoB
		{
			get
			{
				return this._nombreProductoB;
			}
			set
			{
				if ((this._nombreProductoB != value))
				{
					this.OnnombreProductoBChanging(value);
					this.SendPropertyChanging();
					this._nombreProductoB = value;
					this.SendPropertyChanged("nombreProductoB");
					this.OnnombreProductoBChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_imgProductoB", DbType="Image", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary imgProductoB
		{
			get
			{
				return this._imgProductoB;
			}
			set
			{
				if ((this._imgProductoB != value))
				{
					this.OnimgProductoBChanging(value);
					this.SendPropertyChanging();
					this._imgProductoB = value;
					this.SendPropertyChanged("imgProductoB");
					this.OnimgProductoBChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idEtiquetaB", DbType="Int")]
		public System.Nullable<int> idEtiquetaB
		{
			get
			{
				return this._idEtiquetaB;
			}
			set
			{
				if ((this._idEtiquetaB != value))
				{
					if (this._Etiqueta.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidEtiquetaBChanging(value);
					this.SendPropertyChanging();
					this._idEtiquetaB = value;
					this.SendPropertyChanged("idEtiquetaB");
					this.OnidEtiquetaBChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idProductoT", DbType="Int")]
		public System.Nullable<int> idProductoT
		{
			get
			{
				return this._idProductoT;
			}
			set
			{
				if ((this._idProductoT != value))
				{
					if (this._Producto_T.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidProductoTChanging(value);
					this.SendPropertyChanging();
					this._idProductoT = value;
					this.SendPropertyChanged("idProductoT");
					this.OnidProductoTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Producto_B_Trueque", Storage="_Trueque", ThisKey="idProductoB", OtherKey="idProductoB")]
		public EntitySet<Trueque> Trueque
		{
			get
			{
				return this._Trueque;
			}
			set
			{
				this._Trueque.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Etiqueta_Producto_B", Storage="_Etiqueta", ThisKey="idEtiquetaB", OtherKey="idEtiqueta", IsForeignKey=true)]
		public Etiqueta Etiqueta
		{
			get
			{
				return this._Etiqueta.Entity;
			}
			set
			{
				Etiqueta previousValue = this._Etiqueta.Entity;
				if (((previousValue != value) 
							|| (this._Etiqueta.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Etiqueta.Entity = null;
						previousValue.Producto_B.Remove(this);
					}
					this._Etiqueta.Entity = value;
					if ((value != null))
					{
						value.Producto_B.Add(this);
						this._idEtiquetaB = value.idEtiqueta;
					}
					else
					{
						this._idEtiquetaB = default(Nullable<int>);
					}
					this.SendPropertyChanged("Etiqueta");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Producto_T_Producto_B", Storage="_Producto_T", ThisKey="idProductoT", OtherKey="idProductoT", IsForeignKey=true)]
		public Producto_T Producto_T
		{
			get
			{
				return this._Producto_T.Entity;
			}
			set
			{
				Producto_T previousValue = this._Producto_T.Entity;
				if (((previousValue != value) 
							|| (this._Producto_T.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Producto_T.Entity = null;
						previousValue.Producto_B.Remove(this);
					}
					this._Producto_T.Entity = value;
					if ((value != null))
					{
						value.Producto_B.Add(this);
						this._idProductoT = value.idProductoT;
					}
					else
					{
						this._idProductoT = default(Nullable<int>);
					}
					this.SendPropertyChanged("Producto_T");
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
		
		private void attach_Trueque(Trueque entity)
		{
			this.SendPropertyChanging();
			entity.Producto_B = this;
		}
		
		private void detach_Trueque(Trueque entity)
		{
			this.SendPropertyChanging();
			entity.Producto_B = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Producto_T")]
	public partial class Producto_T : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idProductoT;
		
		private string _nombreProductoT;
		
		private System.Data.Linq.Binary _imgProductoT;
		
		private System.Nullable<int> _idUsuario;
		
		private System.Nullable<int> _idCategoria;
		
		private System.Nullable<int> _idEtiqueta;
		
		private EntitySet<Producto_B> _Producto_B;
		
		private EntitySet<Trueque> _Trueque;
		
		private EntityRef<Categoria> _Categoria;
		
		private EntityRef<Etiqueta> _Etiqueta;
		
		private EntityRef<Usuario> _Usuario;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidProductoTChanging(int value);
    partial void OnidProductoTChanged();
    partial void OnnombreProductoTChanging(string value);
    partial void OnnombreProductoTChanged();
    partial void OnimgProductoTChanging(System.Data.Linq.Binary value);
    partial void OnimgProductoTChanged();
    partial void OnidUsuarioChanging(System.Nullable<int> value);
    partial void OnidUsuarioChanged();
    partial void OnidCategoriaChanging(System.Nullable<int> value);
    partial void OnidCategoriaChanged();
    partial void OnidEtiquetaChanging(System.Nullable<int> value);
    partial void OnidEtiquetaChanged();
    #endregion
		
		public Producto_T()
		{
			this._Producto_B = new EntitySet<Producto_B>(new Action<Producto_B>(this.attach_Producto_B), new Action<Producto_B>(this.detach_Producto_B));
			this._Trueque = new EntitySet<Trueque>(new Action<Trueque>(this.attach_Trueque), new Action<Trueque>(this.detach_Trueque));
			this._Categoria = default(EntityRef<Categoria>);
			this._Etiqueta = default(EntityRef<Etiqueta>);
			this._Usuario = default(EntityRef<Usuario>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idProductoT", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int idProductoT
		{
			get
			{
				return this._idProductoT;
			}
			set
			{
				if ((this._idProductoT != value))
				{
					this.OnidProductoTChanging(value);
					this.SendPropertyChanging();
					this._idProductoT = value;
					this.SendPropertyChanged("idProductoT");
					this.OnidProductoTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombreProductoT", DbType="VarChar(50)")]
		public string nombreProductoT
		{
			get
			{
				return this._nombreProductoT;
			}
			set
			{
				if ((this._nombreProductoT != value))
				{
					this.OnnombreProductoTChanging(value);
					this.SendPropertyChanging();
					this._nombreProductoT = value;
					this.SendPropertyChanged("nombreProductoT");
					this.OnnombreProductoTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_imgProductoT", DbType="Image", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary imgProductoT
		{
			get
			{
				return this._imgProductoT;
			}
			set
			{
				if ((this._imgProductoT != value))
				{
					this.OnimgProductoTChanging(value);
					this.SendPropertyChanging();
					this._imgProductoT = value;
					this.SendPropertyChanged("imgProductoT");
					this.OnimgProductoTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idUsuario", DbType="Int")]
		public System.Nullable<int> idUsuario
		{
			get
			{
				return this._idUsuario;
			}
			set
			{
				if ((this._idUsuario != value))
				{
					if (this._Usuario.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidUsuarioChanging(value);
					this.SendPropertyChanging();
					this._idUsuario = value;
					this.SendPropertyChanged("idUsuario");
					this.OnidUsuarioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idCategoria", DbType="Int")]
		public System.Nullable<int> idCategoria
		{
			get
			{
				return this._idCategoria;
			}
			set
			{
				if ((this._idCategoria != value))
				{
					if (this._Categoria.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidCategoriaChanging(value);
					this.SendPropertyChanging();
					this._idCategoria = value;
					this.SendPropertyChanged("idCategoria");
					this.OnidCategoriaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idEtiqueta", DbType="Int")]
		public System.Nullable<int> idEtiqueta
		{
			get
			{
				return this._idEtiqueta;
			}
			set
			{
				if ((this._idEtiqueta != value))
				{
					if (this._Etiqueta.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidEtiquetaChanging(value);
					this.SendPropertyChanging();
					this._idEtiqueta = value;
					this.SendPropertyChanged("idEtiqueta");
					this.OnidEtiquetaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Producto_T_Producto_B", Storage="_Producto_B", ThisKey="idProductoT", OtherKey="idProductoT")]
		public EntitySet<Producto_B> Producto_B
		{
			get
			{
				return this._Producto_B;
			}
			set
			{
				this._Producto_B.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Producto_T_Trueque", Storage="_Trueque", ThisKey="idProductoT", OtherKey="idProductoT")]
		public EntitySet<Trueque> Trueque
		{
			get
			{
				return this._Trueque;
			}
			set
			{
				this._Trueque.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Categoria_Producto_T", Storage="_Categoria", ThisKey="idCategoria", OtherKey="idCategoria", IsForeignKey=true)]
		public Categoria Categoria
		{
			get
			{
				return this._Categoria.Entity;
			}
			set
			{
				Categoria previousValue = this._Categoria.Entity;
				if (((previousValue != value) 
							|| (this._Categoria.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Categoria.Entity = null;
						previousValue.Producto_T.Remove(this);
					}
					this._Categoria.Entity = value;
					if ((value != null))
					{
						value.Producto_T.Add(this);
						this._idCategoria = value.idCategoria;
					}
					else
					{
						this._idCategoria = default(Nullable<int>);
					}
					this.SendPropertyChanged("Categoria");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Etiqueta_Producto_T", Storage="_Etiqueta", ThisKey="idEtiqueta", OtherKey="idEtiqueta", IsForeignKey=true)]
		public Etiqueta Etiqueta
		{
			get
			{
				return this._Etiqueta.Entity;
			}
			set
			{
				Etiqueta previousValue = this._Etiqueta.Entity;
				if (((previousValue != value) 
							|| (this._Etiqueta.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Etiqueta.Entity = null;
						previousValue.Producto_T.Remove(this);
					}
					this._Etiqueta.Entity = value;
					if ((value != null))
					{
						value.Producto_T.Add(this);
						this._idEtiqueta = value.idEtiqueta;
					}
					else
					{
						this._idEtiqueta = default(Nullable<int>);
					}
					this.SendPropertyChanged("Etiqueta");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Usuario_Producto_T", Storage="_Usuario", ThisKey="idUsuario", OtherKey="idUsuario", IsForeignKey=true)]
		public Usuario Usuario
		{
			get
			{
				return this._Usuario.Entity;
			}
			set
			{
				Usuario previousValue = this._Usuario.Entity;
				if (((previousValue != value) 
							|| (this._Usuario.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Usuario.Entity = null;
						previousValue.Producto_T.Remove(this);
					}
					this._Usuario.Entity = value;
					if ((value != null))
					{
						value.Producto_T.Add(this);
						this._idUsuario = value.idUsuario;
					}
					else
					{
						this._idUsuario = default(Nullable<int>);
					}
					this.SendPropertyChanged("Usuario");
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
		
		private void attach_Producto_B(Producto_B entity)
		{
			this.SendPropertyChanging();
			entity.Producto_T = this;
		}
		
		private void detach_Producto_B(Producto_B entity)
		{
			this.SendPropertyChanging();
			entity.Producto_T = null;
		}
		
		private void attach_Trueque(Trueque entity)
		{
			this.SendPropertyChanging();
			entity.Producto_T = this;
		}
		
		private void detach_Trueque(Trueque entity)
		{
			this.SendPropertyChanging();
			entity.Producto_T = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Trueque")]
	public partial class Trueque : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idTrueque;
		
		private System.Nullable<bool> _Estatus;
		
		private System.Nullable<int> _idProductoT;
		
		private System.Nullable<int> _idProductoB;
		
		private EntityRef<Producto_B> _Producto_B;
		
		private EntityRef<Producto_T> _Producto_T;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidTruequeChanging(int value);
    partial void OnidTruequeChanged();
    partial void OnEstatusChanging(System.Nullable<bool> value);
    partial void OnEstatusChanged();
    partial void OnidProductoTChanging(System.Nullable<int> value);
    partial void OnidProductoTChanged();
    partial void OnidProductoBChanging(System.Nullable<int> value);
    partial void OnidProductoBChanged();
    #endregion
		
		public Trueque()
		{
			this._Producto_B = default(EntityRef<Producto_B>);
			this._Producto_T = default(EntityRef<Producto_T>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idTrueque", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int idTrueque
		{
			get
			{
				return this._idTrueque;
			}
			set
			{
				if ((this._idTrueque != value))
				{
					this.OnidTruequeChanging(value);
					this.SendPropertyChanging();
					this._idTrueque = value;
					this.SendPropertyChanged("idTrueque");
					this.OnidTruequeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Estatus", DbType="Bit")]
		public System.Nullable<bool> Estatus
		{
			get
			{
				return this._Estatus;
			}
			set
			{
				if ((this._Estatus != value))
				{
					this.OnEstatusChanging(value);
					this.SendPropertyChanging();
					this._Estatus = value;
					this.SendPropertyChanged("Estatus");
					this.OnEstatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idProductoT", DbType="Int")]
		public System.Nullable<int> idProductoT
		{
			get
			{
				return this._idProductoT;
			}
			set
			{
				if ((this._idProductoT != value))
				{
					if (this._Producto_T.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidProductoTChanging(value);
					this.SendPropertyChanging();
					this._idProductoT = value;
					this.SendPropertyChanged("idProductoT");
					this.OnidProductoTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idProductoB", DbType="Int")]
		public System.Nullable<int> idProductoB
		{
			get
			{
				return this._idProductoB;
			}
			set
			{
				if ((this._idProductoB != value))
				{
					if (this._Producto_B.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidProductoBChanging(value);
					this.SendPropertyChanging();
					this._idProductoB = value;
					this.SendPropertyChanged("idProductoB");
					this.OnidProductoBChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Producto_B_Trueque", Storage="_Producto_B", ThisKey="idProductoB", OtherKey="idProductoB", IsForeignKey=true)]
		public Producto_B Producto_B
		{
			get
			{
				return this._Producto_B.Entity;
			}
			set
			{
				Producto_B previousValue = this._Producto_B.Entity;
				if (((previousValue != value) 
							|| (this._Producto_B.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Producto_B.Entity = null;
						previousValue.Trueque.Remove(this);
					}
					this._Producto_B.Entity = value;
					if ((value != null))
					{
						value.Trueque.Add(this);
						this._idProductoB = value.idProductoB;
					}
					else
					{
						this._idProductoB = default(Nullable<int>);
					}
					this.SendPropertyChanged("Producto_B");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Producto_T_Trueque", Storage="_Producto_T", ThisKey="idProductoT", OtherKey="idProductoT", IsForeignKey=true)]
		public Producto_T Producto_T
		{
			get
			{
				return this._Producto_T.Entity;
			}
			set
			{
				Producto_T previousValue = this._Producto_T.Entity;
				if (((previousValue != value) 
							|| (this._Producto_T.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Producto_T.Entity = null;
						previousValue.Trueque.Remove(this);
					}
					this._Producto_T.Entity = value;
					if ((value != null))
					{
						value.Trueque.Add(this);
						this._idProductoT = value.idProductoT;
					}
					else
					{
						this._idProductoT = default(Nullable<int>);
					}
					this.SendPropertyChanged("Producto_T");
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
