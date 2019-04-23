using System;
using Xunit;
using Docs.Formatters;

namespace Docs.Tests.Formatters
{
    public class FormatterBaseTest
    {
        [Fact]
        public void Format_ShouldThrowNotImplementedException()
        {
            var fb = new FormatterBase();
            Assert.Throws<NotImplementedException>(() => fb.Format(string.Empty));
        }

        [Fact]
        public void FormatMarkdown_ShouldThrowNotImplementedException()
        {
            var fb = new FormatterBase();
            Assert.Throws<NotImplementedException>(() => fb.FormatMarkdown(string.Empty, null));
        }
    }
}