using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ancient_Mystery_2 : MonoBehaviour
{
    private Player player;
    public GameObject islandHead;
    public GameObject buildButton;

    public bool isBuilt = false;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
    }

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            if (!isBuilt)
            {
                buildButton.SetActive(true);
            }
            if (player.isBuilding)
            {
                isBuilt = true;
                islandHead.SetActive(true);
            }
        }
    }
    void OnTriggerExit(Collider other)
    {
        buildButton.SetActive(false);
    }
}
