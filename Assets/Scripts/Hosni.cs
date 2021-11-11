using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hosni : MonoBehaviour
{
    public GameObject HosniPreFab;
    public SpriteRenderer BeardRenderer;
    public SpriteRenderer HairRenderer;
    public SpriteRenderer FaceRenderer;

    // Start is called before the first frame update
    void Start()
    {
        HosniPreFab = GameObject.Find("Hosni");
        BeardRenderer = HosniPreFab.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>();
        HairRenderer = HosniPreFab.transform.GetChild(1).gameObject.GetComponent<SpriteRenderer>();
        FaceRenderer = HosniPreFab.transform.GetChild(2).gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeColor()
    {
        BeardRenderer.color = new Color(205, 0, 255);
        HairRenderer.color = new Color(0, 100, 40);
        FaceRenderer.color = new Color(0, 120, 30);
    }
}
