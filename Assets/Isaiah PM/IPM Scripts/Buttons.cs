using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Game1()
    {
         SceneManager.LoadScene("Example1");
    }
    public void Game2()
    {
         SceneManager.LoadScene("Example2");
    }
    public void IsaiahPM() //This is just for development use.
    {
         SceneManager.LoadScene("Isaiah PM");
    }
}
