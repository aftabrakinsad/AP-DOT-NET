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
    public class BedAllotmentService
    {
        public static BedAllotmentDTO AddAllotment(BedAllotmentDTO bedAllotment,int id)
        {
            var config = Service.Mapping<BedAllotmentDTO, BedAllotment>();
            var mapper = new Mapper(config);
            var bedinfo = DataAccessFactory.BedDataAccess().Get(id);
            var entity = new BedAllotment();
            entity.Id = bedAllotment.ID;
            entity.PatientID=bedAllotment.PatientID;
            entity.PatientName = bedAllotment.PatientName;
            entity.AllotmentDate = DateTime.Now;
            entity.DischargeDate = null;
            entity.BedID=bedinfo.Id;
            entity.BedCategory=bedinfo.BedCategory;
            entity.BedName=bedinfo.BedName;
            var map = mapper.Map<BedAllotment>(entity);
            var data = DataAccessFactory.BedAllotmentDataAccess().Add(map);
            if(data!=null)
            {
                return mapper.Map<BedAllotmentDTO>(data);
            }
            return null;
        }
        public static List<BedAllotmentDTO> GetAllotment()
        {
            var config = Service.OneTimeMapping<BedAllotment, BedAllotmentDTO>();
            var mapper = new Mapper(config);
            var data = DataAccessFactory.BedAllotmentDataAccess().Get();
            return mapper.Map<List<BedAllotmentDTO>>(data);
        }
        public static BedAllotmentDTO GetAllotment(int id)
        {
            var config = Service.OneTimeMapping<BedAllotment, BedAllotmentDTO>();
            var mapper = new Mapper(config);
            var data = DataAccessFactory.BedAllotmentDataAccess().Get(id);
            return mapper.Map<BedAllotmentDTO>(data);
        }
        public static BedAllotmentDTO EditAllotment(BedAllotmentDTO bedAllotment)
        {
            var config = Service.Mapping<BedAllotmentDTO, BedAllotment>();
            var mapper = new Mapper(config);
            var map=mapper.Map<BedAllotment>(bedAllotment);
            var data=DataAccessFactory.BedAllotmentDataAccess().Update(map);
            if (data != null)
            {
                return mapper.Map<BedAllotmentDTO>(data);
            }
            return null;
        }
    }
}
