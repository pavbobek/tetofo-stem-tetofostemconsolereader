using Microsoft.Extensions.DependencyInjection;
using tetofo.DesignPattern;
using tetofo.DesignPattern.Impl;
using tetofo.EventBus;
using tetofo.EventBus.Impl;
using tetofo.Service.Console;
using tetofo.Service.Console.Impl;

namespace tetofo.Stem.Impl;

public class ConsoleReaderStem : BaseStem
{
    protected override void RegisterServices(IServiceCollection serviceCollection)
    {
        serviceCollection.AddSingleton<IConsoleReaderService, ConsoleReaderService>();
        serviceCollection.AddSingleton<IDataFactory, DataFactory>();
        serviceCollection.AddSingleton<IMessageEventFactory, MessageEventFactory>();
        serviceCollection.AddSingleton<ICallback, StartReadingConsoleCallback>();
    }
}