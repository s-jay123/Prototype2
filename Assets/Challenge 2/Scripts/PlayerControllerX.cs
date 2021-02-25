using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    //bool isReadyForInstantiate;
    public GameObject dogPrefab;
    bool canThrowDog = true;


    private void Start()
    {
        //isReadyForInstantiate = true;
    }
    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if ( Input.GetKeyDown(KeyCode.Space) && canThrowDog )
        {
           /// StartCoroutine(PreventSpam());
            SpawnDog();
              canThrowDog = false;
            Invoke("CanThrowDogAgain", 2);
           

        }
       
       
        //
          //  IEnumerator PreventSpam()
          //{
          //  isReadyForInstantiate = false;
          //yield return new WaitForSeconds(2);
          //isReadyForInstantiate = true;
          //}
    }

    void SpawnDog()
    {
        Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
    }

    void CanThrowDogAgain()
    {
        canThrowDog = true;
    } 

}
