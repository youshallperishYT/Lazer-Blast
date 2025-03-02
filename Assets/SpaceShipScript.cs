using System.Data.Common;
using System.Numerics;
using System.Runtime.CompilerServices;
using NUnit.Framework.Constraints;
using Unity.VisualScripting;
using UnityEngine;
using System.Collections;

public class SpaceShipScript : MonoBehaviour
{
public Rigidbody2D myRigidbody;
public float speed = 5;
public GameObject rocket;
public float timer = 2;
public float currenttime = 0;
public AudioSource ding;

public Animator animator;

public BrickScript BrickScript;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
        GameObject.FindWithTag("Logic").GetComponent<BrickScript>();
    }

    // Update is called once per frame
    void Update()
    {
currenttime = currenttime + Time.deltaTime;
        

        if (Input.GetKey(KeyCode.D))
        {
             transform.position += UnityEngine.Vector3.right * speed * Time.deltaTime;
        }


         if (Input.GetKey(KeyCode.A))
        {
             transform.position += UnityEngine.Vector3.left * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.Space)) {
        {
          
            SpawnRocket();
        }
           
          
            
        
//if (BrickScript.Playing == false) 
   //        gameObject.SetActive(false);
        
     //   else
      //        gameObject.SetActive(true);

        
        


    

    }


    void SpawnRocket()
    {

        if (currenttime < timer) {

            
            
        }
        else
        {
        animator.SetBool("Shoot", true);
        //if (BrickScript.Playing == true) {
          Instantiate(rocket, transform.position, transform.rotation);
         // ding.Play();
          rocket.SetActive(true);
          currenttime = 0;
          StartCoroutine(AnimationStart());
          
     
        
        }
  //  }
}


    IEnumerator AnimationStart() {
        yield return new WaitForSeconds(0.25f);
        animator.SetBool("Shoot", false);
    }

    }
}

//I think I have to move it into Rocket Script -waiting for jeremyt. Also https://discussions.unity.com/t/destroying-assets-is-not-permitted-to-avoid-data-loss/878961/3