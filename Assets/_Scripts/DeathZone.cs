using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    public Transform startPos;
    public GameObject ballprefab;
    public int opposingPlayer;
    public AudioClip outSound;


    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Ball"))
        {
            AudioSource.PlayClipAtPoint(outSound, other.transform.position, 1.0f);
            GameManager.AddScore(opposingPlayer);

            Destroy(other.gameObject);


             if (GameManager.playing == true)
            {
                Instantiate(ballprefab, startPos.position, Quaternion.identity);
            }
        }
    }
}
