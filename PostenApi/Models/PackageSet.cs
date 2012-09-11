using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PostenApi.Models
{
    [DataContract]
    public class PackageSet : BaseModel
    {
        private String _statusDescription, _packageNumber, _previousPackageNumber;
        private String _productName, _productCode, _brand, _pickupCode, _dateOfReturn;
        private String _senderName;
        private Double _length, _width, _height, _volume, _weight;
        private RecipientAddress _recipientAddress;
        private List<PackageEvent> _eventSet;

        [DataMember(Name = "statusDescription")]
        public String StatusDescription
        {
            get { return _statusDescription; }
            set
            {
                if (value == _statusDescription) return;

                _statusDescription = value;
                OnPropertyChanged("StatusDescription");
            }
        }

        [DataMember(Name = "packageNumber")]
        public String PackageNumber
        {
            get { return _packageNumber; }
            set
            {
                if (value == _packageNumber) return;

                _packageNumber = value;
                OnPropertyChanged("PackageNumber");
            }
        }

        [DataMember(Name = "previousPackageNumber")]
        public String PreviousPackageNumber
        {
            get { return _previousPackageNumber; }
            set
            {
                if (value == _previousPackageNumber) return;

                _previousPackageNumber = value;
                OnPropertyChanged("PreviousPackageNumber");
            }
        }

        [DataMember(Name = "productName")]
        public String ProductName
        {
            get { return _productName; }
            set
            {
                if (value == _productName) return;

                _productName = value;
                OnPropertyChanged("ProductName");
            }
        }

        [DataMember(Name = "productCode")]
        public String ProductCode
        {
            get { return _productCode; }
            set
            {
                if (value == _productCode) return;

                _productCode = value;
                OnPropertyChanged("ProductCode");
            }
        }

        [DataMember(Name = "brand")]
        public String Brand
        {
            get { return _brand; }
            set
            {
                if (value == _brand) return;

                _brand = value;
                OnPropertyChanged("Brand");
            }
        }

        [DataMember(Name = "pickupCode")]
        public String PickupCode
        {
            get { return _pickupCode; }
            set
            {
                if (value == _pickupCode) return;

                _pickupCode = value;
                OnPropertyChanged("PickupCode");
            }
        }

        [DataMember(Name = "dateOfReturn")]
        public String DateOfReturn
        {
            get { return _dateOfReturn; }
            set
            {
                if (value == _dateOfReturn) return;

                _dateOfReturn = value;
                OnPropertyChanged("DateOfReturn");
            }
        }

        [DataMember(Name = "senderName")]
        public String SenderName
        {
            get { return _senderName; }
            set
            {
                if (value == _senderName) return;

                _senderName = value;
                OnPropertyChanged("SenderName");
            }
        }

        [DataMember(Name = "lengthInCm")]
        public Double Length
        {
            get { return _length; }
            set
            {
                if (_length.Equals(value)) return;

                _length = value;
                OnPropertyChanged("Length");
            }
        }

        [DataMember(Name = "widthInCm")]
        public Double Width
        {
            get { return _width; }
            set
            {
                if (_width.Equals(value)) return;

                _width = value;
                OnPropertyChanged("Width");
            }
        }

        [DataMember(Name = "volumeInDm3")]
        public Double Volume
        {
            get { return _volume; }
            set
            {
                if (_volume.Equals(value)) return;

                _volume = value;
                OnPropertyChanged("Volume");
            }
        }

        [DataMember(Name = "heightInCm")]
        public Double Height
        {
            get { return _height; }
            set
            {
                if (_height.Equals(value)) return;

                _height = value;
                OnPropertyChanged("Height");
            }
        }

        [DataMember(Name = "weightInKgs")]
        public Double Weight
        {
            get { return _weight; }
            set
            {
                if (_weight.Equals(value)) return;

                _weight = value;
                OnPropertyChanged("Weight");
            }
        }

        [DataMember(Name = "recipientAddress")]
        public RecipientAddress RecipientAddress
        {
            get { return _recipientAddress; }
            set
            {
                if (value == _recipientAddress) return;

                _recipientAddress = value;
                OnPropertyChanged("RecipientAddress");
            }
        }

        [DataMember(Name = "eventSet")]
        public List<PackageEvent> Events
        {
            get { return _eventSet; }
            set
            {
                if (value == _eventSet) return;

                _eventSet = value;
                OnPropertyChanged("Events");
            }
        }
    }
}
