/* ========================================================
 * |
 * |     作者：Tamsiree
 * |     邮箱：
 * |     创建时间：2022年11月06日 星期日 19:27:01
 * |     文件：InstallComputer_AddComponent
 * |     主要功能：
 * |     详细描述：
 * |     备注：
 * |     脚本版本：1.0
 * |     Unity版本：2020.3.32f1c1
 * |     [ Vision 1.0 ]
 * |
 *  ========================================================  */

using ET.EventType;

namespace ET
{
    public class InstallComputer_AddComponent:AEvent<EventType.InstallComputer>
    {
        protected override void Run(InstallComputer arg)
        {
            Computer computer = arg.Computer;
            computer.AddComponent<PCCaseComponent>();
            computer.AddComponent<MonitorsComponent>();
            computer.AddComponent<KeyboardComponent>();
            computer.AddComponent<MouseComponent>();
        }
    }
}