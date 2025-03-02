using System;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEditor.Build;
using UnityEditor.Search;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class BrickScript : MonoBehaviour
{


    
    public Text scoreText;
    public int score = 0;
    public int scoretoadd = 1;

    

    public float timenow = 0;
    public float cooldowntime = 0;
    public float max = -8.5f;
    public float min = 8.5f;
    public GameObject brick;

    private GameObject copy;

    public Sprite[] fruits;
    
    public GameObject LoseScreen;

    public bool Playing = false;


    public Animator animator;


    public GameObject rocket;
    public GameObject spaceship;

    public int lives = 3;
    
    


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Playing = false;
       
         
    }

    // Update is called once per frame
    void Update()
    {

        if (Playing == true) {
        SpawnBrick();
   
        }

        if (Playing == false) {
            if (Input.anyKeyDown) {
                Playing = true;
                score = 0;
                scoreText.text = score.ToString();
                LoseScreen.SetActive(false);
                rocket.SetActive(true);
                spaceship.SetActive(true);
            }
        }
    }







    void SpawnBrick()
    {

        cooldowntime = Random.Range(0.25f, 1f); 
        if (timenow < cooldowntime) {
            timenow = timenow + Time.deltaTime;
            
        }
        else
        {
            if (Playing == true) { 
            copy = Instantiate(brick, new Vector3(Random.Range(max, min), 4.5f, 0), transform.rotation);    
            copy.GetComponent<SpriteRenderer>().sprite = fruits[Random.Range(0, fruits.Length)];          
            brick.SetActive(true);
            timenow = 0;
   
            }
        }

    }
    

   public void addscore(int scoretoadd)
    {
              
      
        score = score + scoretoadd;
        scoreText.text = score.ToString();
    }
  



    public void Lose() {
        LoseScreen.SetActive(true);
        Playing = false; 
        rocket.SetActive(false);
        spaceship.SetActive(false);

    }


}




   