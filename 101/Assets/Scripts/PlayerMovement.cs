using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{


    [SerializeField] private float moveSpeed;


    void Update()
    {
        Movement();
    }


    void Movement()
    {
        float xValue = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float zValue = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        transform.Translate(xValue, 0, zValue);
    }

    void Jump()
    {

    }
}
