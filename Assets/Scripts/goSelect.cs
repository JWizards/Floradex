using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goSelect : MonoBehaviour
{
    public GameObject[] go_list; 
    
    public void goCorrect(){
        GameDataManager manager = transform.parent.gameObject.GetComponent<GameDataManager>();
        
        Canvas[] canvi = (Canvas[]) GameObject.FindObjectsOfType(typeof(Canvas));  
        foreach(Canvas c in canvi){
            c.GetComponent<Canvas>().enabled = false;
        }
        manager.readFile();
        go_list[manager.gameData.no_plants].GetComponent<Canvas>().enabled = true;

    } 
}
