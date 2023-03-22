using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UpdateBottle : MonoBehaviour
{
    public GameObject BottleText1;
    public GameObject BoxText1;
    private TMPro.TextMeshProUGUI _bobtext;
    private TMP_InputField _poptext;
    private void Start() 
    {
        _bobtext=BottleText1.GetComponent<TMPro.TextMeshProUGUI>();
        _poptext=BoxText1.GetComponent<TMP_InputField>();
        _poptext.onValueChanged.AddListener (delegate {ValueChangeCheck ();});
    }

    public void ValueChangeCheck()
    {
        if(_poptext.text.Length>25)
        {
            string caca;
            caca=_poptext.text;
            caca=caca.Remove(0,1);
            _bobtext.text=_bobtext.text+_poptext.text[0];
            _poptext.text=caca;
            //BottleText1.GetComponent<TMP_InputField>().text=_bobtext;
            //BoxText1.GetComponent<TMP_InputField>().text=_poptext;
        }
    }

}
