using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationStateController : MonoBehaviour
{
    private Animator anim;

    public float playerSpeed;
    public float time = 0;
    public float prevTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

        StartCoroutine(CalcSpeed());
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
            anim.SetBool("isAttacking", true);
    }

    IEnumerator CalcSpeed()
    {
        bool isPlaying = true;

        while (isPlaying)
        {
            Vector3 prevPos = transform.position;

            yield return new WaitForFixedUpdate();

            playerSpeed = Mathf.RoundToInt(Vector3.Distance(transform.position, prevPos) / Time.fixedDeltaTime);

            if (playerSpeed >= 1)
                anim.SetBool("isWalking", true);
            else
                anim.SetBool("isWalking", false);
            anim.SetFloat("speed", playerSpeed);
        }
    }
    public void EndAttack()
    {
        anim.SetBool("isAttacking", false);
    }
}
