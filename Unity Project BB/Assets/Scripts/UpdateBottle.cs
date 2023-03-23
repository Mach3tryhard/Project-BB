using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UpdateBottle : MonoBehaviour
{
    int rez=0;
    public GameObject BoxText1;
    public GameObject Letter;
    public GameObject Parent_forletter;
    private TMPro.TextMeshProUGUI _bobtext;
    private TMP_InputField _poptext;
    private void Start() 
    {
        _poptext=BoxText1.GetComponent<TMP_InputField>();
        _poptext.onValueChanged.AddListener (delegate {ValueChangeCheck ();});
    }

    public void ValueChangeCheck()
    {
        if(_poptext.text.Length>20 && _poptext.text[0]!=' ')
        {
            string caca;
            caca=_poptext.text;
            caca=caca.Remove(0,1);
            rez++;
            GameObject newletter;
            newletter = Instantiate(Letter, new Vector3(0.0f,2.75f,-3.8f), Quaternion.identity,Parent_forletter.transform);
            newletter.SetActive(true);
            newletter.transform.Find("TextLetter").GetComponent<TMPro.TextMeshProUGUI>().text=""+_poptext.text[0];
            _poptext.text=caca;
        }
        else if(_poptext.text.Length>20)
        {
            string caca;
            caca=_poptext.text;
            caca=caca.Remove(0,1);
            _poptext.text=caca;
        }
        
    }

    void Update()
    {
        if(rez==1250)
        {
            foreach (Transform child in Parent_forletter.transform)
            {
                GameObject.Destroy(child.gameObject);
            }
        }
    }
}
