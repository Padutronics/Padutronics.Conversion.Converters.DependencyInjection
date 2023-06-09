using Padutronics.DependencyInjection;
using System;

namespace Padutronics.Conversion.Converters.DependencyInjection.Modules;

public sealed class ConvertersContainerModule : IContainerModule
{
    public void Load(IContainerBuilder containerBuilder)
    {
        containerBuilder.For<ToStringConverterOptions>().UseSelf().SingleInstance();

        RegisterToStringConverter<bool>(containerBuilder);

        RegisterToStringConverter<sbyte>(containerBuilder);
        RegisterToStringConverter<short>(containerBuilder);
        RegisterToStringConverter<int>(containerBuilder);
        RegisterToStringConverter<long>(containerBuilder);

        RegisterToStringConverter<byte>(containerBuilder);
        RegisterToStringConverter<ushort>(containerBuilder);
        RegisterToStringConverter<uint>(containerBuilder);
        RegisterToStringConverter<ulong>(containerBuilder);

        RegisterToStringConverter<float>(containerBuilder);
        RegisterToStringConverter<double>(containerBuilder);
        RegisterToStringConverter<decimal>(containerBuilder);

        RegisterToStringConverter<string>(containerBuilder);

        RegisterToStringConverter<DateOnly>(containerBuilder);
        RegisterToStringConverter<DateTime>(containerBuilder);
        RegisterToStringConverter<TimeOnly>(containerBuilder);
        RegisterToStringConverter<TimeSpan>(containerBuilder);
    }

    private void RegisterToStringConverter<T>(IContainerBuilder containerBuilder)
    {
        containerBuilder.For<IConverter<T, string>>().Use<ToStringConverter<T>>().InstancePerDependency();
    }
}