using Padutronics.DependencyInjection;

namespace Padutronics.Conversion.Converters.DependencyInjection.Modules;

public sealed class ConvertersContainerModule : IContainerModule
{
    public void Load(IContainerBuilder containerBuilder)
    {
        containerBuilder.For<ToStringConverterOptions>().UseSelf().SingleInstance();

        RegisterToStringConverter<sbyte>(containerBuilder);
        RegisterToStringConverter<short>(containerBuilder);
        RegisterToStringConverter<int>(containerBuilder);
    }

    private void RegisterToStringConverter<T>(IContainerBuilder containerBuilder)
    {
        containerBuilder.For<IConverter<T, string>>().Use<ToStringConverter<T>>().InstancePerDependency();
    }
}