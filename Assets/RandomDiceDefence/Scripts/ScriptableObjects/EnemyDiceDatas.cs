using Sirenix.OdinInspector;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyDiceData
{
    [SerializeField]
    int UID;

    [SerializeField]
    float MaxHp;
    public float GetMaxHP => MaxHp;

    [SerializeField]
    float Speed;
    public float GetSpeed => Speed;

    [SerializeField]
    int InitialBuffID;
    public float GetInitBuffID => InitialBuffID;
}


[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/EnemyDiceDatas", order = 1)]
public class EnemyDiceDatas : SerializedScriptableObject
{
    [SerializeField]
    List<EnemyDiceData> enemyDiceDatas = new List<EnemyDiceData>();
}
