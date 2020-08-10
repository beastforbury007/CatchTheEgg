using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EggController : MonoBehaviour
{
   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag.Equals("Basket"))
        {
            ScoreManager.score += 2;
            if(ScoreManager.score==20)
            {
                SceneManager.LoadScene(2);
            }
            Destroy(this.gameObject);
        
        }

        if(collision.gameObject.CompareTag("Destroy"))
        {
            Destroy(this.gameObject);
        }
        
    }
}
