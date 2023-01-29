using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class moveCamera : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void switchScene()
    {
        SceneManager.LoadScene("Main");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
