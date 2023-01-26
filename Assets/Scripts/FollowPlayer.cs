using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 postLerp;
    public float rotateLerp;

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + postLerp;
        //transform.position = Vector3.Lerp(transform.position, player.position, postLerp);
        transform.rotation = Quaternion.Lerp(transform.rotation, player.rotation, rotateLerp);
    }
}
