using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceGearData : DiceShootData
{
    // 능력에 필요한 변수 정의
    // 연결된 주사위가 많을 수 록 공격력이 썌짐

    // Chain : 자기 기준으로 연결된 갯수를 의미 한다.
    [InfoBox("데미지 증가율 : 연결된 갯수마다 0.3==30% 증가 된다.")]
    public float damageIncreaseRatePerChain = 0.3f;
}

public class DiceFrozenData : DiceShootData
{
    // 상대를 맞추면 느려지게 한다.
    [InfoBox("얼마나 속도를 느려지게 할 것인가 0.3 == 30%")]
    public float decreaseSpeedRate = 0.3f;
}