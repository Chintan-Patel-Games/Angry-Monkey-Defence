using UnityEngine;
using ServiceLocator.Utilities;
using ServiceLocator.Events;
using ServiceLocator.Map;
using ServiceLocator.Wave;
using ServiceLocator.Sound;
using ServiceLocator.Player;
using ServiceLocator.UI;

namespace ServiceLocator.Main
{
    public class GameService : GenericMonoSingleton<GameService>
    {
        // Services:
        public PlayerService PlayerService { get; private set; }

        // Scriptable Objects:
        [SerializeField] private PlayerScriptableObject playerScriptableObject;

        private void Start()
        {
            PlayerService = new PlayerService(playerScriptableObject);
        }

        private void Update()
        {
            PlayerService.Update();
        }
    }
}