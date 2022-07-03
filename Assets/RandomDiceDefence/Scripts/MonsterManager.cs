using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum HowTarget
{
    Fornt,
    Random,
    Back,
}

// 커플링을 용인할것인가, 캡슐화를 절대적으로 우선시 할 것인가.
// Monster를 조작하지 않음. 단순 소유, 그리고 타겟가능한 몬스터에 대한 데이터를 보관하고 있음을 명식적으로 약속함.
public class MonsterManager : Singleton<MonsterManager>
{
    // 몬스터 개체의 타겟팅에 대해 얻어올 수 있음.
    // 몬스터 자료구조에 접근 가능
    // 최신화되고 타겟가능한 몬스터들만 담겨있습니다.
    List<Monster> monsters = new List<Monster>(); 

    public void AddTargetable(Monster monster)
    {
        monsters.Add(monster);
    }

    public void RemoveTarget(Monster monster)
    {
        monsters.Remove(monster);
    }

    public Monster GetTarget(HowTarget how)
    {
        if (monsters.Count <= 0)
            return null;

        switch (how)
        {
            case HowTarget.Fornt:
                return monsters[0];
            case HowTarget.Random:
                break;
            case HowTarget.Back:
                break;
        }
        return null;
    }
}
