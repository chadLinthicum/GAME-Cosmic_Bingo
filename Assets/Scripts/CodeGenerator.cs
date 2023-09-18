using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CodeGenerator : MonoBehaviour
{
    string[] SPACE = { "S", "P", "A", "C", "E" };
    public TextMeshProUGUI displayText;

    void Start()
    {
        int randomLetter;
        int randomInt;
        string square;
        HashSet<string> generatedSquares = new HashSet<string>();

        for (int i = 0; i < 25; i++)
        {
            do
            {
                randomLetter = (int)Random.Range(0f, 5f);
                randomInt = (int)Random.Range(1f, 76f);
                if (i != 12)
                {
                    //square = SPACE[randomLetter] + randomInt;
                    square = randomInt.ToString();
                }
                else
                {
                    square = "__";
                }

            }
            while (generatedSquares.Contains(square));

            generatedSquares.Add(square);

            if (square.Length < 2)
            {
                square = "0" + square; // Add a space to the end of the square if its length is 2
            }

            displayText.text += square;

            if ((i + 1) % 5 == 0 && i != 0)
            {
                displayText.text += "\n"; // Append a line break after every 5th instance
            }
            else
            {
                displayText.text += " "; // Append a space between each instance
            }
        }
    }
}