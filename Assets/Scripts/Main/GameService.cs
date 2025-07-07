using UnityEngine;
using ServiceLocator.Events;
using ServiceLocator.Map;
using ServiceLocator.Wave;
using ServiceLocator.Sound;
using ServiceLocator.Player;
using ServiceLocator.UI;
using ServiceLocator.Utilities;

namespace ServiceLocator.Main
{
    public class GameService : GenericMonoSingleton<GameService>
    {
        // Services:
        public EventService EventService { get; private set; }
        public SoundService SoundService { get; private set; }
        public MapService MapService { get; private set; }
        public PlayerService PlayerService { get; private set; }
        public WaveService WaveService { get; private set; }

        [SerializeField] private UIService uiService;
        public UIService UIService => uiService;


        // Scriptable Objects:
        [SerializeField] private MapScriptableObject mapScriptableObject;
        [SerializeField] private WaveScriptableObject waveScriptableObject;
        [SerializeField] private SoundScriptableObject soundScriptableObject;
        [SerializeField] private PlayerScriptableObject playerScriptableObject;

        // Scene References:
        [SerializeField] private AudioSource sfxSource;
        [SerializeField] private AudioSource bgMusicSource;

        private void Start()
        {
            InitializeServices();
            InjectDependencies();
        }

        private void InitializeServices()
        {
            EventService = new EventService();
            SoundService = new SoundService(soundScriptableObject, sfxSource, bgMusicSource);
            MapService = new MapService(mapScriptableObject);
            PlayerService = new PlayerService(playerScriptableObject);
            WaveService = new WaveService(waveScriptableObject);
        }

        private void InjectDependencies()
        {
            MapService.Init(EventService);
            UIService.Init(WaveService, PlayerService, EventService);
            PlayerService.Init(MapService, uiService, SoundService);
            WaveService.Init(uiService, MapService, PlayerService, SoundService, EventService);
        }

        private void Update()
        {
            PlayerService.Update();
        }
    }
}