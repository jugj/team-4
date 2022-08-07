using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class reset : MonoBehaviour
{
    public string resetbuton;
    public GameObject resetbutton;
    // Start is called before the first frame update
    void Start()
    {
        resetbutton.SetActive(false);   
    }

    // Update is called once per frame
   

    public void start()
    {
        SceneManager.LoadScene(resetbuton);
        Time.timeScale = 1;
    }
}
