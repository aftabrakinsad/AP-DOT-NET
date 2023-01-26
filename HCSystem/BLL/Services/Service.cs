using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class Service
    {
        public static MapperConfiguration Mapping<map1, map2>()
        {
            return new MapperConfiguration(c =>
            {
                c.CreateMap<map1, map2>();
                c.CreateMap<map2,map1>();
            });
            
        }
        public static MapperConfiguration OneTimeMapping<map1, map2>()
        {
            return new MapperConfiguration(c =>
            {
                c.CreateMap<map1, map2>();
            });
            
        }
    }
}
