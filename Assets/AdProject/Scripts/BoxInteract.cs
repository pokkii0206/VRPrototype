using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class BoxInteract : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler
{

    GameObject canvas;
    [SerializeField] private UnityEvent OnClick = new UnityEvent();
    [SerializeField] private UnityEvent OnHover = new UnityEvent();
    void Start(){
       
         DebugUIBuilder.instance.AddLabel("This is Debug UI");
         DebugUIBuilder.instance.Show();
    }

      //Detect if a click occurs
    public void OnPointerClick(PointerEventData pointerEventData)
    {
         DebugUIBuilder.instance.AddLabel("clicked");

        // OnClick.Invoke();
        //Output to console the clicked GameObject's name and the following message. You can replace this with your own actions for when clicking the GameObject.
    }
    //Detect current clicks on the GameObject (the one with the script attached)
    public void OnPointerDown(PointerEventData pointerEventData)
    {
        //Output the name of the GameObject that is being clicked
        //  DebugUIBuilder.instance.AddLabel("click in progress");
    }

    //Detect if clicks are no longer registering
    public void OnPointerUp(PointerEventData pointerEventData)
    {
    //    DebugUIBuilder.instance.AddLabel("no longer being clicked");
    }



     //Detect if the Cursor starts to pass over the GameObject
    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        //Output to console the GameObject's name and the following message
         DebugUIBuilder.instance.AddLabel("pointer entered");
         Debug.Log("Pointer entered");
          OnClick.Invoke();
        //  OnHover.Invoke();
    }

    //Detect when Cursor leaves the GameObject
    public void OnPointerExit(PointerEventData pointerEventData)
    {
        //Output the following message with the GameObject's name
        // DebugUIBuilder.instance.AddLabel("Cursor Exiting ");
    }


   
}
