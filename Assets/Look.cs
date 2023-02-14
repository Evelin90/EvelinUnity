using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Look : MonoBehaviour
{
    [SerializeField] Transform target;

    
    void Update()
    {
        Vector3 targetPosition = target.position;
        Vector3 selfPostion = transform.position;

        Vector3 dir = targetPosition - selfPostion;


        transform.rotation = Quaternion.LookRotation( dir );
    }
}
