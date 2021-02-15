using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
public class PickUpcontroller : MonoBehaviour
{
    public ProjectileGun gunScript;
    public Rigidbody rb;
    public BoxCollider coll;
    public Transform player, gunContainer, fpsCam;

    public float pickUpRange;
    public float dropForwardForce, dropUpwardForce;

    public bool equipped;
    public static bool slotFull;

    private void Update()
    {
         
        //Check if player is in range and "E" is pressed
        Vector3 distanceToPlayer = player.position - transform.position;
        if (!equipped && distanceToPlayer.magnitude <= pickUpRange && Input.GetKeyDown(KeyCode.E) && !slotFull) PickUp();

        //Drop if equipped and "Q" is pressed
        if (equipped && Input.GetKeyDown(KeyCode.Q)) Drop();
    }

    public void PickUp()
    {
        equipped = true;
        slotFull = true;

        //Make Rigidbody kinematic and BoxxCollider a trigger
        rb.isKinematic = true;
        coll.isTrigger = true;

        //Enable Script
        gunScript.enable = true;
    }

    public void Drop()
    {
        equipped = false;
        slotFull = false;

        //Make Rigidbody not kinematic and BoxxCollider a trigger
        rb.isKinematic = false;
        coll.isTrigger = false;

        //Disable Script
        gunScript.enable = false;
    }
}
*/