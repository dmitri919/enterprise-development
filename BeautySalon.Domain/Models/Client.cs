namespace BeautySalon.Domain.Models;

/// <summary>
/// Клиент салона красоты.
/// </summary>
public class Client : Person
{
    /// <summary>
    /// Строковое представление
    /// </summary>
    public override string ToString() =>
        $"Client: {base.ToString()}";
}