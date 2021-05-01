using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.UI;

public class GrabScript : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 start_positions;
    DebugUIScript debug_ui_script;
    public SHScript sh_script;
    public bool isgrabbed = false;

    void Start()
    {

        start_positions = transform.position;

        //手を離した時、
       //もしオブジェクトの位置が初期位置でなかったら
       //オブジェクトを初期位置に戻す
    }

    // Update is called once per frame
    void Update()
    {
        
        if(OVRInput.GetUp(OVRInput.RawButton.RHandTrigger)) {
            if((transform.position - start_positions).magnitude > 0.5f){
                isgrabbed = true;
               sh_script.Hide();
               transform.position = start_positions;
               sh_script.Show();
            }
        } 


    }

    // public void OnPointerEnter(){
    //     DebugUIBuilder.instance.AddLabel("OnPointerEnter was called");
    // }

    
}
