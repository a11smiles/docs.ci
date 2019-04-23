using System;

namespace Docs.Formatters
{
    public class FormatterBase
    {
        public virtual string Format(string text) => throw new NotImplementedException();

        public virtual string FormatMarkdown(string text, FormatType? type) => throw new NotImplementedException();
    }
}