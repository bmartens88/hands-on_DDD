using Marketplace.Framework;

namespace Marketplace.Domain;

public class UserId : ValueObject
{
    private readonly Guid _value;

    public UserId(Guid value)
    {
        if (value == default)
            throw new ArgumentNullException(
                nameof(value), "User id cannot be empty");
        _value = value;
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return _value;
    }
}