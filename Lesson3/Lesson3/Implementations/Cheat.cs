namespace Lesson3.Implementations
{
    public class Cheat : AbstractDice
    {
        public const int MaxNumber = 20;

        public override int Throw()
        {
            int result = _randomGenerator.Next(1, 30);

            if (result >= MaxNumber)
            {
                return MaxNumber;
            }

            return result;
        }

    }
}
