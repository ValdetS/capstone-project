using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInputs : MonoBehaviour
{
    // Move selection displays
    public GameObject Move1;
    public GameObject Move2;
    public GameObject Move3;
    public GameObject Move4;
    public GameObject Move5;

    // Buttons
    public GameObject FightButton;

    // Move id numbers
    public static int AttackId = 1;
    public static int ThrowId = 2;
    public static int BlockId = 3;

    public static int NoMoveId = 0;
    public static int MoveInput;

    // Variables for the move selection displays to hold move ids
    public static int FirstMove = NoMoveId;
    public static int SecondMove = NoMoveId;
    public static int ThirdMove = NoMoveId;
    public static int FourthMove = NoMoveId;
    public static int FifthMove = NoMoveId;

    // Functions for move buttons
    public void Atack() 
    {
        MoveInput = AttackId;
        MoveChecker(255, 0, 0, 255);
    }

    public void Throw() 
    {
        MoveInput = ThrowId;
        MoveChecker(0, 255, 0, 255);
    }

    public void Block() 
    {
        MoveInput = BlockId;
        MoveChecker(0, 0, 255, 255);
    }

    // Function to check which move display is empty then input the selected move
    public void MoveChecker(byte R, byte G, byte B,  byte A) //Takes RBGA colour values as paramters
    {
        if (FirstMove == NoMoveId)
        {
            FirstMove = MoveInput;
            Move1.GetComponent<Image>().color = new Color32(R, G, B, A); //Changes colour based on paramters given
        }
        else if (SecondMove == NoMoveId)
        {
            SecondMove = MoveInput;
            Move2.GetComponent<Image>().color = new Color32(R, G, B, A);
        }
        else if (ThirdMove == NoMoveId)
        {
            ThirdMove = MoveInput;
            Move3.GetComponent<Image>().color = new Color32(R, G, B, A);
        }
        else if (FourthMove == NoMoveId)
        {
            FourthMove = MoveInput;
            Move4.GetComponent<Image>().color = new Color32(R, G, B, A);
        }
        else if (FifthMove == NoMoveId)
        {
            FifthMove = MoveInput;
            Move5.GetComponent<Image>().color = new Color32(R, G, B, A);
        }
    }
    
    public void Fight()
    {
            GlobalCombat.isPlayerReady = true;

            GlobalCombat.FightPhase1();

        StartCoroutine(NextMoveDelay());
            IEnumerator NextMoveDelay()
            {
                yield return new WaitForSeconds(1);
                GlobalCombat.FightPhase2();

                yield return new WaitForSeconds(1);
                GlobalCombat.FightPhase3();

                yield return new WaitForSeconds(1);
                GlobalCombat.FightPhase4();

                yield return new WaitForSeconds(1);
                GlobalCombat.FightPhase5();

                yield return new WaitForSeconds(1);
                GlobalCombat.isPlayerReady = false;

                yield return new WaitForSeconds(1);
                ResetMoveIds();

        }
    }

    public void ResetMoveIds()
    {
        FirstMove = NoMoveId;
        Move1.GetComponent<Image>().color = new Color32(94, 94, 94, 255);
        SecondMove = NoMoveId;
        Move2.GetComponent<Image>().color = new Color32(94, 94, 94, 255);
        ThirdMove = NoMoveId;
        Move3.GetComponent<Image>().color = new Color32(94, 94, 94, 255);
        FourthMove = NoMoveId;
        Move4.GetComponent<Image>().color = new Color32(94, 94, 94, 255);
        FifthMove = NoMoveId;
        Move5.GetComponent<Image>().color = new Color32(94, 94, 94, 255);

        // Reset enemy moves
        DefeatPlayerAgent.isMove1Set = false;
        DefeatPlayerAgent.isMove2Set = false;
        DefeatPlayerAgent.isMove3Set = false;
        DefeatPlayerAgent.isMove4Set = false;
        DefeatPlayerAgent.isMove5Set = false;

        EnemyInputs.EnemyFirstMove = NoMoveId;
        EnemyInputs.EnemySecondMove = NoMoveId;
        EnemyInputs.EnemyThirdMove = NoMoveId;
        EnemyInputs.EnemyFourthMove = NoMoveId;
        EnemyInputs.EnemyFifthMove = NoMoveId;
    }

    public void ResetGame()
    {
        DefeatPlayerAgent.isEpDone = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (FifthMove == 0 || GlobalHealth.PlayerHealthPoints <= 0 || GlobalHealth.EnemyHealthPoints <= 0)
        {
            FightButton.GetComponent<Button>().interactable = false;
        }
        else
        {
            FightButton.GetComponent<Button>().interactable = true;
        }
        
    }
}
