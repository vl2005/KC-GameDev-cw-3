using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CW3 : MonoBehaviour
{
        string HERO_NAME = "salem";
        int hero_power = 10;
        string villian_name = "basam";
        int villian_power = 20;
        float playerSpeed = 4.5f;
        float playerspeed2 = 7f;
    // Start is called before the first frame update
    void Start()
    {
        if (hero_power > villian_power)
        {
            print(" the hero aka " + HERO_NAME + "is winning the fight");
        }
        else if (hero_power == villian_power)
        {
            print(" both of the hero aka " + HERO_NAME + " and the villian aka " + villian_name + " are undefeatable ");
        }
        else
        {
            print(" the villian aka " + villian_name + " is winning the fight ");
        }
        SETSPEED(2.5f);
        CompareSpeed();
    } 
    void SETSPEED(float speed )
    {
        print(playerSpeed);
        playerSpeed = speed;
        print(playerSpeed);
    }
   
    void CompareSpeed()
    {
        if (playerSpeed > playerspeed2 )
        {
            print(" original player speed is faster , and it eaquals to " + playerSpeed);
        }
        else if (playerSpeed == playerspeed2)
        {
            print("the new speed and the old one are the same , the original playerSpeed is" + playerSpeed + "and the new speed is" + playerspeed2);
        }
        else
        {
            print(" the new player speed is faster , and it eaquals to " + playerspeed2);
        }
    }

}
