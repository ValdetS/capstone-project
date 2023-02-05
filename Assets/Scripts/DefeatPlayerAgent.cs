using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.MLAgents;
using Unity.MLAgents.Actuators;
using Unity.MLAgents.Sensors;

public class DefeatPlayerAgent : Agent
{
    public static bool isMove1Set = false;
    public static bool isMove2Set = false;
    public static bool isMove3Set = false;
    public static bool isMove4Set = false;
    public static bool isMove5Set = false;

    public static bool isEpDone = false;


    public override void OnEpisodeBegin()
    {
        if (isEpDone == true)
        {
            GlobalHealth.PlayerHealthPoints = 200;
            GlobalHealth.EnemyHealthPoints = 200;
            isEpDone = false;
        }
       
    }

    public override void CollectObservations(VectorSensor sensor)
    {
        sensor.AddObservation(GlobalHealth.EnemyHealthPoints);
        sensor.AddObservation(GlobalHealth.PlayerHealthPoints);

        sensor.AddObservation(GlobalCombat.isPlayerAttacking);
        sensor.AddObservation(GlobalCombat.isPlayerThrowing) ;
        sensor.AddObservation(GlobalCombat.isPlayerBlocking);

        sensor.AddObservation(GlobalCombat.isEnemyAttacking);
        sensor.AddObservation(GlobalCombat.isEnemyThrowing);
        sensor.AddObservation(GlobalCombat.isEnemyBlocking);
    }

    public override void OnActionReceived(ActionBuffers actions)
    {
        //Debug.Log(actions.DiscreteActions[0]);
        int aiEnemyFirstMove = actions.DiscreteActions[0];
        int aiEnemySecondMove = actions.DiscreteActions[1];
        int aiEnemyThirdMove = actions.DiscreteActions[2];
        int aiEnemyFourthMove = actions.DiscreteActions[3];
        int aiEnemyFifthMove = actions.DiscreteActions[4];

        if(GlobalCombat.isPlayerReady == true)
        {

            if (isMove1Set == false)
            {
                if (aiEnemyFirstMove == 0) { isMove1Set = true; EnemyInputs.EnemyFirstMove = 1; }
                if (aiEnemyFirstMove == 1) { isMove1Set = true; EnemyInputs.EnemyFirstMove = 2; }
                if (aiEnemyFirstMove == 2) { isMove1Set = true; EnemyInputs.EnemyFirstMove = 3; }
            }

            if (isMove2Set == false)
            {

                if (aiEnemySecondMove == 0) { isMove2Set = true; EnemyInputs.EnemySecondMove = 1; }
                if (aiEnemySecondMove == 1) { isMove2Set = true; EnemyInputs.EnemySecondMove = 2; }
                if (aiEnemySecondMove == 2) { isMove2Set = true; EnemyInputs.EnemySecondMove = 3; }

            }



            if (isMove3Set == false)
            {

                if (aiEnemyThirdMove == 0) { isMove3Set = true; EnemyInputs.EnemyThirdMove = 1; }
                if (aiEnemyThirdMove == 1) { isMove3Set = true; EnemyInputs.EnemyThirdMove = 2; }
                if (aiEnemyThirdMove == 2) { isMove3Set = true; EnemyInputs.EnemyThirdMove = 3; }
            }

            if (isMove4Set == false)
            {

                if (aiEnemyFourthMove == 0) { isMove4Set = true; EnemyInputs.EnemyFourthMove = 1; }
                if (aiEnemyFourthMove == 1) { isMove4Set = true; EnemyInputs.EnemyFourthMove = 2; }
                if (aiEnemyFourthMove == 2) { isMove4Set = true; EnemyInputs.EnemyFourthMove = 3; }
            }

            if (isMove5Set == false)
            {

                if (aiEnemyFifthMove == 0) { isMove5Set = true; EnemyInputs.EnemyFifthMove = 1; }
                if (aiEnemyFifthMove == 1) { isMove5Set = true; EnemyInputs.EnemyFifthMove = 2; }
                if (aiEnemyFifthMove == 2) { isMove5Set = true; EnemyInputs.EnemyFifthMove = 3; }
            }

        }

        if (GlobalCombat.isPlayerAttacking == true && GlobalCombat.isEnemyBlocking == true)
        {
            AddReward(0.05f);
        }
        if (GlobalCombat.isPlayerThrowing == true && GlobalCombat.isEnemyAttacking == true)
        {
            AddReward(0.05f);
        }
        if (GlobalCombat.isPlayerBlocking == true && GlobalCombat.isEnemyThrowing == true)
        {
            AddReward(0.05f);
        }

        if (GlobalCombat.isPlayerAttacking == true && GlobalCombat.isEnemyThrowing == true)
        {
            AddReward(-0.01f);
        }
        if (GlobalCombat.isPlayerThrowing == true && GlobalCombat.isEnemyBlocking == true)
        {
            AddReward(-0.1f);
        }
        if (GlobalCombat.isPlayerBlocking == true && GlobalCombat.isEnemyAttacking == true)
        {
            AddReward(-0.1f);
        }

        if (GlobalHealth.PlayerHealthPoints <= 0 && GlobalHealth.EnemyHealthPoints >= 0)
        {
            SetReward(1f);
            EndEpisode();
        }

        if (GlobalHealth.PlayerHealthPoints >= 0 && GlobalHealth.EnemyHealthPoints <= 0)
        {
            SetReward(-1f);
            EndEpisode();
        }

    }

}