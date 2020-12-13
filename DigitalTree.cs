using System.Collections.Generic;

namespace KeywordSearch.Searcher
{
    public class DigitalTree
    {
        public Dictionary<char, DigitalTree> Next { get; set; }

        public bool IsWord { get; set; }

        public DigitalTree Fail { get; set; }

        public DigitalTree Parent { get; set; }

        public string Word { get; private set; }

        public DigitalTree()
        {
            Word = "";
            Next = new Dictionary<char, DigitalTree>();
        }

        public virtual DigitalTree Add(string word)
        {
            var firstCharacter = word[0];

            if (!Next.TryGetValue(firstCharacter, out var node))
            {
                Next[firstCharacter] = node = new DigitalTree{ Parent = this, Word = Word + firstCharacter };
            }

            if (word.Length > 1)
            {
                return node.Add(word.Substring(1));
            }

            node.IsWord = true;

            return node;
        }

        public virtual DigitalTree ExploreFailLink(string word)
        {
            var node = this;

            for (var i = 0; i < word.Length; i++)
            {
                var character = word[i];
                if (!node.Next.TryGetValue(character, out node) || node == null)
                {
                    return null;
                }
            }

            return node;
        }
    }
}
