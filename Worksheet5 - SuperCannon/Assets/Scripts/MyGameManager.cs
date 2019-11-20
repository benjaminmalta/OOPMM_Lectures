using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MyGameManager : MonoBehaviour
{
    [SerializeField] Text scoreComponent;
  

    // Start is called before the first frame update
    public void IncreaseScore(int scoreToAdd)
    {

        GameData.Score = GameData.Score + scoreToAdd;
        DisplayScore();
        Debug.Log(GameData.Score);

    }

    // Update is called once per frame
    public void DisplayScore()
    {
        scoreComponent.text = GameData.Score.ToString();


    }
}
