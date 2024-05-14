using System;

namespace Parrot;

public class EuropeanParrot : Parrot
{
    protected bool IsNailed;

    public EuropeanParrot(int numberOfCoconuts, double voltage, bool isNailed)
        : base(numberOfCoconuts, voltage)
    {
    }

    public override double GetSpeed()
    {
        return GetBaseSpeed();
    }

    public override string GetCry()
    {
        return "Sqoork!";
    }
}