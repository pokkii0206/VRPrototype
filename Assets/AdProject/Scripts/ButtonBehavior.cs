using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonBehavior : MonoBehaviour,IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler,  IPointerUpHandler, IPointerClickHandler
{

    [SerializeField] private UnityEvent OnClick = new UnityEvent();


      //Detect if a click occurs
    public void OnPointerClick(PointerEventData pointerEventData)
    {
        // OnClick.Invoke();
    }

    public void OnPointerDown(PointerEventData pointerEventData)
    {

         DebugUIBuilder.instance.AddLabel("click in progress");
    }


    public void OnPointerUp(PointerEventData pointerEventData)
    {
       DebugUIBuilder.instance.AddLabel("no longer being clicked");
    }


    public void OnPointerEnter(PointerEventData pointerEventData)
    {

      DebugUIBuilder.instance.AddLabel("Button Cursor Enter ");
    }


    public void OnPointerExit(PointerEventData pointerEventData)
    {
        DebugUIBuilder.instance.AddLabel("Cursor Exiting ");
    }

    public void OpneLink(){
        Application.OpenURL("https://www.oculus.com/experiences/rift/1304877726278670/?locale=en_US");
        DebugUIBuilder.instance.AddLabel("opened url");
    }

}
