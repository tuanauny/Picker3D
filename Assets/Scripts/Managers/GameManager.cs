using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using Signals;
using Enums;



namespace Managers
{
    public class GameManager : MonoBehaviour
    {
        #region Self Variables

        #region Serialized Variables

        [SerializeField] private GameStates states;

        #endregion

        #endregion


        private void OnEnable() => SubscribeEvents();

        private void SubscribeEvents()
        {
            CoreGameSignals.Instance.onChangeGameState += OnChangeGameState;
        }

        private void UnsubscribeEvents()
        {
            CoreGameSignals.Instance.onChangeGameState -= OnChangeGameState;
        }

        private void OnDisable() => UnsubscribeEvents();

        private void OnChangeGameState(GameStates state)
        {
            states = state;
        }
    }
}