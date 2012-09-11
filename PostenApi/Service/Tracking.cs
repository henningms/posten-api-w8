using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostenApi.Service
{
    public class Tracking
    {
        public static async Task<Models.TrackingItem> Track(String id)
        {
            var url = new Uri("http://sporing.bring.no/sporing.json?q=" + id);

            return await HttpWebClient.GetDataAsync<Models.TrackingItem>(url);
        }
    }
}
