using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hardcoder : MonoBehaviour
{
    public List<string> hardcodeTextContent;
    public static int count = 0;

    public string GetHardcodedTextContent()
    {
        count++;
        return hardcodeTextContent[(count - 1)% hardcodeTextContent.Capacity];
    }

    public int GetCount()
    {
        return count;
    }
}
