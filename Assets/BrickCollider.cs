using UnityEngine;

public class BrickCollider : MonoBehaviour



{


    public BrickScript logic;
    public int deadzone = -5;

    public float delay = 0.5f;

    public Rigidbody2D myRigidbody;

    public AudioSource boom;


    private bool Alive = true;

 


    

    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
      logic = GameObject.FindWithTag("Logic").GetComponent<BrickScript>();
            
        
    }

    // Update is called once per frame
    void Update()
    {       

        if (Alive)
           myRigidbody.linearVelocity = UnityEngine.Vector2.down * 4;

    

    if (transform.position.y < deadzone)
    {
       // Destroy(gameObject);
       // if (BrickScript.lives == 3) {

       // }
    }

    

    }

    
    void OnCollisionEnter2D(Collision2D collision)

    {
        if (Alive) {
            if (GetComponent<SpriteRenderer>().sprite.name == "radish_0")
            {
                logic.addscore(1);
            }
            if (GetComponent<SpriteRenderer>().sprite.name == "Orange_0")
            {
                logic.addscore(2);
            }
            if (GetComponent<SpriteRenderer>().sprite.name == "pear2_0")
            {
                logic.addscore(3);
            }

            if (GetComponent<SpriteRenderer>().sprite.name == "banana2_0")
            {
                logic.addscore(4);
            }
            
        }
        Alive = false;
        boom.Play();
        
        Debug.Log("Brick Destroyed");
  
        myRigidbody.linearVelocity = UnityEngine.Vector2.up * 50;
        Destroy(gameObject, delay);
        
       

        
    }



   
}


