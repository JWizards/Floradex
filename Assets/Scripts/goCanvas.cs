using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goCanvas : MonoBehaviour
{
    public void go(){

        Canvas[] canvi = (Canvas[]) GameObject.FindObjectsOfType(typeof(Canvas));  
        foreach(Canvas c in canvi){
            c.GetComponent<Canvas>().enabled = false;
        }
        gameObject.GetComponent<Canvas>().enabled = true;
    }

}
