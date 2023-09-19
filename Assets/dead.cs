using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dead : MonoBehaviour
{

public void LoadMainLevel()
{
    // No cursor while playing
    Cursor.lockState = CursorLockMode.Locked;
    Cursor.visible = false;
    // Load scene
    SceneManager.LoadScene("Level1");
}

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}