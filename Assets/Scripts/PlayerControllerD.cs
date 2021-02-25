using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerD : PlayerController
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerControllerD  move_forward = new PlayerControllerD();
      //  move_forward.Forward();
        move_forward.Foodprojectile();


    }
}
