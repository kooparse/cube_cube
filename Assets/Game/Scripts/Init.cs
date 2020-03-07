using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Init : MonoBehaviour
{
     [RuntimeInitializeOnLoadMethod]
    static void Hey()
    {
        Debug.Log("Hey");
    }
}
