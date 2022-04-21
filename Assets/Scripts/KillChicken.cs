using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillChicken : MonoBehaviour
{
    public GameObject gameManager;
    public GameObject dummy;

    private void Awake()
    {
        gameManager = GameObject.Find("GameManager");
        dummy = GameObject.Find("Dummy");
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Chicken") && Input.GetMouseButtonDown(0))
        {
            gameManager.GetComponent<VictoryDefeat>().DecrementChicken();
            Destroy(other.gameObject, 0.2f);
        }

        if (other.CompareTag("Dummy") && Input.GetMouseButtonDown(0))
        {
            dummy.GetComponent<Dummy>().TakeDamage();
        }
    }
}
