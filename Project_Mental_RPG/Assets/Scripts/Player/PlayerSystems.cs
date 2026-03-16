using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.Rendering.VirtualTexturing;

public class PlayerSystems : MonoBehaviour
{
    PlayerManager[] systems;

    [NonSerialized] public PHealth myHealthSystem;

    public T GetSystems<T>() where T : PlayerManager
    {
        foreach (var manager in systems)
        {
            if (manager is T found)
            {
                return found;
            }
        }
        return null;
    }

    private void OnEnable()
    {
        myHealthSystem = GetSystems<PHealth>();
    }

    private void Awake()
    {
        systems = GetComponentsInChildren<PlayerManager>();
        foreach (PlayerManager manager in systems)
        {
            manager.Init(this);
        }
    }

    private void Update()
    {
        foreach (PlayerManager manager in systems)
        {
            manager.Tick();
        }
    }
}