using System;

namespace TrieSystem
{
    public class TrieNode
    {
        private static int NUMBER_OF_CHARACTERS = 26;
        TrieNode[] children = new TrieNode[NUMBER_OF_CHARACTERS];

        public TrieNode[] Children => children;

        public void Add(string stringToAdd)
        {
            Add(stringToAdd, 0);
        }

        private void Add(string stringToAdd, int indexOfChar)
        {
            if (indexOfChar == stringToAdd.Length) return;
            char currentChar = stringToAdd[indexOfChar];
            int charCode = GetCharIndex(currentChar);
            TrieNode child = GetNode(currentChar);

            if (child == null)
            {
                child = new TrieNode();
                SetNode(currentChar, child);
            }

            child.Add(stringToAdd, indexOfChar + 1);
        }

        public void SetNode(char charToAdd, TrieNode newNode)
        {
            Children[GetCharIndex(charToAdd)] = newNode;
        }

        public TrieNode GetNode(char searchedChar)
        {
            return Children[GetCharIndex(searchedChar)];
        }

        private int GetCharIndex(char charToSearch)
        {
            return charToSearch - 'a';
        }        
    }
}