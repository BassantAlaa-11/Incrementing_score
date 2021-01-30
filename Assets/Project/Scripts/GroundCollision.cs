using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GroundCollision : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public Text scoreText;
    public int score;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "EmptyCube")
        {
            Destroy(collision.gameObject);
            score++;
            scoreText.text = score.ToString();
        }
    }
}
