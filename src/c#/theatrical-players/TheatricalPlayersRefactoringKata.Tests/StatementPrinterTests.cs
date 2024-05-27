using System.Collections.Generic;
using System.Threading.Tasks;
using VerifyXunit;
using Xunit;
using static VerifyXunit.Verifier;

namespace TheatricalPlayersRefactoringKata.Tests
{
    [UsesVerify]
    public class StatementPrinterTests
    {
        [Fact]
        public Task test_statement_example()
        {
            var plays = new Dictionary<string, Play>
            {
                {"hamlet", new Tragedy("Hamlet")},
                {"as-like", new Comedy("As You Like It")},
                {"othello", new Tragedy("Othello")}
            };

            var invoice = new Invoice("BigCo", new List<Performance>
            {
                new("hamlet", 55),
                new("as-like", 35),
                new("othello", 40)
            });

            return Verify(invoice.Print(plays));
        }
    }
}