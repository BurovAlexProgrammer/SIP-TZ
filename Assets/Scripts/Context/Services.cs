namespace Context
{
    public static class Services
    {
        // public static GameSession GameSession => GameSession.Instance;
        // public static GameUI GameUI => GameUI.Instance;
        // // public static CommonUI CommonUI => CommonUI.Instance;
        //
        // [SerializeField] private List<MonoServiceBase> _monoBaseServices;
        // private ServiceLocator<IService> _serviceLocator;
        //
        // private void Awake()
        // {
        //     _serviceLocator = new ServiceLocator<IService>();
        //     
        //     foreach (var service in _monoBaseServices)
        //     {
        //         _serviceLocator.Register(service);
        //     }
        // }
        //
        // async void Start()
        // {
        //     DontDestroyOnLoad(gameObject);
        //     var commonUI = GetService<CommonUiService>();
        //     await commonUI.SmoothShowScene();
        //     SceneManager.LoadScene(Scenes.MAIN);
        // }
        //
        // public T GetService<T>() where T : IService
        // {
        //     return _serviceLocator.Get<T>();
        // }
    }
}