using System;

namespace TrieSystem
{
    public class TrieSequence
    {
        private TrieNode trieRootNode;

        public TrieSequence(string[] datas)
        {
            trieRootNode = new TrieNode();

            foreach (var data in datas)
            {
                trieRootNode.Add(data);
            }
        }

        public bool Exists(string searchWord)
        {
            var currentNode = trieRootNode;
            foreach(var wordChar in searchWord)
            {
                currentNode = currentNode.GetNode(wordChar);
                if (currentNode == null)
                    return false;
            }
            return true;
        }
    }
}