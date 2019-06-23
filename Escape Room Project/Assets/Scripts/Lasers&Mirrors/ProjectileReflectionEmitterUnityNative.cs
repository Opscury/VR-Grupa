﻿using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

/*
 * Projectile reflection demonstration in Unity 3D
 * 
 * Demonstrates a projectile reflecting in 3D space a variable number of times.
 * Reflections are calculated using Raycast's and Vector3.Reflect
 * 
 * Developed on World of Zero: https://youtu.be/GttdLYKEJAM
 */
public class ProjectileReflectionEmitterUnityNative : MonoBehaviour
{
    public int maxReflectionCount = 5;
    public float maxStepDistance = 200;
    bool isHit = false;
    bool isStopped = false;

    void OnDrawGizmos()
    {
        Handles.color = Color.red;
        Handles.ArrowHandleCap(0, this.transform.position + this.transform.forward * 0.25f, this.transform.rotation, 0.5f, EventType.Repaint);
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(this.transform.position, 0.25f);

        DrawPredictedReflectionPattern(this.transform.position + this.transform.forward * 0.75f, this.transform.forward, maxReflectionCount);
    }

    private void DrawPredictedReflectionPattern(Vector3 position, Vector3 direction, int reflectionsRemaining)
    {
        if (reflectionsRemaining == 0)
        {
            return;
        }

        Vector3 startingPosition = position;

        Ray ray = new Ray(position, direction);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, maxStepDistance))
        {
            if (hit.collider.tag == "LaserTarget")
            {
                isHit = true;
            } else
            {
                isHit = false;
            }
            if (hit.collider.tag != "Mirror")
            {
                isStopped = true;
            } else
            {
                isStopped = false;
            }

            direction = Vector3.Reflect(direction, hit.normal);
            position = hit.point;

        }
        else
        {
            position += direction * maxStepDistance;
        }


        Gizmos.color = Color.blue;
        Gizmos.DrawLine(startingPosition, position);

        if(isHit == true)
        {
            Debug.Log("HitTarget");
            DrawPredictedReflectionPattern(position, direction, 0);
        } else if (isStopped == true)
        {
            DrawPredictedReflectionPattern(position, direction, 0);
        } else
        {
            DrawPredictedReflectionPattern(position, direction, reflectionsRemaining - 1);

        }
        

    }
}