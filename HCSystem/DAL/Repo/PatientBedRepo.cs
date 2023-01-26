using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class PatientBedRepo : Repo, IRepo<BedAllotmentRepo, int, BedAllotmentRepo>
    {
        public BedAllotmentRepo Add(BedAllotmentRepo obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<BedAllotmentRepo> Get()
        {
            throw new NotImplementedException();
        }

        public BedAllotmentRepo Get(int id)
        {
            throw new NotImplementedException();
        }

        public BedAllotmentRepo Update(BedAllotmentRepo obj)
        {
            throw new NotImplementedException();
        }
    }
}
