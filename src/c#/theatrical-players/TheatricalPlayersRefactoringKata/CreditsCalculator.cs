using System;
using TheatricalPlayersRefactoringKata.Interfaces;

namespace TheatricalPlayersRefactoringKata
{
    public static partial class CreditsCalculator
    {
        private static readonly IMaxNormalizer _maxNormalizer = new MaxNormalizer();

        private static readonly IComedyService _comedyService = new ComedyService();

        private static readonly IFloorNormalizer _floorNormalizer = new FloorNormalizer();

        public static int CalculateCreditsFor(PlayType performanceType, int audience)
        {
            return CalculateCreditsForInternal(performanceType, audience);
        }
    }
}