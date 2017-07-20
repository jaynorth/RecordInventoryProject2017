using RecordsDataModel.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RI.Repo.Repository
{
    public class ArtistRepository
    {
        private RecordsDBEntities _context;
        public ArtistRepository()
        {
            _context = new RecordsDBEntities();
        }

        public void Add(Artist artist)
        {

        }
    }
}
