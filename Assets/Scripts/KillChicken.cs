using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillChicken : MonoBehaviour
{
    public GameObject gameManager;
    public GameObject dummy;
    public GameObject[] enemies;
    public float radius;


    private void Awake()
    {
        gameManager = GameObject.Find("GameManager");
        dummy = GameObject.Find("Dummy");
        enemies = GameObject.FindGameObjectsWithTag("Chicken");
        radius = Shader.GetGlobalFloat("_FirstCircleRadius");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Chicken"))
        {
            other.GetComponent<Ennemi>()._isInRange = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Chicken"))
        {
            other.GetComponent<Ennemi>()._isInRange = false;
        }
    }

    private void Update()
    {
        foreach (var enemy in enemies)
        {
            if (Input.GetMouseButtonUp(0) && enemy.GetComponent<Ennemi>()._isInRange == true)
            {
                Destroy(enemy.gameObject, 0.2f);
                enemy.GetComponent<Ennemi>()._isInRange = false;

                gameManager.GetComponent<VictoryDefeat>().DecrementChicken();

                radius = Shader.GetGlobalFloat("_FirstCircleRadius");
                radius += 0.5f;
                Shader.SetGlobalFloat("_FirstCircleRadius", radius);
            }
            enemies = GameObject.FindGameObjectsWithTag("Chicken");
        }

        if (dummy.CompareTag("Dummy") && Input.GetMouseButtonDown(0))
        {
            dummy.GetComponent<Dummy>().TakeDamage();
        }
    }
}