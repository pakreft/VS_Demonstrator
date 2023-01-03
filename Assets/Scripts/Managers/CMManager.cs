using Cinemachine;
using UnityEngine;

[DisallowMultipleComponent]
public class CMManager : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;

    [SerializeField] private CinemachineVirtualCamera[] vCams;

}
