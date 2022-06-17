using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheatricalPlayersRefactoringKata.Interfaces;

namespace TheatricalPlayersRefactoringKata
{
    public class MaxNormalizer : IMaxNormalizer
    {
        public int Normalize(int audience)
        {
            return Math.Max(audience - 30, 0);
        }
    }
}
