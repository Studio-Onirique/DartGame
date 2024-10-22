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
            // Désactive le ballon
            gameObject.SetActive(false);
            // incrémente le score
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
