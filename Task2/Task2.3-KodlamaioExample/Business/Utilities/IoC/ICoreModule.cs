using Microsoft.Extensions.DependencyInjection;

namespace Business.Utilities.IoC;

public interface ICoreModule
{
    void Load(IServiceCollection serviceCollection);
}
