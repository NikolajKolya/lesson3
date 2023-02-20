using Lesson3.Abstractions;

namespace Lesson3.Implementations
{
    public class AbstractDice : IDice
    {
        protected Random _randomGenerator = new Random();

        public virtual int Throw()
        {
            throw new NotImplementedException();
        }
    }
}
