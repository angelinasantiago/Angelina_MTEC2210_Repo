using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float jumpheight;
    public GameObject snorlaxPrefab;
    public Sprite originalSprite;
    public Sprite secondSprite;
    private SpriteRenderer sr;
    private Rigidbody2D rb; 
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
            sr.sprite = originalSprite;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
            sr.sprite = originalSprite;
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, speed * Time.deltaTime, 0);
            sr.sprite = secondSprite;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, -speed * Time.deltaTime, 0);
            sr.sprite = secondSprite;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * jumpheight);
            sr.sprite = secondSprite;
        }

        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            spawnSnorlax();
        }*/



    }

    public void spawnSnorlax()
    {
        GameObject snorlax = Instantiate(snorlaxPrefab, Vector3.zero, Quaternion.identity);
    }

}
