using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class recommencer : MonoBehaviour
{
   

    public void Reset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Lobby()
    {
        SceneManager.LoadScene("jess");
    }
}
