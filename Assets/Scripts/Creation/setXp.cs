using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setXp : MonoBehaviour
{
    public int xp;

    public void writeXP()
    {
        GameDataManager manager = transform.parent.gameObject.GetComponent<GameDataManager>(); 
        manager.readFile();
        Array.Resize(ref manager.gameData.xp, manager.gameData.no_plants + 1);
        manager.gameData.xp[manager.gameData.no_plants] = xp;

        manager.writeFile();
    }
}
