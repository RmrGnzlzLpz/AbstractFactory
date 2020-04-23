using System;
public interface IFactory<T>
{
    T CreateItem();
}

public class GameboyBloqueFactory : IFactory<IBloqueInterrogante>
{
    public IBloqueInterrogante CreateItem()
    {
        return new GameboyBloqueInterrogante();
    }
}

public class NintendoDSBloqueFactory : IFactory<IBloqueInterrogante>
{
    public IBloqueInterrogante CreateItem()
    {
        return new NintendoDSBloqueInterrogante();
    }
}

// Si quisiéramos extender a más objetos tendríamos que construir más factories.
public class GameboyMonedaFactory : IFactory<IMoneda>
{
    public IMoneda CreateItem()
    {
        return new GameboyMoneda();
    }
}

public class NintendoDSMonedaFactory : IFactory<IMoneda>
{
    public IMoneda CreateItem()
    {
        return new NintendoDSMoneda();
    }
}
