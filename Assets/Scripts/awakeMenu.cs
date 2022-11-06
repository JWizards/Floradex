using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


public class awakeMenu : MonoBehaviour
{
    public GameObject[] popIn;
    public float interv_begin = 0.2f;
    public float interv_close = 0.45f;

    private int n;   //number of elements in popIn
    private float[] intervs;

    private float start_time;

    void Start()
    {
        start_time = Time.time;

        n = popIn.Length;
        intervs = new float[n];        

        for(int i = 0; i < n; i++){
            intervs[i] = Random.Range(interv_begin, interv_close);
        }
        if(intervs != null)
            intervs[0] = 0;
    }

    bool flag = true;
    // Update is called once per frame
    void Update()
    {
        bool should_run = gameObject.transform.parent.gameObject.GetComponent<Canvas>().enabled;
        if(!should_run){
            for(int i =0; i < n; i++)
                popIn[i].GetComponent<Animator>().SetBool("popnow", false);
            
            start_time = Time.time;
            flag = true;
        }

        if(flag && should_run){
            float elapsed = Time.time - start_time;
            if(elapsed < intervs.Sum()){
                for(int i = 0; i < n; i ++){
                    if (elapsed > (intervs.Take(i+1)).Sum() ){
                        popIn[i].GetComponent<Animator>().SetBool("popnow", true);
                    }
                }
            } else {
                for(int i = 0; i < n; i ++)
                    popIn[i].GetComponent<Animator>().SetBool("popnow", true);
                flag = false;
            }
        }
    }
}
