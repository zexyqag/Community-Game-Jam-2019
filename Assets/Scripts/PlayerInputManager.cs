using UnityEngine;

public class PlayerInputManager : MonoBehaviour {
	public static PlayerInputManager Instance { get; private set; }

	[Header("Movemnt keys")]
	[SerializeField] private KeyCode UpButton;
	[SerializeField] private KeyCode LeftButton, DownButton, RightButton;
	[Header("Movemnt keys alternative")]
	[SerializeField] private KeyCode UpButtonAlt;
	[SerializeField] private KeyCode LeftButtonAlt, DownButtonAlt, RightButtonAlt;
	[Header("Other keys")]
	[SerializeField] private KeyCode JumpButton;



	public Vector2 direction { get; private set; }
	public bool JumpDown { get; private set; }
	public bool Jump { get; private set; }
	public bool JumpUp { get; private set; }

	private void Awake() {
		Instance = this;
	}


	private void Update() {

		direction = new Vector2((Input.GetKey(RightButton) || Input.GetKey(RightButtonAlt) ? 1 : 0) - (Input.GetKey(LeftButton) || Input.GetKey(LeftButtonAlt) ? 1 : 0), (Input.GetKey(UpButton) || Input.GetKey(UpButtonAlt) ? 1 : 0) - (Input.GetKey(DownButton) || Input.GetKey(DownButtonAlt) ? 1 : 0));

		JumpDown = Input.GetKeyDown(JumpButton);
		Jump = Input.GetKey(JumpButton);
		JumpUp = Input.GetKeyUp(JumpButton);
	}



}
