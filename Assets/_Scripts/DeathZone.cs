using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    public Transform startPos;
    public GameObject ballPrefab;
    public int opposingPlayer;
    public AudioClip outSound;


    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Ball"))
        {
            AudioSource.PlayClipAtPoint(outSound, other.transform.position, 1.0f);
            GameManager.AddScore(opposingPlayer);

            Destroy(other.gameObject);


           
        
                Instantiate(ballPrefab, startPos.position, Quaternion.identity);
           
        }
    }
}
