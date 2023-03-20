using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonControl : MonoBehaviour
{
    public GameObject BottleText;
    public GameObject BoxText;

    public void BottleUP()
    {
        BottleText.GetComponent<TMPro.TextMeshProUGUI>().text=BottleText.GetComponent<TMPro.TextMeshProUGUI>().text+" "+BoxText.GetComponent<TMP_InputField>().text;
        BoxText.GetComponent<TMP_InputField>().text="";
    }
}
