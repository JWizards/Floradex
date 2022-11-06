using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.UI;
using UnityEngine;
using TMPro;


public class WaterStatus : MonoBehaviour
{

    public TMP_Text Streak;
    public TMP_Text Status;

    int[,] data;

    GameDataManager manager;

    void Start(){
        GameDataManager manager = transform.parent.gameObject.GetComponent<GameDataManager>();
        manager.readFile();
        data = manager.gameData.water_days;
    }

    void Update(){
        if(data[manager.gameData.viewing , 0] == 1){
            Status.text = "Watered!";
        } else {
            Status.text = "Water your plant !";
        }

        int count = 0;
        while(data[manager.gameData.viewing , count] == 1){
            count += 1;
        }

        Streak.text = ""+count;
    }

}
