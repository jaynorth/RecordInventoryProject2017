
using RecordsDataModel.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viewmodel
{
    public class TestViewModel
    {
        private RecordsDBEntities _context;

        public TestViewModel()
        {
           _context = new RecordsDBEntities();

           


           List<Mrecord> ListRecords = new List<Mrecord>(_context.Mrecords);
            ListArtists = new List<Artist>(_context.Artists);
            CurrentArtist = ListArtists[0];
            //_title = CurrentArtist.Title;
            
        

        }

        private List<Mrecord> _listRecords ;

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

        //private string _title;

        //public string Title
        //{
        //    get { return _title; }
        //    set { _title = value; }
        //}



    }
}
