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
    public Transform _headpos;
    public SpriteRenderer _head;
    public Sprite[] HeadspriteArray;
    int head_number = 0;
    //Body
    public Transform _bodypos;
    public SpriteRenderer _body;
    public Sprite[] BodyspriteArray;
    int body_number = 0;
    //Weapon
    public Transform _weaponpos;
    public SpriteRenderer _rightarm;
    public Sprite[] RightarmspriteArray;
    public SpriteRenderer _leftarm;
    public Sprite[] LeftarmspriteArray;
    int weapon_number = 0;
    //Legs
    public Transform _legspos;
    public SpriteRenderer _leftleg;
    public SpriteRenderer _rightleg;
    public Sprite[] LeftlegspriteArray;
    public Sprite[] RightlegspriteArray;
    int legs_number = 0;

    //odeur
    public Rigidbody2D _odeur1;

    public void Change_head_right()
    {
        Rigidbody2D clone;
        clone = Instantiate(_odeur1, _headpos.transform.position, _headpos.transform.rotation);

        if (head_number < 5)
        {
            head_number++;
            jauge_value++;
        }
        if (head_number == 5)
        {
            head_number = 0;
            jauge_value -= 5;
        }
        _head.sprite = HeadspriteArray[head_number];
        Debug.Log("CHANGE HEAD RIGHT");
        Debug.Log(head_number);
    }
    public void Change_head_left()
    {
        Rigidbody2D clone;
        clone = Instantiate(_odeur1, _headpos.transform.position, _headpos.transform.rotation);

        if (head_number >= 0)
        {
            head_number--;
            jauge_value --;
        }
        if (head_number == -1)
        {
            head_number = 4;
            jauge_value += 5;
        }
        _head.sprite = HeadspriteArray[head_number];
        Debug.Log("CHANGE HEAD LEFT");
        Debug.Log(head_number);
    }
    public void Change_body_right()
    {
        Rigidbody2D clone;
        clone = Instantiate(_odeur1, _bodypos.transform.position, _bodypos.transform.rotation);
        if (body_number < 5)
        {
            body_number++;
            jauge_value++;
        }
        if (body_number == 5)
        {
            body_number = 0;
            jauge_value -= 5;
        }
        _body.sprite = BodyspriteArray[body_number];
        Debug.Log("CHANGE BODY RIGHT");
        Debug.Log(body_number);
    }
    public void Change_body_left()
    {
        Rigidbody2D clone;
        clone = Instantiate(_odeur1, _bodypos.transform.position, _bodypos.transform.rotation);
        if (body_number >= 0)
        {
            body_number--;
            jauge_value--;
        }
        if (body_number == -1)
        {
            body_number = 4;
            jauge_value += 5;
        }
        _body.sprite = BodyspriteArray[body_number];
        Debug.Log("CHANGE BODY LEFT");
        Debug.Log(body_number);
    }
    public void Change_weapon_right()
    {
        Rigidbody2D clone;
        clone = Instantiate(_odeur1, _weaponpos.transform.position, _weaponpos.transform.rotation);
        if (weapon_number < 5)
        {
            weapon_number++;
            jauge_value++;
        }
        if (weapon_number == 5)
        {
            weapon_number = 0;
            jauge_value -= 5;
        }
        _rightarm.sprite = RightarmspriteArray[weapon_number];
        _leftarm.sprite = LeftarmspriteArray[weapon_number];
        Debug.Log("CHANGE WEAPON RIGHT");
        Debug.Log(weapon_number);
    }
    public void Change_weapon_left()
    {
        Rigidbody2D clone;
        clone = Instantiate(_odeur1, _weaponpos.transform.position, _weaponpos.transform.rotation);
        if (weapon_number >= 0)
        {
            weapon_number--;
            jauge_value--;
        }
        if (weapon_number == -1)
        {
            weapon_number = 4;
            jauge_value += 5;
        }
        _rightarm.sprite = RightarmspriteArray[weapon_number];
        _leftarm.sprite = LeftarmspriteArray[weapon_number];
        Debug.Log("CHANGE WEAPON LEFT");
        Debug.Log(weapon_number);
    }
    public void Change_legs_right()
    {
        Rigidbody2D clone;
        clone = Instantiate(_odeur1, _legspos.transform.position, _legspos.transform.rotation);
        if (legs_number < 5)
        {
            legs_number++;
            jauge_value++;
        }
        if (legs_number == 5)
        {
            legs_number = 0;
            jauge_value -= 5;
        }
        _rightleg.sprite = RightlegspriteArray[legs_number];
        _leftleg.sprite = LeftlegspriteArray[legs_number];
        Debug.Log("CHANGE LEGS RIGHT");
        Debug.Log(legs_number);
    }
    public void Change_legs_left()
    {
        Rigidbody2D clone;
        clone = Instantiate(_odeur1, _legspos.transform.position, _legspos.transform.rotation);
        if (legs_number >= 0)
        {
            legs_number--;
            jauge_value--;
        }
        if (legs_number == -1)
        {
            legs_number = 4;
            jauge_value += 5;
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
                _TextCharacter.txt1 = "Le chauve";
                break;
            case 1:
                _TextCharacter.txt1 = "Le cow-boy";
                break;
            case 2:
                _TextCharacter.txt1 = "L'hipster";
                break;
            case 3:
                _TextCharacter.txt1 = "Le perchoir";
                break;
            case 4:
                _TextCharacter.txt1 = "Le geek";
                break;
        }
        //body
        switch (body_number)
        {
            default:
                break;
            case 0:
                _TextCharacter.txt2 = "nudiste";
                break;
            case 1:
                _TextCharacter.txt2 = "fan de Johnny";
                break;
            case 2:
                _TextCharacter.txt2 = "couturier";
                break;
            case 3:
                _TextCharacter.txt2 = "un peu beau gosse";
                break;
            case 4:
                _TextCharacter.txt2 = "ancien streamer";
                break;
        }
        //weapon
        switch (weapon_number)
        {
            default:
                break;
            case 0:
                _TextCharacter.txt3 = "aux mains sales";
                break;
            case 1:
                _TextCharacter.txt3 = "imitant le Captain";
                break;
            case 2:
                _TextCharacter.txt3 = "guitariste";
                break;
            case 3:
                _TextCharacter.txt3 = "eleveur de rats";
                break;
            case 4:
                _TextCharacter.txt3 = "squatteur de bar";
                break;
        }
        //legs
        switch (legs_number)
        {
            default:
                break;
            case 0:
                _TextCharacter.txt4 = "dans son slip";
                break;
            case 1:
                _TextCharacter.txt4 = "qui sent la fatigue";
                break;
            case 2:
                _TextCharacter.txt4 = "poilu";
                break;
            case 3:
                _TextCharacter.txt4 = "mal fringuer";
                break;
            case 4:
                _TextCharacter.txt4 = "couvert de sueur";
                break;
        }
    }

    public void RandomizePuant()
    {
        int rnd = Random.Range(0, 2);
        Debug.Log(rnd);
        Debug.Log("RANDOM");
        if (rnd == 0)
        {
            Change_head_left();
            Change_body_right();
            Change_weapon_left();
            Change_legs_right();
        }
        if (rnd == 1)
        {
            Change_head_right();
            Change_body_left();
            Change_weapon_right();
            Change_legs_right();
        }
        if (rnd == 1)
        {
            Change_head_right();
            Change_body_right();
            Change_weapon_left();
            Change_legs_left();
        }
    }

}
