using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scripttrouvelaporte : MonoBehaviour
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
        SceneManager.LoadScene(3);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("bonjour");
        if (other.tag == "scene_trouveleportail")
        {
            Debug.Log("hi");
            jouer();
        }
    }


}