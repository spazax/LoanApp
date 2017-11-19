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
    [DefaultClassOptions,ImageName("BO_Contact")]
    
    public class Products : BaseObject
    {
        private string _ProductName;

        public string ProductName
        {
            get { return _ProductName; }
            set { SetPropertyValue("ProductName", ref _ProductName, value); }
        }

        private string _productdescription;

        public string ProductDescription
        {
            get { return _productdescription; }
            set { SetPropertyValue("ProductDescription", ref _productdescription, value); }
        }
        public Products(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
           
        }
       
    }
}