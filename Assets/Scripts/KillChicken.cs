using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillChicken : MonoBehaviour
{
    public VictoryDefeat VictoryScript;
    
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Chicken") && Input.GetMouseButtonDown(0))
        {
            Destroy(other.gameObject, 0.2f);
            Debug.Log(VictoryScript.ChickenRemaining);
            
            VictoryScript.DecrementChicken();
        }
    }
}
