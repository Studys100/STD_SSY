using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceGearData : DiceShootData
{
    // �ɷ¿� �ʿ��� ���� ����
    // ����� �ֻ����� ���� �� �� ���ݷ��� �y��

    // Chain : �ڱ� �������� ����� ������ �ǹ� �Ѵ�.
    [InfoBox("������ ������ : ����� �������� 0.3==30% ���� �ȴ�.")]
    public float damageIncreaseRatePerChain = 0.3f;
}

public class DiceFrozenData : DiceShootData
{
    // ��븦 ���߸� �������� �Ѵ�.
    [InfoBox("�󸶳� �ӵ��� �������� �� ���ΰ� 0.3 == 30%")]
    public float decreaseSpeedRate = 0.3f;
}