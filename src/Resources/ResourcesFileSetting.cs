using System.Diagnostics.CodeAnalysis;

namespace trnsACT.Core.Resources
{
    public class ResourcesFileSetting
    {
        private string _pattern;
        private string _locale;

        public ResourcesFileSetting([DisallowNull] string locale,
                                    [DisallowNull] string pattern)
        {
            _pattern = pattern;
            _locale = locale;
        }

        public string Pattern { get => _pattern; }
        public string Locale { get => _locale; }
    }
}
