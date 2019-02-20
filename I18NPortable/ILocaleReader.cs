using System.Collections.Generic;
using System.IO;

namespace I18NPortablewithReverseLookup
{
    public interface ILocaleReader
    {
        Dictionary<string, string> Read(Stream stream);
    }
}