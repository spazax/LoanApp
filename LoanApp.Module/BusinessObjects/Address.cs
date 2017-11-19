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
    [DefaultClassOptions]
    
    public class Address : XPObject
    {
        private string _street;
        private string _city;
        private string _state;
        private int _zipcode;
        public string Street {
            get { return _street; }
            set { SetPropertyValue("Street", ref _street, value); }
        }
        public string City { get { return _city; }
        set { SetPropertyValue("City", ref _city, value); }
        }
        public string State { get { return _state; }
        set { SetPropertyValue("State", ref _state, value);
            }
        }
        public int ZipCode { get { return _zipcode; }
            set { SetPropertyValue("ZipCode", ref _zipcode, value); }
        }


        private Customers _customers;
        [Association("Customers-Address")]
        public Customers Customers
        {
            get { return _customers; }
            set { SetPropertyValue("Customers", ref _customers, value); }
        }

        public Address(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
          
        }
    
    }
}