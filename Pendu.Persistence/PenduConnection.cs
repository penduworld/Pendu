using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pendu.Persistence.Data;

namespace Pendu.Persistence
{
    using Data;

    public class PenduConnection
    {
        private readonly PenduDbContext _context;

        public PenduConnection()
        {
            _context = new PenduDbContext();
        }
        public PenduDbContext AppContext { get { return _context; } }
        //public static void Main(string[] args)
        //{
        //    using (var db = new PenduDbContext())
        //    {
        //        var data = db.PenduUsers;
        //        foreach (var item in data)
        //        {
        //            Console.WriteLine(item.Id);
        //        }
        //    }
        //}
    }
}
