using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    CharacterController _controller;
    public float _speed = 10f;


    void Awake()
    {
        _controller = GetComponent<CharacterController>();
    }


    void Update()
    {
        CalculateMovement();
    }

    void CalculateMovement()
    {

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontalInput, 0, verticalInput);

        transform.Translate(direction * _speed * Time.deltaTime);

    }

}
