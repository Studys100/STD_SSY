using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/EnemyDiceData", order = 1)]
public class EnemyDiceData : ScriptableObject
{
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
