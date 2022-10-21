using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{

    public Text rec;
    public Text Best;
    double score;


    float variable = 2;
    int record = 1 ;
    int tito;



    Rigidbody2D rb2d;
    float final=0;
    float derecha=1;
    float izquierda=2;
    float moveSpeed=2;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
       
        
    }

    // Update is called once per frame
    void Update()
    {
        score += variable* Time.deltaTime;
        tito = (int)Math.Ceiling(score);
        rec.text=tito.ToString();
        Best.text="BEST= "+GameManager.roof.record.ToString();

        if(tito>200){
           
            variable =  2.5f;
        }

        if(tito >GameManager.roof.record){
            record = tito;
            GameManager.roof.Record(record);
        } 

      


        
      if(Input. GetMouseButtonDown(0))
      {
        if(final == 2){
            final=derecha;

        }

        else if(final == 1){
            final=izquierda;
            
        }
        else{
            final=1;
        }


      }
    }

    private void FixedUpdate()
    {
        if( final == 1 )
        {
            rb2d.AddForce  (new Vector2(moveSpeed,-2),ForceMode2D.Impulse);
            
        }
        else if( final == 2  )
        {
          rb2d.AddForce  (new Vector2(-moveSpeed,-2),ForceMode2D.Impulse); 
          
        }
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(gameObject);
        GameManager.roof.Contador(1);
        Debug.Log(GameManager.roof.contador.ToString());
        //SceneManager.LoadScene("SampleScene");
    }
}
