using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextCharacter : MonoBehaviour
{
    public TextMeshProUGUI _charatext;
    public string txt1 = "grand";
    public string txt2 = "homme";
    public string txt3 = "odorant";
    public string txt4 = "armé";

    private void Update()
    {
        _charatext.text = ($"{txt1} {txt2} {txt3} et {txt4}");
    }
    
}
