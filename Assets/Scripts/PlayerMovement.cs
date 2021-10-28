using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public GameObject snorlaxPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }


        if (Input.GetKeyDown(KeyCode.Space))
        {
            spawnSnorlax();
        }




    }

    public void spawnSnorlax()
    {
        GameObject snorlax = Instantiate(snorlaxPrefab, Vector3.zero, Quaternion.identity);
    }

}
