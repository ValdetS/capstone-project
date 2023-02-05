using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationHandler : MonoBehaviour
{

    public Animator animator;
    public static bool PlayerAttackAnimState;
    public static bool PlayerBlockAnimState;
    public static bool PlayerLoseAnimState;

    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerAttackAnimState == true && GlobalHealth.PlayerHealthPoints >= 0)
        {
            animator.SetBool("PlayerAttacks", true);
            Player.GetComponent<Animation>().Play("PlayerMove");

            StartCoroutine(AnimOff());

            IEnumerator AnimOff()
            {
                yield return new WaitForSeconds(1);
                PlayerAttackAnimState = false;
                animator.SetBool("PlayerAttacks", false);

            }

        }

        if (PlayerBlockAnimState == true && GlobalHealth.PlayerHealthPoints >= 0)
        {
            animator.SetBool("PlayerBlocks", true);
            Player.GetComponent<Animation>().Play("PlayerMove");

            StartCoroutine(AnimOff());

            IEnumerator AnimOff()
            {
                yield return new WaitForSeconds(1);
                PlayerBlockAnimState = false;
                animator.SetBool("PlayerBlocks", false);

            }

        }

    }
}
