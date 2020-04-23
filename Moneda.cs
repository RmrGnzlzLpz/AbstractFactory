using System;
public interface IMoneda
{
    void GiveMoney();
}


public class GameboyMoneda : IMoneda
{
    public void GiveMoney()
    {
        Console.WriteLine("Dar dinero Gameboy");
    }
}

public class NintendoDSMoneda : IMoneda
{
    public void GiveMoney()
    {
        Console.WriteLine("Dar dinero Nintendo DS");
    }
}