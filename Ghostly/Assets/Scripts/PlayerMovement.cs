using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Animator acPlayer;

    public float moveSpeed = 10f;
    public float rotationSpeed = 100f;
    
    // Update is called once per frame
    void Update()
    {
        // Animación flotadora o Idle sino
        if (Input.GetKey(KeyCode.UpArrow))
        {
            acPlayer.SetBool("Moving", true);
        }
        else
        {
            acPlayer.SetBool("Moving", false);
        }

        //Movimiento en el espacio
        float move = Input.GetAxis("Vertical");
        float rotation = Input.GetAxis("Horizontal");

        transform.position += transform.forward * moveSpeed * move * Time.deltaTime;
        transform.Rotate(Vector3.up, rotationSpeed * rotation * Time.deltaTime);
    }
}
