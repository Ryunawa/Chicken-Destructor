using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
    public GameObject player;
    public int damage;

    private void Awake()
    {
        player = GameObject.Find("Player");
        damage = 1;
    }
    private void Start()
    {
        //SelfDestroy();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject == player)
        {
            Debug.Log("Hit");
            player.GetComponent<PlayerBehaviour>().TakeDamage(damage);
            Destroy(gameObject);
        }
        Destroy(gameObject, 3);
    }

    /*IEnumerator SelfDestroy()
    {
        float duration = 3f;
        float totalTime = 0;

        if (totalTime <= duration)
        {
            Destroy(gameObject);

            yield return null;
        }
    }*/
}
