using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum SegmentType
{
    Default,
    Trap,
    Empty,
    Finish
}
[RequireComponent(typeof(MeshRenderer))]
public class Segments : MonoBehaviour
{
    [SerializeField] public Material TrapMaterial;
    [SerializeField] public Material FinishMaterial;
    [SerializeField] public Material DefaultMaterial;

    [SerializeField] private SegmentType type;

    public SegmentType Type => type;

    private MeshRenderer meshRenderer;

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();   
    }
    public void SetTrap()
    {
        meshRenderer.enabled = true;
        meshRenderer.material = TrapMaterial;
        
        type = SegmentType.Trap;
    }
    public void SetEmpty()
    {
        meshRenderer.enabled = false;

        type = SegmentType.Empty;
    }
    public void SetFinish()
    {
        meshRenderer.enabled = true;
        meshRenderer.material = FinishMaterial;

        type = SegmentType.Finish;
    }
    
}
