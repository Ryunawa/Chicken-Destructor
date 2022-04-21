using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dummy : MonoBehaviour
{

    private float maxHealth;
    public float health;

    // Start is called before the first frame update
    void Start()
    {
        maxHealth = 100;
        health = maxHealth;
    }

    public void TakeDamage()
    {
        if (!GetComponent<Animator>().GetBool("Hurt")) GetComponent<Animator>().SetBool("Hurt", true);
        else GetComponent<Animator>().SetBool("IsDead", true);
    }
}