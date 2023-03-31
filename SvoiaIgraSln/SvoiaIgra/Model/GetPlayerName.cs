using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SvoiaIgra.Model
{
    public class PlayerName
    {
        public string Name { get; set; }
        public int Id {get;}
        
        PlayerName(int id)
        {
            Id = id;
        } 

    }
}
