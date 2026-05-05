using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class script_retour_lobby : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "scene")
        {
            SceneManager.LoadScene("jess");
        }
    }
}