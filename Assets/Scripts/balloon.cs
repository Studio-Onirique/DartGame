using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Oculus.Interaction;

public class balloon : MonoBehaviour
{
    float scoreLocal = GameManager.score;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "PikePike")
        {
            // D�sactive le ballon
            gameObject.SetActive(false);
            // incr�mente le score
            scoreLocal+= 1;
            GameManager.score = scoreLocal;
            print(GameManager.score);
            // actualise le canvas
            GameManager.ActualiserScore();
        }
    }
    void Update()
    {
        //print(scoreLocal);
    }
}
