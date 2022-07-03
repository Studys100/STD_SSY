using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DAShootBullet : MonoBehaviour
{
    public NormalBullet bulletPrefab;

    [SerializeField]
    HowTarget howTarget = HowTarget.Fornt;

    const float coolTime = 1f;
    float accTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        accTime += Time.deltaTime;
        if(accTime >= 1f)
        {
            // 1초가 지남,
            accTime = 0;

            var targetMonster = MonsterManager.Instance.GetTarget(howTarget);
            if (targetMonster == null)
                return;

            var bullet = GameObject.Instantiate(bulletPrefab);
            bullet.transform.position = transform.position;
            bullet.SetTarget(targetMonster.transform);
        }

        // 1. 시작위치 (o)
        // 2. 방향     (o) 
        // 3. 너무많이 쏴(o)
        // 4. MonsterManager, 몬스터를 추가를 안해놨음.(o)
    }
}
