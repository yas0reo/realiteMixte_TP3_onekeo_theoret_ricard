using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scriptcherche_et_trouve : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void jouer()
    {
        SceneManager.LoadScene(2);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("bonjour");
        if (other.tag == "scene_cherche_et_trouve")
        {
            Debug.Log("hi");
            jouer();
        }
    }


}
