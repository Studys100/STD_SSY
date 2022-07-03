using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

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
public abstract class DiceData
{
    public List<int> InitialBuffIDs = new List<int>(); // �±� ���� �͵�, �¿����� �ֵ�
    public float PointForSummon;
    public int BulletID;                              // � �Ѿ��� �� ������

    abstract public RuntimeDiceData MakeRuntimeData();
}

// ���� ��Ÿ�ӽÿ� �ʿ��� ������ ����
public abstract class RuntimeDiceData
{
    abstract public void Start();
    abstract public void Update();
    abstract public void OnDie();


}

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/DiceDatas", order = 1)]
public class DiceDatas : SerializedScriptableObject
{
    [SerializeField]
    List<DiceData> diceDatas = new List<DiceData>();
}