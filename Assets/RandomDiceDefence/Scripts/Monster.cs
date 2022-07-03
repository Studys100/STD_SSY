using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// ���� �Ŵ����� ���� Ŀ�ø�, ���� ���� �Ŵ����� �ݵ�� �ʿ��Ѱ� �ƴ�.
public class Monster : MonoBehaviour
{
    [SerializeField]
    EnemyDiceData diceData; // reference ��

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
        // caching �ӽð�ü�� �����ؼ� ������ ��������
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
        
        // ���� ����
        // ��ǥ�� 
        var dirVec = currentPath - currentPos;
        transform.position += dirVec.normalized * Time.deltaTime * 4f;

        // �����ߴ��� üũ �� ������ �������� �ٲ�
        if(dirVec.magnitude < 0.5f)
        {
            currentPathIndex++;
        }
    }
}