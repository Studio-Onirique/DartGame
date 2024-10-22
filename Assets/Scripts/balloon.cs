using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Oculus.Interaction;

public class balloon : MonoBehaviour
{
    public AudioClip sonPop;
    public GameManager gameManager;
    public AudioSource audioSource;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "PikePike")
        {
            GameManager.score++;
            // actualise le canvas
            gameManager.ActualiserScore();

            audioSource.PlayOneShot(sonPop, 1f);

            // Désactive le ballon
            gameObject.SetActive(false);
        }
    }
    void Update()
    {
        //print(scoreLocal);
    }
}
