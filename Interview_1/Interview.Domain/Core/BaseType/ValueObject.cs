
namespace Interview.Domain.Core.BaseType;

public abstract class ValueObject 
{
    public override bool Equals(object? obj)
    {
        return Equals(obj as ValueObject);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(32);
    }

    public static bool operator ==(ValueObject? left, ValueObject? right)
    {
        return EqualityComparer<ValueObject>.Default.Equals(left, right);
    }

    public static bool operator !=(ValueObject? left, ValueObject? right)
    {
        return !(left == right);
    }
}
