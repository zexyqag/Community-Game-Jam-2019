using RotaryHeart.Lib.SerializableDictionary;
using UnityEngine;

[System.Serializable]
public class ControlsDictionary : SerializableDictionaryBase<ControllKeysEnum, KeyCode> { }
public enum ControllKeysEnum { UpButton, LeftButton, DownButton, RightButton, UpButtonAlt, LeftButtonAlt, DownButtonAlt, RightButtonAlt, JumpButton};