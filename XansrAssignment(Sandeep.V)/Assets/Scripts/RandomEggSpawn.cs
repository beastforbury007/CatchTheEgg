using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class RandomEggSpawn : MonoBehaviour
{
    private int randomid;
    Transform spawnpos;
    public GameObject egg;
    private int min = 1, max =4;
    public Transform pos1,pos2,pos3;


    private float nexteggtime = 0.0f;
    private float spawnrate = 1.5f;

 
    void Update()
    {
       if(nexteggtime<Time.time)
       {
            SpawnEgg();
            nexteggtime = Time.time + spawnrate;
            spawnrate *= 0.98f;
            spawnrate = Mathf.Clamp(spawnrate, 0.3f, 5f);
       }
       
    }



  public void SpawnEgg()
    {
       
        randomid = Random.Range(min, max);
        switch(randomid)
        {
            case 1: 
                Instantiate(egg, pos1);
                     break;

            case 2:
                     
                Instantiate(egg, pos2);
                break;

            case 3:
                     
                Instantiate(egg, pos3);
                     break;

            default:
                        UnityEngine.Debug.Log("Unknown ID");
                          break;

        }
       
        
    }
    
}
