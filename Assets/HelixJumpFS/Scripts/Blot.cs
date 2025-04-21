using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blot : MonoBehaviour
{
    [SerializeField] private float offSet;
    [SerializeField] private SpriteRenderer spriteRenderer;

    public void Init(Vector3 position, Color color)
    {
        spriteRenderer.color = color;

        transform.position = position + new Vector3(0,offSet,0); 
        transform.eulerAngles = new Vector3(0, Random.RandomRange(0, 360), 0);
    }
}
