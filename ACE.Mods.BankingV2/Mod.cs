namespace BankingV2;

public class Mod : BasicMod
{
    public Mod() : base() => Setup(nameof(BankingV2), new PatchClass(this));
}