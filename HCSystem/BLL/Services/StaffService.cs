using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class StaffService
    {
        public static StaffDTO Add(StaffDTO staffDTO)
        {
            
            var config = Service.Mapping<Staff,StaffDTO>();
            var mapper = new Mapper(config);
            var staffs = mapper.Map<Staff>(staffDTO);
            var data = DataAccessFactory.StaffDataAccess().Add(staffs);
            if(data!=null)
            {
                return mapper.Map<StaffDTO>(data);
            }
            return null;

        }

        public static List<StaffDTO> Get()
        {
            
            var config = Service.OneTimeMapping<Staff, StaffDTO>();
            var mapper = new Mapper(config);
            var data = DataAccessFactory.StaffDataAccess().Get();
            return mapper.Map<List<StaffDTO>>(data);
        }
        public static StaffDTO Get(int id)
        {
            
            var config = Service.OneTimeMapping<Staff, StaffDTO>();
            var mapper = new Mapper(config);
            var data = DataAccessFactory.StaffDataAccess().Get(id);
            return mapper.Map<StaffDTO>(data);
        }


        public static bool Delete(/*StaffDTO staffDTO*/ int id)
        {
            //var config=Service.OneTimeMapping<Staff, StaffDTO>();
            //var mapper=new Mapper(config);
            //var staffs=mapper.Map<Staff>(staffDTO);
            var data = DataAccessFactory.StaffDataAccess().Delete(/*staffs*/id);
            return data;

        }


        public static StaffDTO Update(StaffDTO staffDTO)
        {
            var config =Service.Mapping<Staff, StaffDTO>();
            var mapper = new Mapper(config);
            var staffs = mapper.Map<Staff>(staffDTO);
            var data = DataAccessFactory.StaffDataAccess().Update(staffs);
            if (data != null)
            {
                return mapper.Map<StaffDTO>(data);
            }
 
            return null;

        }


    }
}
