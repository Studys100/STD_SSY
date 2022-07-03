using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogicManager : MonoBehaviour
{
    [SerializeField]
    Block blockPrefab;

    public static GameLogicManager Instance;
    public Block currentBlock { get; set; }

    private void Awake()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TryMakeBlockWhenNeed()
    {
        var instancedBlock = GameObject.Instantiate(blockPrefab.gameObject);
    }
}
