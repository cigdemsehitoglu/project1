namespace EventEase.Services
{
    /// <summary>
    /// Simple state management service for user sessions.
    /// Tracks the currently logged-in / registered user.
    /// </summary>
    public class UserSessionService
    {
        public string? CurrentUserName { get; private set; }
        public string? CurrentUserEmail { get; private set; }
        public bool IsLoggedIn => !string.IsNullOrEmpty(CurrentUserName);

        public event Action? OnChange;

        public void Login(string name, string email)
        {
            CurrentUserName = name;
            CurrentUserEmail = email;
            NotifyStateChanged();
        }

        public void Logout()
        {
            CurrentUserName = null;
            CurrentUserEmail = null;
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
