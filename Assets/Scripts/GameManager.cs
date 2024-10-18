using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] darts; // tableau contenant les darts à lancer
    public Vector3[] positionInitiale; // position initiale de ces darts
    Quaternion rotationInitiale; // orientation par défaut
    Vector3 anglesEuler; // pour calculer la rotation
    public AudioSource sourceAudio; // pour les sfx

    // Start is called before the first frame update
    void Start()
    {
        // Enregistrer la rotation initiale
        anglesEuler = new Vector3(90f, 180f, 0f);
        rotationInitiale.eulerAngles = anglesEuler;
        // Enregistrement de la position initiale des darts
        for(int i = 0; i < darts.Length; i++) {
            positionInitiale[i] = new Vector3(
                darts[i].transform.position.x,
                darts[i].transform.position.y,
                darts[i].transform.position.z
            );
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Replace les darts lorsque le joueur appuie sur le bouton RESET
    public void RespawnDarts() {
        for(int i = 0; i < darts.Length; i++) {
            sourceAudio.time = 0.6f;
            sourceAudio.enabled = true;
            darts[i].transform.position = positionInitiale[i];
            darts[i].transform.rotation = rotationInitiale;
            Invoke("DesactiverSourceAudio", 0.8f);
        }
    }
    void DesactiverSourceAudio() {
        sourceAudio.enabled = false;
    }
    public void ActualiserScore() {

    }
}
