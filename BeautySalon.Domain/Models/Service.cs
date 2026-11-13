using BeautySalon.Enums;

namespace BeautySalon.Domain.Models;

/// <summary>
/// Услуги салона красоты
/// </summary>
public class Service
{
    /// <summary>
    /// Уникальный идентификатор услуги
    /// </summary>
    public required Guid Id { get; init; }

    /// <summary>
    /// Название услуги
    /// </summary>
    public required string Name { get; set; }

    /// <summary>
    /// Категория услуги
    /// </summary>
    public required ServiceCategory Category { get; set; }

    /// <summary>
    /// Стоимость услуги
    /// </summary>
    public required decimal Price { get; set; }

    /// <summary>
    /// Длительность услуги в минутах
    /// </summary>
    public required int DurationMinutes { get; set; }
    public TimeSpan Duration => TimeSpan.FromMinutes(DurationMinutes);

    /// <summary>
    /// Строковое представление
    /// </summary>
    public override string ToString() =>
    $"{Id}, {Name}, {Category}, {Price}, {DurationMinutes} min";
}