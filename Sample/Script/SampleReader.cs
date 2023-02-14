using Sirenix.OdinInspector;
using StringTagReplace.Runtime.Script;
using UnityEngine;

namespace Sample.Script
{
    public class SampleReader : MonoBehaviour
    {
        [SerializeField] private TextAsset data;

        [Button]
        private void Test()
        {
            string dataText = data.text;

            TagFinder.MatchTag(dataText);
        }
    }
}