using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BaseSingleton<T> : MonoBehaviour where T : MonoBehaviour
{
    static T _instance;
    public static T Instance => _instance;

    private void Awake()
    {
        _instance = this as T;
    }
}
