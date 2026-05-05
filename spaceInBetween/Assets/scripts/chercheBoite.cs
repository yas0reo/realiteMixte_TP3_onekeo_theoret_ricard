
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boite : MonoBehaviour
{
    public int count;
    public HighScorePersistant pointage;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "bouteille")
        {
            other.gameObject.SetActive(false);
            count++;
            pointage.OnChangerPointage(count);
        }
    }
}




