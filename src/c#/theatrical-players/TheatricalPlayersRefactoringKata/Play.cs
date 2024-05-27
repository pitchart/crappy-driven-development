namespace TheatricalPlayersRefactoringKata;

public abstract record Play(string Name, PlayType Type)
{
    public abstract int PriceFor(int audience);
}

public record Tragedy : Play
{
    public Tragedy(string name) : base(name, PlayType.Tragedy) { }
    
    public override int PriceFor(int audience)
        => audience > 30 ? 40_000 + 1_000 * (audience - 30) : 40_000;
}

public record Comedy : Play
{
    public Comedy(string name) : base(name, PlayType.Comedy) { }
    
    public override int PriceFor(int audience)
        => 30_000 + (300 * audience) + ComedyBonus(audience);
    
    private static int ComedyBonus(int audience) =>
        audience > 20
            ? 10_000 + 500 * (audience - 20)
            : 0;
}