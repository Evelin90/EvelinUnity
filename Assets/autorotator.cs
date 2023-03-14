
using UnityEngine;

class autorotator : MonoBehaviour
{
    [SerelaizeField] float angularVelocity = 360;
    [SerelaizeField] Vector3 axis = Vector3.up;
    [SerelaizeField] Space rotationSpace;

    void Update()
    {
       // Vector3 euler = new Vector3(0, angularVelocity,0);
        //euler *= Time.deltaTime;
        transform.Rotate(axis, angularVelocity * Time.deltaTime, rotationSpace);
    }

    void OnDrawGizmo()
    {
        Vector3 center = tarnsform.position;

        Vector3 dir;
        if (rotationSpace == rotationSpace.World)
        { 
            dir = axis.normalized;
        }
        else 
        {
            dir = transform.TransformDirection(axis).normalized;
        }

        Vector3 a = center + dir * 2;
        Vector3 b = center - dir * 2;

        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(a,b);

    }
}
