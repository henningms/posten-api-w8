using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PostenApi.Models
{
    [DataContract]
    public class TrackingItem : BaseModel
    {
        [DataMember(Name = "consignmentSet")]
        public List<ConsignmentSet> ConsignmentSet { get; set; }

        public PackageSet FirstPackage
        {
            get
            {
                return ConsignmentSet.First() == null ? null : ConsignmentSet.First().PackageSets.First();
            }
        }

        public PackageEvent LatestEvent
        {
            get
            {
                if (ConsignmentSet.First() == null) return null;

                var l = from n in ConsignmentSet
                        from a in n.PackageSets
                        from c in a.Events
                        orderby c.Date descending 
                        select c;

                return l.First();
            }
        }

        public String LatestEventImage
        {
            get
            {
                if (ConsignmentSet.First() == null) return null;

                return String.Format("http://sporing.posten.no/_public_sporing/posten/images/icons/{0}.gif",
                                     LatestEvent.Status.ToLower());
            }
        }
    }
}
