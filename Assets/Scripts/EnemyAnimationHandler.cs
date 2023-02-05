using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimationHandler : MonoBehaviour
{

    public Animator animator;
    public static bool EnemyAttackAnimState;
    public static bool EnemyBlockAnimState;

    public GameObject Enemy;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (EnemyAttackAnimState == true && GlobalHealth.EnemyHealthPoints >= 0)
        {
            animator.SetBool("EnemyAttacks", true);
            Enemy.GetComponent<Animation>().Play("EnemyMove");

            StartCoroutine(AnimOff());

            IEnumerator AnimOff()
            {
                yield return new WaitForSeconds(1);
                EnemyAttackAnimState = false;
                animator.SetBool("EnemyAttacks", false);

            }

        }

        if (EnemyBlockAnimState == true && GlobalHealth.EnemyHealthPoints >= 0)
        {
            animator.SetBool("EnemyBlocks", true);
            Enemy.GetComponent<Animation>().Play("EnemyMove");

            StartCoroutine(AnimOff());

            IEnumerator AnimOff()
            {
                yield return new WaitForSeconds(1);
                EnemyBlockAnimState = false;
                animator.SetBool("EnemyBlocks", false);

            }

        }

    }
}
