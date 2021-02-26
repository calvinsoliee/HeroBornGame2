using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CustomExtensions
{
    // 2
    public static class StringExtensions
    {
        // 3
        public static void FancyDebug(this string str)
        {
            // 4
            Debug.LogFormat("This string contains {0} characters.",
            str.Length);
        }
    }
}

