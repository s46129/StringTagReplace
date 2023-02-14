using System;
using System.Collections.Generic;
using System.Linq;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.Serialization;

namespace StringTagReplace.Runtime.Script
{
    [CreateAssetMenu(menuName = "TagReplace/Dictionary", fileName = "Data")]
    public class TagReplaceDictionary : ScriptableObject
    {
        [FormerlySerializedAs("_dictionary")] [SerializeField]
        private List<Tag> dictionary = new();

        public string GetValue(string key)
        {
            foreach (var tag in dictionary.Where(tag => tag.key == key)) return tag.value;
            return key;
        }

        public void InsertData(Tag tag)
        {
            dictionary ??= new List<Tag>();
            var tags = dictionary.Where(find => find.key == tag.key).ToList();
            if (!tags.Any()) dictionary.Add(tag);
        }
    }

    [Serializable]
    public struct Tag
    {
        [HorizontalGroup("tag")] [HideLabel] public string key;
        [HorizontalGroup("tag")] [HideLabel] public string value;
    }
}