using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PostenApi.Models
{
    [DataContract]
    public class RecipientSignature : BaseModel
    {
        private String _name;

        [DataMember(Name="name")]
        public String Name
        {
            get { return _name; }
            set
            {
                if (value == _name) return;

                _name = value;
                OnPropertyChanged("Name");
            }
        }
    }
}
