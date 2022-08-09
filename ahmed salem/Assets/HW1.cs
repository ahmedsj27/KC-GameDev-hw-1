using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HW1 : MonoBehaviour
{
    int health = 100;
    string hero = "ahmed";
    int damagedhealth;

    // Start is called before the first frame update
    void Start()
    {
        damagedhealth = damaged();

        print("damaged health : " + damagedhealth);
       
        print("boosted health : " + boost());

        if (boost() > damagedhealth)
        {

            print(boost());

        }

        else if (damagedhealth == boost())
        {

            print(damagedhealth + " = " + boost());

        }

        else
        {

            print(damagedhealth);

        }

        print("80 is less than 90");
    }

    // Update is called once per frame
    void Update()
    {

    }

    int damaged()
    {
        return health - 20;

    }

    int boost()
    {
        return damagedhealth + 10;

    }
}
