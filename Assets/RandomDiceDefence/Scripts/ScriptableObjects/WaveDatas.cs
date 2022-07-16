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

[Serializable]
public class WaveData
{
    public int WaveID { get; set; }
    public float startTime;
    public float duration;
    public int spawnCount;
    public float cooltimeForSpawn;

    public int MonsterUID;

    // start�� endtime ���� ��ȯ�� �ؾ���.
    
    public IEnumerator RegistSpawn()
    {
        // start Ÿ�ӵ��� ���ñ�!
        yield return new WaitForSeconds(startTime);
        var parent = GameScene.CurrentScene.transform;

        // start time �ڿ� ����ͼ�!
        float accTime = 0;
        do
        {
            // spawn
            var monster = GameObject.CreatePrimitive(PrimitiveType.Cube);
            monster.transform.SetParent(parent);
            yield return new WaitForSeconds(cooltimeForSpawn); //0.3��

            accTime += cooltimeForSpawn; // 0.0x��
            if (accTime >= duration)
            {
                break;
            }
        } while (GameScene.CurrentScene.stateRP.Value != GameScene.State.End);
    }
}

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/WaveDatas", order = 1)]
public class WaveDatas : ScriptableObject
{
    public List<WaveData> waveDatas = new List<WaveData>();
}
