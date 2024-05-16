using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class CharacterMovementHelper : MonoBehaviour
{

    private CharacterController CharacterController;
    private XRRig XRRig;
    private CharacterControllerDriver driver;
    // Start is called before the first frame update
    void Start()
    {
        XRRig = GetComponent<XRRig>();
        CharacterController = GetComponent<CharacterController>();
        driver = GetComponent<CharacterControllerDriver>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateCharacterController();
    }


    protected virtual void UpdateCharacterController()
    {
        if (XRRig == null || CharacterController == null)
            return;

        var height = Mathf.Clamp(XRRig.CameraInOriginSpaceHeight, driver.minHeight, driver.maxHeight);

        Vector3 center = XRRig.CameraInOriginSpacePos;
        center.y = height / 2f + CharacterController.skinWidth;

        CharacterController.height = height;
        CharacterController.center = center;
    }
}


