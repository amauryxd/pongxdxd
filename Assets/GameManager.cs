using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TMP_Text barra1ScoreText;
    [SerializeField] private TMP_Text barra2ScoreText;

    [SerializeField] private Transform barra1Transform;
    [SerializeField] private Transform barra2Transform;
    [SerializeField] private Transform ballTransform;

    private int barra1Score;
    private int barra2Score;

    private static GameManager instance;

    public static GameManager Instance
    {
        get
        {
            if(instance == null)
            {
                instance = FindObjectOfType<GameManager>();
            }
            return instance;
        }
    }

    public void Barra1Scored()
    {
        barra1Score++;
        barra1ScoreText.text = barra1Score.ToString();
    }

    public void Barra2Scored()
    {
        barra2Score++;
        barra2ScoreText.text = barra2Score.ToString();
    }
    
    public void Restart()
    {
        barra1Transform.position = new Vector2(barra1Transform.position.x, 0);
        barra2Transform.position = new Vector2(barra2Transform.position.x, 0);
        ballTransform.position = new Vector2(0, 0);
    }
    

}
