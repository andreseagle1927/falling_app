using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class spawn : MonoBehaviour
{

    public GameObject obstacle1;
    public GameObject obstacle2;
    public GameObject obstacle3;
    public GameObject obstacle4;
    public GameObject obstacle5;
   

    public float maxX;
    public float minX;
    public float maxY;
    public float minY;
    public float timeAmongSpawn;
    private float spawnTime;

   
    // Start is called before the first frame update
    void Start()
    {
       
    }

    void Update()
    {
        if(Time.time > spawnTime)
        {
            int numerito = Random.Range(0,9);
            Spawn(numerito);
            spawnTime = Time.time + timeAmongSpawn;

        }

        

        
   
    }

    void Spawn(int num)
    {
        float randomX = Random.Range(minX,maxX);
        float randomY = Random.Range(minY,maxY);

        switch (num)
        {
            case 0:
                Instantiate(obstacle1, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
                break;
            case 1:
                Instantiate(obstacle2, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
                break;
            case 2:
                Instantiate(obstacle3, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
                break;
            case 3:
                Instantiate(obstacle4, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
                break;
            case 4:
                Instantiate(obstacle5, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
                break;
            case 5:
                Instantiate(obstacle3, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
                break;
            case 6:
                Instantiate(obstacle4, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
                break;
            case 7:
                Instantiate(obstacle3, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
                break;
            case 8:
                Instantiate(obstacle2, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
                break;
            case 9:
                Instantiate(obstacle5, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
                break;
            default:
                Instantiate(obstacle1, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
                break;
        }

        

    }

    
        
    
}
