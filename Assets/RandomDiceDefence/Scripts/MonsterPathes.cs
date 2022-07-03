using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterPathes : MonoBehaviour
{
    [SerializeField]
    List<GameObject> pathes = new List<GameObject>();
    public List<GameObject> GetPathes => pathes;
}
