using UnityEngine;

public class Camerefollow : MonoBehaviour
{
    public Transform target; // The target object to follow

    void LateUpdate()
    {

        // Set the camera's position to the target's position
        transform.position = target.position + new Vector3(0, 2, -5); // Adjust the offset as needed
        //transform.LookAt(target);

    }
}
