using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    internal class Person()
    {
        
        private int personId = 0;
        private string personName = "";

        // eslinde ayri olaraq personId ve person namei constructor olaraq vermek vacib deyil ama conditionlarda var deye elave etdim cunki mainin ozunde teyin olunur
        public int PersonId { get; set; }
        public string PersonName { get; set; }

    }

}
