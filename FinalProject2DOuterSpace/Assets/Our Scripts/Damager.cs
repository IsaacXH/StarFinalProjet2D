using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damager : MonoBehaviour

{
    public PlayerController bS;
    private Animation anim;
     void Start()
    {
        anim = gameObject.GetComponent<Animation>();
    }
    void OnTriggerEnter2D(Collider2D other)

    
    {
        PlayerController controller = other.GetComponent<PlayerController>();

        if (controller != null)
        {
            controller.ChangeHealth(-1);
           
            anim.Play("Boom");
            
        }
        Destroy(gameObject);
    }
}

