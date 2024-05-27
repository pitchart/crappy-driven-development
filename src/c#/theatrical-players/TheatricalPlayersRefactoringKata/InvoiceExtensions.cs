using System;
using System.Collections.Generic;
using static TheatricalPlayersRefactoringKata.TextFormatter;

namespace TheatricalPlayersRefactoringKata;

public static class InvoiceExtensions
{
    public static string Print(
        this Invoice invoice,
        Dictionary<string, Play> plays)
        => Print(invoice, plays, FormatLineToText, FormatStatementToText);

    private static string Print(
        Invoice invoice,
        Dictionary<string, Play> plays,
        Func<string, int, int, string> lineFormatter,
        Func<string, Statement, string> statementFormatter)
        => invoice.Performances
            .Map(performance => CreateStatement(plays, performance, lineFormatter))
            .Reduce((context, line) => context.Append(line))
            ?.FormatFor(invoice.Customer, statementFormatter);

    private static Statement CreateStatement(
        IReadOnlyDictionary<string, Play> plays,
        Performance performance,
        Func<string, int, int, string> lineFormatter)
    {
        var amount = plays[performance.PlayId].PriceFor(performance.Audience);
        var credits = plays[performance.PlayId].CreditsFor(performance.Audience);

        //@todo refactor this
        return new Statement(
            lineFormatter(plays[performance.PlayId].Name, amount, performance.Audience),
            amount,
            credits);
    }
}