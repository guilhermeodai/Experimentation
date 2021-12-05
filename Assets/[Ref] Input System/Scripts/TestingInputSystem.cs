using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

// https://www.youtube.com/watch?v=Yjee_e4fICc
public class TestingInputSystem : MonoBehaviour
{
	Rigidbody sphereRigidbody;

	PlayerInput playerInput;
	PlayerInputActions playerInputActions;
	float speed = 5f;

	// Start is called before the first frame update
	void Awake ()
	{
		sphereRigidbody = GetComponent<Rigidbody> ();
		playerInput = GetComponent<PlayerInput> ();

		// This uses the Unity generated C# class from the InputActions asset instead of the PlayerInput component
		playerInputActions = new PlayerInputActions ();
		//playerInputActions.Player.Enable ();
		//playerInputActions.Player.Jump.performed += Jump;
		//playerInputActions.UI.Enable ();
		//playerInputActions.UI.Submit.performed += Submit;
	}

	void Update ()
	{
		if (Keyboard.current.tKey.wasPressedThisFrame)
		{
			// If using the PlayerInput component
			playerInput.SwitchCurrentActionMap ("UI");
			
			// If using C# to subscribe
			playerInputActions.Player.Disable ();
			playerInputActions.UI.Enable ();
		}
		if (Keyboard.current.yKey.wasPressedThisFrame)
		{
			// If using the PlayerInput component
			playerInput.SwitchCurrentActionMap ("Player");
			
			// If using C# to subscribe
			playerInputActions.UI.Disable ();
			playerInputActions.Player.Enable ();
		}
	}

	// For movement, this would probably be preferable
	// Warning: if Project Settings > Input System Package > Update Mode is set to Dynamic Update, this won't work because it's on FixedUpdate
	void FixedUpdate () {
		Vector2 inputVector = playerInputActions.Player.Movement.ReadValue<Vector2> ();
		Debug.Log (inputVector);
		sphereRigidbody.AddForce (new Vector3 (inputVector.x, 0f, inputVector.y) * speed, ForceMode.Force);
	}

	// This example uses Unity events. It can be called directly on the PlayerInput component or by subscribing to it on Awake ()
	// Callback Context contains data on the button phases: Started / Performed / Canceled
	public void Jump (InputAction.CallbackContext context)
	{
		Debug.Log (context);
		if (context.performed)
		{
			Debug.Log ("Jump! " + context.phase);
			sphereRigidbody.AddForce (Vector3.up * 5f, ForceMode.Impulse);
		}
	}

	public void Submit (InputAction.CallbackContext context)
	{
		Debug.Log (context);
	}
}
