using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class SnapToGrid : MonoBehaviour
{
    [SerializeField] [Range(1,30)] int Size; // Size of a grid
    void Update()
    {
        Vector3 SnapPos;
        SnapPos.x = Mathf.RoundToInt(transform.position.x / Size) * Size;
        SnapPos.y = 0;
        SnapPos.z = Mathf.RoundToInt(transform.position.z / Size) * Size;
        transform.position = SnapPos;
    }
}
