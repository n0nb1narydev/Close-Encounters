using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float _speed = 10f;
    public bool canMove = true;
    public bool isAbducting = false;
    public bool isDrawing = false;
    public bool isBuilding = false;

    public GameObject abductionLight;
    public GameObject drawingLight;
    public GameObject buildLight;



    void Awake()
    {
     
    }


    void Update()
    {
        if(canMove)
        {
            CalculateMovement();
        }
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

    private IEnumerator Drawing()
    {
        isDrawing = true;
        drawingLight.SetActive(true);
        canMove = false;
        yield return new WaitForSeconds(3f);
        canMove = true;
        drawingLight.SetActive(false);
        isDrawing = false;
    }

    public void Draw()
    {
        StartCoroutine(Drawing());
    }

    private IEnumerator Building()
    {
        isBuilding = true;
        canMove = false;
        buildLight.SetActive(true);
        yield return new WaitForSeconds(5f);
        canMove = true;
        buildLight.SetActive(false);
        isBuilding = false;
    }
    public void Build()
    {
        StartCoroutine(Building());
    }
}
