using Sirenix.OdinInspector;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 N ���̺�
a~b �ʱ���
�ѹ��� �����Ǵ� ���� 
���ʿ� �ѹ��� �������� �ֱ�
� ���͸� ������ ��
 */

public enum MonsterType
{
    NormalMonster,
    BossMonster,
}

[Serializable]
public class WaveData
{
    public int WaveID { get; set; }
    public float startTime;
    public float duration;
    public int spawnCount;
    public float cooltimeForSpawn;

    public MonsterType monsterType;
    public bool IsBoss => monsterType == MonsterType.BossMonster;

    [HideIf(nameof(IsBoss))]
    public int MonsterUID;

    [ShowIf(nameof(IsBoss))]
    public int BossUID;

    // start�� endtime ���� ��ȯ�� �ؾ���.
    
    public IEnumerator RegistSpawn()
    {
        // start Ÿ�ӵ��� ���ñ�!
        yield return new WaitForSeconds(startTime);
        var currentScene = GameScene.CurrentScene;
        var parent = currentScene.transform;

        // start time �ڿ� ����ͼ�!
        float accTime = 0;
        do
        {
            var targetEnemyData = DataManager.Instance.GetEnemyDiceDatas.GetEnemyData(MonsterUID);
            var firstSpawnPath = currentScene.GetMonsterPath.GetPathes[0];

            // spawn
            var monster = targetEnemyData.CreateMonsterInstance(parent);
            monster.transform.position = firstSpawnPath.transform.position;

            yield return new WaitForSeconds(cooltimeForSpawn); //0.3��

            accTime += cooltimeForSpawn; // 0.0x��
            if (accTime >= duration)
            {
                break;
            }
        } while (currentScene.stateRP.Value != GameScene.State.End);
    }
}

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/WaveDatas", order = 1)]
public class WaveDatas : ScriptableObject
{
    public List<WaveData> waveDatas = new List<WaveData>();
}
