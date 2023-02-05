using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSignHandler : MonoBehaviour
{

    public GameObject PlayerAttackSign;
    public GameObject EnemyAttackSign;

    public GameObject PlayerThrowkSign;
    public GameObject EnemyThrowSign;

    public GameObject PlayerBlockSign;
    public GameObject EnemyBlockSign;

    public static bool AttackIcon;
    public static bool EnemyAttackIcon;

    public static bool ThrowIcon;
    public static bool EnemyThrowIcon;


    public static bool BlockIcon;
    public static bool EnemyBlockIcon;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (AttackIcon == true)
        {
            PlayerAttackSign.GetComponent<Animation>().Play("MoveSign");
            AttackIcon = false;
        }

        if (ThrowIcon == true)
        {
            PlayerThrowkSign.GetComponent<Animation>().Play("MoveSign");
            ThrowIcon = false;
        }

        if (BlockIcon == true)
        {
            PlayerBlockSign.GetComponent<Animation>().Play("MoveSign");
            BlockIcon = false;
        }

        if (EnemyAttackIcon == true)
        {
            EnemyAttackSign.GetComponent<Animation>().Play("EnemyMoveSign");
            EnemyAttackIcon = false;
        }

        if (EnemyThrowIcon == true)
        {
            EnemyThrowSign.GetComponent<Animation>().Play("EnemyMoveSign");
            EnemyThrowIcon = false;
        }

        if (EnemyBlockIcon == true)
        {
            EnemyBlockSign.GetComponent<Animation>().Play("EnemyMoveSign");
            EnemyBlockIcon = false;
        }

    }
}
