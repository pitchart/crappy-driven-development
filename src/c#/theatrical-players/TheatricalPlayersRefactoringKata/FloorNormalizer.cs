using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheatricalPlayersRefactoringKata.Interfaces;

namespace TheatricalPlayersRefactoringKata
{
    public class FloorNormalizer : IFloorNormalizer
    {
        public int Normalize(int audience)
        {
            return (int) Math.Floor((decimal) audience / 5);
        }
    }
}
