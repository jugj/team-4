using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject weiterknopf;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void pauseSpiel()
    {
        Time.timeScale = 0;
        weiterknopf.SetActive(true);
    }
}
