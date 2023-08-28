using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class day2 : MonoBehaviour
{
    

    string HeroName = "Ahmad";
    int HeroPower = 90;

    string villianName = "Hamza";
    int villianPower = 75;

    float PlayerSpeed = 105f;

    // Start is called before the first frame update
    void Start()
    {
      if (HeroPower==villianPower)
      {
        print("Hero power equals Villian power ");
      }
      else if (HeroPower > villianPower)
      {
          print("Hero power is more than Villian power ");
      }
      else if (HeroPower < villianPower)
      {
          print(" Villian power is more than Hero power ");
      }
      print(PlayerSpeed);
      SetSpeed(25f);
      print(PlayerSpeed);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SetSpeed(float speed)
    {
        PlayerSpeed = speed; 
    }
}