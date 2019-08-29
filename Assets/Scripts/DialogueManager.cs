using TMPro;
using UnityEngine;

public class DialogueManager : MonoBehaviour {
	[SerializeField] private TextMeshProUGUI Console = null, Chat = null;
	public static DialogueManager Instance;

    private AudioSource audioSource;

    private void Awake()
    {
        Instance = this;
        audioSource = gameObject.GetComponent<AudioSource>();
    }


    public void ConsoleAdd(string text) {
		Console.text += "\n" + text;
	}
	public void ChatAdd(string text) {
		Chat.text += "\n\n" + ">" + text;
        audioSource.Play();
	}

}
