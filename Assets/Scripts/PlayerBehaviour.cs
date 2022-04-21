using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public VictoryDefeat VictoryScript;
    private float _maxHealth;
    public float health;

    // Start is called before the first frame update
    private void Start()
    {
        _maxHealth = 100.0f;
        health = _maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        Shader.SetGlobalVector("_PlayerPosition", transform.position);
    }
    
    public void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log("Health reduce");

        if (health <= 0)
        {
            VictoryScript.Defeat();
        }
    }
    
}
