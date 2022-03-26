using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace DddTwitter.Domain.Models.Users
{
    class UserId : IEquatable<UserId>
    {
        public UserId(long value)
        {
            Value = value;
        }

        public long Value { get; }

        public bool Equals([AllowNull] UserId other)
        {
            throw new NotImplementedException();
        }
    }
}
