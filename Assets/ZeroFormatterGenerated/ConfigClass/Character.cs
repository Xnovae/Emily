using ZeroFormatter;

namespace ClientConfig
{
    [ZeroFormattable]
    public class Character : ConfigGetItem<Character, CharacterItem>
    {
        [Index(0)]
        public virtual ILazyDictionary<string, byte[]> _internalDictionary { get; set; }

        protected override ILazyDictionary<string, byte[]> GetInternalDictionary()
        {
            return _internalDictionary;
        }
        
        protected override void SetInternalDictionary(ILazyDictionary<string, byte[]> dictionary)
        {
            _internalDictionary = dictionary;
        }
    }
}