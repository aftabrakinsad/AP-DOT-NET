using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class Collection_req_acceptDTO
    {
        public int ID { get; set; }

        public int com_id { get; set; }

        public int res_id { get; set;}

        public string res_name { get; set; }

        public string c_name { get; set; }

        public string c_type { get; set; }

        public DateTime accept_time { get; set; }

        public string assign_emp { get; set;}
    }
}