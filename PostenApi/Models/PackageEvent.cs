using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PostenApi.Models
{
    [DataContract]
    public class PackageEvent : BaseModel
    {
        private String _description, _status, _unitId, _unitType;
        private String _postalCode, _city, _countryCode, _country;
        private String _dateIso, _displayDate, _displayTime;
        private RecipientSignature _recipientSignature;
        private List<PackageEventDefinition> _definitions;
        private Boolean _consignmentEvent;


        [DataMember(Name = "description")]
        public String Description
        {
            get { return _description; }
            set
            {
                if (value == _description) return;

                _description = value;
                OnPropertyChanged("Description");
            }
        }

        [DataMember(Name = "status")]
        public String Status
        {
            get { return _status; }
            set
            {
                if (value == _status) return;

                _status = value;
                OnPropertyChanged("Status");
            }
        }

        [DataMember(Name = "unitId")]
        public String UnitId
        {
            get { return _unitId; }
            set
            {
                if (value == _unitId) return;

                _unitId = value;
                OnPropertyChanged("UnitId");
            }
        }

        [DataMember(Name = "unitType")]
        public String UnitType
        {
            get { return _unitId; }
            set
            {
                if (value == _unitType) return;

                _unitType = value;
                OnPropertyChanged("UnitType");
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

        [DataMember(Name = "dateIso")]
        private String DateIso
        {
            get { return _dateIso; }
            set
            {
                if (value == _dateIso) return;

                _dateIso = value;
                OnPropertyChanged("Date");
            }
        }

        public DateTime Date
        {
            get
            {
                return DateIso == null ? default(DateTime) : DateTime.Parse(DateIso);
            }
        }

        [DataMember(Name = "displayDate")]
        public String DisplayDate
        {
            get { return _displayDate; }
            set
            {
                if (value == _displayDate) return;

                _displayDate = value;
                OnPropertyChanged("DisplayDate");
            }
        }

        [DataMember(Name = "displayTime")]
        public String DisplayTime
        {
            get { return _displayTime; }
            set
            {
                if (value == _displayTime) return;

                _displayTime = value;
                OnPropertyChanged("DisplayTime");
            }
        }

        [DataMember(Name = "recipientSignature")]
        public RecipientSignature RecipientSignature
        {
            get { return _recipientSignature; }
            set
            {
                if (value == _recipientSignature) return;

                _recipientSignature = value;
                OnPropertyChanged("RecipientSignature");
            }
        }

        [DataMember(Name = "consignmentEvent")]
        public Boolean ConsignmentEvent
        {
            get { return _consignmentEvent; }
            set
            {
                if (value == _consignmentEvent) return;

                _consignmentEvent = value;
                OnPropertyChanged("ConsignmentEvent");
            }
        }

        [DataMember(Name = "definitions")]
        public List<PackageEventDefinition> Definitions
        {
            get { return _definitions; }
            set
            {
                if (value == _definitions) return;

                _definitions = value;
                OnPropertyChanged("Definitions");
            }
        }
    }
}
