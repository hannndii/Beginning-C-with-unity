using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberGuesser : MonoBehaviour
{
    public int guess;
    public int randomNumber:
    private TextMeshProUGUI textMeshPro;
    // Start is called before the first frame update
    void Start()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();
        textMeshPro.text = "Pick a number between 1 and 10"
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void checkGuess()
    {

    }
}
