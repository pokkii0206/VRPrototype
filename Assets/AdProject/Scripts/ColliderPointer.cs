using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ColliderPointer : MonoBehaviour
{
    
    public float defaultlength = 3.0f;
    private LineRenderer lineRenderer = null;
    public Material colorA;
    public GameObject targetObject;


    private void Awake(){
        lineRenderer = GetComponent<LineRenderer>();
    }
 

    void Update()
    {
        // lineRenderer.SetPosition(0, transform.position);
        // lineRenderer.SetPosition(1, CalculateEnd());
         CreateForwardRaycast();

    }

     private void CreateForwardRaycast(){
        
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        Debug.DrawRay(ray.origin, ray.direction*100, Color.red,  0.1f);

        if (Physics.Raycast(ray, out hit, Mathf.Infinity)){
            if(hit.collider.gameObject.layer == LayerMask.NameToLayer("Collider")){
                    
                    DebugUIBuilder.instance.AddLabel("コライダーにヒットした");
                    ChangeColor();
                    //  endPosition = hit.point;
                // } else {
                //     ChangeColor();
                //     DebugUIBuilder.instance.AddLabel("ヒットしてない");
                // }

        }
        }
    }


    private void ChangeColor(){
        targetObject.GetComponent<Renderer>().material = colorA;
    }

    private void DefaultColor(){
        targetObject.GetComponent<Renderer>().material.color = Color.white;
    }

   

    // private Vector3 DefaultEnd(float length){

    //     return transform.position;
    //     // return  transform.position + (transform.forward * length);
    // }
}
