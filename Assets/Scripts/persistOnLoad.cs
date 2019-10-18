using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class persistOnLoad : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(this);
    }
}
