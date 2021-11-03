using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

// i can now reach input classes to conect my own input actions
public class HandsControllerScript : MonoBehaviour
{
    // Serializefield can see these refs in the inspector now without making them public and  I can assign custom actions
    [SerializeField] InputActionReference gripInputAction;
    [SerializeField] InputActionReference triggerInputAction;

    //private animator ref
    Animator handAnimator;

    // awake method for unity's default start but its called before the start method
    private void Awake()
    {
        handAnimator = GetComponent<Animator>();
    }

    // default onEnable / disable methods for call backs
    private void OnEnable()
    {
        gripInputAction.action.performed += GripPressed;
        triggerInputAction.action.performed += TriggerPressed;

    }
    // now i can read and listen for the input values from grip/trigger buttons-also need to pass float values to animator and set to specific params

    private void TriggerPressed(InputAction.CallbackContext obj)
    {
        handAnimator.SetFloat("Trigger", obj.ReadValue<float>());
        //throw new NotImplementedException();
    }

    private void GripPressed(InputAction.CallbackContext obj)
    {
        handAnimator.SetFloat("Grip", obj.ReadValue<float>());
        //throw new NotImplementedException();
    }

    // when i exit the game it will stop listening to input actions

    private void OnDisable()
    {
        gripInputAction.action.performed -= GripPressed;
        triggerInputAction.action.performed -= TriggerPressed;
    }
}