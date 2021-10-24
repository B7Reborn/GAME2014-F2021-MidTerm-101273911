/*
 * Full Name        : Shane Holloway
 * Student ID       : 101273911
 * Date Modified    : October 23, 2021
 * File             : BackgroundController.cs
 * Description      : Handles background scrolling, including speed and boundaries
 * Revision History : V 1.0 - Initial change from vertical scrolling to horizontal scrolling
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    public float horizontalSpeed;
    public float horizontalBoundary;

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    private void _Reset()
    {
        transform.position = new Vector3(horizontalBoundary, 0.0f);
    }

    private void _Move()
    {
        transform.position -= new Vector3(horizontalSpeed, 0.0f) * Time.deltaTime;
    }

    private void _CheckBounds()
    {
        // if the background is lower than the bottom of the screen then reset
        if (transform.position.x <= -horizontalBoundary)
        {
            _Reset();
        }
    }
}