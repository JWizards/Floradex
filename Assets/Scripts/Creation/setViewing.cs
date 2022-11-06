using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setViewing : MonoBehaviour
{
    public int pos;

    public void writeViewing(){
        GameDataManager manager = transform.parent.gameObject.GetComponent<GameDataManager>(); 
        manager.readFile();
        manager.gameData.viewing = pos;
        manager.writeFile();
    }
}
