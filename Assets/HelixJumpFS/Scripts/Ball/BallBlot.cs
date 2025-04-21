using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBlot : BallEvents
{
    [SerializeField] private Transform parentTransform;
    [SerializeField] private MeshRenderer visualModel;
    [SerializeField] private Blot blotPrefab;
    

    protected override void OnBallCollisionSegment(SegmentType type)
    {
        if(type != SegmentType.Empty)
        {
            Blot blot = Instantiate(blotPrefab, parentTransform);
            blot.Init(new Vector3(visualModel.transform.position.x, transform.position.y, visualModel.transform.position.z),visualModel.material.color);

        }
    }
}
