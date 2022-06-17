using System;
using TheatricalPlayersRefactoringKata.Interfaces;

namespace TheatricalPlayersRefactoringKata
{
    public static partial class CreditsCalculator
    {
        private static int CalculateCreditsForInternal(PlayType performanceType, int audience)
            => _maxNormalizer.Normalize(audience) +
               (_comedyService.IsComedy(performanceType) ? _floorNormalizer.Normalize(audience) : 0);
    }
}