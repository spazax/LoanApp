using System;
using System.Linq;
using System.Text;
using DevExpress.Xpo;
using DevExpress.ExpressApp;
using System.ComponentModel;
using DevExpress.ExpressApp.DC;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using System.Collections.Generic;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;

namespace LoanApp.Module.BusinessObjects
{
    [DefaultClassOptions, ImageName("BO_Contact")]

    public class Accounts : XPObject
    {
        private string _accountName;

        public string AccountName
        {
            get { return _accountName; }
            set { SetPropertyValue("Accountname", ref _accountName, value); }
        }

        private int _accountNo;

        public int AccountNo
        {
            get { return _accountNo; }
            set { SetPropertyValue("AccountNo", ref _accountNo, value); }
        }

        private Customers _customers;
        [Association("Customers-Accounts")]
        public Customers Customers
        {
            get { return _customers; }
            set { SetPropertyValue("Customers", ref _customers, value); }
        }
        public Accounts(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        
        }
       
    }
}