namespace BeautySalon.Domain.Models;

/// <summary>
/// Запись клиента на услугу к мастеру.
/// </summary>
public class Appointment
{
    /// <summary>
    /// Уникальный идентификатор записи
    /// </summary>
    public required Guid Id { get; init; }

    /// <summary>
    /// Идентификатор клиента
    /// </summary>
    public required Guid ClientId { get; init; }

    /// <summary>
    /// Идентификатор мастера
    /// </summary>
    public required Guid MasterId { get; init; }

    /// <summary>
    /// Идентификатор услуги
    /// </summary>
    public required Guid ServiceId { get; init; }

    /// <summary>
    /// Дата и время начала записи
    /// </summary>
    public required DateTime StartDateTime { get; init; }

    /// <summary>
    /// Постоянный клиент?
    /// </summary>
    public required bool IsRegularClient { get; init; }

    /// <summary>
    /// Строковое представление записи
    /// </summary>
    public override string ToString() =>
        $"{Id}, ClientId: {ClientId}, MasterId: {MasterId}, ServiceId: {ServiceId}, " +
        $"Start: {StartDateTime:dd.MM.yyyy HH:mm}, Regular: {IsRegularClient}";
}