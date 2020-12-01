using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizardnumber : MonoBehaviour
{       int max, min, guess;
    // Start is called before the first frame update
    void Start()
    {
        StartGame();
       
    }
    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;
        Debug.Log(" welcome to wizard number game ");
        Debug.Log(" pick a number between 1 to 1000 ");
        Debug.Log(" pick higher number is : " + max);
        Debug.Log(" pick lower number is : " + min);
        Debug.Log(" if number is higher or lower than 500 ");
        Debug.Log(" push up = higher, push down = lower, push enter = correct");
        max = max + 1;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("I am genius");
            StartGame();
        }
    }    
    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("it is higher or lower than ...." + guess);
    }
}
