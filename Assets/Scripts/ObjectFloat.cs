//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;


//// https://youtu.be/eL_zHQEju8s
//// I followed this tutorial I order to get the Boat to float 
//public class ObjectFloat : MonoBehaviour
//{
//    public Rigidbody rigidBody;
//    public float depthBeforeSubmerged = 1f;
//    public float displacementAmount = 3f;
//    public int floaterCount = 1;
//    public float waterDrag = 0.99f;
//    public float waterAngularDrag = 0.5f;

    
//    private void FixedUpdate()
//    {
//        rigidBody.AddforceAtPosition(Physics.gravity / floaterCount, transform.position, forceMode.Acceleration);

//        float waveHeight = WaveManager.instance.GetwaveHeight(transform.position.x);
//        if (transform.position.y < waveHeight)
//        {
//            float displacementMultiplier = Mathf.Clamp01((waveHeight - transform.position.y) / depthBeforeSubmerged) * displacementAmount;
//            rigidBody.AddForceAtPosition(new Vector3(0f, Mathf.Abs(Physics.gravity.y) * displacementMultiplier, 0f), transform.position, ForceMode.Acceleration);
//            rigidBody.AddForce(displacementMultiplier * -rigidBody.velocity * waterDrag * Time.fixeddeltaTime, forceMode.VelocityChange);
//            rigidBody.AddTorque(displacementMultiplier * -rigidBody.angularVelocity * waterAngularDrag * Time.fixeddeltaTime, forceMode.VelocityChange);
//        }
        
//    }
//}
