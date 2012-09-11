using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PostenApi.Models
{
    [DataContract]
    public class RecipientAddress : BaseModel
    {
        private String _addressLine1, _addressLine2, _postalCode, _city;
        private String _countryCode, _country;

        [DataMember(Name = "addressLine1")]
        public String AddressLine1
        {
            get { return _addressLine1; }
            set
            {
                if (value == _addressLine1) return;

                _addressLine1 = value;
                OnPropertyChanged("AddressLine1");
            }
        }

        [DataMember(Name = "addressLine2")]
        public String AddressLine2
        {
            get { return _addressLine2; }
            set
            {
                if (value == _addressLine2) return;

                _addressLine2 = value;
                OnPropertyChanged("AddressLine2");
            }
        }

        [DataMember(Name = "postalCode")]
        public String PostalCode
        {
            get { return _postalCode; }
            set
            {
                if (value == _postalCode) return;

                _postalCode = value;
                OnPropertyChanged("PostalCode");
            }
        }

        [DataMember(Name = "city")]
        public String City
        {
            get { return _city; }
            set
            {
                if (value == _city) return;

                _city = value;
                OnPropertyChanged("City");
            }
        }

        [DataMember(Name = "countryCode")]
        public String CountryCode
        {
            get { return _countryCode; }
            set
            {
                if (value == _countryCode) return;

                _countryCode = value;
                OnPropertyChanged("CountryCode");
            }
        }

        [DataMember(Name = "country")]
        public String Country
        {
            get { return _country; }
            set
            {
                if (value == _country) return;

                _country = value;
                OnPropertyChanged("Country");
            }
        }
    }
}
