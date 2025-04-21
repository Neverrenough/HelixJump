using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomChangeMaterial : Segments
{
    [SerializeField] private MeshRenderer AxisMeshRenderer;
    [SerializeField] private List<Color> listColorAxis = new List<Color>();

    [SerializeField] public List<Color> listColorFinishSegment = new List<Color>();
    [SerializeField] public List<Color> listColorTrapSegment = new List<Color>();
    [SerializeField] public List<Color> listColorDefaultSegment = new List<Color>();

    [SerializeField] private MeshRenderer ballMeshRenderer;
    [SerializeField] public List<Color> listColorBall = new List<Color>();

    private void Start()
    {
        if (AxisMeshRenderer != null)
        {
            int randomInt = Random.Range(0, listColorAxis.Count);
            AxisMeshRenderer.material.color = listColorAxis[randomInt];
            ballMeshRenderer.material.color = listColorBall[randomInt];

            DefaultMaterial.color = listColorDefaultSegment[randomInt];
            TrapMaterial.color = listColorTrapSegment[randomInt];
            FinishMaterial.color = listColorFinishSegment[randomInt];
        }
    }
}
