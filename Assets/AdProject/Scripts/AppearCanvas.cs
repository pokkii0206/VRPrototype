using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearCanvas : MonoBehaviour
{
    public GameObject canvas = null;



    void Start()
    {

    
        canvas.GetComponent<GameObject>();
         canvas.SetActive(false);
    }

    public void ShowCanvas(){

        canvas.SetActive(true);

    }

}
