using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackScript : MonoBehaviour
{
    public SpriteRenderer _back;
    public MainScript _scr;

    public Sprite spr1;
    public Sprite spr2;
    public Sprite spr3;
    public Sprite spr4;

    // Update is called once per frame
    void Update()
    {
        if (_scr.jauge_value <= 4)
        {
            _back.sprite = spr1;
        }
        if (_scr.jauge_value <= 8 && _scr.jauge_value > 4)
        {
            _back.sprite = spr2;
        }
        if (_scr.jauge_value <= 12 && _scr.jauge_value > 8)
        {
            _back.sprite = spr3;
        }
        if (_scr.jauge_value <= 16 && _scr.jauge_value > 12)
        {
            _back.sprite = spr4;
        }
    }
}
