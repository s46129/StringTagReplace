using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using UnityEngine;

namespace StringTagReplace.Runtime.Script
{
    public static class TagFinder
    {
        public static void MatchTag(string dataText)
        {
            const string pattern = @"<[Bb]utton=(\d+)>";

            var match = Regex.Match(dataText, pattern);
            for (var i = 0; i < match.Length; i++)
            {
                Debug.Log($"{match.Groups[1]}");
                match = match.NextMatch();
            }
        }
    }
}