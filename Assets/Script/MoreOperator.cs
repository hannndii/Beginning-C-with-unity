using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using JetBrains.Annotations;
using UnityEngine;

public class MoreOperator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //int x = 2;
        //int y = 5;
        //bool result = x == y;

        //string playerName = null;
        //bool result = playerName != null;

        //string nextLevelXP = 300;
        //string playerOneXP = 185;
        //bool result = playerOneXP > nextLevelXP;

        //Int level = 5;
        //int levelCap = 20;
        //bool result = level < levelCap

        //int points = 100;
        //int highScore = 100;
        //bool result = !(points <= highScore);

        //Debug.Log(!result);
        //Debug.Log(result);
        // Tanda ! adalah negasi.

        //result = !result;
        //Debug.Log(result);

        int coins = 100;
        int maxLive = 3;
        int totalLive = 10;
        bool isPremiumMember = false;
        bool shouldIncreaseLifeCount = coins >= 100 && totalLive < maxLive || isPremiumMember == true;

        bool shouldIncreaseDifficulty = !isPremiumMember && totalLive > 5;
        Debug.Log(shouldIncreaseDifficulty);

        //string firstName = null;
        //bool isUpperCase = firstName != null && firstName.ToUpper() == "VEGETARIANZOMBIE";
        //Debug.Log(isUpperCase);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
