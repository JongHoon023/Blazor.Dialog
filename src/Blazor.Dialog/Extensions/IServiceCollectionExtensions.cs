using Blazor.Dialog.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Blazor.Dialog.Extensions;

/// <summary>
/// <see cref="IServiceCollection" /> 에 대한 확장 함수가 있는 정적 Class 입니다.
/// </summary>
public static class IServiceCollectionExtensions
{
    /// <summary>
    /// <see cref="IDialogService" /> 를 등록 후 <see cref="IServiceCollection" /> 구현체를 반환합니다.
    /// </summary>
    /// <param name="services"> <see cref="IDialogService" /> 를 등록할 <see cref="IServiceCollection" /> 구현체입니다. </param>
    /// <returns> <see cref="IAlertService" /> 를 등록한 <see cref="IServiceCollection" /> 구현체를 반환합니다.  </returns>
    public static IServiceCollection AddAlertService(this IServiceCollection services)
    {
        return services.AddScoped<IDialogService, DialogService>();
    }
}
