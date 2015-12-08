﻿using Shouldly.Tests.Strings;
using Xunit;

namespace Shouldly.Tests.ShouldBePositive
{
    public class DecimalScenario
    {
        [Fact]
        public void DecimalScenarioShouldFail()
        {
            var @decimal = (-3.5m);
            Verify.ShouldFail(() =>
@decimal.ShouldBePositive("Some additional context"),

errorWithSource:
@"@decimal
    should be positive but
-3.5
    is negative

Additional Info:
    Some additional context",

errorWithoutSource:
@"-3.5
    should be positive but is negative

Additional Info:
    Some additional context");
        }

        [Fact]
        public void ShouldPass()
        {
            7.5m.ShouldBePositive();
        }
    }
}