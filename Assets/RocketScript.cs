using System.Reflection;
using System.Security.Cryptography;
using UnityEngine;

public class RocketScript : MonoBehaviour
{
    public GameObject brick;
    public BrickScript BrickLogic;
    public int deadzone = 5;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
   //     BrickLogic = GameObject.Find("Logic").GetComponent<BrickScript>();
    }

    // Update is called once per frame
    void Update()
    {

     
        if (transform.position.y > deadzone)
        {
            Destroy(gameObject);
            
        }

        


        
    }





    
}





