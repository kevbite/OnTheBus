using System;

namespace OnTheBus.Conventions.TypeMatching
{
    public interface ICommandMessageTypeMatching
    {
        bool IsCommandType(Type type);
    }
}