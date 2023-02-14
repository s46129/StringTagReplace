using NUnit.Framework;
using StringTagReplace.Runtime.Script;
using UnityEngine;

namespace StringTagReplace.Test
{
    public class TestReplaceTag
    {
        [TestCase("<button=1>", "<sprite=3>")]
        [TestCase("<button=1>", "<button=3>")]
        [TestCase("<button=1>", "<button=1>")]
        public void TestReplaceAll(string key, string value)
        {
            var tagReplaceDictionary = ScriptableObject.CreateInstance<TagReplaceDictionary>();
            tagReplaceDictionary.InsertData(new Tag { key = key, value = value });
            var testData = $"This Tag {key} be replace";
            var actual = tagReplaceDictionary.ReplaceAll(testData);
            var assertion = $"This Tag {value} be replace";
            Assert.AreEqual(assertion, actual);
        }
    }
}