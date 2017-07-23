using RecordsDataModel.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Viewmodel.ViewModel.Helpers;

namespace Viewmodel.Repository
{
    public class MrecordRepository : BaseViewModel
    {

        public void Add(Mrecord currentRecord)
        {
            Mrecord m = new Mrecord();

            m = currentRecord;

            _context.Mrecords.Add(m);
            _context.SaveChanges();
        }
    }
}
