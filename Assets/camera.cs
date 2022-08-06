using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{

    public float Geschwindigkeit = 4.5f;
    public GameObject Spieler;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position=Spieler.transform.position;
        transform.Translate(new Vector3(0,0,-10));


    }
}
