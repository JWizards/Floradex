using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class makeName : MonoBehaviour
{

    public TMP_InputField field;


    public void writeName()
    {
        GameDataManager manager = transform.parent.gameObject.GetComponent<GameDataManager>(); 
        manager.readFile();
        Array.Resize(ref manager.gameData.names, manager.gameData.no_plants + 1);
        manager.gameData.names[manager.gameData.no_plants] = field.text;

        manager.writeFile();
    }
}
