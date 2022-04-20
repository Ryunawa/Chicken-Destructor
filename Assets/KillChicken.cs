using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillChicken : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        if (!other.CompareTag("Chicken"))
            return;

        if (Input.GetMouseButtonDown(0))
        {
            Destroy(other.gameObject, 0.2f);
        }
        Debug.Log("OK !");
    }
}
