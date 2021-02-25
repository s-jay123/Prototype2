using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float ForwardInput;
    public float Speed = 10.0f;
    public float xValues = 10.0f;
    public GameObject projectilePrefeb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
           //setting boundaries for the player
           if(transform.position.x<-10)
        { //resetting position to -10 again and getting position y and z since they are unchanged
            transform.position = new Vector3(-xValues, transform.position.y, transform.position.z);
        }

        if (transform.position.x >10)
        { //setting position to 10  and getting position y and z since they are unchanged
            transform.position = new Vector3(xValues, transform.position.y, transform.position.z);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * Speed);

       // Forward();
        Foodprojectile();


      //  if (Input.GetKeyDown(KeyCode.Space))
        //{
            // we will launch the projectile from the player
          //  Instantiate(projectilePrefeb, transform.position, projectilePrefeb.transform.rotation);
        //}

       


    }

   // protected void Forward()
    //{
      //  ForwardInput = Input.GetAxis("Vertical");
       // transform.Translate(Vector3.forward * ForwardInput * Time.deltaTime * Speed);
    //}

    protected void Foodprojectile()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // we will launch the projectile from the player
            Instantiate(projectilePrefeb, transform.position, projectilePrefeb.transform.rotation);
        }


    }
}
