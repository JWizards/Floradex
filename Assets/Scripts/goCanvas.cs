using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goCanvas : MonoBehaviour
{
    Canvas[] canvi = (Canvas[]) GameObject.FindObjectsOfType(typeof(Canvas));       
    
    public void go(){
        foreach(Canvas c in canvi){
            c.GetComponent<Canvas>().enabled = false;
        }
        gameObject.GetComponent<Canvas>().enabled = true;
    }

}
