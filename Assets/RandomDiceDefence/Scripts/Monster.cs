using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// 몬스터 매니저에 약한 커플링, 굳이 몬스터 매니저가 반드시 필요한건 아님.
public class Monster : MonoBehaviour
{
    [SerializeField]
    EnemyDiceData diceData; // reference 형

    float CurrentHP;

    MonsterPathes monsterPathes;
    int currentPathIndex = 0;

    private void Awake()
    {
        MonsterManager.Instance.AddTargetable(this);
        CurrentHP = diceData.GetMaxHP;
    }

    private void OnDestroy()
    {
        MonsterManager.Instance.RemoveTarget(this);
    }

    private void Start()
    {
        // caching 임시객체를 저장해서 변수로 갖고있자
        monsterPathes = GameSceneBase.GetActive<BattleScene>().GetMonsterPathes;
        CurrentHP--;
        Debug.LogError(GetHashCode()+" HP : " + CurrentHP);
    }

    // Update is called once per frame
    void Update()
    {
        if (currentPathIndex >= monsterPathes.GetPathes.Count)
        {
            currentPathIndex = 0;
            return;
        }

        var currentPath = monsterPathes.GetPathes[currentPathIndex].transform.position;
        var currentPos = transform.position;
        
        // 방향 백터
        // 좌표계 
        var dirVec = currentPath - currentPos;
        transform.position += dirVec.normalized * Time.deltaTime * 4f;

        // 도착했는지 체크 후 목적지 다음으로 바꿈
        if(dirVec.magnitude < 0.5f)
        {
            currentPathIndex++;
        }
    }
}
