using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Mover : MonoBehaviour
{
    /*[SerializeField] Vector3 velocity;

    void Start()
    {
        Vector2 v2a = new Vector2(1, 4);
        Vector3 v3a = new Vector3(4, 5, 7.545f);

        float f1 = v2a.x;
        float f2 = v3a.z;

        Transform t = transform;

        t.position = v3a;

    }
*/

    [SerializeField] float speed = 5;
    void Update()
    {
        bool up = Input.GetKey(KeyCode.UpArrow) ||  Input.GetKey(KeyCode.W);
        bool down = Input.GetKey(KeyCode.DownArrow);
        bool right = Input.GetKey(KeyCode.RightArrow);
        bool left = Input.GetKey(KeyCode.LeftArrow);

        float y = 0;
        if (up && down)
            y = 0;
        else if (up)
            y = 1;
        else if (down)
            y = -1;

        float x = 0;
        if(right)
            x += 1;
        if (left)
            x -= 1;



        Vector3 velocity = new Vector3(x, 0, y);

        velocity.Normalize();

        velocity *= speed;

        Vector3 p = transform.position;

        Vector3 newPos = p + (velocity * Time.deltaTime);
      
        transform.position = newPos;

        if(velocity != Vector3.zero)
            transform.rotation = Quaternion.LookRotation(velocity);
    }
}
