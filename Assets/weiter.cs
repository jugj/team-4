using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weiter : MonoBehaviour
{
    public GameObject weiterknopf;
    // Start is called before the first frame update
    void Start()
    {
        weiterknopf.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
    
    }
    public void wieterSpiel()
    {
        Time.timeScale = 1;
        weiterknopf.SetActive(false);
    }
}
