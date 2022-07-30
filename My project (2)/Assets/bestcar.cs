using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bestcar : MonoBehaviour
{

    // Start is called before the first frame update
    // 
    string hero_name = "Thamer";
    int heroHeight = 175; 
    int hero_age = 18;
    string heroSuperPower = "speed";
    
    string villainName = "yousef";
    int vililanHeight = 165;
    int villainAge = 17;
    string villainSuperPower = "fire";
    
    void Start()
    { int ageDifference = hero_age - villainAge;
        
        print(" hero name is " + hero_name + " hero age is " + hero_age + " heroHeight is " + heroHeight + " heroSuperPower " + heroSuperPower);
        print(" villainName " + villainName + " vililanHeight " + vililanHeight + " villainAge " + villainAge + " villainSuperPower " + villainSuperPower);
        print(" ageDifference is " + ageDifference);
        heroHeight += 5;
        print(heroHeight);
        villainSuperPower = "none";
        print("villainSuperPower after " + villainSuperPower );

    } 

    







     

    // Update is called once per frame
    void Update()
    {
        
    }
}
