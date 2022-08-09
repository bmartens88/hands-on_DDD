﻿using Marketplace.Framework;

namespace Marketplace.Domain;

public class ClassifiedAdId : ValueObject
{
    private readonly Guid _value;

    public ClassifiedAdId(Guid value)
    {
        if (value == default)
            throw new ArgumentNullException(
                nameof(value), "Classified Ad id cannot be empty");
        _value = value;
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return _value;
    }
}