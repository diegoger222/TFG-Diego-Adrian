using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    private Vector2 size, startPos;
    private Transform cam;
    public Vector2 parallaxFraction;
    void Start()
    {
        startPos = transform.position;
        size = GetComponent<SpriteRenderer>().bounds.size;
        cam = Camera.main.transform;
    }
    void FixedUpdate()
    {
        Vector2 offset = (cam.position * parallaxFraction);
        Vector2 temp = new Vector2(cam.position.x, cam.position.y) - offset;
        if (temp.x > startPos.x + size.x) startPos.x += size.x;
        else if (temp.x < startPos.x - size.x) startPos.x -= size.x;
        if (parallaxFraction.y > 0f && temp.y > startPos.y + size.y)
            startPos.y += size.y;
        else if (parallaxFraction.y > 0f && temp.y < startPos.y - size.y) startPos.y -= size.y;
        transform.position = new Vector3(startPos.x + offset.x, startPos.y + offset.y,
        transform.position.z);
    }

}
