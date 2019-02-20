namespace I18NPortablewithReverseLookup
{
    public class PortableLanguage
    {
        public string Locale { get; set; }
        public string DisplayName { get; set; }
        public override string ToString() => DisplayName;
    }
}