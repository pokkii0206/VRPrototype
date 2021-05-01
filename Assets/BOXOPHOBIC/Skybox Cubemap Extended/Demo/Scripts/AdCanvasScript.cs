using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdCanvasScript : MonoBehaviour
{


    GrabScript grabScript;
    
    // Start is called before the first frame update
    void Start()
    {
         
         DebugUIBuilder.instance.AddLabel("AdCanvasScript is called");
         GameObject obj = (GameObject)Resources.Load("AdCanvas Variant");
        Instantiate(obj, new Vector3(1.8f, 1.8f, 2.9f), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
}
