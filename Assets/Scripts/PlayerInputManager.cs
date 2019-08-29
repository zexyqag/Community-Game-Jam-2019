using UnityEngine;

public class PlayerInputManager : MonoBehaviour {
	public static PlayerInputManager Instance { get; private set; }


	[SerializeField] private ControlsDictionary controlsDictionary = null;

	public Vector2 Direction { get; private set; }
	public bool JumpDown { get; private set; }
	public bool Jump { get; private set; }
	public bool JumpUp { get; private set; }
	public bool Shoot { get; private set; }

	private void Awake() {
		Instance = this;
	}


	private void Update() {
		Direction = new Vector2((Input.GetKey(controlsDictionary[ControllKeysEnum.RightButton]) || Input.GetKey(controlsDictionary[ControllKeysEnum.RightButtonAlt]) ? 1 : 0) -
		(Input.GetKey(controlsDictionary[ControllKeysEnum.LeftButton]) || Input.GetKey(controlsDictionary[ControllKeysEnum.LeftButtonAlt]) ? 1 : 0),
		(Input.GetKey(controlsDictionary[ControllKeysEnum.UpButton]) || Input.GetKey(controlsDictionary[ControllKeysEnum.UpButtonAlt]) ? 1 : 0) -
		(Input.GetKey(controlsDictionary[ControllKeysEnum.DownButton]) || Input.GetKey(controlsDictionary[ControllKeysEnum.DownButtonAlt]) ? 1 : 0));


		JumpDown = Input.GetKeyDown(controlsDictionary[ControllKeysEnum.JumpButton]);
		Jump = Input.GetKey(controlsDictionary[ControllKeysEnum.JumpButton]);
		JumpUp = Input.GetKeyUp(controlsDictionary[ControllKeysEnum.JumpButton]);
	}

	public void SetControlsDictionary(ControlsDictionary controlsDictionary) {
		if(controlsDictionary != null) {
			foreach(var item in controlsDictionary) {
				this.controlsDictionary[item.Key] = item.Value;
			}
		}
	}

}

