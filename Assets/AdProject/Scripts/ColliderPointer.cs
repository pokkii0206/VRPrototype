﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ColliderPointer : MonoBehaviour
{
    
    public float defaultlength = 3.0f;
    private LineRenderer lineRenderer = null;
   

    private void Awake(){
        lineRenderer = GetComponent<LineRenderer>();
    }

    void Update()
    {
       
        lineRenderer.SetPosition(0, transform.position);
        lineRenderer.SetPosition(1, CalculateEnd());
    }


    private Vector3 CalculateEnd(){
        RaycastHit hit = CreateForwardRaycast();
        Vector3 endPosition = DefaultEnd(defaultlength);

        if(hit.collider){
             endPosition = hit.point;
        } 
        return endPosition;


    }

    private RaycastHit CreateForwardRaycast(){
        RaycastHit hit;
        Ray ray = new Ray(transform.position, transform.forward);
        Physics.Raycast(ray, out hit, defaultlength);

        return hit;
    }

    private Vector3 DefaultEnd(float length){

        return  transform.position + (transform.forward * length);
    }
}
