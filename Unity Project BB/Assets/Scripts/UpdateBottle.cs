using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UpdateBottle : MonoBehaviour
{
    public GameObject BoxText1;
    public GameObject Letter;
    public GameObject Canvas_forletter;
    private TMPro.TextMeshProUGUI _bobtext;
    private TMP_InputField _poptext;
    private void Start() 
    {
        _poptext=BoxText1.GetComponent<TMP_InputField>();
        _poptext.onValueChanged.AddListener (delegate {ValueChangeCheck ();});
    }

    public void ValueChangeCheck()
    {
        if(_poptext.text.Length>2)
        {
            string caca;
            caca=_poptext.text;
            caca=caca.Remove(0,1);
            GameObject newletter;
            newletter = Instantiate(Letter, new Vector3(0.0f,2.25f,-3.8f), Quaternion.identity,Canvas_forletter.transform);
            newletter.SetActive(true);
            newletter.transform.Find("TextLetter").GetComponent<TMPro.TextMeshProUGUI>().text=""+_poptext.text[0];
            _poptext.text=caca;
        }
    }
}
