using System;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Player")
        {
            GameManager.isGameOver = true;
            gameObject.SetActive(false);
        }
        else if (collision.transform.tag == "Enemy")
            {
                GameManager.isGameOver = true;
                gameObject.SetActive(false);
            }
    }
}
