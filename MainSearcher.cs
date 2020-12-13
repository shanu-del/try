namespace KeywordSearch.Searcher
{
    public class MainSearcher
    {
        private readonly DigitalTree _digitalTree;

        public MainSearcher()
        {
            _digitalTree = new DigitalTree();
        }

        public MainSearcher(string[] words) : this()
        {
            for (var i = 0; i < words.Length; i++)
            {
                _digitalTree.Add(words[i].ToLower());
            }

            FixFailedBuild();
        }

        public void FixFailedBuild(DigitalTree node = null)
        {
            node = node ?? _digitalTree;

            var word = node.Word;
            for (var i = 1; i < word.Length && node.Fail == null; i++)
            {
                node.Fail = _digitalTree.ExploreFailLink(word.Substring(i));
            }

            foreach (var subNode in node.Next.Values)
            {
                FixFailedBuild(subNode);
            }
        }

        public bool Search(string source)
        {
            var current = _digitalTree;

            for (var i = 0; i < source.Length; i++)
            {
                var character = source[i];

                while (current != null && !current.Next.ContainsKey(character))
                {
                    current = current.Fail;
                }

                if (current == null)
                {
                    current = _digitalTree;
                }

                if (!current.Next.TryGetValue(character, out current))
                {
                    continue;
                }

                var node = current;

                while (node != null)
                {
                    if (node.IsWord)
                    {
                        return true;
                    }

                    node = node.Fail;
                }
            }

            return false;
        }
    }
}
