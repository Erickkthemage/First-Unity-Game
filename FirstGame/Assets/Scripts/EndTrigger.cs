using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
    public Transform player;

    private int finalScore;
   void OnTriggerEnter ()
    {
        finalScore = ((int)player.position.z);
        gameManager.CompleteLevel(finalScore);
    }
}
