using Cinemachine;
using UnityEngine;

[System.Serializable]
public struct Event
{
    [SerializeField] internal GameObject go;
    [SerializeField] internal string instructionText;
    [SerializeField] internal string hintText;
    [SerializeField] internal bool mistakeMade;
    [SerializeField] internal CinemachineVirtualCamera vCam;
}