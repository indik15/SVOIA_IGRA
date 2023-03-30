using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVOIA_IGRA.Model
{
    public class GetPlayerName
    {
        public string GetName { get; set; }
        public int GetPlayerID {get;}


        GetPlayerName(int getplayerid)
        {
            GetPlayerID = getplayerid;
        }
    }
}
