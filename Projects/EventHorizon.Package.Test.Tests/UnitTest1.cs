using System;
using Xunit;
using FluentAssertions;

namespace EventHorizon.Package.Test.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // Given
            var value = "value";
            var expected = "value";

            // When 
            var class1 = new Class1
            {
                Value = value,
            };
            
            // Then
            class1.Value
                .Should().Be(expected);
        }
    }
}
