using TMPro;
using UnityEngine;

public class RightBorder : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private TMP_Text player1ScoreText;
    private static int _player1Score = 0;
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
            Player1ScoreIncrease();
        }
    }

    private void Player1ScoreIncrease()
    {
        _player1Score++;
        player1ScoreText.text = _player1Score.ToString();
    }
}
