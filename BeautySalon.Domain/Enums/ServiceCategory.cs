namespace BeautySalon.Domain.Enums;

/// <summary>
/// Категория услуги салона красоты.
/// </summary>
public enum ServiceCategory
{
    /// <summary>
    /// Парикмахерские услуги
    /// </summary>
    HairCare = 1,

    /// <summary>
    /// Ногтевой сервис
    /// </summary>
    NailCare = 2,

    /// <summary>
    /// Косметология
    /// </summary>
    Skincare = 3,

    /// <summary>
    /// Макияж
    /// </summary>
    Makeup = 4,

    /// <summary>
    /// Эпиляция
    /// </summary>
    HairRemoval = 5,
    /// <summary>
    /// Массаж
    /// </summary>
    Massage = 6,

    /// <summary>
    /// СПА
    /// </summary>
    Spa = 7,

    /// <summary>
    /// Запасная категория
    /// </summary>
    Other = 8
}