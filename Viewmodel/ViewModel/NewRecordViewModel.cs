using RecordsDataModel.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viewmodel.ViewModel
{
    public class NewRecordViewModel
    {
        private RecordsDBEntities _context;
        public NewRecordViewModel()
        {
            _context = new RecordsDBEntities();
            _listArtists = new List<Artist>(_context.Artists
                .OrderBy(a =>a.Title));

        }

        private List<Artist> _listArtists;

        public List<Artist> ListArtists
        {
            get { return _listArtists; }
            set { _listArtists = value; }
        }




    }
}
