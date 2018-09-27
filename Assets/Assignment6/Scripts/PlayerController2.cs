using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController2 : MonoBehaviour {

    public float speed;
    public Text scoreText;
    public Text winText;

    private int score;
    private int count1;
    private int count2;
    private Rigidbody2D rb;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        score = 0;
        count1 = 0;
        count2 = 0;
        winText.text = "";
        SetScoreText();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        rb.AddForce(movement * speed);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PickUp1"))
        {
            other.gameObject.SetActive(false);
            count1 = count1 + 1;
            score = score + 1;
            SetScoreText();
        }
        else if (other.gameObject.CompareTag("PickUp2"))
        {
            other.gameObject.SetActive(false);
            count2 = count2 + 1;
            score = score + 5;
            SetScoreText();
        }
    }

    void SetScoreText()
    {
        scoreText.text = "Score :" + score.ToString() + "\nPickUp 1 :" + count1.ToString() + "\nPickUp 2 :" + count2.ToString();
        if (score >= 26)
        {
            winText.text = "You win!";
        }
    }
}
