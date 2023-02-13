using System.Text.RegularExpressions;
using UnityEngine;

namespace Sample.Script
{
    public class SampleReader : MonoBehaviour
    {
        [SerializeField] private TextAsset data;

        private void Start()
        {
            string dataText = data.text;

            string pattern = @"<button=(\d+)>";

            Match match = Regex.Match(dataText, pattern);
            if (match.Success)
            {
                foreach (Group matchGroup in match.Groups)
                {
                    Debug.Log($"{matchGroup.Name} : {matchGroup.Value}");
                }
            }
        }
    }
}