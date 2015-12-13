using UnityEngine;
using UnitySampleAssets.CrossPlatformInput;

namespace UnitySampleAssets._2D
{

	[RequireComponent(typeof (PlatformerKitty2D))]
	public class PlatformerKittyUserControl : MonoBehaviour
	{
		private PlatformerKitty2D character;
		private bool jump;

		private void Awake()
		{
			character = GetComponent<PlatformerKitty2D>();
		}

		private void Update()
		{
			if(!jump)
				// Read the jump input in Update so button presses aren't missed.
				jump = CrossPlatformInputManager.GetButtonDown("Jump");
		}

		private void FixedUpdate()
		{
			// We don't need these. We want permanent movement forward
			// Read the inputs.
			//bool crouch = Input.GetKey(KeyCode.LeftControl);
			//float h = CrossPlatformInputManager.GetAxis("Horizontal");


			// Pass all parameters to the character control script.
			character.Move(1, false, jump);
			jump = false;
		}
	}
}