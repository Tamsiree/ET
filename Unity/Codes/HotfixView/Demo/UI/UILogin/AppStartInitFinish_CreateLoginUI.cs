namespace ET
{
    public class AppStartInitFinish_CreateLoginUI: AEventAsync<EventType.AppStartInitFinish>
    {
        protected override async ETTask Run(EventType.AppStartInitFinish args)
        {
            await UIHelper.Create(args.ZoneScene, UIType.UILogin, UILayer.Mid);

            /*Computer computer = args.ZoneScene.AddChild<Computer>();

            Game.EventSystem.PublishAsync(new EventType.InstallComputerAsync() { Computer = computer }).Coroutine();*/

            // Test(args.ZoneScene).Coroutine();

            Log.Debug("aaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            // this.TestAsync().Coroutine();  
            // int result = await this.TestResultAsync();
            // Log.Debug($"result: {result}");
            
            
            Log.Debug("bbbbbbbbbbbbbbbbbbbbbbbbbbbbb");
        }

        public async ETTask Test(Scene zoneScene)
        {
            Computer computer = zoneScene.AddChild<Computer>();

            Game.EventSystem.PublishAsync(new EventType.InstallComputerAsync() { Computer = computer }).Coroutine();
            // Game.EventSystem.Publish(new EventType.InstallComputer() { Computer = computer });

            // computer.Start();

            /*computer.AddComponent<PCCaseComponent>();
            computer.AddComponent<MonitorsComponent>();
            computer.AddComponent<KeyboardComponent>();
            computer.AddComponent<MouseComponent>();

            computer.Start();
            */

            /*await TimerComponent.Instance.WaitAsync(3000);

            computer.Dispose();

            UnitConfig config = UnitConfigCategory.Instance.Get(1001);
            Log.Debug(config.Name);

            var allUnitConfig = UnitConfigCategory.Instance.GetAll();
            foreach (var unitConfig in allUnitConfig.Values)
            {
                Log.Debug(unitConfig.Name);
                Log.Debug(unitConfig.TestValue.ToString());
            }

            var heightConfig = UnitConfigCategory.Instance.GetUnitConfigByHeight(178);
            Log.Debug(heightConfig.Name);*/
        }

        public async ETTask TestAsync()
        {
            Log.Debug("11111111111111111111111111");
            await TimerComponent.Instance.WaitAsync(2000);
            Log.Debug("22222222222222222222222222");
        }

        public async ETTask<int> TestResultAsync()
        {
            Log.Debug("11111111111111111111111111");
            await TimerComponent.Instance.WaitAsync(2000);
            Log.Debug("22222222222222222222222222");

            return 10;
        }
    }
}