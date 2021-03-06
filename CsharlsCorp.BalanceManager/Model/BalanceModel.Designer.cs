﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]
#region Metadatos de relaciones en EDM

[assembly: EdmRelationshipAttribute("BalanceModel", "MoneyDetailBills", "Bill", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(CsharlsCorp.BalanceManager.Model.Bill), "MoneyDetail", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(CsharlsCorp.BalanceManager.Model.MoneyDetail), true)]
[assembly: EdmRelationshipAttribute("BalanceModel", "DetailForMoneyDetails", "Detail", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(CsharlsCorp.BalanceManager.Model.Detail), "MoneyDetail", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(CsharlsCorp.BalanceManager.Model.MoneyDetail), true)]
[assembly: EdmRelationshipAttribute("BalanceModel", "TransactionDetail", "Transaction", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(CsharlsCorp.BalanceManager.Model.Transaction), "Detail", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(CsharlsCorp.BalanceManager.Model.Detail), true)]
[assembly: EdmRelationshipAttribute("BalanceModel", "TypeOfTransaction", "Type", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(CsharlsCorp.BalanceManager.Model.Type), "Transaction", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(CsharlsCorp.BalanceManager.Model.Transaction), true)]

#endregion

namespace CsharlsCorp.BalanceManager.Model
{
    #region Contextos
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    public partial class BalanceEntities : ObjectContext
    {
        #region Constructores
    
        /// <summary>
        /// Inicializa un nuevo objeto BalanceEntities usando la cadena de conexión encontrada en la sección 'BalanceEntities' del archivo de configuración de la aplicación.
        /// </summary>
        public BalanceEntities() : base("name=BalanceEntities", "BalanceEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Inicializar un nuevo objeto BalanceEntities.
        /// </summary>
        public BalanceEntities(string connectionString) : base(connectionString, "BalanceEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Inicializar un nuevo objeto BalanceEntities.
        /// </summary>
        public BalanceEntities(EntityConnection connection) : base(connection, "BalanceEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Métodos parciales
    
        partial void OnContextCreated();
    
        #endregion
    
        #region Propiedades de ObjectSet
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        public ObjectSet<Bill> Bills
        {
            get
            {
                if ((_Bills == null))
                {
                    _Bills = base.CreateObjectSet<Bill>("Bills");
                }
                return _Bills;
            }
        }
        private ObjectSet<Bill> _Bills;
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        public ObjectSet<Detail> Details
        {
            get
            {
                if ((_Details == null))
                {
                    _Details = base.CreateObjectSet<Detail>("Details");
                }
                return _Details;
            }
        }
        private ObjectSet<Detail> _Details;
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        public ObjectSet<MoneyDetail> MoneyDetails
        {
            get
            {
                if ((_MoneyDetails == null))
                {
                    _MoneyDetails = base.CreateObjectSet<MoneyDetail>("MoneyDetails");
                }
                return _MoneyDetails;
            }
        }
        private ObjectSet<MoneyDetail> _MoneyDetails;
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        public ObjectSet<Transaction> Transactions
        {
            get
            {
                if ((_Transactions == null))
                {
                    _Transactions = base.CreateObjectSet<Transaction>("Transactions");
                }
                return _Transactions;
            }
        }
        private ObjectSet<Transaction> _Transactions;
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        public ObjectSet<Type> Types
        {
            get
            {
                if ((_Types == null))
                {
                    _Types = base.CreateObjectSet<Type>("Types");
                }
                return _Types;
            }
        }
        private ObjectSet<Type> _Types;

        #endregion
        #region Métodos AddTo
    
        /// <summary>
        /// Método desusado para agregar un nuevo objeto al EntitySet Bills. Considere la posibilidad de usar el método .Add de la propiedad ObjectSet&lt;T&gt; asociada.
        /// </summary>
        public void AddToBills(Bill bill)
        {
            base.AddObject("Bills", bill);
        }
    
        /// <summary>
        /// Método desusado para agregar un nuevo objeto al EntitySet Details. Considere la posibilidad de usar el método .Add de la propiedad ObjectSet&lt;T&gt; asociada.
        /// </summary>
        public void AddToDetails(Detail detail)
        {
            base.AddObject("Details", detail);
        }
    
        /// <summary>
        /// Método desusado para agregar un nuevo objeto al EntitySet MoneyDetails. Considere la posibilidad de usar el método .Add de la propiedad ObjectSet&lt;T&gt; asociada.
        /// </summary>
        public void AddToMoneyDetails(MoneyDetail moneyDetail)
        {
            base.AddObject("MoneyDetails", moneyDetail);
        }
    
        /// <summary>
        /// Método desusado para agregar un nuevo objeto al EntitySet Transactions. Considere la posibilidad de usar el método .Add de la propiedad ObjectSet&lt;T&gt; asociada.
        /// </summary>
        public void AddToTransactions(Transaction transaction)
        {
            base.AddObject("Transactions", transaction);
        }
    
        /// <summary>
        /// Método desusado para agregar un nuevo objeto al EntitySet Types. Considere la posibilidad de usar el método .Add de la propiedad ObjectSet&lt;T&gt; asociada.
        /// </summary>
        public void AddToTypes(Type type)
        {
            base.AddObject("Types", type);
        }

        #endregion
    }
    

    #endregion
    
    #region Entidades
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="BalanceModel", Name="Bill")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Bill : EntityObject
    {
        #region Método de generador
    
        /// <summary>
        /// Crear un nuevo objeto Bill.
        /// </summary>
        /// <param name="billId">Valor inicial de la propiedad billId.</param>
        /// <param name="value">Valor inicial de la propiedad value.</param>
        public static Bill CreateBill(global::System.Byte billId, global::System.String value)
        {
            Bill bill = new Bill();
            bill.billId = billId;
            bill.value = value;
            return bill;
        }

        #endregion
        #region Propiedades primitivas
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Byte billId
        {
            get
            {
                return _billId;
            }
            set
            {
                if (_billId != value)
                {
                    OnbillIdChanging(value);
                    ReportPropertyChanging("billId");
                    _billId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("billId");
                    OnbillIdChanged();
                }
            }
        }
        private global::System.Byte _billId;
        partial void OnbillIdChanging(global::System.Byte value);
        partial void OnbillIdChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String value
        {
            get
            {
                return _value;
            }
            set
            {
                OnvalueChanging(value);
                ReportPropertyChanging("value");
                _value = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("value");
                OnvalueChanged();
            }
        }
        private global::System.String _value;
        partial void OnvalueChanging(global::System.String value);
        partial void OnvalueChanged();

        #endregion
    
        #region Propiedades de navegación
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("BalanceModel", "MoneyDetailBills", "MoneyDetail")]
        public EntityCollection<MoneyDetail> MoneyDetails
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<MoneyDetail>("BalanceModel.MoneyDetailBills", "MoneyDetail");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<MoneyDetail>("BalanceModel.MoneyDetailBills", "MoneyDetail", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="BalanceModel", Name="Detail")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Detail : EntityObject
    {
        #region Método de generador
    
        /// <summary>
        /// Crear un nuevo objeto Detail.
        /// </summary>
        /// <param name="detailId">Valor inicial de la propiedad detailId.</param>
        /// <param name="description">Valor inicial de la propiedad description.</param>
        /// <param name="transactionId">Valor inicial de la propiedad transactionId.</param>
        public static Detail CreateDetail(global::System.Int32 detailId, global::System.String description, global::System.Int32 transactionId)
        {
            Detail detail = new Detail();
            detail.detailId = detailId;
            detail.description = description;
            detail.transactionId = transactionId;
            return detail;
        }

        #endregion
        #region Propiedades primitivas
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 detailId
        {
            get
            {
                return _detailId;
            }
            set
            {
                if (_detailId != value)
                {
                    OndetailIdChanging(value);
                    ReportPropertyChanging("detailId");
                    _detailId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("detailId");
                    OndetailIdChanged();
                }
            }
        }
        private global::System.Int32 _detailId;
        partial void OndetailIdChanging(global::System.Int32 value);
        partial void OndetailIdChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String description
        {
            get
            {
                return _description;
            }
            set
            {
                OndescriptionChanging(value);
                ReportPropertyChanging("description");
                _description = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("description");
                OndescriptionChanged();
            }
        }
        private global::System.String _description;
        partial void OndescriptionChanging(global::System.String value);
        partial void OndescriptionChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 transactionId
        {
            get
            {
                return _transactionId;
            }
            set
            {
                OntransactionIdChanging(value);
                ReportPropertyChanging("transactionId");
                _transactionId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("transactionId");
                OntransactionIdChanged();
            }
        }
        private global::System.Int32 _transactionId;
        partial void OntransactionIdChanging(global::System.Int32 value);
        partial void OntransactionIdChanged();

        #endregion
    
        #region Propiedades de navegación
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("BalanceModel", "DetailForMoneyDetails", "MoneyDetail")]
        public EntityCollection<MoneyDetail> MoneyDetails
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<MoneyDetail>("BalanceModel.DetailForMoneyDetails", "MoneyDetail");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<MoneyDetail>("BalanceModel.DetailForMoneyDetails", "MoneyDetail", value);
                }
            }
        }
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("BalanceModel", "TransactionDetail", "Transaction")]
        public Transaction Transaction
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Transaction>("BalanceModel.TransactionDetail", "Transaction").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Transaction>("BalanceModel.TransactionDetail", "Transaction").Value = value;
            }
        }
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Transaction> TransactionReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Transaction>("BalanceModel.TransactionDetail", "Transaction");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Transaction>("BalanceModel.TransactionDetail", "Transaction", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="BalanceModel", Name="MoneyDetail")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class MoneyDetail : EntityObject
    {
        #region Método de generador
    
        /// <summary>
        /// Crear un nuevo objeto MoneyDetail.
        /// </summary>
        /// <param name="id">Valor inicial de la propiedad Id.</param>
        /// <param name="billQuantity">Valor inicial de la propiedad billQuantity.</param>
        /// <param name="billId">Valor inicial de la propiedad billId.</param>
        /// <param name="detailId">Valor inicial de la propiedad detailId.</param>
        public static MoneyDetail CreateMoneyDetail(global::System.Int32 id, global::System.Int16 billQuantity, global::System.Byte billId, global::System.Int32 detailId)
        {
            MoneyDetail moneyDetail = new MoneyDetail();
            moneyDetail.Id = id;
            moneyDetail.billQuantity = billQuantity;
            moneyDetail.billId = billId;
            moneyDetail.detailId = detailId;
            return moneyDetail;
        }

        #endregion
        #region Propiedades primitivas
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int16 billQuantity
        {
            get
            {
                return _billQuantity;
            }
            set
            {
                OnbillQuantityChanging(value);
                ReportPropertyChanging("billQuantity");
                _billQuantity = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("billQuantity");
                OnbillQuantityChanged();
            }
        }
        private global::System.Int16 _billQuantity;
        partial void OnbillQuantityChanging(global::System.Int16 value);
        partial void OnbillQuantityChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Byte billId
        {
            get
            {
                return _billId;
            }
            set
            {
                OnbillIdChanging(value);
                ReportPropertyChanging("billId");
                _billId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("billId");
                OnbillIdChanged();
            }
        }
        private global::System.Byte _billId;
        partial void OnbillIdChanging(global::System.Byte value);
        partial void OnbillIdChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 detailId
        {
            get
            {
                return _detailId;
            }
            set
            {
                OndetailIdChanging(value);
                ReportPropertyChanging("detailId");
                _detailId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("detailId");
                OndetailIdChanged();
            }
        }
        private global::System.Int32 _detailId;
        partial void OndetailIdChanging(global::System.Int32 value);
        partial void OndetailIdChanged();

        #endregion
    
        #region Propiedades de navegación
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("BalanceModel", "MoneyDetailBills", "Bill")]
        public Bill Bill
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Bill>("BalanceModel.MoneyDetailBills", "Bill").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Bill>("BalanceModel.MoneyDetailBills", "Bill").Value = value;
            }
        }
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Bill> BillReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Bill>("BalanceModel.MoneyDetailBills", "Bill");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Bill>("BalanceModel.MoneyDetailBills", "Bill", value);
                }
            }
        }
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("BalanceModel", "DetailForMoneyDetails", "Detail")]
        public Detail Detail
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Detail>("BalanceModel.DetailForMoneyDetails", "Detail").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Detail>("BalanceModel.DetailForMoneyDetails", "Detail").Value = value;
            }
        }
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Detail> DetailReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Detail>("BalanceModel.DetailForMoneyDetails", "Detail");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Detail>("BalanceModel.DetailForMoneyDetails", "Detail", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="BalanceModel", Name="Transaction")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Transaction : EntityObject
    {
        #region Método de generador
    
        /// <summary>
        /// Crear un nuevo objeto Transaction.
        /// </summary>
        /// <param name="transactionId">Valor inicial de la propiedad transactionId.</param>
        /// <param name="amount">Valor inicial de la propiedad amount.</param>
        /// <param name="date">Valor inicial de la propiedad date.</param>
        /// <param name="typeId">Valor inicial de la propiedad typeId.</param>
        public static Transaction CreateTransaction(global::System.Int32 transactionId, global::System.Decimal amount, global::System.DateTime date, global::System.Byte typeId)
        {
            Transaction transaction = new Transaction();
            transaction.transactionId = transactionId;
            transaction.amount = amount;
            transaction.date = date;
            transaction.typeId = typeId;
            return transaction;
        }

        #endregion
        #region Propiedades primitivas
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 transactionId
        {
            get
            {
                return _transactionId;
            }
            set
            {
                if (_transactionId != value)
                {
                    OntransactionIdChanging(value);
                    ReportPropertyChanging("transactionId");
                    _transactionId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("transactionId");
                    OntransactionIdChanged();
                }
            }
        }
        private global::System.Int32 _transactionId;
        partial void OntransactionIdChanging(global::System.Int32 value);
        partial void OntransactionIdChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Decimal amount
        {
            get
            {
                return _amount;
            }
            set
            {
                OnamountChanging(value);
                ReportPropertyChanging("amount");
                _amount = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("amount");
                OnamountChanged();
            }
        }
        private global::System.Decimal _amount;
        partial void OnamountChanging(global::System.Decimal value);
        partial void OnamountChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime date
        {
            get
            {
                return _date;
            }
            set
            {
                OndateChanging(value);
                ReportPropertyChanging("date");
                _date = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("date");
                OndateChanged();
            }
        }
        private global::System.DateTime _date;
        partial void OndateChanging(global::System.DateTime value);
        partial void OndateChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Byte typeId
        {
            get
            {
                return _typeId;
            }
            set
            {
                OntypeIdChanging(value);
                ReportPropertyChanging("typeId");
                _typeId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("typeId");
                OntypeIdChanged();
            }
        }
        private global::System.Byte _typeId;
        partial void OntypeIdChanging(global::System.Byte value);
        partial void OntypeIdChanged();

        #endregion
    
        #region Propiedades de navegación
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("BalanceModel", "TransactionDetail", "Detail")]
        public EntityCollection<Detail> Details
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Detail>("BalanceModel.TransactionDetail", "Detail");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Detail>("BalanceModel.TransactionDetail", "Detail", value);
                }
            }
        }
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("BalanceModel", "TypeOfTransaction", "Type")]
        public Type Type
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Type>("BalanceModel.TypeOfTransaction", "Type").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Type>("BalanceModel.TypeOfTransaction", "Type").Value = value;
            }
        }
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Type> TypeReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Type>("BalanceModel.TypeOfTransaction", "Type");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Type>("BalanceModel.TypeOfTransaction", "Type", value);
                }
            }
        }

        #endregion

        override public string ToString()
        { 
            return string.Format("amount={0} date={1} typeId={2}",this.amount,this.date,this.typeId);
        }
        
    }
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="BalanceModel", Name="Type")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Type : EntityObject
    {
        #region Método de generador
    
        /// <summary>
        /// Crear un nuevo objeto Type.
        /// </summary>
        /// <param name="typeId">Valor inicial de la propiedad typeId.</param>
        /// <param name="name">Valor inicial de la propiedad name.</param>
        public static Type CreateType(global::System.Byte typeId, global::System.String name)
        {
            Type type = new Type();
            type.typeId = typeId;
            type.name = name;
            return type;
        }

        #endregion
        #region Propiedades primitivas
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Byte typeId
        {
            get
            {
                return _typeId;
            }
            set
            {
                if (_typeId != value)
                {
                    OntypeIdChanging(value);
                    ReportPropertyChanging("typeId");
                    _typeId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("typeId");
                    OntypeIdChanged();
                }
            }
        }
        private global::System.Byte _typeId;
        partial void OntypeIdChanging(global::System.Byte value);
        partial void OntypeIdChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String name
        {
            get
            {
                return _name;
            }
            set
            {
                OnnameChanging(value);
                ReportPropertyChanging("name");
                _name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("name");
                OnnameChanged();
            }
        }
        private global::System.String _name;
        partial void OnnameChanging(global::System.String value);
        partial void OnnameChanged();

        #endregion
    
        #region Propiedades de navegación
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("BalanceModel", "TypeOfTransaction", "Transaction")]
        public EntityCollection<Transaction> Transactions
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Transaction>("BalanceModel.TypeOfTransaction", "Transaction");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Transaction>("BalanceModel.TypeOfTransaction", "Transaction", value);
                }
            }
        }

        #endregion
    }

    #endregion
    
}
