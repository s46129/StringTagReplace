using Sirenix.OdinInspector;
using StringTagReplace.Runtime.Script;
using UnityEngine;

namespace StringTagReplace.Sample.Script
{
    public class SampleReader : MonoBehaviour
    {
        [SerializeField] private TextAsset data;
        [SerializeField] private TagReplaceDictionary _dictionary;

        [Button]
        [HideIf("@data==null||_dictionary==null")]
        private void Test()
        {
            var replaceValue = _dictionary.ReplaceAll(data.text);
            Debug.Log($"{data.text} =>{replaceValue}");
        }
    }
}