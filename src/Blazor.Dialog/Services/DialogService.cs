using Microsoft.JSInterop;

namespace Blazor.Dialog.Services;

/// <summary>
/// <see cref="IDialogService" /> 의 구현체입니다.
/// </summary>
internal sealed class DialogService : IDialogService
{
    private readonly IJSRuntime _jsRuntime;

    /// <summary>
    /// <see cref="DialogService" /> 를 초기화합니다.
    /// </summary>
    /// <param name="jsRuntime"> JavaScript Runtime 의 객체입니다. </param>
    public DialogService(IJSRuntime jsRuntime)
    {
        _jsRuntime = jsRuntime;
    }

    /// <inheritdoc cref="IDialogService.AlertAsync(string)" />
    public ValueTask ShowAlertAsync(string message)
    {
        return _jsRuntime.InvokeVoidAsync("alert", message);
    }

    /// <inheritdoc cref="IDialogService.ConfirmAsync(string)" />
    public ValueTask<bool> ShowConfirmAsync(string message)
    {
        return _jsRuntime.InvokeAsync<bool>("confirm", message);
    }

    /// <inheritdoc cref="IDialogService.PromptAsync(string)" />
    public ValueTask<string?> ShowPromptAsync(string message)
    {
        return _jsRuntime.InvokeAsync<string?>("prompt", message);
    }

    /// <inheritdoc cref="IDialogService.PromptAsync(string, string)" />
    public ValueTask<string?> ShowPromptAsync(string message, string defaultValue)
    {
        return _jsRuntime.InvokeAsync<string?>("prompt", message, defaultValue);
    }
}
