using System;

namespace Parrot;

public class AfricanParrot : Parrot
{
    public AfricanParrot(int numberOfCoconuts, double voltage, bool isNailed)
        : base(numberOfCoconuts, voltage)
    {
    }

    public override double GetSpeed()
    {
        return Math.Max(0, GetBaseSpeed() - GetLoadFactor() * NumberOfCoconuts);
    }

    public override string GetCry()
    {
        return "Sqaark!";
    }
}