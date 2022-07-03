using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalBullet : MonoBehaviour
{
    Transform targetTransform;
    public void SetTarget(Transform inTarget)
    {
        targetTransform = inTarget;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (targetTransform == null)
        {
            Destroy(this.gameObject);
            return;
        }

        // dir
        var dir = targetTransform.position - transform.position;
        transform.position += dir.normalized * Time.deltaTime * 5f;
    }
}
