using System;

namespace Willow.Testing.Core.Reflection
{
    public interface MemberAccessor
    {
        Type declaring_type { get; }
        Type accessor_type { get; }
        void change_value_to(object target,object new_value);
        object get_value(object target);
        string name { get; }
    }
}