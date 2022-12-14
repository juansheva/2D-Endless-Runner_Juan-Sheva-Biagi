using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainTemplateController : MonoBehaviour
{
    private const float debugLineHeight = 10.0f;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
    }

    private void OnDrawGizmos()
    {
        Debug.DrawLine(transform.position + Vector3.up * debugLineHeight / 2, transform.position + Vector3.down * debugLineHeight / 2, Color.green);
    }
}