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

    public GameObject the_bottle;
    public GameObject the_cracked_bottle;
    public GameObject Canvas_of_bottle;

    private TMPro.TextMeshProUGUI _bobtext;
    private TMP_InputField _poptext;
    private void Start() 
    {
        _poptext=BoxText1.GetComponent<TMP_InputField>();
        _poptext.onValueChanged.AddListener (delegate {ValueChangeCheck ();});
    }

    public void MoveBottle()
    {
        foreach (Transform child in Parent_forletter.transform)
        {
            GameObject.Destroy(child.gameObject);
        }
        the_bottle.transform.position += new Vector3(10, 0, 0);
    }

    public void ValueChangeCheck()
    {
        if(_poptext.text.Length>20 && _poptext.text[0]!=' ' && the_bottle.transform.position==new Vector3(0f,1.75f,-4f))
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

    IEnumerator waitCoroutine()
    {
        print(Time.time);
        yield return new WaitForSecondsRealtime(5);
        print(Time.time);
    }

    void Update()
    {
        if(rez>50)
        {
            rez=0;
            GameObject breaked_bottle;
            Vector3 pozitie_bottle=the_bottle.transform.position;
            breaked_bottle = Instantiate(the_cracked_bottle,pozitie_bottle, Quaternion.identity);
            the_bottle.transform.position += new Vector3(-10, 0, 0);
            Canvas_of_bottle.transform.SetParent(breaked_bottle.transform);
            breaked_bottle.SetActive(true);
            StartCoroutine(waitCoroutine());
            foreach (Transform child in Parent_forletter.transform)
            {
                GameObject.Destroy(child.gameObject);
            }
            Canvas_of_bottle.transform.SetParent(the_bottle.transform);
            Destroy(breaked_bottle,3);
            //the_bottle.transform.position += new Vector3(5, 0, 0);
        }
    }
}
