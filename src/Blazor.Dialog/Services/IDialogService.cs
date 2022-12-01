namespace Blazor.Dialog.Services;

/// <summary>
/// Alert, Confirm, Prompt 창을 편하게 사용할 수 있게 돕는 Service 입니다.
/// </summary>
public interface IDialogService
{
    /// <summary>
    /// Alert 창을 띄웁니다.
    /// </summary>
    /// <param name="message"> Alert 창에 보여줄 내용입니다. </param>
    /// <seealso href="https://developer.mozilla.org/docs/Web/API/Window/alert" />
    ValueTask ShowAlertAsync(string message);

    /// <summary>
    /// Confirm 창을 띄웁니다.
    /// </summary>
    /// <param name="message"> Confirm 창에 보여줄 내용입니다. </param>
    /// <returns> <c> 확인 </c> 을 선택했으면 <see langword="true" /> 를 반환하고, <c> 취소 </c> 를 선택했으면 <see langword="false" /> 를 반환합니다. </returns>
    /// <seealso href="https://developer.mozilla.org/docs/Web/API/Window/confirm" />
    ValueTask<bool> ShowConfirmAsync(string message);

    /// <summary>
    /// Prompt 창을 띄웁니다.
    /// </summary>
    /// <param name="message"> Prompt 창에 보여줄 내용입니다. </param>
    /// <returns> <c> 확인 </c> 을 선택했으면 입력한 값을 반환하고, <c> 취소 </c> 를 선택했으면 <see langword="null" /> 을 반환합니다. </returns>
    /// <seealso href="https://developer.mozilla.org/docs/Web/API/Window/prompt" />
    ValueTask<string?> ShowPromptAsync(string message);

    /// <summary>
    /// Prompt 창을 띄웁니다.
    /// </summary>
    /// <param name="message"> Prompt 창에 보여줄 내용입니다. </param>
    /// <param name="defaultValue">
    /// <para> 입력 필드에 채울 기본 값입니다. </para>
    /// <para> ※ Internet Explorer 7과 8에서는 해당 값을 지정하지 않으면 문자열 <c> undefined </c> 가 지정되니 유의하세요. ※ </para>
    /// </param>
    /// <returns> <c> 확인 </c> 을 선택했으면 입력한 값을 반환하고, <c> 취소 </c> 를 선택했으면 <see langword="null" /> 을 반환합니다. </returns>
    /// <seealso href="https://developer.mozilla.org/docs/Web/API/Window/prompt" />
    ValueTask<string?> ShowPromptAsync(string message, string defaultValue);
}
