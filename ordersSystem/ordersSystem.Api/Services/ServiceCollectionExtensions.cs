namespace ordersSystem.Api.Services;

/// <summary>
/// Класс методов расширения для сервисов и других фич
/// </summary>
public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Метод расширения добавляющий в проект сервис с итоговой конфигурацией
    /// </summary>
    /// <param name="services"></param>
    /// <param name="finalConfig">Объект со всеми конфигурациями и провайдерами</param>
    public static void AddConfiguration(this IServiceCollection services, IConfiguration finalConfig)
    {
        services.AddSingleton<IConfiguration>(finalConfig);
    }
}