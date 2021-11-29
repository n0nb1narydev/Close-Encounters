using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clouds : MonoBehaviour
{
    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
        if (transform.position.z > 550f)
        {
            float randomX = Random.Range(-180f, 810f);
            transform.position = new Vector3(randomX, 78f, -727);
        }
    }
}
