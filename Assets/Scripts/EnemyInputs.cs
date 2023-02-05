using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyInputs : MonoBehaviour
{
    // Move enemy move selection displays
    public GameObject EnemyMove1;
    public GameObject EnemyMove2;
    public GameObject EnemyMove3;
    public GameObject EnemyMove4;
    public GameObject EnemyMove5;

    // Variables for the enemy's moves
    public static int EnemyFirstMove; 
    public static int EnemySecondMove; 
    public static int EnemyThirdMove; 
    public static int EnemyFourthMove; 
    public static int EnemyFifthMove; 

    public static void GenerateEnemyMoves()
    {
        EnemyFirstMove = Random.Range(1, 4);
        EnemySecondMove = Random.Range(1, 4);
        EnemyThirdMove = Random.Range(1, 4);
        EnemyFourthMove = Random.Range(1, 4);
        EnemyFifthMove = Random.Range(1, 4);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(EnemyFirstMove == 1)
        {
            EnemyMove1.GetComponent<Image>().color = new Color32(255, 0, 0, 255);
        }
        else if(EnemyFirstMove == 2)
        {
            EnemyMove1.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
        }
        else if(EnemyFirstMove == 3)
        {
            EnemyMove1.GetComponent<Image>().color = new Color32(0, 0, 255, 255);
        }
        else if(EnemyFirstMove == PlayerInputs.NoMoveId)
        {
            EnemyMove1.GetComponent<Image>().color = new Color32(94, 94, 94, 255);
        }

        if(EnemySecondMove == 1)
        {
            EnemyMove2.GetComponent<Image>().color = new Color32(255, 0, 0, 255);
        }
        else if(EnemySecondMove == 2)
        {
            EnemyMove2.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
        }
        else if(EnemySecondMove == 3)
        {
            EnemyMove2.GetComponent<Image>().color = new Color32(0, 0, 255, 255);
        }
        else if(EnemySecondMove == PlayerInputs.NoMoveId)
        {
            EnemyMove2.GetComponent<Image>().color = new Color32(94, 94, 94, 255);
        }

        if(EnemyThirdMove == 1)
        {
            EnemyMove3.GetComponent<Image>().color = new Color32(255, 0, 0, 255);
        }
        else if(EnemyThirdMove == 2)
        {
            EnemyMove3.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
        }
        else if(EnemyThirdMove == 3)
        {
            EnemyMove3.GetComponent<Image>().color = new Color32(0, 0, 255, 255);
        }
        else if(EnemyThirdMove == PlayerInputs.NoMoveId)
        {
            EnemyMove3.GetComponent<Image>().color = new Color32(94, 94, 94, 255);
        }

        if(EnemyFourthMove == 1)
        {
            EnemyMove4.GetComponent<Image>().color = new Color32(255, 0, 0, 255);
        }
        else if(EnemyFourthMove == 2)
        {
            EnemyMove4.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
        }
        else if(EnemyFourthMove == 3)
        {
            EnemyMove4.GetComponent<Image>().color = new Color32(0, 0, 255, 255);
        }
        else if(EnemyFourthMove == PlayerInputs.NoMoveId)
        {
            EnemyMove4.GetComponent<Image>().color = new Color32(94, 94, 94, 255);
        }

        if(EnemyFifthMove == 1)
        {
            EnemyMove5.GetComponent<Image>().color = new Color32(255, 0, 0, 255);
        }
        else if(EnemyFourthMove == 2)
        {
            EnemyMove5.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
        }
        else if(EnemyFourthMove == 3)
        {
            EnemyMove5.GetComponent<Image>().color = new Color32(0, 0, 255, 255);
        }
        else if(EnemyFourthMove == PlayerInputs.NoMoveId)
        {
            EnemyMove5.GetComponent<Image>().color = new Color32(94, 94, 94, 255);
        }
        
    }
}
