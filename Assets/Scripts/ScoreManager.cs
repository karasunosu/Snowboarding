using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    Controller controller;
    [SerializeField] TextMeshProUGUI scoreText;

    float totalRotation = 0f;
    float preRotation = 0f;
    int score = 0;

    void Start()
    {
        controller = GetComponent<Controller>();
    }

    void Update()
    {
        scoreText.SetText("Score: " + score);
    }

    public void CalculateFlips()
    {
        float curRotation = transform.rotation.eulerAngles.z;
        totalRotation += Mathf.DeltaAngle(preRotation, curRotation);

        if(totalRotation > 340 || totalRotation < -340)
        {
            AddScore(100);
            totalRotation = 0f;
        }

        preRotation = curRotation;
    }

    public void AddScore(int addScore)
    {
        score += addScore;
    }
}
