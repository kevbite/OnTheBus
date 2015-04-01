using System;

namespace OnTheBus.Conventions.TypeMatching
{
    public interface IEventMessageTypeMatching
    {
        bool IsEventType(Type type);
    }
}