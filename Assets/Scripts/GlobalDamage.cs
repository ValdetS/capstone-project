using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalDamage : MonoBehaviour
{

    public const int AttackDamageValue = 20;
    public const int ThrowDamageValue = 10;
    public const int BlockDamageValue = 0;

    public const int DamageMultiplier = 2;
    public const int DamageDivider = 2;

    // public const int ComboMultiplier = 4;

    public static int PlayerDamage = 0;
    public static int EnemyDamage = 0;

    // Funtion to calculate how much damage is done based on moves played
    public static void DamageCalculator()
    {
       if (GlobalCombat.isPlayerAttacking == true && GlobalCombat.isEnemyAttacking == true)
       {
           PlayerDamage = AttackDamageValue;
           EnemyDamage = AttackDamageValue;
           GlobalHealth.PlayerHealthPoints -= EnemyDamage;
           GlobalHealth.EnemyHealthPoints -= PlayerDamage;
           Debug.Log("Player attacks for " + PlayerDamage + ". " + "Enemy attacks for " + EnemyDamage + ". ");
       }

       if (GlobalCombat.isPlayerThrowing == true && GlobalCombat.isEnemyThrowing == true)
       {
           PlayerDamage = ThrowDamageValue;
           EnemyDamage = ThrowDamageValue;
           GlobalHealth.PlayerHealthPoints -= EnemyDamage;
           GlobalHealth.EnemyHealthPoints -= PlayerDamage;
           Debug.Log("Player throws for " + PlayerDamage + ". " + "Enemy throws for " + EnemyDamage + ". ");
       }

       if (GlobalCombat.isPlayerBlocking == true && GlobalCombat.isEnemyBlocking == true)
       {
           PlayerDamage = BlockDamageValue;
           EnemyDamage = BlockDamageValue;
           GlobalHealth.PlayerHealthPoints -= EnemyDamage;
           GlobalHealth.EnemyHealthPoints -= PlayerDamage;
           Debug.Log("Player blocks for " + PlayerDamage + ". " + "Enemy blocks for " + EnemyDamage + ". ");
       }

       if (GlobalCombat.isPlayerThrowing == true && GlobalCombat.isEnemyAttacking == true)
       {
           PlayerDamage = ThrowDamageValue;
           EnemyDamage =  AttackDamageValue * DamageMultiplier;
           GlobalHealth.PlayerHealthPoints -= EnemyDamage;
           GlobalHealth.EnemyHealthPoints -= PlayerDamage;
           Debug.Log("Player throws for " + PlayerDamage + ". " + "Enemy attacks for " + EnemyDamage + ". ");
       }

       if (GlobalCombat.isPlayerBlocking == true && GlobalCombat.isEnemyAttacking == true)
       {
           PlayerDamage = AttackDamageValue / DamageDivider;
           EnemyDamage = BlockDamageValue;
           GlobalHealth.PlayerHealthPoints -= EnemyDamage;
           GlobalHealth.EnemyHealthPoints -= PlayerDamage;
           Debug.Log("Player block deflects for " + PlayerDamage + ". " + "Enemy attacks for " + EnemyDamage + ". ");
       }

       if (GlobalCombat.isPlayerBlocking == true && GlobalCombat.isEnemyThrowing == true)
       {
           PlayerDamage = BlockDamageValue;
           EnemyDamage = ThrowDamageValue * DamageMultiplier;
           GlobalHealth.PlayerHealthPoints -= EnemyDamage;
           GlobalHealth.EnemyHealthPoints -= PlayerDamage;
           Debug.Log("Player blocks for " + PlayerDamage + ". " + "Enemy throws for " + EnemyDamage + ". ");
       }

       if (GlobalCombat.isPlayerAttacking == true && GlobalCombat.isEnemyThrowing == true)
       {
           PlayerDamage = AttackDamageValue * DamageMultiplier;
           EnemyDamage = ThrowDamageValue;
           GlobalHealth.PlayerHealthPoints -= EnemyDamage;
           GlobalHealth.EnemyHealthPoints -= PlayerDamage;
           Debug.Log("Player attacks for " + PlayerDamage + ". " + "Enemy throws for " + EnemyDamage + ". ");
       }

       if(GlobalCombat.isPlayerAttacking == true && GlobalCombat.isEnemyBlocking == true)
       {
           PlayerDamage = BlockDamageValue;
           EnemyDamage = AttackDamageValue / DamageDivider;
           GlobalHealth.PlayerHealthPoints -= EnemyDamage;
           GlobalHealth.EnemyHealthPoints -= PlayerDamage;
           Debug.Log("Player attacks for " + PlayerDamage + ". " + "Enemy block deflects for " + EnemyDamage + ". ");
       }

        if (GlobalCombat.isPlayerThrowing == true && GlobalCombat.isEnemyBlocking == true)
        {
            PlayerDamage = ThrowDamageValue * DamageMultiplier;
            EnemyDamage = BlockDamageValue;
            GlobalHealth.PlayerHealthPoints -= EnemyDamage;
            GlobalHealth.EnemyHealthPoints -= PlayerDamage;
            Debug.Log("Player throws for " + PlayerDamage + ". " + "Enemy blocks for " + EnemyDamage + ". ");
        }
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
