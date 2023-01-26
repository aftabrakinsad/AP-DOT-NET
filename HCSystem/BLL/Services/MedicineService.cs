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
    public class MedicineService
    {
        public static MedicineDTO Add(MedicineDTO medicine)
        {
            var config = Service.Mapping<MedicineDTO, Medicine>();
            var mapper = new Mapper(config);
            var result = mapper.Map<Medicine>(medicine);
            var access = DataAccessFactory.MedicineDataAccess().Add(result);
            if (access != null)
            {
                return mapper.Map<MedicineDTO>(access);
            }return null;
        }
        public static List<MedicineDTO> Get()
        {
            var cfg = Service.OneTimeMapping<Medicine, MedicineDTO>();
            var mapper = new Mapper(cfg);
            var access = DataAccessFactory.MedicineDataAccess().Get();
            return mapper.Map<List<MedicineDTO>>(access);
        }
    }
}
