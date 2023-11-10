using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MyVariables : MonoBehaviour
{
    private int health = 100;
    private int Health = 100;
    private string messageForTheTextView = "This space for rent";
    private const int PlayerScore = 100;
    public string firstName;
    private TextMeshProUGUI textMeshPro; 

    // Start is called before the first frame update
    void Start()
    {

        textMeshPro = GetComponent<TextMeshProUGUI>();
        textMeshPro.text = $"Hello {firstName}!";
    }

    // Update is called once per frame
    void Update()
    {

    }
}
