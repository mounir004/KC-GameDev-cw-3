using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thirdday : MonoBehaviour
{
    // Start is called before the first frame update
    string heroname = "mounir";
        int heropower = 100 ;
       string villianname = "chucky";
       int villianpower = 100;
        float playerspeed = 60f ;

       void setspeed (float speed ) 
       { playerspeed = speed ;

       }

    void Start()
    {
        if (heropower > villianpower)
            { 
            print("hero is stronger");

            }
    else if (heropower<villianpower)
            {
                print("villian is stronger");

            }
    else 
            {
                print("hero and villian are equal");
            }
    
    setspeed  (2.5f); 

    print(playerspeed);
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
