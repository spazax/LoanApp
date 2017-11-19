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
   
    public class Customers :XPObject
    {
        private string _firstName;
        private string _lastName;
        private string _middleName;

        public string FirstName
        {
            get { return _firstName; }
            set { SetPropertyValue("FirstName", ref _firstName, value); }
        }

        public string LastName
        {
            get { return _lastName; }
            set { SetPropertyValue("LastName", ref _lastName,value); }
        }


        public string MiddleName
        {
            get { return _middleName; }
            set { SetPropertyValue("MiddleName", ref _middleName, value); }
        }

        [ImageEditor(ListViewImageEditorCustomHeight = 75, DetailViewImageEditorFixedHeight = 150)]
        public byte[] Photo { get; set; }
        [Association("Customers-Accounts")]


        public XPCollection<Accounts> Accounts
        {
            get
            {
                return GetCollection<Accounts>("Accounts");
            }
        }
        [Association("Customers-Address")]
        public XPCollection<Address> Address
        {
            get
            {
                return GetCollection<Address>("Address");
            }
        }

        public Customers(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
           
        }
        
    }
}