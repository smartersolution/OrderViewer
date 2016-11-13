﻿using System;
using System.Collections.ObjectModel;

namespace OrderViewer.Models
{
    public class SalesOrderHeader
    {
        public Int32? SalesOrderID { get; set; }

        public Byte? RevisionNumber { get; set; }

        public DateTime? OrderDate { get; set; }

        public DateTime? DueDate { get; set; }

        public DateTime? ShipDate { get; set; }

        public Byte? Status { get; set; }

        public Boolean? OnlineOrderFlag { get; set; }

        public String SalesOrderNumber { get; set; }

        public String PurchaseOrderNumber { get; set; }

        public String AccountNumber { get; set; }

        public Int32? CustomerID { get; set; }

        public Int32? SalesPersonID { get; set; }

        public Int32? TerritoryID { get; set; }

        public Int32? BillToAddressID { get; set; }

        public Int32? ShipToAddressID { get; set; }

        public Int32? ShipMethodID { get; set; }

        public Int32? CreditCardID { get; set; }

        public String CreditCardApprovalCode { get; set; }

        public Int32? CurrencyRateID { get; set; }

        public Decimal? SubTotal { get; set; }

        public Decimal? TaxAmt { get; set; }

        public Decimal? Freight { get; set; }

        public Decimal? TotalDue { get; set; }

        public String Comment { get; set; }

        public Guid? Rowguid { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public virtual Collection<SalesOrderDetail> SalesOrderDetails { get; set; }
    }

    public class SalesOrderDetail
    {
        public Int32? SalesOrderID { get; set; }

        public Int32? SalesOrderDetailID { get; set; }

        public String CarrierTrackingNumber { get; set; }

        public Int16? OrderQty { get; set; }

        public Int32? ProductID { get; set; }

        public Int32? SpecialOfferID { get; set; }

        public Decimal? UnitPrice { get; set; }

        public Decimal? UnitPriceDiscount { get; set; }

        public Decimal? LineTotal { get; set; }

        public Guid? Rowguid { get; set; }

        public DateTime? ModifiedDate { get; set; }
    }
}
