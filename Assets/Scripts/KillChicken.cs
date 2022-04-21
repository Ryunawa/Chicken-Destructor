using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillChicken : MonoBehaviour
{
    public GameObject gameManager;
    public GameObject dummy;
    public float radius;

    private void Awake()
    {
        gameManager = GameObject.Find("GameManager");
        dummy = GameObject.Find("Dummy");
        radius = Shader.GetGlobalFloat("_FirstCircleRadius");
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Chicken") && Input.GetMouseButtonDown(0))
        {
            gameManager.GetComponent<VictoryDefeat>().DecrementChicken();
            radius = Shader.GetGlobalFloat("_FirstCircleRadius");
            radius += 0.5f;
            Shader.SetGlobalFloat("_FirstCircleRadius", radius);
            Destroy(other.gameObject, 0.2f);
        }

        if (other.CompareTag("Dummy") && Input.GetMouseButtonDown(0))
        {
            dummy.GetComponent<Dummy>().TakeDamage();
        }
    }
}