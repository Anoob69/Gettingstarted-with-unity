using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class rigi : MonoBehaviour
{
       Rigidbody rb;
   // public gameObject wintext;
    float xInput;
    float zInput;

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        //Destroy(gameObject,3f);

        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {

            // rb.AddForce(Vector3.up * 500);
        

            //Destroy(gameObject);
        }
     xInput = Input.GetAxis("Horizontal");
     zInput=Input.GetAxis("Vertical");
      

      rb.AddForce(xInput*speed,0,zInput * speed);
       // rb.velocity = Vector3.forward*20f;
    
      if(Input.GetKeyDown(KeyCode.R))
             {
        SceneManager.LoadScene("Level2");
             } 
    }

    private void OnMouseDown()
    {
        //Destroy(gameObject);
    }

   private void OnCollisionEnter(Collision collision)
   {
       if(collision.gameObject.tag == "enemy")
    {
        //Destroy(gameObject);
       
        //wintext.SetActive(true);
    }

   }

}
