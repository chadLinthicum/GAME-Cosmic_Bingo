using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CodeGenerator : MonoBehaviour
{
    public TextMeshProUGUI displayText;
    string[] numbers = new string[25];



    void Start()
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            int randomInt = Random.Range(00, 75);
            string randomIntString = randomInt.ToString();

            if(randomIntString.Length < 2)
            {
                randomIntString = randomInt.ToString("D2");
            }

            // Check for duplicates in the previous elements
            for (int j = 0; j < i; j++)
            {
                if (numbers[j].ToString() == randomIntString)
                {
                    // Duplicate found, generate a new random number
                    randomInt = Random.Range(0, 75);
                    randomIntString = randomInt.ToString();
                    // Restart the loop to recheck for duplicates
                    j = -1;
                }
            }

            numbers[i] = randomIntString;
            Debug.Log("Index: " + i + ", Value: " + numbers[i]);
        }

        numbers[12] = "__";
        displayText.text = string.Join(" ", numbers);
    }
}