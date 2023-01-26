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
    public class BedService
    {
        public static BedCategoryDTO AddCategory(BedCategoryDTO bedCategory)
        {
            var config = Service.Mapping<BedCategoryDTO, BedCategory>();
            var mapper = new Mapper(config);
            var map = mapper.Map<BedCategory>(bedCategory);
            var data = DataAccessFactory.BedCategoryDataAccess().Add(map);
            if(data != null)
            {
                return mapper.Map<BedCategoryDTO>(data);
            }
            return null;
        }
        public static List<BedDTO> ShowBeds(int id)
        {
            var config= Service.OneTimeMapping<Bed, BedDTO>();
            var mapper = new Mapper(config);
            var data = DataAccessFactory.BedListDataAccess().GetListOfId(id);
            return mapper.Map<List<BedDTO>>(data);
        }
        public static BedDTO AddBedsInCategory(BedDTO beds)
        {
            var config = Service.Mapping<BedDTO, Bed>();
            var mapper = new Mapper(config);
            var map = mapper.Map<Bed>(beds);
            var data = DataAccessFactory.BedDataAccess().Add(map);
            if (data != null)
            {
                return mapper.Map<BedDTO>(data);
            }
            return null;
        }
        public static List<BedCategoryDTO> GetCategory()
        {
            var config = Service.OneTimeMapping<BedCategory, BedCategoryDTO>();
            var mapper = new Mapper(config);
            var data = DataAccessFactory.BedCategoryDataAccess().Get();
            return mapper.Map<List<BedCategoryDTO>>(data);
        }
    }
}
