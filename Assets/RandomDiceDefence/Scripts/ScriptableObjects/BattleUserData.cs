using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ���� �ֱ� : �α��νÿ� ����
// �α׾ƿ� �ÿ� ���� ��.
//public class UserData
//{
//    // ���� ��
//    // 1������ dice�� 32, 10, 50, 22, 31, -
//    public List<int> UserBattleTeam1 = new List<int>();
//    public Dictionary<int, UserDiceData> uidToUserDiceData;
//}

// ���� �ֱ⸦ �ľ��ؾ� ��
// ��ũ��Ʈ���̺� ������Ʈ�ΰ�? �ƴϴ�.
// �����ֱⰡ ���� ����? ���� ���� ��,

// const
public class DiceData
{
    public List<int> InitialBuffID = new List<int>(); // �±� ���� �͵�, �¿����� �ֵ�
    public float PointForSummon;
    public int BulletID;                              // � �Ѿ��� �� ������

}

// current data

public class CurrentDiceData
{

}

public class BattleUserData
{
    [SerializeField]
    int UserID;

    [SerializeField]
    int PointForSummon;
}
