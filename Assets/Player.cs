using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float _speed = 10f;
    public bool canMove = true;
    public bool isAbducting = false;

    public GameObject abductionLight;



    void Awake()
    {
     
    }


    void Update()
    {
        if(canMove)
        {
            CalculateMovement();
        }
        //if(isAbducting)
        //{
        //    StartCoroutine(Abducting());
        //}
    }

    void CalculateMovement()
    {

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontalInput, 0, verticalInput);

        transform.Translate(direction * _speed * Time.deltaTime);

    }

    private IEnumerator Abducting()
    {
        abductionLight.SetActive(true);
        yield return new WaitForSeconds(13f);
        canMove = true;
        abductionLight.SetActive(false);
        isAbducting = false;
    }

    public void Abduct()
    {
        StartCoroutine(Abducting());
        print("button pressed");
        isAbducting = true;
        canMove = false;
    }

}
