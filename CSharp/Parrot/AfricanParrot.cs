using System;

namespace Parrot;

public class AfricanParrot : Parrot
{
    private readonly int _numberOfCoconuts;

    public AfricanParrot(int numberOfCoconuts, double voltage)
        : base(voltage)
    {
        _numberOfCoconuts = numberOfCoconuts;
    }

    public override double GetSpeed()
    {
        return Math.Max(0, GetBaseSpeed() - GetLoadFactor() * _numberOfCoconuts);
    }

    public override string GetCry()
    {
        return "Sqaark!";
    }
}