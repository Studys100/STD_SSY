using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UserDataManager;

#region Buff System
public abstract class Buff
{
    protected BattleDiceActor toUser;
    protected CurrentEnemyData toEnemy;

    public abstract void Start();
    public abstract void Update();
    public abstract void End();
}

// Buff ����� ����
public interface IBuffable
{
    public List<Buff> buffs { get; }
}

public static class BuffableExtension
{
    public static void AddBuff(this IBuffable buffable, int buffID)
    {
        buffable.buffs.Add(DataManager.Instance.GetBuffData(buffID));
    }
}
#endregion



#region Simple Buff
public class BuffSlow : Buff
{
    [Range(-3f, 3f)]
    public float decreaseSpeedRate;

    // User Dice ���� �ӵ��� �����.
    // Monster Dice ���Դ� �̵��ӵ��� �����.

    public override void End()
    {
        if (toEnemy != null)
        {
            toEnemy.speedRateValue += decreaseSpeedRate;
        }

        if (toUser != null && toUser.data is DiceShootData shootData)
        {
            
        }
    }

    public override void Start()
    {
        if(toEnemy != null)
        {
            toEnemy.speedRateValue -= decreaseSpeedRate;
        }

        if (toUser != null && toUser.data is DiceShootData shootData)
        {
            
        }
    }

    public override void Update()
    {
        
    }
}
#endregion