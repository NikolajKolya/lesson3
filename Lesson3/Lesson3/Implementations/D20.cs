﻿using Lesson3.Abstractions;

namespace Lesson3.Implementations
{
    public class D20 : AbstractDice
    {
        public override int Throw()
        {
            return _randomGenerator.Next(1, 20);
        }
    }
}
