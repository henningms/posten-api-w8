using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PostenApi.Models
{
    [DataContract]
    public class PackageEventDefinition : BaseModel
    {
        private String _term, _explanation;

        [DataMember(Name = "term")]
        public String Term
        {
            get { return _term; }
            set
            {
                if (value == _term) return;

                _term = value;
                OnPropertyChanged("Term");
            }
        }

        [DataMember(Name = "explanation")]
        public String Explanation
        {
            get { return _explanation; }
            set
            {
                if (value == _explanation) return;

                _explanation = value;
                OnPropertyChanged("Explanation");
            }
        }
    }
}
