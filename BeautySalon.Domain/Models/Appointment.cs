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
    public required Guid ClientId { get; set; }

    /// <summary>
    /// Идентификатор мастера
    /// </summary>
    public required Guid MasterId { get; set; }

    /// <summary>
    /// Идентификатор услуги
    /// </summary>
    public required Guid ServiceId { get; set; }

    /// <summary>
    /// Дата и время начала записи
    /// </summary>
    public required DateTime StartDateTime { get; set; }

    /// <summary>
    /// Постоянный клиент?
    /// </summary>
    public required bool IsRegularClient { get; set; }

    /// <summary>
    /// Строковое представление записи
    /// </summary>
    public override string ToString() =>
        $"{Id}, ClientId: {ClientId}, MasterId: {MasterId}, ServiceId: {ServiceId}, " +
        $"Start: {StartDateTime:dd.MM.yyyy HH:mm}, Regular: {IsRegularClient}";
}