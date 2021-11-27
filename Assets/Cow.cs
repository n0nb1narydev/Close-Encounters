using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cow : MonoBehaviour
{
    public GameObject abductCow;
    public float _speed = 4f;
    public bool isAbducted = false;

    private Player player;


    void Awake()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
    }
    void Update()
    {
        if(isAbducted)
        {
            Vector3 direction = new Vector3(0, 1, 0);
            // move this object up to ship then delete
            this.transform.Translate(direction * _speed * Time.deltaTime);
            if(transform.position.y >= 71.3f)
            {
                player.canMove = true;
                isAbducted = false;
                Destroy(this.gameObject);
            }
        }
    }

    void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player")
        {
            abductCow.SetActive(true);
            if(player.isAbducting)
            {
                abductCow.SetActive(false);
                isAbducted = true;
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        abductCow.SetActive(false);
    }

}
