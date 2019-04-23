using System;
using Xunit;
using Docs.Parsers;

namespace Docs.Tests.Parsers
{
    public class ParserBaseTest
    {
        [Fact]
        public void Parser_ShouldThrowNotImplementedException()
        {
            var pb = new ParserBase();
            Assert.Throws<NotImplementedException>(() => pb.Parse());
        }
    }
}
