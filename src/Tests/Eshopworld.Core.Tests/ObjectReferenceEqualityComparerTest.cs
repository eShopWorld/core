﻿using Eshopworld.Core;
using Eshopworld.Tests.Core;
using FluentAssertions;
using Xunit;

// ReSharper disable once CheckNamespace
public class ObjectReferenceEqualityComparerTest
{
    public new class Equals
    {
        [Fact, IsUnit]
        public void Test_EqualsOnInts()
        {
            var reference1 = (object)1;
            var reference2 = (object)1;

            ObjectReferenceEqualityComparer<object>.Default.Equals(reference1, reference2).Should().BeFalse();
        }

        [Fact, IsUnit]
        public void Test_EqualsOnStrings()
        {
            var reference1 = 123.ToString();
            var reference2 = 123.ToString();

            ObjectReferenceEqualityComparer<object>.Default.Equals(reference1, reference2).Should().BeFalse();
        }
    }

    public new class GetHashCode
    {
        [Fact, IsUnit]
        public void Test_OnInts()
        {
            var reference1 = (object)1;
            var reference2 = (object)1;

            ObjectReferenceEqualityComparer<object>.Default.GetHashCode(reference1).Should().NotBe(ObjectReferenceEqualityComparer<object>.Default.GetHashCode(reference2));
        }

        [Fact, IsUnit]
        public void Test_OnStrings()
        {
            var reference1 = 123.ToString();
            var reference2 = 123.ToString();

            ObjectReferenceEqualityComparer<object>.Default.GetHashCode(reference1).Should().NotBe(ObjectReferenceEqualityComparer<object>.Default.GetHashCode(reference2));
        }
    }
}
