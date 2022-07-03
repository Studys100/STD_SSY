using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UserDataManager;

// ���� �����͸� �����մϴ�.
public class UserDataManager : Singleton<UserDataManager>
{
    public int Gold;
    
    [SerializeField]
    List<int> uidsForDiceData = new List<int>();

    // Composite ���Ͽ��� ������ ������ ����.
    // �����ڴ� ���� ��ɵ� ����.
    public class BattleDiceActor : IBuffable
    {
        // �о���� ���� ������
        public DiceData data { get; set; } // �������� �� �� �ִ� ReadOnly Data

        // Dice Data�� Runtime ����
        public RuntimeDiceData runtimeData { get; set; }

        public List<Buff> buffs { get; private set; } = new List<Buff>();

        // speed

        public void Init()
        {
            // ���� �ý��� �ʱ�ȭ
            foreach(var id in data.InitialBuffIDs)
            {
                this.AddBuff(id);
            }

            // ��Ÿ�ӽÿ� �ʿ��� �����͸� �������� ����
            runtimeData = data.MakeRuntimeData(); 
        }

        public void UpdateBuff()
        {

        }
    }
    public class CurrentEnemyData : IBuffable
    {
        public EnemyDiceData data { get; set; }
        public List<Buff> buffs { get; private set; } = new List<Buff>();

        public float speedRateValue = 1;

        // GetSpeed (��ȹ�ڰ� ������ ���ǵ� ��) * speedBuffValue(1)
        public float GetBuffedSpeed => data.GetSpeed * speedRateValue;
    }

    

    public override void Init()
    {
        base.Init();
    }
}
