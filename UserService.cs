namespace IT_Asset_ManagementClient;


using Microsoft.JSInterop;


public class UserService
{
    private readonly IJSRuntime _js;
    private const string StorageKey = "currentUser";
    public string? CurrentUser { get; private set; }


    public UserService(IJSRuntime js)
    {
        _js = js;
    }


    public async Task SetUserAsync(string user)
    {
        CurrentUser = user;
        await _js.InvokeVoidAsync("localStorage.setItem", StorageKey, user);
    }


    public async Task<string?> GetUserAsync()
    {
        if (!string.IsNullOrWhiteSpace(CurrentUser))
        {
            return CurrentUser;
        }


        CurrentUser = await _js.InvokeAsync<string?>("localStorage.getItem", StorageKey);
        return CurrentUser;
    }


    public async Task ClearUserAsync()
    {
        CurrentUser = null;
        await _js.InvokeVoidAsync("localStorage.removeItem", StorageKey);
    }
}