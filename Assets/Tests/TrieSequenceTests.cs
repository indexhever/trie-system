using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using TrieSystem;

namespace Tests
{
    public class TrieSequenceTests
    {
        [Test]
        public void CreateSequence()
        {
            string[] datas = new string[] { "amor", "vida" };
            TrieSequence trieSequence = new TrieSequence(datas);

            Assert.IsNotNull(trieSequence);
        }

        [TestCase("amor", true)]
        [TestCase("vida", true)]
        [TestCase("life", false)]
        [TestCase("damit", true)]
        public void Exists_StringInsideSequence_ReturnsTrue(string searchedWord, bool expectedResult)
        {
            string[] datas = new string[] { "amor", "vida", "damit" };
            TrieSequence trieSequence = new TrieSequence(datas);

            bool isStringInSequence = trieSequence.Exists(searchedWord);

            Assert.AreEqual(expectedResult, isStringInSequence);
        }
    }
}
