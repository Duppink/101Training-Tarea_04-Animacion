using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateBall : MonoBehaviour
{
    public Animator ball;
    public Animator grandMa;


    private void OnTriggerEnter(Collider p)
    {

        if (p.tag == "Player")
        {
            ball.SetBool("Susto", true);
            grandMa.SetBool("Susto", true);
        }

    }


    private void OnTriggerExit(Collider p)
    {

        if (p.tag == "Player")
        {
            ball.SetBool("Susto", false);
            grandMa.SetBool("Susto", false);
        }

    }
}
