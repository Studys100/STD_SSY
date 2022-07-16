using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 N 웨이브
a~b 초까지
한번에 생성되는 갯수 
몇초에 한번씩 생성될지 주기
어떤 몬스터를 생성할 지
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

    // start랑 endtime 동안 소환을 해야함.
    
    public IEnumerator RegistSpawn()
    {
        // start 타임동안 쉬시구!
        yield return new WaitForSeconds(startTime);
        var parent = GameScene.CurrentScene.transform;

        // start time 뒤에 여기와서!
        float accTime = 0;
        do
        {
            // spawn
            var monster = GameObject.CreatePrimitive(PrimitiveType.Cube);
            monster.transform.SetParent(parent);
            yield return new WaitForSeconds(cooltimeForSpawn); //0.3초

            accTime += cooltimeForSpawn; // 0.0x초
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
