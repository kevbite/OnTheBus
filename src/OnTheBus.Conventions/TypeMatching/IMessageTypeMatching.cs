using System;

namespace OnTheBus.Conventions.TypeMatching
{
    public interface IMessageTypeMatching
    {
        bool IsMessageType(Type type);
    }
}