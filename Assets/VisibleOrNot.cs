using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisibleOrNot : MonoBehaviour
{
     void OnBecameVisible()
    {
        DebugUIBuilder.instance.AddLabel("表示される様になった");
    }

    void OnBecameInvisible(){
        DebugUIBuilder.instance.AddLabel("表示されない様になった");

    }
}
