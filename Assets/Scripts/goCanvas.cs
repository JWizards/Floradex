using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goCanvas : MonoBehaviour
{
    Canvas[] canvi = (Canvas[]) GameObject.FindObjectsOfType(typeof(Canvas));       
    
    public static go(){
        for{ Canvas c in canvi }{
            c.GetComponent<Canvas>().enabled = false;
        }
        gameObject.GetComponent<Canvas>().enabled = true;
    }

}
