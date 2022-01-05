using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateLight : MonoBehaviour
{
    public Animator lightt;
    public Animator littleBoy;
    public Animator player;
    
    
    private void OnTriggerEnter(Collider p) { 

    if (p.tag == "Player")
    {
        lightt.SetBool("Susto", true);
            littleBoy.SetBool("Susto", true);
                player.SetBool("Asustando", true);
    }

    }


    private void OnTriggerExit(Collider p) { 

    if (p.tag == "Player")
    {
        lightt.SetBool("Susto", false);
            littleBoy.SetBool("Susto", false);
                player.SetBool("Asustando", false);
        }

    }
}
