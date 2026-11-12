namespace BeautySalon.Domain.Models;

/// <summary>
/// Мастер салона красоты.
/// </summary>
public sealed class Master : Person
{
    /// <summary>
    /// Номер паспорта мастера
    /// </summary>
    public required string PassportNumber { get; init; }

    /// <summary>
    /// Специализации мастера
    /// </summary>
    public HashSet<string> Specializations { get; init; } = new(StringComparer.OrdinalIgnoreCase);

    /// <summary>
    /// Стаж работы в годах
    /// </summary>
    public required int ExperienceYears { get; init; }

    /// <summary>
    /// Строковое представление
    /// </summary>
    public override string ToString() =>
        $"Master: {base.ToString()}, " +
        $"Passport: {PassportNumber}, " +
        $"Specializations: {string.Join(", ", Specializations)}, " +
        $"Experience: {ExperienceYears} years";
}