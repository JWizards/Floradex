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
    public Image pfp;

    void Start(){
        GameDataManager manager = transform.parent.gameObject.GetComponent<GameDataManager>();
        manager.readFile();
        string thingy = manager.gameData.names[0];
        Debug.Log(thingy);
        name.text = manager.gameData.names[pos];
        string image_source = "Floramon/" + manager.gameData.types[pos] + "_" + Math.Floor((manager.gameData.xp[pos])/100d);
        pfp.sprite = Resources.Load <Sprite>(image_source);
    }
}
