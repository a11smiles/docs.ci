using System;
using Xunit;
using Docs.Formatters;

namespace Docs.Tests.Formatters
{
    public class FormatterBaseTest
    {
        [Fact]
        public void Formatter_ShouldThrowNotImplementedException()
        {
            var fb = new FormatterBase();
            Assert.Throws<NotImplementedException>(() => fb.Format());
        }
    }
}