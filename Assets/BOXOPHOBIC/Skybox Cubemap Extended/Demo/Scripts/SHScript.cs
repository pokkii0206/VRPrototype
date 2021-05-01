using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SHScript : MonoBehaviour
{

    public GameObject Shoes;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Show(){
        DebugUIBuilder.instance.AddLabel("Show is called");
        Shoes.SetActive(true);
    }

    public void Hide(){
        DebugUIBuilder.instance.AddLabel("Hide is called");
        Shoes.SetActive(false);
    }
}
