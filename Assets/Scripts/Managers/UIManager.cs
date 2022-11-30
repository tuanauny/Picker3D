using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    private void OnEnable()
    {
        SubscribeEvents();
    }

   
    
    private void SubscribeEvents()
    {
        CoreGameSignals.Instance.onLevelInitialize += OnLevelInitialize;
        CoreGameSignals.Instance.onLevelSuccessful += OnLevelSuccessful;
        CoreGameSignals.Instance.onLevelFailed += OnLevelFailed;
        CoreGameSignals.Instance.onReset += OnReset;
    }

    private void UnSubscribeEvents()
    {
        CoreGameSignals.Instance.onLevelInitialize -= OnLevelInitialize;
        CoreGameSignals.Instance.onLevelSuccessful -= OnLevelSuccessful;
        CoreGameSignals.Instance.onLevelFailed -= OnLevelFailed;
        CoreGameSignals.Instance.onReset -= OnReset;

    }

    private void OnDisable()
    {
        UnSubscribeEvents();
    }

    private void OnLevelInitialize(int levelValue)
    {
        
       
    }

    private void OnLevelSuccessful()
    {
        
    }

    private void OnLevelFailed()
    {
        
    }

    public void NextLevel()
    {
        
    }

    public void RestartLevel()
    {
        
    }

    public void Play()
    {
        
    }

    private void OnReset()
    {
        
    }


}
