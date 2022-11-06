using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makeType : MonoBehaviour
{
    public string type;

    public void writeType(){
        GameDataManager manager = transform.parent.gameObject.GetComponent<GameDataManager>();
        Debug.Log(manager);
        manager.readFile();
        Array.Resize(ref manager.gameData.types, manager.gameData.no_plants + 1);
        manager.gameData.types[manager.gameData.no_plants] = type;
        manager.writeFile();
    }
}
