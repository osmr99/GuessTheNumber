using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GuessTheNumber : MonoBehaviour
{
    [SerializeField] TMP_Text GuessANumberText;
    [SerializeField] TMP_Text attempts;
    [SerializeField] TMP_InputField input;
    [SerializeField] Button submit;

    int attemptsNum = 3;  // Help here, if I make these variables accesible for all methods in the script,
                          // I delete these and use the ones in gameSetup()
    int randomNumber; // Help here, how can I make a random num accessible for all the methods??

    // Start is called before the first frame update
    void Start()
    {
        GameSetup();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GameSetup() // Help here, how to make variables accesible or public for all methods in the script.
    {
            int attemptsNum = 3;
            randomNumber = UnityEngine.Random.Range(1, 11);
            input.enabled = true;
            submit.enabled = true;
            input.text = null;
            GuessANumberText.text = "Guess a number between 1 and 10!";
            attempts.text = "Attempts remaining: " + attemptsNum;
            attempts.color = Color.white;
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
            if (attemptsNum == 2)
            {
                attempts.text = "Attempts remaining: " + attemptsNum;
                attempts.color = Color.yellow;
            }
            if (attemptsNum == 1)
            {
                attempts.text = "Attempts remaining: " + attemptsNum;
                attempts.color = Color.red;
            }
            if (attemptsNum == 0)
            {
                attempts.text = "Attempts remaining: " + attemptsNum;
                attempts.color = Color.black;
                Lose();
                attemptsNum--;

            }
        }
    }

    public void Win()
    {
        GuessANumberText.text = "You Won! :D";
        attempts.color = Color.green;
        input.enabled = false;
        submit.enabled = false;
    }

    public void Lose()
    {
        
        GuessANumberText.text = "You Lost :(";
        input.enabled = false;
        submit.enabled = false;

    }

    public void resetGame()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        GameSetup();
    }

}
