/* ========================================================
 * |
 * |     作者：Tamsiree
 * |     邮箱：
 * |     创建时间：2022年10月09日 星期日 22:28:17
 * |     文件：ComputerSystem
 * |     主要功能：
 * |     详细描述：
 * |     备注：
 * |     脚本版本：1.0
 * |     Unity版本：2020.3.32f1c1
 * |     [ Vision 1.0 ]
 * |
 *  ========================================================  */

namespace ET
{
    public class ComputerAwakeSystem: AwakeSystem<Computer>
    {
        public override void Awake(Computer self)
        {
            Log.Debug("Computer Awake!!!!!");
        }
    }
    
    public class ComputerUpdateSystem: UpdateSystem<Computer>
    {
        public override void Update(Computer self)
        {
            Log.Debug("Computer Update!!!!!");
        }
    }
    
    public class ComputerDestroySystem: DestroySystem<Computer>
    {
        public override void Destroy(Computer self)
        {
            Log.Debug("Computer Destroy!!!!!");
        }
    }

    public static class ComputerSystem
    {
        public static void Start(this Computer self)
        {
            Log.Debug("Computer Start!!!!!!!!");
            self.GetComponent<PCCaseComponent>().StartPower();
            self.GetComponent<MonitorsComponent>().Display();

            // self.ZoneScene();
            self.DomainScene();

            // 不推荐
            var domain = self.Domain;
        }
    }
}