using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainScript : MonoBehaviour
{
    //JAUGE
    public int jauge_value;
    public int jauge_max;
    public Image ImageLife;

    //TEXTE
    [SerializeField] TextCharacter _TextCharacter;

    //CHANGEMENT SPRITES

    //Tete
    public SpriteRenderer _head;
    public Sprite[] HeadspriteArray;
    int head_number = 0;
    //Body
    public SpriteRenderer _body;
    public Sprite[] BodyspriteArray;
    int body_number = 0;
    //Weapon
    public SpriteRenderer _rightarm;
    public Sprite[] RightarmspriteArray;
    public SpriteRenderer _leftarm;
    public Sprite[] LeftarmspriteArray;
    int weapon_number = 0;
    //Legs
    public SpriteRenderer _leftleg;
    public SpriteRenderer _rightleg;
    public Sprite[] LeftlegspriteArray;
    public Sprite[] RightlegspriteArray;
    int legs_number = 0;

    public void Change_head_right()
    {
        if (head_number < 4)
        {
            head_number++;
            jauge_value++;
        }
        if (head_number == 4)
        {
            head_number = 0;
            jauge_value -= 4;
        }
        _head.sprite = HeadspriteArray[head_number];
        Debug.Log("CHANGE HEAD RIGHT");
        Debug.Log(head_number);
    }
    public void Change_head_left()
    {
        if (head_number >= 0)
        {
            head_number--;
            jauge_value --;
        }
        if (head_number == -1)
        {
            head_number = 3;
            jauge_value += 4;
        }
        _head.sprite = HeadspriteArray[head_number];
        Debug.Log("CHANGE HEAD LEFT");
        Debug.Log(head_number);
    }
    public void Change_body_right()
    {
        if (body_number < 4)
        {
            body_number++;
            jauge_value++;
        }
        if (body_number == 4)
        {
            body_number = 0;
            jauge_value -= 4;
        }
        _body.sprite = BodyspriteArray[body_number];
        Debug.Log("CHANGE BODY RIGHT");
        Debug.Log(body_number);
    }
    public void Change_body_left()
    {
        if (body_number >= 0)
        {
            body_number--;
            jauge_value--;
        }
        if (body_number == -1)
        {
            body_number = 3;
            jauge_value += 4;
        }
        _body.sprite = BodyspriteArray[body_number];
        Debug.Log("CHANGE BODY LEFT");
        Debug.Log(body_number);
    }
    public void Change_weapon_right()
    {
        if (weapon_number < 4)
        {
            weapon_number++;
            jauge_value++;
        }
        if (weapon_number == 4)
        {
            weapon_number = 0;
            jauge_value -= 4;
        }
        _rightarm.sprite = RightarmspriteArray[weapon_number];
        _leftarm.sprite = LeftarmspriteArray[weapon_number];
        Debug.Log("CHANGE WEAPON RIGHT");
        Debug.Log(weapon_number);
    }
    public void Change_weapon_left()
    {
        if (weapon_number >= 0)
        {
            weapon_number--;
            jauge_value--;
        }
        if (weapon_number == -1)
        {
            weapon_number = 3;
            jauge_value += 4;
        }
        _rightarm.sprite = RightarmspriteArray[weapon_number];
        _leftarm.sprite = LeftarmspriteArray[weapon_number];
        Debug.Log("CHANGE WEAPON LEFT");
        Debug.Log(weapon_number);
    }
    public void Change_legs_right()
    {
        if (legs_number < 4)
        {
            legs_number++;
            jauge_value++;
        }
        if (legs_number == 4)
        {
            legs_number = 0;
            jauge_value -= 4;
        }
        _rightleg.sprite = RightlegspriteArray[legs_number];
        _leftleg.sprite = LeftlegspriteArray[legs_number];
        Debug.Log("CHANGE LEGS RIGHT");
        Debug.Log(legs_number);
    }
    public void Change_legs_left()
    {
        if (legs_number >= 0)
        {
            legs_number--;
            jauge_value--;
        }
        if (legs_number == -1)
        {
            legs_number = 3;
            jauge_value += 4;
        }
        _rightleg.sprite = RightlegspriteArray[legs_number];
        _leftleg.sprite = LeftlegspriteArray[legs_number];
        Debug.Log("CHANGE LEGS LEFT");
        Debug.Log(legs_number);
    }

    private void Update()
    {
        //jauge
        float percent = (float)jauge_value / (float)jauge_max;
        ImageLife.fillAmount = percent;

        //head
        switch (head_number)
        {
            default:
                break;
            case 0:
                _TextCharacter.txt1 = "vigoureux";
                break;
            case 1:
                _TextCharacter.txt1 = "grand";
                break;
            case 2:
                _TextCharacter.txt1 = "vicieux";
                break;
            case 3:
                _TextCharacter.txt1 = "étrange";
                break;
        }
        //body
        switch (body_number)
        {
            default:
                break;
            case 0:
                _TextCharacter.txt2 = "homme";
                break;
            case 1:
                _TextCharacter.txt2 = "bonhomme";
                break;
            case 2:
                _TextCharacter.txt2 = "mamouth";
                break;
            case 3:
                _TextCharacter.txt2 = "gaillard";
                break;
        }
        //weapon
        switch (weapon_number)
        {
            default:
                break;
            case 0:
                _TextCharacter.txt3 = "velu";
                break;
            case 1:
                _TextCharacter.txt3 = "armé";
                break;
            case 2:
                _TextCharacter.txt3 = "dangereux";
                break;
            case 3:
                _TextCharacter.txt3 = "criminel";
                break;
        }
        //legs
        switch (legs_number)
        {
            default:
                break;
            case 0:
                _TextCharacter.txt4 = "rapide";
                break;
            case 1:
                _TextCharacter.txt4 = "bourré";
                break;
            case 2:
                _TextCharacter.txt4 = "fan de johnny";
                break;
            case 3:
                _TextCharacter.txt4 = "malade";
                break;
        }
    }

}
