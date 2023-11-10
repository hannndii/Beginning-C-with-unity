using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using JetBrains.Annotations;

public class MyOperator : MonoBehaviour
{
    private TextMeshProUGUI textMeshPro;
    // Start is called before the first frame update
    void Start()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void DisplayMessage()
    {
        int xp = 90;
        xp = xp + 10;
        xp += 10;
        xp -= 10;
        xp *= 10;
        xp /= 10;

        int strength = 18;
        int stat = strength++;
        // jika strength diinput maka hasilnya 19
        // jika stat diinput maka hasilnya 18

        int joyDivision = 5 % 2;

        string firstName = "Muhammad";
        string lastName = "Handi";
        string fullName = firstName + " " + lastName;

        int problem = 3 - (3 * 6) + 2;

        int multiplication = 3 * 6;
        int additional = 3;
        int solution = multiplication + additional + 2;

        float conversetion = (float)100;
        int largeNumber = 1_000_000;
        byte smallNumber = (byte) largeNumber;
       
        textMeshPro.text = $"{problem}";
    }
}
