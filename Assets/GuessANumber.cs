using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GuessANumber : MonoBehaviour
{
    [SerializeField] TMP_Text GuessANumberText;
    [SerializeField] TMP_Text attempts;
    [SerializeField] TMP_InputField input;
    [SerializeField] Button submit;
    
    int attemptsNum = 3;
    int randomNumber = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (attemptsNum == 3)
        {
            attempts.text = "Attempts remaining " + attemptsNum;
            attempts.color = Color.white;
        }
        if (attemptsNum == 2)
        {
            attempts.text = "Attempts remaining " + attemptsNum;
            attempts.color = Color.yellow;
        }
        if (attemptsNum == 1)
        {
            attempts.text = "Attempts remaining " + attemptsNum;
            attempts.color = Color.red;
        }
        if (attemptsNum == 0)
        {
            attempts.text = "Attempts remaining " + attemptsNum;
            attempts.color = Color.black;
            Lose();
            attemptsNum--;

        }
    }

    public void SubmitGuess()
    {

        if(Convert.ToInt32(input.text)==randomNumber)
        {
            Win();
        }
        else
        {
            attemptsNum--;
            input.text = null;
        }
    }

    public void Win()
    {
        GuessANumberText.text = "You Won! :D";
        input.enabled = false;
        submit.enabled = false;
    }

    public void resetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Lose()
    {
        
        GuessANumberText.text = "You Lost :(";
        input.enabled = false;
        submit.enabled = false;

    }

}
