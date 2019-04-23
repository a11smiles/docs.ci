using System;
using Xunit;
using Docs.Formatters;
using Docs.Formatters.Html;

namespace Docs.Tests.Formatters.Html
{
    public class HtmlFormatterTest
    {
        [Fact]
        public void Format_ShouldThrowNotImplementedException()
        {
            var hf = new HtmlFormatter();
            Assert.Throws<NotImplementedException>(() => hf.Format(string.Empty));
        }

        [Fact]
        public void FormatMarkdown_ShouldThrowFormatException()
        {
            var hf = new HtmlFormatter();
            Assert.Throws<FormatException>(() => hf.FormatMarkdown(string.Empty, null));
        }

        [Theory]
        [InlineData("# header 1", "<h1>header 1</h1>")]
        [InlineData("## header 2", "<h2>header 2</h2>")]
        [InlineData("### header 3", "<h3>header 3</h3>")]
        [InlineData("#### header 4", "<h4>header 4</h4>")]
        [InlineData("##### header 5", "<h5>header 5</h5>")]
        [InlineData("###### header 6", "<h6>header 6</h6>")]
        public void FormatMarkdown_ShouldReturnFormattedHeader(string value, string test)
        {
            var hf = new HtmlFormatter();
            var result = hf.FormatMarkdown(value, FormatType.Header); 
            Assert.True(result == test, result);
        }

        [Fact]
        public void FormatMarkdown_ShouldReturnFormattedEmphasis()
        {
            var hf = new HtmlFormatter();
            var result = hf.FormatMarkdown(string.Empty, FormatType.Emphasis);
        }
        
        [Fact]
        public void FormatMarkdown_ShouldReturnFormattedOrderedList()
        {
            var hf = new HtmlFormatter();
            var result = hf.FormatMarkdown(string.Empty, FormatType.List);
        }
        
        [Fact]
        public void FormatMarkdown_ShouldReturnFormattedUnorderedList()
        {
            var hf = new HtmlFormatter();
            var result = hf.FormatMarkdown(string.Empty, FormatType.List);
        }

        [Fact]
        public void FormatMarkdown_ShouldReturnFormattedLink()
        {
            var hf = new HtmlFormatter();
            var result = hf.FormatMarkdown(string.Empty, FormatType.Link);
        }

        [Fact]
        public void FormatMarkdown_ShouldReturnFormattedImage()
        {
            var hf = new HtmlFormatter();
            var result = hf.FormatMarkdown(string.Empty, FormatType.Image);
        }

        [Fact]
        public void FormatMarkdown_ShouldReturnFormattedCode()
        {
            var hf = new HtmlFormatter();
            var result = hf.FormatMarkdown(string.Empty, FormatType.Code);
        }

        [Fact]
        public void FormatMarkdown_ShouldReturnFormattedTable()
        {
            var hf = new HtmlFormatter();
            var result = hf.FormatMarkdown(string.Empty, FormatType.Table);
        }

        [Fact]
        public void FormatMarkdown_ShouldReturnFormattedBlockquote()
        {
            var hf = new HtmlFormatter();
            var result = hf.FormatMarkdown(string.Empty, FormatType.Blockquote);
        }

        [Fact]
        public void FormatMarkdown_ShouldReturnFormattedInlineHtml()
        {
            var hf = new HtmlFormatter();
            var result = hf.FormatMarkdown(string.Empty, FormatType.InlineHtml);
        }

        [Fact]
        public void FormatMarkdown_ShouldReturnFormattedHorizontalRule()
        {
            var hf = new HtmlFormatter();
            var result = hf.FormatMarkdown(string.Empty, FormatType.HorizontalRule);
            Assert.True(result == "</hr>");
        }

        [Fact]
        public void FormatMarkdown_ShouldReturnFormattedLineBreak()
        {
            var hf = new HtmlFormatter();
            var result = hf.FormatMarkdown(string.Empty, FormatType.LineBreak);
            Assert.True(result == "</br>");
        }
    }
}