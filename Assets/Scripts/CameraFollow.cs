using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform followObject;

    // Update is called once per frame
    private void Update()
    {
        transform.position = followObject.position + new Vector3(0, 2, -5);
        transform.LookAt(followObject);
    }
}