using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makeName : MonoBehaviour
{
    GameDataManager manager;

    void Start()
    {
        manager = transform.parent.gameObject.GetComponent<GameDataManager>();  
    }

    // Update is called once per frame
    void Update()
    {
        manager.readFile();
        manager.gameData.names[manager.gameData.no_plants] = "booga booga";
    }
}
