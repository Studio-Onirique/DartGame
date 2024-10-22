using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{   
    //DARTS
    public GameObject[] darts; // tableau contenant les darts à lancer
    public Vector3[] positionInitialeDarts; // position initiale de ces darts
    Quaternion rotationInitialeDarts; // orientation par défaut
    Vector3 anglesEulerDarts; // pour calculer la rotation

    //BALLONS
    public GameObject[] ballons; // tableau contenant les ballons à éclater
    public Vector3[] positionInitialeBallons; // position initiale de ces ballons
    Quaternion rotationInitialeBallons;
    Vector3 anglesEulerBallons; // pour calculer la rotation

    //SONS
    public AudioSource sourceAudio; // pour les sfx

    //SCORE
    public static float score = 0;
    public TextMeshProUGUI texte; // le canvas avec le score

    // Start is called before the first frame update
    void Start()
    {
        // DARTS
        // Enregistrer la rotation initiale
        anglesEulerDarts = new Vector3(90f, 180f, 0f);
        rotationInitialeDarts.eulerAngles = anglesEulerDarts;
        // Enregistrement de la position initiale des darts
        for(int i = 0; i < darts.Length; i++) {
            positionInitialeDarts[i] = new Vector3(
                darts[i].transform.position.x,
                darts[i].transform.position.y,
                darts[i].transform.position.z
            );
        }

        // BALLONS
        // Enregistrer la rotation initiale
        anglesEulerBallons = new Vector3(0f, 180f, Random.Range(-10f, 10f));
        rotationInitialeBallons.eulerAngles = anglesEulerBallons;
        // Enregistrement de la position initiale des ballons
        for (int i = 0; i < ballons.Length; i++)
        {
            positionInitialeBallons[i] = new Vector3(
                ballons[i].transform.position.x,
                ballons[i].transform.position.y,
                ballons[i].transform.position.z
            );
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Replace les darts et les ballons lorsque le joueur appuie sur le bouton RESET
    public void RespawnDarts() {
        for(int i = 0; i < darts.Length; i++) {
            //SONS
            sourceAudio.time = 0.6f;
            sourceAudio.enabled = true;
            Invoke("DesactiverSourceAudio", 0.8f);
            //DARTS
            darts[i].transform.position = positionInitialeDarts[i];
            darts[i].transform.rotation = rotationInitialeDarts;
            //BALLONS
            ballons[i].transform.position = positionInitialeBallons[i];
            // Enregistrer une nouvelle rotation aléatoire
            anglesEulerBallons = new Vector3(0f, 180f, Random.Range(-10f, 10f));
            rotationInitialeBallons.eulerAngles = anglesEulerBallons;
            ballons[i].transform.rotation = rotationInitialeBallons;
            ballons[i].SetActive(true);
        }
    }
    void DesactiverSourceAudio() {
        sourceAudio.enabled = false;
    }
    public static void ActualiserScore() {
        //texte.text = "Test";
        print("allo!!!");
    }
}
