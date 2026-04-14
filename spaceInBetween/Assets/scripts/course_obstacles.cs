using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class joueur : MonoBehaviour
{
    public deplacementAutomatique deplacementAuto;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "obstacle")
        {
            StartCoroutine("mort");
        }


    }
    public IEnumerator mort()
    {
        deplacementAuto.vitesseAvance = 0;
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("manu_course");
        yield break ;
    }
}

