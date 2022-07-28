
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    private float horizInput;
    private float vertInput;
    private bool isBreaking = true;
    private float currentbreakForce;
    private float currentSteerAngle;

    [SerializeField] private float motorForce;
    [SerializeField] private float breakForce;
    [SerializeField] private float maxSteerAngle;

    [SerializeField] private WheelCollider frontLeftWheelCollider;
    [SerializeField] private WheelCollider frontRightWheelCollider;
    [SerializeField] private WheelCollider rearLeftWheelCollider;
    [SerializeField] private WheelCollider rearRightWheelCollider;

    [SerializeField] private Transform frontLeftWheelTransform;
    [SerializeField] private Transform frontRightWheelTransform;
    [SerializeField] private Transform rearLeftWheelTransform;
    [SerializeField] private Transform rearRightWheelTransform;

    private void FixedUpdate(){
        GetInput();
        HandleMotor();
        HandleSteering();
        UpdateWheels();
    }

    private void HandleMotor(){
        frontLeftWheelCollider.motorTorque = vertInput * motorForce;
        frontRightWheelCollider.motorTorque = vertInput * motorForce;
        currentbreakForce = isBreaking ? breakForce : 0f;
        if(isBreaking){
            ApplyBreaking();
        }
    }

    private void ApplyBreaking(){
        frontLeftWheelCollider.brakeTorque = currentbreakForce;
        frontRightWheelCollider.brakeTorque = currentbreakForce;
        rearLeftWheelCollider.brakeTorque = currentbreakForce;
        rearRightWheelCollider.brakeTorque = currentbreakForce;
    }

    private void GetInput(){
        horizInput = Input.GetAxis("Horizontal");
        vertInput = Input.GetAxis("Vertical");
        isBreaking = Input.GetKey(KeyCode.Space);
    }

    private void HandleSteering(){
        currentSteerAngle = maxSteerAngle * horizInput;
        frontLeftWheelCollider.steerAngle = currentSteerAngle;
        frontRightWheelCollider.steerAngle = currentSteerAngle;
    }

    private void UpdateWheels(){
        UpdateSingleWheel(frontLeftWheelCollider,frontLeftWheelTransform);
        UpdateSingleWheel(frontRightWheelCollider,frontRightWheelTransform);
        UpdateSingleWheel(rearRightWheelCollider,rearRightWheelTransform);
        UpdateSingleWheel(rearLeftWheelCollider,rearLeftWheelTransform);
    }

    private void UpdateSingleWheel(WheelCollider wheelCollider, Transform wheelTransform){
        Vector3 pos;
        Quaternion rot;
        wheelCollider.GetWorldPose(out pos, out rot);
        wheelTransform.rotation = rot;
        wheelTransform.position = pos;
    }
}
