namespace ET
{
    public class AppStartInitFinish_CreateLoginUI: AEvent<EventType.AppStartInitFinish>
    {
        protected override void Run(EventType.AppStartInitFinish args)
        {
            UIHelper.Create(args.ZoneScene, UIType.UILogin, UILayer.Mid).Coroutine();

            Computer computer = args.ZoneScene.AddChild<Computer>();

            Game.EventSystem.PublishAsync(new EventType.InstallComputerAsync() { Computer = computer }).Coroutine();
            
            // Test(args.ZoneScene).Coroutine();
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
    }
}