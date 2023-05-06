using Padutronics.DependencyInjection;

namespace Padutronics.Conversion.Converters.DependencyInjection.Modules;

public sealed class ConvertersContainerModule : IContainerModule
{
    public void Load(IContainerBuilder containerBuilder)
    {
        containerBuilder.For<ToStringConverterOptions>().UseSelf().SingleInstance();
    }
}