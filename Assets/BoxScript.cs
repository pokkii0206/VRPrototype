using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxScript : MonoBehaviour
{
    // Start is called before the first frame update


    void Start()
    {
        DebugUIBuilder.instance.AddLabel("表示されたよ");
         DebugUIBuilder.instance.Show();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
