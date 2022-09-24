using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float Parallax = 1.5f;

    // Update is called once per frame
    void FixedUpdate()
    {
        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
        Material Material = meshRenderer.material;
        Vector2 offset = Material.mainTextureOffset;

        offset.x = transform.position.x / transform.localScale.x / Parallax;
        offset.y = transform.position.y / transform.localScale.y / Parallax;

        Material.mainTextureOffset = offset;
    }
}
