using RecordsDataModel.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viewmodel.ViewModel
{
    public class RecordsDetailViewModel
    {
        private RecordsDBEntities _context;
        public RecordsDetailViewModel()
        {
            _context = new RecordsDBEntities();

            _listRecords = new List<Mrecord>(_context.Mrecords);
            _listArtists = new List<Artist>(_context.Artists);
            _currentArtist = ListArtists[0];
            _currentRecord = ListRecords[0];
        }

        private List<Mrecord> _listRecords;

        public List<Mrecord> ListRecords
        {
            get { return _listRecords; }
            set { _listRecords = value; }
        }

        private List<Artist> _listArtists;

        public List<Artist> ListArtists
        {
            get { return _listArtists; }
            set { _listArtists = value; }
        }


        private Artist _currentArtist;

        public Artist CurrentArtist
        {
            get { return _currentArtist; }
            set { _currentArtist = value; }
        }

        private Mrecord _currentRecord;

        public Mrecord CurrentRecord
        {
            get { return _currentRecord; }
            set { _currentRecord = value; }
        }

    }
}
