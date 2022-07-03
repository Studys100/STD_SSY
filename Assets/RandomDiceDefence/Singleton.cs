using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    static T _Instance;
    public static T Instance
    {
        get
        {
            if(_Instance == null)
            {
                // init here for instance
                GameObject goInstance = new GameObject();
                goInstance.name = typeof(T).Name;
                _Instance =  goInstance.AddComponent<T>();
            }

            return _Instance;
        }
    }
}
