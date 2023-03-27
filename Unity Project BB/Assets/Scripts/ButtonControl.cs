using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonControl : MonoBehaviour
{
    public GameObject script_holder;
    public GameObject BottleText;
    public GameObject BoxText;

    public void BottleUP()
    {
        script_holder.GetComponent<UpdateBottle>().MoveBottle();
        BoxText.GetComponent<TMP_InputField>().text="";
    }
}
