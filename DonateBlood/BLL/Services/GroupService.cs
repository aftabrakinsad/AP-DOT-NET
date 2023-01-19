using AutoMapper;
using BLL.DTOs;
using DAL.DB_EF_CF.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class GroupService
    {
        public static GroupDTO Add(GroupDTO g)
        {
            var config = MapServices.Mapping<GroupDTO, Group>();
            var mapper = new Mapper(config);
            var data = mapper.Map<Group>(g);
            var repo = DataAccessFactory.GroupDataAccess().Add(data);
            if (repo != null)
            {
                return mapper.Map<GroupDTO>(repo);
            }
            return null;
        }

        public static List<GroupDTO> Get()
        {
            var config = MapServices.OneTimeMapping<Group, GroupDTO>();
            var mapper = new Mapper(config);
            var data = DataAccessFactory.GroupDataAccess().Get();
            return mapper.Map<List<GroupDTO>>(data);
        }

        public static GroupDTO Get(int id)
        {
            var config = MapServices.OneTimeMapping<Group, GroupDTO>();
            var mapper = new Mapper(config);
            var data = DataAccessFactory.GroupDataAccess().Get(id);
            return mapper.Map<GroupDTO>(data);
        }

        public static bool Delete(int id)
        {
            var data = DataAccessFactory.GroupDataAccess().Delete(id);
            return data;
        }

        public static GroupDTO Update(GroupDTO groupDTO)
        {
            var config = MapServices.Mapping<Group, GroupDTO>();
            var mapper = new Mapper(config);
            var staffs = mapper.Map<Group>(groupDTO);
            var data = DataAccessFactory.GroupDataAccess().Update(staffs);
            if (data != null)
            {
                return mapper.Map<GroupDTO>(data);
            }
            return null;
        }

        public static GroupDTO GetChecker(string name)
        {
            var data = DataAccessFactory.GroupAuthCheckerDataAccess().GetChecker(name);
            var config = MapServices.OneTimeMapping<Group, GroupDTO>();
            var mapper = new Mapper(config);
            return mapper.Map<GroupDTO>(data);
        }

        public static GroupDonorDTO Get_with_Donor(int id)
        {
            var data = DataAccessFactory.GroupDataAccess().Get(id);
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<Group, GroupDonorDTO>();
                c.CreateMap<Donor, DonorDTO>();

            });
            var mapper = new Mapper(cfg);
            return mapper.Map<GroupDonorDTO>(data);
        }
    }
}
