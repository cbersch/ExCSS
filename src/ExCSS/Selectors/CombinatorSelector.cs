namespace ExCSS
{
    public sealed class CombinatorSelector
    {
        public string Delimiter { get; }
        public ISelector Selector { get; }

        public CombinatorSelector(ISelector selector, string delimiter = null)
        {
            Selector = selector;
            Delimiter = delimiter;
        }
    }
}