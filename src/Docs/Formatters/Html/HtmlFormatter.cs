using System;
using System.Linq;
using Docs.Formatters;

namespace Docs.Formatters.Html {

    public class HtmlFormatter : FormatterBase {

        public override string FormatMarkdown(string text, FormatType? type) {
            if (type == FormatType.Header)
                return FormatHeader(text);
            else if (type == FormatType.Emphasis)
                throw new NotImplementedException();
            else if (type == FormatType.List)
                throw new NotImplementedException();
            else if (type == FormatType.Link)
                throw new NotImplementedException();
            else if (type == FormatType.Image)
                throw new NotImplementedException();
            else if (type == FormatType.Code)
                throw new NotImplementedException();
            else if (type == FormatType.Table)
                throw new NotImplementedException();
            else if (type == FormatType.Blockquote)
                throw new NotImplementedException();
            else if (type == FormatType.InlineHtml)
                throw new NotImplementedException();
            else if (type == FormatType.HorizontalRule)
                return FormatHorizontalRule();
            else if (type == FormatType.LineBreak)
                return FormatLineBreak();
            else 
                throw new FormatException();
        }

        private string FormatHeader(string text) {
            int count = text.TakeWhile(c => c == '#').Count();

            return String.Concat("<h", count, ">", text.Substring(count+1), "</h", count, ">");
        }

        private string FormatHorizontalRule() {
            return "</hr>";
        }

        private string FormatLineBreak() {
            return "</br>";
        }
    }
}