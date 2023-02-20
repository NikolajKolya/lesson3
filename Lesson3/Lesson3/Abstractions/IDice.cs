namespace Lesson3.Abstractions
{
    /// <summary>
    /// Как-бы чертёж будущих классов, в данном случае - кубиков
    /// </summary>
    public interface IDice
    {
        /// <summary>
        /// Бросить кубик
        /// </summary>
        /// <returns>Сколько выпало</returns>
        int Throw();
    }
}
