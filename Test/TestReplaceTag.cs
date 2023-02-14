using NUnit.Framework;
using StringTagReplace.Runtime.Script;
using UnityEngine;

namespace StringTagReplace.Test
{
    public class TestReplaceTag
    {
        [TestCase("<button=1>", "<sprite=3>")]
        [TestCase("<button=1>", "<button=3>")]
        public void TestGetValue(string key, string value)
        {
            var tagReplaceDictionary = ScriptableObject.CreateInstance<TagReplaceDictionary>();
            tagReplaceDictionary.InsertData(new Tag { key = key, value = value });
            Assert.AreEqual(tagReplaceDictionary.GetValue(key), value);
        }
    }
}