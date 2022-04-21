using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
    private GameObject player;
    public int damage;

    private void Awake()
    {
        player = GameObject.Find("Player");
    }
    private void Start()
    {
        damage = 2;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            Debug.Log("Hit");
            player.GetComponent<PlayerBehaviour>().TakeDamage(damage);
            Destroy(gameObject);
        }
        Destroy(gameObject, 3);
    }
}
