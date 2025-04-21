using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScoreText : BallEvents
{
    [SerializeField] private ScoresCollector scoresCollector;
    [SerializeField] private Text scoreText;
    [SerializeField] private Text highScoreText;

    protected override void OnBallCollisionSegment(SegmentType type)
    {
        if(type == SegmentType.Default || type == SegmentType.Finish)
        {
            scoreText.text = scoresCollector.Scores.ToString();
        }
        highScoreText.text = "High score: " + PlayerPrefs.GetInt("Hign Scores: hignScores").ToString();
    }
}
