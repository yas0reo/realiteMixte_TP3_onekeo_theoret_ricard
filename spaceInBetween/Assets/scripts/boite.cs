
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boite : MonoBehaviour
{
    public int count = 0;
    public HighScorePersistant pointage;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("bouteille"))
        {
            count++;
            pointage.OnChangerPointage(count);

            // Optionnel : désactiver la bouteille après qu'elle soit comptée
            other.gameObject.SetActive(false);
        }
    }
}




