using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalCamera : MonoBehaviour
{
    public Transform playerCam;
    public Transform portal_1;
    public Transform portal_2;



    // Update is called once per frame
    void Update()
    {
        Vector3 playerOffsetFromPortal = playerCam.position - portal_2.position;
        transform.position = portal_1.position + playerOffsetFromPortal;

        float angluarDifferanceBetweenPortalRotations = Quaternion.Angle(portal_1.rotation, portal_2.rotation);

        Quaternion portalRotationalDiffernce = Quaternion.AngleAxis(angluarDifferanceBetweenPortalRotations, Vector3.up);
        Vector3 newCameraDirection = portalRotationalDiffernce * playerCam.forward;
        transform.rotation = Quaternion.LookRotation(newCameraDirection, Vector3.up);

    }
}
