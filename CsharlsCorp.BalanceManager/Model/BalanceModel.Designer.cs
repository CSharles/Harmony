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

[assembly: EdmRelationshipAttribute("BalanceModel", "TypeTransaction", "Type", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(CsharlsCorp.BalanceManager.Model.Type), "Transaction", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(CsharlsCorp.BalanceManager.Model.Transaction), true)]
[assembly: EdmRelationshipAttribute("BalanceModel", "TransactionDetail", "Transaction", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(CsharlsCorp.BalanceManager.Model.Transaction), "Detail", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(CsharlsCorp.BalanceManager.Model.Detail))]
[assembly: EdmRelationshipAttribute("BalanceModel", "BillOfMoneyDetail", "Bill", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(CsharlsCorp.BalanceManager.Model.Bill), "MoneyDetail", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(CsharlsCorp.BalanceManager.Model.MoneyDetail), true)]
[assembly: EdmRelationshipAttribute("BalanceModel", "DetailMoneyDetail", "Detail", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(CsharlsCorp.BalanceManager.Model.Detail), "MoneyDetail", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(CsharlsCorp.BalanceManager.Model.MoneyDetail), true)]

#endregion

namespace CsharlsCorp.BalanceManager.Model
{
    #region Contextos
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    public partial class BalanceModelContainer : ObjectContext
    {
        #region Constructores
    
        /// <summary>
        /// Inicializa un nuevo objeto BalanceModelContainer usando la cadena de conexión encontrada en la sección 'BalanceModelContainer' del archivo de configuración de la aplicación.
        /// </summary>
        public BalanceModelContainer() : base("name=BalanceModelContainer", "BalanceModelContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Inicializar un nuevo objeto BalanceModelContainer.
        /// </summary>
        public BalanceModelContainer(string connectionString) : base(connectionString, "BalanceModelContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Inicializar un nuevo objeto BalanceModelContainer.
        /// </summary>
        public BalanceModelContainer(EntityConnection connection) : base(connection, "BalanceModelContainer")
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
        public ObjectSet<MoneyDetail> MoneyDetail
        {
            get
            {
                if ((_MoneyDetail == null))
                {
                    _MoneyDetail = base.CreateObjectSet<MoneyDetail>("MoneyDetail");
                }
                return _MoneyDetail;
            }
        }
        private ObjectSet<MoneyDetail> _MoneyDetail;

        #endregion
        #region Métodos AddTo
    
        /// <summary>
        /// Método desusado para agregar un nuevo objeto al EntitySet Transactions. Considere la posibilidad de usar el método .Add de la propiedad ObjectSet&lt;T&gt; asociada.
        /// </summary>
        public void AddToTransactions(Transaction transaction)
        {
            base.AddObject("Transactions", transaction);
        }
    
        /// <summary>
        /// Método desusado para agregar un nuevo objeto al EntitySet Details. Considere la posibilidad de usar el método .Add de la propiedad ObjectSet&lt;T&gt; asociada.
        /// </summary>
        public void AddToDetails(Detail detail)
        {
            base.AddObject("Details", detail);
        }
    
        /// <summary>
        /// Método desusado para agregar un nuevo objeto al EntitySet Types. Considere la posibilidad de usar el método .Add de la propiedad ObjectSet&lt;T&gt; asociada.
        /// </summary>
        public void AddToTypes(Type type)
        {
            base.AddObject("Types", type);
        }
    
        /// <summary>
        /// Método desusado para agregar un nuevo objeto al EntitySet Bills. Considere la posibilidad de usar el método .Add de la propiedad ObjectSet&lt;T&gt; asociada.
        /// </summary>
        public void AddToBills(Bill bill)
        {
            base.AddObject("Bills", bill);
        }
    
        /// <summary>
        /// Método desusado para agregar un nuevo objeto al EntitySet MoneyDetail. Considere la posibilidad de usar el método .Add de la propiedad ObjectSet&lt;T&gt; asociada.
        /// </summary>
        public void AddToMoneyDetail(MoneyDetail moneyDetail)
        {
            base.AddObject("MoneyDetail", moneyDetail);
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
        /// <param name="denomination">Valor inicial de la propiedad denomination.</param>
        public static Bill CreateBill(global::System.Int32 billId, global::System.String denomination)
        {
            Bill bill = new Bill();
            bill.billId = billId;
            bill.denomination = denomination;
            return bill;
        }

        #endregion
        #region Propiedades primitivas
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 billId
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
        private global::System.Int32 _billId;
        partial void OnbillIdChanging(global::System.Int32 value);
        partial void OnbillIdChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String denomination
        {
            get
            {
                return _denomination;
            }
            set
            {
                OndenominationChanging(value);
                ReportPropertyChanging("denomination");
                _denomination = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("denomination");
                OndenominationChanged();
            }
        }
        private global::System.String _denomination;
        partial void OndenominationChanging(global::System.String value);
        partial void OndenominationChanged();

        #endregion
    
        #region Propiedades de navegación
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("BalanceModel", "BillOfMoneyDetail", "MoneyDetail")]
        public EntityCollection<MoneyDetail> MoneyDetails
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<MoneyDetail>("BalanceModel.BillOfMoneyDetail", "MoneyDetail");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<MoneyDetail>("BalanceModel.BillOfMoneyDetail", "MoneyDetail", value);
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
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("BalanceModel", "DetailMoneyDetail", "MoneyDetail")]
        public EntityCollection<MoneyDetail> MoneyDetails
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<MoneyDetail>("BalanceModel.DetailMoneyDetail", "MoneyDetail");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<MoneyDetail>("BalanceModel.DetailMoneyDetail", "MoneyDetail", value);
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
        /// <param name="invoiceId">Valor inicial de la propiedad invoiceId.</param>
        /// <param name="billQuantity">Valor inicial de la propiedad billQuantity.</param>
        /// <param name="billId">Valor inicial de la propiedad billId.</param>
        /// <param name="detailId">Valor inicial de la propiedad detailId.</param>
        public static MoneyDetail CreateMoneyDetail(global::System.Int32 invoiceId, global::System.Int32 billQuantity, global::System.Int32 billId, global::System.Int32 detailId)
        {
            MoneyDetail moneyDetail = new MoneyDetail();
            moneyDetail.invoiceId = invoiceId;
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
        public global::System.Int32 invoiceId
        {
            get
            {
                return _invoiceId;
            }
            set
            {
                if (_invoiceId != value)
                {
                    OninvoiceIdChanging(value);
                    ReportPropertyChanging("invoiceId");
                    _invoiceId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("invoiceId");
                    OninvoiceIdChanged();
                }
            }
        }
        private global::System.Int32 _invoiceId;
        partial void OninvoiceIdChanging(global::System.Int32 value);
        partial void OninvoiceIdChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 billQuantity
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
        private global::System.Int32 _billQuantity;
        partial void OnbillQuantityChanging(global::System.Int32 value);
        partial void OnbillQuantityChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 billId
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
        private global::System.Int32 _billId;
        partial void OnbillIdChanging(global::System.Int32 value);
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
        [EdmRelationshipNavigationPropertyAttribute("BalanceModel", "BillOfMoneyDetail", "Bill")]
        public Bill Bill
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Bill>("BalanceModel.BillOfMoneyDetail", "Bill").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Bill>("BalanceModel.BillOfMoneyDetail", "Bill").Value = value;
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
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Bill>("BalanceModel.BillOfMoneyDetail", "Bill");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Bill>("BalanceModel.BillOfMoneyDetail", "Bill", value);
                }
            }
        }
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("BalanceModel", "DetailMoneyDetail", "Detail")]
        public Detail Detail
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Detail>("BalanceModel.DetailMoneyDetail", "Detail").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Detail>("BalanceModel.DetailMoneyDetail", "Detail").Value = value;
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
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Detail>("BalanceModel.DetailMoneyDetail", "Detail");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Detail>("BalanceModel.DetailMoneyDetail", "Detail", value);
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
        public static Transaction CreateTransaction(global::System.Int32 transactionId, global::System.Decimal amount, global::System.DateTime date, global::System.Int32 typeId)
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
        /// 
        /// </summary>
        /// <LongDescription>
        /// amout represent the value of the transaction
        /// </LongDescription>
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
        public global::System.Int32 typeId
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
        private global::System.Int32 _typeId;
        partial void OntypeIdChanging(global::System.Int32 value);
        partial void OntypeIdChanged();

        #endregion
    
        #region Propiedades de navegación
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("BalanceModel", "TypeTransaction", "Type")]
        public Type Type
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Type>("BalanceModel.TypeTransaction", "Type").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Type>("BalanceModel.TypeTransaction", "Type").Value = value;
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
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Type>("BalanceModel.TypeTransaction", "Type");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Type>("BalanceModel.TypeTransaction", "Type", value);
                }
            }
        }
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("BalanceModel", "TransactionDetail", "Detail")]
        public Detail Detail
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Detail>("BalanceModel.TransactionDetail", "Detail").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Detail>("BalanceModel.TransactionDetail", "Detail").Value = value;
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
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Detail>("BalanceModel.TransactionDetail", "Detail");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Detail>("BalanceModel.TransactionDetail", "Detail", value);
                }
            }
        }

        #endregion
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
        /// <param name="type1">Valor inicial de la propiedad type.</param>
        public static Type CreateType(global::System.Int32 typeId, global::System.String type1)
        {
            Type type = new Type();
            type.typeId = typeId;
            type.type = type1;
            return type;
        }

        #endregion
        #region Propiedades primitivas
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 typeId
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
        private global::System.Int32 _typeId;
        partial void OntypeIdChanging(global::System.Int32 value);
        partial void OntypeIdChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String type
        {
            get
            {
                return _type;
            }
            set
            {
                OntypeChanging(value);
                ReportPropertyChanging("type");
                _type = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("type");
                OntypeChanged();
            }
        }
        private global::System.String _type;
        partial void OntypeChanging(global::System.String value);
        partial void OntypeChanged();

        #endregion
    
        #region Propiedades de navegación
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("BalanceModel", "TypeTransaction", "Transaction")]
        public EntityCollection<Transaction> Transactions
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Transaction>("BalanceModel.TypeTransaction", "Transaction");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Transaction>("BalanceModel.TypeTransaction", "Transaction", value);
                }
            }
        }

        #endregion
    }

    #endregion
    
}
