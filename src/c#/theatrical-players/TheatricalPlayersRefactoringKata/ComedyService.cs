using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheatricalPlayersRefactoringKata.Interfaces;

namespace TheatricalPlayersRefactoringKata
{
    public class ComedyService : IComedyService
    {
        public bool IsComedy(PlayType playType)
        {
            return playType switch
            {
                PlayType.Comedy => true,
                PlayType.Tragedy => false,
                _ => false
            };
        }
    }
}
