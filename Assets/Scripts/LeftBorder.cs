using System;
using TMPro;
using UnityEngine;

public class LeftBorder : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private TMP_Text player2ScoreText;
    private static int _player2Score = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            Player2ScoreIncrease();
        }
    }

    private void Player2ScoreIncrease()
    {
        _player2Score++;
        player2ScoreText.text = _player2Score.ToString();
    }
}
