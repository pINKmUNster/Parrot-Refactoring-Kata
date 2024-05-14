using System;

namespace Parrot;

public class NorwegianBlueParrot : Parrot
{
    private readonly bool _isNailed;

    public NorwegianBlueParrot(double voltage, bool isNailed) 
        : base(voltage)
    {
        _isNailed = isNailed;
    }

    public override double GetSpeed()
    {
        return _isNailed ? 0 : GetBaseSpeed(Voltage);
    }

    public override string GetCry()
    {
        return  Voltage > 0 ? "Bzzzzzz" : "...";
    }
}