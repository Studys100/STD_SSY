using Sirenix.OdinInspector;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[Serializable]
public class BossEnemyData : EnemyDiceData
{
    public int PointForSummon;
}

[Serializable]
public class BossEnemyData_1 : BossEnemyData
{
    public int availableCountForCrashWall;
    public int cooltimeForAbility;
}


[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/BossEnemyDatas", order = 1)]
public class BossEnemyDatas : SerializedScriptableObject
{
    [InlineProperty]
    [SerializeField]
    List<EnemyDiceData> enemyDiceDatas = new List<EnemyDiceData>();
}
