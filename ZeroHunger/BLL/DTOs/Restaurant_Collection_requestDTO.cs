using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class Restaurant_Collection_requestDTO
    {
        public int ID { get; set; }

        public int res_id { get; set; }

        public string res_name { get; set; }

        public int c_id { get; set; }

        public string c_name { get; set; }

        public string c_type { get; set; }

        public DateTime c_req_opening_time { get; set; }

        public string c_max_pre_time { get; set; }

        public int Operation { get; set; }
    }
}