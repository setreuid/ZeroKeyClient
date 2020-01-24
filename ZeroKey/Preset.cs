using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace ZeroKey
{
    public class Preset
    {
        private List<Act> acts = new List<Act>();

        public Preset(DataTable dt)
        {
            foreach (DataRow dr in dt.Rows)
            {
                var act = new Act {
                    Code = double.Parse(dr["Code"].ToString()),
                    State = dr["Event"].ToString() == "DOWN" ? 1 : 2, // DOWN:1 UP:2
                    Time = double.Parse(dr["Time"].ToString())
                };
                
                acts.Add(act);
            }
        }

        public KeysRequest GetData()
        {
            KeysRequest request = new KeysRequest();
            request.Acts.AddRange(acts);

            return request;
        }
    }
}
