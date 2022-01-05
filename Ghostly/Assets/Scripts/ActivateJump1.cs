using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateJump1 : MonoBehaviour
{
    public Animator hippie;
    public Animator player;


    private void OnTriggerEnter(Collider p)
    {

        if (p.tag == "Player")
        {
            hippie.SetBool("Susto", true);
            hippie.SetFloat("Saltos", 1);
                player.SetBool("Asustando", true);
        }

    }


    private void OnTriggerExit(Collider p)
    {

        if (p.tag == "Player")
        {
            hippie.SetBool("Susto", false);
                player.SetBool("Asustando", false);
        }

    }
}
