using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MadLibs : MonoBehaviour
{

    private TextMeshProUGUI textMeshPro;
    public bool statement = true;
    public string verb = "Unknown";
    public string noun = "Unknown"; 
    public string adjective = "Unknown";
    public int number = 0;
    public string pluralNoun = "Unknown";   
    public float percent = 0f;
   
    // Start is called before the first frame update
    void Start()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();
        textMeshPro.text = $"The is statment is {statement}. I did not {verb} the {noun}. I am not guily. I am {adjective} person. The act was performed {number} wandering {pluralNoun}. I am {percent}% sure of this.";  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
