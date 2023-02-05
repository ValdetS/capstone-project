using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalHealth : MonoBehaviour
{
    // Health bars
    public GameObject PlayerHp;
    public GameObject EnemyHp;
    //public GameObject PlayerHpBar;
    //public GameObject EnemyHpBar;

    // Fight result info
    public GameObject FightResult;
    // Play again button
    public GameObject RestartButton;

    public static int PlayerHealthPoints = 200;
    public static int EnemyHealthPoints = 200;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        PlayerHp.GetComponent<Text>().text = "HP: " + PlayerHealthPoints;
        EnemyHp.GetComponent<Text>().text = "HP: " + EnemyHealthPoints;
        
        if (PlayerHealthPoints <= 0) 
        {
            PlayerInputs.FirstMove = PlayerInputs.NoMoveId;
            PlayerInputs.SecondMove = PlayerInputs.NoMoveId;
            PlayerInputs.ThirdMove = PlayerInputs.NoMoveId;
            PlayerInputs.FourthMove = PlayerInputs.NoMoveId;
            PlayerInputs.FifthMove = PlayerInputs.NoMoveId;

            EnemyInputs.EnemyFirstMove = PlayerInputs.NoMoveId;
            EnemyInputs.EnemySecondMove = PlayerInputs.NoMoveId;
            EnemyInputs.EnemyThirdMove = PlayerInputs.NoMoveId;
            EnemyInputs.EnemyFourthMove = PlayerInputs.NoMoveId;
            EnemyInputs.EnemyFifthMove = PlayerInputs.NoMoveId;

            FightResult.GetComponent<Text>().text = "Defeat!";
            RestartButton.SetActive(true);
        }

        if (EnemyHealthPoints <= 0)
        {
            EnemyInputs.EnemyFirstMove = PlayerInputs.NoMoveId;
            EnemyInputs.EnemySecondMove = PlayerInputs.NoMoveId;
            EnemyInputs.EnemyThirdMove = PlayerInputs.NoMoveId;
            EnemyInputs.EnemyFourthMove = PlayerInputs.NoMoveId;
            EnemyInputs.EnemyFifthMove = PlayerInputs.NoMoveId;

            PlayerInputs.FirstMove = PlayerInputs.NoMoveId;
            PlayerInputs.SecondMove = PlayerInputs.NoMoveId;
            PlayerInputs.ThirdMove = PlayerInputs.NoMoveId;
            PlayerInputs.FourthMove = PlayerInputs.NoMoveId;
            PlayerInputs.FifthMove = PlayerInputs.NoMoveId;

            FightResult.GetComponent<Text>().text = "Victory!";
            RestartButton.SetActive(true);
        }

        if (PlayerHealthPoints == 200)
        {
            FightResult.GetComponent<Text>().text = "";
            RestartButton.SetActive(false);
        }
        
    }
}
