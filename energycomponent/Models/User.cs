/// <summary>
/// Класс User содержит структуру данных о пользователях системы
/// </summary>
namespace energycomponent.Models
{
    public class User
    {
        // Идентификатор пользователя Guid
        public Guid Id { get; set; }

        // Логин пользователя
        public string? Login { get; set; }

        // Пароль пользователя
        public string? Password { get; set; }
    }
}

