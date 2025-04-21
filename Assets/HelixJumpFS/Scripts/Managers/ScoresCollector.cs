using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoresCollector : BallEvents
{
    [SerializeField] private LevelProgress levelProgress;
    [SerializeField] private int scores;
    [SerializeField] private int highScores;
    public int Scores => scores;
    public int HighScores => highScores;

    protected override void OnBallCollisionSegment(SegmentType type)
    {
        if(type == SegmentType.Empty)
        {
            scores += levelProgress.CurrentLevel;
        }
        if (type == SegmentType.Finish && scores >= highScores)
        {
            highScores = scores;
            PlayerPrefs.SetInt("Hign Scores: hignScores", highScores);
        }
    }
}
