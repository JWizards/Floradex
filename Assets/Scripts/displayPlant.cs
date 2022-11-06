using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class displayPlant : MonoBehaviour
{
    public int pos;

    public TMP_Text name;
    Image pfp;

    void Start(){
        GameDataManager manager = transform.parent.gameObject.GetComponent<GameDataManager>();
        pfp = gameObject.GetComponent<Image>();
        name.text = manager.gameData.names[pos];
        Debug.Log(pfp.sprite);
        string image_source = "Floramon" + manager.gameData.types[pos] + "_" + Math.Floor((manager.gameData.xp[pos])/100d);
        Sprite creature =  Resources.Load <Sprite>(image_source);  
        pfp.sprite = creature;
    }
}
