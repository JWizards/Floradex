using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class modifyCount : MonoBehaviour
{
    public void addCount()
    {
        GameDataManager manager = transform.parent.gameObject.GetComponent<GameDataManager>(); 
        manager.readFile();
        manager.gameData.no_plants += 1;
        manager.writeFile();
    }

    public void minusCount()
    {
        GameDataManager manager = transform.parent.gameObject.GetComponent<GameDataManager>(); 
        manager.readFile();
        manager.gameData.no_plants += 1;
        manager.writeFile();
    }
}
