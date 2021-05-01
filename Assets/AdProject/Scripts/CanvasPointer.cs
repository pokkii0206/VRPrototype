using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

//inputModule.mouseをtransform.positionに変更してみた

public class CanvasPointer : MonoBehaviour
{
    public float defaultlength = 3.0f;
    private LineRenderer lineRenderer = null;
    public EventSystem eventSystem = null;
    // public StandaloneInputModule inputModule = null;


    private void Awake(){
        lineRenderer = GetComponent<LineRenderer>();
    }

    void Update()
    {
       
        lineRenderer.SetPosition(0, transform.position);
        lineRenderer.SetPosition(1, GetEnd());
    }

    private Vector3 GetEnd(){
        float distance = GetCanvasDistance();
        Vector3 endPosition = CalculateEnd(defaultlength);

        if(distance != 0.0f){
            endPosition = CalculateEnd(distance);
        }

        return endPosition;
    }

    private float GetCanvasDistance(){
        //Get Data
        PointerEventData eventData = new PointerEventData(eventSystem);
        eventData.position = transform.position;

        //Raycast using data
         List<RaycastResult> results = new List<RaycastResult>();
         eventSystem.RaycastAll(eventData, results);

        //Get closest
        RaycastResult closestResult = FindFirstRaycast(results);
        float distance = closestResult.distance;

        //Clamp
        distance = Mathf.Clamp(distance, 0.0f, defaultlength);
        return distance;

  
    }

    private RaycastResult FindFirstRaycast(List<RaycastResult> results){

        foreach(RaycastResult result in results){
            if(!result.gameObject){
                continue;
            }
            return result;
        }
        return new RaycastResult();
    }

    private Vector3 CalculateEnd(float length){

        return  transform.position + (transform.forward * length);
    }
}
