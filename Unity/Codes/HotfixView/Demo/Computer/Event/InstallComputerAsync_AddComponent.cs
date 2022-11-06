/* ========================================================
 * |
 * |     作者：Tamsiree
 * |     邮箱：
 * |     创建时间：2022年11月06日 星期日 21:56:06
 * |     文件：InstallComputerAsync_AddComponent
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
    public class InstallComputerAsync_AddComponent: AEventAsync<EventType.InstallComputerAsync>
    {
        protected override async ETTask Run(EventType.InstallComputerAsync arg)
        {
            Computer computer = arg.Computer;
            computer.AddComponent<PCCaseComponent>();
            computer.AddComponent<MonitorsComponent>();
            computer.AddComponent<KeyboardComponent>();
            computer.AddComponent<MouseComponent>();

            await TimerComponent.Instance.WaitAsync(3000);

            computer.Start();
        }
    }
}