using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PostenApi.Models
{
    [DataContract]
    public class ConsignmentSet : BaseModel
    {
        private String _consignmentId, _previousConsignmentId;
        private Double _totalWeight, _totalVolume;
        private List<PackageSet> _packageSet;

        [DataMember(Name = "consignmentId")]
        public String Id
        {
            get { return _consignmentId; }
            set
            {
                if (value == _consignmentId) return;

                _consignmentId = value;
                OnPropertyChanged("Id");
            }
        }

        [DataMember(Name = "previousConsignmentId")]
        public String PreviousId
        {
            get { return _previousConsignmentId; }
            set
            {
                if (value == _previousConsignmentId) return;

                _previousConsignmentId = value;
                OnPropertyChanged("PreviousId");
            }
        }

        [DataMember(Name = "totalWeightInKgs")]
        public Double TotalWeight
        {
            get { return _totalWeight; }
            set
            {
                if (_totalWeight.Equals(value)) return;

                _totalWeight = value;
                OnPropertyChanged("TotalWeight");
            }
        }

        [DataMember(Name = "totalVOlumeInDm3")]
        public Double TotalVolume
        {
            get { return _totalVolume; }
            set
            {
                if (_totalVolume.Equals(value)) return;

                _totalVolume = value;
                OnPropertyChanged("TotalVolume");
            }
        }

        [DataMember(Name = "packageSet")]
        public List<PackageSet> PackageSets
        {
            get { return _packageSet; }
            set
            {
                if (value == _packageSet) return;

                _packageSet = value;
                OnPropertyChanged("PackageSets");
            }
        }


    }
}
