using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheatricalPlayersRefactoringKata.Interfaces
{
    /// <summary>
    /// Defines the audience generator
    /// </summary>
    public interface IAudienceGenerator
    {
        /// <summary>
        /// That can generate something
        /// </summary>
        public int Generate();
    }
}
