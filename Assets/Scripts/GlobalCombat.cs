using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalCombat : MonoBehaviour
{
    // The player move signs
    public GameObject PlayerSign;
    public GameObject EnemySign;

    // Booleans for what move player is making
    public static bool isPlayerAttacking = false;
    public static bool isPlayerThrowing = false;
    public static bool isPlayerBlocking = false;

    public static bool isEnemyAttacking = false;
    public static bool isEnemyThrowing = false;
    public static bool isEnemyBlocking = false;

    // Boolean to lnow if player has made their move selection
    public static bool isPlayerReady = false;

    public static void FightPhase1()
    {
        Debug.Log("Phase 1:");
        if (PlayerInputs.FirstMove == PlayerInputs.AttackId)
        {
            isPlayerAttacking = true;
            MoveSignHandler.AttackIcon = true;
            PlayerAnimationHandler.PlayerAttackAnimState = true;
        }
        else if (PlayerInputs.FirstMove == PlayerInputs.ThrowId)
        {
            isPlayerThrowing = true;
            MoveSignHandler.ThrowIcon = true;
            PlayerAnimationHandler.PlayerAttackAnimState = true;

        }
        else if(PlayerInputs.FirstMove == PlayerInputs.BlockId)
        {
            isPlayerBlocking = true;
            MoveSignHandler.BlockIcon = true;
            PlayerAnimationHandler.PlayerBlockAnimState = true;

        }
    
        if (EnemyInputs.EnemyFirstMove == PlayerInputs.AttackId)
        {
            isEnemyAttacking = true;
            MoveSignHandler.EnemyAttackIcon = true;
            EnemyAnimationHandler.EnemyAttackAnimState = true;
        }
        else if (EnemyInputs.EnemyFirstMove == PlayerInputs.ThrowId)
        {
            isEnemyThrowing = true;
            MoveSignHandler.EnemyThrowIcon = true;
            EnemyAnimationHandler.EnemyAttackAnimState = true;

        }
        else if(EnemyInputs.EnemyFirstMove == PlayerInputs.BlockId)
        {
            isEnemyBlocking = true;
            MoveSignHandler.EnemyBlockIcon = true;
            EnemyAnimationHandler.EnemyBlockAnimState = true;
        }

        GlobalDamage.DamageCalculator();

        isPlayerAttacking = false;
        isPlayerThrowing = false;
        isPlayerBlocking = false;

        isEnemyAttacking = false;
        isEnemyThrowing = false;
        isEnemyBlocking = false;
    }

    public static void FightPhase2()
    {
        Debug.Log("Phase 2:");
        if (PlayerInputs.SecondMove == PlayerInputs.AttackId)
        {
            isPlayerAttacking = true;
            MoveSignHandler.AttackIcon = true;
            PlayerAnimationHandler.PlayerAttackAnimState = true;

        }
        else if (PlayerInputs.SecondMove == PlayerInputs.ThrowId)
        {
            isPlayerThrowing = true;
            MoveSignHandler.ThrowIcon = true;
            PlayerAnimationHandler.PlayerAttackAnimState = true;
        }
        else if(PlayerInputs.SecondMove == PlayerInputs.BlockId)
        {
            isPlayerBlocking = true;
            MoveSignHandler.BlockIcon = true;
            PlayerAnimationHandler.PlayerBlockAnimState = true;
        }
    
        if (EnemyInputs.EnemySecondMove == PlayerInputs.AttackId)
        {
            isEnemyAttacking = true;
            MoveSignHandler.EnemyAttackIcon = true;
            EnemyAnimationHandler.EnemyAttackAnimState = true;
        }
        else if (EnemyInputs.EnemySecondMove == PlayerInputs.ThrowId)
        {
            isEnemyThrowing = true;
            MoveSignHandler.EnemyThrowIcon = true;
            EnemyAnimationHandler.EnemyAttackAnimState = true;
        }
        else if(EnemyInputs.EnemySecondMove == PlayerInputs.BlockId)
        {
            isEnemyBlocking = true;
            MoveSignHandler.EnemyBlockIcon = true;
            EnemyAnimationHandler.EnemyBlockAnimState = true;
        }

        GlobalDamage.DamageCalculator();

        isPlayerAttacking = false;
        isPlayerThrowing = false;
        isPlayerBlocking = false;

        isEnemyAttacking = false;
        isEnemyThrowing = false;
        isEnemyBlocking = false;
    }

    public static void FightPhase3()
    {
        Debug.Log("Phase 3:");
        if (PlayerInputs.ThirdMove == PlayerInputs.AttackId)
        {
            isPlayerAttacking = true;
            MoveSignHandler.AttackIcon = true;
            PlayerAnimationHandler.PlayerAttackAnimState = true;
        }
        else if (PlayerInputs.ThirdMove == PlayerInputs.ThrowId)
        {
            isPlayerThrowing = true;
            MoveSignHandler.ThrowIcon = true;
            PlayerAnimationHandler.PlayerAttackAnimState = true;
        }
        else if(PlayerInputs.ThirdMove == PlayerInputs.BlockId)
        {
            isPlayerBlocking = true;
            MoveSignHandler.BlockIcon = true;
            PlayerAnimationHandler.PlayerBlockAnimState = true;
        }
    
        if (EnemyInputs.EnemyThirdMove == PlayerInputs.AttackId)
        {
            isEnemyAttacking = true;
            MoveSignHandler.EnemyAttackIcon = true;
            EnemyAnimationHandler.EnemyAttackAnimState = true;

        }
        else if (EnemyInputs.EnemyThirdMove == PlayerInputs.ThrowId)
        {
            isEnemyThrowing = true;
            MoveSignHandler.EnemyThrowIcon = true;
            EnemyAnimationHandler.EnemyAttackAnimState = true;
        }
        else if(EnemyInputs.EnemyThirdMove == PlayerInputs.BlockId)
        {
            isEnemyBlocking = true;
            MoveSignHandler.EnemyBlockIcon = true;
            EnemyAnimationHandler.EnemyBlockAnimState = true;
        }

        GlobalDamage.DamageCalculator();

        isPlayerAttacking = false;
        isPlayerThrowing = false;
        isPlayerBlocking = false;

        isEnemyAttacking = false;
        isEnemyThrowing = false;
        isEnemyBlocking = false;
    }

    public static void FightPhase4()
    {
        Debug.Log("Phase 4:");
        if (PlayerInputs.FourthMove == PlayerInputs.AttackId)
        {
            isPlayerAttacking = true;
            MoveSignHandler.AttackIcon = true;
            PlayerAnimationHandler.PlayerAttackAnimState = true;
        }
        else if (PlayerInputs.FourthMove == PlayerInputs.ThrowId)
        {
            isPlayerThrowing = true;
            MoveSignHandler.ThrowIcon = true;
            PlayerAnimationHandler.PlayerAttackAnimState = true;
        }
        else if(PlayerInputs.FourthMove == PlayerInputs.BlockId)
        {
            isPlayerBlocking = true;
            MoveSignHandler.BlockIcon = true;
            PlayerAnimationHandler.PlayerBlockAnimState = true;
        }
    
        if (EnemyInputs.EnemyFourthMove == PlayerInputs.AttackId)
        {
            isEnemyAttacking = true;
            MoveSignHandler.EnemyAttackIcon = true;
            EnemyAnimationHandler.EnemyAttackAnimState = true;
        }
        else if (EnemyInputs.EnemyFourthMove == PlayerInputs.ThrowId)
        {
            isEnemyThrowing = true;
            MoveSignHandler.EnemyThrowIcon = true;
        }
        else if(EnemyInputs.EnemyFourthMove == PlayerInputs.BlockId)
            EnemyAnimationHandler.EnemyAttackAnimState = true;
        {
            isEnemyBlocking = true;
            MoveSignHandler.EnemyBlockIcon = true;
            EnemyAnimationHandler.EnemyBlockAnimState = true;
        }

        GlobalDamage.DamageCalculator();

        isPlayerAttacking = false;
        isPlayerThrowing = false;
        isPlayerBlocking = false;

        isEnemyAttacking = false;
        isEnemyThrowing = false;
        isEnemyBlocking = false;
    }

     public static void FightPhase5()
    {
        Debug.Log("Phase 5:");
        if (PlayerInputs.FifthMove == PlayerInputs.AttackId)
        {
            isPlayerAttacking = true;
            MoveSignHandler.AttackIcon = true;
            PlayerAnimationHandler.PlayerAttackAnimState = true;
        }
        else if (PlayerInputs.FifthMove == PlayerInputs.ThrowId)
        {
            isPlayerThrowing = true;
            MoveSignHandler.ThrowIcon = true;
            PlayerAnimationHandler.PlayerAttackAnimState = true;
        }
        else if(PlayerInputs.FifthMove == PlayerInputs.BlockId)
        {
            isPlayerBlocking = true;
            MoveSignHandler.BlockIcon = true;
            PlayerAnimationHandler.PlayerBlockAnimState = true;
        }
    
        if (EnemyInputs.EnemyFifthMove == PlayerInputs.AttackId)
        {
            isEnemyAttacking = true;
            MoveSignHandler.EnemyAttackIcon = true;
            EnemyAnimationHandler.EnemyAttackAnimState = true;
        }
        else if (EnemyInputs.EnemyFifthMove == PlayerInputs.ThrowId)
        {
            isEnemyThrowing = true;
            MoveSignHandler.EnemyThrowIcon = true;
            EnemyAnimationHandler.EnemyAttackAnimState = true;
        }
        else if(EnemyInputs.EnemyFifthMove == PlayerInputs.BlockId)
        {
            isEnemyBlocking = true;
            MoveSignHandler.EnemyBlockIcon = true;
            EnemyAnimationHandler.EnemyBlockAnimState = true;
        }

        GlobalDamage.DamageCalculator();

        isPlayerAttacking = false;
        isPlayerThrowing = false;
        isPlayerBlocking = false;

        isEnemyAttacking = false;
        isEnemyThrowing = false;
        isEnemyBlocking = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
