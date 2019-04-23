using System;

namespace Docs.Formatters
{
    public class FormatterBase
    {
        public virtual string Format() {
            throw new NotImplementedException();
        }
    }
}