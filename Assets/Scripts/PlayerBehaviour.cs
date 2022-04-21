using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public VictoryDefeat VictoryScript;
    public GameObject gameUI;
    private float _maxHealth;
    public float health;

    private void Awake()
    {
        gameUI = GameObject.Find("GameInterface");
    }

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
        gameUI.GetComponent<GameUI>().SetHealthBar(health);

        if (health <= 0)
        {
            VictoryScript.Defeat();
        }
    }
    
}
