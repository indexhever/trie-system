using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using TrieSystem;

namespace Tests
{
    public class TrieTests
    {
        private const int AMOUNT_LETTERS_ALPHABET = 26;

        [Test]
        public void CreateTrie()
        {
            TrieNode trieNode = new TrieNode();

            Assert.NotNull(trieNode);
        }

        [Test]
        public void GetChildren()
        {
            TrieNode trieNode = new TrieNode();

            TrieNode[] returnedChildren = trieNode.Children;

            Assert.NotNull(returnedChildren);
            Assert.AreEqual(AMOUNT_LETTERS_ALPHABET, returnedChildren.Length);
        }

        [Test]
        public void SetNode()
        {
            var charToAdd = 'a';
            TrieNode newNode = new TrieNode();
            TrieNode trieNode = new TrieNode();

            trieNode.SetNode(charToAdd, newNode);
            TrieNode returnedChildren = trieNode.Children[0];

            Assert.AreEqual(newNode, returnedChildren);
        }

        [Test]
        public void GetNode()
        {
            var searchedChar = 'a';
            TrieNode trieNode = new TrieNode();
            TrieNode newNode = new TrieNode();
            trieNode.SetNode(searchedChar, newNode);

            TrieNode returnedNode = trieNode.GetNode(searchedChar);

            Assert.AreEqual(newNode, returnedNode);
        }

        [Test]
        public void AddString_WithEqualPreviousStartChar_RestoOfStringIsChildOfPreiousChar()
        {
            var stringToAdd = "ab";
            var searchedChar = 'a';
            TrieNode trieNode = new TrieNode();
            trieNode.SetNode(searchedChar, new TrieNode());

            trieNode.Add(stringToAdd);
            TrieNode returnedNode = trieNode.GetNode(searchedChar)
                                            .GetNode('b');

            Assert.IsNotNull(returnedNode);
        }
    }
}
