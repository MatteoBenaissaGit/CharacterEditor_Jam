using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyScript : MonoBehaviour
{

    public bool can_be_destroyed = false;

    
    private void Update()
    {
        if (transform.position.x < 5)
        {
            can_be_destroyed = true;
        }
    }
    public void Destroy_animation()
    {
        if (can_be_destroyed == true)
        {
            Destroy(gameObject);
        }
        
    }
}
